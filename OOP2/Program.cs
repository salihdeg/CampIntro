using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Individual individual = new Individual();
            individual.Id = 1;
            individual.CustomerNumber = "12345";
            individual.Name = "Salih";
            individual.Surname = "Değirmenci";
            individual.TcNo = "1111111111";

            Corporate corporate = new Corporate();
            corporate.Id = 2;
            corporate.CustomerNumber = "12346";
            corporate.CompanyName = "Kodlama.io";
            corporate.VergiNo = "123456789";

            Customer customer3 = new Individual();
            Customer customer4 = new Corporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(customer3);
            customerManager.Ekle(customer4);
            customerManager.Ekle(individual);
            customerManager.Ekle(corporate);
        }
    }
}
