using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrorageRestApi.Data;
using StrorageRestApi.Domain;

namespace StrorageRestApi.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;
        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> CreateProductAsync(Product productToCreate)
        {
            await _dataContext.Product.AddAsync(productToCreate);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> DeleteProductAsync(string productId)
        {
            var productType = await GetProductByIdAsync(productId);
            _dataContext.Product.Remove(productType);
            var deleted = await _dataContext.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<Product> GetProductByIdAsync(string productId)
        {
            return await _dataContext.Product.SingleOrDefaultAsync(x => x.Id == productId);
        }

        public async Task<Product> GetProductByNameAsync(string productName)
        {
            return await _dataContext.Product.SingleOrDefaultAsync(x => x.ProductName == productName);
        }

        public async Task<List<Product>> GetProductsAsync(PaginationFilter paginationFilter = null)
        {
            if (paginationFilter == null)
            {
                return await _dataContext.Product.ToListAsync();
            }

            var skip = (paginationFilter.PageNumber - 1) * paginationFilter.PageSize;
            return await _dataContext.Product
                .Skip(skip).Take(paginationFilter.PageSize).ToListAsync();
        }

        public async Task<List<Product>> GetProductsByTypeAsync(string productTypeId, PaginationFilter paginationFilter = null)
        {
            if (paginationFilter == null)
            {
                return await _dataContext.Product.Where(x => x.TypeId == productTypeId).ToListAsync();
            }

            var skip = (paginationFilter.PageNumber - 1) * paginationFilter.PageSize;
            return await _dataContext.Product
                .Where(x => x.TypeId == productTypeId)
                .Skip(skip).Take(paginationFilter.PageSize).ToListAsync();
        }

        public async Task<bool> UpdateProductAsync(Product productToUpdate)
        {
            _dataContext.Product.Update(productToUpdate);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }
    }
}
