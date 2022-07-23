using Task1_ASP.NET_Core_API.Services;
namespace Task1_ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices) => _customerServices = customerServices;
        [HttpGet]
        public async Task<IEnumerable<Customer>> Get() => await _customerServices.GetAll();

        [HttpGet("{id}")]
        public async Task<Customer> Get(int id) => await _customerServices.GetById(id);

        [HttpPost]
        public async Task Post([FromForm] Customer customer) => await _customerServices.Add(customer);

        [HttpPut("{id}")]
        public async Task Put(int id, [FromForm] Customer customer) => await _customerServices.Add(customer);

        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var customerFromDb = await _customerServices.GetById(id);
            _customerServices.Delete(customerFromDb);
        }
    }
}
