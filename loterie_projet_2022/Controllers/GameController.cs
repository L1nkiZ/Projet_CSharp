using loterie_projet_2022.Models;
using Microsoft.AspNetCore.Mvc;

namespace loterie_projet_2022.Controllers
{
    public class GameController : Controller
    {
        [HttpGet]
        //ceée une method httpget 
        public IActionResult Index()
        {
            // Générer des nombres aléatoires pour les numéros de la loterie
            Random rng = new Random();
            List<int> lotteryNumbers = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                lotteryNumbers.Add(rng.Next(1, 49));
            }

            // Afficher la grille de numéros pour le joueur
            Console.WriteLine("Voici la grille des numéros de la loterie (1-49):");
            for (int i = 1; i <= 49; i++)
            {
                Console.Write(i + " ");
                if (i % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();

            // Demander au joueur de choisir ses numéros de loterie
            List<int> playerNumbers = new List<int>();
            Console.WriteLine("Choisissez six numéros pour jouer à la loterie (1-49):");
            for (int i = 0; i < 6; i++)
            {
                int number = int.Parse(Console.ReadLine());
                playerNumbers.Add(number);
            }

            // Vérifier combien de numéros correspondent
            int matches = lotteryNumbers.Intersect(playerNumbers).Count();

            return View();
        }
        [HttpPost]
        public IActionResult Index(GameViewModel model)
        {
            //vue des réusultats plus tard -> reddirect to actions
            return View();
        }
        //ceée une method httpget 

    }
}
