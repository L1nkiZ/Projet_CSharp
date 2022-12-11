using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Player
    {
        public int player_id { get; set; }
        public string guid_code { get; set; }
        public string num_draw_player { get; set; }
        public int score { get; set; }
        public int game_id { get; set; }

        [ForeignKey(nameof(game_id))]

        public Game game { get; set; }
    }
}
