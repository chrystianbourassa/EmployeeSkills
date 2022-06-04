using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeSkill.Migrations
{
    public partial class init5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryID",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_CategoryID",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees_Skills",
                table: "Employees_Skills");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Skills_EmployeeID",
                table: "Employees_Skills");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "SubCategories");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryID",
                table: "SubCategories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Employee_SkillID",
                table: "Employees_Skills",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees_Skills",
                table: "Employees_Skills",
                columns: new[] { "EmployeeID", "SkillID" });

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_SubCategoryID",
                table: "SubCategories",
                column: "SubCategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_SubCategoryID",
                table: "SubCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees_Skills",
                table: "Employees_Skills");

            migrationBuilder.AlterColumn<int>(
                name: "SubCategoryID",
                table: "SubCategories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "SubCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Employee_SkillID",
                table: "Employees_Skills",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees_Skills",
                table: "Employees_Skills",
                column: "Employee_SkillID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryID",
                table: "SubCategories",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Skills_EmployeeID",
                table: "Employees_Skills",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryID",
                table: "SubCategories",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
