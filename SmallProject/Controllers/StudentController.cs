﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SmallProject.Models;
using SmallProject.ViewModels;

namespace SmallProject.Controllers
{
    public class StudentController : Controller
    {
        // Declaring object for interface IStudentRepository
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public ViewResult List()                        // default syntax for action method
        {
            var students = studentRepository.GetAllStudents();
            //ViewBag.Count = students.Count();
            
            StudentsWithCount StudentCount = new StudentsWithCount();
            StudentCount.students = students;
            StudentCount.count = students.Count();
            
            return View(StudentCount);
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            int result = studentRepository.CreateStudent(student);
            return RedirectToAction("List");
        }

        public ViewResult Remove(int id)
        {
            var student = studentRepository
                .GetAllStudents()
                .FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }
        [HttpPost]
        public IActionResult RemoveStudent(Student student)
        {
            int result = studentRepository.RemoveStudent(student);
            return RedirectToAction("List");
        }

        public ViewResult Details(int id)                        // action method
        {
            var student = studentRepository
                .GetAllStudents()
                .FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }

        public ViewResult Edit(int id)                        // action method
        {
            var student = studentRepository
                .GetAllStudents()
                .FirstOrDefault(student => student.StudentID == id);
            return View(student);
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            studentRepository.UpdateStudent(student);
            return RedirectToAction("List");
        }

        [Authorize]
        public ViewResult GetMaleStudents()                        
        {
            var students = studentRepository.GetMaleStudents();
            //ViewBag.Count = students.Count();

            StudentsWithCount MaleCount = new StudentsWithCount();
            MaleCount.students = students;
            MaleCount.count = students.Count();

            return View(MaleCount);
        }
        [Authorize]
        public ViewResult GetFemaleStudents()
        {
            var students = studentRepository.GetFemaleStudents();
            //ViewBag.Count = students.Count();

            StudentsWithCount FemaleCount = new StudentsWithCount();
            FemaleCount.students = students;
            FemaleCount.count = students.Count();

            return View(FemaleCount);
        }

        [Authorize]
        public ViewResult GetSNameStudents()
        {
            var students = studentRepository.GetSNameStudents();
            //ViewBag.Count = students.Count();

            StudentsWithCount SNameCount = new StudentsWithCount();
            SNameCount.students = students;
            SNameCount.count = students.Count();

            return View(SNameCount);
        }
    }
}
