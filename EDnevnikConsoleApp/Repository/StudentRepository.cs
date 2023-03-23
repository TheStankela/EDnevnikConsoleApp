﻿using EDnevnikConsoleApp.Data;
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
        public void AddStudents(List<Student> students)
		{
			foreach(var student in students)
			{
				if (!Database.Students.Any(s => s.FirstName == student.FirstName && s.LastName == student.LastName))
				{
					Database.Students.Add(student);
                    Console.WriteLine($"{student.FirstName} {student.LastName} succesfully added.");
                }
				else
				{
                    Console.WriteLine($"{student.FirstName} {student.LastName} already exists.");
                }
			}
		}

		public void GetAllStudents()
		{
			foreach (Student s in Database.Students)
			{
				Console.WriteLine($"{s.Id} {s.FirstName} {s.LastName}");
			}
		}

		public Student? GetStudent(int id)
		{
			var student = Database.Students.FirstOrDefault(s => s.Id == id);
			
			return student;
		}
	}
}
