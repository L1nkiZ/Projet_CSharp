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
    public class ResultService : IResultService
    {
        private readonly LoterieDbContext _ctx;
        public ResultService(LoterieDbContext ctx)
        {
            _ctx = ctx;
        }

        public ResultViewModel checkResult(string codeGUID)
        {
            var player = _ctx.Players.FirstOrDefault(p => p.guid_code == codeGUID);
            var game = _ctx.Games.FirstOrDefault(g => g.game_id == player.game_id);

            ResultViewModel model = new ResultViewModel()
            {
                player = player,
                game = game,
            };

            return model;
        }
    }
}
