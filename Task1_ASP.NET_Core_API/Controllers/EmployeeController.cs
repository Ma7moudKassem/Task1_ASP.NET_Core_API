using Task1_ASP.NET_Core_API.Services.EmpolyeeServices;

namespace Task1_ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpolyeeServices _empolyeeServices;

        public EmployeeController(IEmpolyeeServices empolyeeServices) => _empolyeeServices = empolyeeServices;
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get() =>await _empolyeeServices.GetAll();

        [HttpGet("{id}")]
        public async Task<Employee> Get(int id) =>await _empolyeeServices.GetById(id);

        [HttpPost]
        public async Task Post([FromForm] Employee employee)=> await _empolyeeServices.Add(employee);

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Employee employee)
        {
            await _empolyeeServices.Add(employee);
        }

        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var empolyeeFromDb =await _empolyeeServices.GetById(id);
            _empolyeeServices.Delete(empolyeeFromDb);
        }
    }
}
