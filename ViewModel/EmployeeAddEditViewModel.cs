using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.ViewModel
{
    public class EmployeeAddEditViewModel
    {
        public Employee Employee { get; set;}

        
        public List<City> Cities { get; set; }
        public List<WorkingComp> Companies { get; set; }
        public List<PayrollComp> PayrollComps { get; set; }
        public List<EmpStatus> Status { get; set; }
        public List<EmpType> EmpTypes { get; set; }
        public List<Department> Departments { get; set; }
        public List<HrRepresentative> Hrs { get; set; }
        public List<ActualRec> ActualRecs { get; set; }
        public List<WorkLoc> WorkLocs { get; set; }
        public List<AppRefData> StatusList { get;  set; }
        public List<GetCompData> WorkComp { get; set; }
        public List<AppRefData> GetEmpType { get; set; }
        public List<AppRefData> BatchId { get; set; }

        public List<AppRefData> Department { get; set; }
        public List<AppRefData> WorkLoc { get; set; }

        public List<AppRefData> HrRep { get; set; }
        public List<AppRefData> ActualRep { get; set; }



    }
}