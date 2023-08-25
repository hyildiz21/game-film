using game_film.DB.Context;
using game_film.DB.Models;
using game_film.WEB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace game_film.WEB.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetUser()
        {
            GameAndFilmContext context = new GameAndFilmContext();

            var user = context.Users.ToList();
            return Json(user);

        }

        public IActionResult AddUser(UserModel userWebModel)
        {
            GameAndFilmContext context = new GameAndFilmContext();

            User newUser = new User
            {
                name = userWebModel.name,
                lastname = userWebModel.lastname,
                username = userWebModel.username,
                password = userWebModel.password,
                email = userWebModel.email,

            };

            context.Users.Add(newUser);
            context.SaveChanges();
            return View("Index");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}