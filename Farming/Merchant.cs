using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farming
{
    public class Merchant
    {
        public int MerchantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Customer> CollectionOfCustomers { get; set; }
        public string ContactInformation { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public IEnumerable<Farm> FarmsOwned { get; set; }
    }
}
