using RequestApp.Interfaces;
using RequestApp.Models;

namespace RequestApp.Mocks
{
    public class MockCategory : IMoviesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category
                    {
                        categoryName = "Аниме",
                        Description = "Японские мультики"
                    },
                    new Category
                    {
                        categoryName = "Русское кино",
                        Description = "Православное добро"
                    }
                };
            }
        }
    }
}
