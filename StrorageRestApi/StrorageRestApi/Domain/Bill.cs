using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Domain
{
    public class Bill
    {
        [Key]
        public string Id { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public BillType Type { get; set; }
    }
}
