using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace CarDealer.Dtos.Import
{   
    [XmlType("Car")]
    public class ImportCarsDto
    {
        [XmlElement("make")]
        public string Make { get; set; }

        [XmlElement("model")]
        public string Model { get; set; }

        [XmlElement("TraveledDistance")]
        public long TraveledDistance { get; set; }

        [XmlArray("parts")]
        public ImportCarPart[] Parts { get; set; }
    }

    [XmlType("partId")]
    public class ImportCarPart
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}
