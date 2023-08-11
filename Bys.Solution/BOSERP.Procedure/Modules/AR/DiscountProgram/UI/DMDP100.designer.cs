using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DiscountProgram.UI
{
    /// <summary>
    /// Summary description for DMARCV100
    /// </summary>
    partial class DMDP100
    {


        /// <summary>
        /// Clean up any resources being used
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
                if (components != null)
                    components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMDP100));
            this.fld_txtARDiscountProgramNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_pteARDiscountProgramEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_dgcARDiscountProgramItems = new BOSERP.Modules.DiscountProgram.ARDiscountProgramItemsGridControl();
            this.fld_dgvARDiscountProgram = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_chkARDiscountProgramIsVoucher = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARDiscountProgramCode = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeARDiscountProgramApplyOn = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_lkeFK_ARCustomerDistributionChannelID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARDiscountProgramMethodType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_chkARDiscountProgramIsExhibit = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel43 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARDiscountProgramIsSales = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtARDiscountProgramSaleTarget = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARDiscountProgramItemValue = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_medARDiscountProgramDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtARDiscountProgramName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARDiscountProgramApplyType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeARDiscountProgramType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lblLabel102 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDiscountProgramEndDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDiscountProgramBeginDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_xtabConfig = new DevExpress.XtraTab.XtraTabControl();
            this.fld_tabProductDiscount = new DevExpress.XtraTab.XtraTabPage();
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.fld_btnChooseProduct = new BOSComponent.BOSButton(this.components);
            this.fld_pteARDiscountProgramItemProductPicture = new BOSComponent.BOSPictureEdit(this.components);
            this.fld_tabTargetConfig = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcARDiscountProgramItemTargets = new BOSERP.Modules.DiscountProgram.ARDiscountProgramItemTargetsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeARDiscountProgramstatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARDiscountProgramDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel26 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARDiscountProgramEmployeePicture.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDiscountProgramItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDiscountProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARDiscountProgramIsVoucher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramApplyOn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerDistributionChannelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramMethodType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARDiscountProgramIsExhibit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramIsSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramSaleTarget.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramItemValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARDiscountProgramDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramApplyType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramEndDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramEndDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramBeginDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramBeginDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_xtabConfig)).BeginInit();
            this.fld_xtabConfig.SuspendLayout();
            this.fld_tabProductDiscount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARDiscountProgramItemProductPicture.Properties)).BeginInit();
            this.fld_tabTargetConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDiscountProgramItemTargets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramstatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtARDiscountProgramNo
            // 
            this.fld_txtARDiscountProgramNo.BOSComment = null;
            this.fld_txtARDiscountProgramNo.BOSDataMember = "ARDiscountProgramNo";
            this.fld_txtARDiscountProgramNo.BOSDataSource = "ARDiscountPrograms";
            this.fld_txtARDiscountProgramNo.BOSDescription = null;
            this.fld_txtARDiscountProgramNo.BOSError = null;
            this.fld_txtARDiscountProgramNo.BOSFieldGroup = null;
            this.fld_txtARDiscountProgramNo.BOSFieldRelation = null;
            this.fld_txtARDiscountProgramNo.BOSPrivilege = null;
            this.fld_txtARDiscountProgramNo.BOSPropertyName = "EditValue";
            this.fld_txtARDiscountProgramNo.Location = new System.Drawing.Point(220, 11);
            this.fld_txtARDiscountProgramNo.MenuManager = this.screenToolbar;
            this.fld_txtARDiscountProgramNo.Name = "fld_txtARDiscountProgramNo";
            this.fld_txtARDiscountProgramNo.Screen = null;
            this.fld_txtARDiscountProgramNo.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARDiscountProgramNo.TabIndex = 0;
            this.fld_txtARDiscountProgramNo.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(125, 14);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(71, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Text = "Mã khuyến mãi";
            // 
            // fld_pteARDiscountProgramEmployeePicture
            // 
            this.fld_pteARDiscountProgramEmployeePicture.BOSComment = null;
            this.fld_pteARDiscountProgramEmployeePicture.BOSDataMember = "ARDiscountProgramEmployeePicture";
            this.fld_pteARDiscountProgramEmployeePicture.BOSDataSource = "ARDiscountPrograms";
            this.fld_pteARDiscountProgramEmployeePicture.BOSDescription = null;
            this.fld_pteARDiscountProgramEmployeePicture.BOSError = null;
            this.fld_pteARDiscountProgramEmployeePicture.BOSFieldGroup = null;
            this.fld_pteARDiscountProgramEmployeePicture.BOSFieldRelation = null;
            this.fld_pteARDiscountProgramEmployeePicture.BOSPrivilege = null;
            this.fld_pteARDiscountProgramEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteARDiscountProgramEmployeePicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARDiscountProgramEmployeePicture.FileName = null;
            this.fld_pteARDiscountProgramEmployeePicture.FilePath = null;
            this.fld_pteARDiscountProgramEmployeePicture.Location = new System.Drawing.Point(6, 12);
            this.fld_pteARDiscountProgramEmployeePicture.Name = "fld_pteARDiscountProgramEmployeePicture";
            this.fld_pteARDiscountProgramEmployeePicture.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_pteARDiscountProgramEmployeePicture.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_pteARDiscountProgramEmployeePicture.Properties.Appearance.Options.UseBackColor = true;
            this.fld_pteARDiscountProgramEmployeePicture.Properties.Appearance.Options.UseForeColor = true;
            this.fld_pteARDiscountProgramEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARDiscountProgramEmployeePicture.Screen = null;
            this.fld_pteARDiscountProgramEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteARDiscountProgramEmployeePicture.TabIndex = 0;
            this.fld_pteARDiscountProgramEmployeePicture.Tag = "DC";
            // 
            // fld_dgcARDiscountProgramItems
            // 
            this.fld_dgcARDiscountProgramItems.AllowDrop = true;
            this.fld_dgcARDiscountProgramItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDiscountProgramItems.BOSComment = null;
            this.fld_dgcARDiscountProgramItems.BOSDataMember = null;
            this.fld_dgcARDiscountProgramItems.BOSDataSource = "ARDiscountProgramItems";
            this.fld_dgcARDiscountProgramItems.BOSDescription = null;
            this.fld_dgcARDiscountProgramItems.BOSError = null;
            this.fld_dgcARDiscountProgramItems.BOSFieldGroup = null;
            this.fld_dgcARDiscountProgramItems.BOSFieldRelation = null;
            this.fld_dgcARDiscountProgramItems.BOSGridType = null;
            this.fld_dgcARDiscountProgramItems.BOSPrivilege = null;
            this.fld_dgcARDiscountProgramItems.BOSPropertyName = null;
            this.fld_dgcARDiscountProgramItems.CommodityType = "";
            this.fld_dgcARDiscountProgramItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARDiscountProgramItems.Location = new System.Drawing.Point(3, 42);
            this.fld_dgcARDiscountProgramItems.MainView = this.fld_dgvARDiscountProgram;
            this.fld_dgcARDiscountProgramItems.Name = "fld_dgcARDiscountProgramItems";
            this.fld_dgcARDiscountProgramItems.PrintReport = false;
            this.fld_dgcARDiscountProgramItems.Screen = null;
            this.fld_dgcARDiscountProgramItems.Size = new System.Drawing.Size(1159, 566);
            this.fld_dgcARDiscountProgramItems.TabIndex = 12;
            this.fld_dgcARDiscountProgramItems.Tag = "DC";
            this.fld_dgcARDiscountProgramItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARDiscountProgram});
            // 
            // fld_dgvARDiscountProgram
            // 
            this.fld_dgvARDiscountProgram.GridControl = this.fld_dgcARDiscountProgramItems;
            this.fld_dgvARDiscountProgram.Name = "fld_dgvARDiscountProgram";
            this.fld_dgvARDiscountProgram.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(6, 114);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeNo";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_chkARDiscountProgramIsVoucher);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtARDiscountProgramCode);
            this.bosPanel1.Controls.Add(this.fld_lkeARDiscountProgramApplyOn);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.groupControl1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_txtARDiscountProgramItemValue);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lblLabel17);
            this.bosPanel1.Controls.Add(this.fld_medARDiscountProgramDesc);
            this.bosPanel1.Controls.Add(this.fld_txtARDiscountProgramName);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_lkeARDiscountProgramApplyType);
            this.bosPanel1.Controls.Add(this.fld_lkeARDiscountProgramType);
            this.bosPanel1.Controls.Add(this.fld_lblLabel102);
            this.bosPanel1.Controls.Add(this.fld_dteARDiscountProgramEndDate);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_dteARDiscountProgramBeginDate);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_xtabConfig);
            this.bosPanel1.Controls.Add(this.fld_lkeARDiscountProgramstatus);
            this.bosPanel1.Controls.Add(this.fld_pteARDiscountProgramEmployeePicture);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteARDiscountProgramDate);
            this.bosPanel1.Controls.Add(this.fld_txtARDiscountProgramNo);
            this.bosPanel1.Controls.Add(this.fld_lblLabel26);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1308, 821);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_chkARDiscountProgramIsVoucher
            // 
            this.fld_chkARDiscountProgramIsVoucher.BOSComment = null;
            this.fld_chkARDiscountProgramIsVoucher.BOSDataMember = "ARDiscountProgramIsVoucher";
            this.fld_chkARDiscountProgramIsVoucher.BOSDataSource = "ARDiscountPrograms";
            this.fld_chkARDiscountProgramIsVoucher.BOSDescription = null;
            this.fld_chkARDiscountProgramIsVoucher.BOSError = null;
            this.fld_chkARDiscountProgramIsVoucher.BOSFieldGroup = null;
            this.fld_chkARDiscountProgramIsVoucher.BOSFieldRelation = null;
            this.fld_chkARDiscountProgramIsVoucher.BOSPrivilege = null;
            this.fld_chkARDiscountProgramIsVoucher.BOSPropertyName = "EditValue";
            this.fld_chkARDiscountProgramIsVoucher.Location = new System.Drawing.Point(220, 116);
            this.fld_chkARDiscountProgramIsVoucher.MenuManager = this.screenToolbar;
            this.fld_chkARDiscountProgramIsVoucher.Name = "fld_chkARDiscountProgramIsVoucher";
            this.fld_chkARDiscountProgramIsVoucher.Properties.Caption = "";
            this.fld_chkARDiscountProgramIsVoucher.Screen = null;
            this.fld_chkARDiscountProgramIsVoucher.Size = new System.Drawing.Size(18, 20);
            this.fld_chkARDiscountProgramIsVoucher.TabIndex = 132;
            this.fld_chkARDiscountProgramIsVoucher.Tag = "DC";
            this.fld_chkARDiscountProgramIsVoucher.CheckedChanged += new System.EventHandler(this.Fld_chkARDiscountProgramIsVoucher_CheckedChanged);
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(125, 143);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(37, 13);
            this.bosLabel1.TabIndex = 136;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Ghi chú";
            // 
            // fld_txtARDiscountProgramCode
            // 
            this.fld_txtARDiscountProgramCode.BOSComment = "";
            this.fld_txtARDiscountProgramCode.BOSDataMember = "ARDiscountProgramCode";
            this.fld_txtARDiscountProgramCode.BOSDataSource = "ARDiscountPrograms";
            this.fld_txtARDiscountProgramCode.BOSDescription = null;
            this.fld_txtARDiscountProgramCode.BOSError = "";
            this.fld_txtARDiscountProgramCode.BOSFieldGroup = "";
            this.fld_txtARDiscountProgramCode.BOSFieldRelation = "";
            this.fld_txtARDiscountProgramCode.BOSPrivilege = "";
            this.fld_txtARDiscountProgramCode.BOSPropertyName = "Text";
            this.fld_txtARDiscountProgramCode.Location = new System.Drawing.Point(244, 115);
            this.fld_txtARDiscountProgramCode.Name = "fld_txtARDiscountProgramCode";
            this.fld_txtARDiscountProgramCode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDiscountProgramCode.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDiscountProgramCode.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDiscountProgramCode.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDiscountProgramCode.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDiscountProgramCode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDiscountProgramCode.Screen = null;
            this.fld_txtARDiscountProgramCode.Size = new System.Drawing.Size(129, 20);
            this.fld_txtARDiscountProgramCode.TabIndex = 5;
            this.fld_txtARDiscountProgramCode.Tag = "DC";
            // 
            // fld_lkeARDiscountProgramApplyOn
            // 
            this.fld_lkeARDiscountProgramApplyOn.BOSAllowAddNew = false;
            this.fld_lkeARDiscountProgramApplyOn.BOSAllowDummy = false;
            this.fld_lkeARDiscountProgramApplyOn.BOSComment = "";
            this.fld_lkeARDiscountProgramApplyOn.BOSDataMember = "ARDiscountProgramApplyOn";
            this.fld_lkeARDiscountProgramApplyOn.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeARDiscountProgramApplyOn.BOSDescription = null;
            this.fld_lkeARDiscountProgramApplyOn.BOSError = "";
            this.fld_lkeARDiscountProgramApplyOn.BOSFieldGroup = "";
            this.fld_lkeARDiscountProgramApplyOn.BOSFieldParent = "";
            this.fld_lkeARDiscountProgramApplyOn.BOSFieldRelation = "";
            this.fld_lkeARDiscountProgramApplyOn.BOSPrivilege = "";
            this.fld_lkeARDiscountProgramApplyOn.BOSPropertyName = "EditValue";
            this.fld_lkeARDiscountProgramApplyOn.BOSSelectType = "";
            this.fld_lkeARDiscountProgramApplyOn.BOSSelectTypeValue = "";
            this.fld_lkeARDiscountProgramApplyOn.CurrentDisplayText = "";
            this.fld_lkeARDiscountProgramApplyOn.Enabled = false;
            this.fld_lkeARDiscountProgramApplyOn.Location = new System.Drawing.Point(483, 89);
            this.fld_lkeARDiscountProgramApplyOn.Name = "fld_lkeARDiscountProgramApplyOn";
            this.fld_lkeARDiscountProgramApplyOn.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARDiscountProgramApplyOn.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDiscountProgramApplyOn.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDiscountProgramApplyOn.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDiscountProgramApplyOn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDiscountProgramApplyOn.Properties.ColumnName = null;
            this.fld_lkeARDiscountProgramApplyOn.Properties.NullText = "";
            this.fld_lkeARDiscountProgramApplyOn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDiscountProgramApplyOn.Screen = null;
            this.fld_lkeARDiscountProgramApplyOn.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARDiscountProgramApplyOn.TabIndex = 4;
            this.fld_lkeARDiscountProgramApplyOn.Tag = "DC";
            this.fld_lkeARDiscountProgramApplyOn.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeARDiscountProgramApplyOn_CloseUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(388, 92);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(57, 13);
            this.bosLabel2.TabIndex = 134;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Áp dụng CK";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.fld_lkeFK_ARCustomerDistributionChannelID);
            this.groupControl1.Controls.Add(this.fld_lkeARDiscountProgramMethodType);
            this.groupControl1.Controls.Add(this.fld_chkARDiscountProgramIsExhibit);
            this.groupControl1.Controls.Add(this.bosLabel10);
            this.groupControl1.Controls.Add(this.bosLabel43);
            this.groupControl1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.groupControl1.Controls.Add(this.fld_lblLabel5);
            this.groupControl1.Controls.Add(this.fld_lkeARDiscountProgramIsSales);
            this.groupControl1.Controls.Add(this.fld_txtARDiscountProgramSaleTarget);
            this.groupControl1.Location = new System.Drawing.Point(651, 11);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(284, 164);
            this.groupControl1.TabIndex = 133;
            this.groupControl1.Text = "Điều kiện áp dụng";
            this.groupControl1.Visible = false;
            // 
            // fld_lkeFK_ARCustomerDistributionChannelID
            // 
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSComment = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSDataMember = "FK_ARCustomerDistributionChannelID";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSError = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSFieldGroup = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSFieldParent = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSFieldRelation = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSPrivilege = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSSelectType = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.CurrentDisplayText = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.Location = new System.Drawing.Point(113, 52);
            this.fld_lkeFK_ARCustomerDistributionChannelID.Name = "fld_lkeFK_ARCustomerDistributionChannelID";
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerDistributionChannelName", "Kệnh phân phối")});
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.DisplayMember = "ARCustomerDistributionChannelName";
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.NullText = "";
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerDistributionChannelID.Properties.ValueMember = "ARCustomerDistributionChannelID";
            this.fld_lkeFK_ARCustomerDistributionChannelID.Screen = null;
            this.fld_lkeFK_ARCustomerDistributionChannelID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_ARCustomerDistributionChannelID.TabIndex = 1;
            this.fld_lkeFK_ARCustomerDistributionChannelID.Tag = "DC";
            this.fld_lkeFK_ARCustomerDistributionChannelID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ARCustomerDistributionChannelID_CloseUp);
            // 
            // fld_lkeARDiscountProgramMethodType
            // 
            this.fld_lkeARDiscountProgramMethodType.BOSAllowAddNew = false;
            this.fld_lkeARDiscountProgramMethodType.BOSAllowDummy = false;
            this.fld_lkeARDiscountProgramMethodType.BOSComment = "";
            this.fld_lkeARDiscountProgramMethodType.BOSDataMember = "ARDiscountProgramMethodType";
            this.fld_lkeARDiscountProgramMethodType.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeARDiscountProgramMethodType.BOSDescription = null;
            this.fld_lkeARDiscountProgramMethodType.BOSError = "";
            this.fld_lkeARDiscountProgramMethodType.BOSFieldGroup = "";
            this.fld_lkeARDiscountProgramMethodType.BOSFieldParent = "";
            this.fld_lkeARDiscountProgramMethodType.BOSFieldRelation = "";
            this.fld_lkeARDiscountProgramMethodType.BOSPrivilege = "";
            this.fld_lkeARDiscountProgramMethodType.BOSPropertyName = "EditValue";
            this.fld_lkeARDiscountProgramMethodType.BOSSelectType = "";
            this.fld_lkeARDiscountProgramMethodType.BOSSelectTypeValue = "";
            this.fld_lkeARDiscountProgramMethodType.CurrentDisplayText = "";
            this.fld_lkeARDiscountProgramMethodType.Location = new System.Drawing.Point(113, 26);
            this.fld_lkeARDiscountProgramMethodType.Name = "fld_lkeARDiscountProgramMethodType";
            this.fld_lkeARDiscountProgramMethodType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARDiscountProgramMethodType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDiscountProgramMethodType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDiscountProgramMethodType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDiscountProgramMethodType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDiscountProgramMethodType.Properties.ColumnName = null;
            this.fld_lkeARDiscountProgramMethodType.Properties.NullText = "";
            this.fld_lkeARDiscountProgramMethodType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDiscountProgramMethodType.Screen = null;
            this.fld_lkeARDiscountProgramMethodType.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARDiscountProgramMethodType.TabIndex = 0;
            this.fld_lkeARDiscountProgramMethodType.Tag = "DC";
            // 
            // fld_chkARDiscountProgramIsExhibit
            // 
            this.fld_chkARDiscountProgramIsExhibit.BOSComment = null;
            this.fld_chkARDiscountProgramIsExhibit.BOSDataMember = "ARDiscountProgramIsExhibit";
            this.fld_chkARDiscountProgramIsExhibit.BOSDataSource = "ARDiscountPrograms";
            this.fld_chkARDiscountProgramIsExhibit.BOSDescription = null;
            this.fld_chkARDiscountProgramIsExhibit.BOSError = null;
            this.fld_chkARDiscountProgramIsExhibit.BOSFieldGroup = null;
            this.fld_chkARDiscountProgramIsExhibit.BOSFieldRelation = null;
            this.fld_chkARDiscountProgramIsExhibit.BOSPrivilege = null;
            this.fld_chkARDiscountProgramIsExhibit.BOSPropertyName = "EditValue";
            this.fld_chkARDiscountProgramIsExhibit.Location = new System.Drawing.Point(14, 130);
            this.fld_chkARDiscountProgramIsExhibit.MenuManager = this.screenToolbar;
            this.fld_chkARDiscountProgramIsExhibit.Name = "fld_chkARDiscountProgramIsExhibit";
            this.fld_chkARDiscountProgramIsExhibit.Properties.Caption = "Hỗ trợ trưng bày";
            this.fld_chkARDiscountProgramIsExhibit.Screen = null;
            this.fld_chkARDiscountProgramIsExhibit.Size = new System.Drawing.Size(159, 20);
            this.fld_chkARDiscountProgramIsExhibit.TabIndex = 4;
            this.fld_chkARDiscountProgramIsExhibit.Tag = "DC";
            this.fld_chkARDiscountProgramIsExhibit.CheckedChanged += new System.EventHandler(this.Fld_chkARDiscountProgramIsExhibit_CheckedChanged);
            this.fld_chkARDiscountProgramIsExhibit.Click += new System.EventHandler(this.Fld_chkARDiscountProgramIsExhibit_Click);
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(14, 29);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(83, 13);
            this.bosLabel10.TabIndex = 131;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Phương thức tính";
            // 
            // bosLabel43
            // 
            this.bosLabel43.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel43.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel43.Appearance.Options.UseBackColor = true;
            this.bosLabel43.Appearance.Options.UseForeColor = true;
            this.bosLabel43.BOSComment = "";
            this.bosLabel43.BOSDataMember = "";
            this.bosLabel43.BOSDataSource = "";
            this.bosLabel43.BOSDescription = null;
            this.bosLabel43.BOSError = null;
            this.bosLabel43.BOSFieldGroup = "";
            this.bosLabel43.BOSFieldRelation = "";
            this.bosLabel43.BOSPrivilege = "";
            this.bosLabel43.BOSPropertyName = null;
            this.bosLabel43.Location = new System.Drawing.Point(14, 55);
            this.bosLabel43.Name = "bosLabel43";
            this.bosLabel43.Screen = null;
            this.bosLabel43.Size = new System.Drawing.Size(74, 13);
            this.bosLabel43.TabIndex = 113;
            this.bosLabel43.Tag = "";
            this.bosLabel43.Text = "Kênh phân phối";
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeFK_ACObjectID.BOSDescription = null;
            this.fld_lkeFK_ACObjectID.BOSError = null;
            this.fld_lkeFK_ACObjectID.BOSFieldGroup = "";
            this.fld_lkeFK_ACObjectID.BOSFieldParent = "";
            this.fld_lkeFK_ACObjectID.BOSFieldRelation = "";
            this.fld_lkeFK_ACObjectID.BOSModuleType = null;
            this.fld_lkeFK_ACObjectID.BOSPrivilege = "";
            this.fld_lkeFK_ACObjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACObjectID.BOSSelectType = "";
            this.fld_lkeFK_ACObjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_ACObjectID.CurrentDisplayText = null;
            this.fld_lkeFK_ACObjectID.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(113, 78);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 2;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACObjectID_CloseUp);
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = "";
            this.fld_lblLabel5.BOSDataMember = "";
            this.fld_lblLabel5.BOSDataSource = "";
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = "";
            this.fld_lblLabel5.BOSFieldRelation = "";
            this.fld_lblLabel5.BOSPrivilege = "";
            this.fld_lblLabel5.BOSPropertyName = "";
            this.fld_lblLabel5.Location = new System.Drawing.Point(14, 81);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel5.TabIndex = 106;
            this.fld_lblLabel5.Tag = "";
            this.fld_lblLabel5.Text = "Đối tượng";
            // 
            // fld_lkeARDiscountProgramIsSales
            // 
            this.fld_lkeARDiscountProgramIsSales.BOSComment = null;
            this.fld_lkeARDiscountProgramIsSales.BOSDataMember = "ARDiscountProgramIsSales";
            this.fld_lkeARDiscountProgramIsSales.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeARDiscountProgramIsSales.BOSDescription = null;
            this.fld_lkeARDiscountProgramIsSales.BOSError = null;
            this.fld_lkeARDiscountProgramIsSales.BOSFieldGroup = null;
            this.fld_lkeARDiscountProgramIsSales.BOSFieldRelation = null;
            this.fld_lkeARDiscountProgramIsSales.BOSPrivilege = null;
            this.fld_lkeARDiscountProgramIsSales.BOSPropertyName = "EditValue";
            this.fld_lkeARDiscountProgramIsSales.Location = new System.Drawing.Point(14, 105);
            this.fld_lkeARDiscountProgramIsSales.MenuManager = this.screenToolbar;
            this.fld_lkeARDiscountProgramIsSales.Name = "fld_lkeARDiscountProgramIsSales";
            this.fld_lkeARDiscountProgramIsSales.Properties.Caption = "Đạt doanh số";
            this.fld_lkeARDiscountProgramIsSales.Screen = null;
            this.fld_lkeARDiscountProgramIsSales.Size = new System.Drawing.Size(93, 20);
            this.fld_lkeARDiscountProgramIsSales.TabIndex = 3;
            this.fld_lkeARDiscountProgramIsSales.Tag = "DC";
            this.fld_lkeARDiscountProgramIsSales.CheckedChanged += new System.EventHandler(this.Fld_lkeARDiscountProgramIsExhibit_CheckedChanged);
            // 
            // fld_txtARDiscountProgramSaleTarget
            // 
            this.fld_txtARDiscountProgramSaleTarget.BOSComment = null;
            this.fld_txtARDiscountProgramSaleTarget.BOSDataMember = "ARDiscountProgramSaleTarget";
            this.fld_txtARDiscountProgramSaleTarget.BOSDataSource = "ARDiscountPrograms";
            this.fld_txtARDiscountProgramSaleTarget.BOSDescription = null;
            this.fld_txtARDiscountProgramSaleTarget.BOSError = null;
            this.fld_txtARDiscountProgramSaleTarget.BOSFieldGroup = null;
            this.fld_txtARDiscountProgramSaleTarget.BOSFieldRelation = null;
            this.fld_txtARDiscountProgramSaleTarget.BOSPrivilege = null;
            this.fld_txtARDiscountProgramSaleTarget.BOSPropertyName = "EditValue";
            this.fld_txtARDiscountProgramSaleTarget.EditValue = "0.00";
            this.fld_txtARDiscountProgramSaleTarget.Location = new System.Drawing.Point(113, 104);
            this.fld_txtARDiscountProgramSaleTarget.Name = "fld_txtARDiscountProgramSaleTarget";
            this.fld_txtARDiscountProgramSaleTarget.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDiscountProgramSaleTarget.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDiscountProgramSaleTarget.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDiscountProgramSaleTarget.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDiscountProgramSaleTarget.Properties.Mask.EditMask = "n";
            this.fld_txtARDiscountProgramSaleTarget.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARDiscountProgramSaleTarget.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDiscountProgramSaleTarget.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDiscountProgramSaleTarget.Screen = null;
            this.fld_txtARDiscountProgramSaleTarget.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARDiscountProgramSaleTarget.TabIndex = 3;
            this.fld_txtARDiscountProgramSaleTarget.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(125, 92);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(88, 13);
            this.bosLabel4.TabIndex = 129;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Hình thức áp dụng";
            // 
            // fld_txtARDiscountProgramItemValue
            // 
            this.fld_txtARDiscountProgramItemValue.BOSComment = null;
            this.fld_txtARDiscountProgramItemValue.BOSDataMember = "ARDiscountProgramValue";
            this.fld_txtARDiscountProgramItemValue.BOSDataSource = "ARDiscountPrograms";
            this.fld_txtARDiscountProgramItemValue.BOSDescription = null;
            this.fld_txtARDiscountProgramItemValue.BOSError = null;
            this.fld_txtARDiscountProgramItemValue.BOSFieldGroup = null;
            this.fld_txtARDiscountProgramItemValue.BOSFieldRelation = null;
            this.fld_txtARDiscountProgramItemValue.BOSPrivilege = null;
            this.fld_txtARDiscountProgramItemValue.BOSPropertyName = "EditValue";
            this.fld_txtARDiscountProgramItemValue.EditValue = "0.00";
            this.fld_txtARDiscountProgramItemValue.Location = new System.Drawing.Point(483, 115);
            this.fld_txtARDiscountProgramItemValue.Name = "fld_txtARDiscountProgramItemValue";
            this.fld_txtARDiscountProgramItemValue.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDiscountProgramItemValue.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDiscountProgramItemValue.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDiscountProgramItemValue.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDiscountProgramItemValue.Properties.Mask.EditMask = "n";
            this.fld_txtARDiscountProgramItemValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtARDiscountProgramItemValue.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDiscountProgramItemValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDiscountProgramItemValue.Screen = null;
            this.fld_txtARDiscountProgramItemValue.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARDiscountProgramItemValue.TabIndex = 10;
            this.fld_txtARDiscountProgramItemValue.Tag = "DC";
            this.fld_txtARDiscountProgramItemValue.Validated += new System.EventHandler(this.Fld_txtARDiscountProgramItemValue_Validated);
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseFont = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment = "";
            this.bosLabel9.BOSDataMember = "";
            this.bosLabel9.BOSDataSource = "";
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = "";
            this.bosLabel9.BOSFieldRelation = "";
            this.bosLabel9.BOSPrivilege = "";
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(388, 118);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(41, 13);
            this.bosLabel9.TabIndex = 124;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "% CTKM";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseFont = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = "";
            this.fld_lblLabel17.BOSDataMember = "";
            this.fld_lblLabel17.BOSDataSource = "";
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = "";
            this.fld_lblLabel17.BOSFieldRelation = "";
            this.fld_lblLabel17.BOSPrivilege = "";
            this.fld_lblLabel17.BOSPropertyName = null;
            this.fld_lblLabel17.Location = new System.Drawing.Point(125, 119);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(57, 13);
            this.fld_lblLabel17.TabIndex = 122;
            this.fld_lblLabel17.Tag = "";
            this.fld_lblLabel17.Text = "Mã giảm giá";
            // 
            // fld_medARDiscountProgramDesc
            // 
            this.fld_medARDiscountProgramDesc.BOSComment = "";
            this.fld_medARDiscountProgramDesc.BOSDataMember = "ARDiscountProgramDesc";
            this.fld_medARDiscountProgramDesc.BOSDataSource = "ARDiscountPrograms";
            this.fld_medARDiscountProgramDesc.BOSDescription = null;
            this.fld_medARDiscountProgramDesc.BOSError = "";
            this.fld_medARDiscountProgramDesc.BOSFieldGroup = "";
            this.fld_medARDiscountProgramDesc.BOSFieldRelation = "";
            this.fld_medARDiscountProgramDesc.BOSPrivilege = "";
            this.fld_medARDiscountProgramDesc.BOSPropertyName = "Text";
            this.fld_medARDiscountProgramDesc.Location = new System.Drawing.Point(220, 141);
            this.fld_medARDiscountProgramDesc.Name = "fld_medARDiscountProgramDesc";
            this.fld_medARDiscountProgramDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medARDiscountProgramDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medARDiscountProgramDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medARDiscountProgramDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medARDiscountProgramDesc.Screen = null;
            this.fld_medARDiscountProgramDesc.Size = new System.Drawing.Size(416, 34);
            this.fld_medARDiscountProgramDesc.TabIndex = 11;
            this.fld_medARDiscountProgramDesc.Tag = "DC";
            // 
            // fld_txtARDiscountProgramName
            // 
            this.fld_txtARDiscountProgramName.BOSComment = "";
            this.fld_txtARDiscountProgramName.BOSDataMember = "ARDiscountProgramName";
            this.fld_txtARDiscountProgramName.BOSDataSource = "ARDiscountPrograms";
            this.fld_txtARDiscountProgramName.BOSDescription = null;
            this.fld_txtARDiscountProgramName.BOSError = "";
            this.fld_txtARDiscountProgramName.BOSFieldGroup = "";
            this.fld_txtARDiscountProgramName.BOSFieldRelation = "";
            this.fld_txtARDiscountProgramName.BOSPrivilege = "";
            this.fld_txtARDiscountProgramName.BOSPropertyName = "Text";
            this.fld_txtARDiscountProgramName.Location = new System.Drawing.Point(220, 37);
            this.fld_txtARDiscountProgramName.Name = "fld_txtARDiscountProgramName";
            this.fld_txtARDiscountProgramName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARDiscountProgramName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARDiscountProgramName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARDiscountProgramName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARDiscountProgramName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtARDiscountProgramName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtARDiscountProgramName.Screen = null;
            this.fld_txtARDiscountProgramName.Size = new System.Drawing.Size(153, 20);
            this.fld_txtARDiscountProgramName.TabIndex = 1;
            this.fld_txtARDiscountProgramName.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(125, 40);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(82, 13);
            this.bosLabel3.TabIndex = 120;
            this.bosLabel3.Text = "Tên chương trình";
            // 
            // fld_lkeARDiscountProgramApplyType
            // 
            this.fld_lkeARDiscountProgramApplyType.BOSAllowAddNew = false;
            this.fld_lkeARDiscountProgramApplyType.BOSAllowDummy = false;
            this.fld_lkeARDiscountProgramApplyType.BOSComment = "";
            this.fld_lkeARDiscountProgramApplyType.BOSDataMember = "ARDiscountProgramApplyType";
            this.fld_lkeARDiscountProgramApplyType.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeARDiscountProgramApplyType.BOSDescription = null;
            this.fld_lkeARDiscountProgramApplyType.BOSError = "";
            this.fld_lkeARDiscountProgramApplyType.BOSFieldGroup = "";
            this.fld_lkeARDiscountProgramApplyType.BOSFieldParent = "";
            this.fld_lkeARDiscountProgramApplyType.BOSFieldRelation = "";
            this.fld_lkeARDiscountProgramApplyType.BOSPrivilege = "";
            this.fld_lkeARDiscountProgramApplyType.BOSPropertyName = "EditValue";
            this.fld_lkeARDiscountProgramApplyType.BOSSelectType = "";
            this.fld_lkeARDiscountProgramApplyType.BOSSelectTypeValue = "";
            this.fld_lkeARDiscountProgramApplyType.CurrentDisplayText = "";
            this.fld_lkeARDiscountProgramApplyType.Location = new System.Drawing.Point(220, 89);
            this.fld_lkeARDiscountProgramApplyType.Name = "fld_lkeARDiscountProgramApplyType";
            this.fld_lkeARDiscountProgramApplyType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARDiscountProgramApplyType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDiscountProgramApplyType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDiscountProgramApplyType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDiscountProgramApplyType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDiscountProgramApplyType.Properties.ColumnName = null;
            this.fld_lkeARDiscountProgramApplyType.Properties.NullText = "";
            this.fld_lkeARDiscountProgramApplyType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDiscountProgramApplyType.Screen = null;
            this.fld_lkeARDiscountProgramApplyType.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARDiscountProgramApplyType.TabIndex = 9;
            this.fld_lkeARDiscountProgramApplyType.Tag = "DC";
            this.fld_lkeARDiscountProgramApplyType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeARDiscountProgramApplyType_CloseUp);
            // 
            // fld_lkeARDiscountProgramType
            // 
            this.fld_lkeARDiscountProgramType.BOSAllowAddNew = false;
            this.fld_lkeARDiscountProgramType.BOSAllowDummy = false;
            this.fld_lkeARDiscountProgramType.BOSComment = "";
            this.fld_lkeARDiscountProgramType.BOSDataMember = "ARDiscountProgramType";
            this.fld_lkeARDiscountProgramType.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeARDiscountProgramType.BOSDescription = null;
            this.fld_lkeARDiscountProgramType.BOSError = "";
            this.fld_lkeARDiscountProgramType.BOSFieldGroup = "";
            this.fld_lkeARDiscountProgramType.BOSFieldParent = "";
            this.fld_lkeARDiscountProgramType.BOSFieldRelation = "";
            this.fld_lkeARDiscountProgramType.BOSPrivilege = "";
            this.fld_lkeARDiscountProgramType.BOSPropertyName = "EditValue";
            this.fld_lkeARDiscountProgramType.BOSSelectType = "";
            this.fld_lkeARDiscountProgramType.BOSSelectTypeValue = "";
            this.fld_lkeARDiscountProgramType.CurrentDisplayText = "";
            this.fld_lkeARDiscountProgramType.Location = new System.Drawing.Point(1046, 15);
            this.fld_lkeARDiscountProgramType.Name = "fld_lkeARDiscountProgramType";
            this.fld_lkeARDiscountProgramType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARDiscountProgramType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARDiscountProgramType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDiscountProgramType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARDiscountProgramType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDiscountProgramType.Properties.ColumnName = null;
            this.fld_lkeARDiscountProgramType.Properties.NullText = "";
            this.fld_lkeARDiscountProgramType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDiscountProgramType.Screen = null;
            this.fld_lkeARDiscountProgramType.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARDiscountProgramType.TabIndex = 3;
            this.fld_lkeARDiscountProgramType.Tag = "DC";
            this.fld_lkeARDiscountProgramType.Visible = false;
            this.fld_lkeARDiscountProgramType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeARDiscountProgramType_CloseUp);
            // 
            // fld_lblLabel102
            // 
            this.fld_lblLabel102.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel102.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel102.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel102.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel102.Appearance.Options.UseFont = true;
            this.fld_lblLabel102.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel102.BOSComment = "";
            this.fld_lblLabel102.BOSDataMember = "";
            this.fld_lblLabel102.BOSDataSource = "";
            this.fld_lblLabel102.BOSDescription = null;
            this.fld_lblLabel102.BOSError = null;
            this.fld_lblLabel102.BOSFieldGroup = "";
            this.fld_lblLabel102.BOSFieldRelation = "";
            this.fld_lblLabel102.BOSPrivilege = "";
            this.fld_lblLabel102.BOSPropertyName = null;
            this.fld_lblLabel102.Location = new System.Drawing.Point(951, 18);
            this.fld_lblLabel102.Name = "fld_lblLabel102";
            this.fld_lblLabel102.Screen = null;
            this.fld_lblLabel102.Size = new System.Drawing.Size(82, 13);
            this.fld_lblLabel102.TabIndex = 115;
            this.fld_lblLabel102.Tag = "";
            this.fld_lblLabel102.Text = "Loại chương trình";
            this.fld_lblLabel102.Visible = false;
            // 
            // fld_dteARDiscountProgramEndDate
            // 
            this.fld_dteARDiscountProgramEndDate.BOSComment = null;
            this.fld_dteARDiscountProgramEndDate.BOSDataMember = "ARDiscountProgramEndDate";
            this.fld_dteARDiscountProgramEndDate.BOSDataSource = "ARDiscountPrograms";
            this.fld_dteARDiscountProgramEndDate.BOSDescription = null;
            this.fld_dteARDiscountProgramEndDate.BOSError = null;
            this.fld_dteARDiscountProgramEndDate.BOSFieldGroup = null;
            this.fld_dteARDiscountProgramEndDate.BOSFieldRelation = null;
            this.fld_dteARDiscountProgramEndDate.BOSPrivilege = null;
            this.fld_dteARDiscountProgramEndDate.BOSPropertyName = "EditValue";
            this.fld_dteARDiscountProgramEndDate.EditValue = null;
            this.fld_dteARDiscountProgramEndDate.Location = new System.Drawing.Point(483, 63);
            this.fld_dteARDiscountProgramEndDate.Name = "fld_dteARDiscountProgramEndDate";
            this.fld_dteARDiscountProgramEndDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDiscountProgramEndDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDiscountProgramEndDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDiscountProgramEndDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDiscountProgramEndDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDiscountProgramEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDiscountProgramEndDate.Screen = null;
            this.fld_dteARDiscountProgramEndDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARDiscountProgramEndDate.TabIndex = 8;
            this.fld_dteARDiscountProgramEndDate.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(388, 66);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(67, 13);
            this.bosLabel8.TabIndex = 111;
            this.bosLabel8.Text = "Ngày kết thúc";
            // 
            // fld_dteARDiscountProgramBeginDate
            // 
            this.fld_dteARDiscountProgramBeginDate.BOSComment = null;
            this.fld_dteARDiscountProgramBeginDate.BOSDataMember = "ARDiscountProgramBeginDate";
            this.fld_dteARDiscountProgramBeginDate.BOSDataSource = "ARDiscountPrograms";
            this.fld_dteARDiscountProgramBeginDate.BOSDescription = null;
            this.fld_dteARDiscountProgramBeginDate.BOSError = null;
            this.fld_dteARDiscountProgramBeginDate.BOSFieldGroup = null;
            this.fld_dteARDiscountProgramBeginDate.BOSFieldRelation = null;
            this.fld_dteARDiscountProgramBeginDate.BOSPrivilege = null;
            this.fld_dteARDiscountProgramBeginDate.BOSPropertyName = "EditValue";
            this.fld_dteARDiscountProgramBeginDate.EditValue = null;
            this.fld_dteARDiscountProgramBeginDate.Location = new System.Drawing.Point(220, 63);
            this.fld_dteARDiscountProgramBeginDate.Name = "fld_dteARDiscountProgramBeginDate";
            this.fld_dteARDiscountProgramBeginDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDiscountProgramBeginDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDiscountProgramBeginDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDiscountProgramBeginDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDiscountProgramBeginDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDiscountProgramBeginDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDiscountProgramBeginDate.Screen = null;
            this.fld_dteARDiscountProgramBeginDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARDiscountProgramBeginDate.TabIndex = 2;
            this.fld_dteARDiscountProgramBeginDate.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(125, 66);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(67, 13);
            this.bosLabel6.TabIndex = 109;
            this.bosLabel6.Text = "Ngày áp dụng";
            // 
            // fld_xtabConfig
            // 
            this.fld_xtabConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_xtabConfig.Location = new System.Drawing.Point(6, 181);
            this.fld_xtabConfig.Name = "fld_xtabConfig";
            this.fld_xtabConfig.SelectedTabPage = this.fld_tabProductDiscount;
            this.fld_xtabConfig.Size = new System.Drawing.Size(1294, 637);
            this.fld_xtabConfig.TabIndex = 107;
            this.fld_xtabConfig.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabProductDiscount,
            this.fld_tabTargetConfig});
            // 
            // fld_tabProductDiscount
            // 
            this.fld_tabProductDiscount.Controls.Add(this.bosButton1);
            this.fld_tabProductDiscount.Controls.Add(this.fld_btnChooseProduct);
            this.fld_tabProductDiscount.Controls.Add(this.fld_dgcARDiscountProgramItems);
            this.fld_tabProductDiscount.Controls.Add(this.fld_pteARDiscountProgramItemProductPicture);
            this.fld_tabProductDiscount.Name = "fld_tabProductDiscount";
            this.fld_tabProductDiscount.Size = new System.Drawing.Size(1292, 612);
            this.fld_tabProductDiscount.Text = "Danh sách sản phẩm";
            // 
            // bosButton1
            // 
            this.bosButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosButton1.Appearance.Options.UseForeColor = true;
            this.bosButton1.BOSComment = "";
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = "";
            this.bosButton1.BOSFieldRelation = "";
            this.bosButton1.BOSPrivilege = "";
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(114, 9);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.bosButton1.Size = new System.Drawing.Size(103, 27);
            this.bosButton1.TabIndex = 1;
            this.bosButton1.Tag = "";
            this.bosButton1.Text = "Load từ Excel";
            this.bosButton1.Visible = false;
            // 
            // fld_btnChooseProduct
            // 
            this.fld_btnChooseProduct.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnChooseProduct.Appearance.Options.UseForeColor = true;
            this.fld_btnChooseProduct.BOSComment = "";
            this.fld_btnChooseProduct.BOSDataMember = null;
            this.fld_btnChooseProduct.BOSDataSource = null;
            this.fld_btnChooseProduct.BOSDescription = null;
            this.fld_btnChooseProduct.BOSError = null;
            this.fld_btnChooseProduct.BOSFieldGroup = "";
            this.fld_btnChooseProduct.BOSFieldRelation = "";
            this.fld_btnChooseProduct.BOSPrivilege = "";
            this.fld_btnChooseProduct.BOSPropertyName = null;
            this.fld_btnChooseProduct.Location = new System.Drawing.Point(5, 9);
            this.fld_btnChooseProduct.Name = "fld_btnChooseProduct";
            this.fld_btnChooseProduct.Screen = null;
            this.fld_btnChooseProduct.Size = new System.Drawing.Size(103, 27);
            this.fld_btnChooseProduct.TabIndex = 0;
            this.fld_btnChooseProduct.Tag = "";
            this.fld_btnChooseProduct.Text = "Chọn sản phẩm";
            this.fld_btnChooseProduct.Click += new System.EventHandler(this.Fld_btnChooseProduct_Click);
            // 
            // fld_pteARDiscountProgramItemProductPicture
            // 
            this.fld_pteARDiscountProgramItemProductPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pteARDiscountProgramItemProductPicture.BOSComment = null;
            this.fld_pteARDiscountProgramItemProductPicture.BOSDataMember = "ARDiscountProgramItemProductPicture";
            this.fld_pteARDiscountProgramItemProductPicture.BOSDataSource = "ARDiscountProgramItems";
            this.fld_pteARDiscountProgramItemProductPicture.BOSDescription = null;
            this.fld_pteARDiscountProgramItemProductPicture.BOSError = null;
            this.fld_pteARDiscountProgramItemProductPicture.BOSFieldGroup = null;
            this.fld_pteARDiscountProgramItemProductPicture.BOSFieldRelation = null;
            this.fld_pteARDiscountProgramItemProductPicture.BOSPrivilege = null;
            this.fld_pteARDiscountProgramItemProductPicture.BOSPropertyName = "EditValue";
            this.fld_pteARDiscountProgramItemProductPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_pteARDiscountProgramItemProductPicture.FileName = null;
            this.fld_pteARDiscountProgramItemProductPicture.FilePath = null;
            this.fld_pteARDiscountProgramItemProductPicture.Location = new System.Drawing.Point(1168, 42);
            this.fld_pteARDiscountProgramItemProductPicture.MenuManager = this.screenToolbar;
            this.fld_pteARDiscountProgramItemProductPicture.Name = "fld_pteARDiscountProgramItemProductPicture";
            this.fld_pteARDiscountProgramItemProductPicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteARDiscountProgramItemProductPicture.Screen = null;
            this.fld_pteARDiscountProgramItemProductPicture.Size = new System.Drawing.Size(120, 120);
            this.fld_pteARDiscountProgramItemProductPicture.TabIndex = 60;
            this.fld_pteARDiscountProgramItemProductPicture.Tag = "DC";
            // 
            // fld_tabTargetConfig
            // 
            this.fld_tabTargetConfig.Controls.Add(this.fld_dgcARDiscountProgramItemTargets);
            this.fld_tabTargetConfig.Name = "fld_tabTargetConfig";
            this.fld_tabTargetConfig.PageVisible = false;
            this.fld_tabTargetConfig.Size = new System.Drawing.Size(1278, 605);
            this.fld_tabTargetConfig.Text = "Cấu hình thưởng doanh số";
            // 
            // fld_dgcARDiscountProgramItemTargets
            // 
            this.fld_dgcARDiscountProgramItemTargets.AllowDrop = true;
            this.fld_dgcARDiscountProgramItemTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARDiscountProgramItemTargets.BOSComment = null;
            this.fld_dgcARDiscountProgramItemTargets.BOSDataMember = null;
            this.fld_dgcARDiscountProgramItemTargets.BOSDataSource = "ARDiscountProgramItemTargets";
            this.fld_dgcARDiscountProgramItemTargets.BOSDescription = null;
            this.fld_dgcARDiscountProgramItemTargets.BOSError = null;
            this.fld_dgcARDiscountProgramItemTargets.BOSFieldGroup = null;
            this.fld_dgcARDiscountProgramItemTargets.BOSFieldRelation = null;
            this.fld_dgcARDiscountProgramItemTargets.BOSGridType = null;
            this.fld_dgcARDiscountProgramItemTargets.BOSPrivilege = null;
            this.fld_dgcARDiscountProgramItemTargets.BOSPropertyName = null;
            this.fld_dgcARDiscountProgramItemTargets.CommodityType = "";
            this.fld_dgcARDiscountProgramItemTargets.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARDiscountProgramItemTargets.Location = new System.Drawing.Point(3, 6);
            this.fld_dgcARDiscountProgramItemTargets.MainView = this.gridView1;
            this.fld_dgcARDiscountProgramItemTargets.Name = "fld_dgcARDiscountProgramItemTargets";
            this.fld_dgcARDiscountProgramItemTargets.PrintReport = false;
            this.fld_dgcARDiscountProgramItemTargets.Screen = null;
            this.fld_dgcARDiscountProgramItemTargets.Size = new System.Drawing.Size(1270, 595);
            this.fld_dgcARDiscountProgramItemTargets.TabIndex = 13;
            this.fld_dgcARDiscountProgramItemTargets.Tag = "DC";
            this.fld_dgcARDiscountProgramItemTargets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcARDiscountProgramItemTargets;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_lkeARDiscountProgramstatus
            // 
            this.fld_lkeARDiscountProgramstatus.BOSAllowAddNew = false;
            this.fld_lkeARDiscountProgramstatus.BOSAllowDummy = false;
            this.fld_lkeARDiscountProgramstatus.BOSComment = null;
            this.fld_lkeARDiscountProgramstatus.BOSDataMember = "ARDiscountProgramStatus";
            this.fld_lkeARDiscountProgramstatus.BOSDataSource = "ARDiscountPrograms";
            this.fld_lkeARDiscountProgramstatus.BOSDescription = null;
            this.fld_lkeARDiscountProgramstatus.BOSError = null;
            this.fld_lkeARDiscountProgramstatus.BOSFieldGroup = null;
            this.fld_lkeARDiscountProgramstatus.BOSFieldParent = null;
            this.fld_lkeARDiscountProgramstatus.BOSFieldRelation = null;
            this.fld_lkeARDiscountProgramstatus.BOSPrivilege = null;
            this.fld_lkeARDiscountProgramstatus.BOSPropertyName = "EditValue";
            this.fld_lkeARDiscountProgramstatus.BOSSelectType = null;
            this.fld_lkeARDiscountProgramstatus.BOSSelectTypeValue = null;
            this.fld_lkeARDiscountProgramstatus.CurrentDisplayText = null;
            this.fld_lkeARDiscountProgramstatus.Location = new System.Drawing.Point(483, 37);
            this.fld_lkeARDiscountProgramstatus.Name = "fld_lkeARDiscountProgramstatus";
            this.fld_lkeARDiscountProgramstatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeARDiscountProgramstatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARDiscountProgramstatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARDiscountProgramstatus.Properties.ColumnName = null;
            this.fld_lkeARDiscountProgramstatus.Properties.NullText = "";
            this.fld_lkeARDiscountProgramstatus.Properties.ReadOnly = true;
            this.fld_lkeARDiscountProgramstatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARDiscountProgramstatus.Screen = null;
            this.fld_lkeARDiscountProgramstatus.Size = new System.Drawing.Size(153, 20);
            this.fld_lkeARDiscountProgramstatus.TabIndex = 7;
            this.fld_lkeARDiscountProgramstatus.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(388, 40);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(49, 13);
            this.bosLabel5.TabIndex = 7;
            this.bosLabel5.Text = "Tình trạng";
            // 
            // fld_dteARDiscountProgramDate
            // 
            this.fld_dteARDiscountProgramDate.BOSComment = null;
            this.fld_dteARDiscountProgramDate.BOSDataMember = "ARDiscountProgramDate";
            this.fld_dteARDiscountProgramDate.BOSDataSource = "ARDiscountPrograms";
            this.fld_dteARDiscountProgramDate.BOSDescription = null;
            this.fld_dteARDiscountProgramDate.BOSError = null;
            this.fld_dteARDiscountProgramDate.BOSFieldGroup = null;
            this.fld_dteARDiscountProgramDate.BOSFieldRelation = null;
            this.fld_dteARDiscountProgramDate.BOSPrivilege = null;
            this.fld_dteARDiscountProgramDate.BOSPropertyName = "EditValue";
            this.fld_dteARDiscountProgramDate.EditValue = null;
            this.fld_dteARDiscountProgramDate.Location = new System.Drawing.Point(483, 11);
            this.fld_dteARDiscountProgramDate.Name = "fld_dteARDiscountProgramDate";
            this.fld_dteARDiscountProgramDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARDiscountProgramDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARDiscountProgramDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARDiscountProgramDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARDiscountProgramDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARDiscountProgramDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARDiscountProgramDate.Screen = null;
            this.fld_dteARDiscountProgramDate.Size = new System.Drawing.Size(153, 20);
            this.fld_dteARDiscountProgramDate.TabIndex = 6;
            this.fld_dteARDiscountProgramDate.Tag = "DC";
            // 
            // fld_lblLabel26
            // 
            this.fld_lblLabel26.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel26.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel26.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel26.BOSComment = null;
            this.fld_lblLabel26.BOSDataMember = null;
            this.fld_lblLabel26.BOSDataSource = null;
            this.fld_lblLabel26.BOSDescription = null;
            this.fld_lblLabel26.BOSError = null;
            this.fld_lblLabel26.BOSFieldGroup = null;
            this.fld_lblLabel26.BOSFieldRelation = null;
            this.fld_lblLabel26.BOSPrivilege = null;
            this.fld_lblLabel26.BOSPropertyName = null;
            this.fld_lblLabel26.Location = new System.Drawing.Point(388, 14);
            this.fld_lblLabel26.Name = "fld_lblLabel26";
            this.fld_lblLabel26.Screen = null;
            this.fld_lblLabel26.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel26.TabIndex = 85;
            this.fld_lblLabel26.Text = "Ngày chứng từ";
            // 
            // DMDP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1308, 821);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMDP100.IconOptions.Icon")));
            this.Name = "DMDP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARDiscountProgramEmployeePicture.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDiscountProgramItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARDiscountProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARDiscountProgramIsVoucher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramApplyOn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerDistributionChannelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramMethodType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkARDiscountProgramIsExhibit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramIsSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramSaleTarget.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramItemValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medARDiscountProgramDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARDiscountProgramName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramApplyType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramEndDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramEndDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramBeginDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramBeginDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_xtabConfig)).EndInit();
            this.fld_xtabConfig.ResumeLayout(false);
            this.fld_tabProductDiscount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteARDiscountProgramItemProductPicture.Properties)).EndInit();
            this.fld_tabTargetConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARDiscountProgramItemTargets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARDiscountProgramstatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARDiscountProgramDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private BOSComponent.BOSTextBox fld_txtARDiscountProgramNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSPictureEdit fld_pteARDiscountProgramEmployeePicture;
        private IContainer components;
        private ARDiscountProgramItemsGridControl fld_dgcARDiscountProgramItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARDiscountProgram;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeARDiscountProgramstatus;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private DevExpress.XtraTab.XtraTabControl fld_xtabConfig;
        private DevExpress.XtraTab.XtraTabPage fld_tabProductDiscount;
        private BOSComponent.BOSDateEdit fld_dteARDiscountProgramBeginDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSDateEdit fld_dteARDiscountProgramEndDate;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel43;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerDistributionChannelID;
        private BOSComponent.BOSLookupEdit fld_lkeARDiscountProgramType;
        private BOSComponent.BOSLabel fld_lblLabel102;
        private BOSComponent.BOSLookupEdit fld_lkeARDiscountProgramApplyType;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtARDiscountProgramName;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSComponent.BOSMemoEdit fld_medARDiscountProgramDesc;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtARDiscountProgramItemValue;
        private BOSComponent.BOSCheckEdit fld_chkARDiscountProgramIsExhibit;
        private BOSComponent.BOSCheckEdit fld_lkeARDiscountProgramIsSales;
        private BOSComponent.BOSTextBox fld_txtARDiscountProgramSaleTarget;
        private BOSComponent.BOSButton fld_btnChooseProduct;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeARDiscountProgramMethodType;
        private BOSComponent.BOSLabel bosLabel10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private BOSComponent.BOSPictureEdit fld_pteARDiscountProgramItemProductPicture;
        private BOSComponent.BOSDateEdit fld_dteARDiscountProgramDate;
        private BOSComponent.BOSLabel fld_lblLabel26;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeARDiscountProgramApplyOn;
        private DevExpress.XtraTab.XtraTabPage fld_tabTargetConfig;
        private ARDiscountProgramItemTargetsGridControl fld_dgcARDiscountProgramItemTargets;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtARDiscountProgramCode;
        private BOSComponent.BOSCheckEdit fld_chkARDiscountProgramIsVoucher;
    }
}
