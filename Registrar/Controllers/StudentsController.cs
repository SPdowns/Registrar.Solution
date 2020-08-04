using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly RegistrarContext _db;
    
    public StudentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Students.OrderBy(student => student.StudentId).ToList());
    }

    public ActionResult Create()
    {
      return View();
    }
    [HttpPost]
    public ActionResult Create(Student student)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }


  }
}