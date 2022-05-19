using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ComicBookReader.Models
{
    public class ComicBook
    {
        public int ComicBookId { get; set; }
        [Required]
        public string ComicBookTitle { get; set; }
        public string ComicBookLanguage { get; set; }
        public string ComicBookCover { get; set; }
        public string ComicBookDescription { get; set; }
        public int ComicBookYear { get; set; }
        public List<ComicBook_User> ComicBookUsers { get; set; } = new List<ComicBook_User>();
        public List<Author> Authors { get; set; } = new List<Author>();
        public List<Genre> Genres { get; set; } = new List<Genre>();
        public List<Chapter> Chapters { get; set; } = new List<Chapter>();

    }
}
