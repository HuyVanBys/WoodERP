using BOSERP;
using System.Collections.Generic;

namespace BOSReport
{
    public partial class RPBarcode : BaseReport
    {
        /// <summary>
        /// Gets or sets stock list
        /// </summary>
        public RPBarcode(List<ICProductsInfo> objICProductsInfo)
        {
            InitializeComponent();
            this.DataSource = objICProductsInfo;
        }
    }
}
