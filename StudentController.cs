using Microsoft.AspNetCore.Mvc;
using MvcApplication3.Models;
using static MvcApplication3.Models.Student;

namespace MvcApplication3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var context = new StudentContext();
            var model = context.Stud.ToList();
            return View(model);
        }

        public IActionResult OnAdd()
        {
            var context = new Student();
            return View(context);
        }
        [HttpPost]
        public IActionResult OnAdd(Student postedRec)
        {
            var model = new StudentContext();
            model.Stud.Add(postedRec);
            model.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult OnFind(int id)
        {

            var context = new StudentContext();
            var model = context.Stud.FirstOrDefault(r => r.Id == id);
            if (model == null)
            {
                throw new Exception("No record Found");
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult OnFind(Student postedData)
        {
            var context = new StudentContext();
            var rec = context.Stud.FirstOrDefault(rec => rec.Id == postedData.Id);
            if (rec != null)
            {
                rec.StudentName = postedData.StudentName;
                rec.Email = postedData.Email;
                rec.age = postedData.age;
                rec.mobileno = postedData.mobileno;
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            else
            {
                return View(postedData);
            }
          

        }
        public IActionResult OnDelete(int id)
        {
            var context = new StudentContext();
            var model = context.Stud.FirstOrDefault(r=>r.Id == id);
            if(model!=null)
            {
                context.Stud.Remove(model); 
                context.SaveChanges();
                return RedirectToAction("Index");   
            }
            else
            {
                throw new Exception("No Data Found");
            }

        }
    }
}
