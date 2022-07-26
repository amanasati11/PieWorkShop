using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmallProject.Models;
using SmallProject.ViewModels;

namespace SmallProject.Controllers
{
    public class TeamBController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public TeamBController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [Authorize]
        public ViewResult ListB()
        {
            var students = studentRepository.GetTeamBStudents();
            //ViewBag.Count = students.Count();
            
            StudentsWithCount TeamBCount = new StudentsWithCount();
            TeamBCount.students = students;
            TeamBCount.count = students.Count();
            return View(TeamBCount);
        }
    }
}
