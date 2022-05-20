using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookReader.Models
{
    public class ComicPage
    {
        public int ComicPageId { get; set; }
        public int ChapterId { get; set; }
        public string PageImage { get; set; }
        public string PageTranslatedImage { get; set; }
        public virtual Chapter Chapter { get; set; }
    }
}
