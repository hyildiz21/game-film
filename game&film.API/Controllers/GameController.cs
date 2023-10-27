using game_film.API.Business;
using game_film.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace game_film.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class GameController : ControllerBase
	{
		
		public GameController() 
		{
			
		}

		[HttpPost("AddGame")]
		public string AddGame([FromBody] GameModelApi gameModelApi)
		{
			var result = new GameBusiness().AddGame(gameModelApi);
			return result;
		}
	}
}
