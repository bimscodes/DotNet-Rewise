using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcService.Models;

namespace MyMvcService.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMyServices _myServices;

    public HomeController(ILogger<HomeController> logger,IMyServices myServices)
    {
        _logger = logger;
        _myServices= myServices;
    }

    public IActionResult Index()
    {
       var test= _myServices.GetMessage();
       ViewBag.Message=test.ToString();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
