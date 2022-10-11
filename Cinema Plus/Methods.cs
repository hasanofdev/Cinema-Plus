using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Cinema_Plus;

internal class Methods
{
    public static void DeserializeMovies(string fileName, ref List<Movie> movies)
    {
        var stringData = File.ReadAllText(fileName);
        if (movies is null) { movies = new List<Movie>(); }

        movies = JsonConvert.DeserializeObject<List<Movie>>(stringData);
    }
}
