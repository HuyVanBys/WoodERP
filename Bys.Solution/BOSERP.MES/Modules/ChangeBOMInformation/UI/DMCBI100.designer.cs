using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ChangeBOMInformation.UI
{
	/// <summary>
	/// Summary description for DMCBI100
	/// </summary>
	partial class DMCBI100
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
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMChangeBOMInformationItems = new BOSERP.Modules.ChangeBOMInformation.ChangeBOMInformationItemsGridControl();
            this.fld_btnViewChangeInfo = new BOSComponent.BOSButton(this.components);
            this.fld_dteChangeBOMInformationToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteChangeBOMInformationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMChangeBOMInformationStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medMMChangeBOMInformationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMProductionNormID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMChangeBOMInformationDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMChangeBOMInformationNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgvMMChangeBOMInformationItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lkeFK_MMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMChangeBOMInformationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteChangeBOMInformationToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteChangeBOMInformationToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteChangeBOMInformationFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteChangeBOMInformationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMChangeBOMInformationStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMChangeBOMInformationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMChangeBOMInformationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMChangeBOMInformationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMBatchProductID);
            this.bosPanel1.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.fld_lkeMMChangeBOMInformationStatus);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.bosPanel1.Controls.Add(this.fld_medMMChangeBOMInformationDesc);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMProductionNormID);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_dteMMChangeBOMInformationDate);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtMMChangeBOMInformationNo);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(360, 35);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 4;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcMMChangeBOMInformationItems);
            this.bosGroupControl1.Controls.Add(this.fld_btnViewChangeInfo);
            this.bosGroupControl1.Controls.Add(this.fld_dteChangeBOMInformationToDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel13);
            this.bosGroupControl1.Controls.Add(this.fld_dteChangeBOMInformationFromDate);
            this.bosGroupControl1.Controls.Add(this.bosLabel12);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 126);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(855, 438);
            this.bosGroupControl1.TabIndex = 110;
            this.bosGroupControl1.Text = "Danh sách chi tiết thay đổi";
            // 
            // fld_dgcMMChangeBOMInformationItems
            // 
            this.fld_dgcMMChangeBOMInformationItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMChangeBOMInformationItems.BOSComment = null;
            this.fld_dgcMMChangeBOMInformationItems.BOSDataMember = null;
            this.fld_dgcMMChangeBOMInformationItems.BOSDataSource = "MMChangeBOMInformationItems";
            this.fld_dgcMMChangeBOMInformationItems.BOSDescription = null;
            this.fld_dgcMMChangeBOMInformationItems.BOSError = null;
            this.fld_dgcMMChangeBOMInformationItems.BOSFieldGroup = null;
            this.fld_dgcMMChangeBOMInformationItems.BOSFieldRelation = null;
            this.fld_dgcMMChangeBOMInformationItems.BOSGridType = null;
            this.fld_dgcMMChangeBOMInformationItems.BOSPrivilege = null;
            this.fld_dgcMMChangeBOMInformationItems.BOSPropertyName = null;
            this.fld_dgcMMChangeBOMInformationItems.Location = new System.Drawing.Point(0, 58);
            this.fld_dgcMMChangeBOMInformationItems.MenuManager = this.screenToolbar;
            this.fld_dgcMMChangeBOMInformationItems.Name = "fld_dgcMMChangeBOMInformationItems";
            this.fld_dgcMMChangeBOMInformationItems.PrintReport = false;
            this.fld_dgcMMChangeBOMInformationItems.Screen = null;
            this.fld_dgcMMChangeBOMInformationItems.Size = new System.Drawing.Size(855, 380);
            this.fld_dgcMMChangeBOMInformationItems.TabIndex = 27;
            // 
            // fld_btnViewChangeInfo
            // 
            this.fld_btnViewChangeInfo.BOSComment = null;
            this.fld_btnViewChangeInfo.BOSDataMember = null;
            this.fld_btnViewChangeInfo.BOSDataSource = null;
            this.fld_btnViewChangeInfo.BOSDescription = null;
            this.fld_btnViewChangeInfo.BOSError = null;
            this.fld_btnViewChangeInfo.BOSFieldGroup = null;
            this.fld_btnViewChangeInfo.BOSFieldRelation = null;
            this.fld_btnViewChangeInfo.BOSPrivilege = null;
            this.fld_btnViewChangeInfo.BOSPropertyName = null;
            this.fld_btnViewChangeInfo.Location = new System.Drawing.Point(563, 25);
            this.fld_btnViewChangeInfo.Name = "fld_btnViewChangeInfo";
            this.fld_btnViewChangeInfo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnViewChangeInfo, true);
            this.fld_btnViewChangeInfo.Size = new System.Drawing.Size(171, 27);
            this.fld_btnViewChangeInfo.TabIndex = 26;
            this.fld_btnViewChangeInfo.Text = "Xem thông tin thay đổi";
            this.fld_btnViewChangeInfo.Click += new System.EventHandler(this.fld_btnViewChangeInfo_Click);
            // 
            // fld_dteChangeBOMInformationToDate
            // 
            this.fld_dteChangeBOMInformationToDate.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationToDate.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationToDate.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationToDate.BOSDescription = null;
            this.fld_dteChangeBOMInformationToDate.BOSError = null;
            this.fld_dteChangeBOMInformationToDate.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationToDate.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationToDate.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationToDate.BOSPropertyName = "EditValue";
            this.fld_dteChangeBOMInformationToDate.EditValue = null;
            this.fld_dteChangeBOMInformationToDate.Location = new System.Drawing.Point(357, 32);
            this.fld_dteChangeBOMInformationToDate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.fld_dteChangeBOMInformationToDate.Name = "fld_dteChangeBOMInformationToDate";
            this.fld_dteChangeBOMInformationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteChangeBOMInformationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteChangeBOMInformationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteChangeBOMInformationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteChangeBOMInformationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteChangeBOMInformationToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteChangeBOMInformationToDate.Screen = null;
            this.fld_dteChangeBOMInformationToDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteChangeBOMInformationToDate.TabIndex = 2;
            this.fld_dteChangeBOMInformationToDate.Tag = "DC";
            // 
            // bosLabel13
            // 
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(284, 35);
            this.bosLabel13.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(47, 13);
            this.bosLabel13.TabIndex = 25;
            this.bosLabel13.Text = "Đến ngày";
            // 
            // fld_dteChangeBOMInformationFromDate
            // 
            this.fld_dteChangeBOMInformationFromDate.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationFromDate.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationFromDate.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationFromDate.BOSDescription = null;
            this.fld_dteChangeBOMInformationFromDate.BOSError = null;
            this.fld_dteChangeBOMInformationFromDate.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationFromDate.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationFromDate.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_dteChangeBOMInformationFromDate.BOSPropertyName = "EditValue";
            this.fld_dteChangeBOMInformationFromDate.EditValue = null;
            this.fld_dteChangeBOMInformationFromDate.Location = new System.Drawing.Point(66, 32);
            this.fld_dteChangeBOMInformationFromDate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.fld_dteChangeBOMInformationFromDate.Name = "fld_dteChangeBOMInformationFromDate";
            this.fld_dteChangeBOMInformationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteChangeBOMInformationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteChangeBOMInformationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteChangeBOMInformationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteChangeBOMInformationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteChangeBOMInformationFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteChangeBOMInformationFromDate.Screen = null;
            this.fld_dteChangeBOMInformationFromDate.Size = new System.Drawing.Size(173, 20);
            this.fld_dteChangeBOMInformationFromDate.TabIndex = 2;
            this.fld_dteChangeBOMInformationFromDate.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(9, 35);
            this.bosLabel12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(40, 13);
            this.bosLabel12.TabIndex = 25;
            this.bosLabel12.Text = "Từ ngày";
            // 
            // fld_lkeMMChangeBOMInformationStatus
            // 
            this.fld_lkeMMChangeBOMInformationStatus.BOSAllowAddNew = false;
            this.fld_lkeMMChangeBOMInformationStatus.BOSAllowDummy = false;
            this.fld_lkeMMChangeBOMInformationStatus.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSDataMember = "MMChangeBOMInformationStatus";
            this.fld_lkeMMChangeBOMInformationStatus.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeMMChangeBOMInformationStatus.BOSDescription = null;
            this.fld_lkeMMChangeBOMInformationStatus.BOSError = null;
            this.fld_lkeMMChangeBOMInformationStatus.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMChangeBOMInformationStatus.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.CurrentDisplayText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.Location = new System.Drawing.Point(639, 9);
            this.fld_lkeMMChangeBOMInformationStatus.Name = "fld_lkeMMChangeBOMInformationStatus";
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMChangeBOMInformationStatus.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.ReadOnly = true;
            this.fld_lkeMMChangeBOMInformationStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMChangeBOMInformationStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMChangeBOMInformationStatus, true);
            this.fld_lkeMMChangeBOMInformationStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeMMChangeBOMInformationStatus.TabIndex = 2;
            this.fld_lkeMMChangeBOMInformationStatus.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(566, 12);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 109;
            this.bosLabel3.Text = "Tình trạng";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(566, 38);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 107;
            this.bosLabel6.Text = "Đơn hàng";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = true;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "FK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeFK_ARSaleOrderID.BOSDescription = null;
            this.fld_lkeFK_ARSaleOrderID.BOSError = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldGroup = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldParent = null;
            this.fld_lkeFK_ARSaleOrderID.BOSFieldRelation = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPrivilege = null;
            this.fld_lkeFK_ARSaleOrderID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARSaleOrderID.BOSSelectType = null;
            this.fld_lkeFK_ARSaleOrderID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARSaleOrderID.CurrentDisplayText = null;
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(639, 35);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã đơn hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDeliveryDate", "Ngày giao"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDesc", "Ghi chú")});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 5;
            this.fld_lkeFK_ARSaleOrderID.Tag = "DC";
            this.fld_lkeFK_ARSaleOrderID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_ARSaleOrderID_EditValueChanged);
            // 
            // fld_medMMChangeBOMInformationDesc
            // 
            this.fld_medMMChangeBOMInformationDesc.BOSComment = null;
            this.fld_medMMChangeBOMInformationDesc.BOSDataMember = "MMChangeBOMInformationDesc";
            this.fld_medMMChangeBOMInformationDesc.BOSDataSource = "MMChangeBOMInformations";
            this.fld_medMMChangeBOMInformationDesc.BOSDescription = null;
            this.fld_medMMChangeBOMInformationDesc.BOSError = null;
            this.fld_medMMChangeBOMInformationDesc.BOSFieldGroup = null;
            this.fld_medMMChangeBOMInformationDesc.BOSFieldRelation = null;
            this.fld_medMMChangeBOMInformationDesc.BOSPrivilege = null;
            this.fld_medMMChangeBOMInformationDesc.BOSPropertyName = "EditValue";
            this.fld_medMMChangeBOMInformationDesc.Location = new System.Drawing.Point(71, 87);
            this.fld_medMMChangeBOMInformationDesc.MenuManager = this.screenToolbar;
            this.fld_medMMChangeBOMInformationDesc.Name = "fld_medMMChangeBOMInformationDesc";
            this.fld_medMMChangeBOMInformationDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMChangeBOMInformationDesc, true);
            this.fld_medMMChangeBOMInformationDesc.Size = new System.Drawing.Size(739, 33);
            this.fld_medMMChangeBOMInformationDesc.TabIndex = 9;
            this.fld_medMMChangeBOMInformationDesc.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(12, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(34, 13);
            this.bosLabel4.TabIndex = 105;
            this.bosLabel4.Text = "Mã LSX";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = null;
            this.bosLabel5.BOSDataSource = null;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(12, 90);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 106;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(287, 38);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel10, true);
            this.fld_lblLabel10.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel10.TabIndex = 101;
            this.fld_lblLabel10.Text = "Khách hàng";
            // 
            // fld_lkeFK_ICProductID
            // 
            this.fld_lkeFK_ICProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductID.BOSComment = null;
            this.fld_lkeFK_ICProductID.BOSDataMember = "FK_ICProductID";
            this.fld_lkeFK_ICProductID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeFK_ICProductID.BOSDescription = null;
            this.fld_lkeFK_ICProductID.BOSError = null;
            this.fld_lkeFK_ICProductID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductID.BOSSelectType = null;
            this.fld_lkeFK_ICProductID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICProductID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductID.Location = new System.Drawing.Point(360, 61);
            this.fld_lkeFK_ICProductID.Name = "fld_lkeFK_ICProductID";
            this.fld_lkeFK_ICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeFK_ICProductID.Properties.DisplayMember = "ICProductNo";
            this.fld_lkeFK_ICProductID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeFK_ICProductID.Screen = null;
            this.fld_lkeFK_ICProductID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_ICProductID.TabIndex = 7;
            this.fld_lkeFK_ICProductID.Tag = "DC";
            this.fld_lkeFK_ICProductID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_ICProductID_EditValueChanged);
            this.fld_lkeFK_ICProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductID_CloseUp);
            // 
            // fld_lkeFK_MMProductionNormID
            // 
            this.fld_lkeFK_MMProductionNormID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionNormID.BOSAllowDummy = true;
            this.fld_lkeFK_MMProductionNormID.BOSComment = null;
            this.fld_lkeFK_MMProductionNormID.BOSDataMember = "FK_MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeFK_MMProductionNormID.BOSDescription = null;
            this.fld_lkeFK_MMProductionNormID.BOSError = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionNormID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionNormID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionNormID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionNormID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionNormID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionNormID.Location = new System.Drawing.Point(639, 61);
            this.fld_lkeFK_MMProductionNormID.Name = "fld_lkeFK_MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionNormID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Mã BOM"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormOldProductNo", "Mã HT củ")});
            this.fld_lkeFK_MMProductionNormID.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_lkeFK_MMProductionNormID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMProductionNormID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionNormID.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.Screen = null;
            this.fld_lkeFK_MMProductionNormID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_MMProductionNormID.TabIndex = 8;
            this.fld_lkeFK_MMProductionNormID.Tag = "DC";
            this.fld_lkeFK_MMProductionNormID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMProductionNormID_CloseUp);
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(12, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 100;
            this.bosLabel2.Text = "Nhân viên";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(287, 64);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(47, 13);
            this.bosLabel10.TabIndex = 96;
            this.bosLabel10.Text = "Sản phẩm";
            // 
            // fld_dteMMChangeBOMInformationDate
            // 
            this.fld_dteMMChangeBOMInformationDate.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMChangeBOMInformationDate.BOSDataMember = "MMChangeBOMInformationDate";
            this.fld_dteMMChangeBOMInformationDate.BOSDataSource = "MMChangeBOMInformations";
            this.fld_dteMMChangeBOMInformationDate.BOSDescription = null;
            this.fld_dteMMChangeBOMInformationDate.BOSError = null;
            this.fld_dteMMChangeBOMInformationDate.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMChangeBOMInformationDate.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMChangeBOMInformationDate.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMChangeBOMInformationDate.BOSPropertyName = "EditValue";
            this.fld_dteMMChangeBOMInformationDate.EditValue = null;
            this.fld_dteMMChangeBOMInformationDate.Location = new System.Drawing.Point(360, 9);
            this.fld_dteMMChangeBOMInformationDate.Name = "fld_dteMMChangeBOMInformationDate";
            this.fld_dteMMChangeBOMInformationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMChangeBOMInformationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMChangeBOMInformationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMChangeBOMInformationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMChangeBOMInformationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMChangeBOMInformationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMChangeBOMInformationDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMChangeBOMInformationDate, true);
            this.fld_dteMMChangeBOMInformationDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteMMChangeBOMInformationDate.TabIndex = 1;
            this.fld_dteMMChangeBOMInformationDate.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(566, 64);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(22, 13);
            this.bosLabel9.TabIndex = 97;
            this.bosLabel9.Text = "BOM";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(71, 35);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 3;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(12, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(43, 13);
            this.bosLabel1.TabIndex = 98;
            this.bosLabel1.Text = "Mã phiếu";
            // 
            // fld_txtMMChangeBOMInformationNo
            // 
            this.fld_txtMMChangeBOMInformationNo.BOSComment = null;
            this.fld_txtMMChangeBOMInformationNo.BOSDataMember = "MMChangeBOMInformationNo";
            this.fld_txtMMChangeBOMInformationNo.BOSDataSource = "MMChangeBOMInformations";
            this.fld_txtMMChangeBOMInformationNo.BOSDescription = null;
            this.fld_txtMMChangeBOMInformationNo.BOSError = null;
            this.fld_txtMMChangeBOMInformationNo.BOSFieldGroup = null;
            this.fld_txtMMChangeBOMInformationNo.BOSFieldRelation = null;
            this.fld_txtMMChangeBOMInformationNo.BOSPrivilege = null;
            this.fld_txtMMChangeBOMInformationNo.BOSPropertyName = "EditValue";
            this.fld_txtMMChangeBOMInformationNo.Location = new System.Drawing.Point(71, 9);
            this.fld_txtMMChangeBOMInformationNo.MenuManager = this.screenToolbar;
            this.fld_txtMMChangeBOMInformationNo.Name = "fld_txtMMChangeBOMInformationNo";
            this.fld_txtMMChangeBOMInformationNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMChangeBOMInformationNo, true);
            this.fld_txtMMChangeBOMInformationNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtMMChangeBOMInformationNo.TabIndex = 0;
            this.fld_txtMMChangeBOMInformationNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(287, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(42, 13);
            this.bosLabel7.TabIndex = 99;
            this.bosLabel7.Text = "Ngày lập";
            // 
            // fld_dgvMMChangeBOMInformationItems
            // 
            this.fld_dgvMMChangeBOMInformationItems.Name = "fld_dgvMMChangeBOMInformationItems";
            this.fld_dgvMMChangeBOMInformationItems.PaintStyleName = "Office2003";
            // 
            // fld_lkeFK_MMBatchProductID
            // 
            this.fld_lkeFK_MMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMBatchProductID.BOSAllowDummy = true;
            this.fld_lkeFK_MMBatchProductID.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.BOSDataMember = "FK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.BOSDataSource = "MMChangeBOMInformations";
            this.fld_lkeFK_MMBatchProductID.BOSDescription = null;
            this.fld_lkeFK_MMBatchProductID.BOSError = null;
            this.fld_lkeFK_MMBatchProductID.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMBatchProductID.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeFK_MMBatchProductID.Location = new System.Drawing.Point(71, 61);
            this.fld_lkeFK_MMBatchProductID.Name = "fld_lkeFK_MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderSaleAgreement", "Số hợp đồng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã đơn bán hàng")});
            this.fld_lkeFK_MMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeFK_MMBatchProductID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMBatchProductID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeFK_MMBatchProductID.Screen = null;
            this.fld_lkeFK_MMBatchProductID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_MMBatchProductID.TabIndex = 6;
            this.fld_lkeFK_MMBatchProductID.Tag = "DC";
            this.fld_lkeFK_MMBatchProductID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMBatchProductID_CloseUp);
            this.fld_lkeFK_MMBatchProductID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMBatchProductID_QueryPopUp);
            // 
            // DMCBI100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCBI100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMCBI100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMChangeBOMInformationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteChangeBOMInformationToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteChangeBOMInformationToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteChangeBOMInformationFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteChangeBOMInformationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMChangeBOMInformationStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMChangeBOMInformationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMChangeBOMInformationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMChangeBOMInformationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMChangeBOMInformationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMBatchProductID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionNormID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSDateEdit fld_dteMMChangeBOMInformationDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMChangeBOMInformationNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeMMChangeBOMInformationStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSMemoEdit fld_medMMChangeBOMInformationDesc;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSButton fld_btnViewChangeInfo;
        private BOSComponent.BOSDateEdit fld_dteChangeBOMInformationToDate;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSDateEdit fld_dteChangeBOMInformationFromDate;
        private BOSComponent.BOSLabel bosLabel12;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMChangeBOMInformationItems;
        private ChangeBOMInformationItemsGridControl fld_dgcMMChangeBOMInformationItems;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMBatchProductID;
	}
}
