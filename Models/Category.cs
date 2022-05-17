namespace RequestApp.Models
{
    public class Category
    {
        public int id { set; get; }

        public string? categoryName { set; get; }

        public string? Description { set; get; }

        public List<Movie>? Movies { set; get; }
    }
}
