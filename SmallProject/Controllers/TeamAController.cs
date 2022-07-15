using Microsoft.AspNetCore.Mvc;
using SmallProject.Models;
using SmallProject.ViewModels;

namespace SmallProject.Controllers
{
    public class TeamAController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public TeamAController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult ListA()
        {
            var students = studentRepository.GetTeamAStudents();
            //ViewBag.Count = students.Count();
            
            StudentsWithCount TeamACount = new StudentsWithCount();
            TeamACount.students = students;
            TeamACount.count = students.Count();
            return View(TeamACount);
        }
    }
}
