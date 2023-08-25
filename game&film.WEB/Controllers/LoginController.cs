using game_film.DB.Context;
using game_film.DB.Models;
using game_film.WEB.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Security.Claims;

namespace game_film.WEB.Controllers
{
   
    public class LoginController : Controller
    {

        GameAndFilmContext context;
        public LoginController()
        {
            context = new GameAndFilmContext();
        }



        public IActionResult Index(string message)
        {
            if (message != null)
            {
                ViewData["LoginError"] = message;

            }
            else
            {
                ViewData["LoginError"] = "";
            }
            return View();
        }


        public async Task<IActionResult> SignIn(UserModel userModel)
        {

            User user = context.Users.Where(x => x.username == userModel.username && x.password == userModel.password && x.isDeleted == false).FirstOrDefault();



            if (user != null)
            {
                //var userType = context.Users.Where(x => x.userId == user.userId).FirstOrDefault();

                var claim = new List<Claim>
                {new Claim(ClaimTypes.SerialNumber,user.userId.ToString()),
                 new Claim(ClaimTypes.Name,user.name ),
                 new Claim(ClaimTypes.Surname,user.lastname ),
                 new Claim(ClaimTypes.NameIdentifier,user.username),
                 new Claim(ClaimTypes.Actor,user.userId.ToString()),
                };

                var userIdentity = new ClaimsIdentity(claim, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");



            }
            else
            {
               //yanlış parola veya inputlar boş olursa ekrana message
                ViewData["LoginError"] = "Kullanıcı adı veya parola yanlış, tekrar deneyiniz!";
                return RedirectToAction("Index", "Login", new { message = ViewData["LoginError"].ToString() });


            }
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Index", "Login");
        }

    }
}
