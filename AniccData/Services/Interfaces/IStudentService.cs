using AniccData.Models;

namespace AniccData.Services.Interfaces
{
    public interface IStudentService
    {
        bool AddStudent(StudentCSV student);
        bool UpdateStudent(string studentId, StudentCSV student);
        bool DeleteStudent(string studentId);
        bool IsStudentExists(string studentId);
    }
}
