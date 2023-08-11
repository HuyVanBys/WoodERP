using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.DepartmentRoomGroupTeam.UI
{
	/// <summary>
	/// Summary description for DMDRGT100
	/// </summary>
	partial class DMDRGT100
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
            this.fld_medHRDepartmentRoomGroupDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtHRDepartmentRoomGroupNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDepartmentRoomGroupName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_grcHRDepartmentRoomGroupTeamItems = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRDepartmentRoomGroupTeamItems = new BOSERP.Modules.DepartmentRoomGroupTeam.HRDepartmentRoomGroupTeamItemsGridControl();
            this.RLKEWorkingShift = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentRoomID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_HRDepartmentID2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDepartmentRoomGroupDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcHRDepartmentRoomGroupTeamItems)).BeginInit();
            this.fld_grcHRDepartmentRoomGroupTeamItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRoomGroupTeamItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLKEWorkingShift)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_medHRDepartmentRoomGroupDesc
            // 
            this.fld_medHRDepartmentRoomGroupDesc.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRDepartmentRoomGroupDesc.BOSDataMember = "HRDepartmentRoomGroupTeamDesc";
            this.fld_medHRDepartmentRoomGroupDesc.BOSDataSource = "HRDepartmentRoomGroupTeams";
            this.fld_medHRDepartmentRoomGroupDesc.BOSDescription = null;
            this.fld_medHRDepartmentRoomGroupDesc.BOSError = null;
            this.fld_medHRDepartmentRoomGroupDesc.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRDepartmentRoomGroupDesc.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRDepartmentRoomGroupDesc.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRDepartmentRoomGroupDesc.BOSPropertyName = "Text";
            this.fld_medHRDepartmentRoomGroupDesc.EditValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_medHRDepartmentRoomGroupDesc.Location = new System.Drawing.Point(92, 89);
            this.fld_medHRDepartmentRoomGroupDesc.Name = "fld_medHRDepartmentRoomGroupDesc";
            this.fld_medHRDepartmentRoomGroupDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHRDepartmentRoomGroupDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHRDepartmentRoomGroupDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHRDepartmentRoomGroupDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHRDepartmentRoomGroupDesc.Screen = null;
            this.fld_medHRDepartmentRoomGroupDesc.Size = new System.Drawing.Size(438, 57);
            this.fld_medHRDepartmentRoomGroupDesc.TabIndex = 5;
            this.fld_medHRDepartmentRoomGroupDesc.Tag = "DC";
            // 
            // fld_txtHRDepartmentRoomGroupNo
            // 
            this.fld_txtHRDepartmentRoomGroupNo.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.BOSDataMember = "HRDepartmentRoomGroupTeamNo";
            this.fld_txtHRDepartmentRoomGroupNo.BOSDataSource = "HRDepartmentRoomGroupTeams";
            this.fld_txtHRDepartmentRoomGroupNo.BOSDescription = null;
            this.fld_txtHRDepartmentRoomGroupNo.BOSError = null;
            this.fld_txtHRDepartmentRoomGroupNo.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.BOSPropertyName = "Text";
            this.fld_txtHRDepartmentRoomGroupNo.EditValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupNo.Location = new System.Drawing.Point(92, 9);
            this.fld_txtHRDepartmentRoomGroupNo.Name = "fld_txtHRDepartmentRoomGroupNo";
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDepartmentRoomGroupNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDepartmentRoomGroupNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDepartmentRoomGroupNo.Screen = null;
            this.fld_txtHRDepartmentRoomGroupNo.Size = new System.Drawing.Size(165, 20);
            this.fld_txtHRDepartmentRoomGroupNo.TabIndex = 0;
            this.fld_txtHRDepartmentRoomGroupNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(12, 12);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(61, 13);
            this.bosLabel7.TabIndex = 93;
            this.bosLabel7.Tag = "DC";
            this.bosLabel7.Text = "Mã chứng từ";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(12, 91);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(40, 13);
            this.bosLabel11.TabIndex = 94;
            this.bosLabel11.Tag = "DC";
            this.bosLabel11.Text = "Diễn giải";
            // 
            // fld_txtHRDepartmentRoomGroupName
            // 
            this.fld_txtHRDepartmentRoomGroupName.BOSComment = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupName.BOSDataMember = "HRDepartmentRoomGroupTeamName";
            this.fld_txtHRDepartmentRoomGroupName.BOSDataSource = "HRDepartmentRoomGroupTeams";
            this.fld_txtHRDepartmentRoomGroupName.BOSDescription = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSError = null;
            this.fld_txtHRDepartmentRoomGroupName.BOSFieldGroup = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupName.BOSFieldRelation = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupName.BOSPrivilege = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupName.BOSPropertyName = "Text";
            this.fld_txtHRDepartmentRoomGroupName.EditValue = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_txtHRDepartmentRoomGroupName.Location = new System.Drawing.Point(365, 9);
            this.fld_txtHRDepartmentRoomGroupName.Name = "fld_txtHRDepartmentRoomGroupName";
            this.fld_txtHRDepartmentRoomGroupName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDepartmentRoomGroupName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDepartmentRoomGroupName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDepartmentRoomGroupName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDepartmentRoomGroupName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDepartmentRoomGroupName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDepartmentRoomGroupName.Screen = null;
            this.fld_txtHRDepartmentRoomGroupName.Size = new System.Drawing.Size(165, 20);
            this.fld_txtHRDepartmentRoomGroupName.TabIndex = 1;
            this.fld_txtHRDepartmentRoomGroupName.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(285, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 100;
            this.bosLabel1.Tag = "DC";
            this.bosLabel1.Text = "Tên chứng từ";
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
            this.bosLabel9.Location = new System.Drawing.Point(12, 38);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(51, 13);
            this.bosLabel9.TabIndex = 92;
            this.bosLabel9.Tag = "DC";
            this.bosLabel9.Text = "Phòng ban";
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
            this.bosLabel2.Location = new System.Drawing.Point(285, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(39, 13);
            this.bosLabel2.TabIndex = 92;
            this.bosLabel2.Tag = "DC";
            this.bosLabel2.Text = "Bộ phận";
            // 
            // fld_grcHRDepartmentRoomGroupTeamItems
            // 
            this.fld_grcHRDepartmentRoomGroupTeamItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSComment = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSDataMember = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSDataSource = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSDescription = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSError = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSFieldGroup = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSFieldRelation = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSPrivilege = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.BOSPropertyName = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.Controls.Add(this.fld_dgcHRDepartmentRoomGroupTeamItems);
            this.fld_grcHRDepartmentRoomGroupTeamItems.Location = new System.Drawing.Point(3, 152);
            this.fld_grcHRDepartmentRoomGroupTeamItems.Name = "fld_grcHRDepartmentRoomGroupTeamItems";
            this.fld_grcHRDepartmentRoomGroupTeamItems.Screen = null;
            this.fld_grcHRDepartmentRoomGroupTeamItems.Size = new System.Drawing.Size(702, 417);
            this.fld_grcHRDepartmentRoomGroupTeamItems.TabIndex = 102;
            this.fld_grcHRDepartmentRoomGroupTeamItems.Text = "Danh sách nhóm";
            // 
            // fld_dgcHRDepartmentRoomGroupTeamItems
            // 
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSComment = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSDataMember = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSDataSource = "HRDepartmentRoomGroupTeamItems";
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSDescription = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSError = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSFieldGroup = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSFieldRelation = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSGridType = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSPrivilege = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.BOSPropertyName = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.CommodityType = global::Localization.PurchaseOrderLocalizedResources.a;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRDepartmentRoomGroupTeamItems.MenuManager = this.screenToolbar;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.Name = "fld_dgcHRDepartmentRoomGroupTeamItems";
            this.fld_dgcHRDepartmentRoomGroupTeamItems.PrintReport = false;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RLKEWorkingShift});
            this.fld_dgcHRDepartmentRoomGroupTeamItems.Screen = null;
            this.fld_dgcHRDepartmentRoomGroupTeamItems.Size = new System.Drawing.Size(698, 393);
            this.fld_dgcHRDepartmentRoomGroupTeamItems.TabIndex = 0;
            // 
            // RLKEWorkingShift
            // 
            this.RLKEWorkingShift.AutoHeight = false;
            this.RLKEWorkingShift.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RLKEWorkingShift.DisplayMember = "HRWorkingShiftName";
            this.RLKEWorkingShift.Name = "RLKEWorkingShift";
            this.RLKEWorkingShift.ValueMember = "HRWorkingShiftID";
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
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomGroupItemID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentRoomID2);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HRDepartmentID2);
            this.bosPanel1.Controls.Add(this.fld_grcHRDepartmentRoomGroupTeamItems);
            this.bosPanel1.Controls.Add(this.fld_txtHRDepartmentRoomGroupName);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.fld_medHRDepartmentRoomGroupDesc);
            this.bosPanel1.Controls.Add(this.fld_txtHRDepartmentRoomGroupNo);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(712, 571);
            this.bosPanel1.TabIndex = 103;
            // 
            // fld_lkeFK_HRDepartmentRoomGroupItemID
            // 
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataMember = "FK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDataSource = "HRDepartmentRoomGroupTeams";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Location = new System.Drawing.Point(92, 61);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Name = "fld_lkeFK_HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomGroupItemName", "Tổ")});
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.DisplayMember = "HRDepartmentRoomGroupItemName";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties.ValueMember = "HRDepartmentRoomGroupItemID";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Screen = null;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.TabIndex = 4;
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomGroupItemID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomGroupID_QueryPopUp);
            // 
            // fld_lkeFK_HRDepartmentRoomID2
            // 
            this.fld_lkeFK_HRDepartmentRoomID2.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSAllowDummy = false;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSComment = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSDataMember = "FK_HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID2.BOSDataSource = "HRDepartmentRoomGroupTeams";
            this.fld_lkeFK_HRDepartmentRoomID2.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSError = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentRoomID2.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentRoomID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentRoomID2.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentRoomID2.Location = new System.Drawing.Point(365, 35);
            this.fld_lkeFK_HRDepartmentRoomID2.Name = "fld_lkeFK_HRDepartmentRoomID2";
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentRoomName", "Bộ phận")});
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.DisplayMember = "HRDepartmentRoomName";
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentRoomID2.Properties.ValueMember = "HRDepartmentRoomID";
            this.fld_lkeFK_HRDepartmentRoomID2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentRoomID2, true);
            this.fld_lkeFK_HRDepartmentRoomID2.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_HRDepartmentRoomID2.TabIndex = 3;
            this.fld_lkeFK_HRDepartmentRoomID2.Tag = "DC";
            this.fld_lkeFK_HRDepartmentRoomID2.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_HRDepartmentRoomID2_QueryPopUp);
            // 
            // fld_lkeFK_HRDepartmentID2
            // 
            this.fld_lkeFK_HRDepartmentID2.BOSAllowAddNew = false;
            this.fld_lkeFK_HRDepartmentID2.BOSAllowDummy = true;
            this.fld_lkeFK_HRDepartmentID2.BOSComment = null;
            this.fld_lkeFK_HRDepartmentID2.BOSDataMember = "FK_HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID2.BOSDataSource = "HRDepartmentRoomGroupTeams";
            this.fld_lkeFK_HRDepartmentID2.BOSDescription = null;
            this.fld_lkeFK_HRDepartmentID2.BOSError = null;
            this.fld_lkeFK_HRDepartmentID2.BOSFieldGroup = null;
            this.fld_lkeFK_HRDepartmentID2.BOSFieldParent = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRDepartmentID2.BOSFieldRelation = null;
            this.fld_lkeFK_HRDepartmentID2.BOSPrivilege = null;
            this.fld_lkeFK_HRDepartmentID2.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRDepartmentID2.BOSSelectType = null;
            this.fld_lkeFK_HRDepartmentID2.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRDepartmentID2.CurrentDisplayText = null;
            this.fld_lkeFK_HRDepartmentID2.Location = new System.Drawing.Point(92, 35);
            this.fld_lkeFK_HRDepartmentID2.Name = "fld_lkeFK_HRDepartmentID2";
            this.fld_lkeFK_HRDepartmentID2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HRDepartmentID2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HRDepartmentID2.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HRDepartmentID2.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HRDepartmentID2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRDepartmentID2.Properties.ColumnName = null;
            this.fld_lkeFK_HRDepartmentID2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HRDepartmentName", "Phòng ban")});
            this.fld_lkeFK_HRDepartmentID2.Properties.DisplayMember = "HRDepartmentName";
            this.fld_lkeFK_HRDepartmentID2.Properties.NullText = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_lkeFK_HRDepartmentID2.Properties.PopupWidth = 40;
            this.fld_lkeFK_HRDepartmentID2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HRDepartmentID2.Properties.ValueMember = "HRDepartmentID";
            this.fld_lkeFK_HRDepartmentID2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HRDepartmentID2, true);
            this.fld_lkeFK_HRDepartmentID2.Size = new System.Drawing.Size(165, 20);
            this.fld_lkeFK_HRDepartmentID2.TabIndex = 2;
            this.fld_lkeFK_HRDepartmentID2.Tag = "DC";
            this.fld_lkeFK_HRDepartmentID2.Validated += new System.EventHandler(this.fld_lkeFK_HRDepartmentID2_Validated);
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
            this.bosLabel3.Location = new System.Drawing.Point(13, 64);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(12, 13);
            this.bosLabel3.TabIndex = 92;
            this.bosLabel3.Tag = "DC";
            this.bosLabel3.Text = "Tổ";
            // 
            // DMDRGT100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(712, 571);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMDRGT100";
            this.Text = "Thông tin";
            this.Load += new System.EventHandler(this.DMDRGT100_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHRDepartmentRoomGroupDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDepartmentRoomGroupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcHRDepartmentRoomGroupTeamItems)).EndInit();
            this.fld_grcHRDepartmentRoomGroupTeamItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDepartmentRoomGroupTeamItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RLKEWorkingShift)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomGroupItemID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentRoomID2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRDepartmentID2.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSMemoEdit fld_medHRDepartmentRoomGroupDesc;
        private BOSComponent.BOSTextBox fld_txtHRDepartmentRoomGroupNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel11;
        private IContainer components;
        private BOSComponent.BOSTextBox fld_txtHRDepartmentRoomGroupName;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSGroupControl fld_grcHRDepartmentRoomGroupTeamItems;
        private BOSERP.Modules.DepartmentRoomGroupTeam.HRDepartmentRoomGroupTeamItemsGridControl fld_dgcHRDepartmentRoomGroupTeamItems;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RLKEWorkingShift;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentID2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomID2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRDepartmentRoomGroupItemID;
        private BOSComponent.BOSLabel bosLabel3;
	}
}
