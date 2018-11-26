using Creational.FactoryMethod.Entities.Factories;

namespace Creational.FactoryMethod.Entities
{
    /// <summary>
    /// Client class for creating courses.
    /// </summary>
    public static class CourseCreator
    {
        /// <summary>
        /// Method for creating course.
        /// </summary>
        /// <param name="courseType">Type of course(Corporate,Online,Offline).</param>
        /// <param name="platform">Type of platform(.Net,Java,Angular).</param>
        /// <returns>ICourse.</returns>
        public static ICourse CreateCourse(CourseType courseType, DeveloperPlatform platform)
        {
            AbstractCourseFactory courseFactory = null;
            switch (courseType)
            {
                case CourseType.Online:
                    courseFactory = new OnlineCourseFactoryVersion2();
                    break;
                case CourseType.Offline:
                    courseFactory = new OfflineCourseFactory();
                    break;
                case CourseType.Corporate:
                    courseFactory = new CorporateCourseFactory();
                    break;
                default:
                    courseFactory = null;
                    break;
            }
            if (courseFactory != null)
            {
                return courseFactory.CreateCourse(platform);
            }
            else
            {
                return null;
            }
        }
    }
}
