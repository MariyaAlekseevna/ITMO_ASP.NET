using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using StudentScore.Models;
using System.Threading.Tasks;
using System.Text;

namespace StudentScore.Controllers
{
    public class StudentsController : Controller
    {
        private StudentContext db = new StudentContext();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentId,FirstName,LastName,Group,ScoreTask1,ScoreTask2,FinalScore")] Student student)
        {
            if (ModelState.IsValid)
            {
                student.FinalScore = student.ScoreTask1 + student.ScoreTask2;
                db.Students.Add(student);                      
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. 
        // Дополнительные сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentId,FirstName,LastName,Group,ScoreTask1,ScoreTask2,FinalScore")] Student student)
        {
            if (ModelState.IsValid)
            {
                db.Entry(student).State = EntityState.Modified;
                student.FinalScore = student.ScoreTask1 + student.ScoreTask2;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Student student = db.Students.Find(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult FiveStudentsWithHighScore()
        {
            var fiveStudents = db.Students.OrderByDescending(a => a.FinalScore).Take(5).ToList();
            if (fiveStudents.Count == 0)
            {
                return Content("В таблице нет записей");
                //return HttpNotFound();
            }
            return PartialView(fiveStudents);
        }
        public ActionResult FiveStudentsWithLowScore()
        {
            var fiveStudents = db.Students.OrderBy(a => a.FinalScore).Take(5).ToList();
            if (fiveStudents.Count == 0)
            {
                return Content("В таблице нет записей");
            }
            return PartialView(fiveStudents);
        }
        public ActionResult StudentToFile()
        {
            var allStudents = db.Students.ToList();
            if (allStudents.Count == 0)
            {
                return Content("В таблице нет записей");
            }
            string path = @"C:\Users\shibanovi\source\repos\ITMO.APSNET\StudentScore\StudentScore.txt";
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(path);
            if (fileInfo.Exists)
            {
                fileInfo.Delete();
            }
            foreach (var student in allStudents)
            {
                System.IO.File.AppendAllText(path, student.StudentId +";"+ student.FirstName + ";"
                    + student.LastName + ";" + student.Group + ";" + student.ScoreTask1 + ";" 
                    + student.ScoreTask2 + ";" + student.FinalScore+"\n");
            }
            return PartialView();
        }       
    }
}
