using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAPIDemo.Model;
using StudentAPIDemo.Models;

namespace StudentAPIDemo.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController : ControllerBase
    {
        private readonly IMapper mapper;

        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("GetAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                var students = this
                .studentRepository.GetAllStudents();
                var miniStudents = mapper.Map<StudentMini[]>(students);
                return Ok(miniStudents);
            }
            catch(Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet("{id}", Name = "GetStudent")]
        public IActionResult GetStudent(int id)
        {
            try
            {
                var student = this.studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == id);
                if (student == null)
                    return NotFound("Student Not found For this ID");
                return Ok(student);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }
        [HttpGet]
        [Route("GetTeamAStudents")]
        public IActionResult GetTeamAStudents()
        {
            try
            {
                var studentsA = this
                .studentRepository
                .GetTeamAStudents();
                return Ok(studentsA);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("GetTeamBStudents")]
        public IActionResult GetTeamBStudents()
        {
            try
            {
                var studentsB = this
                .studentRepository
                .GetTeamBStudents();
                return Ok(studentsB);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }

        }
        [HttpGet]
        [Route("GetTeamCStudents")]
        public IActionResult GetTeamCStudents()
        {
            try
            {
                var studentsC = this
                .studentRepository
                .GetTeamCStudents();
                return Ok(studentsC);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("GetTeamDStudents")]
        public IActionResult GetTeamDStudents()
        {
            try
            {
                var studentsD = this
                .studentRepository
                .GetTeamDStudents();
                return Ok(studentsD);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("GetMaleStudents")]
        public IActionResult GetMaleStudents()
        {
            try
            {
                var MaleStudents = this
                .studentRepository
                .GetMaleStudents();
                return Ok(MaleStudents);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("GetFemaleStudents")]
        public IActionResult GetFemaleStudents()
        {
            try
            {
                var FemaleStudents = this
                .studentRepository
                .GetFemaleStudents();
                return Ok(FemaleStudents);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpGet]
        [Route("GetSNameStudents")]
        public IActionResult GetSNameStudents()
        {
            try
            {
                var GetSNameStudents = this
                                .studentRepository
                                .GetStudentsWithS();
                return Ok(GetSNameStudents);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpPost]
        [Route("InsertStudent")]
        public IActionResult InsertStudent(Student student)
        {
            try
            {
                var insertedStudent = this
                                .studentRepository
                                .InsertStudent(student);
                return CreatedAtRoute("GetStudent", new { id = insertedStudent.StudentID }, insertedStudent);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpPut]
        [Route("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            try
            {
                var updatedStudent = this
                                .studentRepository
                                .UpdateStudent(student);
                return Ok(updatedStudent);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
        [HttpDelete]
        [Route("DeleteStudent")]
        public IActionResult DeleteStudent(int studentID)
        {
            try
            {
                var student = this.studentRepository.GetAllStudents().FirstOrDefault(student => student.StudentID == studentID);
                if (student == null)
                {
                    return BadRequest("Student not found, try some other valid id");
                }
                var deletedStudent = this
                    .studentRepository
                    .DeleteStudent(studentID);
                return Ok(deletedStudent);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
    }
}
