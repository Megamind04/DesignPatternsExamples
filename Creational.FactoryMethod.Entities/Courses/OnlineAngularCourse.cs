using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class OnlineAngularCourse : AbstractCourse
    {
        internal OnlineAngularCourse()
        {
            CourseType = CourseType.Online;
            CourseName = "Learn Angular in 1 Month";
            CourseDuration = 1;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[Angular Online Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[Angular Online Course - course materials created]");
        }
    }
}
