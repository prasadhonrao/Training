using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;

namespace Code_First___Data_Annotations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new DropCreateDatabaseAlways<MovieContext>());

            using (var context = new MovieContext())
            {
                try
                {
                    var newActor = new Actor
                    {
                        FirstName = "P",
                        LastName = "Honrao",
                        BirthDate = DateTime.Now.AddYears(-35)
                    };

                    context.Actors.Add(newActor);
                    context.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var item in ex.EntityValidationErrors)
                    {
                        Console.WriteLine(item.ValidationErrors.First().ErrorMessage);
                    }
                }
            }

            Console.WriteLine("Press [Enter] to exit...");
            Console.ReadLine();
        }
    }

    public class MovieContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }

    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "LastName missing")]
        [MinLength(2, ErrorMessage = "LastName is too short")]
        [MaxLength(50, ErrorMessage = "LastName cannot exceed more than 50 characters")]
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }
        public List<Movie> Movies { get; set; }
    }

    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        public string Title { get; set; }

        public string ReleaseYear { get; set; }

        public List<Actor> Actors { get; set; }
    }
}
