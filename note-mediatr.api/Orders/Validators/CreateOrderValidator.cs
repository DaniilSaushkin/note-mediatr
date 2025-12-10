using FluentValidation;
using note_mediatr.api.Orders.Commands;

namespace note_mediatr.api.Orders.Validators
{
    public class CreateOrderValidator : AbstractValidator<CreateOrderCommand>
    {
        private readonly decimal _minimumAmount = 0;

        public CreateOrderValidator()
        {
            RuleFor(x => x.Amount).GreaterThan(_minimumAmount);
            RuleFor(x => x.CustomerName).MinimumLength(2);
        }
    }
}
