using Microsoft.AspNetCore.Mvc;

namespace OnlinePetAdoptingSite.Controllers;

public class AdoptionController : Controller
{
    public IActionResult List()
    {
        return View();
    }



    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Example()
    {
        return View();
    }
}