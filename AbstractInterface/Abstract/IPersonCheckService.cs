using AbstractInterface.Entities;

namespace AbstractInterface.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
