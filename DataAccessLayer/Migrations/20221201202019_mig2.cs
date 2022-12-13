using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BlogStatus",
                table: "Blogs",
                newName: "CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "BlogCount",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Blogs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId1",
                table: "Blogs",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Categoires_CategoryId1",
                table: "Blogs",
                column: "CategoryId1",
                principalTable: "Categoires",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Categoires_CategoryId1",
                table: "Blogs");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_CategoryId1",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogCount",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Blogs");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Blogs",
                newName: "BlogStatus");
        }
    }
}
