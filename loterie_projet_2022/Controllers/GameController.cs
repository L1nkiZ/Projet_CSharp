using CSharpVitamins;
using loterie_projet_2022.Models;
using loterie_projet_2022.services;
using loterie_projet_2022.services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace loterie_projet_2022.Controllers
{
    public class GameController : Controller
    {

        private readonly IGameService _gameService;
        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        //ceée une method httpget 
        public IActionResult game()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult game(GameViewModel model)
        {

            var result = _gameService.checkTirage(model);
            //vue des réusultats plus tard -> reddirect to actions
            return View("Result", result);
            //ceée une method httpget 

        }
    }
}
