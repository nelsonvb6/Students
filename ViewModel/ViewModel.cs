using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Students.ViewModel
{
    public class student
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "First Name")]
        public string studentFirstName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Last Name")]
        public string studentLastName { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Date of Birth")]
        public string studentDOB { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Address")]
        public string Address { get; set; }
    }
}