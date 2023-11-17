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

        [HttpGet]
        public IActionResult GetData()
        {
            // Devolver la vista 'Register.cshtml' desde la carpeta 'Views/Home'
            return View("~/Views/Home/Register.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Register(string userName, string password)
        {
            /*
            if (userName) {
                return BadRequest("esta mal");
            }
            */
            var usuarioNuevo = new Table1()
            {
                Usuario = userName,
                Contraseña = password
            };

            _context.Add(usuarioNuevo);
            await _context.SaveChangesAsync();


            return Json(new { redirectTo = Url.Action("Register", "Account") });
        }
    }
}
