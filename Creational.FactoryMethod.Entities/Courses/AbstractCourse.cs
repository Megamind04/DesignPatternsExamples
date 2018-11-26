
namespace Creational.FactoryMethod.Entities.Courses
{
    internal abstract class AbstractCourse : ICourse
    {
        public CourseType CourseType { get; protected set; }
        public string CourseName { get; protected set; }
        public int CourseDuration { get; protected set; }

        internal abstract void CreateCourseMaterial();
        internal abstract void CreateSchedule();
    }
}
