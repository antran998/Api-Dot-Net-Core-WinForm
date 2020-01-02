using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageManager.Custom_Class
{
    public class ErrorsResult
    {
        public IEnumerable<string> Errors { get; set; }
        public List<ErrorValidator> ErrorsValidator { get; set; }
    }
}
