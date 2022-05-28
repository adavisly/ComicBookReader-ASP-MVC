using Microsoft.AspNetCore.Mvc;

namespace ComicBookReader.Models
{
    public class CropModel
    {
        [HiddenInput]
        public int Top { get; set; }
        [HiddenInput]
        public int Bottom { get; set; }
        [HiddenInput]
        public int Left { get; set; }
        [HiddenInput]
        public int Right { get; set; }
        [HiddenInput]
        public int Width { get; set; }
        [HiddenInput]
        public int Height { get; set; }
    }
}
