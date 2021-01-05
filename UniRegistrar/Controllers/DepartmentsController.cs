using Microsoft.AspNetCore.Mvc;
using UniRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UniRegistrar.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly UniRegistrarContext _db;

        public DepartmentsController(UniRegistrarContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<Department> model = _db.Departments.ToList();
            return View(model);
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
                .Include(department => department.Majors)
                .ThenInclude(join => join.Major)
                .FirstOrDefault(department => department.DepartmentId == id);
                return View(thisDepartment);
        }

        public ActionResult Delete(int id)
        {
            // needs code
        }
    }
}