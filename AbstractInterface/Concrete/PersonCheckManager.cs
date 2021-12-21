using AbstractInterface.Abstract;
using AbstractInterface.Entities;

namespace AbstractInterface.Concrete
{
    class PersonCheckManager : IPersonCheckService
    {//Mernise de bağımlı olmadığım fake bir service kullandım
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
