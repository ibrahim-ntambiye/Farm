using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farming
{
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public Farm Farm { get; set; }
        public decimal PriceTotal { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<FarmProduct> Product { get; set; }
        public DateTime CDeadline { get; set; }
        public DateTime MDeadline { get; set; }

        public Order()
        {
            Date = DateTime.Now;
        }
    }
}
