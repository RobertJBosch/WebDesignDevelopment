using System.Collections.Generic;

namespace webapi {
public interface IStudentServices
{
    List<StudentViewModel> GetAllStudents();

}
}