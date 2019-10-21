using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faraday_Contract
{
    public class Customer
    {

        private string driversLicense;
        private string name;

        public Customer()
        {

        }

        public Customer(string diversLicense, string name)
        {
            this.DriversLicense = DriversLicense;
            this.Name = name;
        }

        public string DriversLicense { get => driversLicense; set => driversLicense = value; }
        public string Name { get => name; set => name = value; }

    }
}
