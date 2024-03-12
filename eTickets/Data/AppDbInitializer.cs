using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.Migrate();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Id=1,
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                             Id=2,
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the second cinema"
                        },
                        new Cinema()
                        {
                             Id=3,
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the third cinema"
                        },
                        new Cinema()
                        {
                             Id=4,
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the fourth cinema"
                        },
                        new Cinema()
                        {
                             Id=5,
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the fifth cinema"
                        },
                    });
                    context.SaveChanges();
                }

                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                             Id=1,
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://static.toiimg.com/thumb/58376589.cms?width=170&height=240"
                        },
                          new Actor()
                        {
                             Id=2,
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Aparna_Balamurali.png/330px-Aparna_Balamurali.png"
                        },
                        new Actor()
                        {
                             Id=3,
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/74/Sreenath_Bhasi_latest_.jpg/330px-Sreenath_Bhasi_latest_.jpg"
                        },
                        new Actor()
                        {
                             Id=4,
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the third actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/SoubinShahir.jpg/330px-SoubinShahir.jpg"
                        },
                        new Actor()
                        {
                             Id=5,
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the fourth actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/94/Robert_Downey_Jr_2014_Comic_Con_%28cropped%29.jpg/330px-Robert_Downey_Jr_2014_Comic_Con_%28cropped%29.jpg"
                        },
                        new Actor()
                        {
                             Id=6,
                            FullName = "Actor 6",
                            Bio = "This is the Bio of the fifth actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8d/ChrisEvans2023.jpg/330px-ChrisEvans2023.jpg"
                        },
                        new Actor()
                        {
                            Id=7,
                            FullName = "Actor 7",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Shah_Rukh_Khan_graces_the_launch_of_the_new_Santro.jpg/330px-Shah_Rukh_Khan_graces_the_launch_of_the_new_Santro.jpg"
                        },
                        new Actor()
                        {
                            Id=8,
                            FullName = "Actor 8",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/1/15/Taapsee_Pannu_in_March_2022.jpg"
                        },
                         new Actor()
                        {
                             Id=9,
                            FullName = "Actor 9",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            Id=10,
                            FullName = "Actor 10",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            Id=11,
                            FullName = "Actor 11",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            Id=12,
                            FullName = "Actor 12",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                             Id=1,
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first producer",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2b/SoubinShahir.jpg/330px-SoubinShahir.jpg"
                        },
                        new Producer()
                        {
                             Id=2,
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second producer",
                            ProfilePictureURL = "https://t0.gstatic.com/licensed-image?q=tbn:ANd9GcQWcKbDfu6PgoueHO0msUYvHGUF7Tpt8gLJkKRe5JMklXxJADVs53sEeRT7muGX2Aml"
                        },
                        new Producer()
                        {
                             Id=3,
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the third producer",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2f/Gunnet_Monga.jpg/330px-Gunnet_Monga.jpg"
                        },
                        new Producer()
                        {
                             Id=4,
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the fourth producer",
                            ProfilePictureURL = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSf0zUzLJ6EwcxbTxnQR89py_ElVGqjaLOXWbN--EGF8W2tnzQq"
                        },
                        new Producer()
                        {
                             Id=5,
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the fifth producer",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        },
                         new Producer()
                        {
                            Id=6,
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                    });
                    context.SaveChanges();
                }

                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                             Id=1,
                            Name = "Soorarai pottru",
                            Description = "This is the Life movie description",
                            Price = 120,
                            ImageURL = "https://pbs.twimg.com/media/EJAUBcAUYAEHuBq?format=jpg&name=4096x4096",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Id=2,
                            Name = "Manjummel Boys",
                            Description = "This is the Manjummel Boys description",
                            Price = 200,
                            ImageURL = "https://img.onmanorama.com/content/dam/mm/en/entertainment/entertainment-news/images/2024/2/10/manjummel-boys.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                             Id=3,
                            Name = "Avengers",
                            Description = "This is the Avengers description",
                            Price = 390,
                            ImageURL = "https://i.etsystatic.com/37166133/r/il/60f034/4087791906/il_570xN.4087791906_jcbj.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Id=4,
                            Name = "Dunki",
                            Description = "This is the Dunki description",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/M/MV5BMzQ0NDRhNmItYzllYS00NDdlLTk0YTctZDQ5YmFkYjdkNDcyXkEyXkFqcGdeQXVyNTYwMzA0MTM@._V1_FMjpg_UX1000_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Id=5,
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 6,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                             Id=6,
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }

                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 6,
                            MovieId = 3
                        },

                        new Actor_Movie()
                        {
                            ActorId = 7,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 8,
                            MovieId = 4
                        },

                        new Actor_Movie()
                        {
                            ActorId = 9,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 12,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 10,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 11,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 12,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

        public static async Task SeedUsersAndRolesAsync(IServiceProvider serviceProvider)
        {
            using (var serviceScope = serviceProvider.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetRequiredService<AppDbContext>();

                // Ensure the database is created and migrations are applied
                context.Database.Migrate();

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                // Check if roles exist before creating them
                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));

                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                // Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                string adminUserEmail = "admin@etickets.com";
                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);

                if (adminUser == null)
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@etickets.com";
                var appUser = await userManager.FindByEmailAsync(appUserEmail);

                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }

    

}
}
