namespace SmallProject.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();

        IEnumerable<Student> GetTeamAStudents();

        IEnumerable<Student> GetTeamBStudents();

        IEnumerable<Student> GetTeamCStudents();

        IEnumerable<Student> GetTeamDStudents();

        IEnumerable<Student> GetMaleStudents();

        IEnumerable<Student> GetFemaleStudents();

        IEnumerable<Student> GetSNameStudents();
    }
}
