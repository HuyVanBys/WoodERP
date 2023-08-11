using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRPayRoll.UI
{
	/// <summary>
	/// Summary description for DMHRPR100
	/// </summary>
	partial class DMHRPR100
    {
        private BOSComponent.BOSLabel fld_lblLabel9;
		private BOSComponent.BOSDateEdit fld_dteHRPayRollDate1;
		private BOSComponent.BOSTextBox fld_txtHRPayRollNo1;
		private BOSComponent.BOSTextBox fld_txtHRPayRollName1;
        private BOSComponent.BOSMemoEdit fld_medHRPayRollDesc;
		private BOSComponent.BOSLookupEdit fld_lkeHRPayRollType1;
		private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private HREmployeePayRollsGridControl fld_dgcHREmployeePayRolls;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREmployeePayRolls;
        private BOSComponent.BOSButton fld_btnAddEmployee;


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
            this.fld_lblLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHRPayRollDate1 = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtHRPayRollNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRPayRollName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHRPayRollDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeHRPayRollType1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeePayRolls = new BOSERP.Modules.HRPayRoll.HREmployeePayRollsGridControl();
            this.fld_dgvHREmployeePayRolls = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddEmployee = new BOSComponent.BOSButton(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeHRPayRollStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_pteHRTimeSheetEmployeePicture = new BOSComponent.BOSPictureEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnExportExcel = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollDate1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollDate1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRPayRollDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollType1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePayRolls)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel9
            // 
            this.fld_lblLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel9.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel9.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel9.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel9.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel9.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel9.BOSDescription = null;
            this.fld_lblLabel9.BOSError = null;
            this.fld_lblLabel9.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel9.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel9.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel9.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel9.Location = new System.Drawing.Point(120, 38);
            this.fld_lblLabel9.Name = "fld_lblLabel9";
            this.fld_lblLabel9.Screen = null;
            this.fld_lblLabel9.Size = new System.Drawing.Size(30, 13);
            this.fld_lblLabel9.TabIndex = 9;
            this.fld_lblLabel9.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel9.Text = "Tháng";
            // 
            // fld_dteHRPayRollDate1
            // 
            this.fld_dteHRPayRollDate1.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteHRPayRollDate1.BOSDataMember = "HRPayRollDate";
            this.fld_dteHRPayRollDate1.BOSDataSource = "HRPayRolls";
            this.fld_dteHRPayRollDate1.BOSDescription = null;
            this.fld_dteHRPayRollDate1.BOSError = null;
            this.fld_dteHRPayRollDate1.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteHRPayRollDate1.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteHRPayRollDate1.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dteHRPayRollDate1.BOSPropertyName = "EditValue";
            this.fld_dteHRPayRollDate1.EditValue = null;
            this.fld_dteHRPayRollDate1.Location = new System.Drawing.Point(203, 35);
            this.fld_dteHRPayRollDate1.Name = "fld_dteHRPayRollDate1";
            this.fld_dteHRPayRollDate1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHRPayRollDate1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHRPayRollDate1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHRPayRollDate1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHRPayRollDate1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHRPayRollDate1.Properties.DisplayFormat.FormatString = "MM/yyyy";
            this.fld_dteHRPayRollDate1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRPayRollDate1.Properties.EditFormat.FormatString = "MM/yyyy";
            this.fld_dteHRPayRollDate1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteHRPayRollDate1.Properties.Mask.EditMask = "MM/yyyy";
            this.fld_dteHRPayRollDate1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHRPayRollDate1.Screen = null;
            this.fld_dteHRPayRollDate1.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHRPayRollDate1.TabIndex = 2;
            this.fld_dteHRPayRollDate1.Tag = "DC";
            // 
            // fld_txtHRPayRollNo1
            // 
            this.fld_txtHRPayRollNo1.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollNo1.BOSDataMember = "HRPayRollNo";
            this.fld_txtHRPayRollNo1.BOSDataSource = "HRPayRolls";
            this.fld_txtHRPayRollNo1.BOSDescription = null;
            this.fld_txtHRPayRollNo1.BOSError = null;
            this.fld_txtHRPayRollNo1.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollNo1.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollNo1.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollNo1.BOSPropertyName = "Text";
            this.fld_txtHRPayRollNo1.EditValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollNo1.Location = new System.Drawing.Point(203, 9);
            this.fld_txtHRPayRollNo1.Name = "fld_txtHRPayRollNo1";
            this.fld_txtHRPayRollNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRPayRollNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRPayRollNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRPayRollNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRPayRollNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRPayRollNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRPayRollNo1.Screen = null;
            this.fld_txtHRPayRollNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHRPayRollNo1.TabIndex = 0;
            this.fld_txtHRPayRollNo1.Tag = "DC";
            // 
            // fld_txtHRPayRollName1
            // 
            this.fld_txtHRPayRollName1.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollName1.BOSDataMember = "HRPayRollName";
            this.fld_txtHRPayRollName1.BOSDataSource = "HRPayRolls";
            this.fld_txtHRPayRollName1.BOSDescription = null;
            this.fld_txtHRPayRollName1.BOSError = null;
            this.fld_txtHRPayRollName1.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollName1.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollName1.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollName1.BOSPropertyName = "Text";
            this.fld_txtHRPayRollName1.EditValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRPayRollName1.Location = new System.Drawing.Point(471, 9);
            this.fld_txtHRPayRollName1.Name = "fld_txtHRPayRollName1";
            this.fld_txtHRPayRollName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRPayRollName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRPayRollName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRPayRollName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRPayRollName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRPayRollName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRPayRollName1.Screen = null;
            this.fld_txtHRPayRollName1.Size = new System.Drawing.Size(387, 20);
            this.fld_txtHRPayRollName1.TabIndex = 1;
            this.fld_txtHRPayRollName1.Tag = "DC";
            // 
            // fld_medHRPayRollDesc
            // 
            this.fld_medHRPayRollDesc.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRPayRollDesc.BOSDataMember = "HRPayRollDesc";
            this.fld_medHRPayRollDesc.BOSDataSource = "HRPayRolls";
            this.fld_medHRPayRollDesc.BOSDescription = null;
            this.fld_medHRPayRollDesc.BOSError = null;
            this.fld_medHRPayRollDesc.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRPayRollDesc.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRPayRollDesc.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRPayRollDesc.BOSPropertyName = "Text";
            this.fld_medHRPayRollDesc.EditValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRPayRollDesc.Location = new System.Drawing.Point(203, 61);
            this.fld_medHRPayRollDesc.Name = "fld_medHRPayRollDesc";
            this.fld_medHRPayRollDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRPayRollDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRPayRollDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRPayRollDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRPayRollDesc.Screen = null;
            this.fld_medHRPayRollDesc.Size = new System.Drawing.Size(655, 38);
            this.fld_medHRPayRollDesc.TabIndex = 5;
            this.fld_medHRPayRollDesc.Tag = "DC";
            // 
            // fld_lkeHRPayRollType1
            // 
            this.fld_lkeHRPayRollType1.BOSAllowAddNew = false;
            this.fld_lkeHRPayRollType1.BOSAllowDummy = false;
            this.fld_lkeHRPayRollType1.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeHRPayRollType1.BOSDataMember = "HRPayRollType";
            this.fld_lkeHRPayRollType1.BOSDataSource = "HRPayRolls";
            this.fld_lkeHRPayRollType1.BOSDescription = null;
            this.fld_lkeHRPayRollType1.BOSError = null;
            this.fld_lkeHRPayRollType1.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeHRPayRollType1.BOSFieldParent = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeHRPayRollType1.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeHRPayRollType1.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeHRPayRollType1.BOSPropertyName = "EditValue";
            this.fld_lkeHRPayRollType1.BOSSelectType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeHRPayRollType1.BOSSelectTypeValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeHRPayRollType1.CurrentDisplayText = null;
            this.fld_lkeHRPayRollType1.Location = new System.Drawing.Point(471, 35);
            this.fld_lkeHRPayRollType1.Name = "fld_lkeHRPayRollType1";
            this.fld_lkeHRPayRollType1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeHRPayRollType1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeHRPayRollType1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeHRPayRollType1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeHRPayRollType1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRPayRollType1.Properties.ColumnName = null;
            this.fld_lkeHRPayRollType1.Properties.NullText = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lkeHRPayRollType1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeHRPayRollType1.Screen = null;
            this.fld_lkeHRPayRollType1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRPayRollType1.TabIndex = 3;
            this.fld_lkeHRPayRollType1.Tag = "DC";
            this.fld_lkeHRPayRollType1.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeHRPayRollType1_CloseUp);
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnExportExcel);
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHREmployeePayRolls);
            this.fld_grcGroupControl1.Controls.Add(this.fld_btnAddEmployee);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(0, 127);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(934, 581);
            this.fld_grcGroupControl1.TabIndex = 17;
            this.fld_grcGroupControl1.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_grcGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_dgcHREmployeePayRolls
            // 
            this.fld_dgcHREmployeePayRolls.AllowDrop = true;
            this.fld_dgcHREmployeePayRolls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeePayRolls.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHREmployeePayRolls.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHREmployeePayRolls.BOSDataSource = "HREmployeePayRolls";
            this.fld_dgcHREmployeePayRolls.BOSDescription = null;
            this.fld_dgcHREmployeePayRolls.BOSError = null;
            this.fld_dgcHREmployeePayRolls.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHREmployeePayRolls.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHREmployeePayRolls.BOSGridType = null;
            this.fld_dgcHREmployeePayRolls.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHREmployeePayRolls.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHREmployeePayRolls.CommodityType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHREmployeePayRolls.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeePayRolls.GridViewMain = null;
            this.fld_dgcHREmployeePayRolls.Location = new System.Drawing.Point(3, 25);
            this.fld_dgcHREmployeePayRolls.MainView = this.fld_dgvHREmployeePayRolls;
            this.fld_dgcHREmployeePayRolls.Name = "fld_dgcHREmployeePayRolls";
            this.fld_dgcHREmployeePayRolls.PrintReport = false;
            this.fld_dgcHREmployeePayRolls.Screen = null;
            this.fld_dgcHREmployeePayRolls.ShowOnlyPredefinedDetails = true;
            this.fld_dgcHREmployeePayRolls.Size = new System.Drawing.Size(931, 514);
            this.fld_dgcHREmployeePayRolls.TabIndex = 0;
            this.fld_dgcHREmployeePayRolls.Tag = "DC";
            this.fld_dgcHREmployeePayRolls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREmployeePayRolls});
            // 
            // fld_dgvHREmployeePayRolls
            // 
            this.fld_dgvHREmployeePayRolls.GridControl = this.fld_dgcHREmployeePayRolls;
            this.fld_dgvHREmployeePayRolls.Name = "fld_dgvHREmployeePayRolls";
            this.fld_dgvHREmployeePayRolls.OptionsView.ShowDetailButtons = false;
            this.fld_dgvHREmployeePayRolls.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.fld_dgvHREmployeePayRolls.PaintStyleName = "Office2003";
            // 
            // fld_btnAddEmployee
            // 
            this.fld_btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnAddEmployee.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddEmployee.Appearance.Options.UseForeColor = true;
            this.fld_btnAddEmployee.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnAddEmployee.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnAddEmployee.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnAddEmployee.BOSDescription = null;
            this.fld_btnAddEmployee.BOSError = null;
            this.fld_btnAddEmployee.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnAddEmployee.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnAddEmployee.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnAddEmployee.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnAddEmployee.Location = new System.Drawing.Point(109, 545);
            this.fld_btnAddEmployee.Name = "fld_btnAddEmployee";
            this.fld_btnAddEmployee.Screen = null;
            this.fld_btnAddEmployee.Size = new System.Drawing.Size(100, 27);
            this.fld_btnAddEmployee.TabIndex = 0;
            this.fld_btnAddEmployee.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnAddEmployee.Text = "Thêm nhân viên";
            this.fld_btnAddEmployee.Visible = false;
            this.fld_btnAddEmployee.Click += new System.EventHandler(this.fld_btnAddEmployee_Click);
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
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(934, 711);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_lkeHRPayRollStatus);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel2.Controls.Add(this.fld_pteHRTimeSheetEmployeePicture);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel9);
            this.bosPanel2.Controls.Add(this.fld_medHRPayRollDesc);
            this.bosPanel2.Controls.Add(this.fld_txtHRPayRollNo1);
            this.bosPanel2.Controls.Add(this.fld_dteHRPayRollDate1);
            this.bosPanel2.Controls.Add(this.fld_txtHRPayRollName1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel2);
            this.bosPanel2.Controls.Add(this.fld_lkeHRPayRollType1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel4);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(934, 124);
            this.bosPanel2.TabIndex = 18;
            // 
            // fld_lkeHRPayRollStatus
            // 
            this.fld_lkeHRPayRollStatus.BOSAllowAddNew = false;
            this.fld_lkeHRPayRollStatus.BOSAllowDummy = false;
            this.fld_lkeHRPayRollStatus.BOSComment = null;
            this.fld_lkeHRPayRollStatus.BOSDataMember = "HRPayRollStatus";
            this.fld_lkeHRPayRollStatus.BOSDataSource = "HRPayRolls";
            this.fld_lkeHRPayRollStatus.BOSDescription = null;
            this.fld_lkeHRPayRollStatus.BOSError = null;
            this.fld_lkeHRPayRollStatus.BOSFieldGroup = null;
            this.fld_lkeHRPayRollStatus.BOSFieldParent = null;
            this.fld_lkeHRPayRollStatus.BOSFieldRelation = null;
            this.fld_lkeHRPayRollStatus.BOSPrivilege = null;
            this.fld_lkeHRPayRollStatus.BOSPropertyName = "EditValue";
            this.fld_lkeHRPayRollStatus.BOSSelectType = null;
            this.fld_lkeHRPayRollStatus.BOSSelectTypeValue = null;
            this.fld_lkeHRPayRollStatus.CurrentDisplayText = null;
            this.fld_lkeHRPayRollStatus.Location = new System.Drawing.Point(708, 35);
            this.fld_lkeHRPayRollStatus.MenuManager = this.screenToolbar;
            this.fld_lkeHRPayRollStatus.Name = "fld_lkeHRPayRollStatus";
            this.fld_lkeHRPayRollStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeHRPayRollStatus.Properties.ColumnName = null;
            this.fld_lkeHRPayRollStatus.Properties.ReadOnly = true;
            this.fld_lkeHRPayRollStatus.Screen = null;
            this.fld_lkeHRPayRollStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeHRPayRollStatus.TabIndex = 4;
            this.fld_lkeHRPayRollStatus.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = null;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "HRPayRolls";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(3, 101);
            this.fld_lkeFK_HREmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(100, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 20;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_pteHRTimeSheetEmployeePicture
            // 
            this.fld_pteHRTimeSheetEmployeePicture.BOSComment = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataMember = "HRPayRollEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDataSource = "HRPayRolls";
            this.fld_pteHRTimeSheetEmployeePicture.BOSDescription = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSError = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldGroup = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSFieldRelation = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPrivilege = null;
            this.fld_pteHRTimeSheetEmployeePicture.BOSPropertyName = "EditValue";
            this.fld_pteHRTimeSheetEmployeePicture.FileName = null;
            this.fld_pteHRTimeSheetEmployeePicture.FilePath = null;
            this.fld_pteHRTimeSheetEmployeePicture.Location = new System.Drawing.Point(3, 3);
            this.fld_pteHRTimeSheetEmployeePicture.MenuManager = this.screenToolbar;
            this.fld_pteHRTimeSheetEmployeePicture.Name = "fld_pteHRTimeSheetEmployeePicture";
            this.fld_pteHRTimeSheetEmployeePicture.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.fld_pteHRTimeSheetEmployeePicture.Screen = null;
            this.fld_pteHRTimeSheetEmployeePicture.Size = new System.Drawing.Size(100, 96);
            this.fld_pteHRTimeSheetEmployeePicture.TabIndex = 7;
            this.fld_pteHRTimeSheetEmployeePicture.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.Location = new System.Drawing.Point(641, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(49, 13);
            this.bosLabel2.TabIndex = 5;
            this.bosLabel2.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel2.Text = "Tình trạng";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel1.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel1.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel1.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel1.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel1.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel1.Location = new System.Drawing.Point(375, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(76, 13);
            this.bosLabel1.TabIndex = 5;
            this.bosLabel1.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel1.Text = "Loại bảng lương";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.Location = new System.Drawing.Point(120, 12);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(71, 13);
            this.fld_lblLabel2.TabIndex = 1;
            this.fld_lblLabel2.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel2.Text = "Mã bảng lương";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel4.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel4.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel4.Location = new System.Drawing.Point(375, 12);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(75, 13);
            this.fld_lblLabel4.TabIndex = 3;
            this.fld_lblLabel4.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_lblLabel4.Text = "Tên bảng lương";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.Location = new System.Drawing.Point(120, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 15;
            this.bosLabel3.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_btnExportExcel
            // 
            this.fld_btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fld_btnExportExcel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnExportExcel.Appearance.Options.UseForeColor = true;
            this.fld_btnExportExcel.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnExportExcel.BOSDataMember = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnExportExcel.BOSDataSource = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnExportExcel.BOSDescription = null;
            this.fld_btnExportExcel.BOSError = null;
            this.fld_btnExportExcel.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnExportExcel.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnExportExcel.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnExportExcel.BOSPropertyName = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnExportExcel.Location = new System.Drawing.Point(3, 545);
            this.fld_btnExportExcel.Name = "fld_btnExportExcel";
            this.fld_btnExportExcel.Screen = null;
            this.fld_btnExportExcel.Size = new System.Drawing.Size(100, 27);
            this.fld_btnExportExcel.TabIndex = 6;
            this.fld_btnExportExcel.Tag = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_btnExportExcel.Text = "Xuất excel";
            this.fld_btnExportExcel.Click += new System.EventHandler(this.fld_btnExportExcel_Click);
            // 
            // DMHRPR100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(934, 711);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMHRPR100";
            this.Text = "Thông tin bảng lương";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollDate1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHRPayRollDate1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRPayRollName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRPayRollDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollType1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeePayRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREmployeePayRolls)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeHRPayRollStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_pteHRTimeSheetEmployeePicture.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSPictureEdit fld_pteHRTimeSheetEmployeePicture;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeHRPayRollStatus;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSButton fld_btnExportExcel;
	}
}
