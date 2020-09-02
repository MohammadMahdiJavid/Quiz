using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Console_shared;
using UserApi.Repositories;

namespace Server_api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private UserRepository _userRepo;
        public UsersController(UserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost("login")]
        public ActionResult<UserModel> Login (LoginModel user)
        {
            (bool, UserModel) isSuccessful = _userRepo.Login(user);
            if (isSuccessful.Item1) return Ok(isSuccessful.Item2);
            return new BadRequestResult();
        }

        [HttpPost("register")]
        public ActionResult<UserModel> CreateUser (UserModel user)
        {
            Task<bool> isSuccessful = _userRepo.Add(user);
            if (isSuccessful.Result) return CreatedAtAction(nameof(CreateUser), new { id = user.Id }, user);
            return new BadRequestResult();
        }

        [HttpPost("find")]
        public ActionResult<UserModel> Find (BackUpModel user)
        {
            (bool, UserModel) isSuccessful = _userRepo.Find(user);
            if (isSuccessful.Item1) return Ok(isSuccessful.Item2);
            return NotFound();
        }

        [HttpPut ("update")]
        public IActionResult Update (UserModel user)
        {
            Task<bool> isSuccessful = _userRepo.TryUpdate(user);
            if (isSuccessful.Result) return Ok("User Updated Successfuly");
            return new BadRequestResult();
        }
    }
}