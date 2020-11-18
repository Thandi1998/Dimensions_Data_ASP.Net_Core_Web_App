using System;
using System.Collections.Generic;

#nullable disable

namespace Dimensions_Data.Models
{
    public partial class PerfomanceAndRate
    {
        public int EmployeeNumber { get; set; }
        public int MonthlyIncome { get; set; }
        public int MonthlyRate { get; set; }
        public string NumCompaniesWorked { get; set; }
        public string OverTime { get; set; }
        public int PercentSalaryHike { get; set; }
        public int PerformanceRating { get; set; }
        public string RelationshipSatisfaction { get; set; }
    }
}
