using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.ViewModel;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class Sample2Controller : Controller
    {
        // GET: Sample2
        public ActionResult Index2()
        {
            var cities = new List<City>();
            cities.Add(new City { Id = 1, Name = "Jpr" });
            cities.Add(new City { Id = 2, Name = "Krl" });

            var WorkingCompnay = new List<WorkingComp>();
            WorkingCompnay.Add(new WorkingComp { Id = 1, Name = "Compunnel Inc" });
            WorkingCompnay.Add(new WorkingComp { Id = 2, Name = "Infopro Learning Inc" });
            WorkingCompnay.Add(new WorkingComp { Id = 3, Name = "Compunnel Healthcare" });
            WorkingCompnay.Add(new WorkingComp { Id = 4, Name = "JobleticsPro" });
            WorkingCompnay.Add(new WorkingComp { Id = 5, Name = "Compunnel India" });
            WorkingCompnay.Add(new WorkingComp { Id = 6, Name = "Compunnel Canada" });
            WorkingCompnay.Add(new WorkingComp { Id = 7, Name = "LMG Healthcare" });

            var PayrollCompnay = new List<PayrollComp>();
            PayrollCompnay.Add(new PayrollComp { Id = 1, Name = "Compunnel Inc" });
            PayrollCompnay.Add(new PayrollComp { Id = 2, Name = "Infopro Learning Inc" });
            PayrollCompnay.Add(new PayrollComp { Id = 3, Name = "Compunnel Healthcare" });
            PayrollCompnay.Add(new PayrollComp { Id = 4, Name = "JobleticsPro" });
            PayrollCompnay.Add(new PayrollComp { Id = 5, Name = "Compunnel India" });
            PayrollCompnay.Add(new PayrollComp { Id = 6, Name = "Compunnel Canada" });
            PayrollCompnay.Add(new PayrollComp { Id = 7, Name = "LMG Healthcare" });

            var status = new List<EmpStatus>();
            status.Add(new EmpStatus { Id = 1, Name = "Active" });
            status.Add(new EmpStatus { Id = 2, Name = "Inactive" });

            var empType = new List<EmpType>();
             empType.Add(new EmpType { Id = 1, Name = "Consultant" });
             empType.Add(new EmpType { Id = 2, Name = "Customer Contact" });
             empType.Add(new EmpType { Id = 3, Name = "In-House Employee" });
             empType.Add(new EmpType { Id = 4, Name = "Job Seeker" });
             empType.Add(new EmpType { Id = 5, Name = "Sub-Contractor" });

            var department = new List<Department>();
            department.Add(new Department { Id = 1, Name = "Sales" });
            department.Add(new Department { Id = 2, Name = "Recrutment" });
            department.Add(new Department { Id = 3, Name = "Legal" });
            department.Add(new Department { Id = 4, Name = "HR" });
            department.Add(new Department { Id = 5, Name = "Accounting" });
            department.Add(new Department { Id = 6, Name = "Custom Project" });

            var hrRep = new List<HrRepresentative>();
            hrRep.Add(new HrRepresentative { Id = 1, Name = "Alok Singh" });
            hrRep.Add(new HrRepresentative { Id = 2, Name = "Ajay Singh" });
            hrRep.Add(new HrRepresentative { Id = 3, Name = "Akshay Kumar" });
            hrRep.Add(new HrRepresentative { Id = 4, Name = "Amit Gaur" });
            hrRep.Add(new HrRepresentative { Id = 5, Name = "Aman Srivastava" });

            var actRec = new List<ActualRec>();
            actRec.Add(new ActualRec { Id = 1, Name = "Alok Singh" });
            actRec.Add(new ActualRec { Id = 2, Name = "Ajay Singh" });
            actRec.Add(new ActualRec { Id = 3, Name = "Akshay Kumar" });
            actRec.Add(new ActualRec { Id = 4, Name = "Amit Gaur" });
            actRec.Add(new ActualRec { Id = 5, Name = "Aman Srivastava" });

            var loc = new List<WorkLoc>();
            loc.Add(new WorkLoc { Id = 1, Name = "Noida" });
            loc.Add(new WorkLoc { Id = 2, Name = "Goa" });
            loc.Add(new WorkLoc { Id = 3, Name = "Pune" });
            loc.Add(new WorkLoc { Id = 4, Name = "Jaipur" });
            loc.Add(new WorkLoc { Id = 5, Name = "California" });

            var emp = new EmployeeAddEditViewModel
            {
                Cities = cities,
                Companies = WorkingCompnay,
                PayrollComps= PayrollCompnay,
                Status = status,
                EmpTypes=empType,
                Departments= department,
                Hrs= hrRep,
                ActualRecs= actRec,
                WorkLocs=loc
            };
  
            return View(emp);
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                var cities = new List<City>();
                cities.Add(new City { Id = 1, Name = "Jpr" });
                cities.Add(new City { Id = 2, Name = "Krl" });

                var WorkingCompnay = new List<WorkingComp>();
                WorkingCompnay.Add(new WorkingComp { Id = 1, Name = "Compunnel Inc" });
                WorkingCompnay.Add(new WorkingComp { Id = 2, Name = "Infopro Learning Inc" });
                WorkingCompnay.Add(new WorkingComp { Id = 3, Name = "Compunnel Healthcare" });
                WorkingCompnay.Add(new WorkingComp { Id = 4, Name = "JobleticsPro" });
                WorkingCompnay.Add(new WorkingComp { Id = 5, Name = "Compunnel India" });
                WorkingCompnay.Add(new WorkingComp { Id = 6, Name = "Compunnel Canada" });
                WorkingCompnay.Add(new WorkingComp { Id = 7, Name = "LMG Healthcare" });

                var PayrollCompnay = new List<PayrollComp>();
                PayrollCompnay.Add(new PayrollComp { Id = 1, Name = "Compunnel Inc" });
                PayrollCompnay.Add(new PayrollComp { Id = 2, Name = "Infopro Learning Inc" });
                PayrollCompnay.Add(new PayrollComp { Id = 3, Name = "Compunnel Healthcare" });
                PayrollCompnay.Add(new PayrollComp { Id = 4, Name = "JobleticsPro" });
                PayrollCompnay.Add(new PayrollComp { Id = 5, Name = "Compunnel India" });
                PayrollCompnay.Add(new PayrollComp { Id = 6, Name = "Compunnel Canada" });
                PayrollCompnay.Add(new PayrollComp { Id = 7, Name = "LMG Healthcare" });

                var status = new List<EmpStatus>();
                status.Add(new EmpStatus { Id = 1, Name = "Active" });
                status.Add(new EmpStatus { Id = 2, Name = "Inactive" });

                var empType = new List<EmpType>();
                empType.Add(new EmpType { Id = 1, Name = "Consultant" });
                empType.Add(new EmpType { Id = 2, Name = "Customer Contact" });
                empType.Add(new EmpType { Id = 3, Name = "In-House Employee" });
                empType.Add(new EmpType { Id = 4, Name = "Job Seeker" });
                empType.Add(new EmpType { Id = 5, Name = "Sub-Contractor" });

                var department = new List<Department>();
                department.Add(new Department { Id = 1, Name = "Sales" });
                department.Add(new Department { Id = 2, Name = "Recrutment" });
                department.Add(new Department { Id = 3, Name = "Legal" });
                department.Add(new Department { Id = 4, Name = "HR" });
                department.Add(new Department { Id = 5, Name = "Accounting" });
                department.Add(new Department { Id = 6, Name = "Custom Project" });

                var hrRep = new List<HrRepresentative>();
                hrRep.Add(new HrRepresentative { Id = 1, Name = "Alok Singh" });
                hrRep.Add(new HrRepresentative { Id = 2, Name = "Ajay Singh" });
                hrRep.Add(new HrRepresentative { Id = 3, Name = "Akshay Kumar" });
                hrRep.Add(new HrRepresentative { Id = 4, Name = "Amit Gaur" });
                hrRep.Add(new HrRepresentative { Id = 5, Name = "Aman Srivastava" });

                var actRec = new List<ActualRec>();
                actRec.Add(new ActualRec { Id = 1, Name = "Alok Singh" });
                actRec.Add(new ActualRec { Id = 2, Name = "Ajay Singh" });
                actRec.Add(new ActualRec { Id = 3, Name = "Akshay Kumar" });
                actRec.Add(new ActualRec { Id = 4, Name = "Amit Gaur" });
                actRec.Add(new ActualRec { Id = 5, Name = "Aman Srivastava" });

                var loc = new List<WorkLoc>();
                loc.Add(new WorkLoc { Id = 1, Name = "Noida" });
                loc.Add(new WorkLoc { Id = 2, Name = "Goa" });
                loc.Add(new WorkLoc { Id = 3, Name = "Pune" });
                loc.Add(new WorkLoc { Id = 4, Name = "Jaipur" });
                loc.Add(new WorkLoc { Id = 5, Name = "California" });

                var empValid = new EmployeeAddEditViewModel
                {
                    Cities = cities,
                    Companies = WorkingCompnay,
                    PayrollComps = PayrollCompnay,
                    Status = status,
                    EmpTypes = empType,
                    Departments = department,
                    Hrs = hrRep,
                    ActualRecs = actRec,
                    WorkLocs = loc
                };

                return View("Index2", empValid);
            }else
            return Content("Ok");
        }

    }

}
