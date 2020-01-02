using Microsoft.EntityFrameworkCore;
using StrorageRestApi.Data;
using StrorageRestApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Services
{
    public class ProductTypeService : IProductTypeService
    {
        private readonly DataContext _dataContext;
        public ProductTypeService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        //public async Task<Product> CheckProductTypeIsBlankAsync(string productTypeId)
        //{
        //    return await _dataContext.Product.FirstOrDefaultAsync(x => x.Type.Id == productTypeId);            
        //}

        public async Task<bool> CreateProductTypeAsync(ProductType productTypeToCreate) {
            await _dataContext.ProductType.AddAsync(productTypeToCreate);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<bool> DeleteProductTypeAsync(string productTypeId)
        {
            var productType = await GetProductTypeByIdAsync(productTypeId);
            _dataContext.ProductType.Remove(productType);
            var deleted = await _dataContext.SaveChangesAsync();
            return deleted > 0;
        }

        public async Task<ProductType> GetProductTypeByIdAsync(string productTypeId)
        {
            return await _dataContext.ProductType.SingleOrDefaultAsync(x => x.Id == productTypeId);
        }

        public async Task<ProductType> GetProductTypeByNameAsync(string productTypeName)
        {
            return await _dataContext.ProductType.SingleOrDefaultAsync(x => x.Type == productTypeName);
        }

        public async Task<List<ProductType>> GetProductTypesAsync(PaginationFilter paginationFilter=null)
        {
            if(paginationFilter == null) 
            {
                return await _dataContext.ProductType.ToListAsync();
            }

            var skip = (paginationFilter.PageNumber - 1) * paginationFilter.PageSize;
            return await _dataContext.ProductType
                .Skip(skip).Take(paginationFilter.PageSize).ToListAsync();
        }

        public async Task<bool> UpdateProductTypeAsync(ProductType productTypeToUpdate)
        {
            _dataContext.ProductType.Update(productTypeToUpdate);
            var updated = await _dataContext.SaveChangesAsync();
            return updated > 0;
        }

    }
}
