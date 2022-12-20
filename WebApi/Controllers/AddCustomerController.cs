using Domain.Contracts.UseCases.AddCustomer;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.AddCustomer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        private readonly IAddCustomerUseCase _addCustomerUseCase;

        public AddCustomerController(IAddCustomerUseCase addCustomerUseCase)
        {
            _addCustomerUseCase = addCustomerUseCase;
        }

        [HttpPost]
        public IActionResult AddCostumer(AddCustomerInput input)
        {
            var customer = new Domain.Entities.Customer(input.Name, input.Email, input.Document);
            _addCustomerUseCase.AddCustomer(customer);

            return Created("", input);
        }
    }
}
