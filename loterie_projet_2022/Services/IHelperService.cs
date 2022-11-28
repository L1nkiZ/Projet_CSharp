using loterie_projet_2022.Models;

namespace loterie_projet_2022.Services
{
    public interface IHelperService
    {
        DateTime GetCurrentDate();
        string GetCurrentTime();
        indexVueModel GetData();
    }
}
