using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_1.Model
{
    public class GameSystemCreate
    {
        //Name of game system
        [Required]
        public string  GameSystemName { get; set; }
    }
}
