using Microsoft.AspNetCore.Mvc;
using proyecto_santoro.Models;

public class MenuController : Controller
{
    public IActionResult Inicio()
    {
        List<MenuItem> elementosMenu = new List<MenuItem>
        {
            new MenuItem { RutaImagen = "images/user.svg", Texto = "Perfil", Url = "#" },
            new MenuItem { RutaImagen = "images/file.svg", Texto = "Almacenamiento", Url = "#" },
            new MenuItem { RutaImagen = "images/cloud.png", Texto = "Clima", Url = "#" },
            new MenuItem { RutaImagen = "images/juego.png", Texto = "Juego", Url = "#" },
            new MenuItem { RutaImagen = "images/settings.svg", Texto = "Configuración", Url = "#" }
        };

        return View(elementosMenu);
    }

}
