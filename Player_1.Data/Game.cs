using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_1.Data
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        public string GameName { get; set; }

        public virtual Genre Genre { get; set; }
        [ForeignKey(nameof(Genre))]
        public int GenreId { get; set; }

        public virtual GameSystem GameSystem { get; set; }

        [ForeignKey(nameof(GameSystem))]
        public int GameSystemId { get; set; }

        public Guid UserId { get; set; }
    }
}
