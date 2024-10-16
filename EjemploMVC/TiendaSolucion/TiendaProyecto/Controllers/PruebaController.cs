using Microsoft.AspNetCore.Mvc;

namespace TiendaProyecto.Controllers;

public class PruebaController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}