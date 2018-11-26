using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class CorporateAngularCourse : AbstractCourse
    {
        internal CorporateAngularCourse()
        {
            CourseDuration = 3;
            CourseName = "A fast track advance Angular course for working professionals";
            CourseType = CourseType.Corporate;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[Angular Corporate Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[Angular Corporate Course - course materials created]");
        }
    }
}
