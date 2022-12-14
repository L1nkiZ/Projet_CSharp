using loterie_projet_2022.Models;

namespace loterie_projet_2022.services.Interfaces
{
    public interface IGameService
    {
        void CreateTirage();

        string checkTirage(GameViewModel model);
    }
}
