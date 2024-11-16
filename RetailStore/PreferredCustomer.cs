using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStore
{
    class PreferredCustomer : Customer
    {
        public int _purchaseAmount;
        public decimal _discountLevel;

        public PreferredCustomer()
        {
            _purchaseAmount = 0;
            _discountLevel = 0;
        }

        public int PurchaseAmount { get; set; }
        public decimal DiscountLevel { get; set; }  
    }
}
