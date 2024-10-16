using Microsoft.AspNetCore.Mvc;

namespace TiendaProyecto.Controllers
{
    public class MonedasController : Controller
    {
        
        //Metodo de accion para la vista de Monedas
        public IActionResult Index()
        {
            ViewBag.Title="Monedas";
            ViewBag.Descripcion="Aqui podras ver las monedas disponibles";
            ViewBag.Precio = "Precio";
            ViewBag.Fecha = DateTime.Now;
            
            return View();
        }
    }
}
