using System.ComponentModel.DataAnnotations;

namespace StrorageRestApi.Contracts.v1.Requests
{
    public class UserRegistrationRequest
    {
        //[Required]
        //[RegularExpression(@"^[a-z][^0][a-z0-9_\.\-]{3,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$", ErrorMessage = "Incorrect email format")]
        public string Email { get; set; }
        //[Required]
        //[RegularExpression(@"^.[^\d]{5,}$", ErrorMessage = "Name must have at least 5 character")]
        public string Name { get; set; }
        //[Required]
        //[RegularExpression(@"^[0][1-9]{9}$", ErrorMessage = "Incorrect phone number format")]
        public string Phone { get; set; }
        //[Required]
        //[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$", ErrorMessage = "At least: 1 uppercase, 1 lowercase, 1 number, 1 special character")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //[Required]        
        //[Compare("Password", ErrorMessage = "Not Match")]
        [DataType(DataType.Password)]
        public string Confirm { get; set; }
    }
}