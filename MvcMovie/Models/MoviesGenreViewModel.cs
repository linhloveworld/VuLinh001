using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcMovie.Models
{
    public class MoviesGenreViewModel
    {
        public List<Movies>? Movies { get; set; }
        public SelectList? Genre { get; set; } 
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
