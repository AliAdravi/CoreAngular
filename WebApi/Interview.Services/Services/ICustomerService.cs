using InterviewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Services.Services
{
    public interface ICustomerService
    {
        Customers getCustomer(int id);

        bool AddCustomer(Customers customer);
    }
}
