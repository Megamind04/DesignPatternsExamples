using Creational.FactoryMethod.Entities.Courses;
using System.Collections.Generic;

namespace Creational.FactoryMethod.Entities.Factories
{
    internal abstract class AbstractCourseFactory
    {
        protected readonly IDictionary<DeveloperPlatform, AbstractCourse> courses;

        internal AbstractCourseFactory()
        {
            courses = new Dictionary<DeveloperPlatform, AbstractCourse>();
        }

        public ICourse CreateCourse(DeveloperPlatform developerPlatform)
        {
            AbstractCourse course = this.GetCourse(developerPlatform);
            if (course != null)
            {
                course.CreateCourseMaterial();
                course.CreateSchedule();
            }
            return course;
        }

        protected abstract AbstractCourse GetCourse(DeveloperPlatform developerPlatform);
    }
}
