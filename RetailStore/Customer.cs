using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    class Customer : Person
    {
        private string _customerNumber;
        private bool _mailingList;

        public Customer()
        {
            _customerNumber = "";
            _mailingList = false;
        }

        public string CustomerNumber { get; set; }
        public bool MailingList { get; set; }
    }
}
