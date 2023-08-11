using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class BysSplashForm : SplashScreen
    {
        public BysSplashForm()
        {
            InitializeComponent();
            this.labelCopyright.Text = string.Format("Copyright © 2010-{0}. All right reserved", DateTime.Now.Year.ToString());
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}