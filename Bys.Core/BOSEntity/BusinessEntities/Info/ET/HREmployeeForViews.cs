using BOSLib;
using System;
namespace BOSERP
{
    public class HREmployeeForViews : HREmployeesInfo
    {
        public HREmployeeForViews()
        { }

        public String HREmployeeGender { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupPrice)]
        public decimal TotalSaleAmount { get; set; }

        [FormatGroup(FormatGroupAttribute.cstFormatGroupQty)]
        public decimal TotalSaleQty { get; set; }

        //Salary
        public DateTime HREmployeeSalaryDate { get; set; }
        public decimal HREmployeeSalaryTotal { get; set; }
        public decimal HREmployeeSalaryCommission { get; set; }
        public String HREmployeePayrollFomularName { get; set; }
        public String HREmployeeIDCardPlaceName { get; set; }
        public String GEStateProvinceName { get; set; }


        //Report 154
        public String HREmployeePayrollFormulaName { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupQty)]
        public decimal AllNumberEmployee { get; set; }               //Nhân viên
        public int HRDepartmentRoomIntend { get; set; }
        [FormatGroup(FormatGroupAttribute.cstFormatGroupQty)]
        public decimal NumberNewEmployee { get; set; }               //NV m?i
        [FormatGroup(FormatGroupAttribute.cstFormatGroupQty)]
        public decimal NumberEmployeeOffWord { get; set; }           //NV ngh? 
        [FormatGroup(FormatGroupAttribute.cstFormatGroupQty)]
        public decimal NumberEmployeePresent { get; set; }           //NV có m?t
        public decimal TotalNumberEmployee { get; set; }             //T?ng 
        public decimal NumberEmployeeAbsent { get; set; }            // NV v?ng
        public decimal HREmployeeDifference { get; set; }            // Chênh l?ch
        public int HREmployeePayrollFomularID { get; set; }
        public string HRDormitoryName { get; set; }
    }
}
