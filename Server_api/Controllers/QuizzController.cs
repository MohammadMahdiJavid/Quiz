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
    [Route("api/quizz")]
    public class QuizzController : ControllerBase
    {
        private QuizzRepository _quizzRepo;
        public QuizzController(QuizzRepository quizzRepo)
        {
            _quizzRepo = quizzRepo;
        }

        [HttpGet("function/multiplechoice")]
        public ActionResult<List<QuizzModel>> GetFunctionMultipleChoiceQuesttions ()
        {
            return Ok(this._quizzRepo.FunctionQuizzMultipleChoice());
        }

        [HttpPost("EndQuizz")]
        public ActionResult<UserModel> EndQuizz(UserModel user)
        {
            return Ok(this._quizzRepo.MySaveQuizz(user));
        }
    }
}