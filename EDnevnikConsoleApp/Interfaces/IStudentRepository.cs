using EDnevnikConsoleApp.Data;
using EDnevnikConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikConsoleApp.Interfaces
{
    public interface IStudentRepository
    {
		void GetAllStudents();
		Student GetStudent(int id);
		void AddStudents(List<Student> students);
	}
}
