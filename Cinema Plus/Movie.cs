using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Plus;

internal class Movie
{
    public int Id { get; set; }
    public string? Country { get; set; }
    public string? MovieName { get; set; }
    public string? Director { get; set; }
    public string? Actors { get; set; }
    public double Time { get; set; }
    public string Genre { get; set; }
    public int AgeLimit { get; set; }
    public string ImageName { get; set; }

    public Movie() { }

    public Movie(int id, string? country, string? movieName, string? director, string? actors, double time, string genre, int ageLimit, string imageName)
    {
        Id = id;
        Country = country;
        MovieName = movieName;
        Director = director;
        Actors = actors;
        Time = time;
        Genre = genre;
        AgeLimit = ageLimit;
        ImageName = imageName;
    }

    public static Movie JsonToMovie(string? movie) { return new Movie(); }
}
