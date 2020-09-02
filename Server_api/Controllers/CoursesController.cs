using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Console_shared;
using UserApi.Repositories;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

namespace Server_api.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CoursesController : ControllerBase
    {
        private CourseRepository _courseRepo;
        public CoursesController (CourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        [HttpGet]
        public List<CourseModel> GetAllCourses() => this._courseRepo.GetAllCourses();
        
    }
}
