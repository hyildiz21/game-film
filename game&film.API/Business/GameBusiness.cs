using game_film.API.Models;
using game_film.DB.Context;
using game_film.DB.Models;

namespace game_film.API.Business
{
	public class GameBusiness
	{
		GameAndFilmContext context;
		public GameBusiness()
		{ 
			context = new GameAndFilmContext();
		}

		public string AddGame(GameModelApi gameModelApi)
		{
			if (gameModelApi == null)
			{
				return "Error";
			}
			else
			{
				Game game = new Game
				{
					gameName = gameModelApi.gameName,
					gameCategoryId = gameModelApi.gameCategoryId,
					state = gameModelApi.state,
					isActive = true

				};
				context.Games.Add(game);
				context.SaveChanges();
				return "Success";
			}
			
		}
	}
}
