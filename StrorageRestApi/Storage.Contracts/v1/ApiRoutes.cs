using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Contracts.v1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root+"/"+Version;

        public static class ProductTypes
        {
            public const string GetAll = Base + "/productTypes";
            public const string Get = Base + "/productTypes/{productTypeName}";
            public const string Update = Base + "/productTypes/{productTypeId}";
            public const string Delete = Base + "/productTypes/{productTypeId}";
            public const string Create = Base + "/productTypes";
        }

        public static class Identity
        {
            public const string Login = Base + "/identity/login";
            public const string Register = Base + "/identity/register";
            public const string Refresh = Base + "/identity/refresh";
            public const string UserInfo = Base + "/identity/userInfo/{token}";
        }

        public static class Products
        {
            public const string GetAll = Base + "/products/type/{productTypeId}";
            public const string Get = Base + "/products/{productName}";
            public const string Update = Base + "/products/{productId}";
            public const string Delete = Base + "/products/{productId}";
            public const string Create = Base + "/products";
        }

        public static class Bills
        {
            public const string GetAllByType = Base + "/bills/type/{billTypeId}";
            public const string GetAllByDate = Base + "/bills/date/{date}";
            public const string Create = Base + "/bills";
        }

        public static class BillDetails
        {
            public const string GetAllByBillId = Base + "/billDetails/billId/{billId}";            
            public const string Create = Base + "/billDetails";
        }
    }
}
