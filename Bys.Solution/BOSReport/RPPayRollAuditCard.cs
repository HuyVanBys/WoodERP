using DevExpress.XtraReports.UI;
using System;
namespace BOSReport
{
    public partial class RPPayRollAuditCard : BaseReport
    {
        public RPPayRollAuditCard()
        {
            InitializeComponent();
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        public override void SetTextTableCell(XRTableCell cell)
        {
            if (cell.DataBindings.Count > 0)
            {
                string dataMember = cell.DataBindings[0].DataMember;
                if (dataMember == "HRPayRollAuditDate")
                {
                    DateTime value = Convert.ToDateTime(GetCurrentColumnValue("HRPayRollAuditDate"));
                    if (value.Date == DateTime.MinValue.Date)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeeWorkingSlrAmt")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeeWorkingSlrAmt"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditTotalWorkingSalary")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditTotalWorkingSalary"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditExtraSalary")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditExtraSalary"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditReward")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditReward"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditCommission")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditCommission"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditTotalInsAmt")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditTotalInsAmt"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditSyndicateFee")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditSyndicateFee"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditIncomeTaxAmount")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditIncomeTaxAmount"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditAdvance")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditAdvance"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditDiscipline")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditDiscipline"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
                else if (dataMember == "HREmployeePayRollAuditTotalSalary")
                {
                    double value = Convert.ToDouble(GetCurrentColumnValue("HREmployeePayRollAuditTotalSalary"));
                    if (value == 0)
                    {
                        cell.Text = string.Empty;
                    }
                }
            }
        }
    }
}
