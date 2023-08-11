using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCostFormula.UI
{
	/// <summary>
	/// Summary description for DMPCF100
	/// </summary>
	partial class DMPCF100
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
			this.bosLine2 = new BOSComponent.BOSLine(this.components);
			this.fld_chkIsProductGroup = new BOSComponent.BOSCheckEdit(this.components);
			this.fld_chkIsProject = new BOSComponent.BOSCheckEdit(this.components);
			this.fld_chkIsDepartment = new BOSComponent.BOSCheckEdit(this.components);
			this.fld_chkIsOperation = new BOSComponent.BOSCheckEdit(this.components);
			this.fld_chkIsSaleOrder = new BOSComponent.BOSCheckEdit(this.components);
			this.fld_chkIsProduct = new BOSComponent.BOSCheckEdit(this.components);
			this.fld_chkIsBatchProduct = new BOSComponent.BOSCheckEdit(this.components);
			this.fld_chkMMProductionCostFormulaHasReceiptShipment = new BOSComponent.BOSCheckEdit(this.components);
			this.fld_lblLabelSaleOrderType = new BOSComponent.BOSLabel(this.components);
			this.fld_lkeMMProductionCostFormulaType = new BOSComponent.BOSLookupEdit(this.components);
			this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.fld_dgcMMProductionCostFormulaDetails = new BOSERP.Modules.ProductionCostFormula.MMProductionCostFormulaDetailsGridControl();
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
			this.fld_dgcMMProductionCostFormulaOperations = new BOSERP.Modules.ProductionCostFormula.MMProductionCostFormulaOperationsGridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
			this.fld_dgcMMProductionCostFormulaOperationItems = new BOSERP.Modules.ProductionCostFormula.MMProductionCostFormulaOperationItemsGridControl();
			this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
			this.fld_btnAddProductGroup = new BOSComponent.BOSButton(this.components);
			this.fld_btnAddProduct = new BOSComponent.BOSButton(this.components);
			this.fld_dgcMMProductionCostFormulaProducts = new BOSERP.Modules.ProductionCostFormula.MMProductionCostFormulaProductsGridControl();
			this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.bosLine1 = new BOSComponent.BOSLine(this.components);
			this.fld_dteMMProductionCostFormulaToDate = new BOSComponent.BOSDateEdit(this.components);
			this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
			this.fld_dteMMProductionCostFormulaFromDate = new BOSComponent.BOSDateEdit(this.components);
			this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
			this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
			this.fld_txtMMProductionCostFormulaName = new BOSComponent.BOSTextBox(this.components);
			this.fld_dteMMProductionCostFormulaDate = new BOSComponent.BOSDateEdit(this.components);
			this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
			this.fld_medMMProductionCostFormulaDesc = new BOSComponent.BOSMemoEdit(this.components);
			this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
			this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
			this.fld_txtMMProductionCostFormulaNo = new BOSComponent.BOSTextBox(this.components);
			this.bosPanel1.SuspendLayout();
			this.bosLine2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsProductGroup.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsProject.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsDepartment.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsOperation.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsSaleOrder.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsProduct.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsBatchProduct.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkMMProductionCostFormulaHasReceiptShipment.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionCostFormulaType.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
			this.bosTabControl1.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormulaDetails)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			this.xtraTabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormulaOperations)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.xtraTabPage4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormulaOperationItems)).BeginInit();
			this.xtraTabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormulaProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
			this.bosLine1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaToDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaToDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaFromDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaFromDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostFormulaName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaDate.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionCostFormulaDesc.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostFormulaNo.Properties)).BeginInit();
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
			this.bosPanel1.Controls.Add(this.bosLine2);
			this.bosPanel1.Controls.Add(this.fld_chkMMProductionCostFormulaHasReceiptShipment);
			this.bosPanel1.Controls.Add(this.fld_lblLabelSaleOrderType);
			this.bosPanel1.Controls.Add(this.fld_lkeMMProductionCostFormulaType);
			this.bosPanel1.Controls.Add(this.bosTabControl1);
			this.bosPanel1.Controls.Add(this.bosLine1);
			this.bosPanel1.Controls.Add(this.bosLabel4);
			this.bosPanel1.Controls.Add(this.fld_txtMMProductionCostFormulaName);
			this.bosPanel1.Controls.Add(this.fld_dteMMProductionCostFormulaDate);
			this.bosPanel1.Controls.Add(this.bosLabel3);
			this.bosPanel1.Controls.Add(this.fld_medMMProductionCostFormulaDesc);
			this.bosPanel1.Controls.Add(this.bosLabel2);
			this.bosPanel1.Controls.Add(this.bosLabel1);
			this.bosPanel1.Controls.Add(this.fld_txtMMProductionCostFormulaNo);
			this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.bosPanel1.Location = new System.Drawing.Point(0, 0);
			this.bosPanel1.Name = "bosPanel1";
			this.bosPanel1.Screen = null;
			this.bosPanel1.Size = new System.Drawing.Size(982, 581);
			this.bosPanel1.TabIndex = 0;
			// 
			// bosLine2
			// 
			this.bosLine2.BOSComment = null;
			this.bosLine2.BOSDataMember = null;
			this.bosLine2.BOSDataSource = null;
			this.bosLine2.BOSDescription = null;
			this.bosLine2.BOSError = null;
			this.bosLine2.BOSFieldGroup = null;
			this.bosLine2.BOSFieldRelation = null;
			this.bosLine2.BOSPrivilege = null;
			this.bosLine2.BOSPropertyName = null;
			this.bosLine2.Controls.Add(this.fld_chkIsProductGroup);
			this.bosLine2.Controls.Add(this.fld_chkIsProject);
			this.bosLine2.Controls.Add(this.fld_chkIsDepartment);
			this.bosLine2.Controls.Add(this.fld_chkIsOperation);
			this.bosLine2.Controls.Add(this.fld_chkIsSaleOrder);
			this.bosLine2.Controls.Add(this.fld_chkIsProduct);
			this.bosLine2.Controls.Add(this.fld_chkIsBatchProduct);
			this.bosLine2.Location = new System.Drawing.Point(537, 12);
			this.bosLine2.Name = "bosLine2";
			this.bosLine2.Screen = null;
			this.bosLine2.Size = new System.Drawing.Size(265, 167);
			this.bosLine2.TabIndex = 112;
			this.bosLine2.TabStop = false;
			this.bosLine2.Text = "Tính giá thành theo:";
			// 
			// fld_chkIsProductGroup
			// 
			this.fld_chkIsProductGroup.BOSComment = null;
			this.fld_chkIsProductGroup.BOSDataMember = "IsProductGroup";
			this.fld_chkIsProductGroup.BOSDataSource = "MMProductionCostFormulas";
			this.fld_chkIsProductGroup.BOSDescription = null;
			this.fld_chkIsProductGroup.BOSError = null;
			this.fld_chkIsProductGroup.BOSFieldGroup = null;
			this.fld_chkIsProductGroup.BOSFieldRelation = null;
			this.fld_chkIsProductGroup.BOSPrivilege = null;
			this.fld_chkIsProductGroup.BOSPropertyName = "EditValue";
			this.fld_chkIsProductGroup.Location = new System.Drawing.Point(6, 102);
			this.fld_chkIsProductGroup.MenuManager = this.screenToolbar;
			this.fld_chkIsProductGroup.Name = "fld_chkIsProductGroup";
			this.fld_chkIsProductGroup.Properties.Caption = "Nhóm sản phẩm";
			this.fld_chkIsProductGroup.Screen = null;
			this.fld_chkIsProductGroup.Size = new System.Drawing.Size(119, 19);
			this.fld_chkIsProductGroup.TabIndex = 3;
			this.fld_chkIsProductGroup.Tag = "DC";
			// 
			// fld_chkIsProject
			// 
			this.fld_chkIsProject.BOSComment = null;
			this.fld_chkIsProject.BOSDataMember = "IsProject";
			this.fld_chkIsProject.BOSDataSource = "MMProductionCostFormulas";
			this.fld_chkIsProject.BOSDescription = null;
			this.fld_chkIsProject.BOSError = null;
			this.fld_chkIsProject.BOSFieldGroup = null;
			this.fld_chkIsProject.BOSFieldRelation = null;
			this.fld_chkIsProject.BOSPrivilege = null;
			this.fld_chkIsProject.BOSPropertyName = "EditValue";
			this.fld_chkIsProject.Location = new System.Drawing.Point(131, 77);
			this.fld_chkIsProject.MenuManager = this.screenToolbar;
			this.fld_chkIsProject.Name = "fld_chkIsProject";
			this.fld_chkIsProject.Properties.Caption = "Dự án";
			this.fld_chkIsProject.Screen = null;
			this.fld_chkIsProject.Size = new System.Drawing.Size(119, 19);
			this.fld_chkIsProject.TabIndex = 6;
			this.fld_chkIsProject.Tag = "DC";
			// 
			// fld_chkIsDepartment
			// 
			this.fld_chkIsDepartment.BOSComment = null;
			this.fld_chkIsDepartment.BOSDataMember = "IsDepartment";
			this.fld_chkIsDepartment.BOSDataSource = "MMProductionCostFormulas";
			this.fld_chkIsDepartment.BOSDescription = null;
			this.fld_chkIsDepartment.BOSError = null;
			this.fld_chkIsDepartment.BOSFieldGroup = null;
			this.fld_chkIsDepartment.BOSFieldRelation = null;
			this.fld_chkIsDepartment.BOSPrivilege = null;
			this.fld_chkIsDepartment.BOSPropertyName = "EditValue";
			this.fld_chkIsDepartment.Location = new System.Drawing.Point(131, 26);
			this.fld_chkIsDepartment.MenuManager = this.screenToolbar;
			this.fld_chkIsDepartment.Name = "fld_chkIsDepartment";
			this.fld_chkIsDepartment.Properties.Caption = "Xí nghiệp";
			this.fld_chkIsDepartment.Screen = null;
			this.fld_chkIsDepartment.Size = new System.Drawing.Size(119, 19);
			this.fld_chkIsDepartment.TabIndex = 4;
			this.fld_chkIsDepartment.Tag = "DC";
			// 
			// fld_chkIsOperation
			// 
			this.fld_chkIsOperation.BOSComment = null;
			this.fld_chkIsOperation.BOSDataMember = "IsOperation";
			this.fld_chkIsOperation.BOSDataSource = "MMProductionCostFormulas";
			this.fld_chkIsOperation.BOSDescription = null;
			this.fld_chkIsOperation.BOSError = null;
			this.fld_chkIsOperation.BOSFieldGroup = null;
			this.fld_chkIsOperation.BOSFieldRelation = null;
			this.fld_chkIsOperation.BOSPrivilege = null;
			this.fld_chkIsOperation.BOSPropertyName = "EditValue";
			this.fld_chkIsOperation.Location = new System.Drawing.Point(131, 52);
			this.fld_chkIsOperation.MenuManager = this.screenToolbar;
			this.fld_chkIsOperation.Name = "fld_chkIsOperation";
			this.fld_chkIsOperation.Properties.Caption = "Công đoạn";
			this.fld_chkIsOperation.Screen = null;
			this.fld_chkIsOperation.Size = new System.Drawing.Size(119, 19);
			this.fld_chkIsOperation.TabIndex = 5;
			this.fld_chkIsOperation.Tag = "DC";
			// 
			// fld_chkIsSaleOrder
			// 
			this.fld_chkIsSaleOrder.BOSComment = null;
			this.fld_chkIsSaleOrder.BOSDataMember = "IsSaleOrder";
			this.fld_chkIsSaleOrder.BOSDataSource = "MMProductionCostFormulas";
			this.fld_chkIsSaleOrder.BOSDescription = null;
			this.fld_chkIsSaleOrder.BOSError = null;
			this.fld_chkIsSaleOrder.BOSFieldGroup = null;
			this.fld_chkIsSaleOrder.BOSFieldRelation = null;
			this.fld_chkIsSaleOrder.BOSPrivilege = null;
			this.fld_chkIsSaleOrder.BOSPropertyName = "EditValue";
			this.fld_chkIsSaleOrder.Location = new System.Drawing.Point(6, 77);
			this.fld_chkIsSaleOrder.MenuManager = this.screenToolbar;
			this.fld_chkIsSaleOrder.Name = "fld_chkIsSaleOrder";
			this.fld_chkIsSaleOrder.Properties.Caption = "Đơn bán hàng";
			this.fld_chkIsSaleOrder.Screen = null;
			this.fld_chkIsSaleOrder.Size = new System.Drawing.Size(119, 19);
			this.fld_chkIsSaleOrder.TabIndex = 2;
			this.fld_chkIsSaleOrder.Tag = "DC";
			// 
			// fld_chkIsProduct
			// 
			this.fld_chkIsProduct.BOSComment = null;
			this.fld_chkIsProduct.BOSDataMember = "IsProduct";
			this.fld_chkIsProduct.BOSDataSource = "MMProductionCostFormulas";
			this.fld_chkIsProduct.BOSDescription = null;
			this.fld_chkIsProduct.BOSError = null;
			this.fld_chkIsProduct.BOSFieldGroup = null;
			this.fld_chkIsProduct.BOSFieldRelation = null;
			this.fld_chkIsProduct.BOSPrivilege = null;
			this.fld_chkIsProduct.BOSPropertyName = "EditValue";
			this.fld_chkIsProduct.Location = new System.Drawing.Point(6, 52);
			this.fld_chkIsProduct.MenuManager = this.screenToolbar;
			this.fld_chkIsProduct.Name = "fld_chkIsProduct";
			this.fld_chkIsProduct.Properties.Caption = "Sản phẩm";
			this.fld_chkIsProduct.Screen = null;
			this.fld_chkIsProduct.Size = new System.Drawing.Size(119, 19);
			this.fld_chkIsProduct.TabIndex = 1;
			this.fld_chkIsProduct.Tag = "DC";
			// 
			// fld_chkIsBatchProduct
			// 
			this.fld_chkIsBatchProduct.BOSComment = null;
			this.fld_chkIsBatchProduct.BOSDataMember = "IsBatchProduct";
			this.fld_chkIsBatchProduct.BOSDataSource = "MMProductionCostFormulas";
			this.fld_chkIsBatchProduct.BOSDescription = null;
			this.fld_chkIsBatchProduct.BOSError = null;
			this.fld_chkIsBatchProduct.BOSFieldGroup = null;
			this.fld_chkIsBatchProduct.BOSFieldRelation = null;
			this.fld_chkIsBatchProduct.BOSPrivilege = null;
			this.fld_chkIsBatchProduct.BOSPropertyName = "EditValue";
			this.fld_chkIsBatchProduct.Location = new System.Drawing.Point(6, 26);
			this.fld_chkIsBatchProduct.MenuManager = this.screenToolbar;
			this.fld_chkIsBatchProduct.Name = "fld_chkIsBatchProduct";
			this.fld_chkIsBatchProduct.Properties.Caption = "Lệnh sản xuất";
			this.fld_chkIsBatchProduct.Screen = null;
			this.fld_chkIsBatchProduct.Size = new System.Drawing.Size(119, 19);
			this.fld_chkIsBatchProduct.TabIndex = 0;
			this.fld_chkIsBatchProduct.Tag = "DC";
			// 
			// fld_chkMMProductionCostFormulaHasReceiptShipment
			// 
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSComment = null;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSDataMember = "MMProductionCostFormulaHasReceiptShipment";
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSDataSource = "MMProductionCostFormulas";
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSDescription = null;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSError = null;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSFieldGroup = null;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSFieldRelation = null;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSPrivilege = null;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.BOSPropertyName = "EditValue";
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.Location = new System.Drawing.Point(279, 65);
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.MenuManager = this.screenToolbar;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.Name = "fld_chkMMProductionCostFormulaHasReceiptShipment";
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.Properties.Caption = "Có nhập xuất kho";
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.Screen = null;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.Size = new System.Drawing.Size(176, 19);
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.TabIndex = 4;
			this.fld_chkMMProductionCostFormulaHasReceiptShipment.Tag = "DC";
			// 
			// fld_lblLabelSaleOrderType
			// 
			this.fld_lblLabelSaleOrderType.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_lblLabelSaleOrderType.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_lblLabelSaleOrderType.Appearance.Options.UseBackColor = true;
			this.fld_lblLabelSaleOrderType.Appearance.Options.UseForeColor = true;
			this.fld_lblLabelSaleOrderType.BOSComment = null;
			this.fld_lblLabelSaleOrderType.BOSDataMember = null;
			this.fld_lblLabelSaleOrderType.BOSDataSource = null;
			this.fld_lblLabelSaleOrderType.BOSDescription = null;
			this.fld_lblLabelSaleOrderType.BOSError = null;
			this.fld_lblLabelSaleOrderType.BOSFieldGroup = null;
			this.fld_lblLabelSaleOrderType.BOSFieldRelation = null;
			this.fld_lblLabelSaleOrderType.BOSPrivilege = null;
			this.fld_lblLabelSaleOrderType.BOSPropertyName = null;
			this.fld_lblLabelSaleOrderType.Location = new System.Drawing.Point(17, 67);
			this.fld_lblLabelSaleOrderType.Name = "fld_lblLabelSaleOrderType";
			this.fld_lblLabelSaleOrderType.Screen = null;
			this.ScreenHelper.SetShowHelp(this.fld_lblLabelSaleOrderType, true);
			this.fld_lblLabelSaleOrderType.Size = new System.Drawing.Size(70, 13);
			this.fld_lblLabelSaleOrderType.TabIndex = 111;
			this.fld_lblLabelSaleOrderType.Text = "Loại công thức";
			// 
			// fld_lkeMMProductionCostFormulaType
			// 
			this.fld_lkeMMProductionCostFormulaType.BOSAllowAddNew = false;
			this.fld_lkeMMProductionCostFormulaType.BOSAllowDummy = false;
			this.fld_lkeMMProductionCostFormulaType.BOSComment = null;
			this.fld_lkeMMProductionCostFormulaType.BOSDataMember = "MMProductionCostFormulaType";
			this.fld_lkeMMProductionCostFormulaType.BOSDataSource = "MMProductionCostFormulas";
			this.fld_lkeMMProductionCostFormulaType.BOSDescription = null;
			this.fld_lkeMMProductionCostFormulaType.BOSError = null;
			this.fld_lkeMMProductionCostFormulaType.BOSFieldGroup = null;
			this.fld_lkeMMProductionCostFormulaType.BOSFieldParent = null;
			this.fld_lkeMMProductionCostFormulaType.BOSFieldRelation = null;
			this.fld_lkeMMProductionCostFormulaType.BOSPrivilege = null;
			this.fld_lkeMMProductionCostFormulaType.BOSPropertyName = "EditValue";
			this.fld_lkeMMProductionCostFormulaType.BOSSelectType = "";
			this.fld_lkeMMProductionCostFormulaType.BOSSelectTypeValue = "";
			this.fld_lkeMMProductionCostFormulaType.CurrentDisplayText = null;
			this.fld_lkeMMProductionCostFormulaType.Location = new System.Drawing.Point(101, 64);
			this.fld_lkeMMProductionCostFormulaType.Name = "fld_lkeMMProductionCostFormulaType";
			this.fld_lkeMMProductionCostFormulaType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.fld_lkeMMProductionCostFormulaType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_lkeMMProductionCostFormulaType.Properties.Appearance.Options.UseBackColor = true;
			this.fld_lkeMMProductionCostFormulaType.Properties.Appearance.Options.UseForeColor = true;
			this.fld_lkeMMProductionCostFormulaType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fld_lkeMMProductionCostFormulaType.Properties.ColumnName = null;
			this.fld_lkeMMProductionCostFormulaType.Properties.NullText = "";
			this.fld_lkeMMProductionCostFormulaType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.fld_lkeMMProductionCostFormulaType.Screen = null;
			this.ScreenHelper.SetShowHelp(this.fld_lkeMMProductionCostFormulaType, true);
			this.fld_lkeMMProductionCostFormulaType.Size = new System.Drawing.Size(150, 20);
			this.fld_lkeMMProductionCostFormulaType.TabIndex = 3;
			this.fld_lkeMMProductionCostFormulaType.Tag = "DC";
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
			this.bosTabControl1.Location = new System.Drawing.Point(3, 185);
			this.bosTabControl1.Name = "bosTabControl1";
			this.bosTabControl1.Screen = null;
			this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
			this.bosTabControl1.Size = new System.Drawing.Size(976, 393);
			this.bosTabControl1.TabIndex = 6;
			this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage4,
            this.xtraTabPage3});
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Controls.Add(this.fld_dgcMMProductionCostFormulaDetails);
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(970, 365);
			this.xtraTabPage1.Text = "Chi tiết";
			// 
			// fld_dgcMMProductionCostFormulaDetails
			// 
			this.fld_dgcMMProductionCostFormulaDetails.AllowDrop = true;
			this.fld_dgcMMProductionCostFormulaDetails.BOSComment = null;
			this.fld_dgcMMProductionCostFormulaDetails.BOSDataMember = null;
			this.fld_dgcMMProductionCostFormulaDetails.BOSDataSource = "MMProductionCostFormulaDetails";
			this.fld_dgcMMProductionCostFormulaDetails.BOSDescription = null;
			this.fld_dgcMMProductionCostFormulaDetails.BOSError = null;
			this.fld_dgcMMProductionCostFormulaDetails.BOSFieldGroup = null;
			this.fld_dgcMMProductionCostFormulaDetails.BOSFieldRelation = null;
			this.fld_dgcMMProductionCostFormulaDetails.BOSGridType = null;
			this.fld_dgcMMProductionCostFormulaDetails.BOSPrivilege = null;
			this.fld_dgcMMProductionCostFormulaDetails.BOSPropertyName = null;
			this.fld_dgcMMProductionCostFormulaDetails.CommodityType = "";
			this.fld_dgcMMProductionCostFormulaDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fld_dgcMMProductionCostFormulaDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.fld_dgcMMProductionCostFormulaDetails.Location = new System.Drawing.Point(0, 0);
			this.fld_dgcMMProductionCostFormulaDetails.MainView = this.gridView2;
			this.fld_dgcMMProductionCostFormulaDetails.Name = "fld_dgcMMProductionCostFormulaDetails";
			this.fld_dgcMMProductionCostFormulaDetails.PrintReport = false;
			this.fld_dgcMMProductionCostFormulaDetails.Screen = null;
			this.fld_dgcMMProductionCostFormulaDetails.Size = new System.Drawing.Size(970, 365);
			this.fld_dgcMMProductionCostFormulaDetails.TabIndex = 0;
			this.fld_dgcMMProductionCostFormulaDetails.Tag = "DC";
			this.fld_dgcMMProductionCostFormulaDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
			// 
			// gridView2
			// 
			this.gridView2.GridControl = this.fld_dgcMMProductionCostFormulaDetails;
			this.gridView2.Name = "gridView2";
			this.gridView2.PaintStyleName = "Office2003";
			// 
			// xtraTabPage2
			// 
			this.xtraTabPage2.Controls.Add(this.fld_dgcMMProductionCostFormulaOperations);
			this.xtraTabPage2.Name = "xtraTabPage2";
			this.xtraTabPage2.Size = new System.Drawing.Size(970, 365);
			this.xtraTabPage2.Text = "Nhóm công đoạn";
			// 
			// fld_dgcMMProductionCostFormulaOperations
			// 
			this.fld_dgcMMProductionCostFormulaOperations.AllowDrop = true;
			this.fld_dgcMMProductionCostFormulaOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fld_dgcMMProductionCostFormulaOperations.BOSComment = null;
			this.fld_dgcMMProductionCostFormulaOperations.BOSDataMember = null;
			this.fld_dgcMMProductionCostFormulaOperations.BOSDataSource = "MMProductionCostFormulaOperations";
			this.fld_dgcMMProductionCostFormulaOperations.BOSDescription = null;
			this.fld_dgcMMProductionCostFormulaOperations.BOSError = null;
			this.fld_dgcMMProductionCostFormulaOperations.BOSFieldGroup = null;
			this.fld_dgcMMProductionCostFormulaOperations.BOSFieldRelation = null;
			this.fld_dgcMMProductionCostFormulaOperations.BOSGridType = null;
			this.fld_dgcMMProductionCostFormulaOperations.BOSPrivilege = null;
			this.fld_dgcMMProductionCostFormulaOperations.BOSPropertyName = null;
			this.fld_dgcMMProductionCostFormulaOperations.CommodityType = "";
			this.fld_dgcMMProductionCostFormulaOperations.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.fld_dgcMMProductionCostFormulaOperations.Location = new System.Drawing.Point(0, 0);
			this.fld_dgcMMProductionCostFormulaOperations.MainView = this.gridView1;
			this.fld_dgcMMProductionCostFormulaOperations.Name = "fld_dgcMMProductionCostFormulaOperations";
			this.fld_dgcMMProductionCostFormulaOperations.PrintReport = false;
			this.fld_dgcMMProductionCostFormulaOperations.Screen = null;
			this.fld_dgcMMProductionCostFormulaOperations.Size = new System.Drawing.Size(970, 365);
			this.fld_dgcMMProductionCostFormulaOperations.TabIndex = 4;
			this.fld_dgcMMProductionCostFormulaOperations.Tag = "DC";
			this.fld_dgcMMProductionCostFormulaOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.GridControl = this.fld_dgcMMProductionCostFormulaOperations;
			this.gridView1.Name = "gridView1";
			this.gridView1.PaintStyleName = "Office2003";
			// 
			// xtraTabPage4
			// 
			this.xtraTabPage4.Controls.Add(this.fld_dgcMMProductionCostFormulaOperationItems);
			this.xtraTabPage4.Name = "xtraTabPage4";
			this.xtraTabPage4.Size = new System.Drawing.Size(970, 365);
			this.xtraTabPage4.Text = "Công đoạn";
			// 
			// fld_dgcMMProductionCostFormulaOperationItems
			// 
			this.fld_dgcMMProductionCostFormulaOperationItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSComment = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSDataMember = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSDataSource = "MMProductionCostFormulaOperationItems";
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSDescription = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSError = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSFieldGroup = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSFieldRelation = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSGridType = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSPrivilege = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.BOSPropertyName = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.CommodityType = "";
			this.fld_dgcMMProductionCostFormulaOperationItems.Location = new System.Drawing.Point(3, 3);
			this.fld_dgcMMProductionCostFormulaOperationItems.MenuManager = this.screenToolbar;
			this.fld_dgcMMProductionCostFormulaOperationItems.Name = "fld_dgcMMProductionCostFormulaOperationItems";
			this.fld_dgcMMProductionCostFormulaOperationItems.PrintReport = false;
			this.fld_dgcMMProductionCostFormulaOperationItems.Screen = null;
			this.fld_dgcMMProductionCostFormulaOperationItems.Size = new System.Drawing.Size(967, 358);
			this.fld_dgcMMProductionCostFormulaOperationItems.TabIndex = 0;
			// 
			// xtraTabPage3
			// 
			this.xtraTabPage3.Controls.Add(this.fld_btnAddProductGroup);
			this.xtraTabPage3.Controls.Add(this.fld_btnAddProduct);
			this.xtraTabPage3.Controls.Add(this.fld_dgcMMProductionCostFormulaProducts);
			this.xtraTabPage3.Name = "xtraTabPage3";
			this.xtraTabPage3.Size = new System.Drawing.Size(964, 358);
			this.xtraTabPage3.Text = "Sản phẩm áp dụng";
			// 
			// fld_btnAddProductGroup
			// 
			this.fld_btnAddProductGroup.BOSComment = null;
			this.fld_btnAddProductGroup.BOSDataMember = null;
			this.fld_btnAddProductGroup.BOSDataSource = null;
			this.fld_btnAddProductGroup.BOSDescription = null;
			this.fld_btnAddProductGroup.BOSError = null;
			this.fld_btnAddProductGroup.BOSFieldGroup = null;
			this.fld_btnAddProductGroup.BOSFieldRelation = null;
			this.fld_btnAddProductGroup.BOSPrivilege = null;
			this.fld_btnAddProductGroup.BOSPropertyName = null;
			this.fld_btnAddProductGroup.ImageOptions.Image = global::BOSERP.MES.Properties.Resources.table_add_icon;
			this.fld_btnAddProductGroup.Location = new System.Drawing.Point(130, 3);
			this.fld_btnAddProductGroup.Name = "fld_btnAddProductGroup";
			this.fld_btnAddProductGroup.Screen = null;
			this.fld_btnAddProductGroup.Size = new System.Drawing.Size(121, 27);
			this.fld_btnAddProductGroup.TabIndex = 1;
			this.fld_btnAddProductGroup.Text = "Chọn nhóm hàng";
			this.fld_btnAddProductGroup.Click += new System.EventHandler(this.fld_btnAddProductGroup_Click);
			// 
			// fld_btnAddProduct
			// 
			this.fld_btnAddProduct.BOSComment = null;
			this.fld_btnAddProduct.BOSDataMember = null;
			this.fld_btnAddProduct.BOSDataSource = null;
			this.fld_btnAddProduct.BOSDescription = null;
			this.fld_btnAddProduct.BOSError = null;
			this.fld_btnAddProduct.BOSFieldGroup = null;
			this.fld_btnAddProduct.BOSFieldRelation = null;
			this.fld_btnAddProduct.BOSPrivilege = null;
			this.fld_btnAddProduct.BOSPropertyName = null;
			this.fld_btnAddProduct.ImageOptions.Image = global::BOSERP.MES.Properties.Resources.table_add_icon;
			this.fld_btnAddProduct.Location = new System.Drawing.Point(3, 3);
			this.fld_btnAddProduct.Name = "fld_btnAddProduct";
			this.fld_btnAddProduct.Screen = null;
			this.fld_btnAddProduct.Size = new System.Drawing.Size(121, 27);
			this.fld_btnAddProduct.TabIndex = 0;
			this.fld_btnAddProduct.Text = "Chọn sản phẩm";
			this.fld_btnAddProduct.Click += new System.EventHandler(this.fld_btnAddProduct_Click);
			// 
			// fld_dgcMMProductionCostFormulaProducts
			// 
			this.fld_dgcMMProductionCostFormulaProducts.AllowDrop = true;
			this.fld_dgcMMProductionCostFormulaProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fld_dgcMMProductionCostFormulaProducts.BOSComment = null;
			this.fld_dgcMMProductionCostFormulaProducts.BOSDataMember = null;
			this.fld_dgcMMProductionCostFormulaProducts.BOSDataSource = "MMProductionCostFormulaProducts";
			this.fld_dgcMMProductionCostFormulaProducts.BOSDescription = null;
			this.fld_dgcMMProductionCostFormulaProducts.BOSError = null;
			this.fld_dgcMMProductionCostFormulaProducts.BOSFieldGroup = null;
			this.fld_dgcMMProductionCostFormulaProducts.BOSFieldRelation = null;
			this.fld_dgcMMProductionCostFormulaProducts.BOSGridType = null;
			this.fld_dgcMMProductionCostFormulaProducts.BOSPrivilege = null;
			this.fld_dgcMMProductionCostFormulaProducts.BOSPropertyName = null;
			this.fld_dgcMMProductionCostFormulaProducts.CommodityType = "";
			this.fld_dgcMMProductionCostFormulaProducts.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.fld_dgcMMProductionCostFormulaProducts.Location = new System.Drawing.Point(0, 36);
			this.fld_dgcMMProductionCostFormulaProducts.MainView = this.gridView3;
			this.fld_dgcMMProductionCostFormulaProducts.Name = "fld_dgcMMProductionCostFormulaProducts";
			this.fld_dgcMMProductionCostFormulaProducts.PrintReport = false;
			this.fld_dgcMMProductionCostFormulaProducts.Screen = null;
			this.fld_dgcMMProductionCostFormulaProducts.Size = new System.Drawing.Size(964, 322);
			this.fld_dgcMMProductionCostFormulaProducts.TabIndex = 2;
			this.fld_dgcMMProductionCostFormulaProducts.Tag = "DC";
			this.fld_dgcMMProductionCostFormulaProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
			// 
			// gridView3
			// 
			this.gridView3.GridControl = this.fld_dgcMMProductionCostFormulaProducts;
			this.gridView3.Name = "gridView3";
			this.gridView3.PaintStyleName = "Office2003";
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
			this.bosLine1.Controls.Add(this.fld_dteMMProductionCostFormulaToDate);
			this.bosLine1.Controls.Add(this.bosLabel6);
			this.bosLine1.Controls.Add(this.fld_dteMMProductionCostFormulaFromDate);
			this.bosLine1.Controls.Add(this.bosLabel5);
			this.bosLine1.Location = new System.Drawing.Point(8, 90);
			this.bosLine1.Name = "bosLine1";
			this.bosLine1.Screen = null;
			this.bosLine1.Size = new System.Drawing.Size(523, 46);
			this.bosLine1.TabIndex = 3;
			this.bosLine1.TabStop = false;
			this.bosLine1.Text = "Thời gian áp dụng";
			// 
			// fld_dteMMProductionCostFormulaToDate
			// 
			this.fld_dteMMProductionCostFormulaToDate.BOSComment = null;
			this.fld_dteMMProductionCostFormulaToDate.BOSDataMember = "MMProductionCostFormulaToDate";
			this.fld_dteMMProductionCostFormulaToDate.BOSDataSource = "MMProductionCostFormulas";
			this.fld_dteMMProductionCostFormulaToDate.BOSDescription = null;
			this.fld_dteMMProductionCostFormulaToDate.BOSError = null;
			this.fld_dteMMProductionCostFormulaToDate.BOSFieldGroup = null;
			this.fld_dteMMProductionCostFormulaToDate.BOSFieldRelation = null;
			this.fld_dteMMProductionCostFormulaToDate.BOSPrivilege = null;
			this.fld_dteMMProductionCostFormulaToDate.BOSPropertyName = "EditValue";
			this.fld_dteMMProductionCostFormulaToDate.EditValue = null;
			this.fld_dteMMProductionCostFormulaToDate.Location = new System.Drawing.Point(362, 20);
			this.fld_dteMMProductionCostFormulaToDate.Name = "fld_dteMMProductionCostFormulaToDate";
			this.fld_dteMMProductionCostFormulaToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.fld_dteMMProductionCostFormulaToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_dteMMProductionCostFormulaToDate.Properties.Appearance.Options.UseBackColor = true;
			this.fld_dteMMProductionCostFormulaToDate.Properties.Appearance.Options.UseForeColor = true;
			this.fld_dteMMProductionCostFormulaToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fld_dteMMProductionCostFormulaToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.fld_dteMMProductionCostFormulaToDate.Screen = null;
			this.fld_dteMMProductionCostFormulaToDate.Size = new System.Drawing.Size(150, 20);
			this.fld_dteMMProductionCostFormulaToDate.TabIndex = 1;
			this.fld_dteMMProductionCostFormulaToDate.Tag = "DC";
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
			this.bosLabel6.Location = new System.Drawing.Point(273, 23);
			this.bosLabel6.Name = "bosLabel6";
			this.bosLabel6.Screen = null;
			this.bosLabel6.Size = new System.Drawing.Size(47, 13);
			this.bosLabel6.TabIndex = 86;
			this.bosLabel6.Text = "Đến ngày";
			// 
			// fld_dteMMProductionCostFormulaFromDate
			// 
			this.fld_dteMMProductionCostFormulaFromDate.BOSComment = null;
			this.fld_dteMMProductionCostFormulaFromDate.BOSDataMember = "MMProductionCostFormulaFromDate";
			this.fld_dteMMProductionCostFormulaFromDate.BOSDataSource = "MMProductionCostFormulas";
			this.fld_dteMMProductionCostFormulaFromDate.BOSDescription = null;
			this.fld_dteMMProductionCostFormulaFromDate.BOSError = null;
			this.fld_dteMMProductionCostFormulaFromDate.BOSFieldGroup = null;
			this.fld_dteMMProductionCostFormulaFromDate.BOSFieldRelation = null;
			this.fld_dteMMProductionCostFormulaFromDate.BOSPrivilege = null;
			this.fld_dteMMProductionCostFormulaFromDate.BOSPropertyName = "EditValue";
			this.fld_dteMMProductionCostFormulaFromDate.EditValue = null;
			this.fld_dteMMProductionCostFormulaFromDate.Location = new System.Drawing.Point(93, 20);
			this.fld_dteMMProductionCostFormulaFromDate.Name = "fld_dteMMProductionCostFormulaFromDate";
			this.fld_dteMMProductionCostFormulaFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.fld_dteMMProductionCostFormulaFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_dteMMProductionCostFormulaFromDate.Properties.Appearance.Options.UseBackColor = true;
			this.fld_dteMMProductionCostFormulaFromDate.Properties.Appearance.Options.UseForeColor = true;
			this.fld_dteMMProductionCostFormulaFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fld_dteMMProductionCostFormulaFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.fld_dteMMProductionCostFormulaFromDate.Screen = null;
			this.fld_dteMMProductionCostFormulaFromDate.Size = new System.Drawing.Size(150, 20);
			this.fld_dteMMProductionCostFormulaFromDate.TabIndex = 0;
			this.fld_dteMMProductionCostFormulaFromDate.Tag = "DC";
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
			this.bosLabel5.Location = new System.Drawing.Point(9, 23);
			this.bosLabel5.Name = "bosLabel5";
			this.bosLabel5.Screen = null;
			this.bosLabel5.Size = new System.Drawing.Size(40, 13);
			this.bosLabel5.TabIndex = 84;
			this.bosLabel5.Text = "Từ ngày";
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
			this.bosLabel4.Location = new System.Drawing.Point(17, 41);
			this.bosLabel4.Name = "bosLabel4";
			this.bosLabel4.Screen = null;
			this.bosLabel4.Size = new System.Drawing.Size(69, 13);
			this.bosLabel4.TabIndex = 83;
			this.bosLabel4.Text = "Tên công thức";
			// 
			// fld_txtMMProductionCostFormulaName
			// 
			this.fld_txtMMProductionCostFormulaName.BOSComment = "";
			this.fld_txtMMProductionCostFormulaName.BOSDataMember = "MMProductionCostFormulaName";
			this.fld_txtMMProductionCostFormulaName.BOSDataSource = "MMProductionCostFormulas";
			this.fld_txtMMProductionCostFormulaName.BOSDescription = null;
			this.fld_txtMMProductionCostFormulaName.BOSError = null;
			this.fld_txtMMProductionCostFormulaName.BOSFieldGroup = "";
			this.fld_txtMMProductionCostFormulaName.BOSFieldRelation = "";
			this.fld_txtMMProductionCostFormulaName.BOSPrivilege = "";
			this.fld_txtMMProductionCostFormulaName.BOSPropertyName = "Text";
			this.fld_txtMMProductionCostFormulaName.EditValue = "";
			this.fld_txtMMProductionCostFormulaName.Location = new System.Drawing.Point(101, 38);
			this.fld_txtMMProductionCostFormulaName.Name = "fld_txtMMProductionCostFormulaName";
			this.fld_txtMMProductionCostFormulaName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.fld_txtMMProductionCostFormulaName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_txtMMProductionCostFormulaName.Properties.Appearance.Options.UseBackColor = true;
			this.fld_txtMMProductionCostFormulaName.Properties.Appearance.Options.UseForeColor = true;
			this.fld_txtMMProductionCostFormulaName.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtMMProductionCostFormulaName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fld_txtMMProductionCostFormulaName.Screen = null;
			this.fld_txtMMProductionCostFormulaName.Size = new System.Drawing.Size(419, 20);
			this.fld_txtMMProductionCostFormulaName.TabIndex = 2;
			this.fld_txtMMProductionCostFormulaName.Tag = "DC";
			// 
			// fld_dteMMProductionCostFormulaDate
			// 
			this.fld_dteMMProductionCostFormulaDate.BOSComment = null;
			this.fld_dteMMProductionCostFormulaDate.BOSDataMember = "MMProductionCostFormulaDate";
			this.fld_dteMMProductionCostFormulaDate.BOSDataSource = "MMProductionCostFormulas";
			this.fld_dteMMProductionCostFormulaDate.BOSDescription = null;
			this.fld_dteMMProductionCostFormulaDate.BOSError = null;
			this.fld_dteMMProductionCostFormulaDate.BOSFieldGroup = null;
			this.fld_dteMMProductionCostFormulaDate.BOSFieldRelation = null;
			this.fld_dteMMProductionCostFormulaDate.BOSPrivilege = null;
			this.fld_dteMMProductionCostFormulaDate.BOSPropertyName = "EditValue";
			this.fld_dteMMProductionCostFormulaDate.EditValue = null;
			this.fld_dteMMProductionCostFormulaDate.Location = new System.Drawing.Point(370, 12);
			this.fld_dteMMProductionCostFormulaDate.Name = "fld_dteMMProductionCostFormulaDate";
			this.fld_dteMMProductionCostFormulaDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.fld_dteMMProductionCostFormulaDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_dteMMProductionCostFormulaDate.Properties.Appearance.Options.UseBackColor = true;
			this.fld_dteMMProductionCostFormulaDate.Properties.Appearance.Options.UseForeColor = true;
			this.fld_dteMMProductionCostFormulaDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fld_dteMMProductionCostFormulaDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.fld_dteMMProductionCostFormulaDate.Screen = null;
			this.fld_dteMMProductionCostFormulaDate.Size = new System.Drawing.Size(150, 20);
			this.fld_dteMMProductionCostFormulaDate.TabIndex = 1;
			this.fld_dteMMProductionCostFormulaDate.Tag = "DC";
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
			this.bosLabel3.Location = new System.Drawing.Point(17, 145);
			this.bosLabel3.Name = "bosLabel3";
			this.bosLabel3.Screen = null;
			this.bosLabel3.Size = new System.Drawing.Size(40, 13);
			this.bosLabel3.TabIndex = 79;
			this.bosLabel3.Text = "Diễn giải";
			// 
			// fld_medMMProductionCostFormulaDesc
			// 
			this.fld_medMMProductionCostFormulaDesc.BOSComment = "";
			this.fld_medMMProductionCostFormulaDesc.BOSDataMember = "MMProductionCostFormulaDesc";
			this.fld_medMMProductionCostFormulaDesc.BOSDataSource = "MMProductionCostFormulas";
			this.fld_medMMProductionCostFormulaDesc.BOSDescription = null;
			this.fld_medMMProductionCostFormulaDesc.BOSError = null;
			this.fld_medMMProductionCostFormulaDesc.BOSFieldGroup = "";
			this.fld_medMMProductionCostFormulaDesc.BOSFieldRelation = "";
			this.fld_medMMProductionCostFormulaDesc.BOSPrivilege = "";
			this.fld_medMMProductionCostFormulaDesc.BOSPropertyName = "EditValue";
			this.fld_medMMProductionCostFormulaDesc.EditValue = "";
			this.fld_medMMProductionCostFormulaDesc.Location = new System.Drawing.Point(101, 142);
			this.fld_medMMProductionCostFormulaDesc.Name = "fld_medMMProductionCostFormulaDesc";
			this.fld_medMMProductionCostFormulaDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.fld_medMMProductionCostFormulaDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_medMMProductionCostFormulaDesc.Properties.Appearance.Options.UseBackColor = true;
			this.fld_medMMProductionCostFormulaDesc.Properties.Appearance.Options.UseForeColor = true;
			this.fld_medMMProductionCostFormulaDesc.Screen = null;
			this.ScreenHelper.SetShowHelp(this.fld_medMMProductionCostFormulaDesc, true);
			this.fld_medMMProductionCostFormulaDesc.Size = new System.Drawing.Size(430, 37);
			this.fld_medMMProductionCostFormulaDesc.TabIndex = 5;
			this.fld_medMMProductionCostFormulaDesc.Tag = "DC";
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
			this.bosLabel2.Location = new System.Drawing.Point(281, 15);
			this.bosLabel2.Name = "bosLabel2";
			this.bosLabel2.Screen = null;
			this.bosLabel2.Size = new System.Drawing.Size(44, 13);
			this.bosLabel2.TabIndex = 13;
			this.bosLabel2.Text = "Ngày tạo";
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
			this.bosLabel1.Location = new System.Drawing.Point(17, 15);
			this.bosLabel1.Name = "bosLabel1";
			this.bosLabel1.Screen = null;
			this.bosLabel1.Size = new System.Drawing.Size(65, 13);
			this.bosLabel1.TabIndex = 11;
			this.bosLabel1.Text = "Mã công thức";
			// 
			// fld_txtMMProductionCostFormulaNo
			// 
			this.fld_txtMMProductionCostFormulaNo.BOSComment = "";
			this.fld_txtMMProductionCostFormulaNo.BOSDataMember = "MMProductionCostFormulaNo";
			this.fld_txtMMProductionCostFormulaNo.BOSDataSource = "MMProductionCostFormulas";
			this.fld_txtMMProductionCostFormulaNo.BOSDescription = null;
			this.fld_txtMMProductionCostFormulaNo.BOSError = null;
			this.fld_txtMMProductionCostFormulaNo.BOSFieldGroup = "";
			this.fld_txtMMProductionCostFormulaNo.BOSFieldRelation = "";
			this.fld_txtMMProductionCostFormulaNo.BOSPrivilege = "";
			this.fld_txtMMProductionCostFormulaNo.BOSPropertyName = "Text";
			this.fld_txtMMProductionCostFormulaNo.EditValue = "";
			this.fld_txtMMProductionCostFormulaNo.Location = new System.Drawing.Point(101, 12);
			this.fld_txtMMProductionCostFormulaNo.Name = "fld_txtMMProductionCostFormulaNo";
			this.fld_txtMMProductionCostFormulaNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.fld_txtMMProductionCostFormulaNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.fld_txtMMProductionCostFormulaNo.Properties.Appearance.Options.UseBackColor = true;
			this.fld_txtMMProductionCostFormulaNo.Properties.Appearance.Options.UseForeColor = true;
			this.fld_txtMMProductionCostFormulaNo.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.fld_txtMMProductionCostFormulaNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.fld_txtMMProductionCostFormulaNo.Screen = null;
			this.fld_txtMMProductionCostFormulaNo.Size = new System.Drawing.Size(150, 20);
			this.fld_txtMMProductionCostFormulaNo.TabIndex = 0;
			this.fld_txtMMProductionCostFormulaNo.Tag = "DC";
			// 
			// DMPCF100
			// 
			this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Appearance.Options.UseForeColor = true;
			this.ClientSize = new System.Drawing.Size(982, 581);
			this.Controls.Add(this.bosPanel1);
			this.Name = "DMPCF100";
			this.Text = "Thông tin";
			this.Controls.SetChildIndex(this.bosPanel1, 0);
			this.bosPanel1.ResumeLayout(false);
			this.bosPanel1.PerformLayout();
			this.bosLine2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsProductGroup.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsProject.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsDepartment.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsOperation.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsSaleOrder.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsProduct.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkIsBatchProduct.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_chkMMProductionCostFormulaHasReceiptShipment.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMProductionCostFormulaType.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
			this.bosTabControl1.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormulaDetails)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			this.xtraTabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormulaOperations)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.xtraTabPage4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormulaOperationItems)).EndInit();
			this.xtraTabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormulaProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
			this.bosLine1.ResumeLayout(false);
			this.bosLine1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaToDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaToDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaFromDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaFromDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostFormulaName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostFormulaDate.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionCostFormulaDesc.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostFormulaNo.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostFormulaNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medMMProductionCostFormulaDesc;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostFormulaDate;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostFormulaName;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostFormulaFromDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostFormulaToDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private MMProductionCostFormulaDetailsGridControl fld_dgcMMProductionCostFormulaDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private MMProductionCostFormulaOperationsGridControl fld_dgcMMProductionCostFormulaOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private MMProductionCostFormulaProductsGridControl fld_dgcMMProductionCostFormulaProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSLabel fld_lblLabelSaleOrderType;
        private BOSComponent.BOSLookupEdit fld_lkeMMProductionCostFormulaType;
        private BOSComponent.BOSCheckEdit fld_chkMMProductionCostFormulaHasReceiptShipment;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSCheckEdit fld_chkIsProductGroup;
        private BOSComponent.BOSCheckEdit fld_chkIsProject;
        private BOSComponent.BOSCheckEdit fld_chkIsDepartment;
        private BOSComponent.BOSCheckEdit fld_chkIsOperation;
        private BOSComponent.BOSCheckEdit fld_chkIsSaleOrder;
        private BOSComponent.BOSCheckEdit fld_chkIsProduct;
        private BOSComponent.BOSCheckEdit fld_chkIsBatchProduct;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private MMProductionCostFormulaOperationItemsGridControl fld_dgcMMProductionCostFormulaOperationItems;
        private BOSComponent.BOSButton fld_btnAddProductGroup;
	}
}
