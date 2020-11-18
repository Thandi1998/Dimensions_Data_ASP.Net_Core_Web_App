using System;
using System.Collections.Generic;

#nullable disable

namespace Dimensions_Data.Models
{
    public partial class DepartmentsAndEducation
    {
        public int EmployeeNumber { get; set; }
        public string Department { get; set; }
        public string Education { get; set; }
        public string EducationField { get; set; }
        public string EmployeeCount { get; set; }
        public string JobInvolvement { get; set; }
        public string JobLevel { get; set; }
        public string JobRole { get; set; }
        public string JobSatisfaction { get; set; }
    }
}
