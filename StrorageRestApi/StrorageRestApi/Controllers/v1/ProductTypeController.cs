using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Storage.Contracts.v1.Requests.Queries;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1;
using StrorageRestApi.Contracts.v1.Requests;
using StrorageRestApi.Contracts.v1.Responses;
using StrorageRestApi.Domain;
using StrorageRestApi.Helpers;
using StrorageRestApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Controllers.v1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ProductTypeController : Controller
    {
        private readonly IProductTypeService _productTypeService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;

        public ProductTypeController(IProductTypeService productTypeService, IMapper mapper, IUriService uriService)
        {
            _productTypeService = productTypeService;
            _mapper = mapper;
            _uriService = uriService;
        }

        [HttpGet(ApiRoutes.ProductTypes.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var productType = await _productTypeService.GetProductTypesAsync(pagination);
            var productTypesResponse = _mapper.Map<List<ProductTypeResponse>>(productType);

            if(pagination == null || pagination.PageNumber < 1 || pagination.PageSize < 1)
            {
                return Ok(new PagedResponse<ProductTypeResponse>(productTypesResponse));
            }

            var paginationResponse = PaginationHelpers.CreatePaginatedResponse(_uriService, pagination, productTypesResponse);            
            return Ok(paginationResponse);
        }

        [HttpGet(ApiRoutes.ProductTypes.Get)]
        public async Task<IActionResult> Get([FromRoute] string productTypeName)
        {
            var productType = await _productTypeService.GetProductTypeByNameAsync(productTypeName);
            if (productType == null) return NotFound();
            var productTypesResponse = _mapper.Map<ProductTypeResponse>(productType);
            return Ok(productTypesResponse);
        }

        [HttpPost(ApiRoutes.ProductTypes.Create)]
        public async Task<IActionResult> Create([FromBody] CreateProductTypeRequest productTypeRequest)
        {
            var productType = new ProductType { Type = productTypeRequest.TypeName };
            
            await _productTypeService.CreateProductTypeAsync(productType);
            
            var locationUrl = _uriService.GetProductTypeUri(productType.Id.ToString());
            //var response = new ProductTypeResponse { Id = productType.Id };
            return Created(locationUrl,_mapper.Map<ProductTypeResponse>(productType));
        }

        [HttpDelete(ApiRoutes.ProductTypes.Delete)]
        public async Task<IActionResult> Delete([FromRoute] string productTypeId)
        {
            //var isNotBlank = await _productTypeService.CheckProductTypeIsBlankAsync(productTypeId);
            //if (isNotBlank != null)
            //{
                var deleted = await _productTypeService.DeleteProductTypeAsync(productTypeId);
                if (deleted) return NoContent();
                return NotFound();
            //}
            //return Ok(isNotBlank);
        }

        [HttpPut(ApiRoutes.ProductTypes.Update)]
        public async Task<IActionResult> Update([FromRoute] string productTypeId, [FromBody] UpdateProductTypeRequest updateProductType)
        {
            var productType = new ProductType
            {
                Id = productTypeId,
                Type = updateProductType.Name
            };
            var updated = await _productTypeService.UpdateProductTypeAsync(productType);            
            if (updated) return Ok(_mapper.Map<ProductTypeResponse>(productType));
            return NotFound();
        }
    }
}