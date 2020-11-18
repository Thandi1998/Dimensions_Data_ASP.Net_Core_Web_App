using System;
using System.Collections.Generic;

#nullable disable

namespace Dimensions_Data.Models
{
    public partial class EmployeeWorkInfomation
    {
        public int EmployeeNumber { get; set; }
        public int StandardHours { get; set; }
        public string StockOptionLevel { get; set; }
        public string TotalWorkingYears { get; set; }
        public string TrainingTimesLastYear { get; set; }
        public string WorkLifeBalance { get; set; }
        public string YearsAtCompany { get; set; }
        public string YearsInCurrentRole { get; set; }
        public string YearsSinceLastPromotion { get; set; }
    }
}
