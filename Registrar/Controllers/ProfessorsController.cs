using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar
{
  public class ProfessorsController : Controller
  {
    private readonly RegistrarContext _db;
    
    public ProfessorsController (RegistrarContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      return View(_db.Professors.ToList());
    }
        public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Professor professor)
    {
      _db.Professors.Add(professor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Details(int id)
    {
      Professor thisProfessor = _db.Professors
      .Include(professor => professor.Department)
      .FirstOrDefault(professor => professor.ProfessorId == id);
      return View(thisProfessor);
    }
    public ActionResult Edit(int id)
    {
      var thisProfessor = _db.Professors.FirstOrDefault(professors => professors.ProfessorId == id);
      ViewBag.DepartmentId = new SelectList(_db.Departments, "DepartmentId", "DepartmentName");
      return View(thisProfessor);
    }
    [HttpPost]
    public ActionResult Edit(Professor professor, int DepartmentId)
    {
      _db.Entry(professor).State = EntityState.Modified;
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
    public ActionResult Delete(int id)
    {
      Professor thisProfessor = _db.Professors.FirstOrDefault(professors => professors.ProfessorId == id);
      return View(thisProfessor);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Professor thisProfessor = _db.Professors.FirstOrDefault(professors => professors.ProfessorId == id);
      _db.Professors.Remove(thisProfessor);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}