using System;
using System.Collections.Generic;

#nullable disable

namespace Dimensions_Data.Models
{
    public partial class EmployeeBasicInfo
    {
        public int EmployeeNumber { get; set; }
        public string Attrition { get; set; }
        public string BusinessTravel { get; set; }
        public int DailyRate { get; set; }
        public string DistanceFromHome { get; set; }
        public string EnvironmentSatisfaction { get; set; }
        public int HourlyRate { get; set; }
    }
}
