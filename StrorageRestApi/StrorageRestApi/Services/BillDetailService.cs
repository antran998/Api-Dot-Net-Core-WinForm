using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrorageRestApi.Data;
using StrorageRestApi.Domain;

namespace StrorageRestApi.Services
{
    public class BillDetailService : IBillDetailService
    {
        private readonly DataContext _dataContext;

        public BillDetailService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<bool> CreateBillDetailAsync(List<BillDetail> billDetails)
        {
            await _dataContext.AddRangeAsync(billDetails);
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<List<BillDetail>> GetBillDetailsByBillIdAsync(string billId, PaginationFilter paginationFilter = null)
        {
            if (paginationFilter == null)
            {
                return await _dataContext.BillDetail.Where(x => x.BillId == billId).ToListAsync();
            }

            var skip = (paginationFilter.PageNumber - 1) * paginationFilter.PageSize;
            return await _dataContext.BillDetail
                .Where(x => x.BillId == billId)
                .Skip(skip).Take(paginationFilter.PageSize).ToListAsync();
        }
    }
}
