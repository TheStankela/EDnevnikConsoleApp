
using EDnevnikConsoleApp.Data;
using EDnevnikConsoleApp.IoC;

var _studentRepository = Factory.CreateStudentRepository();
var _subjectRepository = Factory.CreateSubjectRepository();
var _gradeRepository = Factory.CreateGradeRepository();
var _studentService = Factory.CreateInputService();
var _gradeService = Factory.CreateGradeService();

bool value = true;
do
{
	Console.Clear();
	Console.WriteLine("Available services: \n[1]All Subjects\n[2]Add Student \n[3]New Grade \n[4]Get all grades for specific student \n[5]Exit");
	if (!int.TryParse(Console.ReadLine(), out int userChoice))
	{
		Console.WriteLine("Invalid input");
	}
	switch (userChoice)
	{
		case 1:
			{
				Console.Clear();
				_subjectRepository.GetAllSubjects();
				break;
			}
		case 2:
			{
				Console.Clear();
				_studentService.StudentInput();
				break;
			}
		case 3:
			{
				Console.Clear();
				_studentRepository.GetAllStudents();
				_gradeService.GradeStudent();
				break;
			}
		case 4:
			{
				Console.Clear();
				_studentRepository.GetAllStudents();
				Console.WriteLine("Enter students ID:");
				int.TryParse(Console.ReadLine(), out int studentId);
				_gradeRepository.GetGradesByStudentId(studentId);
				break;
			}
		case 5:
			{
				Console.Clear();
				value = false;
				break;
			}
	}

	Console.WriteLine("Press any key to continue..");
	Console.ReadKey();

} while (value);


