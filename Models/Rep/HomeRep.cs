using Cinema.Data;
using Cinema.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models.Rep
{
    public class HomeRep
    {
        private readonly ApplicationDbContext db=null;

        public HomeRep()
        {
            db = new ApplicationDbContext();
        }

        public List<Movie> GetMovies()
        {
            var q = db.Movies.ToList();
            return q;
        }
    }
}
