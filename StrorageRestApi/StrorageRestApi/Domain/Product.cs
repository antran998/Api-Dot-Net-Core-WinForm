using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Domain
{
    public class Product
    {
        [Key]
        public string  Id { get; set; }
        public string ProductName { get; set; }        
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string TypeId { get; set; }

        [ForeignKey(nameof(TypeId))]
        public ProductType Type { get; set; }
    }
}
