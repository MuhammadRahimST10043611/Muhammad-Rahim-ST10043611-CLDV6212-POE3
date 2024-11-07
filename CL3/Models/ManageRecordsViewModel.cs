using System.Collections.Generic;

namespace CL3.Models
{
    public class ManageRecordsViewModel
    {
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public List<Order> Orders { get; set; }
    }
}