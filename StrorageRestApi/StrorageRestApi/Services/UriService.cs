using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Storage.Contracts.v1.Requests.Queries;
using StrorageRestApi.Contracts.v1;

namespace StrorageRestApi.Services
{
    public class UriService : IUriService
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetAllProductTypeUri(PaginationQuery pagination = null)
        {
            var uri = new Uri(_baseUri);

            if(pagination == null)
            {
                return uri;
            }

            var modifiedUri = QueryHelpers.AddQueryString(_baseUri, "pageNumber", pagination.PageNumber.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", pagination.PageSize.ToString());

            return new Uri(modifiedUri);
        }

        public Uri GetAllProductUri(PaginationQuery pagination = null)
        {
            var uri = new Uri(_baseUri);

            if (pagination == null)
            {
                return uri;
            }

            var modifiedUri = QueryHelpers.AddQueryString(_baseUri, "pageNumber", pagination.PageNumber.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", pagination.PageSize.ToString());

            return new Uri(modifiedUri);
        }

        public Uri GetProductTypeUri(string productTypeId)
        {
            return new Uri(_baseUri + ApiRoutes.ProductTypes.Get.Replace("{productTypeId}", productTypeId));
        }

        public Uri GetProductUri(string productId)
        {
            return new Uri(_baseUri + ApiRoutes.Products.Get.Replace("{productId}", productId));
        }
    }
}
