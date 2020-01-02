using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StrorageRestApi.Data;
using StrorageRestApi.Domain;

namespace StrorageRestApi.Services
{
    public class BillService : IBillService
    {
        private readonly DataContext _dataContext;

        public BillService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<bool> CreateBillAsync(Bill billToCreate)
        {
            await _dataContext.AddAsync(billToCreate);  
            var created = await _dataContext.SaveChangesAsync();
            return created > 0;
        }

        public async Task<List<Bill>> GetBillsByDateAsync(string date, PaginationFilter paginationFilter = null)
        {
            if (paginationFilter == null)
            {
                return await _dataContext.Bill.Where(x => x.Date == date).ToListAsync();
            }

            var skip = (paginationFilter.PageNumber - 1) * paginationFilter.PageSize;
            return await _dataContext.Bill
                .Where(x => x.Date == date)
                .Skip(skip).Take(paginationFilter.PageSize).ToListAsync();
        }

        public async Task<List<Bill>> GetBillsByTypeAsync(string typeId, PaginationFilter paginationFilter = null)
        {
            if (paginationFilter == null)
            {
                return await _dataContext.Bill.Where(x => x.TypeId == typeId).ToListAsync();
            }

            var skip = (paginationFilter.PageNumber - 1) * paginationFilter.PageSize;
            return await _dataContext.Bill
                .Where(x => x.TypeId == typeId)
                .Skip(skip).Take(paginationFilter.PageSize).ToListAsync();
        }

        public async Task<Bill> GetLastestBillIdAsync()
        {
            return await _dataContext.Bill.FirstOrDefaultAsync();          
        }
    }
}
