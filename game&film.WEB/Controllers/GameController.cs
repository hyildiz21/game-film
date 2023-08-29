using Microsoft.AspNetCore.Mvc;

namespace game_film.WEB.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
