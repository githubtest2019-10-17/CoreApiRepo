using CoreApiRepo.Models;
using System.Threading.Tasks;

namespace CoreApiRepo.Repository
{
    public interface ICustomterRepository
    {
        Response GetCustomers();
        // Add require implemetation to Get the Customer object in Memory Singleton Object

        Response CreateCustomer(Customer customer);
        // Add require implemetation to Save the Customer object in Memory

        // If possible Please Add GetCustomer method in Repository taking as ID as param

    }
}