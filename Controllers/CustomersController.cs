using System.Threading.Tasks;
using GraphqlWallets.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace GraphqlWallets.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly CustomerRepository _repository;

        public CustomersController(CustomerRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Get()
        {
            var customers = await _repository.GetAll();
            return Ok(customers);
        }
    }
}