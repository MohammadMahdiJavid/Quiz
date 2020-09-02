using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Console_shared;
using UserApi;

namespace UserApi.Repositories
{
    public class CourseRepository
    {
        private MyDbContext _dbContext;
        public CourseRepository (MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CourseModel> GetAllCourses () => this._dbContext.Courses.ToList();
    }
}