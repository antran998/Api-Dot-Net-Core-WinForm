using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Storage.Contracts.v1.Requests;
using Storage.Contracts.v1.Requests.Queries;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1;
using StrorageRestApi.Domain;
using StrorageRestApi.Helpers;
using StrorageRestApi.Services;

namespace StrorageRestApi.Controllers.v1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BillController : Controller
    {
        private readonly IBillService _billService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;

        public BillController(IBillService billService, IMapper mapper, IUriService uriService)
        {
            _billService = billService;
            _mapper = mapper;
            _uriService = uriService;
        }

        [HttpGet(ApiRoutes.Bills.GetAllByType)]
        public async Task<IActionResult> GetAllByTypeAsync([FromRoute] string billTypeId, [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var bill = await _billService.GetBillsByTypeAsync(billTypeId, pagination);
            var billsResponse = _mapper.Map<List<BillResponse>>(bill);

            if (pagination == null || pagination.PageNumber < 1 || pagination.PageSize < 1)
            {
                return Ok(new PagedResponse<BillResponse>(billsResponse));
            }

            var paginationResponse = PaginationHelpers.CreatePaginatedResponse(_uriService, pagination, billsResponse);
            return Ok(paginationResponse);
        }

        [HttpGet(ApiRoutes.Bills.GetAllByDate)]
        public async Task<IActionResult> GetAllByDateAsync([FromRoute] string date, [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var bill = await _billService.GetBillsByDateAsync(date, pagination);
            var billsResponse = _mapper.Map<List<BillResponse>>(bill);

            if (pagination == null || pagination.PageNumber < 1 || pagination.PageSize < 1)
            {
                return Ok(new PagedResponse<BillResponse>(billsResponse));
            }

            var paginationResponse = PaginationHelpers.CreatePaginatedResponse(_uriService, pagination, billsResponse);
            return Ok(paginationResponse);
        }

        [HttpPost(ApiRoutes.Bills.Create)]
        public async Task<IActionResult> CreateAsync([FromBody] CreateBillRequest billRequest)
        {
            var bill = new Bill
            {
                Date = billRequest.Date,
                Price = billRequest.Price,
                Quantity = billRequest.Quantity,
                TypeId = billRequest.TypeId
            };

            await _billService.CreateBillAsync(bill);

            var locationUrl = _uriService.GetProductUri(bill.Id.ToString());
            //var response = new ProductTypeResponse { Id = productType.Id };
            return Created(locationUrl, _mapper.Map<BillResponse>(bill));
        }
    }
}