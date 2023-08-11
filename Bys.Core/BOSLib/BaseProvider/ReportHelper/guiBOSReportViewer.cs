using CrystalDecisions.Windows.Forms;
using System.Windows.Forms;
namespace BOSLib
{
    public partial class guiBOSReportViewer : Form
    {
        public guiBOSReportViewer()
        {
            InitializeComponent();
        }

        public CrystalReportViewer BOSReportViewer
        {
            get { return fld_crReportViewer; }
            set { fld_crReportViewer = value; }
        }
    }
}