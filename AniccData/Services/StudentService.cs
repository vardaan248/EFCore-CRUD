using AniccData.DB;
using AniccData.Models;
using AniccData.Services.Interfaces;

namespace AniccData.Services
{
    public class StudentService : IStudentService
    {
        private AppDbContext DbContext { get; set; }
        private IConfiguration configuration { get; set; }

        public StudentService(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.DbContext = new AppDbContext(this.configuration);
        }

        public bool AddStudent(StudentCSV student)
        {
            this.DbContext.StudentsCSV.Add(student);
            return this.DbContext.SaveChanges() == 1;
        }

        public bool UpdateStudent(string studentId, StudentCSV student)
        {
            var studentRecord = this.DbContext.StudentsCSV.SingleOrDefault(student => student.Student_ID == studentId);

            if (studentRecord != null)
            {
                student.Student_ID = studentId;

                this.DbContext.StudentsCSV.Update(student);
                return this.DbContext.SaveChanges() == 1;
            }

            return false;
        }

        public bool DeleteStudent(string studentId)
        {
            var student = this.DbContext.StudentsCSV.SingleOrDefault(student => student.Student_ID == studentId);
            if (student != null)
            {
                this.DbContext.StudentsCSV.Remove(student);
                return this.DbContext.SaveChanges() == 1;
            }

            return false;
        }

        public bool IsStudentExists(string studentId)
        {
            return this.DbContext.StudentsCSV.SingleOrDefault(student => student.Student_ID == studentId) is not null;
        }
    }
}
