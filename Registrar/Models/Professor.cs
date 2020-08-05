
using System;

namespace Registrar.Models
{
  public class Professor
  {
    public int ProfessorId { get; set; } 
    public string ProfessorName { get; set; }
    public bool Tenure { get; set; }
    public int DepartmentId { get; set; }
    public virtual Department Department { get; set; }
  
  }
}