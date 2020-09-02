using System.Threading.Tasks;

namespace Console_shared
{
    interface IUser
    {
        string Email {get; set;}
        string Password {get; set;}
        string BackupQuestion {get; set;}
        string BackupAnswer {get; set;}
    }
}