using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BatchProduct.UI
{
	/// <summary>
	/// Summary description for DMBP100
	/// </summary>
	partial class DMBP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMBP100));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeARProductionPlanningSaleType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ckeARSaleOrderIsDeliveryPlan = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_lkeFK_ACObjectID = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductGeneralMaterialStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductPackagingStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductPaintStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductHWStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductWoodStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lbWoodType = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ICProductAttributeTTMTID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeMMBatchProductResourceType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMPriority = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMBatchProductItems = new BOSERP.Modules.BatchProduct.MMBatchProductItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_mmoMMBatchProductMultiCustomer = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_medMMBatchProductDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_dteMMBatchProductDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMBatchProductToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMBatchProductDeliveryDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMBatchProductFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMBatchProductNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductionPlanningSaleType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsDeliveryPlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductPackagingStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductPaintStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductHWStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductWoodStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductResourceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPriority.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProductItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_mmoMMBatchProductMultiCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMBatchProductDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductDeliveryDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductDeliveryDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMBatchProductNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bosTextBox2);
            this.panel1.Controls.Add(this.bosLabel22);
            this.panel1.Controls.Add(this.bosLabel20);
            this.panel1.Controls.Add(this.fld_lkeARProductionPlanningSaleType);
            this.panel1.Controls.Add(this.fld_ckeARSaleOrderIsDeliveryPlan);
            this.panel1.Controls.Add(this.fld_lkeFK_ACObjectID);
            this.panel1.Controls.Add(this.bosTextBox1);
            this.panel1.Controls.Add(this.bosLabel18);
            this.panel1.Controls.Add(this.bosLine1);
            this.panel1.Controls.Add(this.fld_lbWoodType);
            this.panel1.Controls.Add(this.fld_lkeFK_ICProductAttributeTTMTID);
            this.panel1.Controls.Add(this.fld_lkeMMBatchProductResourceType);
            this.panel1.Controls.Add(this.bosLabel13);
            this.panel1.Controls.Add(this.fld_lkeMMBatchProductType);
            this.panel1.Controls.Add(this.bosLabel12);
            this.panel1.Controls.Add(this.fld_lkeMMPriority);
            this.panel1.Controls.Add(this.bosLabel9);
            this.panel1.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.panel1.Controls.Add(this.bosLabel19);
            this.panel1.Controls.Add(this.bosLabel4);
            this.panel1.Controls.Add(this.bosLabel10);
            this.panel1.Controls.Add(this.bosLabel6);
            this.panel1.Controls.Add(this.fld_lkeMMBatchProductStatus);
            this.panel1.Controls.Add(this.bosLabel11);
            this.panel1.Controls.Add(this.bosLabel3);
            this.panel1.Controls.Add(this.bosGroupControl1);
            this.panel1.Controls.Add(this.bosLabel2);
            this.panel1.Controls.Add(this.fld_mmoMMBatchProductMultiCustomer);
            this.panel1.Controls.Add(this.fld_medMMBatchProductDesc);
            this.panel1.Controls.Add(this.fld_dteMMBatchProductDate);
            this.panel1.Controls.Add(this.fld_dteMMBatchProductToDate);
            this.panel1.Controls.Add(this.fld_dteMMBatchProductDeliveryDate);
            this.panel1.Controls.Add(this.fld_dteMMBatchProductFromDate);
            this.panel1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.panel1.Controls.Add(this.bosLabel1);
            this.panel1.Controls.Add(this.bosLabel8);
            this.panel1.Controls.Add(this.fld_txtMMBatchProductNo);
            this.panel1.Controls.Add(this.bosLabel5);
            this.panel1.Controls.Add(this.bosLabel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1390, 712);
            this.panel1.TabIndex = 0;
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "MMBatchProductSOName";
            this.bosTextBox2.BOSDataSource = "MMBatchProducts";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Location = new System.Drawing.Point(892, 113);
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
            this.bosTextBox2.Size = new System.Drawing.Size(154, 20);
            this.bosTextBox2.TabIndex = 811;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosLabel22
            // 
            this.bosLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel22.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel22.Appearance.Options.UseBackColor = true;
            this.bosLabel22.Appearance.Options.UseFont = true;
            this.bosLabel22.Appearance.Options.UseForeColor = true;
            this.bosLabel22.BOSComment = "";
            this.bosLabel22.BOSDataMember = "";
            this.bosLabel22.BOSDataSource = "";
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = "";
            this.bosLabel22.BOSFieldRelation = "";
            this.bosLabel22.BOSPrivilege = "";
            this.bosLabel22.BOSPropertyName = "";
            this.bosLabel22.Location = new System.Drawing.Point(790, 116);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(96, 13);
            this.bosLabel22.TabIndex = 812;
            this.bosLabel22.Tag = "";
            this.bosLabel22.Text = "Mã đơn hàng nội bộ";
            // 
            // bosLabel20
            // 
            this.bosLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel20.Appearance.Options.UseBackColor = true;
            this.bosLabel20.Appearance.Options.UseForeColor = true;
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(530, 116);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(94, 13);
            this.bosLabel20.TabIndex = 810;
            this.bosLabel20.Text = "Hình thức bán hàng";
            // 
            // fld_lkeARProductionPlanningSaleType
            // 
            this.fld_lkeARProductionPlanningSaleType.BOSAllowAddNew = false;
            this.fld_lkeARProductionPlanningSaleType.BOSAllowDummy = true;
            this.fld_lkeARProductionPlanningSaleType.BOSComment = null;
            this.fld_lkeARProductionPlanningSaleType.BOSDataMember = "MMBatchProductSaleType";
            this.fld_lkeARProductionPlanningSaleType.BOSDataSource = "MMBatchProducts";
            this.fld_lkeARProductionPlanningSaleType.BOSDescription = null;
            this.fld_lkeARProductionPlanningSaleType.BOSError = null;
            this.fld_lkeARProductionPlanningSaleType.BOSFieldGroup = null;
            this.fld_lkeARProductionPlanningSaleType.BOSFieldParent = null;
            this.fld_lkeARProductionPlanningSaleType.BOSFieldRelation = null;
            this.fld_lkeARProductionPlanningSaleType.BOSPrivilege = null;
            this.fld_lkeARProductionPlanningSaleType.BOSPropertyName = "EditValue";
            this.fld_lkeARProductionPlanningSaleType.BOSSelectType = null;
            this.fld_lkeARProductionPlanningSaleType.BOSSelectTypeValue = null;
            this.fld_lkeARProductionPlanningSaleType.CurrentDisplayText = null;
            this.fld_lkeARProductionPlanningSaleType.Location = new System.Drawing.Point(630, 113);
            this.fld_lkeARProductionPlanningSaleType.Name = "fld_lkeARProductionPlanningSaleType";
            this.fld_lkeARProductionPlanningSaleType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeARProductionPlanningSaleType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeARProductionPlanningSaleType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeARProductionPlanningSaleType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeARProductionPlanningSaleType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeARProductionPlanningSaleType.Properties.ColumnName = null;
            this.fld_lkeARProductionPlanningSaleType.Properties.NullText = "";
            this.fld_lkeARProductionPlanningSaleType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeARProductionPlanningSaleType.Screen = null;
            this.fld_lkeARProductionPlanningSaleType.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeARProductionPlanningSaleType.TabIndex = 809;
            this.fld_lkeARProductionPlanningSaleType.Tag = "DC";
            // 
            // fld_ckeARSaleOrderIsDeliveryPlan
            // 
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSComment = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSDataMember = "MMBatchProductIsWoodPlan";
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSDataSource = "MMBatchProducts";
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSDescription = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSError = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSFieldGroup = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSFieldRelation = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSPrivilege = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.BOSPropertyName = "EditValue";
            this.fld_ckeARSaleOrderIsDeliveryPlan.Location = new System.Drawing.Point(1174, 39);
            this.fld_ckeARSaleOrderIsDeliveryPlan.MenuManager = this.screenToolbar;
            this.fld_ckeARSaleOrderIsDeliveryPlan.Name = "fld_ckeARSaleOrderIsDeliveryPlan";
            this.fld_ckeARSaleOrderIsDeliveryPlan.Properties.Caption = "Hoạch định chi tiết";
            this.fld_ckeARSaleOrderIsDeliveryPlan.Screen = null;
            this.fld_ckeARSaleOrderIsDeliveryPlan.Size = new System.Drawing.Size(136, 20);
            this.fld_ckeARSaleOrderIsDeliveryPlan.TabIndex = 36;
            this.fld_ckeARSaleOrderIsDeliveryPlan.Tag = "DC";
            this.fld_ckeARSaleOrderIsDeliveryPlan.Visible = false;
            // 
            // fld_lkeFK_ACObjectID
            // 
            this.fld_lkeFK_ACObjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACObjectID.BOSAllowDummy = true;
            this.fld_lkeFK_ACObjectID.BOSComment = "";
            this.fld_lkeFK_ACObjectID.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeFK_ACObjectID.BOSDataSource = "MMBatchProducts";
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
            this.fld_lkeFK_ACObjectID.Location = new System.Drawing.Point(1174, 12);
            this.fld_lkeFK_ACObjectID.Name = "fld_lkeFK_ACObjectID";
            this.fld_lkeFK_ACObjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ACObjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACObjectID.Properties.ColumnName = null;
            this.fld_lkeFK_ACObjectID.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeFK_ACObjectID.Properties.NullText = "";
            this.fld_lkeFK_ACObjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_ACObjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACObjectID.Properties.ValueMember = "ACObjectID";
            this.fld_lkeFK_ACObjectID.Screen = null;
            this.fld_lkeFK_ACObjectID.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeFK_ACObjectID.TabIndex = 5;
            this.fld_lkeFK_ACObjectID.Tag = "DC";
            this.fld_lkeFK_ACObjectID.Visible = false;
            this.fld_lkeFK_ACObjectID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_ACObjectID_CloseUp);
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "MMBatchProductPONo";
            this.bosTextBox1.BOSDataSource = "MMBatchProducts";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Location = new System.Drawing.Point(1174, 65);
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
            this.bosTextBox1.Size = new System.Drawing.Size(154, 20);
            this.bosTextBox1.TabIndex = 16;
            this.bosTextBox1.Tag = "DC";
            this.bosTextBox1.Visible = false;
            // 
            // bosLabel18
            // 
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "";
            this.bosLabel18.BOSDataSource = "";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(1075, 69);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel18, true);
            this.bosLabel18.Size = new System.Drawing.Size(48, 13);
            this.bosLabel18.TabIndex = 32;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "Số PO.No";
            this.bosLabel18.Visible = false;
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
            this.bosLine1.Controls.Add(this.bosLabel21);
            this.bosLine1.Controls.Add(this.fld_lkeMMBatchProductGeneralMaterialStatus);
            this.bosLine1.Controls.Add(this.bosLabel17);
            this.bosLine1.Controls.Add(this.fld_lkeMMBatchProductPackagingStatus);
            this.bosLine1.Controls.Add(this.bosLabel16);
            this.bosLine1.Controls.Add(this.fld_lkeMMBatchProductPaintStatus);
            this.bosLine1.Controls.Add(this.bosLabel15);
            this.bosLine1.Controls.Add(this.fld_lkeMMBatchProductHWStatus);
            this.bosLine1.Controls.Add(this.bosLabel14);
            this.bosLine1.Controls.Add(this.fld_lkeMMBatchProductWoodStatus);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(12, 139);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(1294, 48);
            this.bosLine1.TabIndex = 24;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Trạng thái nguyên liệu đầu vào";
            // 
            // bosLabel21
            // 
            this.bosLabel21.BOSComment = null;
            this.bosLabel21.BOSDataMember = null;
            this.bosLabel21.BOSDataSource = null;
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = null;
            this.bosLabel21.BOSFieldRelation = null;
            this.bosLabel21.BOSPrivilege = null;
            this.bosLabel21.BOSPropertyName = null;
            this.bosLabel21.Location = new System.Drawing.Point(1065, 22);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel21, true);
            this.bosLabel21.Size = new System.Drawing.Size(38, 13);
            this.bosLabel21.TabIndex = 8;
            this.bosLabel21.Text = "ĐM VTC";
            // 
            // fld_lkeMMBatchProductGeneralMaterialStatus
            // 
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSComment = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSDataMember = "MMBatchProductGeneralMaterialStatus";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSDescription = null;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSError = null;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSFieldParent = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSPrivilege = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSSelectType = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.CurrentDisplayText = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Location = new System.Drawing.Point(1123, 18);
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Name = "fld_lkeMMBatchProductGeneralMaterialStatus";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.NullText = "";
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.ReadOnly = true;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductGeneralMaterialStatus, true);
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMBatchProductGeneralMaterialStatus.TabIndex = 9;
            this.fld_lkeMMBatchProductGeneralMaterialStatus.Tag = "DC";
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
            this.bosLabel17.Location = new System.Drawing.Point(803, 22);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(45, 13);
            this.bosLabel17.TabIndex = 6;
            this.bosLabel17.Text = "ĐM PLĐG";
            // 
            // fld_lkeMMBatchProductPackagingStatus
            // 
            this.fld_lkeMMBatchProductPackagingStatus.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductPackagingStatus.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductPackagingStatus.BOSComment = "";
            this.fld_lkeMMBatchProductPackagingStatus.BOSDataMember = "MMBatchProductPackagingStatus";
            this.fld_lkeMMBatchProductPackagingStatus.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductPackagingStatus.BOSDescription = null;
            this.fld_lkeMMBatchProductPackagingStatus.BOSError = null;
            this.fld_lkeMMBatchProductPackagingStatus.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductPackagingStatus.BOSFieldParent = "";
            this.fld_lkeMMBatchProductPackagingStatus.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductPackagingStatus.BOSPrivilege = "";
            this.fld_lkeMMBatchProductPackagingStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductPackagingStatus.BOSSelectType = "";
            this.fld_lkeMMBatchProductPackagingStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductPackagingStatus.CurrentDisplayText = "";
            this.fld_lkeMMBatchProductPackagingStatus.Location = new System.Drawing.Point(875, 18);
            this.fld_lkeMMBatchProductPackagingStatus.Name = "fld_lkeMMBatchProductPackagingStatus";
            this.fld_lkeMMBatchProductPackagingStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMBatchProductPackagingStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductPackagingStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductPackagingStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductPackagingStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductPackagingStatus.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductPackagingStatus.Properties.NullText = "";
            this.fld_lkeMMBatchProductPackagingStatus.Properties.ReadOnly = true;
            this.fld_lkeMMBatchProductPackagingStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductPackagingStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductPackagingStatus, true);
            this.fld_lkeMMBatchProductPackagingStatus.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMBatchProductPackagingStatus.TabIndex = 7;
            this.fld_lkeMMBatchProductPackagingStatus.Tag = "DC";
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
            this.bosLabel16.Location = new System.Drawing.Point(518, 21);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(37, 13);
            this.bosLabel16.TabIndex = 4;
            this.bosLabel16.Text = "ĐM Sơn";
            // 
            // fld_lkeMMBatchProductPaintStatus
            // 
            this.fld_lkeMMBatchProductPaintStatus.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductPaintStatus.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductPaintStatus.BOSComment = "";
            this.fld_lkeMMBatchProductPaintStatus.BOSDataMember = "MMBatchProductPaintStatus";
            this.fld_lkeMMBatchProductPaintStatus.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductPaintStatus.BOSDescription = null;
            this.fld_lkeMMBatchProductPaintStatus.BOSError = null;
            this.fld_lkeMMBatchProductPaintStatus.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductPaintStatus.BOSFieldParent = "";
            this.fld_lkeMMBatchProductPaintStatus.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductPaintStatus.BOSPrivilege = "";
            this.fld_lkeMMBatchProductPaintStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductPaintStatus.BOSSelectType = "";
            this.fld_lkeMMBatchProductPaintStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductPaintStatus.CurrentDisplayText = "";
            this.fld_lkeMMBatchProductPaintStatus.Location = new System.Drawing.Point(618, 19);
            this.fld_lkeMMBatchProductPaintStatus.Name = "fld_lkeMMBatchProductPaintStatus";
            this.fld_lkeMMBatchProductPaintStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMBatchProductPaintStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductPaintStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductPaintStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductPaintStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductPaintStatus.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductPaintStatus.Properties.NullText = "";
            this.fld_lkeMMBatchProductPaintStatus.Properties.ReadOnly = true;
            this.fld_lkeMMBatchProductPaintStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductPaintStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductPaintStatus, true);
            this.fld_lkeMMBatchProductPaintStatus.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMBatchProductPaintStatus.TabIndex = 5;
            this.fld_lkeMMBatchProductPaintStatus.Tag = "DC";
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
            this.bosLabel15.Location = new System.Drawing.Point(257, 22);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(66, 13);
            this.bosLabel15.TabIndex = 2;
            this.bosLabel15.Text = "ĐM Hardware";
            // 
            // fld_lkeMMBatchProductHWStatus
            // 
            this.fld_lkeMMBatchProductHWStatus.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductHWStatus.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductHWStatus.BOSComment = "";
            this.fld_lkeMMBatchProductHWStatus.BOSDataMember = "MMBatchProductHWStatus";
            this.fld_lkeMMBatchProductHWStatus.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductHWStatus.BOSDescription = null;
            this.fld_lkeMMBatchProductHWStatus.BOSError = null;
            this.fld_lkeMMBatchProductHWStatus.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductHWStatus.BOSFieldParent = "";
            this.fld_lkeMMBatchProductHWStatus.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductHWStatus.BOSPrivilege = "";
            this.fld_lkeMMBatchProductHWStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductHWStatus.BOSSelectType = "";
            this.fld_lkeMMBatchProductHWStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductHWStatus.CurrentDisplayText = "";
            this.fld_lkeMMBatchProductHWStatus.Location = new System.Drawing.Point(330, 18);
            this.fld_lkeMMBatchProductHWStatus.Name = "fld_lkeMMBatchProductHWStatus";
            this.fld_lkeMMBatchProductHWStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMBatchProductHWStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductHWStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductHWStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductHWStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductHWStatus.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductHWStatus.Properties.NullText = "";
            this.fld_lkeMMBatchProductHWStatus.Properties.ReadOnly = true;
            this.fld_lkeMMBatchProductHWStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductHWStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductHWStatus, true);
            this.fld_lkeMMBatchProductHWStatus.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMBatchProductHWStatus.TabIndex = 3;
            this.fld_lkeMMBatchProductHWStatus.Tag = "DC";
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
            this.bosLabel14.Location = new System.Drawing.Point(6, 22);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, true);
            this.bosLabel14.Size = new System.Drawing.Size(37, 13);
            this.bosLabel14.TabIndex = 0;
            this.bosLabel14.Text = "ĐM BTP";
            // 
            // fld_lkeMMBatchProductWoodStatus
            // 
            this.fld_lkeMMBatchProductWoodStatus.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductWoodStatus.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductWoodStatus.BOSComment = "";
            this.fld_lkeMMBatchProductWoodStatus.BOSDataMember = "MMBatchProductWoodStatus";
            this.fld_lkeMMBatchProductWoodStatus.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductWoodStatus.BOSDescription = null;
            this.fld_lkeMMBatchProductWoodStatus.BOSError = null;
            this.fld_lkeMMBatchProductWoodStatus.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductWoodStatus.BOSFieldParent = "";
            this.fld_lkeMMBatchProductWoodStatus.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductWoodStatus.BOSPrivilege = "";
            this.fld_lkeMMBatchProductWoodStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductWoodStatus.BOSSelectType = "";
            this.fld_lkeMMBatchProductWoodStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductWoodStatus.CurrentDisplayText = "";
            this.fld_lkeMMBatchProductWoodStatus.Location = new System.Drawing.Point(65, 18);
            this.fld_lkeMMBatchProductWoodStatus.Name = "fld_lkeMMBatchProductWoodStatus";
            this.fld_lkeMMBatchProductWoodStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMBatchProductWoodStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductWoodStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductWoodStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductWoodStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductWoodStatus.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductWoodStatus.Properties.NullText = "";
            this.fld_lkeMMBatchProductWoodStatus.Properties.ReadOnly = true;
            this.fld_lkeMMBatchProductWoodStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductWoodStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductWoodStatus, true);
            this.fld_lkeMMBatchProductWoodStatus.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMBatchProductWoodStatus.TabIndex = 1;
            this.fld_lkeMMBatchProductWoodStatus.Tag = "DC";
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
            this.fld_lbWoodType.Location = new System.Drawing.Point(790, 92);
            this.fld_lbWoodType.Name = "fld_lbWoodType";
            this.fld_lbWoodType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lbWoodType, true);
            this.fld_lbWoodType.Size = new System.Drawing.Size(26, 13);
            this.fld_lbWoodType.TabIndex = 22;
            this.fld_lbWoodType.Text = "TTMT";
            // 
            // fld_lkeFK_ICProductAttributeTTMTID
            // 
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowAddNew = false;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSAllowDummy = true;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSComment = null;
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataMember = "FK_ICProductAttributeTTMTID";
            this.fld_lkeFK_ICProductAttributeTTMTID.BOSDataSource = "MMBatchProducts";
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Location = new System.Drawing.Point(892, 87);
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
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.NullText = "";
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ICProductAttributeTTMTID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeFK_ICProductAttributeTTMTID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_ICProductAttributeTTMTID, true);
            this.fld_lkeFK_ICProductAttributeTTMTID.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeFK_ICProductAttributeTTMTID.TabIndex = 23;
            this.fld_lkeFK_ICProductAttributeTTMTID.Tag = "DC";
            this.fld_lkeFK_ICProductAttributeTTMTID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ICProductAttributeTTMTID_CloseUp);
            // 
            // fld_lkeMMBatchProductResourceType
            // 
            this.fld_lkeMMBatchProductResourceType.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductResourceType.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductResourceType.BOSComment = "";
            this.fld_lkeMMBatchProductResourceType.BOSDataMember = "MMBatchProductResourceType";
            this.fld_lkeMMBatchProductResourceType.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductResourceType.BOSDescription = null;
            this.fld_lkeMMBatchProductResourceType.BOSError = null;
            this.fld_lkeMMBatchProductResourceType.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductResourceType.BOSFieldParent = "";
            this.fld_lkeMMBatchProductResourceType.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductResourceType.BOSPrivilege = "";
            this.fld_lkeMMBatchProductResourceType.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductResourceType.BOSSelectType = "";
            this.fld_lkeMMBatchProductResourceType.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductResourceType.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductResourceType.Location = new System.Drawing.Point(1174, 91);
            this.fld_lkeMMBatchProductResourceType.Name = "fld_lkeMMBatchProductResourceType";
            this.fld_lkeMMBatchProductResourceType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductResourceType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductResourceType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductResourceType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductResourceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductResourceType.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductResourceType.Properties.NullText = "";
            this.fld_lkeMMBatchProductResourceType.Properties.PopupWidth = 40;
            this.fld_lkeMMBatchProductResourceType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductResourceType.Screen = null;
            this.fld_lkeMMBatchProductResourceType.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMBatchProductResourceType.TabIndex = 5;
            this.fld_lkeMMBatchProductResourceType.Tag = "DC";
            this.fld_lkeMMBatchProductResourceType.Visible = false;
            this.fld_lkeMMBatchProductResourceType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeMMBatchProductResourceType_CloseUp);
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel13.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel13.Appearance.Options.UseBackColor = true;
            this.bosLabel13.Appearance.Options.UseFont = true;
            this.bosLabel13.Appearance.Options.UseForeColor = true;
            this.bosLabel13.BOSComment = "";
            this.bosLabel13.BOSDataMember = "";
            this.bosLabel13.BOSDataSource = "";
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = "";
            this.bosLabel13.BOSFieldRelation = "";
            this.bosLabel13.BOSPrivilege = "";
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(1075, 94);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(32, 13);
            this.bosLabel13.TabIndex = 4;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Nguồn";
            this.bosLabel13.Visible = false;
            // 
            // fld_lkeMMBatchProductType
            // 
            this.fld_lkeMMBatchProductType.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductType.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductType.BOSComment = "";
            this.fld_lkeMMBatchProductType.BOSDataMember = "MMBatchProductType";
            this.fld_lkeMMBatchProductType.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductType.BOSDescription = null;
            this.fld_lkeMMBatchProductType.BOSError = null;
            this.fld_lkeMMBatchProductType.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductType.BOSFieldParent = "";
            this.fld_lkeMMBatchProductType.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductType.BOSPrivilege = "";
            this.fld_lkeMMBatchProductType.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductType.BOSSelectType = "";
            this.fld_lkeMMBatchProductType.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductType.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductType.Location = new System.Drawing.Point(77, 64);
            this.fld_lkeMMBatchProductType.Name = "fld_lkeMMBatchProductType";
            this.fld_lkeMMBatchProductType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMBatchProductType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductType.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductType.Properties.NullText = "";
            this.fld_lkeMMBatchProductType.Properties.PopupWidth = 40;
            this.fld_lkeMMBatchProductType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductType.Screen = null;
            this.fld_lkeMMBatchProductType.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMBatchProductType.TabIndex = 15;
            this.fld_lkeMMBatchProductType.Tag = "DC";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel12.Appearance.Options.UseBackColor = true;
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.Appearance.Options.UseForeColor = true;
            this.bosLabel12.BOSComment = "";
            this.bosLabel12.BOSDataMember = "";
            this.bosLabel12.BOSDataSource = "";
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = "";
            this.bosLabel12.BOSFieldRelation = "";
            this.bosLabel12.BOSPrivilege = "";
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(18, 67);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(39, 13);
            this.bosLabel12.TabIndex = 14;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Loại ĐH";
            // 
            // fld_lkeMMPriority
            // 
            this.fld_lkeMMPriority.BOSAllowAddNew = false;
            this.fld_lkeMMPriority.BOSAllowDummy = false;
            this.fld_lkeMMPriority.BOSComment = "";
            this.fld_lkeMMPriority.BOSDataMember = "MMPriority";
            this.fld_lkeMMPriority.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMPriority.BOSDescription = null;
            this.fld_lkeMMPriority.BOSError = null;
            this.fld_lkeMMPriority.BOSFieldGroup = "";
            this.fld_lkeMMPriority.BOSFieldParent = "";
            this.fld_lkeMMPriority.BOSFieldRelation = "";
            this.fld_lkeMMPriority.BOSPrivilege = "";
            this.fld_lkeMMPriority.BOSPropertyName = "EditValue";
            this.fld_lkeMMPriority.BOSSelectType = "";
            this.fld_lkeMMPriority.BOSSelectTypeValue = "";
            this.fld_lkeMMPriority.CurrentDisplayText = null;
            this.fld_lkeMMPriority.Location = new System.Drawing.Point(342, 38);
            this.fld_lkeMMPriority.Name = "fld_lkeMMPriority";
            this.fld_lkeMMPriority.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeMMPriority.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMPriority.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMPriority.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMPriority.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMPriority.Properties.ColumnName = null;
            this.fld_lkeMMPriority.Properties.NullText = "";
            this.fld_lkeMMPriority.Properties.PopupWidth = 40;
            this.fld_lkeMMPriority.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMPriority.Screen = null;
            this.fld_lkeMMPriority.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMPriority.TabIndex = 11;
            this.fld_lkeMMPriority.Tag = "DC";
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
            this.bosLabel9.Location = new System.Drawing.Point(269, 41);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(49, 13);
            this.bosLabel9.TabIndex = 10;
            this.bosLabel9.Tag = "";
            this.bosLabel9.Text = "Độ ưu tiên";
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = false;
            this.fld_lkeFK_MMWorkShopID.BOSComment = null;
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = null;
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = null;
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = null;
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = null;
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(342, 64);
            this.fld_lkeFK_MMWorkShopID.Name = "fld_lkeFK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMWorkShopID.Properties.ColumnName = null;
            this.fld_lkeFK_MMWorkShopID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMWorkShopName", "Tên xưởng")});
            this.fld_lkeFK_MMWorkShopID.Properties.DisplayMember = "MMWorkShopName";
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 17;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            // 
            // bosLabel19
            // 
            this.bosLabel19.BOSComment = null;
            this.bosLabel19.BOSDataMember = null;
            this.bosLabel19.BOSDataSource = null;
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = null;
            this.bosLabel19.BOSFieldRelation = null;
            this.bosLabel19.BOSPrivilege = null;
            this.bosLabel19.BOSPropertyName = null;
            this.bosLabel19.Location = new System.Drawing.Point(269, 67);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(31, 13);
            this.bosLabel19.TabIndex = 16;
            this.bosLabel19.Text = "Xưởng";
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
            this.bosLabel4.Location = new System.Drawing.Point(1074, 15);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 10;
            this.bosLabel4.Text = "Đối tượng";
            this.bosLabel4.Visible = false;
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
            this.bosLabel10.Location = new System.Drawing.Point(790, 14);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(47, 13);
            this.bosLabel10.TabIndex = 6;
            this.bosLabel10.Text = "Đến ngày";
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = null;
            this.bosLabel6.BOSDataSource = null;
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(530, 14);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(48, 13);
            this.bosLabel6.TabIndex = 4;
            this.bosLabel6.Text = "T.Hiện từ ";
            // 
            // fld_lkeMMBatchProductStatus
            // 
            this.fld_lkeMMBatchProductStatus.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductStatus.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductStatus.BOSComment = "";
            this.fld_lkeMMBatchProductStatus.BOSDataMember = "MMBatchProductStatus";
            this.fld_lkeMMBatchProductStatus.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductStatus.BOSDescription = null;
            this.fld_lkeMMBatchProductStatus.BOSError = null;
            this.fld_lkeMMBatchProductStatus.BOSFieldGroup = "";
            this.fld_lkeMMBatchProductStatus.BOSFieldParent = "";
            this.fld_lkeMMBatchProductStatus.BOSFieldRelation = "";
            this.fld_lkeMMBatchProductStatus.BOSPrivilege = "";
            this.fld_lkeMMBatchProductStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductStatus.BOSSelectType = "";
            this.fld_lkeMMBatchProductStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMBatchProductStatus.CurrentDisplayText = "";
            this.fld_lkeMMBatchProductStatus.Location = new System.Drawing.Point(630, 87);
            this.fld_lkeMMBatchProductStatus.Name = "fld_lkeMMBatchProductStatus";
            this.fld_lkeMMBatchProductStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMBatchProductStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMBatchProductStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMBatchProductStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMBatchProductStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductStatus.Properties.ColumnName = null;
            this.fld_lkeMMBatchProductStatus.Properties.NullText = "";
            this.fld_lkeMMBatchProductStatus.Properties.ReadOnly = true;
            this.fld_lkeMMBatchProductStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMBatchProductStatus, true);
            this.fld_lkeMMBatchProductStatus.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeMMBatchProductStatus.TabIndex = 21;
            this.fld_lkeMMBatchProductStatus.Tag = "DC";
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
            this.bosLabel11.Location = new System.Drawing.Point(1074, 120);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(90, 13);
            this.bosLabel11.TabIndex = 20;
            this.bosLabel11.Text = "Ngày giao trể nhất";
            this.bosLabel11.Visible = false;
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
            this.bosLabel3.Location = new System.Drawing.Point(530, 90);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 20;
            this.bosLabel3.Text = "Tình trạng";
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
            this.bosGroupControl1.Controls.Add(this.fld_dgcMMBatchProductItems);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 193);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1378, 515);
            this.bosGroupControl1.TabIndex = 25;
            this.bosGroupControl1.Text = "Danh sách sản phẩm";
            // 
            // fld_dgcMMBatchProductItems
            // 
            this.fld_dgcMMBatchProductItems.AllowDrop = true;
            this.fld_dgcMMBatchProductItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMBatchProductItems.BOSComment = null;
            this.fld_dgcMMBatchProductItems.BOSDataMember = null;
            this.fld_dgcMMBatchProductItems.BOSDataSource = "MMBatchProductItems";
            this.fld_dgcMMBatchProductItems.BOSDescription = null;
            this.fld_dgcMMBatchProductItems.BOSError = null;
            this.fld_dgcMMBatchProductItems.BOSFieldGroup = null;
            this.fld_dgcMMBatchProductItems.BOSFieldRelation = null;
            this.fld_dgcMMBatchProductItems.BOSGridType = null;
            this.fld_dgcMMBatchProductItems.BOSPrivilege = null;
            this.fld_dgcMMBatchProductItems.BOSPropertyName = null;
            this.fld_dgcMMBatchProductItems.CommodityType = "";
            this.fld_dgcMMBatchProductItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMBatchProductItems.Location = new System.Drawing.Point(12, 23);
            this.fld_dgcMMBatchProductItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcMMBatchProductItems.Name = "fld_dgcMMBatchProductItems";
            this.fld_dgcMMBatchProductItems.PrintReport = false;
            this.fld_dgcMMBatchProductItems.Screen = null;
            this.fld_dgcMMBatchProductItems.Size = new System.Drawing.Size(1361, 478);
            this.fld_dgcMMBatchProductItems.TabIndex = 2;
            this.fld_dgcMMBatchProductItems.Tag = "DC";
            this.fld_dgcMMBatchProductItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcMMBatchProductItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
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
            this.bosLabel2.Location = new System.Drawing.Point(18, 41);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 8;
            this.bosLabel2.Text = "Nhân viên";
            // 
            // fld_mmoMMBatchProductMultiCustomer
            // 
            this.fld_mmoMMBatchProductMultiCustomer.BOSComment = null;
            this.fld_mmoMMBatchProductMultiCustomer.BOSDataMember = "MMBatchProductMultiCustomer";
            this.fld_mmoMMBatchProductMultiCustomer.BOSDataSource = "MMBatchProducts";
            this.fld_mmoMMBatchProductMultiCustomer.BOSDescription = null;
            this.fld_mmoMMBatchProductMultiCustomer.BOSError = null;
            this.fld_mmoMMBatchProductMultiCustomer.BOSFieldGroup = null;
            this.fld_mmoMMBatchProductMultiCustomer.BOSFieldRelation = null;
            this.fld_mmoMMBatchProductMultiCustomer.BOSPrivilege = null;
            this.fld_mmoMMBatchProductMultiCustomer.BOSPropertyName = "EditValue";
            this.fld_mmoMMBatchProductMultiCustomer.Location = new System.Drawing.Point(630, 38);
            this.fld_mmoMMBatchProductMultiCustomer.Name = "fld_mmoMMBatchProductMultiCustomer";
            this.fld_mmoMMBatchProductMultiCustomer.Screen = null;
            this.fld_mmoMMBatchProductMultiCustomer.Size = new System.Drawing.Size(416, 43);
            this.fld_mmoMMBatchProductMultiCustomer.TabIndex = 13;
            this.fld_mmoMMBatchProductMultiCustomer.Tag = "DC";
            // 
            // fld_medMMBatchProductDesc
            // 
            this.fld_medMMBatchProductDesc.BOSComment = null;
            this.fld_medMMBatchProductDesc.BOSDataMember = "MMBatchProductDesc";
            this.fld_medMMBatchProductDesc.BOSDataSource = "MMBatchProducts";
            this.fld_medMMBatchProductDesc.BOSDescription = null;
            this.fld_medMMBatchProductDesc.BOSError = null;
            this.fld_medMMBatchProductDesc.BOSFieldGroup = null;
            this.fld_medMMBatchProductDesc.BOSFieldRelation = null;
            this.fld_medMMBatchProductDesc.BOSPrivilege = null;
            this.fld_medMMBatchProductDesc.BOSPropertyName = "EditValue";
            this.fld_medMMBatchProductDesc.Location = new System.Drawing.Point(77, 90);
            this.fld_medMMBatchProductDesc.MenuManager = this.screenToolbar;
            this.fld_medMMBatchProductDesc.Name = "fld_medMMBatchProductDesc";
            this.fld_medMMBatchProductDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMBatchProductDesc, true);
            this.fld_medMMBatchProductDesc.Size = new System.Drawing.Size(419, 43);
            this.fld_medMMBatchProductDesc.TabIndex = 19;
            this.fld_medMMBatchProductDesc.Tag = "DC";
            // 
            // fld_dteMMBatchProductDate
            // 
            this.fld_dteMMBatchProductDate.BOSComment = "";
            this.fld_dteMMBatchProductDate.BOSDataMember = "MMBatchProductDate";
            this.fld_dteMMBatchProductDate.BOSDataSource = "MMBatchProducts";
            this.fld_dteMMBatchProductDate.BOSDescription = null;
            this.fld_dteMMBatchProductDate.BOSError = null;
            this.fld_dteMMBatchProductDate.BOSFieldGroup = "";
            this.fld_dteMMBatchProductDate.BOSFieldRelation = "";
            this.fld_dteMMBatchProductDate.BOSPrivilege = "";
            this.fld_dteMMBatchProductDate.BOSPropertyName = "EditValue";
            this.fld_dteMMBatchProductDate.EditValue = null;
            this.fld_dteMMBatchProductDate.Location = new System.Drawing.Point(342, 12);
            this.fld_dteMMBatchProductDate.Name = "fld_dteMMBatchProductDate";
            this.fld_dteMMBatchProductDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMBatchProductDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMBatchProductDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMBatchProductDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMBatchProductDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMBatchProductDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMBatchProductDate.Screen = null;
            this.fld_dteMMBatchProductDate.Size = new System.Drawing.Size(154, 20);
            this.fld_dteMMBatchProductDate.TabIndex = 3;
            this.fld_dteMMBatchProductDate.Tag = "DC";
            // 
            // fld_dteMMBatchProductToDate
            // 
            this.fld_dteMMBatchProductToDate.BOSComment = "";
            this.fld_dteMMBatchProductToDate.BOSDataMember = "MMBatchProductToDate";
            this.fld_dteMMBatchProductToDate.BOSDataSource = "MMBatchProducts";
            this.fld_dteMMBatchProductToDate.BOSDescription = null;
            this.fld_dteMMBatchProductToDate.BOSError = null;
            this.fld_dteMMBatchProductToDate.BOSFieldGroup = "";
            this.fld_dteMMBatchProductToDate.BOSFieldRelation = "";
            this.fld_dteMMBatchProductToDate.BOSPrivilege = "";
            this.fld_dteMMBatchProductToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMBatchProductToDate.EditValue = null;
            this.fld_dteMMBatchProductToDate.Location = new System.Drawing.Point(892, 11);
            this.fld_dteMMBatchProductToDate.Name = "fld_dteMMBatchProductToDate";
            this.fld_dteMMBatchProductToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMBatchProductToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMBatchProductToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMBatchProductToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMBatchProductToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMBatchProductToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMBatchProductToDate.Screen = null;
            this.fld_dteMMBatchProductToDate.Size = new System.Drawing.Size(154, 20);
            this.fld_dteMMBatchProductToDate.TabIndex = 7;
            this.fld_dteMMBatchProductToDate.Tag = "DC";
            // 
            // fld_dteMMBatchProductDeliveryDate
            // 
            this.fld_dteMMBatchProductDeliveryDate.BOSComment = "";
            this.fld_dteMMBatchProductDeliveryDate.BOSDataMember = "MMBatchProductDeliveryDate";
            this.fld_dteMMBatchProductDeliveryDate.BOSDataSource = "MMBatchProducts";
            this.fld_dteMMBatchProductDeliveryDate.BOSDescription = null;
            this.fld_dteMMBatchProductDeliveryDate.BOSError = null;
            this.fld_dteMMBatchProductDeliveryDate.BOSFieldGroup = "";
            this.fld_dteMMBatchProductDeliveryDate.BOSFieldRelation = "";
            this.fld_dteMMBatchProductDeliveryDate.BOSPrivilege = "";
            this.fld_dteMMBatchProductDeliveryDate.BOSPropertyName = "EditValue";
            this.fld_dteMMBatchProductDeliveryDate.EditValue = null;
            this.fld_dteMMBatchProductDeliveryDate.Location = new System.Drawing.Point(1174, 117);
            this.fld_dteMMBatchProductDeliveryDate.Name = "fld_dteMMBatchProductDeliveryDate";
            this.fld_dteMMBatchProductDeliveryDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMBatchProductDeliveryDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMBatchProductDeliveryDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMBatchProductDeliveryDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMBatchProductDeliveryDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMBatchProductDeliveryDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMBatchProductDeliveryDate.Screen = null;
            this.fld_dteMMBatchProductDeliveryDate.Size = new System.Drawing.Size(154, 20);
            this.fld_dteMMBatchProductDeliveryDate.TabIndex = 21;
            this.fld_dteMMBatchProductDeliveryDate.Tag = "DC";
            this.fld_dteMMBatchProductDeliveryDate.Visible = false;
            this.fld_dteMMBatchProductDeliveryDate.EditValueChanged += new System.EventHandler(this.fld_dteMMBatchProductDeliveryDate_EditValueChanged);
            // 
            // fld_dteMMBatchProductFromDate
            // 
            this.fld_dteMMBatchProductFromDate.BOSComment = "";
            this.fld_dteMMBatchProductFromDate.BOSDataMember = "MMBatchProductFromDate";
            this.fld_dteMMBatchProductFromDate.BOSDataSource = "MMBatchProducts";
            this.fld_dteMMBatchProductFromDate.BOSDescription = null;
            this.fld_dteMMBatchProductFromDate.BOSError = null;
            this.fld_dteMMBatchProductFromDate.BOSFieldGroup = "";
            this.fld_dteMMBatchProductFromDate.BOSFieldRelation = "";
            this.fld_dteMMBatchProductFromDate.BOSPrivilege = "";
            this.fld_dteMMBatchProductFromDate.BOSPropertyName = "EditValue";
            this.fld_dteMMBatchProductFromDate.EditValue = null;
            this.fld_dteMMBatchProductFromDate.Location = new System.Drawing.Point(630, 12);
            this.fld_dteMMBatchProductFromDate.Name = "fld_dteMMBatchProductFromDate";
            this.fld_dteMMBatchProductFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMBatchProductFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMBatchProductFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMBatchProductFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMBatchProductFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMBatchProductFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMBatchProductFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMBatchProductFromDate, true);
            this.fld_dteMMBatchProductFromDate.Size = new System.Drawing.Size(154, 20);
            this.fld_dteMMBatchProductFromDate.TabIndex = 5;
            this.fld_dteMMBatchProductFromDate.Tag = "DC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMBatchProducts";
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
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(77, 38);
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
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(154, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 9;
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
            this.bosLabel1.Location = new System.Drawing.Point(18, 15);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(52, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã lệnh SX";
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
            this.bosLabel8.Location = new System.Drawing.Point(530, 41);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(56, 13);
            this.bosLabel8.TabIndex = 12;
            this.bosLabel8.Text = "Khách hàng";
            // 
            // fld_txtMMBatchProductNo
            // 
            this.fld_txtMMBatchProductNo.BOSComment = null;
            this.fld_txtMMBatchProductNo.BOSDataMember = "MMBatchProductNo";
            this.fld_txtMMBatchProductNo.BOSDataSource = "MMBatchProducts";
            this.fld_txtMMBatchProductNo.BOSDescription = null;
            this.fld_txtMMBatchProductNo.BOSError = null;
            this.fld_txtMMBatchProductNo.BOSFieldGroup = null;
            this.fld_txtMMBatchProductNo.BOSFieldRelation = null;
            this.fld_txtMMBatchProductNo.BOSPrivilege = null;
            this.fld_txtMMBatchProductNo.BOSPropertyName = "EditValue";
            this.fld_txtMMBatchProductNo.Location = new System.Drawing.Point(77, 12);
            this.fld_txtMMBatchProductNo.MenuManager = this.screenToolbar;
            this.fld_txtMMBatchProductNo.Name = "fld_txtMMBatchProductNo";
            this.fld_txtMMBatchProductNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMBatchProductNo, true);
            this.fld_txtMMBatchProductNo.Size = new System.Drawing.Size(154, 20);
            this.fld_txtMMBatchProductNo.TabIndex = 1;
            this.fld_txtMMBatchProductNo.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(18, 94);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 18;
            this.bosLabel5.Text = "Diễn giải";
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
            this.bosLabel7.Location = new System.Drawing.Point(269, 15);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(42, 13);
            this.bosLabel7.TabIndex = 2;
            this.bosLabel7.Text = "Ngày lập";
            // 
            // DMBP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1390, 712);
            this.Controls.Add(this.panel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMBP100.IconOptions.Icon")));
            this.Name = "DMBP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeARProductionPlanningSaleType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeARSaleOrderIsDeliveryPlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACObjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductGeneralMaterialStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductPackagingStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductPaintStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductHWStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductWoodStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ICProductAttributeTTMTID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductResourceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMPriority.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProductItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_mmoMMBatchProductMultiCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMBatchProductDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductDeliveryDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductDeliveryDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMBatchProductFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMBatchProductNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private Panel panel1;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductType;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLookupEdit fld_lkeMMPriority;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductStatus;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSMemoEdit fld_medMMBatchProductDesc;
        private BOSComponent.BOSDateEdit fld_dteMMBatchProductDate;
        private BOSComponent.BOSDateEdit fld_dteMMBatchProductToDate;
        private BOSComponent.BOSDateEdit fld_dteMMBatchProductDeliveryDate;
        private BOSComponent.BOSDateEdit fld_dteMMBatchProductFromDate;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMBatchProductNo;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel7;
        private MMBatchProductItemsGridControl fld_dgcMMBatchProductItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductResourceType;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel fld_lbWoodType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ICProductAttributeTTMTID;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductWoodStatus;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductHWStatus;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductPaintStatus;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductPackagingStatus;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel21;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductGeneralMaterialStatus;
        private AccObjectLookupEdit fld_lkeFK_ACObjectID;
        private BOSComponent.BOSCheckEdit fld_ckeARSaleOrderIsDeliveryPlan;
        private BOSComponent.BOSMemoEdit fld_mmoMMBatchProductMultiCustomer;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLookupEdit fld_lkeARProductionPlanningSaleType;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel bosLabel22;
    }
}
