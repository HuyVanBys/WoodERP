using BOSERP;
using System.Collections.Generic;

namespace BOSReport
{
    public partial class RPBarcodeOperation : BaseReport
    {
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public RPBarcodeOperation(List<MMOperationsInfo> objICProductsInfo)
        {
            InitializeComponent();
            this.DataSource = objICProductsInfo;
            //this.Watermark.Image = Image.FromFile(Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyBackgroundlogo);
        }
    }
}
