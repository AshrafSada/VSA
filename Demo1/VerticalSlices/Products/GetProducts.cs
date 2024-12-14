using Demo1.Data;
using Demo1.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Demo1.VerticalSlices.Products;

public static class GetProducts
{
    public record Query(int Id) : IRequest<IEnumerable<Product>>;

    public class Handler : IRequestHandler<Query, IEnumerable<Product>>
    {
        private readonly AppDbContext _context;

        public Handler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> Handle(Query request, CancellationToken cancellationToken)
        {
            if (request.Id > 0)
            {
                return await _context.Products.Where(p => p.Id == request.Id).ToListAsync();
            }
            return await _context.Products.ToListAsync();
        }
    }

}
