using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSERP.Modules.OperationDetailPlanCancel;

namespace BOSERP.Modules.OperationDetailPlanCancel.UI
{
	/// <summary>
	/// Summary description for DMODPC100
	/// </summary>
	partial class DMODPC100
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
            this.fld_txtMMOperationDetailPlanWeek = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMLineID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMOperationDetailPlanCancelItems = new BOSERP.Modules.OperationDetailPlanCancel.MMOperationDetailPlanCancelItemsGridControl();
            this.fld_dgvBatchProductCancelItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMOperationDetailPlanCancelDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeMMOperationDetailPlanCancelStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMOperationDetailPlanCancelDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtMMOperationDetailPlanCancelNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcFK_MMOperationDetailPlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationDetailPlanWeek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationDetailPlanCancelItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvBatchProductCancelItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMOperationDetailPlanCancelDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationDetailPlanCancelStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanCancelDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationDetailPlanCancelNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMOperationDetailPlanID.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_txtMMOperationDetailPlanWeek);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMLineID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_medMMOperationDetailPlanCancelDesc);
            this.bosPanel1.Controls.Add(this.fld_lkeMMOperationDetailPlanCancelStatus);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_dteMMOperationDetailPlanCancelDate);
            this.bosPanel1.Controls.Add(this.fld_txtMMOperationDetailPlanCancelNo);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.fld_dgcFK_MMOperationDetailPlanID);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_txtMMOperationDetailPlanWeek
            // 
            this.fld_txtMMOperationDetailPlanWeek.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanWeek.BOSDataMember = "MMOperationDetailPlanCancelWeek";
            this.fld_txtMMOperationDetailPlanWeek.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_txtMMOperationDetailPlanWeek.BOSDescription = null;
            this.fld_txtMMOperationDetailPlanWeek.BOSError = null;
            this.fld_txtMMOperationDetailPlanWeek.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanWeek.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanWeek.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanWeek.BOSPropertyName = "Text";
            this.fld_txtMMOperationDetailPlanWeek.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMOperationDetailPlanWeek.Location = new System.Drawing.Point(670, 64);
            this.fld_txtMMOperationDetailPlanWeek.Name = "fld_txtMMOperationDetailPlanWeek";
            this.fld_txtMMOperationDetailPlanWeek.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtMMOperationDetailPlanWeek.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMOperationDetailPlanWeek.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMOperationDetailPlanWeek.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMOperationDetailPlanWeek.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMOperationDetailPlanWeek.Properties.ReadOnly = true;
            this.fld_txtMMOperationDetailPlanWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMOperationDetailPlanWeek.Screen = null;
            this.fld_txtMMOperationDetailPlanWeek.Size = new System.Drawing.Size(171, 20);
            this.fld_txtMMOperationDetailPlanWeek.TabIndex = 7;
            this.fld_txtMMOperationDetailPlanWeek.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.BOSPropertyName = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.Location = new System.Drawing.Point(615, 67);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(25, 13);
            this.bosLabel10.TabIndex = 575;
            this.bosLabel10.Tag = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel10.Text = "Tuần";
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = null;
            this.bosLabel8.BOSDataSource = null;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(615, 41);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(37, 13);
            this.bosLabel8.TabIndex = 569;
            this.bosLabel8.Text = "Chuyền";
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
            this.bosLabel9.Location = new System.Drawing.Point(328, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(31, 13);
            this.bosLabel9.TabIndex = 570;
            this.bosLabel9.Text = "Xưởng";
            // 
            // fld_lkeFK_MMLineID
            // 
            this.fld_lkeFK_MMLineID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMLineID.BOSAllowDummy = false;
            this.fld_lkeFK_MMLineID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_MMLineID.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_lkeFK_MMLineID.BOSDescription = null;
            this.fld_lkeFK_MMLineID.BOSError = null;
            this.fld_lkeFK_MMLineID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMLineID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.Location = new System.Drawing.Point(670, 38);
            this.fld_lkeFK_MMLineID.Name = "fld_lkeFK_MMLineID";
            this.fld_lkeFK_MMLineID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMLineID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMLineID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên")});
            this.fld_lkeFK_MMLineID.Properties.DisplayMember = "MMLineName";
            this.fld_lkeFK_MMLineID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMLineID.Properties.ReadOnly = true;
            this.fld_lkeFK_MMLineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMLineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_MMLineID.Screen = null;
            this.fld_lkeFK_MMLineID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_MMLineID.TabIndex = 5;
            this.fld_lkeFK_MMLineID.Tag = "DC";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = false;
            this.fld_lkeFK_MMWorkShopID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(412, 38);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMWorkShopID.Properties.ReadOnly = true;
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 4;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcMMOperationDetailPlanCancelItems);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 113);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 451);
            this.bosGroupControl1.TabIndex = 8;
            this.bosGroupControl1.Text = "Danh sách hủy";
            // 
            // fld_dgcMMOperationDetailPlanCancelItems
            // 
            this.fld_dgcMMOperationDetailPlanCancelItems.AllowDrop = true;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSComment = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSDataMember = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSDataSource = "MMOperationDetailPlanCancelItems";
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSDescription = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSError = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSFieldGroup = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSFieldRelation = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSGridType = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSPrivilege = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.BOSPropertyName = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMOperationDetailPlanCancelItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMOperationDetailPlanCancelItems.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcMMOperationDetailPlanCancelItems.MainView = this.fld_dgvBatchProductCancelItem;
            this.fld_dgcMMOperationDetailPlanCancelItems.Name = "fld_dgcMMOperationDetailPlanCancelItems";
            this.fld_dgcMMOperationDetailPlanCancelItems.PrintReport = false;
            this.fld_dgcMMOperationDetailPlanCancelItems.Screen = null;
            this.fld_dgcMMOperationDetailPlanCancelItems.Size = new System.Drawing.Size(852, 427);
            this.fld_dgcMMOperationDetailPlanCancelItems.TabIndex = 0;
            this.fld_dgcMMOperationDetailPlanCancelItems.Tag = "DC";
            this.fld_dgcMMOperationDetailPlanCancelItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvBatchProductCancelItem});
            // 
            // fld_dgvBatchProductCancelItem
            // 
            this.fld_dgvBatchProductCancelItem.GridControl = this.fld_dgcMMOperationDetailPlanCancelItems;
            this.fld_dgvBatchProductCancelItem.Name = "fld_dgvBatchProductCancelItem";
            this.fld_dgvBatchProductCancelItem.PaintStyleName = "Office2003";
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
            this.bosLabel5.Location = new System.Drawing.Point(24, 67);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 565;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_medMMOperationDetailPlanCancelDesc
            // 
            this.fld_medMMOperationDetailPlanCancelDesc.BOSComment = null;
            this.fld_medMMOperationDetailPlanCancelDesc.BOSDataMember = "MMOperationDetailPlanCancelDesc";
            this.fld_medMMOperationDetailPlanCancelDesc.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_medMMOperationDetailPlanCancelDesc.BOSDescription = null;
            this.fld_medMMOperationDetailPlanCancelDesc.BOSError = null;
            this.fld_medMMOperationDetailPlanCancelDesc.BOSFieldGroup = null;
            this.fld_medMMOperationDetailPlanCancelDesc.BOSFieldRelation = null;
            this.fld_medMMOperationDetailPlanCancelDesc.BOSPrivilege = null;
            this.fld_medMMOperationDetailPlanCancelDesc.BOSPropertyName = "EditValue";
            this.fld_medMMOperationDetailPlanCancelDesc.Location = new System.Drawing.Point(122, 64);
            this.fld_medMMOperationDetailPlanCancelDesc.MenuManager = this.screenToolbar;
            this.fld_medMMOperationDetailPlanCancelDesc.Name = "fld_medMMOperationDetailPlanCancelDesc";
            this.fld_medMMOperationDetailPlanCancelDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMOperationDetailPlanCancelDesc, true);
            this.fld_medMMOperationDetailPlanCancelDesc.Size = new System.Drawing.Size(461, 43);
            this.fld_medMMOperationDetailPlanCancelDesc.TabIndex = 6;
            this.fld_medMMOperationDetailPlanCancelDesc.Tag = "DC";
            // 
            // fld_lkeMMOperationDetailPlanCancelStatus
            // 
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSAllowAddNew = false;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSAllowDummy = false;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSDataMember = "MMOperationDetailPlanCancelStatus";
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSDescription = null;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSError = null;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Location = new System.Drawing.Point(670, 12);
            this.fld_lkeMMOperationDetailPlanCancelStatus.Name = "fld_lkeMMOperationDetailPlanCancelStatus";
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.ReadOnly = true;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMOperationDetailPlanCancelStatus, true);
            this.fld_lkeMMOperationDetailPlanCancelStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeMMOperationDetailPlanCancelStatus.TabIndex = 2;
            this.fld_lkeMMOperationDetailPlanCancelStatus.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(615, 15);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 563;
            this.bosLabel3.Text = "Tình trạng";
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
            this.bosLabel7.Location = new System.Drawing.Point(328, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 561;
            this.bosLabel7.Text = "Ngày chứng từ";
            // 
            // fld_dteMMOperationDetailPlanCancelDate
            // 
            this.fld_dteMMOperationDetailPlanCancelDate.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMOperationDetailPlanCancelDate.BOSDataMember = "MMOperationDetailPlanCancelDate";
            this.fld_dteMMOperationDetailPlanCancelDate.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_dteMMOperationDetailPlanCancelDate.BOSDescription = null;
            this.fld_dteMMOperationDetailPlanCancelDate.BOSError = null;
            this.fld_dteMMOperationDetailPlanCancelDate.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMOperationDetailPlanCancelDate.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMOperationDetailPlanCancelDate.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_dteMMOperationDetailPlanCancelDate.BOSPropertyName = "EditValue";
            this.fld_dteMMOperationDetailPlanCancelDate.EditValue = null;
            this.fld_dteMMOperationDetailPlanCancelDate.Location = new System.Drawing.Point(412, 12);
            this.fld_dteMMOperationDetailPlanCancelDate.Name = "fld_dteMMOperationDetailPlanCancelDate";
            this.fld_dteMMOperationDetailPlanCancelDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMOperationDetailPlanCancelDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMOperationDetailPlanCancelDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMOperationDetailPlanCancelDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMOperationDetailPlanCancelDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMOperationDetailPlanCancelDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMOperationDetailPlanCancelDate, true);
            this.fld_dteMMOperationDetailPlanCancelDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteMMOperationDetailPlanCancelDate.TabIndex = 1;
            this.fld_dteMMOperationDetailPlanCancelDate.Tag = "DC";
            // 
            // fld_txtMMOperationDetailPlanCancelNo
            // 
            this.fld_txtMMOperationDetailPlanCancelNo.BOSComment = null;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSDataMember = "MMOperationDetailPlanCancelNo";
            this.fld_txtMMOperationDetailPlanCancelNo.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_txtMMOperationDetailPlanCancelNo.BOSDescription = null;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSError = null;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSFieldGroup = null;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSFieldRelation = null;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSPrivilege = null;
            this.fld_txtMMOperationDetailPlanCancelNo.BOSPropertyName = "EditValue";
            this.fld_txtMMOperationDetailPlanCancelNo.Location = new System.Drawing.Point(122, 12);
            this.fld_txtMMOperationDetailPlanCancelNo.MenuManager = this.screenToolbar;
            this.fld_txtMMOperationDetailPlanCancelNo.Name = "fld_txtMMOperationDetailPlanCancelNo";
            this.fld_txtMMOperationDetailPlanCancelNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMOperationDetailPlanCancelNo, true);
            this.fld_txtMMOperationDetailPlanCancelNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtMMOperationDetailPlanCancelNo.TabIndex = 0;
            this.fld_txtMMOperationDetailPlanCancelNo.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(24, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 559;
            this.bosLabel1.Text = "Mã chứng từ";
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
            this.bosLabel4.Location = new System.Drawing.Point(24, 41);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(89, 13);
            this.bosLabel4.TabIndex = 557;
            this.bosLabel4.Text = "Kế hoạch sản xuất";
            // 
            // fld_dgcFK_MMOperationDetailPlanID
            // 
            this.fld_dgcFK_MMOperationDetailPlanID.BOSAllowAddNew = false;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSAllowDummy = false;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSComment = null;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSDataMember = "FK_MMOperationDetailPlanID";
            this.fld_dgcFK_MMOperationDetailPlanID.BOSDataSource = "MMOperationDetailPlanCancels";
            this.fld_dgcFK_MMOperationDetailPlanID.BOSDescription = null;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSError = null;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSFieldGroup = null;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSFieldParent = null;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSFieldRelation = null;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSPrivilege = null;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSPropertyName = "EditValue";
            this.fld_dgcFK_MMOperationDetailPlanID.BOSSelectType = null;
            this.fld_dgcFK_MMOperationDetailPlanID.BOSSelectTypeValue = null;
            this.fld_dgcFK_MMOperationDetailPlanID.CurrentDisplayText = null;
            this.fld_dgcFK_MMOperationDetailPlanID.Location = new System.Drawing.Point(122, 38);
            this.fld_dgcFK_MMOperationDetailPlanID.Name = "fld_dgcFK_MMOperationDetailPlanID";
            this.fld_dgcFK_MMOperationDetailPlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dgcFK_MMOperationDetailPlanID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationDetailPlanNo", "Mã kế hoạch SX")});
            this.fld_dgcFK_MMOperationDetailPlanID.Properties.DisplayMember = "MMOperationDetailPlanNo";
            this.fld_dgcFK_MMOperationDetailPlanID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcFK_MMOperationDetailPlanID.Properties.ReadOnly = true;
            this.fld_dgcFK_MMOperationDetailPlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_dgcFK_MMOperationDetailPlanID.Properties.ValueMember = "MMOperationDetailPlanID";
            this.fld_dgcFK_MMOperationDetailPlanID.Screen = null;
            this.fld_dgcFK_MMOperationDetailPlanID.Size = new System.Drawing.Size(171, 20);
            this.fld_dgcFK_MMOperationDetailPlanID.TabIndex = 3;
            this.fld_dgcFK_MMOperationDetailPlanID.Tag = "DC";
            // 
            // DMODPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMODPC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationDetailPlanWeek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationDetailPlanCancelItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvBatchProductCancelItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMOperationDetailPlanCancelDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationDetailPlanCancelStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanCancelDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMOperationDetailPlanCancelDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationDetailPlanCancelNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcFK_MMOperationDetailPlanID.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_dgcFK_MMOperationDetailPlanID;
        private BOSComponent.BOSTextBox fld_txtMMOperationDetailPlanCancelNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSDateEdit fld_dteMMOperationDetailPlanCancelDate;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationDetailPlanCancelStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSMemoEdit fld_medMMOperationDetailPlanCancelDesc;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private MMOperationDetailPlanCancelItemsGridControl fld_dgcMMOperationDetailPlanCancelItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvBatchProductCancelItem;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMLineID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSTextBox fld_txtMMOperationDetailPlanWeek;
        private BOSComponent.BOSLabel bosLabel10;
	}
}
