using Microsoft.EntityFrameworkCore.Migrations;

namespace DzEntityFramework1.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Auditions",
                table: "Tracks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1,
                column: "Rating",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2,
                column: "Rating",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3,
                column: "Rating",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4,
                column: "Rating",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5,
                column: "Rating",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 1,
                columns: new[] { "Auditions", "Rating", "Text" },
                values: new object[] { 12930.0, 10, "xxxxxxxxxxxxxxxxxx" });

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 2,
                columns: new[] { "Auditions", "Rating", "Text" },
                values: new object[] { 9728.0, 5, "xxxxxxxxxxxxxxxxxx" });

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 3,
                columns: new[] { "Auditions", "Rating", "Text" },
                values: new object[] { 1000000.0, 1, "xxxxxxxxxxxxxxxxxx" });

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 4,
                columns: new[] { "Auditions", "Rating", "Text" },
                values: new object[] { 29402.0, 4, "xxxxxxxxxxxxxxxxxx" });

            migrationBuilder.UpdateData(
                table: "Tracks",
                keyColumn: "TrackId",
                keyValue: 5,
                columns: new[] { "Auditions", "Rating", "Text" },
                values: new object[] { 18209.0, 7, "xxxxxxxxxxxxxxxxxx" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Auditions",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Albums");
        }
    }
}
