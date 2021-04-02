using CarDealer.Data;
using CarDealer.Dtos.Export;
using CarDealer.Dtos.Import;
using CarDealer.Models;
using ProductShop.XMLHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //var xml = File.ReadAllText("../../../Datasets/cars.xml");
            //var result = ImportCars(context, xml);

            var context = new CarDealerContext();


            var result = GetSalesWithAppliedDiscount(context);
            File.WriteAllText("../../../Results/sales-discounts.xml", result);

            Console.WriteLine(result);

        }

        //2.Import Data
        //09. Import Suppliers
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            var suppliersDtos = XMLConverter.Deserializer<ImportSuppliersDto>(inputXml, "Suppliers");

            var result = suppliersDtos.Select(s => new Supplier
            {
                Name = s.Name,
                IsImporter = s.IsImporter
            }).ToList();

            context.Suppliers.AddRange(result);
            context.SaveChanges();

            return $"Successfully imported {result.Count}";
        }

        //10. Import Parts
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            var partsDtos = XMLConverter.Deserializer<ImportPartsDto>(inputXml, "Parts");

            var result = partsDtos
                .Where(i => context.Suppliers.Any(s => s.Id == i.SupplierId))
                .Select(x => new Part
                {
                    Name = x.Name,
                    Price = x.Price,
                    Quantity = x.Quantity,
                    SupplierId = x.SupplierId
                }).ToList();

            context.Parts.AddRange(result);
            context.SaveChanges();
            return $"Successfully imported {result.Count}";
        }

        //11. Import Cars
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            var root = "Cars";
            var carsDtos = XMLConverter.Deserializer<ImportCarsDto>(inputXml, root);

            List<Car> cars = new List<Car>();

            foreach (var carDto in carsDtos)
            {
                var uniqueParts = carDto.Parts.Select(s => s.Id).Distinct().ToArray();
                var realParts = uniqueParts.Where(id => context.Parts.Any(i => i.Id == id));

                var car = new Car
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledDistance = carDto.TraveledDistance,
                    PartCars = realParts.Select(id => new PartCar
                    {
                        PartId = id
                    })
                    .ToArray()
                };
                cars.Add(car);
            }

            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }

        //12. Import Customers
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            var root = "Customers";
            var customersDtos = XMLConverter.Deserializer<ImportCustomersDto>(inputXml, root);

            var result = customersDtos
                .Select(x => new Customer
                {
                    Name = x.Name,
                    BirthDate = DateTime.Parse(x.BirthDate),
                    IsYoungDriver = x.IsYourDriver

                }).ToList();

            context.Customers.AddRange(result);
            context.SaveChanges();

            return $"Successfully imported {result.Count}";
        }

        //13. Import Sales
        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            var root = "Sales";
            var salesDto = XMLConverter.Deserializer<ImportSalesDto>(inputXml, root);

            var result = salesDto
                .Where(i => context.Cars.Any(x => x.Id == i.CarId))
                .Select(x => new Sale
                {
                    CarId = x.CarId,
                    CustomerId = x.CustomerId,
                    Discount = x.Discount
                }).ToList();

            context.Sales.AddRange(result);
            context.SaveChanges();

            return $"Successfully imported {result.Count}";
        }

        //3.Query and Export Data
        //14. Cars With Distance
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(x => x.TravelledDistance > 2000000)
                .Select(x => new ExportCarsWithDistanceDto
                {
                    Make = x.Make,
                    Model = x.Model,
                    TravelledDistance = x.TravelledDistance
                })
                .OrderBy(x => x.Make)
                .ThenBy(x => x.Model)
                .Take(10)
                .ToList();

            var root = "cars";
            var xml = XMLConverter.Serialize(cars, root);

            return xml;
        }

        //15. Cars from make BMW
        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "BMW")
                .Select(c => new ExportCarsFromMakeBMWDto
                {
                    Id = c.Id,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .ToArray();

            var root = "cars";
            var xml = XMLConverter.Serialize(cars, root);
            return xml;
        }

        //16. Local Suppliers
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(x => !x.IsImporter)
                .Select(x => new ExportLocalSuppliersDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    PartsCount = x.Parts.Count(p => p.Quantity > 0)
                }).ToList();

            var root = "suppliers";
            var xml = XMLConverter.Serialize(suppliers, root);

            return xml;
        }

        //17. Cars with Their List of Parts
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var cars = context.Cars
                .Select(x => new ExportCarsWithTheirListOfPartsDto
                {
                    CarMake = x.Make,
                    Model = x.Model,
                    TravelledDistance = x.TravelledDistance,
                    Parts = x.PartCars.Select(p => new PartsDto
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price
                    }).OrderByDescending(p => p.Price)
                    .ToArray()
                })
                .OrderByDescending(x => x.TravelledDistance)
                .ThenBy(x => x.Model)
                .Take(5)
                .ToArray();

            var root = "cars";
            var xml = XMLConverter.Serialize(cars, root);

            return xml;
        }

        //18. Total Sales by Customer
        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var customers = context.Customers
                .Where(c => c.Sales.Count() > 0)
                .Select(x => new ExportTotalSalesByCustomerDto
                {
                    FullName = x.Name,
                    BoughtCars = x.Sales.Count(),
                    SpentMoney = x.Sales.Sum(s => s.Car.PartCars.Sum(pc => pc.Part.Price))
                })
                .OrderByDescending(c => c.SpentMoney)
                .ThenByDescending(c => c.BoughtCars)
                .ToArray();

            var root = "customers";
            var xml = XMLConverter.Serialize(customers, root);
            return xml;
        }

        //19. Sales with Applied Discount
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var sales = context.Sales
                .Select(s => new SalesWithAppliedDiscountDto
                {
                    Car = new SaleCarDTO
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance
                    },
                    Discount = s.Discount,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartCars.Sum(pc => pc.Part.Price),
                    PriceWithDiscount = s.Car.PartCars.Sum(pc => pc.Part.Price) - (s.Car.PartCars.Sum(pc => pc.Part.Price) * s.Discount / 100)

                })
                .ToArray();

            var root = "sales";
            var xml = XMLConverter.Serialize(sales, root);
            return xml;
        }

    }
}