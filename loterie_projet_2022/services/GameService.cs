using CSharpVitamins;
using DataLayer;
using DataLayer.Models;
using loterie_projet_2022.Models;
using loterie_projet_2022.services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace loterie_projet_2022.services
{
    public class GameService : IGameService
    {
        private readonly LoterieDbContext _ctx;
        public GameService(LoterieDbContext ctx) 
        {
            _ctx = ctx;
        }

        public void CreateTirage()
        {
            // Générer des nombres aléatoires pour les numéros de la loterie
            Random rng = new Random();
            List<int> lotteryNumbers = new List<int>();
            while (lotteryNumbers.Count != 6)
            {
                int number = (rng.Next(1, 49));
                if (!lotteryNumbers.Contains(number))
                {
                    lotteryNumbers.Add(number);
                }
            }
        }

        public string checkTirage(GameViewModel model)
        {
            Game lastGame = _ctx.Games
                .OrderBy(d => d.GetCurrentDate)
                .LastOrDefault();

            var objGridPlayer = new Player()
            {
                guid_code = ShortGuid.NewGuid(),
                num_draw_player = model.player_number,
                game_id = lastGame.game_id,
            };

            _ctx.Players.Add(objGridPlayer);
            _ctx.SaveChanges();

            return objGridPlayer.guid_code;
        }
    }
}
