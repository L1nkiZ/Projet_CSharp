using CSharpVitamins;
using loterie_projet_2022.Models;
using Microsoft.AspNetCore.Mvc;

namespace loterie_projet_2022.Controllers
{
    public class GameController : Controller
    {
        [HttpGet]
        //ceée une method httpget 
        public IActionResult game()
        {
            return View();
        }

        [HttpPost]
        public IActionResult game(GameViewModel model)
        {
            string NewPlayer = ShortGuid.NewGuid().ToString();
            //vue des réusultats plus tard -> reddirect to actions
            return View();
        }
        //ceée une method httpget 

    }
}
