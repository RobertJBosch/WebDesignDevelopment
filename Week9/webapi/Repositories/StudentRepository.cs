using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using Database;
using System;

namespace webapi {
public class StudentRepository : IStudentRepository
{
    private readonly SchoolContext _dbContext;
    private readonly ILogger _logger;

    public StudentRepository(SchoolContext dbContext, ILoggerFactory loggerFactory)
    {
        _dbContext = dbContext;
        _logger = loggerFactory.CreateLogger("Controllers.StudentsRepository");
    }

    public List<Students> GetAllStudents()
    {
        try
        {
            return _dbContext.Students.ToList();
        } 
        catch(Exception ex)
        {
            _logger.LogError("Failed to get Students.", ex);
            
            return new List<Students>();
        }
    }

}
}