using CoreApiRepo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiRepo.Repository
{
    public class CustomerRepository : ICustomterRepository
    {
        Response ICustomterRepository.CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
      
        Response ICustomterRepository.GetCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
