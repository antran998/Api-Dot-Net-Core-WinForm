using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Domain
{
    public class BillType
    {
        [Key]
        public string Id { get; set; }
        public string Type { get; set; }
    }
}
