using StrorageRestApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Services
{
    public interface IBillDetailService
    {
        Task<bool> CreateBillDetailAsync(List<BillDetail> billDetails);
        Task<List<BillDetail>> GetBillDetailsByBillIdAsync(string billId, PaginationFilter paginationFilter = null);
    }
}
