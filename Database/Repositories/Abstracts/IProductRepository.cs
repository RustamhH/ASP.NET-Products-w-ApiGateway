using Database.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Abstracts
{
    public interface IProductRepository
    {
        Task<ICollection<Product>> GetAllProductsAsync();
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int productId);
        Task<Product> GetProductById(int id);
        Task SaveChangesAsync();
    }
}
