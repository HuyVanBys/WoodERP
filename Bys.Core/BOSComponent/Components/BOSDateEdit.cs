using BOSLib;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BOSComponent
{
    public partial class BOSDateEdit : DevExpress.XtraEditors.DateEdit, IBOSControl
    {
        #region Private Properties
        private int CheckKey { get; set; }
        #endregion

        #region Variables
        protected String _BOSDataSource;
        protected String _BOSFieldRelation;
        protected String _BOSDataMember;
        protected String _BOSPropertyName;
        protected String _BOSFieldGroup;
        protected String _BOSComment;
        protected BOSScreen _screen;
        protected String _BOSError;
        protected String _BOSPrivilege;
        protected String _BOSDescription;
        #endregion

        #region Public Properties
        [Category("Design")]
        [Browsable(true)]
        public new String Name
        {
            get
            {
                return base.Name;
            }

            set
            {
                base.Name = value;
            }
        }

        public BOSScreen Screen
        {
            get
            {
                return _screen;
            }
            set
            {
                _screen = value;
            }
        }

        [Category("BOS")]
        public String BOSDataSource
        {
            get
            {
                return _BOSDataSource;
            }
            set
            {
                _BOSDataSource = value;
            }
        }

        [Category("BOS")]
        public String BOSDataMember
        {
            get
            {
                return _BOSDataMember;
            }
            set
            {
                _BOSDataMember = value;
            }
        }

        [Category("BOS")]
        public String BOSPropertyName
        {
            get
            {
                return _BOSPropertyName;
            }
            set
            {
                _BOSPropertyName = value;
            }
        }

        [Category("BOS")]
        public String BOSFieldGroup
        {
            get
            {
                return _BOSFieldGroup;
            }
            set
            {
                _BOSFieldGroup = value;
            }
        }

        [Category("BOS")]
        public String BOSFieldRelation
        {
            get
            {
                return _BOSFieldRelation;
            }
            set
            {
                _BOSFieldRelation = value;
            }
        }

        [Category("BOS")]
        public String BOSComment
        {
            get
            {
                return _BOSComment;
            }
            set
            {
                _BOSComment = value;
            }
        }

        [Category("BOS")]
        public String BOSError
        {
            get
            {
                return _BOSError;
            }
            set
            {
                _BOSError = value;
            }
        }

        [Category("BOS")]
        public String BOSPrivilege
        {
            get
            {
                return _BOSPrivilege;
            }
            set
            {
                _BOSPrivilege = value;
            }
        }

        [Category("BOS")]
        public String BOSDescription
        {
            get
            {
                return _BOSDescription;
            }
            set
            {
                _BOSDescription = value;
            }
        }
        #endregion

        #region Constructor
        public BOSDateEdit()
        {
            InitializeComponent();
            Size = new Size(150, 20);
            CheckKey = 0;
        }

        public BOSDateEdit(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            Size = new Size(150, 20);
            CheckKey = 0;
        }
        #endregion

        #region--Initialize--
        public void InitializeControl(STFieldsInfo objFieldInfo)
        {

        }

        public void InitializeControl()
        {
            if (!String.IsNullOrEmpty(this.BOSDataSource) && !String.IsNullOrEmpty(this.BOSDataMember))
            {
                ((BOSScreen)Screen).BindingDataControl(this);
            }

            if (this.Name.Contains("SearchFrom") || this.Name.Contains("SearchTo"))
            {
                if (Tag != null && Tag.ToString() == BOSScreen.SearchControl)
                {
                    if (this.Name.Contains("SearchFrom"))
                        this.EditValue = BOSUtil.GetYearBeginDate();
                    else if (this.Name.Contains("SearchTo"))
                        this.EditValue = BOSUtil.GetYearEndDate();
                }
            }

            Properties.NullDate = DateTime.MaxValue;

            this.Click += ((IBaseModuleERP)Screen.Module).Control_Click;
            this.KeyUp += new KeyEventHandler(((IBaseModuleERP)Screen.Module).Control_KeyUp);
            this.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(BOSDateEdit_Spin);
            this.Click += new EventHandler(this.BOSDateEdit_Click);
            this.KeyUp += new KeyEventHandler(this.BOSDateEdit_KeyUp);
            this.Leave += new EventHandler(this.BOSDateEdit_Leave);
        }

        void BOSDateEdit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            e.Handled = true;
        }

        private void BOSDateEdit_Click(object sender, EventArgs e)
        {
            CheckKey = 0;
        }

        private void BOSDateEdit_Leave(object sender, EventArgs e)
        {
            CheckKey = 0;
        }

        private void BOSDateEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0
                || e.KeyCode == Keys.NumPad1
                || e.KeyCode == Keys.NumPad2
                || e.KeyCode == Keys.NumPad3
                || e.KeyCode == Keys.NumPad4
                || e.KeyCode == Keys.NumPad5
                || e.KeyCode == Keys.NumPad6
                || e.KeyCode == Keys.NumPad7
                || e.KeyCode == Keys.NumPad8
                || e.KeyCode == Keys.NumPad9
                || e.KeyCode == Keys.D0
                || e.KeyCode == Keys.D1
                || e.KeyCode == Keys.D2
                || e.KeyCode == Keys.D3
                || e.KeyCode == Keys.D4
                || e.KeyCode == Keys.D5
                || e.KeyCode == Keys.D6
                || e.KeyCode == Keys.D7
                || e.KeyCode == Keys.D8
                || e.KeyCode == Keys.D9)
            {
                CheckKey++;
                if (CheckKey == 2)
                {
                    SendKeys.Send("{Right}");
                }
                else if (CheckKey == 4)
                {
                    SendKeys.Send("{Right}");
                }
                else if (CheckKey == 8)
                {
                    CheckKey = 0;
                    SendKeys.Send("{Left}");
                    SendKeys.Send("{Left}");
                }
            }
        }
        #endregion
    }
}
