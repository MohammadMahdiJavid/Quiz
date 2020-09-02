using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace Console_shared
{
    public class RegisterModel: BackUpModel, IRegister, IBackUp
    {
        [DataType(DataType.Password)]
        [Required (ErrorMessage = "Password should not be empty", AllowEmptyStrings=false)]
        [Display(Name = "Password")]
        [MinLength(6,ErrorMessage ="Minimum 6 characters required")]
        public string Password {get; set;}
        [DataType(DataType.Password)]
        [Required (ErrorMessage = "Password should not be empty", AllowEmptyStrings=false)]
        [Display(Name = "Re-type Password")]
        [Compare("Password", ErrorMessage = "Passwords Do Not Match")]
        public string ConfirmPassword {get; set;}
    }
}