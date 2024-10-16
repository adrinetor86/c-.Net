using Microsoft.AspNetCore.Mvc;

namespace TiendaProyecto.Controllers
{
    public class AcercaDeController : Controller
    {
        
        //TO DO: implementar el modelo con los datos de la empresa
        public IActionResult Index()
        {
            @ViewBag.Title="INDEX";
            @ViewBag.Descripcion="Cambia index por informacion para ver el cambio";
            return View();
        }
        
        public IActionResult Informacion()
        {
            @ViewBag.Title="TAJAMAR";
            @ViewBag.Descripcion="Empresa española muy desarrollada";
            @ViewBag.Location="Vallecas";

            return View();
        }
    }
}
