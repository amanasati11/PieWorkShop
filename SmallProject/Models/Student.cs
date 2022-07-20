using System.ComponentModel.DataAnnotations;

namespace SmallProject.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        [StringLength(10)]
        [Required(ErrorMessage ="Please Enter First Name: ")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter Last Name: ")]
        [StringLength(10)]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Please Enter Age: ")]
        [Range(16, 35)]
        public int Age { get; set; }
        
        [Required(ErrorMessage = "Please Enter Gender: ")]
        public string Gender { get; set; }
        
        [Display(Name = "Team Name")]
        [StringLength(5)]
        [Required(ErrorMessage = "Please Enter Team Name: ")]
        public string TeamName { get; set; }
    }
}
