using Player_1.Data;
using Player_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_1.Service
{
    public class GameService
    {
        private readonly Guid _userId;

        public GameService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateGame(GameCreate model)
        {
            var entity = new Game()
            {
                GameName = model.GameName,
                GenreId = model.GenreId,
                GameSystemId = model.GameSystemId
            };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.Games.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<GameDetail> GetGames()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .Games
                    //.Where(e => e.UserId == _userId)
                    .Select(e => new GameDetail { GameId = e.GameId, GameName = e.GameName, GameSystemName = e.GameSystem, GenreName = e.Genre });
                return query.ToArray();
            }
        }
    }
}
