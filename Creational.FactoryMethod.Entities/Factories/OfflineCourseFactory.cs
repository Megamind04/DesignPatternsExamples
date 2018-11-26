﻿using Creational.FactoryMethod.Entities.Courses;

namespace Creational.FactoryMethod.Entities.Factories
{
    internal class OfflineCourseFactory : AbstractCourseFactory
    {
        internal OfflineCourseFactory()
        {
            courses.Add(DeveloperPlatform.Angular, new OfflineAngularCourse());
            courses.Add(DeveloperPlatform.Java, new OfflineJavaCourse());
            courses.Add(DeveloperPlatform.Net, new OfflineNetCourse());
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
