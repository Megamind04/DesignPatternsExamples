using Creational.FactoryMethod.Entities.Courses;

namespace Creational.FactoryMethod.Entities.Factories
{
    internal class OnlineCourseFactory : AbstractCourseFactory
    {
        internal OnlineCourseFactory()
        {
            courses.Add(DeveloperPlatform.Angular, new OnlineAngularCourse());
            courses.Add(DeveloperPlatform.Java, new OnlineJavaCourse());
            courses.Add(DeveloperPlatform.Net, new OnlineNetCourse());
        }

        protected override AbstractCourse GetCourse(DeveloperPlatform developerPlatform)
        {
            bool isNotNull = courses.TryGetValue(developerPlatform, out AbstractCourse course);
            if (isNotNull)
            {
                return course;
            }
            else
            {
                return null;
            }
        }
    }
}
