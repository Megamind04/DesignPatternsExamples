using System;

namespace Creational.FactoryMethod.Entities.Courses
{
    internal class OfflineAngularCourse : AbstractCourse
    {
        internal OfflineAngularCourse()
        {
            CourseDuration = 2;
            CourseName = "Learn Angular in 2 Months";
            CourseType = CourseType.Offline;
        }

        internal override void CreateCourseMaterial()
        {
            Console.WriteLine("[Angular Offline Course - course schedule created]");
        }

        internal override void CreateSchedule()
        {
            Console.WriteLine("[Angular Offline Course - course materials created]");
        }
    }
}
