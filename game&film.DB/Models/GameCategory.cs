using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_film.DB.Models
{
	[Table("GameCategories")]
	public class GameCategory
    {
        [Key] public int categoryId { get; set; }
        public string categoryName { get; set; }
        public bool isActive { get; set; }

    }
}
