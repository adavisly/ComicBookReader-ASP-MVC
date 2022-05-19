using ComicBookReader.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ComicBookReader.Data
{
    public static class InitialData
    {
        public static void Initialize(AppDBContext context)
        {

            if (!context.ComicBooks.Any())
            {
                context.ComicBooks.AddRange(
                    new ComicBook
                    {
                        ComicBookId = 1,
                        ComicBookTitle = "Аватар: Легенда об Аанге - Поиск",
                        ComicBookLanguage = "English",
                        ComicBookCover = "",
                        ComicBookDescription = "Зуко и Азула ищут свою мать Урсу вместе с командой Аватара, которая пытается" +
                        "держать психически неуравновешенную принцессу под контролем",
                        ComicBookYear = 2014
                    });
                context.SaveChanges();
            }

            if (!context.Chapters.Any())
            {
                context.Chapters.AddRange(
                    new Chapter
                    {
                        ChapterId = 1,
                        ComicBookId = 1,
                        ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 1"
                    },
                    new Chapter
                    {
                        ChapterId = 2,
                        ComicBookId = 1,
                        ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 2"
                    },
                    new Chapter
                    {
                        ChapterId = 3,
                        ComicBookId = 1,
                        ChapterName = "Аватар: Легенда об Аанге - Поиск. Часть 3"
                    });
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
        }

    }
}
