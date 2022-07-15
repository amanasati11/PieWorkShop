using Microsoft.AspNetCore.Mvc;
using SmallProject.Models;
using SmallProject.ViewModels;

namespace SmallProject.Controllers
{
    public class TeamCController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public TeamCController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult ListC()
        {
            var students = studentRepository.GetTeamCStudents();
            //ViewBag.Count = students.Count();

            StudentsWithCount TeamCCount = new StudentsWithCount();
            TeamCCount.students = students;
            TeamCCount.count = students.Count();
            return View(TeamCCount);
        }
    }
}
