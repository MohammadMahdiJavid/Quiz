using System.ComponentModel.DataAnnotations;

namespace Console_shared
{
    public class LoginModel : ILogin
    {
        [Required (ErrorMessage = "Email should not be empty", AllowEmptyStrings=false)]
        [EmailAddressAttribute (ErrorMessage = "Not valid Email format")]
        public string Email {get; set;}
        [Required (ErrorMessage = "Password should not be empty", AllowEmptyStrings=false)]
        public string Password {get; set;}
    }
}