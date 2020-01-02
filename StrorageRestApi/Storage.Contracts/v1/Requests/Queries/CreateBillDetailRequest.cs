using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Contracts.v1.Requests.Queries
{
    public class CreateBillDetailRequest
    {
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
    }
}
