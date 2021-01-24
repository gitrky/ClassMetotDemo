using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer newCustomer)
        {
            Console.WriteLine(newCustomer.Name+" "+newCustomer.Surname+
                " : Ad ve soyadına sahip yeni müşteri eklendi.");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Id+ ". Müşteri silindi  ");

        }
        public void ListCustomer( Customer customer )
        {
            Console.WriteLine(customer.Id + ". müşteri bilgileri: ");
            Console.WriteLine("Müşteri adı-soyadı : "+customer.Name +" "
                +customer.Surname+"\n" 
                +"Müşteri telefon numarası:  "+ customer.PhoneNumber +"\n" 
                +"Müşterinin yaşadığı il: "+customer.Location);


        }
    }
}
