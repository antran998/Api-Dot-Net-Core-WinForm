using StrorageRestApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Services
{
    public interface IProductService
    {
        Task<bool> CreateProductAsync(Product productToCreate);
        Task<List<Product>> GetProductsAsync(PaginationFilter paginationFilter = null);
        Task<Product> GetProductByIdAsync(string productId);
        Task<Product> GetProductByNameAsync(string productName);
        Task<bool> UpdateProductAsync(Product productToUpdate);
        Task<bool> DeleteProductAsync(string productId);
        Task<List<Product>> GetProductsByTypeAsync(string productTypeId,PaginationFilter paginationFilter = null);
    }
}
