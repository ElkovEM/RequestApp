namespace RequestApp.Models
{
    public class Movie
    {
        public int id { set; get; }

        public string? name { set; get; }

        public string? shortDescription { set; get; }

        public string? longDescription { set; get; }

        public string? image { set; get; }

        public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }
    }
}
