using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiRepo.Models
{
    public class Customer
    {
        private int _noofOrders;
        public String CustomerID { get; set; }
        public string CustomerName { get; set; }
      

        public Customer(int noofOrders, string _CustomerName)
        {
            _noofOrders = noofOrders;
            CustomerID = Guid.NewGuid().ToString();
            CustomerName = _CustomerName;
        }

        public Customer()
        {
        }
    }

}
