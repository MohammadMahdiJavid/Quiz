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
    [Route("api/images")]
    public class ImagesController : ControllerBase
    {
        string[] allowedExtensions = new [] {".jpg", ".png", ".jpeg", ".bmp", ".ico"};
        private readonly IHostEnvironment _environment;
        public ImagesController (IHostEnvironment environment)
        {
            this._environment = environment;
        }

        [HttpPost ("profile")]
        public async Task<IActionResult> Post ([FromForm] IFormFile image)
        {
            if (image is null || image.Length == 0) return BadRequest ("There is a problem with uploaded file");

            string fileName = image.FileName;
            string extension = Path.GetExtension(fileName);
            if (! this.allowedExtensions.Contains(extension)) return BadRequest("Not Valid Type Of File");

            string storedFileName = $"{Guid.NewGuid()}{extension}";
            string directory = "Profile Images";
            string root = "wwwroot";
            string filePath = Path.Combine(this._environment.ContentRootPath, root, directory, storedFileName);

            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                await image.CopyToAsync(file);

            return Ok($"{directory}/{storedFileName}");
        }
    }
}
