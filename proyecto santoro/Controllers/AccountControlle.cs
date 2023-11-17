using Microsoft.AspNetCore.Mvc;

namespace proyecto_santoro.Controllers
{
    public class AccountController : Controller
    {
        // Otras acciones y lógica del controlador...

        [HttpGet]
        public IActionResult Register()
        {
            // Devolver la vista 'Register.cshtml' desde la carpeta 'Views/Home'
            return View("~/Views/Home/Register.cshtml");
        }

        [HttpPost]
        public IActionResult Register(string userName, string password)
        {
            // Lógica para registrar al usuario
            // Puedes usar un servicio de identidad o manejar el registro manualmente
            // ...

            // Redireccionar a la página de inicio de sesión después del registro
            return RedirectToAction("Login");
        }
    }
}
