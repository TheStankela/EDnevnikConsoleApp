
using EDnevnikConsoleApp.Data;
using EDnevnikConsoleApp.IoC;

var _studentRepository = Factory.CreateStudentRepository();
var _studentService = Factory.CreateNewInputService();


_studentService.StudentInput();

_studentRepository.GetAllStudents();

