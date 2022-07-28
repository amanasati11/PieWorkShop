using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StudentAPIDemo.Model
{
    public class Student
    {
        public int StudentID { get; set; }

        [Required(ErrorMessage ="Please provide a first Name")]
        [StringLength(10, ErrorMessage ="Please Enter less than 10 Characters")]
        [DataType(DataType.Text)]
        [MinLength(1)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide a Last Name")]
        [StringLength(10, ErrorMessage = "Please Enter less than 10 Characters")]
        [DataType(DataType.Text)]
        [MinLength(1)]
        public string LastName { get; set; }

        [RegularExpression(@"^(?:1[8-9]|[2-3][0-6])$", ErrorMessage = "Please Enter Age Between 18-36.")]
        //[MaxLength(2)]
        public int Age { get; set; }

        
        public string Gender { get; set; }
        public string TeamName { get; set; }
    }
}
