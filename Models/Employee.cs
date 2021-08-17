using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage ="**Invalid Name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "**Please select valid city")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "**Please select Working company")]
        [Display(Name = "Working Company")]
        public string WorkingCompany { get; set; }
        
        [Required(ErrorMessage = "**Please select Payroll company")]
        [Display(Name = "Payroll Company")]
        public string PayrollCompany { get; set; }
        
        [Required(ErrorMessage ="**Select Staus")]
        [Display(Name = "Employee Staus")]
        public string EmployeeStaus { get; set; }

        [Required(ErrorMessage = "**Select Gender")]
        public string Gender { get; set; }
        
        [Required]
        [Display(Name = "Employee Type")]
        public string EmployeeType { get; set; }

        [Required]
        public int SSN { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]       
        public DataType Date_of_Birth { get; set; }

        [Required]
        public int Department { get; set; }

        [Required]
        [Display(Name = "Personal Email")]
        public string PersonalEmail { get; set; }
        
        [Required]
        [Display(Name = "Official Email")]
        public string OfficialEmail { get; set; }

        [Required]
        [Display(Name = "Date of Hire")]
        [DataType(DataType.Date)]
        public DataType Date_of_Hire { get; set; }

        [Required]
        [Display(Name = "HR Representative")]
        public string HrRepresentative { get; set; }

        [Required]
        [Display(Name = "Actual Recruiter")]
        public string ActualRec { get; set; }

        [Required]
        [Display(Name = "Work Location")]
        public string WorkLoc { get; set; }

        public int? ProjectId { get; set; }
        public int Status { get; set; }

        public int BatchID { get; set; }
        public int Departments { get; set; }


    }
}