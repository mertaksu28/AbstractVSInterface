using AbstractInterface.Entities;
using System;

namespace AbstractInterface.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Veritabanına Kaydedildi: " + customer.FirstName);
        }
    }
}
