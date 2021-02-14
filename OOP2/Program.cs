using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gerçek Kişi
            Individual customer1=new Individual();

            customer1.Id = 1;
            customer1.FirstName = "ibrahim";
            customer1.LastName = "Durmaz";
            customer1.CustomerNumber = "12345";
            customer1.NationalityId = "01234567890";


            //Tüzekl Kişi
            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CompanyName = "Kodlama.io";
            customer2.CustomerNumber = "67890";
            customer2.TaxId = "1234567890";

            //Base class
            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer4);
        }
    }
}
