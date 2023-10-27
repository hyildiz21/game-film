using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_film.API.Models
{
    public class GameModelApi
    {
        public int gameId { get; set; }
        public string? gameName { get; set; }
        public int? gameCategoryId { get; set; }
        public byte? state { get; set; } // 0:oynadım - 1: oynuyor - 2: oynayacak
        public bool? isActive { get; set; } // 0: aktif - 1: pasif

    }
}
