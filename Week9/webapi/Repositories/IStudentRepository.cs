using System.Collections.Generic;

namespace webapi {
public interface IStudentRepository
{
    List<Students> GetAllStudents();
}
}