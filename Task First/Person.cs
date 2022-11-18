using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace Task_First
{
    internal class Person
    {

        public Person(string firstName, string lastName, int age, Address address, string jobTitle)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            JobTitle = jobTitle;
            Address = address;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public Address Address { get; set; }
        public string JobTitle { get; set; }


        public string DisplayPersonalInfo()
        {
            return ("FirstName: " + FirstName + ";\n" + "LastName: " + LastName + ";\n" + "Age: " + Age + ";\n" + Address.GetAddress() + ";\n" + "JobTitle: " + JobTitle);
        }
        
        public void ChangeAddress(Address newAddress)
        {
            Address = newAddress;
        }

    }
}
    
