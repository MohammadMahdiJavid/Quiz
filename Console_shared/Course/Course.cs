using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace Console_shared
{
    public class CourseModel : ICourse
    {
        public string Name {get; set;}
        public int TotalScore {get; set;}
        public int Exercises {get; set;}
        public string Description {get; set;}
        public string Author {get; set;}
        public string Chapters {get; set;}
        public int Id {get; set;}
        public string ImagePath {get; set;}
    }
}