using Microsoft.AspNetCore.Mvc;

namespace TiendaProyecto.Controllers;

public class UserController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}