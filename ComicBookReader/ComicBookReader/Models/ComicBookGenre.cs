using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComicBookReader.Models
{
    public class ComicBookGenre
    {
        [Key, Column(Order = 0)]
        public int ComicBooksComicBookId { get; set; }
        [Key, Column(Order = 1)]
        public int GenresGenreId { get; set; }
    }
}
