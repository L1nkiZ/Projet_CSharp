using loterie_projet_2022.Models;
using loterie_projet_2022.services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace loterie_projet_2022.Controllers
{
    public class ResultController : Controller
    {
        private readonly IResultService _resultService;
        public ResultController(IResultService resultService)
        {
            _resultService = resultService;
        }

        [HttpGet]
        public IActionResult result()
        {
            ResultViewModel model = new ResultViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult result(ResultViewModel model)
        {
            var ModelWithResult = _resultService.checkResult(model.code);
            return View(ModelWithResult);
        }
    }
}
