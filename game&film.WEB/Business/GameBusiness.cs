using game_film.DB.Models;
using game_film.WEB.Models;
using game_film.WEB.Services;
using Newtonsoft.Json;

namespace game_film.WEB.Business
{
    public class GameBusiness
    {
        Service service;

        public GameBusiness()
        {
            service = new Service();
        }

        
        /// <summary>
        /// Oyun eklerken kontrolleri yapar ve apiye datayı gönderir, sonrasında da bir return döner
        /// </summary>
        /// <param name="gameModelWeb"></param>
        /// <returns></returns>
		public string Add(GameModelWeb gameModelWeb)
        {
            string result = "";    
            if (gameModelWeb.gameName==null || gameModelWeb.gameCategoryId==null || gameModelWeb.state==null )
            {
                result = "NULL";
            }
            else
            {

                try
                {
                    var getData = service.Post(gameModelWeb, "", "Game/AddGame").ToString();
                    if (getData != null)
                    {
                        result = getData;
                    }
                }
                catch (Exception ex)
                {

                    result = ex.ToString();
                }
                
				
			}
            return result;                    
        }




    }
}
