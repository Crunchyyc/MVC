using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using _409110035MVC.Models;

namespace _409110035MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
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

    // 新增的 NO409110035 Action 方法
    public IActionResult NO123()
    {
        ViewData["Number"] = "123";
        ViewData["Name"] = "Cian";
        return View();
    }
}
