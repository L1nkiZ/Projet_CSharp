namespace loterie_projet_2022.Services
{
    public class MaClasse : IMaClasse
    {
        public String DisSalut()
        {
            return "Salut !";
        }

        public String DisSalut(string nom)
        {
            return "Salut " + nom + "!";
        }
    }
}
