using EDnevnikConsoleApp.Data;
using EDnevnikConsoleApp.Interfaces;
using EDnevnikConsoleApp.Repository;
using EDnevnikConsoleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnikConsoleApp.IoC
{
	public static class Factory
	{
		public static IStudentRepository CreateStudentRepository()
		{
			return new StudentRepository();
		}
		public static IInputService CreateInputService()
		{
			return new InputService(CreateStudentRepository());
		}
		public static IGradeRepository CreateGradeRepository()
		{
			return new GradeRepository(CreateStudentRepository());
		}
		public static ISubjectRepository CreateSubjectRepository()
		{
			return new SubjectRepository();
		}
		public static IGradeService CreateGradeService()
		{
			return new GradeService(CreateStudentRepository(), CreateSubjectRepository(), CreateGradeRepository());
		}
	}
}
