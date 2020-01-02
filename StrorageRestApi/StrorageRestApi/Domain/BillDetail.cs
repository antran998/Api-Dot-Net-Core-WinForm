using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Domain
{
    public class BillDetail
    {
        [Key]
        public string Id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string BillId { get; set; }

        [ForeignKey(nameof(BillId))]
        public Bill Bill { get; set; }
    }
}
