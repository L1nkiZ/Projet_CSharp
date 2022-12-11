using loterie_projet_2022.services.Interfaces;

namespace loterie_projet_2022.services
{
    public class GameService : IGameService
    {
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
    }
}
