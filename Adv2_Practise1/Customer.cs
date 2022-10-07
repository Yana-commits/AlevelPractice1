using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv2_Practise1
{
    public class Customer
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public float Coins { get; set; }
        public List<string> Purchases { get; set; }
    }
}
