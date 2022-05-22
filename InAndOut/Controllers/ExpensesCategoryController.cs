using InAndOut.Data;
using InAndOut.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InAndOut.Controllers
{
    public class ExpensesCategoryController : Controller
    {
        public readonly ApplicationDbContex _db;

        public ExpensesCategoryController(ApplicationDbContex db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<ExpensesCategory> objList = _db.ExpensesCategory;
            return View(objList);
        }

        //GET - Create
        public IActionResult Create()
        {
            return View();
        }

        //POST - Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ExpensesCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpensesCategory.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
        }

        //GET - Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpensesCategory.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST - Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var obj = _db.ExpensesCategory.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.ExpensesCategory.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET - Update
        public IActionResult Update(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.ExpensesCategory.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //POST - Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ExpensesCategory obj)
        {
            if (ModelState.IsValid)
            {
                _db.ExpensesCategory.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(obj);
        }

    }
}
