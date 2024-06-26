﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace LandingApp.Controllers
{
    public class SelectionController : Controller
    {
        // GET: /<controller>/
        public ViewResult UploadFile()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            // Добавьте здесь код для загрузки файла
            if (file!=null && file.Length>0)
            {
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/upload", file.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
            }
            return View();
        }
        
    }
}

