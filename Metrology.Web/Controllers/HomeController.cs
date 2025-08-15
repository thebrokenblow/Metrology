using Microsoft.AspNetCore.Mvc;

namespace Metrology.Web.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}