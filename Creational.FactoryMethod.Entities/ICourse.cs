
namespace Creational.FactoryMethod.Entities
{
    /// <summary>
    /// Type of Course.
    /// </summary>
    public enum CourseType
    {
        /// <value>Online Course.</value>
        Online = 1,
        /// <value>Offline Course.</value>
        Offline = 2,
        /// <value>Corporate Course.</value>
        Corporate = 3
    }
    /// <summary>
    /// Developer Platform.
    /// </summary>
    public enum DeveloperPlatform
    {
        /// <value>Net Courses.</value>
        Net = 1,
        /// <value>Java Courses.</value>
        Java = 2,
        /// <value>Angular Courses.</value>
        Angular = 3,
        /// <value>jQuery Courses.</value>
        jQuery = 4,
        /// <value>Ruby On Rails Courses.</value>
        RubyOnRails = 5
    }
    /// <summary>
    /// Abstract Produc
    /// </summary>
    public interface ICourse
    {
        /// <summary>
        /// Gets Course Type.
        /// </summary>
        CourseType CourseType { get; }
        /// <summary>
        /// Gets Course Name.
        /// </summary>
        string CourseName { get; }
        /// <summary>
        /// Gets Course Duration.
        /// </summary>
        int CourseDuration { get; }
    }
}
