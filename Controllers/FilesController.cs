using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspcoreMvc.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
            string[] files = Directory.GetFiles("./TextFiles").Select(file => Path.GetFileNameWithoutExtension(file)).ToArray();
            return View(files);
        }

        public IActionResult ContentRead(string id)
        {
            StreamReader sr = System.IO.File.OpenText("./TextFiles/" + id + ".txt");
            string strContents = sr.ReadToEnd();
            ViewBag.Content = strContents;
            return View();
        }
    }
}