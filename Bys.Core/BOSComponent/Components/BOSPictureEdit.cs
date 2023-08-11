using BOSLib;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace BOSComponent
{
    public partial class BOSPictureEdit : DevExpress.XtraEditors.PictureEdit, IBOSControl
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
        protected string _FileName;
        protected string _FilePath;
        protected PictureMenu _menu;
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

        public string FileName
        {
            get { return _FileName; }
            set { _FileName = value; }
        }

        public string FilePath
        {
            get { return _FilePath; }
            set { _FilePath = value; }
        }

        protected override PictureMenu Menu
        {
            get
            {
                if (_menu == null) _menu = new BOSPictureMenu(this);
                return _menu;
            }
        }

        #endregion

        #region Constructor
        public BOSPictureEdit()
        {
            InitializeComponent();
            this.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.Properties.PictureStoreMode = PictureStoreMode.ByteArray;
        }

        public BOSPictureEdit(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
        }
        #endregion

        #region--Initialize--
        public void InitializeControl(STFieldsInfo objFieldsInfo)
        {

        }

        public void InitializeControl()
        {
            if (!String.IsNullOrEmpty(this.BOSDataSource) && !String.IsNullOrEmpty(this.BOSDataMember))
                ((BOSScreen)Screen).BindingDataControl(this);
            this.KeyUp += new KeyEventHandler(((IBaseModuleERP)Screen.Module).Control_KeyUp);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            guiZoomImage zoomImage = new guiZoomImage(Image);
            zoomImage.ShowDialog();
        }
        #endregion
    }

    public class BOSPictureMenu : PictureMenu
    {
        public BOSPictureMenu(IPictureMenu menuControl) : base(menuControl) { }
        protected override void PasteImage(Image im)
        {
            FieldInfo fi = typeof(PictureMenu).GetField("openFile", BindingFlags.Instance | BindingFlags.NonPublic);
            if (fi == null) return;
            OpenFileDialog od = fi.GetValue(this) as OpenFileDialog;
            BOSPictureEdit pe = MenuControl as BOSPictureEdit;
            if (pe != null && od != null)
            {
                pe.FileName = od.SafeFileName;
                pe.FilePath = od.FileName;

            }
            base.PasteImage(im);
        }
    }
}
