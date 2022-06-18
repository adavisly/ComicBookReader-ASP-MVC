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

                ComicBook ComicBookMajorGrom = new ComicBook
                {
                    ComicBookTitle = "Майор Гром",
                    ComicBookLanguage = "Russian",
                    ComicBookCover = "/img/ComicBooks/Major_Grom/mg_cover.jpeg",
                    ComicBookDescription = "Основное действие комикса происходит в альтернативном Санкт-Петербурге. " +
                    "Главный герой серии — майор полиции по имени Игорь Гром, известный своим непримиримым отношением " +
                    "к преступности, честностью, неподкупностью, а также детективными способностями и навыками рукопашного боя.",
                    ComicBookYear = 2012
                };

                ComicBook ComicBookAttackOnTitan = new ComicBook
                {
                    ComicBookTitle = "Атака титанов",
                    ComicBookLanguage = "Japanese",
                    ComicBookCover = "/img/ComicBooks/Attack_On_Titan/snk_cover.png",
                    ComicBookDescription = "Давным-давно человечество было всего лишь «их» кормом, до тех пор, пока оно не " +
                    "построило гигантскую стену вокруг своей страны. С тех пор прошло сто лет мира и большинство людей жили " +
                    "счастливой, беззаботной жизнью. Но за долгие годы спокойствия пришлось заплатить огромную цену, " +
                    "и в 845 году они снова познали чувство ужаса и беспомощности – стена, которая была их единственным " +
                    "спасением, пала. «Они» прорвались. Половина человечества съедена, треть территории навсегда потеряна...",
                    ComicBookYear = 2009
                };

                context.ComicBooks.Add(ComicBookAvatarTheSearch);
                context.ComicBooks.Add(ComicBookMajorGrom);
                context.ComicBooks.Add(ComicBookAttackOnTitan);

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
                /*
                Author AuthorMajorGrom1 = new Author
                {
                    AuthorName = "Артём Габрелянов",
                    AuthorBirthday = "9.02.1987",
                    AuthorImage = ""
                };

                Author AuthorAoT = new Author
                {
                    AuthorName = "Хадзиме Исаяма",
                    AuthorBirthday = "9.02.1987",
                    AuthorImage = ""
                };
                */
                context.Authors.AddRange(AuthorAvatarTheSearch1, AuthorAvatarTheSearch2);
                //context.Authors.Add(AuthorMajorGrom1);

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

                //ComicBookMajorGrom.Authors.Add(AuthorMajorGrom1);

                ComicBookAvatarTheSearch.Genres.Add(Drama);
                ComicBookAvatarTheSearch.Genres.Add(Fantasy);
                ComicBookAvatarTheSearch.Genres.Add(Adventure);
                ComicBookAvatarTheSearch.Genres.Add(Action);

                ComicBookMajorGrom.Genres.Add(Drama);
                ComicBookMajorGrom.Genres.Add(Adventure);
                ComicBookMajorGrom.Genres.Add(Action);

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

                Chapter ChapterMajorGrom1 = new Chapter
                {
                    ComicBook = ComicBookMajorGrom,
                    ChapterName = "Глава 1"
                };

                Chapter ChapterMajorGrom2 = new Chapter
                {
                    ComicBook = ComicBookMajorGrom,
                    ChapterName = "Глава 2"
                };

                Chapter ChapterAoT1 = new Chapter
                {
                    ComicBook = ComicBookAttackOnTitan,
                    ChapterName = "Глава 1"
                };

                context.Chapters.AddRange(ChapterAvatarTheSearch1, ChapterAvatarTheSearch2, ChapterAvatarTheSearch3);

                context.Chapters.AddRange(ChapterMajorGrom1, ChapterMajorGrom2);

                context.Chapters.Add(ChapterAoT1);

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

                for (int i = 0; i < 33; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        Chapter = ChapterMajorGrom1,
                        PageImage = $"/img/ComicBooks/Major_Grom/ch1/{i + 1}.jpg",
                        PageNumber = i + 1
                    });
                }

                for (int i = 0; i < 23; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        Chapter = ChapterMajorGrom2,
                        PageImage = $"/img/ComicBooks/Major_Grom/ch2/{i + 1}.jpg",
                        PageNumber = i + 1
                    });
                }

                for (int i = 0; i < 15; i++)
                {
                    context.ComicPages.Add(
                    new ComicPage
                    {
                        Chapter = ChapterAoT1,
                        PageImage = $"/img/ComicBooks/Attack_On_Titan/ch1/aot ({i + 1}).jpg",
                        PageNumber = i + 1
                    });
                }

                context.SaveChanges();
            }
            
        }

        
    }
}
