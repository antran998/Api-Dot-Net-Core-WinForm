using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Contracts.v1.Requests
{
    public class CreateBillRequest
    {
        public string Date { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string TypeId { get; set; }
    }
}
