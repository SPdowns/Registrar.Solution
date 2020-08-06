using System.Collections.Generic;
using System;

namespace Registrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Courses = new HashSet<Course>();
      this.Students = new HashSet<Student>();
      this.Professors = new HashSet<Professor>();
    }
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public string DepartmentDescription { get; set; }
    public int? StudentId { get; set; }
    public int? CourseId { get; set; }
    public int? ProfessorId { get; set; } 
    public virtual ICollection<Course> Courses { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<Professor> Professors { get; set; }
  }
}
