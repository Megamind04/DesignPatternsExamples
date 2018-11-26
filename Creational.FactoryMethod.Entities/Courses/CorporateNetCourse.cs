using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class CorporateNetCourse : AbstractCourse
    {
        internal CorporateNetCourse()
        {
            CourseDuration = 3;
            CourseName = "A fast track advance .Net course for working professionals";
            CourseType = CourseType.Corporate;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[.Net Corporate Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[.Net Corporate Course - course materials created]");
        }
    }
}
