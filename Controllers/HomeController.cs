using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AspcoreMvc.Models;

namespace AspcoreMvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        string[] days = { "M", "T", "W" };
        ViewData["days"] = days;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Bogus()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
