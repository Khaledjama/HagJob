using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstApplication.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeelingId",
                table: "post",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Feelings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YourFeeling = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feelings", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_post_FeelingId",
                table: "post",
                column: "FeelingId");

            migrationBuilder.AddForeignKey(
                name: "FK_post_Feelings_FeelingId",
                table: "post",
                column: "FeelingId",
                principalTable: "Feelings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_post_Feelings_FeelingId",
                table: "post");

            migrationBuilder.DropTable(
                name: "Feelings");

            migrationBuilder.DropIndex(
                name: "IX_post_FeelingId",
                table: "post");

            migrationBuilder.DropColumn(
                name: "FeelingId",
                table: "post");
        }
    }
}
