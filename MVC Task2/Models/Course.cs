namespace MVC_Task2.Models
{
	public class Course
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public float Degree { get; set; }
		public float MinDegree { get; set; }
		public virtual ICollection <CourseResult> CourseResults  { get; set; }
		public virtual ICollection<Instructor> Instructors { get; set; }
	}
}
