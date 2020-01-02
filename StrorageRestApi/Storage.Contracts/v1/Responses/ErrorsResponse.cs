using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Contracts.v1.Responses
{
    public class ErrorsResponse
    {
        public List<ErrorModel> ErrorsValidator { get; set; } = new List<ErrorModel>();
    }
}
