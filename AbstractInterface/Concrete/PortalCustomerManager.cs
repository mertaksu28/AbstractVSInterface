using AbstractInterface.Abstract;
using AbstractInterface.Entities;

namespace AbstractInterface.Concrete
{//İki firmayı firma Id' si ile dağıtacağımızı varsayarız.
    public class PortalCustomerManager : BaseCustomerManager
    {
        //İlerde Portal da isterse dependency injection ile rahatlıkla onda doğrulama getirebiliriz.
        public override void Save(Customer customer)
        {
            base.Save(customer);
        }
    }
}
