using ComicBookReader.Models;
using System.Linq;

namespace ComicBookReader.Data
{
    public static class InitialData
    {
        public static void Initialize(ComicBookReaderContext context)
        {
            if (!context.ComicBooks.Any())
            {
                context.ComicBooks.AddRange(
                    new ComicBook
                    {
                        ComicBookTitle = "Аватар: Легенда об Аанге - Поиск",
                        ComicBookLanguage = "English",
                        ComicBookCover = "",
                        ComicBookDescription = "Зуко и Азула ищут свою мать Урсу вместе с командой Аватара, которая пытается" +
                        "держать психически неуравновешенную принцессу под контролем",
                        ComicBookYear = 2014
                    });
            }
        }
    }
}
