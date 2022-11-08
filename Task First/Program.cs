using System.Net;
using System.Security.Cryptography.X509Certificates;
using Task_First;



public class Test
{
    static void Main()
    {
        var address = new Address("Country1", "City1", "Street1", 1, 11111);
        var newAddress = new Address("Country2", "City2", "Street2", 2, 22222);
        Person myPerson = new Person("FirstName1", "LastName1", 25, address, "dev");
        myPerson.ChangeAddress(newAddress);
        Console.WriteLine(myPerson.DisplayPersonalInfo());
    


        var addressOfCompany = new Address("Country3", "City3", "Street3", 3, 33333);
        var addressOfDirector = new Address("Country4", "City4", "Street4", 4, 44444);
        var informationOfDirector = new Person("Director", "DirectorFirst", 25, addressOfDirector, "director");
        var informationOfCompany = new Company("MyCompany", addressOfCompany, informationOfDirector, 50);
        var newDirector = new Person("Director", "DirectorSecond", 23, addressOfDirector, "director");
        var newEmployeer = new Person("NewPerson", "NewPerson", 25, addressOfDirector, "director");
        informationOfCompany.changeDirectory(newDirector);
        informationOfCompany.Hire(newEmployeer);
        Console.WriteLine(informationOfCompany.DisplayCompanyInfo());
    }
}