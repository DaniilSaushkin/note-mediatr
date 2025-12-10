using FluentValidation;
using note_mediatr.api.Common;
using note_mediatr.api.Products.Commands;

namespace note_mediatr.api.Products.Validators
{
    public class CreateProductValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull();
            RuleFor(x => x.Price).GreaterThan(Consts.MinimalPrice);
        }
    }
}
