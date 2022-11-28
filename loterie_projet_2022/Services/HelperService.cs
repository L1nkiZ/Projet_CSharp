using loterie_projet_2022.Models;

namespace loterie_projet_2022.Services
{
    public class HelperService : IHelperService
    {
        private readonly IMaClasse _maClasse;
        public DateTime GetCurrentDate()
        {
            return DateTime.Now.Date;
        }

        public string GetCurrentTime()
        {
            //DateTime.Now.ToString("T");
            //DateTime.Now.ToString("HH:mm:ss");
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public HelperService(IMaClasse maClasse)
        { 
            _maClasse = maClasse;
        }

        public indexVueModel GetData()
        {
            //operation en bdd
            //intellogence
            //Buisness layer

            var name = "Maxome";
            var result = new indexVueModel
            {
                Age = 25,
                Name = name,
                Greetings = _maClasse.DisSalut(name),
                GetCurrentDate = GetCurrentDate(),
                GetCurrentTime = GetCurrentTime(),
            };

            return result;
        }
    }
}
