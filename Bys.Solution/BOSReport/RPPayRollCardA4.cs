using BOSERP;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPayRollCardA4 : BaseReport
    {
        public RPPayRollCardA4()
        {
            InitializeComponent();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        public override void SetTextTableCell(XRTableCell cell)
        {
            //if (cell.DataBindings.Count > 0)
            //{
            //    string dataMember = cell.DataBindings[0].DataMember;
            //    if (dataMember == "HRPayRollDate")
            //    {
            //        DateTime value = Convert.ToDateTime(GetCurrentColumnValue("HRPayRollDate"));
            //        if (value.Date == DateTime.MinValue.Date)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeeWorkingSlrAmt")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeeWorkingSlrAmt"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollTotalWorkingSalary")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollTotalWorkingSalary"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }                
            //    else if (dataMember == "HREmployeePayRollExtraSalary")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollExtraSalary"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollReward")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollReward"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollCommission")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollCommission"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollTotalInsAmt")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollTotalInsAmt"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollSyndicateFee")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollSyndicateFee"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollIncomeTaxAmount")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollIncomeTaxAmount"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollAdvance")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAdvance"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollDiscipline")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollDiscipline"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }
            //    else if (dataMember == "HREmployeePayRollTotalSalary")
            //    {
            //        double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollTotalSalary"));
            //        if (value == 0)
            //        {
            //            cell.Text = string.Empty;
            //        }
            //    }    
            //}
        }
    }
}
