using InterviewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Services.Services
{
    public class CustomerService : ICustomerService
    {

        public Customers getCustomer(int id) =>
            customers.FirstOrDefault(x => x.CustomerId == id)!;

        public bool AddCustomer(Customers customer)
        {
            customers.Add(customer);
            return true;
        }
            

        List<Customers> customers => 
            new()
            {
                new()
                {
                    CustomerId = 1,
                    CustomerName = "Ali Ahmad",
                    Age = 40
                },
                new()
                {
                    CustomerId = 2,
                    CustomerName = "Farhan Ali",
                    Age = 12
                },
                new()
                {
                    CustomerId = 3,
                    CustomerName = "Rahmat Ali",
                    Age = 30
                },
            };
    }
}
