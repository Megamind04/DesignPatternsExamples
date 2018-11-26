using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class OfflineNetCourse : AbstractCourse
    {
        internal OfflineNetCourse()
        {
            CourseType = CourseType.Offline;
            CourseName = "Learn .Net in 2 Months";
            CourseDuration = 2;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[.Net Offline Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[.Net Offline Course - course materials created]");
        }
    }
}
