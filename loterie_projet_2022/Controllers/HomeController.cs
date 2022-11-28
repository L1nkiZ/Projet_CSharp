using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using loterie_projet_2022.Models;
using loterie_projet_2022.Services;


namespace loterie_projet_2022.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IMaClasse _classe;
    private readonly IHelperService _helperService; //Ne pas oublié de déclarer dans le controlleur 

    public HomeController(
        ILogger<HomeController> logger,
        IMaClasse classe
        )
    {
        _logger = logger;
        _classe = classe;
    }

    public IActionResult Index()
    {

        var model = _helperService.GetData();

        /*
        var name = "Maxome";
        var result = new indexVueModel
        {
            Age = 25,
            Name = name,
            Greetings = _classe.DisSalut(name),
            GetCurrentDate= _helperService.GetCurrentDate(),
            GetCurrentTime= _helperService.GetCurrentTime(),
        };
        

        //var resulat = _classe.DisSalut();
        //return View("index", resulat);
        //return View(result);
        */

        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
