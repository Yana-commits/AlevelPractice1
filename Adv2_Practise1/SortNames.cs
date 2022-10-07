using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv2_Practise1
{
    class SortNames : IComparer<Customer>
    {
        public int Compare(Customer cust1, Customer cust2)
        {
            if (cust1 is null || cust2 is null)
                throw new ArgumentException("No customers");

            return cust1.Name - cust2.Name;
        }
    }
}
