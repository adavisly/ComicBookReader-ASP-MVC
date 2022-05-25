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

            
            if (!context.ComicBooks.Any())
            {
                ComicBook ComicBookAvatarTheSearch = new ComicBook
                {
                    ComicBookTitle = "Аватар: Легенда об Аанге - Поиск",
                    ComicBookLanguage = "English",
                    ComicBookCover = "/img/ComicBooks/Avatar_The_Promise/cover.jpg",
                    ComicBookDescription = "Зуко и Азула ищут свою мать Урсу вместе с командой Аватара, которая пытается" +
                            "держать психически неуравновешенную принцессу под контролем",
                    ComicBookYear = 2014
                };

                context.ComicBooks.Add(ComicBookAvatarTheSearch);

                Author AuthorAvatarTheSearch1 = new Author
                {
                    AuthorName = "Джин Луэнь Янг",
                    AuthorBirthday = "9.08.1973",
                    AuthorImage = ""
                };

                Author AuthorAvatarTheSearch2 = new Author
                {
                    AuthorName = "Гурихиру",
                    AuthorBirthday = "",
                    AuthorImage = ""
                };

                context.Authors.AddRange(AuthorAvatarTheSearch1, AuthorAvatarTheSearch2);

                Genre Drama = new Genre
                {
                    GenreName = "Драма"
                };

                Genre Fantasy = new Genre
                {
                    GenreName = "Фантастика"
                };

                Genre Adventure = new Genre
                {
                    GenreName = "Приключения"
                };

                Genre Action = new Genre
                {
                    GenreName = "Экшн"
                };

                Genre Detective = new Genre
                {
                    GenreName = "Детектив"
                };

                Genre Horror = new Genre
                {
                    GenreName = "Ужасы"
                };

                Genre Thriller = new Genre
                {
                    GenreName = "Триллер"
                };

                Genre Tragedy = new Genre
                {
                    GenreName = "Трагедия"
                };

                Genre Romance = new Genre
                {
                    GenreName = "Романтика"
                };

                Genre Sport = new Genre
                {
                    GenreName = "Спорт"
                };

                Genre Psychology = new Genre
                {
                    GenreName = "Психология"
                };

                Genre SliceOfLife = new Genre
                {
                    GenreName = "Повседневность"
                };

                Genre ScinceFiction = new Genre
                {
                    GenreName = "Научная фантастика"
                };

                context.Genres.AddRange(Drama, Fantasy, Adventure, Action, Detective, Horror, Thriller, Tragedy, Romance, Sport, Psychology, SliceOfLife, ScinceFiction);

                ComicBookAvatarTheSearch.Authors.Add(AuthorAvatarTheSearch1);
                ComicBookAvatarTheSearch.Authors.Add(AuthorAvatarTheSearch2);

                ComicBookAvatarTheSearch.Genres.Add(Drama);
                ComicBookAvatarTheSearch.Genres.Add(Fantasy);
                ComicBookAvatarTheSearch.Genres.Add(Adventure);
                ComicBookAvatarTheSearch.Genres.Add(Action);

                Chapter ChapterAvatarTheSearch1 = new Chapter
                {
                    ComicBook = ComicBookAvatarTheSearch,
                    ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 1"
                };

                Chapter ChapterAvatarTheSearch2 = new Chapter
                {
                    ComicBook = ComicBookAvatarTheSearch,
                    ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 2"
                };

                Chapter ChapterAvatarTheSearch3 = new Chapter
                {
                    ComicBook = ComicBookAvatarTheSearch,
                    ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 3"
                };

                context.Chapters.AddRange(ChapterAvatarTheSearch1, ChapterAvatarTheSearch2, ChapterAvatarTheSearch3);

                //int countPagesThePromise1 = new DirectoryInfo("wwwroot/img/ComicBooks/Avatar_The_Promise/Part1").GetFiles().Length;
                for (int i = 0; i < 82; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        Chapter = ChapterAvatarTheSearch1,
                        PageImage = $"/img/ComicBooks/Avatar_The_Promise/Part1/the promise 1 ({i + 1}).jpg",
                        PageNumber = i + 1
                    });
                }

                //int countPagesThePromise2 = new DirectoryInfo("wwwroot/img/ComicBooks/Avatar_The_Promise/Part2").GetFiles().Length;
                for (int i = 0; i < 83; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        Chapter = ChapterAvatarTheSearch2,
                        PageImage = $"/img/ComicBooks/Avatar_The_Promise/Part2/the promise 2 ({i + 1}).jpg",
                        PageNumber = i + 1
                    });
                }

                //int countPagesThePromise3 = new DirectoryInfo("wwwroot/img/ComicBooks/Avatar_The_Promise/Part3").GetFiles().Length;
                for (int i = 0; i < 82; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        Chapter = ChapterAvatarTheSearch3,
                        PageImage = $"/img/ComicBooks/Avatar_The_Promise/Part3/the promise 3 ({i + 1}).jpg",
                        PageNumber = i + 1
                    });
                }
                context.SaveChanges();
            }
            
        }

        
    }
}
