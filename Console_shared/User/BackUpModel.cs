using System.ComponentModel.DataAnnotations;

namespace Console_shared
{
    public class BackUpModel : IBackUp
    {
        [Display(Name ="Email Address")]
        [Required (ErrorMessage = "Email should not be empty", AllowEmptyStrings=false)]
        [EmailAddressAttribute (ErrorMessage = "Not valid Email format")]
        public string Email {get; set;}
        [Required (ErrorMessage = "BackUp Question should not be empty", AllowEmptyStrings=false)]
        public string BackupQuestion {get; set;}
        [Required (ErrorMessage = "BackUp Answer should not be empty", AllowEmptyStrings=false)]
        public string BackupAnswer {get; set;}
    }
}