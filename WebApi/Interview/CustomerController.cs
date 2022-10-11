using Interview.Services.Services;
using InterviewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Interview
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService CustomerService { get; }
        public CustomerController(ICustomerService custService)
        {
            CustomerService = custService;
        }


        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customers Get(int id)
        {
            return this.CustomerService.getCustomer(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public void Post([FromBody] Customers customer)
        {
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
