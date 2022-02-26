using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farming
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Order> OrderCollection { get; set; }
        public string ContactInformation { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}

