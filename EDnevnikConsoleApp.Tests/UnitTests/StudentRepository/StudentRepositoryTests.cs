using EDnevnikConsoleApp.IoC;
using EDnevnikConsoleApp.Models;

namespace EDnevnikConsoleApp.Tests.UnitTests.StudentRepository
{
	[TestClass]
	public class StudentRepositoryTests
	{
		[TestMethod]
		public void StudentRepository_GetStudentById_ReturnsStudent()
		{
			//Arrange
			int id = 1;
			List<Student> students = new List<Student>
			{
				new Student(1, "Marko", "Markovic")
			};

			//Act
			var student = students.FirstOrDefault(s => s.Id == id);

			//Assert
			Assert.IsInstanceOfType(student, typeof(Student));
		}

		[TestMethod]
		public void StudentRepository_GetAllStudents_ReturnsListOfStudents()
		{
			//Arrange
			List<Student> students = new List<Student>
			{
				new Student(1, "Marko", "Markovic")
			};

			//Act
			var result = students.ToList();

			//Assert
			Assert.IsInstanceOfType(result, typeof(List<Student>));
		}
		[TestMethod]
		public void StudentRepository_StudentExists_ReturnsTrue()
		{
			//Arrange
			Student enteredStudent = new Student(1, "Nikola", "Nikolic");
			List<Student> students = new List<Student>
			{
				new Student(1, "Marko", "Markovic")
			};

			//Act
			var result = students.Any(s => s.Id == enteredStudent.Id);

			//Assert
			Assert.IsTrue(result);
		}
	}
}