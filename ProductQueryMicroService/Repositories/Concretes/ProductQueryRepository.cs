using Database.Contexts;
using Database.Entities.Concretes;
using Database.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Concretes
{
    internal class ProductQueryRepository : IProductQueryRepository
    {
        private readonly AppDbContext _context;
        
        public ProductQueryRepository(AppDbContext context)
        {
            _context = context;
        }
        
        
        public async Task<ICollection<Product>> GetAllProductsAsync()
        {
            return await _context.Set<Product>().ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Set<Product>().FirstOrDefaultAsync(product => product.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
