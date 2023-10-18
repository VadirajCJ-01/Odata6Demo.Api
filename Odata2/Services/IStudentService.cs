using Odata2.Models;

namespace Odata2.Services
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}
