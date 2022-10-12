using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Part.Models
{
    public class MvcEmployee
    {
        public int employee_id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string first_name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string last_name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string phone_number { get; set; }
        public Nullable<System.DateTime> hire_date { get; set; }
        public Nullable<int> job_id { get; set; }
        public Nullable<decimal> salary { get; set; }
        public Nullable<int> manager_id { get; set; }
        public Nullable<int> department_id { get; set; }
    }
}