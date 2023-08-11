using System;
using System.Windows.Forms;

namespace BOSERP.BaseProvider.Components
{
    public partial class guiTableSize : BOSERPScreen
    {
        /// <summary>
        /// Gets or sets the row count
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// Gets or sets the column count
        /// </summary>
        public int Columns { get; set; }

        public guiTableSize()
        {
            InitializeComponent();
        }

        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Rows = Convert.ToInt32(fld_txtRow.Text);
            Columns = Convert.ToInt32(fld_txtColumn.Text);
        }


    }
}
