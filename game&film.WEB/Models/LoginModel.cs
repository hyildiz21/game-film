namespace game_film.WEB.Models
{
    public class LoginModel
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string? email { get; set; }
        //public string title { get; set; }
        //public int role { get; set; }

        public bool isDeleted { get; set; }
        public bool isLogin { get; set; }
        public string token { get; set; }

    }
}
