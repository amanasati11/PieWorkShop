using Microsoft.AspNetCore.Mvc;
using StudentAPIDemo.Model;
using StudentAPIDemo.Models;

namespace StudentAPIDemo.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            var students = this
                .studentRepository.GetAllStudents();
            return Ok(students);
        }
        [HttpGet]
        [Route("GetTeamAStudents")]
        public IActionResult GetTeamAStudents()
        {
            var studentsA = this
                .studentRepository
                .GetTeamAStudents();
            return Ok(studentsA);
        }
        [HttpGet]
        [Route("GetTeamBStudents")]
        public IActionResult GetTeamBStudents()
        {
            var studentsB = this
                .studentRepository
                .GetTeamBStudents();
            return Ok(studentsB);
        }
        [HttpGet]
        [Route("GetTeamCStudents")]
        public IActionResult GetTeamCStudents()
        {
            var studentsC = this
                .studentRepository
                .GetTeamCStudents();
            return Ok(studentsC);
        }
        [HttpGet]
        [Route("GetTeamDStudents")]
        public IActionResult GetTeamDStudents()
        {
            var studentsD = this
                .studentRepository
                .GetTeamDStudents();
            return Ok(studentsD);
        }
        [HttpGet]
        [Route("GetMaleStudents")]
        public IActionResult GetMaleStudents()
        {
            var MaleStudents = this
                .studentRepository
                .GetMaleStudents();
            return Ok(MaleStudents);
        }
        [HttpGet]
        [Route("GetFemaleStudents")]
        public IActionResult GetFemaleStudents()
        {
            var FemaleStudents = this
                .studentRepository
                .GetFemaleStudents();
            return Ok(FemaleStudents);
        }
        [HttpGet]
        [Route("GetSNameStudents")]
        public IActionResult GetSNameStudents()
        {
            var GetSNameStudents = this
                .studentRepository
                .GetStudentsWithS();
            return Ok(GetSNameStudents);
        }
    }
}
