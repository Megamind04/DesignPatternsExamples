using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class OnlinejQueryCourse : AbstractCourse
    {
        internal OnlinejQueryCourse()
        {
            CourseType = CourseType.Online;
            CourseName = "Learn jQuery in 1 Month";
            CourseDuration = 1;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[jQuery Online Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[jQuery Online Course - course materials created]");
        }
    }
}
