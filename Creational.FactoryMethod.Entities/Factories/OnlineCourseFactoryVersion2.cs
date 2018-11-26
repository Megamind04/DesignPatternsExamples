using Creational.FactoryMethod.Entities.Courses;

namespace Creational.FactoryMethod.Entities.Factories
{
    internal class OnlineCourseFactoryVersion2 : OnlineCourseFactory
    {
        internal OnlineCourseFactoryVersion2()
        {
            courses.Add(DeveloperPlatform.jQuery, new OnlinejQueryCourse());
            courses.Add(DeveloperPlatform.RubyOnRails, new OnlineRubyOnRailsCourse());
        }
    }
}
