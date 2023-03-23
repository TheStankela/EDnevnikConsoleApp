using EDnevnikConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikConsoleApp.Data
{
	public static class Database
	{
		public static List<Subject> Subjects = new List<Subject>
		{
			new Subject(1, "Algebra"),
			new Subject(2, "Matematika"),
			new Subject(3, "Biologija"),
			new Subject(4, "Srpski Jezik"),
			new Subject(5, "Engleski Jezik"),
		};
		public static List<Student> Students = new List<Student>
		{
			new Student("Marko", "Markovic")
		};
		public static List<Grade> Grades = new List<Grade>();
	}
}
