using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess_ClassLibrary.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    PublishingId = table.Column<int>(type: "int", nullable: false),
                    AmountOfPages = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    PublishingYear = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    PriceToSell = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    PromotionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PromotionsName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.PromotionsId);
                });

            migrationBuilder.CreateTable(
                name: "Publishings",
                columns: table => new
                {
                    PublishingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublishingName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishings", x => x.PublishingId);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLientId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                });

            migrationBuilder.CreateTable(
                name: "Trays",
                columns: table => new
                {
                    TrayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trays", x => x.TrayId);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Edward", "Sweeney" },
                    { 2, "Elodie", "Richardson" },
                    { 3, "Harley", "Bloggs" },
                    { 4, "Saba", "Vaughan" },
                    { 5, "Ada", "Hahn" },
                    { 6, "Christine", "Kirby" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AmountOfPages", "AuthorId", "BookName", "Cost", "GenreId", "PriceToSell", "PublishingId", "PublishingYear" },
                values: new object[,]
                {
                    { 8, 525, 4, "Means Without Courage", 820.0, 2, 972.0, 3, 2023 },
                    { 6, 728, 1, "Foes And Cats", 305.0, 5, 604.0, 2, 2021 },
                    { 5, 739, 6, "Foes And Gangsters", 399.0, 3, 490.0, 3, 2005 },
                    { 7, 253, 2, "Choice With Gold", 302.0, 1, 492.0, 1, 2016 },
                    { 3, 493, 1, "Witches Of The Ancients", 699.0, 5, 1200.0, 3, 2020 },
                    { 2, 572, 5, "Man Of The Eternal", 100.0, 2, 300.0, 1, 2019 },
                    { 1, 382, 3, "Warrior Of The Curse", 299.0, 4, 400.0, 2, 2023 },
                    { 4, 395, 2, "Girls Of Hell", 1099.0, 1, 1698.0, 1, 2017 }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ClientId", "Login", "Password" },
                values: new object[,]
                {
                    { 1, "sullen", "KBSkNeKu" },
                    { 2, "real", "GLmATFfF" },
                    { 3, "immediate", "g9H4r6pC" },
                    { 4, "blackbird", "eaxH9cMk" },
                    { 5, "grapefruit", "xvMhDaqK" },
                    { 6, "trice", "Wh5XRHzu" },
                    { 7, "edge", "xvMhDaqK" },
                    { 8, "taco", "" },
                    { 9, "bale", "" },
                    { 10, "tacit", "BWGncz5f" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[,]
                {
                    { 5, "Dystopian" },
                    { 4, "Westerns" },
                    { 1, "Fantasy" },
                    { 2, "Mystery" },
                    { 3, "Romance" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "PromotionsId", "Discount", "PromotionsName" },
                values: new object[,]
                {
                    { 1, 94.0, "Chrome book shop" },
                    { 2, 31.0, "Suburban book shop" },
                    { 3, 75.0, "Viral book shop" },
                    { 4, 294.0, "Wonderland book shop" },
                    { 5, 12.0, "Mate book shop" }
                });

            migrationBuilder.InsertData(
                table: "Publishings",
                columns: new[] { "PublishingId", "PublishingName" },
                values: new object[,]
                {
                    { 1, "Brainy Publications" },
                    { 2, "Ink n Paper Press" },
                    { 3, "Wordsmith Literature" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "Amount", "BookId", "CLientId", "Date", "Price" },
                values: new object[,]
                {
                    { 8, 1, 7, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 274.0 },
                    { 7, 7, 5, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 627.0 },
                    { 6, 4, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 273.0 },
                    { 5, 6, 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 829.0 },
                    { 2, 8, 4, 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 382.0 }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "Amount", "BookId", "CLientId", "Date", "Price" },
                values: new object[,]
                {
                    { 3, 10, 6, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 135.0 },
                    { 1, 2, 2, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 272.0 },
                    { 4, 3, 8, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 826.0 }
                });

            migrationBuilder.InsertData(
                table: "Trays",
                columns: new[] { "TrayId", "Amount", "BookId", "ClientId" },
                values: new object[,]
                {
                    { 4, 12, 1, 6 },
                    { 1, 15, 2, 9 },
                    { 2, 3, 7, 2 },
                    { 3, 1, 4, 4 },
                    { 5, 7, 6, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Publishings");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Trays");
        }
    }
}
