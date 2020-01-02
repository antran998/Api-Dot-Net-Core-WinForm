using Storage.Contracts.v1.Requests.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Services
{
    public interface IUriService
    {
        Uri GetProductTypeUri(string productTypeId);
        Uri GetAllProductTypeUri(PaginationQuery pagination = null);
        Uri GetProductUri(string productId);
        Uri GetAllProductUri(PaginationQuery pagination = null);
    }
}
