using System.Collections.Generic;
using webapi;

namespace Database
{
    public static class InMemory
    {
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