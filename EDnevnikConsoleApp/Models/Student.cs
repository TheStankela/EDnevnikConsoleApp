using EDnevnikConsoleApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikConsoleApp.Models
{
	public class Student
	{
        public Student(string firstName, string lastName)
        {
			Id = GenerateStudentId();
			FirstName = firstName;
			LastName = lastName;
        }
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public List<Grade>? Grades { get; set; }

		public int GenerateStudentId()
		{
			Random rnd = new Random();
			int id;
			do
			{
				id = rnd.Next(1, 1000);
			}
			while (Database.Students.Any(s => Id == s.Id));

			return id;
		}

	}
}
