using ProductShop.Data;
using ProductShop.Dtos.Export;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using ProductShop.XMLHelper;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ProductShopContext context = new ProductShopContext();

            //var xml = File.ReadAllText("../../../Datasets/categories-products.xml");


            var getResults = GetUsersWithProducts(context);
            File.WriteAllText("../../../Results/users-and-products.xml", getResults);
            Console.WriteLine(getResults);
        }

        //reset and create database
        public static void ResetDatabase(ProductShopContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }

        //1.Import Data
        //01. Import Users
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportUserDto[]), new XmlRootAttribute("Users"));

            var deserilizer = (ImportUserDto[])serializer.Deserialize(new StringReader(inputXml));

            var users = deserilizer
                .Select(x => new User
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Age = x.Age
                }).ToList();

            context.AddRange(users);
            context.SaveChanges();

            return $"Successfully imported {users.Count}";
        }

        //02. Import Products
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportProductDto[]), new XmlRootAttribute("Products"));

            var deserilizer = (ImportProductDto[])serializer.Deserialize(new StringReader(inputXml));


            var products = deserilizer
                .Select(x => new Product
                {
                    Name = x.Name,
                    Price = x.Price,
                    BuyerId = x.BuyerId,
                    SellerId = x.SellerId
                }).ToList();

            context.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Count}";

        }

        //03. Import Categories
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCategoryDto[]), new XmlRootAttribute("Categories"));

            var deserializer = (ImportCategoryDto[])serializer.Deserialize(new StringReader(inputXml));

            var categoties = deserializer.Select(x => new Category { Name = x.Name }).ToList();

            context.AddRange(categoties);
            context.SaveChanges();

            return $"Successfully imported {categoties.Count}";
        }

        //04. Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var serializer = new XmlSerializer(typeof(ImportCategoryProductDto[]), new XmlRootAttribute("CategoryProducts"));

            var deserializer = (ImportCategoryProductDto[])serializer.Deserialize(new StringReader(inputXml));

            var categoryProducts = deserializer
                .Where(x => context.Categories.Any(y => y.Id == x.CategoryId) && context.Products.Any(y => y.Id == x.ProductId))
                .Select(x => new CategoryProduct
                {
                    CategoryId = x.CategoryId,
                    ProductId = x.ProductId
                }).ToList();

            context.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Count}";
        }

        //2.Query and Export Data
        //05. Products In Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                 .Select(p => new ExportProductDto
                 {
                     Name = p.Name,
                     Price = p.Price,
                     Buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                 })
                .OrderBy(p => p.Price)
                .Take(10)
                .ToArray();


            var root = "Products";

            var xmlProducts = XMLConverter.Serialize(products, root);
            return xmlProducts;
        }

        //06. Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var user = context.Users
                .Where(x => x.ProductsSold.Any())
                .Select(x => new ExportUsersDto
                {

                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    SoldProducts = x.ProductsSold.Select(s => new ProductDto
                    {
                        Name = s.Name,
                        Price = s.Price
                    }).ToArray()
                })
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .Take(5)
                .ToArray();

            var root = "Users";

            var xmlUserProducts = XMLConverter.Serialize(user, root);

            return xmlUserProducts;
        }

        //07. Categories By Products Count
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            //Get all categories.
            //For each category select its name,
            //the number of products,
            //the average price of those products
            //and the total revenue(total price sum) of those products(regardless if they have a buyer or not).
            //Order them by the number of products(descending) then by total revenue.

            var categories = context.Categories
                .Select(x => new ExportCategoryDto
                {
                    Name = x.Name,
                    Count = x.CategoryProducts.Count,
                    AveragePrice = x.CategoryProducts.Average(p => p.Product.Price),
                    TotalRevenue = x.CategoryProducts.Where(b => b.Product.BuyerId != 0).Sum(p => p.Product.Price)
                })
                .OrderByDescending(x => x.Count)
                .ThenBy(x => x.TotalRevenue)
                .ToArray();

            var root = "Categories";

            var xmlcategories = XMLConverter.Serialize(categories, root);

            return xmlcategories;
        }

        //08. Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                 .AsEnumerable()
                 .Where(u => u.ProductsSold.Any())
                 .Select(u => new UserDTO
                 {
                     FirstName = u.FirstName,
                     LastName = u.LastName,
                     Age = u.Age,
                     SoldProduct = new UserSoldProductDTO
                     {
                         Count = u.ProductsSold.Count,
                         Products = u.ProductsSold.Select(ps => new ProductDTO
                         {
                             Name = ps.Name,
                             Price = ps.Price
                         })
                         .OrderByDescending(p => p.Price)
                         .ToArray()
                     }
                 })
                 .OrderByDescending(p => p.SoldProduct.Count)
                 .Take(10)
                 .ToArray();

            var result = new ExportUserAndProductsDto
            {
                Count = context.Users.Count(u => u.ProductsSold.Any()),
                Users = users
            };

            var root = "Users";
            var xml = XMLConverter.Serialize(result, root);
            return xml;
        }
    }
}