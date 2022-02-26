using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farming
{
   public class Farm
    {
        public string FarmName { get; set; }
        public int FarmId { get; set; }
        public string Address { get; set; }
        public Merchant Merchant { get; set; }
        public string ImageFileName { get; set; }
        public IEnumerable<FarmProduct> FarmProduce { get; set; }
        public IEnumerable<Customer> Customer { get; set; }
    }
}
