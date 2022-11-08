using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_First
{
    public class Address
    {
        public Address(string country, string city, string street, int buildingNumber, int postalCode)
        {
            Country = country;
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
            PostalCode = postalCode;
        }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int BuildingNumber { get; set; }
        public int PostalCode { get; set; }

        public string GetAddress()
        {
            return (Country + ";" + City + ";" + Street + ";" + BuildingNumber + ";" + PostalCode);
        }

    }
}
