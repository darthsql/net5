using Microsoft.EntityFrameworkCore;
using NET5_Sample.Models;

namespace NET5_Sample.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {

        }

        public DbSet<Movie> Movie { get; set; }
    }
}
