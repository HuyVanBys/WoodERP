using BOSERP;
using System.Collections.Generic;

namespace BOSReport
{
    public partial class RPQRcode : BaseReport
    {
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public RPQRcode(List<ICProductsInfo> objICProductsInfo)
        {
            InitializeComponent();
            this.DataSource = objICProductsInfo;
        }
    }
}
