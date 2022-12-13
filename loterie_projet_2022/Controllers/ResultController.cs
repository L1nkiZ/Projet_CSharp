using Microsoft.AspNetCore.Mvc;

namespace loterie_projet_2022.Controllers
{
    public class ResultController : Controller
    {
        public IActionResult result(string result)
        {
            return View(result);
        }
    }
}
