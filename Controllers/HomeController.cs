using Microsoft.AspNetCore.Mvc;
using RequestApp.Interfaces;
using RequestApp.ViewModels;

namespace RequestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllMovies _allMovies;
        private readonly IMoviesCategory _allCaterogies;

        public HomeController(IAllMovies iAllMovies, IMoviesCategory iMoviesCat)
        {
            _allMovies = iAllMovies;
            _allCaterogies = iMoviesCat;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Страница с фильмами";
            MoviesListViewModel obj = new MoviesListViewModel();
            obj.allMovies = _allMovies.Movies;
            obj.currentCategory = "";

            return View(obj);
        }

    }
}
