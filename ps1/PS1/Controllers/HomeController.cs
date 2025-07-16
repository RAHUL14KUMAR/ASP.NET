using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PS1.Models;

namespace PS1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Message = "Data from ViewBag";
        return View();
    }

    public IActionResult Privacy()
    {
        ViewData["Message"] = "Data from ViewData for its privacy";
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
