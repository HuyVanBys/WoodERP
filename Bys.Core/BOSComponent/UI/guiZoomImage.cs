using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BOSComponent
{
    public partial class guiZoomImage : XtraForm
    {
        /// <summary>
        /// A variable to store ID of the previous selected location
        /// </summary>
        private int LocationID;

        /// <summary>
        /// Gets or sets the tree list binded to the location tree list control
        /// </summary>

        public guiZoomImage()
        {
            InitializeComponent();
        }
        public guiZoomImage(Image image)
        {
            InitializeComponent();
            this.pictureEdit1.Image = image;
        }


        private void fld_btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fld_btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }





    }
}
