using Database.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Repositories.Abstracts
{
    public interface IProductCommandRepository
    {
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int productId);

        Task SaveChangesAsync();
    }
}
