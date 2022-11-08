using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_First
{
    internal class Company
    {
        public Company(string name, Address address, Person director, int numberOfEmployees)
        {
            Name = name;
            Address = address;
            Director = director;
            NumberOfEmployees = numberOfEmployees;
        }
        public string Name { get;  }
        public Address Address { get; set; }
        public Person Director { get; set; }

        public int NumberOfEmployees { get; set; }


        public string DisplayCompanyInfo()
        {
            return ("Name: " + Name + ";\n" + "Address of company: " + "\n" + Address.GetAddress() + ";\n" + "Information about director: " + "\n" + Director.DisplayPersonalInfo() + "\n" + "NumberOfEmployees: " + NumberOfEmployees + ";");
        }

        public void changeDirectory(Person newDirector) 
        {
            Director = newDirector;   
        }
        public void Hire(Person newPerson)
        {
             NumberOfEmployees = NumberOfEmployees+1;
            if(newPerson.JobTitle == "director")
            {
                Director = newPerson;
            }
        }

    }
}
