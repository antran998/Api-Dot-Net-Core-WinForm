using StrorageRestApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Services
{
    public interface IBillService
    {
        Task<bool> CreateBillAsync(Bill billToCreate);
        Task<List<Bill>> GetBillsByDateAsync(string date,PaginationFilter paginationFilter = null);
        Task<List<Bill>> GetBillsByTypeAsync(string typeId, PaginationFilter paginationFilter = null);
        Task<Bill> GetLastestBillIdAsync();
    }
}
