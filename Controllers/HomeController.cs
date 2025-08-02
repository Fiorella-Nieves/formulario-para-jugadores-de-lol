using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using formulario_lol.Models;

namespace formulario_lol.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

     public IActionResult RegistroJugadorazo(Cliente cliente)
    {
        ViewData["mensaje"]= "GRACIAS " + cliente.Nombre + " POR HABERTE REGISTRADO A NUESTRO JUEGO DE LOL, se nota que no te bañas";
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
