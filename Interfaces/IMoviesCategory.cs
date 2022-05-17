using RequestApp.Models;

namespace RequestApp.Interfaces
{
    public interface IMoviesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
