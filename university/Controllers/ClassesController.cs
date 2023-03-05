using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using university.Models;
using university.Repositories;
namespace university.Controllers
{

    public class ClassesController : Controller
    {
        //GET
        public ActionResult Index()
        {
            List<Class> classes = new List<Class>();
            classes.Add(new Class(1, 06.11, 1,"Math",3));
            classes.Add(new Class(2, 07.11, 3, "Angl", 5));
            classes.Add(new Class(3, 08.11, 5, "Bio", 2));
            classes.Add(new Class(4, 09.11, 7, "Baz", 8));
            classes.Add(new Class(5, 10.11, 9, "Math", 1));
            classes.Add(new Class(6, 11.11, 11, "Math", 9));




            return View("Index", classes);
        }




    }

   /* public class ClassesController : Controller
    {
        // GET: ClassesController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ClassesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClassesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassesController/Edit/5
          [HttpGet]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClassesController/Edit/5
     
        
        public ActionResult Edit(int id, IFormCollection collection)
        {
            
            
                return RedirectToAction("Index");
           
         
        }

        // GET: ClassesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClassesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


       
    }*/
}
