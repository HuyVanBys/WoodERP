using BOSLib;
using DevExpress.XtraGrid;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSComponent
{
    public partial class BOSTabControl : DevExpress.XtraTab.XtraTabControl, IBOSControl
    {
        #region Variables
        protected String _BOSFieldGroup;
        protected String _BOSFieldRelation;
        protected BOSScreen _screen;
        protected String _BOSComment;
        protected String _BOSDataSource;
        protected String _BOSDataMember;
        protected String _BOSError;
        protected String _BOSPropertyName;
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
            get { return _screen; }
            set { _screen = value; }
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
        public BOSTabControl()
        {
            InitializeComponent();
        }

        public BOSTabControl(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region--Initialize--
        public void InitializeControl(STFieldsInfo objFieldsInfo)
        {

        }

        public void InitializeControl()
        {
            this.KeyUp += new KeyEventHandler(((IBaseModuleERP)Screen.Module).Control_KeyUp);
            this.SelectedPageChanged += BOSTabControl_SelectedPageChanged;
        }

        private void BOSTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            XtraTabPage page = e.Page;
            if (page == null)
                return;

            RefeshDataBindingTabPage(page.Controls);
        }

        public void RefeshDataBindingTabPage(ControlCollection controls)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is IBOSControl)
                    ctrl.Refresh();

                if (ctrl is GridControl)
                    ((GridControl)ctrl).RefreshDataSource();

                if (ctrl is TreeList)
                    ((TreeList)ctrl).RefreshDataSource();

                if (ctrl.Controls.Count > 0)
                    RefeshDataBindingTabPage(ctrl.Controls);
            }
        }
        #endregion
    }
}
