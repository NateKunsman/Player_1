using Player_1.Data;
using Player_1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player_1.Service
{
    public class GenreService
    {
        private readonly Guid _UserId;

        public GenreService(Guid userId)
        {
            userId = _UserId;
        }
        public bool GenreCreate(GenreCreate model)
        {
            var entity =
                new Genre()
                {
                    UserId = _UserId,
                    GenreName = model.GenreName,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Genres.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteGenre(int genreId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Genres
                        .Single(e => e.GenreId == genreId) /*&& e.AuthorId == _genreId)*/;
                ctx.Genres.Remove(entity);
                return ctx.SaveChanges() == 1;
            }
        }

    }
}
