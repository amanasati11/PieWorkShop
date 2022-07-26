using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmallProject.Models;
using SmallProject.ViewModels;

namespace SmallProject.Controllers
{
    public class TeamDController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public TeamDController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [Authorize]
        public ViewResult ListD()
        {
            var students = studentRepository.GetTeamDStudents();
            //ViewBag.Count = students.Count();

            StudentsWithCount TeamDCount = new StudentsWithCount();
            TeamDCount.students = students;
            TeamDCount.count = students.Count();
            return View(TeamDCount);
        }
    }
}
