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
		public static Dictionary<double, string> gradeName = new Dictionary<double, string>()
		{
			{1, "Nedovoljan" },
			{2, "Dovoljan" },
			{3, "Dobar" },
			{4, "Vrlo Dobar" },
			{5, "Odlican" }

		};
		public static List<Subject> Subjects = new List<Subject>
		{
			new Subject(1, "Algebra"),
			new Subject(2, "Matematika"),
			new Subject(3, "Biologija"),
			new Subject(4, "Srpski Jezik"),
			new Subject(5, "Engleski Jezik"),
		};
		public static List<Student> Students = new List<Student>();
		public static List<Grade> Grades = new List<Grade>();
	}
}
