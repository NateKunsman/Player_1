using Player_1.Data;
using Player_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_1.Service
{
    public class GameSystemService
    {
        private readonly Guid _UserId;

        public GameSystemService(Guid userId)
        {
            _UserId = userId;
        }
    public bool CreateGameSystem(GameSystemCreate model)
    {
        var entity =
            new GameSystem()
            {
                GameSystemName = model.GameSystemName,
            };
        using (var ctx = new ApplicationDbContext())
        {
            ctx.GameSystems.Add(entity);
            return ctx.SaveChanges() == 1;
        }
    }

  }
}
