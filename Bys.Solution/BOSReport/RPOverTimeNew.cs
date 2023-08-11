using DevExpress.XtraReports.UI;

namespace BOSReport
{
    public partial class RPOverTimeNew : BaseReport
    {
        public RPOverTimeNew()
        {
            InitializeComponent();
            //logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
            ////this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }

        private void XrTableCell3_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {

            //Dim cell As XRTableCell
            //Dim check As XRCheckBox

            //cell = CType(sender, XRTableCell)
            //check = CType(cell.Controls(0), XRCheckBox)

            //If(Me.GetCurrentColumnValue("Discontinued") = True) Then
            //    check.Left = cell.Width / 2 - check.Width / 2
            //Else
            //    check.Left = cell.Width - check.Width
            //End If
            XRTableCell cell = (XRTableCell)sender;
            XRCheckBox check = new XRCheckBox();
            //check.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            check.Left = cell.Width / 2 - check.Width / 2;
            check.DataBindings.Add("CheckState", "[HREmployeeOTs]", "[HREmployeeOTChecked]");
            //XRCheckBox check = (XRCheckBox)cell.Controls[0];

            //if (bool.Parse(cell.Text) == true)
            //{
            //    check.CheckState = CheckState.Checked;
            //}
            //else
            //{
            //    check.CheckState = CheckState.Unchecked;
            //}

            cell.Controls.Add(check);
        }
    }
}
