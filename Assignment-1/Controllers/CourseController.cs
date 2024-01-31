using Assignment_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        static List<Courses> courses = new List<Courses>()
        {
            new Courses(){CId=1,CName="Abhi",CFee=20000,Technology=".Net",CStartDate=new DateTime(day:23,month:12,year:2012),CEndDate=new DateTime(day:30,month:08,year:2013) },
             new Courses(){CId=2,CName="Riya",CFee=15000,Technology="Python",CStartDate=new DateTime(day:13,month:09,year:2016),CEndDate=new DateTime(day:03,month:11,year:2016) },
              new Courses(){CId=3,CName="Sai",CFee=25000,Technology="Java FullStack",CStartDate=new DateTime(day:22,month:11,year:2020),CEndDate=new DateTime(day:15,month:08,year:2021) },
               new Courses(){CId=4,CName="Janu",CFee=10000,Technology="ChatGpt",CStartDate=new DateTime(day:02,month:12,year:2015),CEndDate=new DateTime(day:08,month:06,year:2017) },

        };
        public ActionResult Index()
        {
            return View(courses);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Courses());
        }
        [HttpPost]
        public ActionResult Create(Courses cou)
        {
            if (ModelState.IsValid)
            {
                courses.Add(cou);
                return RedirectToAction("Index");

            }
            return View(cou);
        }
    }
}