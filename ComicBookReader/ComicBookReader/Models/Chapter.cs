using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookReader.Models
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        public int ComicBookId { get; set; }
        public ComicBook ComicBook { get; set; }
        public string ChapterName { get; set; }
        public List<ComicPage> ComicPages { get; set; } = new List<ComicPage>();
    }
}
