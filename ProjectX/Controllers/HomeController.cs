using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using ProjectX.Models;

namespace ProjectX.Controllers
{
    public class HomeController : Controller

    {
        private ApplicationDbContext db = new ApplicationDbContext();
       

        public ActionResult Index()
        {
          
            return View();
        }

        //  get methodes exemple


        // GET: Students

        public ActionResult GetMethod()
        {
                return View();
        }
        [HttpGet]

        public ActionResult GetMethod(int id)
        {
         if (id>10)
            {
                return View(id);
            }
         else
            {
                return View("Error");
            }
               
            
        }

        public ActionResult GetMethod1()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetMethod1(int? id)
        {
            
                return View(id);
        
        }



        public ActionResult GetMethod3()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetMethod3(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }

            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(students.name);
            }

        }

        public ActionResult PostMethod()
        {
            return View();
        }

        // 

        //  post methodes exemple
        [HttpPost]

        public ActionResult PostMethod(string student, HttpPostedFileBase profile)
        {
            return View();
        }

        

        // 
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}