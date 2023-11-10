using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClinicaLanderr.Models;

namespace ClinicaLanderr.Controllers;

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

       public IActionResult Produtos()
    {
        return View();
    }

       public IActionResult Duvidas()
    {
        return View();
    }

       public IActionResult Agendamento()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
