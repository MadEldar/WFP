using Microsoft.AspNetCore.Hosting;
using Movie_On_Demand.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Movie_On_Demand.Services
{
    public class MovieService
    {
        public MovieService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "movies.json"); }
        }

        public IEnumerable<Movie> GetMovies()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Movie[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public Movie GetMovie(int id)
        {
            return GetMovies().FirstOrDefault(x => x.ID == id);
        }

        public bool Rate(int id, int rating)
        {
            var movies = GetMovies();
            var movie = movies.FirstOrDefault(x => x.ID == id);
            if (movie == null)
            {
                return false;
            }
            movies.FirstOrDefault(x => x.ID == id).Ratings.Add(rating);
            //Debug.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(movies));
            File.WriteAllText(JsonFileName, Newtonsoft.Json.JsonConvert.SerializeObject(movies));
            return true;
        }
    }
}
