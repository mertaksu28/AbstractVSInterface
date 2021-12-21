using AbstractInterface.Abstract;
using AbstractInterface.Entities;
using ServiceReference1;
using System;
using System.Globalization;

namespace AbstractInterface.Adapters
{
    public class MernisServiceAdapter : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            var locale = new CultureInfo("tr-TR", false);
            var svc = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            {
                var cmd = svc.TCKimlikNoDogrulaAsync(Convert.ToInt64(customer.NationalityId), customer.FirstName, customer.LastName, customer.BirthDay.Year);
                return cmd.Result.Body.TCKimlikNoDogrulaResult;
            };
        }
    }
}
