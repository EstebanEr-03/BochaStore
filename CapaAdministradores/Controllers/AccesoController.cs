using Microsoft.AspNetCore.Mvc;

namespace CapaAdministradores.Controllers
{
    public class AccesoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewTienda()
        {
            return View();
        }
        public IActionResult CambiarClave()
        {
            return View();
        }
        public IActionResult Reestablecer()
        {
            return View();
        }
    }
}
