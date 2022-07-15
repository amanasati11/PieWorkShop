using SmallProject.Models;

namespace SmallProject.ViewModels
{
    // ViewModel - will provide custom data
    public class StudentsWithCount
    {
        public IEnumerable<Student> students { get; set; }
        public int count { get; set; }
    }
}
