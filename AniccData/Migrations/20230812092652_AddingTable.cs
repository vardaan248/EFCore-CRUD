using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AniccData.Migrations
{
    /// <inheritdoc />
    public partial class AddingTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.CreateTable(
                name: "StudentsCSV",
                columns: table => new
                {
                    Student_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalITy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceofBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    raisedhands = table.Column<int>(type: "int", nullable: false),
                    VisITedResources = table.Column<int>(type: "int", nullable: false),
                    AnnouncementsView = table.Column<int>(type: "int", nullable: false),
                    Discussion = table.Column<int>(type: "int", nullable: false),
                    ParentAnsweringSurvey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentschoolSatisfaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentAbsenceDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_Marks = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCSV", x => x.Student_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsCSV");

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Student_ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AnnouncementsView = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discussion = table.Column<int>(type: "int", nullable: false),
                    GradeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalITy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAnsweringSurvey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentschoolSatisfaction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlaceofBirth = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relation = table.Column<int>(type: "int", nullable: false),
                    SectionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Semester = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentAbsenceDays = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Student_Marks = table.Column<int>(type: "int", nullable: false),
                    Topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisITedResources = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    raisedhands = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Student_ID);
                });
        }
    }
}
