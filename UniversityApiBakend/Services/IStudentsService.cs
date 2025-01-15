using UniversityApiBakend.Models.DataModels;

namespace UniversityApiBakend.Services
{
    public interface IStudentsService
    {
        IEnumerable<Student> GetStudentsWithCourses();
        IEnumerable<Student> GetStudentsWithoutCoursees();
    }
}
