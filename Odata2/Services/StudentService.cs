using Odata2.Models;

namespace Odata2.Services
{
    public class StudentService : IStudentService
    {
        public IQueryable<Student> RetrieveAllStudents()
        {
            return new List<Student>
            {
               new Student
               {
                   ID = Guid.NewGuid(),
                   Name = "Vadiraj Joshi",
                   Score = 120
               },
               new Student
               {
                   ID = Guid.NewGuid(),
                   Name = "John Doe",
                   Score = 180
               },
               new Student
               {
                   ID = Guid.NewGuid(),
                   Name = "Jane Dahmer",
                   Score = 202
               }
            }.AsQueryable();
        }
    }
}
