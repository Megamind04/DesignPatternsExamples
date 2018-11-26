using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class OnlineNetCourse : AbstractCourse
    {
        internal OnlineNetCourse()
        {
            CourseType = CourseType.Online;
            CourseName = "Learn .Net in 1 Month";
            CourseDuration = 1;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[.Net Online Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[.Net Online Course - course materials created]");
        }
    }
}
