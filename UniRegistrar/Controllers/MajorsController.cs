using Microsoft.AspNetCore.Mvc;
using UniRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UniRegistrar.Controllers
{
    public class MajorsController : Controller
    {
        private readonly UniRegistrarContext _db;

        public MajorsController(UniRegistrarContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Major> model = _db.Majors.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(_db.Departments, "DepartmentId", "DepartmentName");
            return View();
        }

        [HttpPost]
        public ActionResult Create(Major major, int DepartmentId)
        {
            _db.Majors.Add(major);
            if (DepartmentId != 0)
            {
                _db.Enrollment.Add(new Enrollment() { DepartmentId = DepartmentId, MajorId = major.MajorId});
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var thisMajor = _db.Majors
                .Include(major => major.Courses)
                    .ThenInclude(join => join.Course)
                // .Include(major => major.Departments)
                //     .ThenInclude(join => join.Department)
                .FirstOrDefault(major => major.MajorId == id);
            return View(thisMajor);
        }

    }
}