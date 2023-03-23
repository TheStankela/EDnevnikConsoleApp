using EDnevnikConsoleApp.Data;
using EDnevnikConsoleApp.Interfaces;
using EDnevnikConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikConsoleApp.Repository
{
	public class StudentRepository : IStudentRepository
	{
        public bool AddStudents(List<Student> students)
		{
			foreach(var student in students)
			{
				Database.Students.Add(student);
			}
			return true;
		}

		public void GetAllStudents()
		{
			foreach (Student s in Database.Students)
			{
				Console.WriteLine(s.FirstName);
			}
		}

		public Student GetStudent(string indexNumber)
		{
			throw new NotImplementedException();
		}
	}
}
