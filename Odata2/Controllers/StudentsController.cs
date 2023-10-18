using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Odata2.Models;
using Odata2.Services;

namespace Odata2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableQuery]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpGet]
        public ActionResult<IQueryable<Student>> GetAllStudents()
        {
            IQueryable<Student> retrivedStudents =
                this.studentService.RetrieveAllStudents();

            return Ok(retrivedStudents);
        }
    }
}
