using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Contracts.v1.Responses
{
    public class ProductResponse
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string TypeId { get; set; }
    }
}
