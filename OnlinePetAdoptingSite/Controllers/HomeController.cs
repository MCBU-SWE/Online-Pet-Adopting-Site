using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnlinePetAdoptingSite.Models;

namespace OnlinePetAdoptingSite.Controllers;

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
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult About()
    {
        var model = new
        {
            Title = "About Us",
            Description = "Learn more about PetSoLive, our mission, and how we help pets find loving homes.",
            PreviousPageTitle = "Home",
            CurrentPageTitle = "About Us"
        };

        return View(model);
    }

    public IActionResult Faq()
    {
        return View();
    }
    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}