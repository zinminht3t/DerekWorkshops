using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop4
{
    class Customer
    {
        string name;
        string address;
        string passport;
        DateTime dateofbirth;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Passport
        {
            get { return passport; }
            set { passport = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateofbirth; }
            set { dateofbirth = value; }
        }
        public Customer(string name, string address, string passport, DateTime dateofbirth)
        {
            this.name = name;
            this.address = address;
            this.passport = passport;
            this.dateofbirth = dateofbirth;
        }
        public int GetAge()
        {
            return DateTime.Today.Year - dateofbirth.Year;
        }

    }
}
