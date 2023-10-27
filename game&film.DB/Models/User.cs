using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_film.DB.Models
{
    [Table("Users")]
    public class User
    {
        public int userId { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int roleId { get; set; }

        public bool isLogin { get; set; } //kullanıcı 1 kere giriş yaptığında ilLogin=1 
        public bool isDeleted { get; set; } //kullanıcı silinirse true olur


    }
}
