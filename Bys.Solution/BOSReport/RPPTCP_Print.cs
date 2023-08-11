using BOSERP;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPPTCP_Print : BaseReport
    {



        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public RPPTCP_Print(BandedGridView view, string dateStr)
        {
            InitializeComponent();
            InitColumn(view);


            this.DataSource = view.DataSource;
            xr_lblFromdateTodate.Text = dateStr;
            xrPictureBox1.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }


        /// <summary>
        /// Init column by date type
        /// </summary>
        /// <param name="dateType">The date format</param>
        /// <param name="index">The start index of date</param>
        public void InitColumn(BandedGridView view)
        {
            XRTableCell cell;
            XRTableCell cellData;
            foreach (BandedGridColumn column in view.Columns)
            {
                cell = new XRTableCell();
                cell.Name = column.Name;
                cell.Text = column.Caption;
                cell.Weight = 0.55;

                xrTableRow1.Cells.Add(cell);



                cellData = new XRTableCell();
                cellData.DataBindings.AddRange(new XRBinding[] { new XRBinding("Text", null, column.Name, column.DisplayFormat.FormatString) });
                cellData.Name = column.Name;
                cellData.Weight = 0.55;

                // cellData.CanShrink = true;
                xrTableRow3.Cells.Add(cellData);

            }
            // xrTable2.CanShrink = true;

            // xrTableRow3.CanShrink = true;
        }

    }
}
