using System.ComponentModel.DataAnnotations;

namespace Console_shared
{
    internal interface IRegister : IBackUp
    {
        [DataType(DataType.Password)]
        [Required (ErrorMessage = "Password should not be empty", AllowEmptyStrings=false)]
        [Display(Name = "Password")]
        [MinLength(6,ErrorMessage ="Minimum 6 characters required")]
        string Password {get; set;}
        [DataType(DataType.Password)]
        [Required (ErrorMessage = "Password should not be empty", AllowEmptyStrings=false)]
        [Display(Name = "Re-type Password")]
        [Compare("Password", ErrorMessage = "Passwords Do Not Match")]
        string ConfirmPassword {get; set;}
    }
}