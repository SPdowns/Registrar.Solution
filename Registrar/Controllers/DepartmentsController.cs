using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
  public class DepartmentsController : Controller
  {
    private readonly RegistrarContext _db;
    
    public DepartmentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Departments.ToList());
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Department department)
      {
        _db.Departments.Add(department);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    
    public ActionResult Details(int id)
    {
      var thisDepartment = _db.Departments
      .Include(department => department.Courses)
      .FirstOrDefault(department => department.DepartmentId == id);
      return View(thisDepartment);
    }

    public ActionResult Edit(int id)
    {
      var thisDepartment = _db.Departments.FirstOrDefault(Department => Department.DepartmentId == id);
      return View(thisDepartment);
    }

    // [HttpPost]
    // public ActionResult Edit(Student student, int CourseId)
    // {
    //   if (CourseId !=0)
    //   {
    //     _db.CourseStudent.Add(new CourseStudent() { CourseId = CourseId, StudentId = student.StudentId });
    //   }
    //   _db.Entry(student).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

  //   public ActionResult Delete(int id)
  //   {
  //     var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
  //     return View(thisStudent);
  //   }

  //   [HttpPost, ActionName("Delete")]
  //   public ActionResult DeleteConfirmed(int id)
  //   {
  //     var thisStudent = _db.Students.FirstOrDefault(student => student.StudentId == id);
  //     _db.Students.Remove(thisStudent);
  //     _db.SaveChanges();
  //     return RedirectToAction("Index");
  //   }

  //   [HttpPost]
  //   public ActionResult DeleteCourse(int joinId)
  //   {
  //     var joinEntry = _db.CourseStudent.FirstOrDefault(entry => entry.CourseStudentId == joinId);
  //     _db.CourseStudent.Remove(joinEntry);
  //     _db.SaveChanges();
  //     return RedirectToAction("Index");
  //   }
  }
}