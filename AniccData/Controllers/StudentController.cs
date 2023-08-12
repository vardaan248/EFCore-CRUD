using AniccData.Models;
using AniccData.Services.Interfaces;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace AniccData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService studentService { get; set; }

        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        // Add the record in the database
        [HttpPost("add")]
        public bool AddStudent(StudentCSV student)
        {
            return this.studentService.AddStudent(student);
        }

        // Updates the record if the record is present in the database
        [HttpPut("update")]
        public bool UpdateStudent(string studentId, StudentCSV student)
        {
            return this.studentService.UpdateStudent(studentId, student);
        }

        // Deletes the record from the database if the record is present in database
        [HttpDelete("delete")]
        public bool DeleteStudent(string studentId)
        {
            return this.studentService.DeleteStudent(studentId);
        }

        // This method will read the CSV file and returns the records
        // And Add the record if the record is not present in the database
        [HttpGet("save-via-csv")]
        public List<StudentCSV> GetStudents()
        {
            string csvFilePath = "C:\\Users\\Vardaan\\OneDrive\\Desktop\\AniccData\\AniccData\\CSV_Data\\Student-original.csv";

            List<StudentCSV> students = new();

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvHelper.Configuration.CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var records = csv.GetRecords<StudentCSV>();

                foreach (var record in records)
                {
                    if (!this.studentService.IsStudentExists(record.Student_ID))
                        this.AddStudent(record);

                    students.Add(record);
                }
            }

            return students;
        }
    }
}
