using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.WoodPlan.UI
{
	/// <summary>
	/// Summary description for DMWP100
	/// </summary>
	partial class DMWP100
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
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_lkeMaterials = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMaterialsChange = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnChangeMaterials = new BOSComponent.BOSButton(this.components);
            this.fld_txtTotalMaterialQtyChange = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtTotalMaterialQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosButton1 = new BOSComponent.BOSButton(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMLineID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_btnUpdateInventoryStock = new BOSComponent.BOSButton(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.fld_dgcWoodPlans = new BOSERP.Modules.WoodPlan.MMWoodPlanItemsGridControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lkeICProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMWoodPlanItemDetails = new BOSERP.Modules.WoodPlan.MMWoodPlanItemDetailsGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcWoodPlanItemDetail = new BOSERP.Modules.WoodPlan.MMWoodPlanItemDetailMainsGridControl();
            this.fld_lkeFK_MMOperationDetailPlanID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARSaleOrderID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ARCustomerID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMWoodPlanStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMBatchItemPlanDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMWoodPlanProductQty = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMWoodPlanDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMWoodPlanNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterials.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterialsChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTotalMaterialQtyChange.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTotalMaterialQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcWoodPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMWoodPlanItemDetails)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcWoodPlanItemDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationDetailPlanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWoodPlanStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMBatchItemPlanDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWoodPlanProductQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWoodPlanNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.bosTextBox2);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosButton1);
            this.bosPanel1.Controls.Add(this.bosLabel11);
            this.bosPanel1.Controls.Add(this.bosLabel13);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMLineID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosPanel1.Controls.Add(this.bosTextBox1);
            this.bosPanel1.Controls.Add(this.bosLabel12);
            this.bosPanel1.Controls.Add(this.fld_lbWoodType);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.bosPanel1.Controls.Add(this.fld_btnUpdateInventoryStock);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMOperationDetailPlanID);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_lblLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARSaleOrderID);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ARCustomerID);
            this.bosPanel1.Controls.Add(this.fld_lkeMMWoodPlanStatus);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_medMMBatchItemPlanDesc);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeMMWoodPlanProductQty);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_dteMMWoodPlanDate);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtMMWoodPlanNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1275, 600);
            this.bosPanel1.TabIndex = 6;
            // 
            // bosLine1
            // 
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_lkeMaterials);
            this.bosLine1.Controls.Add(this.fld_lkeMaterialsChange);
            this.bosLine1.Controls.Add(this.fld_btnChangeMaterials);
            this.bosLine1.Controls.Add(this.fld_txtTotalMaterialQtyChange);
            this.bosLine1.Controls.Add(this.fld_txtTotalMaterialQty);
            this.bosLine1.Controls.Add(this.bosLabel16);
            this.bosLine1.Controls.Add(this.bosLabel17);
            this.bosLine1.Controls.Add(this.bosLabel14);
            this.bosLine1.Controls.Add(this.bosLabel15);
            this.bosLine1.Location = new System.Drawing.Point(896, 12);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(367, 138);
            this.bosLine1.TabIndex = 577;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thay đổi nguyên liệu";
            // 
            // fld_lkeMaterials
            // 
            this.fld_lkeMaterials.BOSAllowAddNew = false;
            this.fld_lkeMaterials.BOSAllowDummy = true;
            this.fld_lkeMaterials.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterials.BOSDataMember = "ICProductName";
            this.fld_lkeMaterials.BOSDataSource = "ICProducts";
            this.fld_lkeMaterials.BOSDescription = null;
            this.fld_lkeMaterials.BOSError = null;
            this.fld_lkeMaterials.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterials.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterials.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterials.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterials.BOSPropertyName = "EditValue";
            this.fld_lkeMaterials.BOSSelectType = "ICProductType";
            this.fld_lkeMaterials.BOSSelectTypeValue = "Ingredient;Lumber;Roundwood;Reuse;Verneer;ArtificialBoard;Detail";
            this.fld_lkeMaterials.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterials.Location = new System.Drawing.Point(120, 20);
            this.fld_lkeMaterials.Name = "fld_lkeMaterials";
            this.fld_lkeMaterials.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMaterials.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMaterials.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMaterials.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMaterials.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMaterials.Properties.ColumnName = null;
            this.fld_lkeMaterials.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên")});
            this.fld_lkeMaterials.Properties.DisplayMember = "ICProductName";
            this.fld_lkeMaterials.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterials.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMaterials.Properties.ValueMember = "ICProductID";
            this.fld_lkeMaterials.Screen = null;
            this.fld_lkeMaterials.Size = new System.Drawing.Size(119, 20);
            this.fld_lkeMaterials.TabIndex = 584;
            this.fld_lkeMaterials.Tag = "DC";
            this.fld_lkeMaterials.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.fld_lkeMaterials_Closed);
            // 
            // fld_lkeMaterialsChange
            // 
            this.fld_lkeMaterialsChange.BOSAllowAddNew = false;
            this.fld_lkeMaterialsChange.BOSAllowDummy = true;
            this.fld_lkeMaterialsChange.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterialsChange.BOSDataMember = "ICProductName";
            this.fld_lkeMaterialsChange.BOSDataSource = "ICProducts";
            this.fld_lkeMaterialsChange.BOSDescription = null;
            this.fld_lkeMaterialsChange.BOSError = null;
            this.fld_lkeMaterialsChange.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterialsChange.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterialsChange.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterialsChange.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterialsChange.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterialsChange.BOSSelectType = "ICProductType";
            this.fld_lkeMaterialsChange.BOSSelectTypeValue = "Ingredient;Lumber;Roundwood;Reuse;Verneer;ArtificialBoard;Detail";
            this.fld_lkeMaterialsChange.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterialsChange.Location = new System.Drawing.Point(120, 46);
            this.fld_lkeMaterialsChange.Name = "fld_lkeMaterialsChange";
            this.fld_lkeMaterialsChange.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMaterialsChange.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMaterialsChange.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMaterialsChange.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMaterialsChange.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMaterialsChange.Properties.ColumnName = null;
            this.fld_lkeMaterialsChange.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên")});
            this.fld_lkeMaterialsChange.Properties.DisplayMember = "ICProductName";
            this.fld_lkeMaterialsChange.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMaterialsChange.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMaterialsChange.Properties.ValueMember = "ICProductID";
            this.fld_lkeMaterialsChange.Screen = null;
            this.fld_lkeMaterialsChange.Size = new System.Drawing.Size(119, 20);
            this.fld_lkeMaterialsChange.TabIndex = 583;
            this.fld_lkeMaterialsChange.Tag = "DC";
            // 
            // fld_btnChangeMaterials
            // 
            this.fld_btnChangeMaterials.BOSComment = null;
            this.fld_btnChangeMaterials.BOSDataMember = null;
            this.fld_btnChangeMaterials.BOSDataSource = null;
            this.fld_btnChangeMaterials.BOSDescription = null;
            this.fld_btnChangeMaterials.BOSError = null;
            this.fld_btnChangeMaterials.BOSFieldGroup = null;
            this.fld_btnChangeMaterials.BOSFieldRelation = null;
            this.fld_btnChangeMaterials.BOSPrivilege = null;
            this.fld_btnChangeMaterials.BOSPropertyName = null;
            this.fld_btnChangeMaterials.Location = new System.Drawing.Point(255, 80);
            this.fld_btnChangeMaterials.Name = "fld_btnChangeMaterials";
            this.fld_btnChangeMaterials.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnChangeMaterials, true);
            this.fld_btnChangeMaterials.Size = new System.Drawing.Size(106, 27);
            this.fld_btnChangeMaterials.TabIndex = 582;
            this.fld_btnChangeMaterials.Text = "Thay đổi nguyên liệu";
            this.fld_btnChangeMaterials.Click += new System.EventHandler(this.fld_btnChangeMaterials_Click);
            // 
            // fld_txtTotalMaterialQtyChange
            // 
            this.fld_txtTotalMaterialQtyChange.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQtyChange.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQtyChange.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQtyChange.BOSDescription = null;
            this.fld_txtTotalMaterialQtyChange.BOSError = null;
            this.fld_txtTotalMaterialQtyChange.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQtyChange.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQtyChange.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQtyChange.BOSPropertyName = "Text";
            this.fld_txtTotalMaterialQtyChange.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQtyChange.Location = new System.Drawing.Point(311, 46);
            this.fld_txtTotalMaterialQtyChange.Name = "fld_txtTotalMaterialQtyChange";
            this.fld_txtTotalMaterialQtyChange.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtTotalMaterialQtyChange.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtTotalMaterialQtyChange.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtTotalMaterialQtyChange.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtTotalMaterialQtyChange.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtTotalMaterialQtyChange.Properties.NullText = "0";
            this.fld_txtTotalMaterialQtyChange.Properties.NullValuePrompt = "0";
            this.fld_txtTotalMaterialQtyChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtTotalMaterialQtyChange.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtTotalMaterialQtyChange, true);
            this.fld_txtTotalMaterialQtyChange.Size = new System.Drawing.Size(50, 20);
            this.fld_txtTotalMaterialQtyChange.TabIndex = 581;
            this.fld_txtTotalMaterialQtyChange.Tag = "DC";
            // 
            // fld_txtTotalMaterialQty
            // 
            this.fld_txtTotalMaterialQty.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQty.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQty.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQty.BOSDescription = null;
            this.fld_txtTotalMaterialQty.BOSError = null;
            this.fld_txtTotalMaterialQty.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQty.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQty.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQty.BOSPropertyName = "Text";
            this.fld_txtTotalMaterialQty.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtTotalMaterialQty.Location = new System.Drawing.Point(311, 20);
            this.fld_txtTotalMaterialQty.Name = "fld_txtTotalMaterialQty";
            this.fld_txtTotalMaterialQty.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_txtTotalMaterialQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtTotalMaterialQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtTotalMaterialQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtTotalMaterialQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtTotalMaterialQty.Properties.ReadOnly = true;
            this.fld_txtTotalMaterialQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtTotalMaterialQty.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtTotalMaterialQty, true);
            this.fld_txtTotalMaterialQty.Size = new System.Drawing.Size(50, 20);
            this.fld_txtTotalMaterialQty.TabIndex = 580;
            this.fld_txtTotalMaterialQty.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(255, 49);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(50, 13);
            this.bosLabel16.TabIndex = 578;
            this.bosLabel16.Text = "Khối lượng";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(255, 23);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(50, 13);
            this.bosLabel17.TabIndex = 579;
            this.bosLabel17.Text = "Khối lượng";
            // 
            // bosLabel14
            // 
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(20, 49);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(96, 13);
            this.bosLabel14.TabIndex = 576;
            this.bosLabel14.Text = "NL dùng để thay đổi";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(20, 23);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(74, 13);
            this.bosLabel15.TabIndex = 577;
            this.bosLabel15.Text = "NL cần thay đổi";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSDataMember = "MMWoodPlanBatchProductNo";
            this.bosTextBox2.BOSDataSource = "MMWoodPlans";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox2.Location = new System.Drawing.Point(63, 64);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(361, 20);
            this.bosTextBox2.TabIndex = 575;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseFont = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Location = new System.Drawing.Point(14, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(38, 13);
            this.bosLabel4.TabIndex = 576;
            this.bosLabel4.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Text = "Mã LSX";
            // 
            // bosButton1
            // 
            this.bosButton1.BOSComment = null;
            this.bosButton1.BOSDataMember = null;
            this.bosButton1.BOSDataSource = null;
            this.bosButton1.BOSDescription = null;
            this.bosButton1.BOSError = null;
            this.bosButton1.BOSFieldGroup = null;
            this.bosButton1.BOSFieldRelation = null;
            this.bosButton1.BOSPrivilege = null;
            this.bosButton1.BOSPropertyName = null;
            this.bosButton1.Location = new System.Drawing.Point(730, 123);
            this.bosButton1.Name = "bosButton1";
            this.bosButton1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosButton1, true);
            this.bosButton1.Size = new System.Drawing.Size(149, 27);
            this.bosButton1.TabIndex = 574;
            this.bosButton1.Text = "Chọn LSX";
            this.bosButton1.Click += new System.EventHandler(this.bosButton1_Click);
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
            this.bosLabel11.Location = new System.Drawing.Point(664, 67);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(37, 13);
            this.bosLabel11.TabIndex = 572;
            this.bosLabel11.Text = "Chuyền";
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
            this.bosLabel13.Location = new System.Drawing.Point(664, 41);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(31, 13);
            this.bosLabel13.TabIndex = 573;
            this.bosLabel13.Text = "Xưởng";
            // 
            // fld_lkeFK_MMLineID
            // 
            this.fld_lkeFK_MMLineID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMLineID.BOSAllowDummy = false;
            this.fld_lkeFK_MMLineID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_MMLineID.BOSDataSource = "MMWoodPlans";
            this.fld_lkeFK_MMLineID.BOSDescription = null;
            this.fld_lkeFK_MMLineID.BOSError = null;
            this.fld_lkeFK_MMLineID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMLineID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.Location = new System.Drawing.Point(730, 64);
            this.fld_lkeFK_MMLineID.Name = "fld_lkeFK_MMLineID";
            this.fld_lkeFK_MMLineID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMLineID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMLineID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMLineID.Properties.ColumnName = null;
            this.fld_lkeFK_MMLineID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMLineName", "Tên")});
            this.fld_lkeFK_MMLineID.Properties.DisplayMember = "MMLineName";
            this.fld_lkeFK_MMLineID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMLineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMLineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_MMLineID.Screen = null;
            this.fld_lkeFK_MMLineID.Size = new System.Drawing.Size(149, 20);
            this.fld_lkeFK_MMLineID.TabIndex = 571;
            this.fld_lkeFK_MMLineID.Tag = "DC";
            this.fld_lkeFK_MMLineID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMLineID_CloseUp);
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = false;
            this.fld_lkeFK_MMWorkShopID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMWoodPlans";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(730, 38);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(149, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 570;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            this.fld_lkeFK_MMWorkShopID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMWorkShopID_CloseUp);
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSDataMember = "MMWoodPlanPONo";
            this.bosTextBox1.BOSDataSource = "MMWoodPlans";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.Location = new System.Drawing.Point(500, 90);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(141, 20);
            this.bosTextBox1.TabIndex = 10;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.Location = new System.Drawing.Point(438, 93);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(51, 13);
            this.bosLabel12.TabIndex = 569;
            this.bosLabel12.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel12.Text = " Số PO.No";
            // 
            // fld_lbWoodType
            // 
            this.fld_lbWoodType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbWoodType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbWoodType.Appearance.Options.UseBackColor = true;
            this.fld_lbWoodType.Appearance.Options.UseForeColor = true;
            this.fld_lbWoodType.BOSComment = null;
            this.fld_lbWoodType.BOSDataMember = null;
            this.fld_lbWoodType.BOSDataSource = null;
            this.fld_lbWoodType.BOSDescription = null;
            this.fld_lbWoodType.BOSError = null;
            this.fld_lbWoodType.BOSFieldGroup = null;
            this.fld_lbWoodType.BOSFieldRelation = null;
            this.fld_lbWoodType.BOSPrivilege = null;
            this.fld_lbWoodType.BOSPropertyName = null;
            this.fld_lbWoodType.Location = new System.Drawing.Point(438, 67);
            this.fld_lbWoodType.Name = "fld_lbWoodType";
            this.fld_lbWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbWoodType, true);
            this.fld_lbWoodType.Size = new System.Drawing.Size(26, 13);
            this.fld_lbWoodType.TabIndex = 567;
            this.fld_lbWoodType.Text = "TTMT";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "MMWoodPlans";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDescription = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSError = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldGroup = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldParent = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSFieldRelation = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPrivilege = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectType = "ICProductAttributeGroup";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSSelectTypeValue = "TTMT";
            this.fld_lkeFK_ICProductAttributeTTMTID.CurrentDisplayText = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(500, 64);
            this.fld_lkeFK_ICProductAttributeTTMTID.Name = "fld_lkeFK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ColumnName = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "TTMT")});
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 8;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            // 
            // fld_btnUpdateInventoryStock
            // 
            this.fld_btnUpdateInventoryStock.BOSComment = null;
            this.fld_btnUpdateInventoryStock.BOSDataMember = null;
            this.fld_btnUpdateInventoryStock.BOSDataSource = null;
            this.fld_btnUpdateInventoryStock.BOSDescription = null;
            this.fld_btnUpdateInventoryStock.BOSError = null;
            this.fld_btnUpdateInventoryStock.BOSFieldGroup = null;
            this.fld_btnUpdateInventoryStock.BOSFieldRelation = null;
            this.fld_btnUpdateInventoryStock.BOSPrivilege = null;
            this.fld_btnUpdateInventoryStock.BOSPropertyName = null;
            this.fld_btnUpdateInventoryStock.Location = new System.Drawing.Point(730, 90);
            this.fld_btnUpdateInventoryStock.Name = "fld_btnUpdateInventoryStock";
            this.fld_btnUpdateInventoryStock.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnUpdateInventoryStock, true);
            this.fld_btnUpdateInventoryStock.Size = new System.Drawing.Size(149, 27);
            this.fld_btnUpdateInventoryStock.TabIndex = 553;
            this.fld_btnUpdateInventoryStock.Text = "Xem tồn kho thời điểm";
            this.fld_btnUpdateInventoryStock.Click += new System.EventHandler(this.fld_btnUpdateInventoryStock_Click);
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Location = new System.Drawing.Point(3, 156);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(1269, 444);
            this.bosTabControl1.TabIndex = 111;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.splitContainerControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1262, 415);
            this.xtraTabPage1.Text = "Định mức gỗ";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcWoodPlans);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.bosGroupControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1262, 415);
            this.splitContainerControl1.SplitterPosition = 487;
            this.splitContainerControl1.TabIndex = 110;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // fld_dgcWoodPlans
            // 
            this.fld_dgcWoodPlans.BOSComment = null;
            this.fld_dgcWoodPlans.BOSDataMember = null;
            this.fld_dgcWoodPlans.BOSDataSource = "MMWoodPlanItems";
            this.fld_dgcWoodPlans.BOSDescription = null;
            this.fld_dgcWoodPlans.BOSError = null;
            this.fld_dgcWoodPlans.BOSFieldGroup = null;
            this.fld_dgcWoodPlans.BOSFieldRelation = null;
            this.fld_dgcWoodPlans.BOSGridType = null;
            this.fld_dgcWoodPlans.BOSPrivilege = null;
            this.fld_dgcWoodPlans.BOSPropertyName = null;
            this.fld_dgcWoodPlans.CommodityType = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcWoodPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcWoodPlans.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcWoodPlans.MenuManager = this.screenToolbar;
            this.fld_dgcWoodPlans.Name = "fld_dgcWoodPlans";
            this.fld_dgcWoodPlans.PrintReport = false;
            this.fld_dgcWoodPlans.Screen = null;
            this.fld_dgcWoodPlans.Size = new System.Drawing.Size(487, 415);
            this.fld_dgcWoodPlans.TabIndex = 0;
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_lkeICProductID);
            this.bosGroupControl1.Controls.Add(this.bosLabel8);
            this.bosGroupControl1.Controls.Add(this.fld_dgcMMWoodPlanItemDetails);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(769, 415);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Thông tin chi tiết";
            // 
            // fld_lkeICProductID
            // 
            this.fld_lkeICProductID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeICProductID.BOSAllowAddNew = false;
            this.fld_lkeICProductID.BOSAllowDummy = true;
            this.fld_lkeICProductID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.BOSDataMember = "ICProductID";
            this.fld_lkeICProductID.BOSDataSource = "ICProducts";
            this.fld_lkeICProductID.BOSDescription = null;
            this.fld_lkeICProductID.BOSError = null;
            this.fld_lkeICProductID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductID.BOSSelectType = "FK_ICDepartmentID";
            this.fld_lkeICProductID.BOSSelectTypeValue = "4";
            this.fld_lkeICProductID.CurrentDisplayText = null;
            this.fld_lkeICProductID.Location = new System.Drawing.Point(97, 25);
            this.fld_lkeICProductID.Name = "fld_lkeICProductID";
            this.fld_lkeICProductID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeICProductID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeICProductID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeICProductID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeICProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductID.Properties.ColumnName = null;
            this.fld_lkeICProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNo", "Mã sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductNoOfOldSys", "Mã HT củ"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên sản phẩm"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductDesc", "Mô tả")});
            this.fld_lkeICProductID.Properties.DisplayMember = "ICProductName";
            this.fld_lkeICProductID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeICProductID.Properties.PopupWidth = 40;
            this.fld_lkeICProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeICProductID.Properties.ValueMember = "ICProductID";
            this.fld_lkeICProductID.Screen = null;
            this.fld_lkeICProductID.Size = new System.Drawing.Size(669, 20);
            this.fld_lkeICProductID.TabIndex = 0;
            this.fld_lkeICProductID.Tag = "DC";
            this.fld_lkeICProductID.Visible = false;
            this.fld_lkeICProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductID_KeyUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(14, 28);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(77, 13);
            this.bosLabel8.TabIndex = 1;
            this.bosLabel8.Tag = global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.Text = "Nguyên phụ liệu";
            this.bosLabel8.Visible = false;
            // 
            // fld_dgcMMWoodPlanItemDetails
            // 
            this.fld_dgcMMWoodPlanItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMWoodPlanItemDetails.BOSComment = null;
            this.fld_dgcMMWoodPlanItemDetails.BOSDataMember = null;
            this.fld_dgcMMWoodPlanItemDetails.BOSDataSource = "MMWoodPlanItemDetails";
            this.fld_dgcMMWoodPlanItemDetails.BOSDescription = null;
            this.fld_dgcMMWoodPlanItemDetails.BOSError = null;
            this.fld_dgcMMWoodPlanItemDetails.BOSFieldGroup = null;
            this.fld_dgcMMWoodPlanItemDetails.BOSFieldRelation = null;
            this.fld_dgcMMWoodPlanItemDetails.BOSGridType = null;
            this.fld_dgcMMWoodPlanItemDetails.BOSPrivilege = null;
            this.fld_dgcMMWoodPlanItemDetails.BOSPropertyName = null;
            this.fld_dgcMMWoodPlanItemDetails.CommodityType = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMWoodPlanItemDetails.Location = new System.Drawing.Point(2, 51);
            this.fld_dgcMMWoodPlanItemDetails.MenuManager = this.screenToolbar;
            this.fld_dgcMMWoodPlanItemDetails.Name = "fld_dgcMMWoodPlanItemDetails";
            this.fld_dgcMMWoodPlanItemDetails.PrintReport = false;
            this.fld_dgcMMWoodPlanItemDetails.Screen = null;
            this.fld_dgcMMWoodPlanItemDetails.Size = new System.Drawing.Size(767, 362);
            this.fld_dgcMMWoodPlanItemDetails.TabIndex = 1;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcWoodPlanItemDetail);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1262, 415);
            this.xtraTabPage2.Text = "Nguyên liệu";
            // 
            // fld_dgcWoodPlanItemDetail
            // 
            this.fld_dgcWoodPlanItemDetail.BOSComment = null;
            this.fld_dgcWoodPlanItemDetail.BOSDataMember = null;
            this.fld_dgcWoodPlanItemDetail.BOSDataSource = "MMWoodPlanItemDetails";
            this.fld_dgcWoodPlanItemDetail.BOSDescription = null;
            this.fld_dgcWoodPlanItemDetail.BOSError = null;
            this.fld_dgcWoodPlanItemDetail.BOSFieldGroup = null;
            this.fld_dgcWoodPlanItemDetail.BOSFieldRelation = null;
            this.fld_dgcWoodPlanItemDetail.BOSGridType = null;
            this.fld_dgcWoodPlanItemDetail.BOSPrivilege = null;
            this.fld_dgcWoodPlanItemDetail.BOSPropertyName = null;
            this.fld_dgcWoodPlanItemDetail.CommodityType = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcWoodPlanItemDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcWoodPlanItemDetail.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcWoodPlanItemDetail.MenuManager = this.screenToolbar;
            this.fld_dgcWoodPlanItemDetail.Name = "fld_dgcWoodPlanItemDetail";
            this.fld_dgcWoodPlanItemDetail.PrintReport = false;
            this.fld_dgcWoodPlanItemDetail.Screen = null;
            this.fld_dgcWoodPlanItemDetail.Size = new System.Drawing.Size(1262, 415);
            this.fld_dgcWoodPlanItemDetail.TabIndex = 1;
            // 
            // fld_lkeFK_MMOperationDetailPlanID
            // 
            this.fld_lkeFK_MMOperationDetailPlanID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSAllowDummy = false;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSComment = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSDataMember = "FK_MMOperationDetailPlanID";
            this.fld_lkeFK_MMOperationDetailPlanID.BOSDataSource = "MMWoodPlans";
            this.fld_lkeFK_MMOperationDetailPlanID.BOSDescription = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSError = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationDetailPlanID.BOSSelectType = null;
            this.fld_lkeFK_MMOperationDetailPlanID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMOperationDetailPlanID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationDetailPlanID.Location = new System.Drawing.Point(730, 12);
            this.fld_lkeFK_MMOperationDetailPlanID.Name = "fld_lkeFK_MMOperationDetailPlanID";
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationDetailPlanNo", "Mã KHSX"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationDetailPlanWeek", "Tuần"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationDetailPlanDesc", "Ghi chú")});
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.DisplayMember = "MMOperationDetailPlanNo";
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.ReadOnly = true;
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationDetailPlanID.Properties.ValueMember = "MMOperationDetailPlanID";
            this.fld_lkeFK_MMOperationDetailPlanID.Screen = null;
            this.fld_lkeFK_MMOperationDetailPlanID.Size = new System.Drawing.Size(149, 20);
            this.fld_lkeFK_MMOperationDetailPlanID.TabIndex = 3;
            this.fld_lkeFK_MMOperationDetailPlanID.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(226, 41);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 106;
            this.bosLabel6.Text = "Đơn hàng";
            // 
            // fld_lblLabel10
            // 
            this.fld_lblLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel10.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel10.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel10.BOSComment = null;
            this.fld_lblLabel10.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSDescription = null;
            this.fld_lblLabel10.BOSError = null;
            this.fld_lblLabel10.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel10.BOSFieldRelation = null;
            this.fld_lblLabel10.BOSPrivilege = null;
            this.fld_lblLabel10.BOSPropertyName = null;
            this.fld_lblLabel10.Location = new System.Drawing.Point(438, 41);
            this.fld_lblLabel10.Name = "fld_lblLabel10";
            this.fld_lblLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel10, true);
            this.fld_lblLabel10.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLabel10.TabIndex = 107;
            this.fld_lblLabel10.Text = "Khách hàng";
            // 
            // fld_lkeFK_ARSaleOrderID
            // 
            this.fld_lkeFK_ARSaleOrderID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARSaleOrderID.BOSAllowDummy = false;
            this.fld_lkeFK_ARSaleOrderID.BOSComment = null;
            this.fld_lkeFK_ARSaleOrderID.BOSDataMember = "FK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.BOSDataSource = "MMWoodPlans";
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
            this.fld_lkeFK_ARSaleOrderID.Location = new System.Drawing.Point(280, 38);
            this.fld_lkeFK_ARSaleOrderID.Name = "fld_lkeFK_ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARSaleOrderID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARSaleOrderID.Properties.ColumnName = null;
            this.fld_lkeFK_ARSaleOrderID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderNo", "Mã đơn hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDeliveryDate", "Ngày giao"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARSaleOrderDesc", "Ghi chú")});
            this.fld_lkeFK_ARSaleOrderID.Properties.DisplayMember = "ARSaleOrderNo";
            this.fld_lkeFK_ARSaleOrderID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARSaleOrderID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARSaleOrderID.Properties.ValueMember = "ARSaleOrderID";
            this.fld_lkeFK_ARSaleOrderID.Screen = null;
            this.fld_lkeFK_ARSaleOrderID.Size = new System.Drawing.Size(144, 20);
            this.fld_lkeFK_ARSaleOrderID.TabIndex = 4;
            this.fld_lkeFK_ARSaleOrderID.Tag = "DC";
            // 
            // fld_lkeFK_ARCustomerID
            // 
            this.fld_lkeFK_ARCustomerID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerID.BOSAllowDummy = false;
            this.fld_lkeFK_ARCustomerID.BOSComment = null;
            this.fld_lkeFK_ARCustomerID.BOSDataMember = "FK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.BOSDataSource = "MMWoodPlans";
            this.fld_lkeFK_ARCustomerID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerID.BOSError = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldGroup = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldParent = null;
            this.fld_lkeFK_ARCustomerID.BOSFieldRelation = null;
            this.fld_lkeFK_ARCustomerID.BOSPrivilege = null;
            this.fld_lkeFK_ARCustomerID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerID.BOSSelectType = null;
            this.fld_lkeFK_ARCustomerID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ARCustomerID.CurrentDisplayText = null;
            this.fld_lkeFK_ARCustomerID.Location = new System.Drawing.Point(500, 38);
            this.fld_lkeFK_ARCustomerID.Name = "fld_lkeFK_ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ARCustomerID.Properties.ColumnName = null;
            this.fld_lkeFK_ARCustomerID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerNo", "Mã khách hàng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerName", "Tên KH"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerContactPhone", "ĐT"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerTaxNumber", "MST"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ARCustomerWebsite", "Website")});
            this.fld_lkeFK_ARCustomerID.Properties.DisplayMember = "ARCustomerName";
            this.fld_lkeFK_ARCustomerID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ARCustomerID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerID.Properties.ValueMember = "ARCustomerID";
            this.fld_lkeFK_ARCustomerID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ARCustomerID, true);
            this.fld_lkeFK_ARCustomerID.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeFK_ARCustomerID.TabIndex = 5;
            this.fld_lkeFK_ARCustomerID.Tag = "DC";
            // 
            // fld_lkeMMWoodPlanStatus
            // 
            this.fld_lkeMMWoodPlanStatus.BOSAllowAddNew = false;
            this.fld_lkeMMWoodPlanStatus.BOSAllowDummy = false;
            this.fld_lkeMMWoodPlanStatus.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSDataMember = "MMWoodPlanStatus";
            this.fld_lkeMMWoodPlanStatus.BOSDataSource = "MMWoodPlans";
            this.fld_lkeMMWoodPlanStatus.BOSDescription = null;
            this.fld_lkeMMWoodPlanStatus.BOSError = null;
            this.fld_lkeMMWoodPlanStatus.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMWoodPlanStatus.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.Location = new System.Drawing.Point(500, 117);
            this.fld_lkeMMWoodPlanStatus.Name = "fld_lkeMMWoodPlanStatus";
            this.fld_lkeMMWoodPlanStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMWoodPlanStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMWoodPlanStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMWoodPlanStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMWoodPlanStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMWoodPlanStatus.Properties.ColumnName = null;
            this.fld_lkeMMWoodPlanStatus.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeMMWoodPlanStatus.Properties.ReadOnly = true;
            this.fld_lkeMMWoodPlanStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMWoodPlanStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMWoodPlanStatus, true);
            this.fld_lkeMMWoodPlanStatus.Size = new System.Drawing.Size(141, 20);
            this.fld_lkeMMWoodPlanStatus.TabIndex = 7;
            this.fld_lkeMMWoodPlanStatus.Tag = "DC";
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
            this.bosLabel3.Location = new System.Drawing.Point(438, 120);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 104;
            this.bosLabel3.Text = "Tình trạng";
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
            this.bosLabel9.Location = new System.Drawing.Point(664, 15);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(60, 13);
            this.bosLabel9.TabIndex = 101;
            this.bosLabel9.Text = "Mã kế hoạch";
            // 
            // fld_medMMBatchItemPlanDesc
            // 
            this.fld_medMMBatchItemPlanDesc.BOSComment = null;
            this.fld_medMMBatchItemPlanDesc.BOSDataMember = "MMBatchItemPlanDesc";
            this.fld_medMMBatchItemPlanDesc.BOSDataSource = "MMBatchItemPlans";
            this.fld_medMMBatchItemPlanDesc.BOSDescription = null;
            this.fld_medMMBatchItemPlanDesc.BOSError = null;
            this.fld_medMMBatchItemPlanDesc.BOSFieldGroup = null;
            this.fld_medMMBatchItemPlanDesc.BOSFieldRelation = null;
            this.fld_medMMBatchItemPlanDesc.BOSPrivilege = null;
            this.fld_medMMBatchItemPlanDesc.BOSPropertyName = "EditValue";
            this.fld_medMMBatchItemPlanDesc.Location = new System.Drawing.Point(63, 90);
            this.fld_medMMBatchItemPlanDesc.MenuManager = this.screenToolbar;
            this.fld_medMMBatchItemPlanDesc.Name = "fld_medMMBatchItemPlanDesc";
            this.fld_medMMBatchItemPlanDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMBatchItemPlanDesc, true);
            this.fld_medMMBatchItemPlanDesc.Size = new System.Drawing.Size(361, 43);
            this.fld_medMMBatchItemPlanDesc.TabIndex = 9;
            this.fld_medMMBatchItemPlanDesc.Tag = "DC";
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
            this.bosLabel10.Location = new System.Drawing.Point(14, 41);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(42, 13);
            this.bosLabel10.TabIndex = 99;
            this.bosLabel10.Text = "Số lượng";
            // 
            // fld_lkeMMWoodPlanProductQty
            // 
            this.fld_lkeMMWoodPlanProductQty.BOSComment = null;
            this.fld_lkeMMWoodPlanProductQty.BOSDataMember = "MMWoodPlanProductQty";
            this.fld_lkeMMWoodPlanProductQty.BOSDataSource = "MMWoodPlans";
            this.fld_lkeMMWoodPlanProductQty.BOSDescription = null;
            this.fld_lkeMMWoodPlanProductQty.BOSError = null;
            this.fld_lkeMMWoodPlanProductQty.BOSFieldGroup = null;
            this.fld_lkeMMWoodPlanProductQty.BOSFieldRelation = null;
            this.fld_lkeMMWoodPlanProductQty.BOSPrivilege = null;
            this.fld_lkeMMWoodPlanProductQty.BOSPropertyName = "EditValue";
            this.fld_lkeMMWoodPlanProductQty.Location = new System.Drawing.Point(63, 38);
            this.fld_lkeMMWoodPlanProductQty.Name = "fld_lkeMMWoodPlanProductQty";
            this.fld_lkeMMWoodPlanProductQty.Properties.ReadOnly = true;
            this.fld_lkeMMWoodPlanProductQty.Screen = null;
            this.fld_lkeMMWoodPlanProductQty.Size = new System.Drawing.Size(140, 20);
            this.fld_lkeMMWoodPlanProductQty.TabIndex = 6;
            this.fld_lkeMMWoodPlanProductQty.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(14, 93);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 103;
            this.bosLabel5.Text = "Diễn giải";
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
            this.bosLabel2.Location = new System.Drawing.Point(226, 15);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 40;
            this.bosLabel2.Text = "Nhân viên";
            // 
            // fld_dteMMWoodPlanDate
            // 
            this.fld_dteMMWoodPlanDate.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMWoodPlanDate.BOSDataMember = "MMWoodPlanDate";
            this.fld_dteMMWoodPlanDate.BOSDataSource = "MMWoodPlans";
            this.fld_dteMMWoodPlanDate.BOSDescription = null;
            this.fld_dteMMWoodPlanDate.BOSError = null;
            this.fld_dteMMWoodPlanDate.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMWoodPlanDate.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMWoodPlanDate.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dteMMWoodPlanDate.BOSPropertyName = "EditValue";
            this.fld_dteMMWoodPlanDate.EditValue = null;
            this.fld_dteMMWoodPlanDate.Location = new System.Drawing.Point(500, 12);
            this.fld_dteMMWoodPlanDate.Name = "fld_dteMMWoodPlanDate";
            this.fld_dteMMWoodPlanDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMWoodPlanDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMWoodPlanDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMWoodPlanDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMWoodPlanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMWoodPlanDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMWoodPlanDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMWoodPlanDate, true);
            this.fld_dteMMWoodPlanDate.Size = new System.Drawing.Size(141, 20);
            this.fld_dteMMWoodPlanDate.TabIndex = 2;
            this.fld_dteMMWoodPlanDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMWoodPlans";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(280, 12);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(144, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(438, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(42, 13);
            this.bosLabel7.TabIndex = 39;
            this.bosLabel7.Text = "Ngày lập";
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
            this.bosLabel1.Location = new System.Drawing.Point(14, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(43, 13);
            this.bosLabel1.TabIndex = 23;
            this.bosLabel1.Text = "Mã phiếu";
            // 
            // fld_txtMMWoodPlanNo
            // 
            this.fld_txtMMWoodPlanNo.BOSComment = null;
            this.fld_txtMMWoodPlanNo.BOSDataMember = "MMWoodPlanNo";
            this.fld_txtMMWoodPlanNo.BOSDataSource = "MMWoodPlans";
            this.fld_txtMMWoodPlanNo.BOSDescription = null;
            this.fld_txtMMWoodPlanNo.BOSError = null;
            this.fld_txtMMWoodPlanNo.BOSFieldGroup = null;
            this.fld_txtMMWoodPlanNo.BOSFieldRelation = null;
            this.fld_txtMMWoodPlanNo.BOSPrivilege = null;
            this.fld_txtMMWoodPlanNo.BOSPropertyName = "EditValue";
            this.fld_txtMMWoodPlanNo.Location = new System.Drawing.Point(63, 12);
            this.fld_txtMMWoodPlanNo.MenuManager = this.screenToolbar;
            this.fld_txtMMWoodPlanNo.Name = "fld_txtMMWoodPlanNo";
            this.fld_txtMMWoodPlanNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMWoodPlanNo, true);
            this.fld_txtMMWoodPlanNo.Size = new System.Drawing.Size(140, 20);
            this.fld_txtMMWoodPlanNo.TabIndex = 0;
            this.fld_txtMMWoodPlanNo.Tag = "DC";
            // 
            // DMWP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1275, 600);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMWP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterials.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMaterialsChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTotalMaterialQtyChange.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtTotalMaterialQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcWoodPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMWoodPlanItemDetails)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcWoodPlanItemDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationDetailPlanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARSaleOrderID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWoodPlanStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMBatchItemPlanDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMWoodPlanProductQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMWoodPlanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMWoodPlanNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMWoodPlanNo;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteMMWoodPlanDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel fld_lblLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARSaleOrderID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerID;
        private BOSComponent.BOSLookupEdit fld_lkeMMWoodPlanStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medMMBatchItemPlanDesc;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSTextBox fld_lkeMMWoodPlanProductQty;
        private BOSComponent.BOSLabel bosLabel5;
        private MMWoodPlanItemsGridControl fld_dgcWoodPlans;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private MMWoodPlanItemDetailsGridControl fld_dgcMMWoodPlanItemDetails;
        private BOSComponent.BOSLookupEdit fld_lkeICProductID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private MMWoodPlanItemDetailMainsGridControl fld_dgcWoodPlanItemDetail;
        private BOSComponent.BOSButton fld_btnUpdateInventoryStock;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationDetailPlanID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMLineID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSButton bosButton1;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtTotalMaterialQtyChange;
        private BOSComponent.BOSTextBox fld_txtTotalMaterialQty;
        private BOSComponent.BOSButton fld_btnChangeMaterials;
        private BOSComponent.BOSLookupEdit fld_lkeMaterialsChange;
        private BOSComponent.BOSLookupEdit fld_lkeMaterials;
	}
}
