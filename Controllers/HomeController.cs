using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP3_Arias.Models;

namespace TP3_Arias.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        empresa.InicializarCatalogo();
        ViewBag.catalogo = empresa.catalogo;
        return View();
    }
     public IActionResult infoDisco(int id)
    {
        empresa.InicializarCatalogo();
        int i = -1;
        do{
            i++;
        }while(empresa.catalogo[i].id != id && id < empresa.catalogo.Count);
        if(i < empresa.catalogo.Count) ViewBag.disco = empresa.catalogo[i];
        return View();
    }
}
