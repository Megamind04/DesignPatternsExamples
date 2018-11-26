using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class CorporateJavaCourse : AbstractCourse
    {
        internal CorporateJavaCourse()
        {
            CourseDuration = 3;
            CourseName = "A fast track advance Java course for working professionals";
            CourseType = CourseType.Corporate;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[Java Corporate Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[Java Corporate Course - course materials created]");
        }
    }
}
