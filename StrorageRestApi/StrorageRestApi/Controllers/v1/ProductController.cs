using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Storage.Contracts.v1.Requests;
using Storage.Contracts.v1.Requests.Queries;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1;
using StrorageRestApi.Contracts.v1.Requests;
using StrorageRestApi.Contracts.v1.Responses;
using StrorageRestApi.Domain;
using StrorageRestApi.Helpers;
using StrorageRestApi.Services;

namespace StrorageRestApi.Controllers.v1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;

        public ProductController(IProductService productService, IMapper mapper, IUriService uriService)
        {
            _productService = productService;
            _mapper = mapper;
            _uriService = uriService;
        }

        [HttpGet(ApiRoutes.Products.GetAll)]
        public async Task<IActionResult> GetAllByType([FromRoute] string productTypeId, [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var product = await _productService.GetProductsByTypeAsync(productTypeId, pagination);
            var productsResponse = _mapper.Map<List<ProductResponse>>(product);

            if (pagination == null || pagination.PageNumber < 1 || pagination.PageSize < 1)
            {
                return Ok(new PagedResponse<ProductResponse>(productsResponse));
            }

            var paginationResponse = PaginationHelpers.CreatePaginatedResponse(_uriService, pagination, productsResponse);
            return Ok(paginationResponse);
        }

        [HttpGet(ApiRoutes.Products.Get)]
        public async Task<IActionResult> Get([FromRoute] string productName)
        {
            var product = await _productService.GetProductByNameAsync(productName);
            if (product == null) return NotFound();
            var productResponse = _mapper.Map<ProductResponse>(product);
            return Ok(productResponse);
        }

        [HttpPost(ApiRoutes.Products.Create)]
        public async Task<IActionResult> Create([FromBody] CreateProductRequest productRequest)
        {
            var product = new Product 
            { 
                ProductName = productRequest.ProductName,
                Price = productRequest.Price,
                Quantity = productRequest.Quantity,
                TypeId = productRequest.TypeId
            };

            await _productService.CreateProductAsync(product);

            var locationUrl = _uriService.GetProductUri(product.Id.ToString());
            //var response = new ProductTypeResponse { Id = productType.Id };
            return Created(locationUrl, _mapper.Map<ProductResponse>(product));
        }

        [HttpDelete(ApiRoutes.Products.Delete)]
        public async Task<IActionResult> Delete([FromRoute] string productId)
        {
            var deleted = await _productService.DeleteProductAsync(productId);
            if (deleted) return NoContent();
            return NotFound();
        }

        [HttpPut(ApiRoutes.Products.Update)]
        public async Task<IActionResult> Update([FromRoute] string productId, [FromBody] UpdateProductRequest updateProduct)
        {
            var product = new Product
            {
                Id = productId,
                ProductName = updateProduct.ProductName,
                Price = updateProduct.Price,
                Quantity = updateProduct.Quantity,
                TypeId = updateProduct.TypeId
            };
            var updated = await _productService.UpdateProductAsync(product);
            if (updated) return Ok(_mapper.Map<ProductResponse>(product));
            return NotFound();
        }
    }
}