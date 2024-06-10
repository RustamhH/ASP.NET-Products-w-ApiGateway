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
    internal class ProductCommandRepository : IProductCommandRepository
    {
        private readonly AppDbContext _context;
        
        public ProductCommandRepository(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task AddProductAsync(Product product)
        {
            await _context.Set<Product>().AddAsync(product);
            SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int productId)
        {
            var product=await _context.Set<Product>().FirstOrDefaultAsync(product=>product.Id==productId);
            _context.Set<Product>().Remove(product);
            SaveChangesAsync();

        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Set<Product>().Update(product);
            SaveChangesAsync();
        }



    }
}
