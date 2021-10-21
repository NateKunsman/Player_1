using Player_1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_1.Model
{
    public class GameDetail
    {
        public int GameId { get; set; }

        public string GameName { get; set; }

        public virtual Genre GenreName { get; set; }
        public virtual GameSystem GameSystemName { get; set; }


    }
}
