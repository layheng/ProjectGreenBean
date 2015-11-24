using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QFGreenBean.Models;

namespace QFGreenBean.Tests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestIsStudentEnrolled()
        {
            Student student = new Student();

            Assert.IsTrue(student.IsStudentEnrolled(12345));
        }
    }
}
