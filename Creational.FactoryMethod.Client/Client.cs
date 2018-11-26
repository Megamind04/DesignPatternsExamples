using Creational.FactoryMethod.Entities;
using System;

namespace Creational.FactoryMethod.Client
{
    internal class Client
    {
        private ICourse course;
        private CourseType courseType;
        private DeveloperPlatform developerPlatform;

        internal void RunClient() => ChooseCourseType();

        private void ChooseCourseType()
        {
            Console.WriteLine("Please choose course type: ");
            Console.WriteLine("For Online course write - 1.");
            Console.WriteLine("For Offline course write - 2.");
            Console.WriteLine("For Corporate course write - 3.");
            CheckCourseType();
        }

        private void ChooseDeveloperPlatform()
        {
            Console.WriteLine("Please choose Developer Platform: ");
            Console.WriteLine("For .Net course write - 1.");
            Console.WriteLine("For Java course write - 2.");
            Console.WriteLine("For Angular course write - 3.");
            Console.WriteLine("For jQuery course write - 4.");
            Console.WriteLine("For RubyOnRails course write - 5.");
            CheckDeveloperPlatform();
        }

        private void CheckCourseType()
        {
            int[] aveableTypes = new int[] { 1, 2, 3 };

            int.TryParse(Console.ReadLine(), out int courseNum);

            if (Array.IndexOf(aveableTypes, courseNum) > -1)
            {
                courseType = (CourseType)courseNum;
                Console.Clear();
                ChooseDeveloperPlatform();
            }
            else
            {
                Console.Clear();
                ChooseCourseType();
            }
        }

        private void CheckDeveloperPlatform()
        {
            int[] aveableTypes = new int[] { 1, 2, 3, 4, 5 };

            int.TryParse(Console.ReadLine(), out int platformNum);

            if (Array.IndexOf(aveableTypes, platformNum) > -1)
            {
                developerPlatform = (DeveloperPlatform)platformNum;
                Console.Clear();
                course = CourseCreator.CreateCourse(courseType, developerPlatform);
                CheckCourseForNull(course);
            }
            else
            {
                Console.Clear();
                ChooseDeveloperPlatform();
            }
        }

        private void CheckCourseForNull(ICourse course)
        {
            if (course != null)
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine($"Course Type: {course.CourseType}.");
                Console.WriteLine($"Course Name: {course.CourseName}.");
                Console.WriteLine($"Course Duration: {course.CourseDuration} Months.");
                Console.WriteLine("-----------------------------------------------------");
            }
            else
            {
                Console.WriteLine($"There is no available {courseType} course for {developerPlatform}.");
            }
        }
    }
}
