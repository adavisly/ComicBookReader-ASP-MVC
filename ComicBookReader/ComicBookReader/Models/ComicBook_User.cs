using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookReader.Models
{
    public class ComicBook_User
    {
        [Key, Column(Order = 0)]
        public int ComicBookId { get; set; }
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
        public ComicBook ComicBook { get; set; }
        public User User { get; set; }
        public bool IsFavourite { get; set; }
        public string ReadingStatus { get; set; }
        public string ComicBookReview { get; set; }
        public int ComicBookMark { get; set; }
        public int LastPage { get; set; }
        
    }
}
