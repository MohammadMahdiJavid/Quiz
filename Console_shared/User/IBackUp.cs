using System.ComponentModel.DataAnnotations;

namespace Console_shared
{
    interface IBackUp
    {
        [Display(Name ="Email Address")]
        [Required (ErrorMessage = "Email should not be empty", AllowEmptyStrings=false)]
        [EmailAddressAttribute (ErrorMessage = "Not valid Email format")]
        string Email {get; set;}
        [Required (ErrorMessage = "BackUp Question should not be empty", AllowEmptyStrings=false)]
        string BackupQuestion {get; set;}
        [Required (ErrorMessage = "BackUp Answer should not be empty", AllowEmptyStrings=false)]
        string BackupAnswer {get; set;}
    }
}