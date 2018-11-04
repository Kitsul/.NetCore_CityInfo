using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Entities
{
    public class CityInfoContext : DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options) : base(options)
        {
            Database.Migrate();
        }
        public DbSet<City> Cities  { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest(){
                            Name = "Central Park",
                            Description = "The most visited urban park in the United States.",
                            CityId = 1
                        },
                         new PointOfInterest(){
                            Name = "Empire State Building",
                            Description = "A 102-story skyscraper located in Midtown Manhattan",
                            CityId = 1
                         }
                    }
                },
                new City
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cathedral that was never really finished.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest(){
                            Name = "Cathedral of Our lady",
                            Description = "A Gothic style cathedral, conceived by architects Jan and Pieter Appelmans.",
                            CityId = 2
                        },
                         new PointOfInterest(){
                            Name = "Antwerp Central Station",
                            Description = "The the finest example of railway architecture in Belgium.",
                            CityId = 2
                         }
                    }
                },
                new City
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with that big tower.",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest(){
                            Name = "Eiffel Tower",
                            Description = "A wrought iron lattice tower on the Champ de Mars, named after enginner Gustave",
                            CityId = 3
                        },
                         new PointOfInterest(){
                            Name = "The Louvre",
                            Description = "The world's largest museum.",
                            CityId = 3
                         }
                    }
                });
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
