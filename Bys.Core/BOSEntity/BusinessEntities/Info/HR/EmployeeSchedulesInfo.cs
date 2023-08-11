using BOSLib;
using System;
namespace BOSERP
{
    public class EmployeeSchedulesInfo : BusinessObject
    {
        public string EmployeeName { get; set; }
        public DateTime WorkDate { get; set; }
        public string Sheet { get; set; }
    }
}
