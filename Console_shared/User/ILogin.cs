using System.ComponentModel.DataAnnotations;

namespace Console_shared
{
    interface ILogin
    {
        [Required (ErrorMessage = "Email should not be empty", AllowEmptyStrings=false)]
        [EmailAddressAttribute (ErrorMessage = "Not valid Email format")]
        string Email {get; set;}
        [Required (ErrorMessage = "Password should not be empty", AllowEmptyStrings=false)]
        string Password {get; set;}
    }
}