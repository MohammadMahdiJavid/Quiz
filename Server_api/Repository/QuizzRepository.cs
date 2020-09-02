using System.Linq.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_shared;
using UserApi;

namespace UserApi.Repositories
{
    public class QuizzRepository
    {
        private MyDbContext _dbContext;
        public QuizzRepository (MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<QuizzModel> FunctionQuizzMultipleChoice () => 
            this._dbContext.Quizzes.Where(e => (e.Name=="Function" && e.Model==QuizzType.MultipleChoice)).ToList();

        public UserModel MySaveQuizz (UserModel newUser)
        {
            UserModel user = this._dbContext.Users.Where(e => (e.Email==newUser.Email && e.Password==newUser.Password)).FirstOrDefault();
            this._dbContext.Users.Remove(user);
            this._dbContext.SaveChanges();
            user.Score = newUser.Score;
            this._dbContext.Users.Add(user);
            this._dbContext.SaveChanges();
            return user;
        }
    }
}