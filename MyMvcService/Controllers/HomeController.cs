using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyMvcService.Models;

namespace MyMvcService.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMyServices _myServices;
    private readonly IchatService _chatservice;

    public HomeController(ILogger<HomeController> logger,IMyServices myServices,IchatService chatservice)
    {
        _logger = logger;
        _myServices= myServices;
        _chatservice= chatservice;
    }

    public IActionResult Index()
    {
       var test= _myServices.GetMessage();
       var chatservicea=_chatservice.execute();
       ViewBag.Message=test.ToString();
       ViewBag.chatService=chatservicea.ToString();
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
