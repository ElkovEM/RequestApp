using RequestApp.Models;

namespace RequestApp.Interfaces
{
    public interface IAllMovies
    {
        IEnumerable<Movie> Movies { get; }
        Movie GetMovie(int MovieID);
    }
}
