using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class EmployeeNew
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide First Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First Name Should be min 5 and max 20 length")]
        public String FirstName{ get; set;}

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Last Name")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "First Name Should be min 5 and max 20 length")]
        public String LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Eamil")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        public String Email { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Age")]
        [Range(25, 45, ErrorMessage = "Age Should be min 25 and max 45")]
        public int? Age { get; set; }
      
        [Required(ErrorMessage = "Please Provide Gender")]
        public bool Gender { get; set; }

        [Required(ErrorMessage = "Please Select Working Company")]
        public List<WorkingComp> Companies { get; set; }
    }
    public class WorkingCom
    {
        [Required(ErrorMessage = "Please Select Working Company")]
        public string WorkComp { get; set; }
    }
}