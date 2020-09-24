using Microsoft.AspNetCore.Mvc;
using Movie_On_Demand.Services;

namespace Movie_On_Demand.Controllers
{
    public class MoviesController : Controller
    {
        public MoviesController(MovieService movieService)
        {
            MoviesService = movieService;
        }

        public MovieService MoviesService { get; }

        [HttpGet]
        public IActionResult Index()
        {
            return View(MoviesService.GetMovies());
        }

        [HttpGet]
        [Route("Movies/Details/{id}")]
        public IActionResult Details(int id)
        {
            return View(MoviesService.GetMovie(id));
        }

        [HttpPost]
        [Route("Movies/Rate/{id}")]
        public RedirectResult Rate(int id, int rating)
        {
            if (MoviesService.Rate(id, rating))
            {
                return Redirect("/Movies/Details/" + id);
            }
            else
            {
                return Redirect("/Movies");
            }
        }
    }
}
