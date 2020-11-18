using System;
using System.Collections.Generic;

#nullable disable

namespace Dimensions_Data.Models
{
    public partial class LoginInformation
    {
        public int EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public int JobLevel { get; set; }
        public string JobRole { get; set; }
        public bool loggingSuccess = false;
    }
}
