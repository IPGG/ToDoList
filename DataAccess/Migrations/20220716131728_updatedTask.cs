using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class updatedTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AssigneeId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "AdigneeId",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "AssigneeId",
                table: "Tasks",
                newName: "AssigneeID");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_AssigneeId",
                table: "Tasks",
                newName: "IX_Tasks_AssigneeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AssigneeID",
                table: "Tasks",
                column: "AssigneeID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AssigneeID",
                table: "Tasks");

            migrationBuilder.RenameColumn(
                name: "AssigneeID",
                table: "Tasks",
                newName: "AssigneeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_AssigneeID",
                table: "Tasks",
                newName: "IX_Tasks_AssigneeId");

            migrationBuilder.AddColumn<int>(
                name: "AdigneeId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AssigneeId",
                table: "Tasks",
                column: "AssigneeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
