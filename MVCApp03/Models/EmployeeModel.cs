4using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp03.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Email { get; set; }
        public string ConfirmEmail{ get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
}