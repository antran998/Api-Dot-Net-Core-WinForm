using StrorageRestApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Services
{
    public interface IProductTypeService
    {
        Task<bool> CreateProductTypeAsync(ProductType productTypeToCreate);
        Task<List<ProductType>> GetProductTypesAsync(PaginationFilter paginationFilter=null);
        Task<ProductType> GetProductTypeByIdAsync(string productTypeId);
        Task<ProductType> GetProductTypeByNameAsync(string productTypeName);
        Task<bool> UpdateProductTypeAsync(ProductType productTypeToUpdate);
        Task<bool> DeleteProductTypeAsync(string productTypeId);
        //Task<Product> CheckProductTypeIsBlankAsync(string productTypeId);
    }
}
