using ComicBookReader.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ComicBookReader.Data
{
    public class InitialData
    {
        public static void Initialize(AppDBContext context)
        {
            ComicBook ComicBookAvatarTheSearch = new ComicBook
            {
                ComicBookId = 1,
                ComicBookTitle = "Аватар: Легенда об Аанге - Поиск",
                ComicBookLanguage = "English",
                ComicBookCover = "",
                ComicBookDescription = "Зуко и Азула ищут свою мать Урсу вместе с командой Аватара, которая пытается" +
                        "держать психически неуравновешенную принцессу под контролем",
                ComicBookYear = 2014
            };

            context.ComicBooks.Add(ComicBookAvatarTheSearch);

            Author AuthorAvatarTheSearch1 = new Author
            {
                AuthorId = 1,
                AuthorName = "Джин Луэнь Янг",
                AuthorBirthday = "9.08.1973",
                AuthorImage = ""
            };

            Author AuthorAvatarTheSearch2 = new Author
            {
                AuthorId = 2,
                AuthorName = "Гурихиру",
                AuthorBirthday = "",
                AuthorImage = ""
            };

            context.Authors.AddRange(AuthorAvatarTheSearch1, AuthorAvatarTheSearch2);
            ComicBookAvatarTheSearch.Authors.Add(AuthorAvatarTheSearch1);
            ComicBookAvatarTheSearch.Authors.Add(AuthorAvatarTheSearch2);

            Chapter ChapterAvatarTheSearch1 = new Chapter
            {
                ChapterId = 1,
                ComicBookId = 1,
                ComicBook = ComicBookAvatarTheSearch,
                ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 1"
            };

            Chapter ChapterAvatarTheSearch2 = new Chapter
            {
                ChapterId = 2,
                ComicBookId = 1,
                ComicBook = ComicBookAvatarTheSearch,
                ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 2"
            };

            Chapter ChapterAvatarTheSearch3 = new Chapter
            {
                ChapterId = 3,
                ComicBookId = 1,
                ComicBook = ComicBookAvatarTheSearch,
                ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 3"
            };

            

            Genre Drama = new Genre
            {
                GenreId = 1,
                GenreName = "Драма"
            };

            Genre Fantasy = new Genre
            {
                GenreId = 2,
                GenreName = "Фантастика"
            };

            Genre Adventure = new Genre
            {
                GenreId = 3,
                GenreName = "Приключения"
            };

            Genre Action = new Genre
            {
                GenreId = 4,
                GenreName = "Экшн"
            };

            Genre Detective = new Genre
            {
                GenreId = 5,
                GenreName = "Детектив"
            };

            Genre Horror = new Genre
            {
                GenreId = 6,
                GenreName = "Ужасы"
            };

            Genre Thriller = new Genre
            {
                GenreId = 7,
                GenreName = "Триллер"
            };

            Genre Tragedy = new Genre
            {
                GenreId = 8,
                GenreName = "Трагедия"
            };

            Genre Romance = new Genre
            {
                GenreId = 9,
                GenreName = "Романтика"
            };

            Genre Sport = new Genre
            {
                GenreId = 10,
                GenreName = "Спорт"
            };

            Genre Psychology = new Genre
            {
                GenreId = 11,
                GenreName = "Психология"
            };

            Genre SliceOfLife = new Genre
            {
                GenreId = 12,
                GenreName = "Повседневность"
            };

            Genre ScinceFiction = new Genre
            {
                GenreId = 13,
                GenreName = "Научная фантастика"
            };


            if (!context.ComicBooks.Any())
            {
                context.ComicBooks.AddRange(ComicBookAvatarTheSearch);
                context.SaveChanges();
            }

            if (!context.Chapters.Any())
            {
                context.Chapters.AddRange(ChapterAvatarTheSearch1, ChapterAvatarTheSearch2, ChapterAvatarTheSearch3);
                context.SaveChanges();
            }

            if (!context.ComicPages.Any())
            {
                int countPagesThePromise1 = new DirectoryInfo(@"/img/ComicBooks/Avatar_The_Promise/Part1").GetFiles().Length;
                for (int i = 0; i < countPagesThePromise1; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        ChapterId = 1,
                        PageImage = $"/img/ComicBooks/Avatar_The_Promise/Part1/the promise 1 ({i + 1}).jpg"
                    });
                }

                int countPagesThePromise2 = new DirectoryInfo(@"/img/ComicBooks/Avatar_The_Promise/Part2").GetFiles().Length;
                for (int i = 0; i < countPagesThePromise2; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        ChapterId = 2,
                        PageImage = $"/img/ComicBooks/Avatar_The_Promise/Part2/the promise 2 ({i + 1}).jpg"
                    });
                }

                int countPagesThePromise3 = new DirectoryInfo(@"/img/ComicBooks/Avatar_The_Promise/Part3").GetFiles().Length;
                for (int i = 0; i < countPagesThePromise3; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        ChapterId = 3,
                        PageImage = $"/img/ComicBooks/Avatar_The_Promise/Part3/the promise 3 ({i + 1}).jpg"
                    });
                }
                context.SaveChanges();
            }

            if (!context.Authors.Any())
            {
                context.Authors.AddRange(AuthorAvatarTheSearch1, AuthorAvatarTheSearch2);
            }
        }

        
    }
}
