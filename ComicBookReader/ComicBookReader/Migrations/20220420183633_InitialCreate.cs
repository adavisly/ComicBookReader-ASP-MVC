using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicBookReader.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorBirthday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "ComicBooks",
                columns: table => new
                {
                    ComicBookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicBookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComicBookLanguage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicBookCover = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicBookDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicBookYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicBooks", x => x.ComicBookId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AuthorComicBook",
                columns: table => new
                {
                    AuthorsAuthorId = table.Column<int>(type: "int", nullable: false),
                    ComicBooksComicBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorComicBook", x => new { x.AuthorsAuthorId, x.ComicBooksComicBookId });
                    table.ForeignKey(
                        name: "FK_AuthorComicBook_Authors_AuthorsAuthorId",
                        column: x => x.AuthorsAuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorComicBook_ComicBooks_ComicBooksComicBookId",
                        column: x => x.ComicBooksComicBookId,
                        principalTable: "ComicBooks",
                        principalColumn: "ComicBookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    ChapterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComicBookId = table.Column<int>(type: "int", nullable: false),
                    ChapterName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.ChapterId);
                    table.ForeignKey(
                        name: "FK_Chapters_ComicBooks_ComicBookId",
                        column: x => x.ComicBookId,
                        principalTable: "ComicBooks",
                        principalColumn: "ComicBookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComicBookGenre",
                columns: table => new
                {
                    ComicBooksComicBookId = table.Column<int>(type: "int", nullable: false),
                    GenresGenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicBookGenre", x => new { x.ComicBooksComicBookId, x.GenresGenreId });
                    table.ForeignKey(
                        name: "FK_ComicBookGenre_ComicBooks_ComicBooksComicBookId",
                        column: x => x.ComicBooksComicBookId,
                        principalTable: "ComicBooks",
                        principalColumn: "ComicBookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComicBookGenre_Genres_GenresGenreId",
                        column: x => x.GenresGenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComicBook_Users",
                columns: table => new
                {
                    ComicBookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    IsFavourite = table.Column<bool>(type: "bit", nullable: false),
                    ReadingStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicBookReview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComicBookMark = table.Column<int>(type: "int", nullable: false),
                    LastPage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicBook_Users", x => new { x.ComicBookId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ComicBook_Users_ComicBooks_ComicBookId",
                        column: x => x.ComicBookId,
                        principalTable: "ComicBooks",
                        principalColumn: "ComicBookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComicBook_Users_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComicPages",
                columns: table => new
                {
                    ComicPageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    PageImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageTranslatedImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComicPages", x => x.ComicPageId);
                    table.ForeignKey(
                        name: "FK_ComicPages_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "ChapterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AuthorComicBook_ComicBooksComicBookId",
                table: "AuthorComicBook",
                column: "ComicBooksComicBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_ComicBookId",
                table: "Chapters",
                column: "ComicBookId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicBook_Users_UserId",
                table: "ComicBook_Users",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicBookGenre_GenresGenreId",
                table: "ComicBookGenre",
                column: "GenresGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_ComicPages_ChapterId",
                table: "ComicPages",
                column: "ChapterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuthorComicBook");

            migrationBuilder.DropTable(
                name: "ComicBook_Users");

            migrationBuilder.DropTable(
                name: "ComicBookGenre");

            migrationBuilder.DropTable(
                name: "ComicPages");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "ComicBooks");
        }
    }
}
