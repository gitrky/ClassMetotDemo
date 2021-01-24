using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer();
            newCustomer.Id = 11853; 
            newCustomer.Name = "Ayşe";
            newCustomer.Surname = "Turan";
            newCustomer.PhoneNumber = 555555555; 
            newCustomer.Location = "Bursa";

            Customer newCustomer2 = new Customer();
            newCustomer2.Id =  11854;
            newCustomer2.Name = "Merih";
            newCustomer2.Surname = "Şah";
            newCustomer2.PhoneNumber =111111111;
            newCustomer2.Location = "İstanbul";

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(newCustomer2);
            Console.WriteLine("***********************");
            customerManager.Delete(newCustomer);
            Console.WriteLine("*****************************");
            customerManager.ListCustomer(newCustomer2);


        }
    }
}
