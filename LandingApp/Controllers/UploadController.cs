using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.IO;



// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LandingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : Controller
    {



        // GET api/upload/getfile
        [HttpGet("getfile")]
        public void GetFile()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/upload");
            var files = Directory.GetFiles(path);

             RunFile(files);
            return;
        }

        [HttpPost("runfile")]
        public IActionResult RunFile([FromBody] string[] files)
        {
            foreach(var file in files)
            {
                Process.Start(new ProcessStartInfo { FileName = file, UseShellExecute = true });
                
            }    
            

            return Ok("File started successfully");
        }
    }
}




