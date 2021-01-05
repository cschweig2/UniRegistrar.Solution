using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniRegistrar.Migrations
{
    public partial class AddDepartmentAndMajor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Enrollment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MajorId",
                table: "Enrollment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Majors",
                columns: table => new
                {
                    MajorId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MajorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majors", x => x.MajorId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_DepartmentId",
                table: "Enrollment",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_MajorId",
                table: "Enrollment",
                column: "MajorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Departments_DepartmentId",
                table: "Enrollment",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Majors_MajorId",
                table: "Enrollment",
                column: "MajorId",
                principalTable: "Majors",
                principalColumn: "MajorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Departments_DepartmentId",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Majors_MajorId",
                table: "Enrollment");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Majors");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_DepartmentId",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_MajorId",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "MajorId",
                table: "Enrollment");
        }
    }
}
