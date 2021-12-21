using AbstractInterface.Abstract;
using AbstractInterface.Entities;
using System;

namespace AbstractInterface.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {

        IPersonCheckService _personCheckService;

        public StarbucksCustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Gerçek Kişi Değil.");
            }


        }
    }
}
