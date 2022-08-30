using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorECommerceWebsiteCourse.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "A high school chemistry teacher diagnosed with inoperable lung cancer turns to manufacturing and selling methamphetamine in order to secure his family's future.", "https://flxt.tmsimg.com/assets/p185846_b_h9_ad.jpg", 9.99m, "Breaking Bad" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Set in a future where consciousness is digitized and stored, a prisoner returns to life in a new body and must solve a mind-bending murder to win his freedom.", "https://images.squarespace-cdn.com/content/v1/540efafce4b02e0dc20adb52/1520180035309-DVO0IGJFKF69ITB31Z6U/alteredcarbon.jpg?format=1500w", 4.99m, "Altered Carbon" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "A mockumentary on a group of typical office workers, where the workday consists of ego clashes, inappropriate behavior, and tedium.", "https://m.media-amazon.com/images/M/MV5BMDNkOTE4NDQtMTNmYi00MWE0LWE4ZTktYTc0NzhhNWIzNzJiXkEyXkFqcGdeQXVyMzQ2MDI5NjU@._V1_FMjpg_UX1000_.jpg", 5.99m, "The Office" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}
