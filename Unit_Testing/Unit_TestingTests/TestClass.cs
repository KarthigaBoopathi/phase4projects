using System;
using System.Collections.Generic;
using System.Linq;
using Unit_Testing;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace Unit_TestingTests
{
    [TestFixture]
    public class TestClass
    {
        [TestCase]
        public void Test_student()
        {
            Student stu = new Student();
            stu.StudentId = 90;
            stu.StudentName = "Karthiga";
            Assert.AreEqual(stu.StudentId, 90);      
        }

        [TestCase]
        public void Test_subject()
        {
            Subject sub = new Subject();
            sub.SubjectId = 101;
            sub.SubjectName = "Mathematics";
            sub.SubjectMarks = 100;
            Assert.AreEqual(sub.SubjectMarks, 100);
        }

        [TestCase]
        public void Test_teacher()
        {
            Teacher tea = new Teacher();
            tea.TeacherId = 11;
            tea.TeacherName = "Silambarasan";
            Assert.AreEqual(tea.TeacherName, "Silambarasan");
        }

    }
}
