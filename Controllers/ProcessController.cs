using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspcoreMvc.Controllers
{
    public class ProcessController : Controller
    {
        // GET: Process
        public ActionResult Index()
        {
            Process[] procs = Process.GetProcesses();
            ViewBag.Procs = procs;
            return View(Process.GetProcesses());
        }

        public IActionResult Display(int id)
        {
            Process osProcess = Process.GetProcessById(id);
            return View(osProcess);
        }
    }
}