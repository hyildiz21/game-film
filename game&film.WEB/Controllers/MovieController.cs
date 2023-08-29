using Microsoft.AspNetCore.Mvc;

namespace game_film.WEB.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
