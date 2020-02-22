using System.Collections.Generic;
using webapi;

namespace Database
{
    public static class InMemory
    {
        public static List<Student> Students = new List<Student> {
            new Student {
                StudentId = 123456,
                EmailAddress = "owen.wilson@whow.net"
            },
            new Student {
                StudentId = 789123,
                EmailAddress = "imadethisup.forthisassignment.org"
            },

            new Student {
                StudentId = 456789,
                EmailAddress = "mary.janes@kites.com"
            }
        };

        public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                FirstName = "Steven",
                MiddleInitial = "R",
                LastName = "Parker"
            },

            new Instructor {
                FirstName = "Ethan",
                MiddleInitial = "J",
                LastName = "Slovak"
            },

            new Instructor {
                FirstName = "Simeon",
                MiddleInitial = "C",
                LastName = "Florea"
            }
        };
    }
}