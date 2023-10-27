using game_film.DB.Models;
using game_film.WEB.Business;
using game_film.WEB.Models;
using game_film.WEB.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Newtonsoft.Json;

namespace game_film.WEB.Controllers
{
    public class GameController : Controller
    {
        
        
        public GameController() 
        {
           
        }

       
        public IActionResult Index()
        {

            return View();
        }

		public string AddGameJson(GameModelWeb gameModelWeb)
        {
			return new GameBusiness().Add(gameModelWeb);
                    
        }


    }
}
