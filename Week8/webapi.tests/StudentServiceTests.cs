using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using webapi;

public class StudentServiceTests
{
    private StudentServices _studentService;
    private IStudentRepository _studentRepository;



    [SetUp]
    public void Setup()
    {
        var loggerFactory = A.Fake<LoggerFactory>();
        _studentRepository = A.Fake<IStudentRepository>();
        _studentService = new StudentServices(_studentRepository, loggerFactory);

    }

    [Test]
    public void ShouldReturnSpecialStudent()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Students> {
                new Students {
                    StudentId = 80,
                    Email = "test.email@test.com"
                },
                new Students {
                    StudentId = 52,
                    Email = "email.test@email.com"
                }
            }
        );

        // Assert (NUnit Assertions) (Then)
        Assert.That(_studentService.GetAllStudents().Any(student => student.Special), Is.EqualTo(true));

        // Assert (FluentAssertions) (Then)
        _studentService.GetAllStudents().Any(student => student.Special).Should().BeTrue();
    }

    [Test]
    public void ShouldNotReturnSpecialStudent()
    {
        // Arrange (Given)
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Students> {
                new Students {
                    StudentId = 55,
                    Email = "test.email@test.com"
                },
                new Students {
                    StudentId = 67,
                    Email = "email.test@email.com"
                }
            }
        );

        // Assert (NUnit Assertions) (Then)
        Assert.That(_studentService.GetAllStudents().Any(student => student.Special), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        _studentService.GetAllStudents().Any(student => student.Special).Should().BeFalse();
    }

}