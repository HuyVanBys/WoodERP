using System;
using System.Windows.Forms;

namespace BOSLib
{
    public partial class guiBOSProgressBar : Form
    {
        public guiBOSProgressBar()
        {
            InitializeComponent();
        }

        public guiBOSProgressBar(String desc)
        {
            InitializeComponent();
            fld_lblDescription.Text = desc;
        }

        public void Show(String desc)
        {
            fld_lblDescription.Text = desc;
            this.Show();
        }
    }
}