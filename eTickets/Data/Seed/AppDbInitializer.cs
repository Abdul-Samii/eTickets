using eTickets.Models;

namespace eTickets.Data.Seed
{
  public class AppDbInitializer
  {
    public static void Seed(IApplicationBuilder applicationBuilder)
    {
      using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
      {
        var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
        context.Database.EnsureCreated();

        //Cinema
        if (!context.Cinemas.Any())
        {
          context.Cinemas.AddRange(new List<Cinema>()
          {
            new Cinema()
            {
              Name = "Cinema 1",
              Logo = "https://dotnethow.net/images/cinemas/cinema-1.jpeg",
              Description = "This is description"
            },
            new Cinema()
            {
              Name = "Cinema 2",
              Logo = "https://dotnethow.net/images/cinemas/cinema-2.jpeg",
              Description = "This is description"
            },
            new Cinema()
            {
              Name = "Cinema 3",
              Logo = "https://dotnethow.net/images/cinemas/cinema-3.jpeg",
              Description = "This is description"
            },
            new Cinema()
            {
              Name = "Cinema 4",
              Logo = "https://dotnethow.net/images/cinemas/cinema-5.jpeg",
              Description = "This is description"
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
              FullName = "Actor 1",
              Bio = "This is actor's bio",
              ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-1.jpeg"
            },
            new Actor()
            {
              FullName = "Actor 2",
              Bio = "This is actor's bio",
              ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-2.jpeg"
            },
            new Actor()
            {
              FullName = "Actor 3",
              Bio = "This is actor's bio",
              ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-3.jpeg"
            },
            new Actor()
            {
              FullName = "Actor 4",
              Bio = "This is actor's bio",
              ProfilePictureUrl = "https://dotnethow.net/images/actors/actor-4.jpeg"
            },
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
              Name = "Producer 1",
              Bio = "This is Producer's Bio",
              ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-1.jpeg"
            },
            new Producer()
            {
              Name = "Producer 2",
              Bio = "This is Producer's Bio",
              ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-2.jpeg"
            },
            new Producer()
            {
              Name = "Producer 3",
              Bio = "This is Producer's Bio",
              ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-3.jpeg"
            },
            new Producer()
            {
              Name = "Producer 4",
              Bio = "This is Producer's Bio",
              ProfilePictureUrl = "https://dotnethow.net/images/producers/producer-4.jpeg"
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
              Name = "Scoob",
              Description = "This is Scoob Movie Description",
              Price = 79,
              ImageURL = "https://dotnethow.net/images/movies/movie-1.jpeg",
              StartDate = DateTime.Now.AddDays(-10),
              EndDate = DateTime.Now.AddDays(-2),
              CinemaId = 1,
              ProducerId = 3,
              MovieCategory = Enums.MovieCategory.Action
            },
            new Movie()
            {
              Name = "Cold Soles",
              Description = "This is Cold Soles Description",
              Price = 79,
              ImageURL = "https://dotnethow.net/images/movies/movie-2.jpeg",
              StartDate = DateTime.Now.AddDays(-16),
              EndDate = DateTime.Now.AddDays(-3),
              CinemaId = 1,
              ProducerId = 3,
              MovieCategory = Enums.MovieCategory.Action
            },
            new Movie()
            {
              Name = "Hot beach",
              Description = "This is Hot beach Movie Description",
              Price = 79,
              ImageURL = "https://dotnethow.net/images/movies/movie-3.jpeg",
              StartDate = DateTime.Now.AddDays(-16),
              EndDate = DateTime.Now.AddDays(-2),
              CinemaId = 1,
              ProducerId = 3,
              MovieCategory = Enums.MovieCategory.Drama
            },
            new Movie()
            {
              Name = "West House",
              Description = "This is West House Movie Description",
              Price = 79,
              ImageURL = "https://dotnethow.net/images/movies/movie-4.jpeg",
              StartDate = DateTime.Now.AddDays(-19),
              EndDate = DateTime.Now.AddDays(-2),
              CinemaId = 1,
              ProducerId = 3,
              MovieCategory = Enums.MovieCategory.Documentary
            },
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
              MovieId = 2,
            },
            new Actor_Movie()
            {
              ActorId = 2,
              MovieId = 1,
            },
            new Actor_Movie()
            {
              ActorId = 4,
              MovieId = 1,
            },
            new Actor_Movie()
            {
              ActorId = 2,
              MovieId = 2,
            },
            new Actor_Movie()
            {
              ActorId = 3,
              MovieId = 3,
            },
            new Actor_Movie()
            {
              ActorId = 4,
              MovieId = 4,
            },
            new Actor_Movie()
            {
              ActorId = 3,
              MovieId = 2,
            },
          });
          context.SaveChanges();
        }
      }
    }
  }
}
