using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class SampleController : Controller
    {
        public ActionResult Index()
        {
            var WorkingCompnay = new List<WorkingComp>();
            WorkingCompnay.Add(new WorkingComp { Id = 1, Name = "Compunnel Inc" });
            WorkingCompnay.Add(new WorkingComp { Id = 2, Name = "Infopro Learning Inc" });
            WorkingCompnay.Add(new WorkingComp { Id = 3, Name = "Compunnel Healthcare" });
            WorkingCompnay.Add(new WorkingComp { Id = 4, Name = "JobleticsPro" });
            WorkingCompnay.Add(new WorkingComp { Id = 5, Name = "Compunnel India" });
            WorkingCompnay.Add(new WorkingComp { Id = 6, Name = "Compunnel Canada" });
            WorkingCompnay.Add(new WorkingComp { Id = 7, Name = "LMG Healthcare" });
            var emp = new EmployeeNew
            {
                Companies = WorkingCompnay
            };

            return View();
        }
        // GET: Sample
        [HttpPost]
        public ActionResult Index(EmployeeNew emp)
        {
            if (ModelState.IsValid)
            {
                TempData["emp"] = emp;
                return Redirect("/Sample/Index");
            }
            else
            {
                return View(emp);
            }
        }
        //public ActionResult Details(EmployeeNew emp)
        //{
         //   if (ModelState.IsValid)
        //    {
         //       TempData["emp"] = emp;

                //EmployeeNew emp = (EmployeeNew)TempData["emp"];
           //     return Redirect("/Sample/Index"); 
           // }
          //  else {return View(emp); }
        //}
    }
}