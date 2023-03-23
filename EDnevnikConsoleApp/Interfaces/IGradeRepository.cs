using EDnevnikConsoleApp.Models;

namespace EDnevnikConsoleApp.Interfaces
{
    public interface IGradeRepository
    {
        bool AddGrade(Student student, Subject subject, int grade);
        void GetAllGrades();
        public void GetGradesByStudentId(int studentId);

	}
}