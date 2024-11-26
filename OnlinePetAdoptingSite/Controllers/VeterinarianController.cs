using Microsoft.AspNetCore.Mvc;

namespace OnlinePetAdoptingSite.Controllers;

public class VeterinarianController : Controller
{
    public IActionResult FindVolunteers()
    {
        return View();
    }
}