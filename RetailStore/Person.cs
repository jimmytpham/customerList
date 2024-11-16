using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    class Person
    {
        public string _name;
        public string _address;
        public string _phoneNumber;

        public Person()
        {
            _name = "";
            _address = "";
            _phoneNumber = "";
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    
    }
}
