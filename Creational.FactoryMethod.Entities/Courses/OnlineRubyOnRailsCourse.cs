using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class OnlineRubyOnRailsCourse : AbstractCourse
    {
        internal OnlineRubyOnRailsCourse()
        {
            CourseType = CourseType.Online;
            CourseName = "Learn Ruby On Rails in 1 Month";
            CourseDuration = 1;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[Ruby On Rails Online Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[Ruby On Rails Online Course - course materials created]");
        }
    }
}
