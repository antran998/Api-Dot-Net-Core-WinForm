using Refit;
using Storage.Contracts.v1.Requests;
using Storage.Contracts.v1.Requests.Queries;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1.Requests;
using StrorageRestApi.Contracts.v1.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Storage.sdk
{
    [Headers("Authorization: Bearer")]
    public interface IStorageApi
    {
        // Product type goes here

        [Get("/api/v1/productTypes")]
        Task<ApiResponse<PagedResponse<ProductTypeResponse>>> GetAllAsync(PaginationQuery paginationQuery);

        [Get("/api/v1/productTypes/{productTypeName}")]
        Task<ApiResponse<ProductTypeResponse>> GetAsync(string productTypeName);

        [Post("/api/v1/productTypes")]
        Task<ApiResponse<ProductTypeResponse>> CreateAsync([Body] CreateProductTypeRequest createProductTypeRequest);

        [Put("/api/v1/productTypes/{productTypeId}")]
        Task<ApiResponse<ProductTypeResponse>> UpdateAsync(string productTypeId, [Body] UpdateProductTypeRequest updateProductTypeRequest);

        [Delete("/api/v1/productTypes/{productTypeId}")]
        Task<ApiResponse<string>> DeleteAsync(string productTypeId);

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        // Product goes here 

        [Get("/api/v1/products/type/{productTypeId}")]
        Task<ApiResponse<PagedResponse<ProductResponse>>> GetAllProductByTypeAsync(string productTypeId, PaginationQuery paginationQuery);

        [Get("/api/v1/products/{productName}")]
        Task<ApiResponse<ProductResponse>> GetProductAsync(string productName);

        [Post("/api/v1/products")]
        Task<ApiResponse<ProductResponse>> CreateProductAsync([Body] CreateProductRequest createProductRequest);

        [Put("/api/v1/products/{productId}")]
        Task<ApiResponse<ProductResponse>> UpdateProductAsync(string productId, [Body] UpdateProductRequest updateProductRequest);

        [Delete("/api/v1/products/{productId}")]
        Task<ApiResponse<string>> DeleteProductAsync(string productId);

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        // Bill goes here 
        
        [Get("/api/v1/bills/type/{billTypeId}")]
        Task<ApiResponse<PagedResponse<BillResponse>>> GetBillsByTypeAsync(string billTypeId, PaginationQuery paginationQuery);
        [Get("/api/v1/bills/date/{date}")]
        Task<ApiResponse<PagedResponse<BillResponse>>> GetBillsByDateAsync(string date, PaginationQuery paginationQuery);
        [Get("/api/v1/bills")]
        Task<ApiResponse<BillResponse>> CreateBillAsync([Body] CreateBillRequest billRequest);

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------
        // Bill detail goes here

        [Get("/api/v1/billDetails")]
        Task<ApiResponse<BillDetailResponse>> CreateBillDetailAsync([Body] CreateBillDetailRequest billDetailRequest);
        [Get("/api/v1/billDetails/billId/{billId}")]
        Task<ApiResponse<PagedResponse<BillDetailResponse>>> GetBillDetailsByBillIdAsync(string billId, PaginationQuery paginationQuery);
    }
}
