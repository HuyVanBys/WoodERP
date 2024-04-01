using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Controls;
using Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class AccObjectLookupEdit : BOSLookupEdit
    {
        [Category("BOS")]
        public string BOSModuleType { get; set; }

        public DateTime LastedUpdate { get; set; }

        public AccObjectLookupEdit()
        {
            InitializeComponent();
        }

        public AccObjectLookupEdit(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public override void InitializeControl()
        {
            try
            {
                this.LookupTables = ((IBaseModuleERP)this.Screen.Module).GetLookupTableCollection();
                this.LookupTablesUpdatedDate = ((IBaseModuleERP)this.Screen.Module).GetLookupTableUpdatedDateCollection();
                this.LookupTableObjects = ((IBaseModuleERP)this.Screen.Module).GetLookupTableObjects();
                this.InitLookupEditColumns();
                this.InitObjectDataToLookupEdit();
                this.LastUpdatedDate = DateTime.Now;
                this.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
                this.Properties.SearchMode = SearchMode.AutoFilter;
                this.Properties.TextEditStyle = TextEditStyles.Standard;
                this.Properties.NullText = string.Empty;
                this.Properties.AllowMouseWheel = false;
                if (!string.IsNullOrEmpty(this.BOSDataSource) && !string.IsNullOrEmpty(this.BOSDataMember) && !this.BOSDataSource.Equals("ADConfigValues"))
                    this.Screen.BindingDataControl((Control)this);
                this.Click += new EventHandler(((IBaseModuleERP)this.Screen.Module).Control_Click);
                this.KeyUp += new KeyEventHandler(((IBaseModuleERP)this.Screen.Module).Control_KeyUp);
                this.KeyUp += new KeyEventHandler(this.BOSLookupEdit_KeyUp);
                this.EditValueChanged += new EventHandler(this.BOSLookupEdit_EditValueChanged);
                this.ProcessNewValue += new ProcessNewValueEventHandler(this.BOSLookupEdit_ProcessNewValue);
                this.QueryPopUp += new CancelEventHandler(this.BOSLookupEdit_QueryPopUp);
                this.Leave += new EventHandler(this.BOSLookupEdit_Leave);
                this.KeyDown += new KeyEventHandler(this.BOSLookupEdit_KeyDown);
                this.CloseUp += new CloseUpEventHandler(this.BOSLookupEdit_CloseUp);
                this.Spin += new SpinEventHandler(this.BOSLookupEdit_Spin);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message, CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            BOSLookupEdit_QueryPopUp(null, null);
            Properties.ValueMember = "ACObjectAccessKey";
            Properties.DisplayMember = "ACObjectName";
        }

        private void BOSLookupEdit_Spin(object sender, SpinEventArgs e)
        {
            if ((sender as BOSLookupEdit).IsPopupOpen)
                return;
            e.Handled = true;
        }

        protected override void BOSLookupEdit_EditValueChanged(object sender, EventArgs e)
        {
            base.BOSLookupEdit_EditValueChanged(sender, e);
            //ReloadDatasource();
        }

        public override void InitLookupEditColumns()
        {
            this.Properties.Columns.Clear();

            LookUpColumnInfo column = new LookUpColumnInfo();
            column.Caption = BaseLocalizedResources.ACObjectNo;
            column.FieldName = "ACObjectNo";
            this.Properties.Columns.Add(column);

            column = new LookUpColumnInfo();
            column.Caption = BaseLocalizedResources.ACObjectName;
            column.FieldName = "ACObjectName";
            this.Properties.Columns.Add(column);

            column = new LookUpColumnInfo();
            column.Caption = BaseLocalizedResources.ACObjectContactPhone;
            column.FieldName = "ACObjectContactPhone";
            this.Properties.Columns.Add(column);

            column = new LookUpColumnInfo();
            column.Caption = BaseLocalizedResources.ACObjectContactAddress;
            column.FieldName = "ACObjectContactAddress";
            this.Properties.Columns.Add(column);

            column = new LookUpColumnInfo();
            column.Caption = BaseLocalizedResources.ACObjectTaxNumber;
            column.FieldName = "ACObjectTaxNumber";
            this.Properties.Columns.Add(column);
        }

        protected override void InitObjectDataToLookupEdit()
        {
            ReloadDataSourceToLookupEdit();
        }

        private void ReloadDataSourceToLookupEdit()
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            List<ACObjectsInfo> objects = new List<ACObjectsInfo>();
            if (!string.IsNullOrEmpty(BOSModuleType))
            {
                objects = objObjectsController.GetObjectViewPermissionByUseIDAndModule(BOSApp.CurrentUsersInfo.ADUserID, BOSModuleType);
            }
            else
            {
                if (this.Screen != null && this.Screen.Module != null)
                objects = objObjectsController.GetObjectViewPermissionByUseIDAndModule(BOSApp.CurrentUsersInfo.ADUserID, this.Screen.Module.Name);
            }
            if (BOSAllowDummy)
            {
                objects.Insert(0, new ACObjectsInfo());
            }
            Properties.DataSource = objects;
            LastedUpdate = BOSApp.GetCurrentServerDate();
        }

        private void ReloadDatasource()
        {
            ACObjectsController objObjectsController = new ACObjectsController();
            bool isUpdate = objObjectsController.CheckObjectChangeFromDatabase(LastedUpdate, !string.IsNullOrEmpty(BOSModuleType) ? this.Screen.Module.Name : BOSModuleType);
            if (!isUpdate)
                return;

            ReloadDataSourceToLookupEdit();
        }

        protected override void BOSLookupEdit_QueryPopUp(object sender, CancelEventArgs e)
        {
            ReloadDatasource();
        }
    }
}
