using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Storage.Contracts.v1.Requests.Queries;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1;
using StrorageRestApi.Domain;
using StrorageRestApi.Helpers;
using StrorageRestApi.Services;

namespace StrorageRestApi.Controllers.v1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class BillDetailController : Controller
    {
        private readonly IBillDetailService _billDetailService;
        private readonly IBillService _billService;
        private readonly IMapper _mapper;
        private readonly IUriService _uriService;

        public BillDetailController(IBillDetailService billDetailService, IMapper mapper, IUriService uriService, IBillService billService)
        {
            _billDetailService = billDetailService;
            _mapper = mapper;
            _uriService = uriService;
            _billService = billService;
        }

        [HttpPost(ApiRoutes.BillDetails.Create)]
        public async Task<IActionResult> CreateAsync([FromBody] List<CreateBillDetailRequest> billDetailRequest)
        {
            var newBill = await _billService.GetLastestBillIdAsync();

            List<BillDetail> billDetails = new List<BillDetail>();
            foreach (var item in billDetailRequest)
            {
                var billDetail = new BillDetail
                {
                    Price = item.Price,
                    Quantity = item.Quantity,
                    BillId = newBill.Id,
                    ProductName = item.ProductName
                };
                billDetails.Add(billDetail);
            }

            await _billDetailService.CreateBillDetailAsync(billDetails);

            var locationUrl = _uriService.GetProductUri(billDetails[0].Id.ToString());
            //var response = new ProductTypeResponse { Id = productType.Id };
            return Created(locationUrl, _mapper.Map<BillDetailResponse>(billDetails[0]));
        }

        [HttpGet(ApiRoutes.BillDetails.GetAllByBillId)]
        public async Task<IActionResult> GetAllByBillIdAsync([FromRoute] string billId, [FromQuery] PaginationQuery paginationQuery)
        {
            var pagination = _mapper.Map<PaginationFilter>(paginationQuery);
            var billDetail = await _billDetailService.GetBillDetailsByBillIdAsync(billId, pagination);
            var billDetailsResponse = _mapper.Map<List<BillDetailResponse>>(billDetail);

            if (pagination == null || pagination.PageNumber < 1 || pagination.PageSize < 1)
            {
                return Ok(new PagedResponse<BillDetailResponse>(billDetailsResponse));
            }

            var paginationResponse = PaginationHelpers.CreatePaginatedResponse(_uriService, pagination, billDetailsResponse);
            return Ok(paginationResponse);
        }
    }
}