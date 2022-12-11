using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Game
    {
        public int game_id { get; set; }
        public DateTime GetCurrentDate { get; set; }
        public int choux { get; set; }
        public string num_draw { get; set; }

        [InverseProperty(nameof(Player.game))]

        public List<Player> players { get; set; }
    }
}
