using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Console_shared
{
    interface IProfile
    {
        [Required , RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$" , ErrorMessage="First Letter Should be Upper-Case")]
        [Display(Name = "FirstName")]
        string Name {get; set;}
        [Required , RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$" , ErrorMessage="First Letter Should be Upper-Case")]
        [Display(Name = "LastName")]
        string LastName {get; set;}
        string About {get; set;}
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "only numbers allowed in the sequence.")]
        string Phone {get; set;}
        string Profession {get; set;}
    }
}