using Task1_ASP.NET_Core_API.Services;
using Task1_ASP.NET_Core_API.Services.EmpolyeeServices;

namespace Task1_ASP.NET_Core_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProspectController : ControllerBase
    {
        private readonly IProspectServices _prospectServices;

        public ProspectController(IProspectServices empolyeeServices)
        {
            _prospectServices = empolyeeServices;
        }
        [HttpGet]
        public async Task<IEnumerable<Prospect>> Get() => await _prospectServices.GetAll();

        [HttpGet("{id}")]
        public async Task<Prospect> Get(int id) =>  await _prospectServices.GetById(id);
            //await _prospectServices.GetById(id);

        [HttpPost]
        public async Task Post([FromForm] Prospect prospect) => await _prospectServices.Add(prospect);

        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Prospect prospect)
        {
            await _prospectServices.Add(prospect);
        }

        [HttpDelete("{id}")]
        public async void Delete(int id)
        {
            var prospectFromDb = await _prospectServices.GetById(id);
            _prospectServices.Delete(prospectFromDb);
        }
    }
}
