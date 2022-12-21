using FluentValidation;
using WebApi.Models.AddCustomer;

namespace WebApi.Models.AddCostumer
{
    public class AddCustomerInputValidator : AbstractValidator<AddCustomerInput>
    {
        public AddCustomerInputValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Email).EmailAddress();
            RuleFor(c => c.Document).IsValidCPF().WithMessage("'Document' é um CPF invalido.");
        }
    }
}
