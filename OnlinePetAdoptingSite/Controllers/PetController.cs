using Microsoft.AspNetCore.Mvc;

namespace OnlinePetAdoptingSite.Controllers;

public class PetController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }
    
}