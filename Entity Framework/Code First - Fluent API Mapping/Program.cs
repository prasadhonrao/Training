using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First___Fluent_API_Mapping
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MovieContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().ToTable("MovieActor")
                                        .HasKey(key => key.Id)
                                        .Property(p => p.FirstName).IsRequired().HasMaxLength(50)
                                        
            modelBuilder.Entity<Movie>().HasKey(key => key.MovieId)
                                        .Property(p => p.Title).IsRequired().HasMaxLength(50);
                                        
            modelBuilder.Entity<Movie>().Property(p => p.ReleaseYear).IsOptional()
                                        .HasColumnName("ReleaseYear2")
                                        .HasColumnType("date");
                                        
                                        
        }
    }

    public class Actor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public List<Movie> Movies { get; set; }
    }

    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
