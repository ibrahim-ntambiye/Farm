using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farming
{
    public abstract class FarmProduct
    {
        virtual int NumberAtFarm { get; set; }
        public string Breed { get; set; }
        public string Age { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        public string ProductDescription { get; set; }
        public string ImageFileName { get; set; }
        public IEnumerable<Order> ListOFOrders { get; set; }
        public Farm Farm { get; set; }

    }
}
