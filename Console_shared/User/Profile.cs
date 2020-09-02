using System.ComponentModel.DataAnnotations;


namespace Console_shared
{
    public class ProfileModel : IProfile
    {
        [Required , RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$" , ErrorMessage="First Letter Should be Upper-Case")]
        [Display(Name = "FirstName")]
        public string Name {get; set;}
        [Required , RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$" , ErrorMessage="First Letter Should be Upper-Case")]
        [Display(Name = "LastName")]
        public string LastName {get; set;}
        public string About {get; set;}
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "only numbers allowed in the sequence.")]
        public string Phone {get; set;}
        public string Profession {get; set;}
    }
}
