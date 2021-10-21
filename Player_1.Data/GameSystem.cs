using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_1.Data
{
    public class GameSystem
    {
        [Key]
        public int GamesSystemId { get; set; }
        [Required]
        public string GameSystemName { get; set; }
        public Guid UserId { get; set; }
    }
}
