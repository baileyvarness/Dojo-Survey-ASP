using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurveyController.Controllers
{
    public class DojoSurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("method")]
        public IActionResult Method(string YourName, string DojoLocation, string FavoriteLanguage, string Comment)
        {
            ViewBag.YourName = YourName;
            ViewBag.DojoLocation = DojoLocation;
            ViewBag.FavoriteLanguage = FavoriteLanguage;
            ViewBag.Comment = Comment;
            return View("Result");
        }

        [HttpGet]
        [Route("/result")]
        public ViewResult Result()
        {
            return View("Result");
        }
    }

}