using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProductShop.Dtos.Export
{

    public class ExportUserAndProductsDto
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("users")]
        public ExportUserDto[] Users { get; set; }
    }

    [XmlType("User")]
    public class ExportUserDto
    {
        [XmlElement("firstName")]
        public string FirstName { get; set; }

        [XmlElement("lastName")]
        public string LastName { get; set; }

        [XmlElement("age")]
        public int? Age { get; set; }

        [XmlElement("SoldProducts")]
        public ExportProductCountDto SoldProduct { get; set; }
    }

    [XmlType("SoldProducts")]
    public class ExportProductCountDto
    {
        [XmlElement("count")]
        public int Count { get; set; }

        [XmlArray("products")]
        public ExportProductDTO[] Products { get; set; }
    }

    [XmlType("Product")]
    public class ExportProductDTO
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public decimal Price { get; set; }
    }
}