using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class OnlineJavaCourse : AbstractCourse
    {
        internal OnlineJavaCourse()
        {
            CourseType = CourseType.Online;
            CourseName = "Learn Java in 1 Months";
            CourseDuration = 1;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[Java Online Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[Java Online Course - course materials created]");
        }
    }
}
