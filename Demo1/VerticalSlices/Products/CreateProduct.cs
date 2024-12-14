using Demo1.Data;
using Demo1.Models;
using FluentValidation;
using MediatR;

namespace Demo1.VerticalSlices.Products;

public class CreateProduct
{
    public class Command : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }

    public class CommandValidator : AbstractValidator<Command>
    {
        public CommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty().MaximumLength(100);
            RuleFor(c => c.Price).GreaterThanOrEqualTo(0);
        }
    }

    public class Handler : IRequestHandler<Command, int>
    {
        private readonly AppDbContext _context;
        private readonly IValidator<Command> _validator;

        public Handler(AppDbContext context, IValidator<Command> validator)
        {
            _context = context;
            _validator = validator;
        }

        public async Task<int> Handle(Command request, CancellationToken cancellationToken)
        {
            var validationResult = _validator.Validate(request);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product.Id;
        }
    }
}
