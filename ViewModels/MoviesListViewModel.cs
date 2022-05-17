using RequestApp.Models;

namespace RequestApp.ViewModels
{
    public class MoviesListViewModel
    {
        public IEnumerable<Movie>? allMovies { get; set; }

        public string? currentCategory { get; set; }
    }
}
