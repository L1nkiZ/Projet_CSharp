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

        //[HttpGet]
        //public IActionResult game(string result)
        //{
        //    var result_short_guid = new GameViewModel()
        //    {
        //        guid_code = result
        //    };

        //    return View("Result", result_short_guid);
        //}

        public IActionResult game()
        {
            return View();
        }

        [HttpPost]
        public IActionResult game(GameViewModel model)
        {

            var result = _gameService.checkTirage(model);
            codeGUIDViewModel modelGUID = new codeGUIDViewModel();
            modelGUID.GUID = result;
            //vue des réusultats plus tard -> reddirect to actions
            //return RedirectToAction("codeGuid", new { view_code_guid_result = result});
            return RedirectToAction("codeGuid", modelGUID);
            //ceée une method httpget 

        }

        [HttpGet]
        public IActionResult codeGuid(codeGUIDViewModel modelGUID)
        {
            return View(modelGUID);

        }
    }
}
