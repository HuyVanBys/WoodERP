using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.InitializedInventoryStock.UI
{
	/// <summary>
	/// Summary description for DMIS100
	/// </summary>
	partial class DMIS100
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
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeFK_ICStockID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medICProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICInitializedInventoryStockStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICInitializedInventoryStockQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtICInitializedInventoryStockUnitCost = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtFK_ICProductSerieID = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtICProductNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteICInitializedInventoryStockToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICInitializedInventoryStocks = new BOSERP.Modules.InitializedInventoryStock.ICInitializedInventoryStocksGridControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.fld_dteDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInitializedInventoryStockStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInitializedInventoryStockQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInitializedInventoryStockUnitCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFK_ICProductSerieID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInitializedInventoryStockToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInitializedInventoryStockToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInitializedInventoryStocks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDateTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDateTo.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel2.Controls.Add(this.bosGroupControl2);
            this.bosPanel2.Controls.Add(this.bosGroupControl3);
            this.bosPanel2.Controls.Add(this.bosGroupControl1);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 605);
            this.bosPanel2.TabIndex = 10;
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_lkeFK_ICStockID1);
            this.bosGroupControl2.Controls.Add(this.fld_medICProductDesc);
            this.bosGroupControl2.Controls.Add(this.bosLabel8);
            this.bosGroupControl2.Controls.Add(this.fld_lkeICInitializedInventoryStockStatus);
            this.bosGroupControl2.Controls.Add(this.bosLabel7);
            this.bosGroupControl2.Controls.Add(this.fld_txtICInitializedInventoryStockQty);
            this.bosGroupControl2.Controls.Add(this.fld_txtICInitializedInventoryStockUnitCost);
            this.bosGroupControl2.Controls.Add(this.bosLabel6);
            this.bosGroupControl2.Controls.Add(this.bosLabel5);
            this.bosGroupControl2.Controls.Add(this.fld_txtFK_ICProductSerieID);
            this.bosGroupControl2.Controls.Add(this.bosLabel4);
            this.bosGroupControl2.Controls.Add(this.bosLabel3);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductName);
            this.bosGroupControl2.Controls.Add(this.bosLabel2);
            this.bosGroupControl2.Controls.Add(this.fld_txtICProductNo);
            this.bosGroupControl2.Controls.Add(this.fld_lblLabel4);
            this.bosGroupControl2.Controls.Add(this.fld_dteICInitializedInventoryStockToDate);
            this.bosGroupControl2.Controls.Add(this.bosLabel1);
            this.bosGroupControl2.Location = new System.Drawing.Point(6, 78);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl2, true);
            this.bosGroupControl2.Size = new System.Drawing.Size(856, 164);
            this.bosGroupControl2.TabIndex = 14;
            this.bosGroupControl2.Text = "Thông tin chi tiết";
            // 
            // fld_lkeFK_ICStockID1
            // 
            this.fld_lkeFK_ICStockID1.BOSAllowAddNew = false;
            this.fld_lkeFK_ICStockID1.BOSAllowDummy = false;
            this.fld_lkeFK_ICStockID1.BOSComment = null;
            this.fld_lkeFK_ICStockID1.BOSDataMember = "FK_ICStockID";
            this.fld_lkeFK_ICStockID1.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_lkeFK_ICStockID1.BOSDescription = null;
            this.fld_lkeFK_ICStockID1.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICStockID1.BOSFieldGroup = null;
            this.fld_lkeFK_ICStockID1.BOSFieldParent = null;
            this.fld_lkeFK_ICStockID1.BOSFieldRelation = null;
            this.fld_lkeFK_ICStockID1.BOSPrivilege = null;
            this.fld_lkeFK_ICStockID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICStockID1.BOSSelectType = null;
            this.fld_lkeFK_ICStockID1.BOSSelectTypeValue = null;
            this.fld_lkeFK_ICStockID1.CurrentDisplayText = null;
            this.fld_lkeFK_ICStockID1.Location = new System.Drawing.Point(368, 31);
            this.fld_lkeFK_ICStockID1.Name = "fld_lkeFK_ICStockID1";
            this.fld_lkeFK_ICStockID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICStockID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICStockID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.CommonLocalizedResources.String2, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICStockName", "Name")});
            this.fld_lkeFK_ICStockID1.Properties.DisplayMember = "ICStockName";
            this.fld_lkeFK_ICStockID1.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_ICStockID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_ICStockID1.Properties.ReadOnly = true;
            this.fld_lkeFK_ICStockID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICStockID1.Properties.ValueMember = "ICStockID";
            this.fld_lkeFK_ICStockID1.Screen = null;
            this.fld_lkeFK_ICStockID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ICStockID1.TabIndex = 38;
            this.fld_lkeFK_ICStockID1.Tag = "DC";
            // 
            // fld_medICProductDesc
            // 
            this.fld_medICProductDesc.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductDesc.BOSDataMember = "ICProductDesc";
            this.fld_medICProductDesc.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_medICProductDesc.BOSDescription = null;
            this.fld_medICProductDesc.BOSError = null;
            this.fld_medICProductDesc.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductDesc.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductDesc.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductDesc.BOSPropertyName = "Text";
            this.fld_medICProductDesc.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_medICProductDesc.Location = new System.Drawing.Point(103, 112);
            this.fld_medICProductDesc.Name = "fld_medICProductDesc";
            this.fld_medICProductDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medICProductDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medICProductDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medICProductDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medICProductDesc.Properties.ReadOnly = true;
            this.fld_medICProductDesc.Screen = null;
            this.fld_medICProductDesc.Size = new System.Drawing.Size(415, 37);
            this.fld_medICProductDesc.TabIndex = 37;
            this.fld_medICProductDesc.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(9, 119);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(27, 13);
            this.bosLabel8.TabIndex = 36;
            this.bosLabel8.Tag = "SI";
            this.bosLabel8.Text = "Mô tả";
            // 
            // fld_lkeICInitializedInventoryStockStatus
            // 
            this.fld_lkeICInitializedInventoryStockStatus.BOSAllowAddNew = false;
            this.fld_lkeICInitializedInventoryStockStatus.BOSAllowDummy = true;
            this.fld_lkeICInitializedInventoryStockStatus.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.BOSDataMember = "ICInitializedInventoryStockStatus";
            this.fld_lkeICInitializedInventoryStockStatus.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_lkeICInitializedInventoryStockStatus.BOSDescription = null;
            this.fld_lkeICInitializedInventoryStockStatus.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.BOSFieldParent = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.BOSPropertyName = "EditValue";
            this.fld_lkeICInitializedInventoryStockStatus.BOSSelectType = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.BOSSelectTypeValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.CurrentDisplayText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.Location = new System.Drawing.Point(103, 86);
            this.fld_lkeICInitializedInventoryStockStatus.Name = "fld_lkeICInitializedInventoryStockStatus";
            this.fld_lkeICInitializedInventoryStockStatus.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICInitializedInventoryStockStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICInitializedInventoryStockStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICInitializedInventoryStockStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICInitializedInventoryStockStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICInitializedInventoryStockStatus.Properties.DisplayMember = "APSupplierName";
            this.fld_lkeICInitializedInventoryStockStatus.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeICInitializedInventoryStockStatus.Properties.PopupWidth = 40;
            this.fld_lkeICInitializedInventoryStockStatus.Properties.ReadOnly = true;
            this.fld_lkeICInitializedInventoryStockStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICInitializedInventoryStockStatus.Properties.ValueMember = "APSupplierID";
            this.fld_lkeICInitializedInventoryStockStatus.Screen = null;
            this.fld_lkeICInitializedInventoryStockStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeICInitializedInventoryStockStatus.TabIndex = 35;
            this.fld_lkeICInitializedInventoryStockStatus.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseFont = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(9, 89);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(48, 13);
            this.bosLabel7.TabIndex = 34;
            this.bosLabel7.Tag = "SI";
            this.bosLabel7.Text = "Trạng thái";
            // 
            // fld_txtICInitializedInventoryStockQty
            // 
            this.fld_txtICInitializedInventoryStockQty.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockQty.BOSDataMember = "ICInitializedInventoryStockQty";
            this.fld_txtICInitializedInventoryStockQty.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_txtICInitializedInventoryStockQty.BOSDescription = null;
            this.fld_txtICInitializedInventoryStockQty.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockQty.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockQty.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockQty.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockQty.BOSPropertyName = "Text";
            this.fld_txtICInitializedInventoryStockQty.Location = new System.Drawing.Point(636, 60);
            this.fld_txtICInitializedInventoryStockQty.Name = "fld_txtICInitializedInventoryStockQty";
            this.fld_txtICInitializedInventoryStockQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICInitializedInventoryStockQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICInitializedInventoryStockQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICInitializedInventoryStockQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICInitializedInventoryStockQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICInitializedInventoryStockQty.Properties.ReadOnly = true;
            this.fld_txtICInitializedInventoryStockQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICInitializedInventoryStockQty.Screen = null;
            this.fld_txtICInitializedInventoryStockQty.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICInitializedInventoryStockQty.TabIndex = 33;
            this.fld_txtICInitializedInventoryStockQty.Tag = "DC";
            // 
            // fld_txtICInitializedInventoryStockUnitCost
            // 
            this.fld_txtICInitializedInventoryStockUnitCost.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockUnitCost.BOSDataMember = "ICInitializedInventoryStockUnitCost";
            this.fld_txtICInitializedInventoryStockUnitCost.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_txtICInitializedInventoryStockUnitCost.BOSDescription = null;
            this.fld_txtICInitializedInventoryStockUnitCost.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockUnitCost.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockUnitCost.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockUnitCost.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICInitializedInventoryStockUnitCost.BOSPropertyName = "Text";
            this.fld_txtICInitializedInventoryStockUnitCost.Location = new System.Drawing.Point(636, 31);
            this.fld_txtICInitializedInventoryStockUnitCost.Name = "fld_txtICInitializedInventoryStockUnitCost";
            this.fld_txtICInitializedInventoryStockUnitCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICInitializedInventoryStockUnitCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICInitializedInventoryStockUnitCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICInitializedInventoryStockUnitCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICInitializedInventoryStockUnitCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICInitializedInventoryStockUnitCost.Properties.ReadOnly = true;
            this.fld_txtICInitializedInventoryStockUnitCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICInitializedInventoryStockUnitCost.Screen = null;
            this.fld_txtICInitializedInventoryStockUnitCost.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICInitializedInventoryStockUnitCost.TabIndex = 32;
            this.fld_txtICInitializedInventoryStockUnitCost.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseFont = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(538, 63);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(42, 13);
            this.bosLabel6.TabIndex = 31;
            this.bosLabel6.Tag = "SI";
            this.bosLabel6.Text = "Số lượng";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(538, 34);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(58, 13);
            this.bosLabel5.TabIndex = 30;
            this.bosLabel5.Tag = "SI";
            this.bosLabel5.Text = "Đơn giá gốc";
            // 
            // fld_txtFK_ICProductSerieID
            // 
            this.fld_txtFK_ICProductSerieID.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtFK_ICProductSerieID.BOSDataMember = "FK_ICProductSerieID";
            this.fld_txtFK_ICProductSerieID.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_txtFK_ICProductSerieID.BOSDescription = null;
            this.fld_txtFK_ICProductSerieID.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtFK_ICProductSerieID.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtFK_ICProductSerieID.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtFK_ICProductSerieID.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtFK_ICProductSerieID.BOSPropertyName = "Text";
            this.fld_txtFK_ICProductSerieID.Location = new System.Drawing.Point(368, 60);
            this.fld_txtFK_ICProductSerieID.Name = "fld_txtFK_ICProductSerieID";
            this.fld_txtFK_ICProductSerieID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtFK_ICProductSerieID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtFK_ICProductSerieID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtFK_ICProductSerieID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtFK_ICProductSerieID.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtFK_ICProductSerieID.Properties.ReadOnly = true;
            this.fld_txtFK_ICProductSerieID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtFK_ICProductSerieID.Screen = null;
            this.fld_txtFK_ICProductSerieID.Size = new System.Drawing.Size(150, 20);
            this.fld_txtFK_ICProductSerieID.TabIndex = 29;
            this.fld_txtFK_ICProductSerieID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(281, 63);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(26, 13);
            this.bosLabel4.TabIndex = 27;
            this.bosLabel4.Tag = "SI";
            this.bosLabel4.Text = "Mã lô";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(281, 34);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(19, 13);
            this.bosLabel3.TabIndex = 26;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Kho";
            // 
            // fld_txtICProductName
            // 
            this.fld_txtICProductName.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductName.BOSDataMember = "ICProductName";
            this.fld_txtICProductName.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_txtICProductName.BOSDescription = null;
            this.fld_txtICProductName.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductName.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductName.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductName.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductName.BOSPropertyName = "Text";
            this.fld_txtICProductName.Location = new System.Drawing.Point(103, 60);
            this.fld_txtICProductName.Name = "fld_txtICProductName";
            this.fld_txtICProductName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductName.Properties.ReadOnly = true;
            this.fld_txtICProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductName.Screen = null;
            this.fld_txtICProductName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductName.TabIndex = 25;
            this.fld_txtICProductName.Tag = "DC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(9, 63);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(68, 13);
            this.bosLabel2.TabIndex = 24;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Tên sản phẩm";
            // 
            // fld_txtICProductNo
            // 
            this.fld_txtICProductNo.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSDataMember = "ICProductNo";
            this.fld_txtICProductNo.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_txtICProductNo.BOSDescription = null;
            this.fld_txtICProductNo.BOSError = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtICProductNo.BOSPropertyName = "Text";
            this.fld_txtICProductNo.Location = new System.Drawing.Point(103, 31);
            this.fld_txtICProductNo.Name = "fld_txtICProductNo";
            this.fld_txtICProductNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtICProductNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtICProductNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtICProductNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtICProductNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtICProductNo.Properties.ReadOnly = true;
            this.fld_txtICProductNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtICProductNo.Screen = null;
            this.fld_txtICProductNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtICProductNo.TabIndex = 23;
            this.fld_txtICProductNo.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDataMember = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDataSource = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(9, 34);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel4.TabIndex = 22;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Mã sản phẩm";
            // 
            // fld_dteICInitializedInventoryStockToDate
            // 
            this.fld_dteICInitializedInventoryStockToDate.BOSComment = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSDataMember = "ICInitializedInventoryStockToDate";
            this.fld_dteICInitializedInventoryStockToDate.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_dteICInitializedInventoryStockToDate.BOSDescription = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSError = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSFieldGroup = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSFieldRelation = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSPrivilege = null;
            this.fld_dteICInitializedInventoryStockToDate.BOSPropertyName = "EditValue";
            this.fld_dteICInitializedInventoryStockToDate.EditValue = null;
            this.fld_dteICInitializedInventoryStockToDate.Location = new System.Drawing.Point(368, 86);
            this.fld_dteICInitializedInventoryStockToDate.Name = "fld_dteICInitializedInventoryStockToDate";
            this.fld_dteICInitializedInventoryStockToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteICInitializedInventoryStockToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteICInitializedInventoryStockToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteICInitializedInventoryStockToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteICInitializedInventoryStockToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteICInitializedInventoryStockToDate.Properties.ReadOnly = true;
            this.fld_dteICInitializedInventoryStockToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteICInitializedInventoryStockToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteICInitializedInventoryStockToDate, true);
            this.fld_dteICInitializedInventoryStockToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteICInitializedInventoryStockToDate.TabIndex = 21;
            this.fld_dteICInitializedInventoryStockToDate.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(281, 89);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(47, 13);
            this.bosLabel1.TabIndex = 18;
            this.bosLabel1.Text = "Đến ngày";
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosGroupControl3.BOSComment = null;
            this.bosGroupControl3.BOSDataMember = null;
            this.bosGroupControl3.BOSDataSource = null;
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = null;
            this.bosGroupControl3.BOSFieldRelation = null;
            this.bosGroupControl3.BOSPrivilege = null;
            this.bosGroupControl3.BOSPropertyName = null;
            this.bosGroupControl3.Controls.Add(this.fld_dgcICInitializedInventoryStocks);
            this.bosGroupControl3.Location = new System.Drawing.Point(3, 248);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl3, true);
            this.bosGroupControl3.Size = new System.Drawing.Size(856, 354);
            this.bosGroupControl3.TabIndex = 13;
            this.bosGroupControl3.Text = "Danh sách số dư tồn kho";
            // 
            // fld_dgcICInitializedInventoryStocks
            // 
            this.fld_dgcICInitializedInventoryStocks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICInitializedInventoryStocks.BOSComment = null;
            this.fld_dgcICInitializedInventoryStocks.BOSDataMember = null;
            this.fld_dgcICInitializedInventoryStocks.BOSDataSource = "ICInitializedInventoryStocks";
            this.fld_dgcICInitializedInventoryStocks.BOSDescription = null;
            this.fld_dgcICInitializedInventoryStocks.BOSError = null;
            this.fld_dgcICInitializedInventoryStocks.BOSFieldGroup = null;
            this.fld_dgcICInitializedInventoryStocks.BOSFieldRelation = null;
            this.fld_dgcICInitializedInventoryStocks.BOSGridType = null;
            this.fld_dgcICInitializedInventoryStocks.BOSPrivilege = null;
            this.fld_dgcICInitializedInventoryStocks.BOSPropertyName = null;
            this.fld_dgcICInitializedInventoryStocks.Location = new System.Drawing.Point(5, 25);
            this.fld_dgcICInitializedInventoryStocks.MenuManager = this.screenToolbar;
            this.fld_dgcICInitializedInventoryStocks.Name = "fld_dgcICInitializedInventoryStocks";
            this.fld_dgcICInitializedInventoryStocks.PrintReport = false;
            this.fld_dgcICInitializedInventoryStocks.Screen = null;
            this.fld_dgcICInitializedInventoryStocks.Size = new System.Drawing.Size(851, 324);
            this.fld_dgcICInitializedInventoryStocks.TabIndex = 0;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
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
            this.bosGroupControl1.Controls.Add(this.fld_btnShow);
            this.bosGroupControl1.Controls.Add(this.fld_dteDateTo);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel62);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosGroupControl1, true);
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 69);
            this.bosGroupControl1.TabIndex = 11;
            this.bosGroupControl1.Text = "Tìm kiếm";
            // 
            // fld_btnShow
            // 
            this.fld_btnShow.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShow.Appearance.Options.UseForeColor = true;
            this.fld_btnShow.BOSComment = null;
            this.fld_btnShow.BOSDataMember = null;
            this.fld_btnShow.BOSDataSource = null;
            this.fld_btnShow.BOSDescription = null;
            this.fld_btnShow.BOSError = null;
            this.fld_btnShow.BOSFieldGroup = null;
            this.fld_btnShow.BOSFieldRelation = null;
            this.fld_btnShow.BOSPrivilege = null;
            this.fld_btnShow.BOSPropertyName = null;
            this.fld_btnShow.Location = new System.Drawing.Point(259, 25);
            this.fld_btnShow.Name = "fld_btnShow";
            this.fld_btnShow.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShow, true);
            this.fld_btnShow.Size = new System.Drawing.Size(75, 27);
            this.fld_btnShow.TabIndex = 19;
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
            // 
            // fld_dteDateTo
            // 
            this.fld_dteDateTo.BOSComment = null;
            this.fld_dteDateTo.BOSDataMember = "DateEdit";
            this.fld_dteDateTo.BOSDataSource = null;
            this.fld_dteDateTo.BOSDescription = null;
            this.fld_dteDateTo.BOSError = null;
            this.fld_dteDateTo.BOSFieldGroup = null;
            this.fld_dteDateTo.BOSFieldRelation = null;
            this.fld_dteDateTo.BOSPrivilege = null;
            this.fld_dteDateTo.BOSPropertyName = "EditValue";
            this.fld_dteDateTo.EditValue = null;
            this.fld_dteDateTo.Location = new System.Drawing.Point(79, 31);
            this.fld_dteDateTo.Name = "fld_dteDateTo";
            this.fld_dteDateTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteDateTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteDateTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteDateTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteDateTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteDateTo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteDateTo, true);
            this.fld_dteDateTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteDateTo.TabIndex = 21;
            this.fld_dteDateTo.Tag = "DC";
            // 
            // fld_lblLabel62
            // 
            this.fld_lblLabel62.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel62.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel62.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel62.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel62.BOSComment = null;
            this.fld_lblLabel62.BOSDataMember = null;
            this.fld_lblLabel62.BOSDataSource = null;
            this.fld_lblLabel62.BOSDescription = null;
            this.fld_lblLabel62.BOSError = null;
            this.fld_lblLabel62.BOSFieldGroup = null;
            this.fld_lblLabel62.BOSFieldRelation = null;
            this.fld_lblLabel62.BOSPrivilege = null;
            this.fld_lblLabel62.BOSPropertyName = null;
            this.fld_lblLabel62.Location = new System.Drawing.Point(12, 34);
            this.fld_lblLabel62.Name = "fld_lblLabel62";
            this.fld_lblLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel62, true);
            this.fld_lblLabel62.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel62.TabIndex = 18;
            this.fld_lblLabel62.Text = "Đến ngày";
            // 
            // DMIS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 603);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMIS100";
            this.Text = "Thông tin khách hàng thay đổi";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.bosPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            this.bosGroupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICStockID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medICProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICInitializedInventoryStockStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInitializedInventoryStockQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICInitializedInventoryStockUnitCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtFK_ICProductSerieID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtICProductNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInitializedInventoryStockToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteICInitializedInventoryStockToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICInitializedInventoryStocks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDateTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteDateTo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteDateTo;
        private BOSComponent.BOSButton fld_btnShow;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private ICInitializedInventoryStocksGridControl fld_dgcICInitializedInventoryStocks;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private BOSComponent.BOSDateEdit fld_dteICInitializedInventoryStockToDate;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtICProductName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtICProductNo;
        private BOSComponent.BOSTextBox fld_txtICInitializedInventoryStockQty;
        private BOSComponent.BOSTextBox fld_txtICInitializedInventoryStockUnitCost;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtFK_ICProductSerieID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeICInitializedInventoryStockStatus;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSMemoEdit fld_medICProductDesc;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICStockID1;
	}
}
