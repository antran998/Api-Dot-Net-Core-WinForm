using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.Contracts.v1.Responses
{
    public class UserInfoResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }        
    }
}
