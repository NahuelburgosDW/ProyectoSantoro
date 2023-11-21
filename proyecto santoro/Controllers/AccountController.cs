using Microsoft.AspNetCore.Mvc;
using proyecto_santoro.Models;

namespace proyecto_santoro.Controllers
{
    public class AccountController : Controller
    {
        private readonly ProyectoContext _context;

        public AccountController(ProyectoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            // Devolver la vista 'Register.cshtml' desde la carpeta 'Views/Home'
            return View("~/Views/Home/Register.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Register(string userName, string password)
        {
            try
            {
                var usuarioNuevo = new Table1()
                {
                    Usuario = userName,
                    Contraseña = password
                };

                _context.Add(usuarioNuevo);
                await _context.SaveChangesAsync();

                ViewData["RegistroExitoso"] = true;

                return PartialView("_RegistroExitoso");
            }
            catch (Exception ex)
            {
                // Loguea el error o devuelve un mensaje de error específico
                return Json(new { error = ex.Message });
            }
        }




        [HttpPost]
        [HttpPost]
        public IActionResult Login(string UserName, string Password)
        {
            // Lógica para verificar las credenciales del usuario
            var usuario = _context.Table1s.FirstOrDefault(u => u.Usuario == UserName && u.Contraseña == Password);

            if (usuario != null)
            {
                // Supongamos que las credenciales son correctas
                // Aquí deberías tener tu lógica de autenticación real

                // Redirigir a la página de inicio si el inicio de sesión es exitoso
                return View("~/Views/Home/Inicio.cshtml");

            }
            else
            {
                // Las credenciales son incorrectas, podrías redirigir a una página de error
                // o mostrar un mensaje de error en la vista Login
                return View("Inicio", new { error = "Credenciales incorrectas" });
            }
            

        }


    }
}
