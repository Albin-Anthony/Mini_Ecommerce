using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Ecommerce.Models.Input
{
    public class RegisterDTO
    {
        public int CustomerId { get; set; } = 0;
        public string? FirstName { get; set; }  
        
        public string? LastName { get; set; }

        public Int64? PhoneNumber { get; set; }
        public string? Emailaddress { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }


    }
    public class LoginDTO
    {
        public string? Email { get; set; }
        public string? Password { get; set; }


    }
}
