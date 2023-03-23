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
	public class SubjectRepository : ISubjectRepository
	{
		public void GetAllSubjects()
		{
			foreach(var subject in Database.Subjects)
			{
				Console.WriteLine($"{subject.Id} - {subject.Name}");
			}
		}

		public Subject? GetSubjectById(int id)
		{
			return Database.Subjects.FirstOrDefault(x => x.Id == id);
		}
	}
}
