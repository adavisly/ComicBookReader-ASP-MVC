using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComicBookReader.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string UserImage { get; set; }
        public List<ComicBook_User> ComicBookUsers { get; set; } = new List<ComicBook_User>();
    }
}
