using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_shared;
using UserApi;

namespace UserApi.Repositories
{
    public class UserRepository
    {
        private MyDbContext _dbContext;
        public UserRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> Add (UserModel user)
        {
            bool isSuccessful = true;
            if (_dbContext.Users.Select(e => e.Email).Contains(user.Email))
            {
                isSuccessful = false;
                return isSuccessful;
            }

            user.Id = _dbContext.Users.Max(t=>t.Id) + 1;
            this._dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            return isSuccessful;
        }

        internal (bool, UserModel) Login (LoginModel user)
        {
            bool isSuccessful = true;
            UserModel userModel = _dbContext.Users.Where(e => (e.Email==user.Email && e.Password==user.Password)).FirstOrDefault();
            if (userModel is null)
            {
                isSuccessful = false;
                return (isSuccessful, userModel);
            }
            return (isSuccessful, userModel);
        }

        internal (bool, UserModel) Find (BackUpModel user)
        {
            bool isSuccessful = true;
            UserModel userModel = _dbContext.Users.Where(e => (e.Email==user.Email && e.BackupQuestion==user.BackupQuestion 
                                                            && e.BackupAnswer==user.BackupAnswer)).FirstOrDefault();
            if (userModel is null)
            {
                isSuccessful = false;
                return (isSuccessful, userModel);
            }
            return (isSuccessful, userModel);
        }

        public async Task<bool> TryUpdate (UserModel user)
        {
            bool isSuccessful = false;
            UserModel userModel = _dbContext.Users.Where(e => (e.Email==user.Email && e.Password==user.Password)).FirstOrDefault();
            _dbContext.Users.Remove(userModel);
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();
            isSuccessful = true;
            return isSuccessful;
        }
    }
}