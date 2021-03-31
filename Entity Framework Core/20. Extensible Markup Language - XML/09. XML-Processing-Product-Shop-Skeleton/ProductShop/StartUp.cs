using ProductShop.Data;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ProductShopContext context = new ProductShopContext();

            var xml = File.ReadAllText("../../../Datasets/categories-products.xml");


            var result = ImportCategoryProducts(context, xml);
            System.Console.WriteLine(result);        
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

            return$"Successfully imported {users.Count}";
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
    }
}