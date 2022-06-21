using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ActorConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new DirectorConfiguration());
            modelBuilder.ApplyConfiguration(new PhotoConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new ActorMovieConfiguration());
        }

        public DbSet<Actor>? Actors { get; set; }
        public DbSet<Director>? Directors { get; set; }
        public DbSet<Genre>? Genres { get; set; }
        public DbSet<Photo>? Photos { get; set; }
        public DbSet<Movie>? Movies { get; set; }
        public DbSet<ActorMovie>? ActorMovies { get; set; }
    }
}
