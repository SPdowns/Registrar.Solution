using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public Course()
    {
      this.Students = new HashSet<CourseStudent>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public int Number { get; set; }
    public string Description { get; set; }
    public int ProfessorId { get; set; } 
    public Professor Professor { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department Department { get; set; }
    public ICollection<CourseStudent> Students { get; set;}
  }
}