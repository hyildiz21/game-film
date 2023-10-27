using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace game_film.WEB.Services
{
    public class Service
    {
        public object Post(object datas, string token, string route)
        {
            try
            {

                using (var client = new HttpClient())
                {
					client.BaseAddress = new Uri("https://localhost:7241/api/"); //local              
					if (!String.IsNullOrEmpty(token))
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    }
                    HttpRequestMessage requestMessage = new HttpRequestMessage();
                    var data = JsonConvert.SerializeObject(datas);
                    requestMessage.Content = new StringContent(data, Encoding.UTF8, "application/json");
                    var response = client.PostAsync(route, requestMessage.Content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsStringAsync().Result;
                    }
                    else { return null; }

                }

            }
            catch (Exception ex)
            {
                return null;

            }

        }

        public object Get(string token, string route)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:3000");
                    if (!String.IsNullOrEmpty(token))
                    {
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    }
                    var response = client.GetAsync(route).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsStringAsync().Result;
                    }
                    else { return null; }

                }

            }
            catch (Exception ex)
            {
                return null;

            }

        }
    }
}

