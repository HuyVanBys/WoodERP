using BOSERP;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPRevenueByCustomerType : BaseReport
    {



        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public RPRevenueByCustomerType(BandedGridView view)
        {
            InitializeComponent();
            InitColumn(view);


            this.DataSource = view.DataSource;
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
