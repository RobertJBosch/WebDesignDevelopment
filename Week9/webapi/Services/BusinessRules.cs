using System;

namespace webapi {
public static class BusinessRules {
    
    public static bool isSpecial(Students student) {
        return student.StudentId % 2 == 0;
    }
}
}