using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace webapi {
public class StudentServices : IStudentServices
{
    private readonly IStudentRepository _StudentRespository;
    private readonly ILogger _logger;

    public StudentServices(IStudentRepository StudentRepository, ILoggerFactory loggerFactory)
    {
        _StudentRespository = StudentRepository;
        _logger = loggerFactory.CreateLogger("Controllers.StudentService");
    }

    public List<StudentViewModel> GetAllStudents()
    {
        var StudentViewModels = new List<StudentViewModel>();

        foreach(var Student in _StudentRespository.GetAllStudents())
        {
            StudentViewModels.Add(new StudentViewModel {
                StudentId = Student.StudentId,
                Email = Student.Email,
                Special = BusinessRules.isSpecial(Student)
               
            });
            if (BusinessRules.isSpecial(Student))
            {
                _logger.LogInformation("Found special Student: " + Student.StudentId);
                
            }
        }

        return StudentViewModels;
    }

}
}