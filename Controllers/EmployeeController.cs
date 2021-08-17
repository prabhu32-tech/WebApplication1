using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Repository;
using WebApplication2.ViewModel;


namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Common objRepo = new Common();
            var appRefStatus = objRepo.GetAppRefData(1800);
            var workComps = objRepo.GetWorkingComp();
            var appRefType = objRepo.GetAppRefData(1220);
            var batchId = objRepo.GetAppRefData(2500);
            var Depart = objRepo.GetDepartment();
            var workLoc = objRepo.GetWorkLoc();
            var hrRep = objRepo.GetHr();
            var actualRep = objRepo.GetActRecr();
            var empVM = new EmployeeAddEditViewModel
            {
               StatusList = appRefStatus,
               WorkComp = workComps,
                GetEmpType = appRefType,
                BatchId= batchId,
                Department= Depart,
                WorkLoc= workLoc,
                HrRep= hrRep,
                ActualRep= actualRep

            };

            return View(empVM);
        }
    }
};