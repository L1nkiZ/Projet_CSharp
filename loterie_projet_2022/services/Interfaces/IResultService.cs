using loterie_projet_2022.Models;

namespace loterie_projet_2022.services.Interfaces
{
    public interface IResultService
    {
        ResultViewModel checkResult(string codeGUID);
    }
}
