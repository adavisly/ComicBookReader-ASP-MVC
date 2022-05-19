using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookReader.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorBirthday { get; set; }
        public string AuthorImage { get; set; }
        public List<ComicBook> ComicBooks { get; set; } = new List<ComicBook>();
    }
}
