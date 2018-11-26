using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class OfflineJavaCourse : AbstractCourse
    {
        internal OfflineJavaCourse()
        {
            CourseType = CourseType.Offline;
            CourseName = "Learn Java in 2 Months";
            CourseDuration = 2;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[Java Offline Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[Java Offline Course - course materials created]");
        }
    }
}
