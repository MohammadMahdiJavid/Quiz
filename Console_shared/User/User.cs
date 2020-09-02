using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;

namespace Console_shared
{
    public class UserModel : AuthenticationStateProvider, IUser
    {
        public void equalnew (UserModel user)
        {
            (this.Email, this.Password, this.BackupQuestion, this.BackupAnswer, 
                this.Id, this.ProfileImage, this.IsAuthorized, this.Name, this.LastName,
                this.About, this.Courses, this.Phone, this.Profession, this.Websites, this.Skills, this.Score, this.Scores, 
                    this.BeforeExamScore ) = 
                (user.Email, user.Password, user.BackupQuestion, user.BackupAnswer,
                    user.Id, user.ProfileImage, user.IsAuthorized, user.Name, user.LastName,
                    user.About, user.Courses, user.Phone, user.Profession, user.Websites, user.Skills, user.Score, user.Scores,
                    user.BeforeExamScore);
        }
        public string Email {get; set;}
        public string Password {get; set;}
        public string BackupQuestion {get; set;}
        public string BackupAnswer {get; set;}
        public int Id {get; set;}
        public string ProfileImage {get; set;}
        public string Name {get; set;}
        public string LastName {get; set;}
        public string About {get; set;}
        public string Courses {get; set;}
        public string Phone {get; set;}
        public string Profession {get; set;}
        public string Websites {get; set;}
        public string Skills {get; set;}
        public int Score {get; set;}
        public int BeforeExamScore {get; set;}
        public bool IsAuthorized {get; set;} = false;
        public string Scores{get; set;}

        public override bool Equals (object obj)
        {
            UserModel user = obj as UserModel;
            if (user is null) return false;
            return this.Email == user.Email && this.Password == user.Password;
        }

        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            this.IsAuthorized = true;
            ClaimsPrincipal user = new ClaimsPrincipal();
            return Task.FromResult(new AuthenticationState(user));
        }

        public override int GetHashCode () => this.Email.GetHashCode() ^ this.Password.GetHashCode();
    }
}