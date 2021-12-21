using AbstractInterface.Abstract;
using AbstractInterface.Adapters;
using AbstractInterface.Concrete;
using AbstractInterface.Entities;
using System;

namespace AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {                                               //PortalCustomerManager
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { BirthDay = new DateTime(1234, 8, 2), FirstName = "Mert", LastName = "AKSU", NationalityId = "1312323" });
        }
    }
}
