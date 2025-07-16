using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using helloWorld.Models;
using Newtonsoft.Json;

namespace helloWorld.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private LinkGenerator _linkGenerator;

    public HomeController(ILogger<HomeController> logger, LinkGenerator linkGenerator)
    {
        _logger = logger;
        _linkGenerator = linkGenerator;
    }

    public string Privacy()
    {
        var user = new User
        {
            Username = "John Doe",
            Password = 123456
        };
        var json = JsonConvert.SerializeObject(user,Formatting.Indented);
        
        // which is used to debug the code error
        _logger.LogInformation(json);
        return json;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Link()
    {
        var link = _linkGenerator.GetPathByAction("privacy", "Home");
        return Content(link);
    }

    // public IActionResult Privacy()
    // {
    //     return View();
    // }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
