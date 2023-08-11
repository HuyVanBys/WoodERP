using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Operation.UI
{
	/// <summary>
	/// Summary description for DMOP100
	/// </summary>
	partial class DMOP100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMOP100));
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMOperationName = new BOSComponent.BOSTextBox(this.components);
            this.fld_medMMOperationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtMMOperationNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMLineOperations = new BOSERP.Modules.Operation.MMLineOperationGridControl();
            this.fld_dgvGridControl1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_chkMMOperationCostCalculationCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_txtMMOperationOrder = new BOSComponent.BOSTextBox(this.components);
            this.fld_chkMMOperationInOutStockCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationGroup = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMOperationAcronym = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACDebitAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACCostAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMProductionComplexityByOperations = new BOSERP.Modules.Operation.MMProductionComplexityByOperationsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_dgcMMOperationMachineGroups = new BOSERP.Modules.Operation.MMOperationMachineGroupsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblOperationSync = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_MMOperationID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_ckeMMOperationIsBeginOperation = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkMMOperationIsOutSourcing = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeMMOperationNeedQC = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_chkMMOperationForParentSyncCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeMMOperationSyncProductCheck = new BOSComponent.BOSCheckEdit(this.components);
            this.fld_ckeMMOperationIsPlan = new BOSComponent.BOSCheckEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMOperationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMLineOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMOperationCostCalculationCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMOperationInOutStockCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationAcronym.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDebitAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionComplexityByOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationMachineGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMMOperationIsBeginOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMOperationIsOutSourcing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMMOperationNeedQC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMOperationForParentSyncCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMMOperationSyncProductCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMMOperationIsPlan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseFont = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(15, 9);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel12.TabIndex = 0;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Mã công đoạn";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseFont = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(274, 9);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(74, 13);
            this.fld_lblLabel14.TabIndex = 2;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Tên công đoạn";
            // 
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseFont = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = "";
            this.fld_lblLabel18.BOSDataMember = "";
            this.fld_lblLabel18.BOSDataSource = "";
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = "";
            this.fld_lblLabel18.BOSFieldRelation = "";
            this.fld_lblLabel18.BOSPrivilege = "";
            this.fld_lblLabel18.BOSPropertyName = null;
            this.fld_lblLabel18.Location = new System.Drawing.Point(15, 112);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel18.TabIndex = 27;
            this.fld_lblLabel18.Tag = "";
            this.fld_lblLabel18.Text = "Diễn giải";
            // 
            // fld_txtMMOperationName
            // 
            this.fld_txtMMOperationName.BOSComment = "";
            this.fld_txtMMOperationName.BOSDataMember = "MMOperationName";
            this.fld_txtMMOperationName.BOSDataSource = "MMOperations";
            this.fld_txtMMOperationName.BOSDescription = null;
            this.fld_txtMMOperationName.BOSError = "";
            this.fld_txtMMOperationName.BOSFieldGroup = "";
            this.fld_txtMMOperationName.BOSFieldRelation = "";
            this.fld_txtMMOperationName.BOSPrivilege = "";
            this.fld_txtMMOperationName.BOSPropertyName = "Text";
            this.fld_txtMMOperationName.Location = new System.Drawing.Point(364, 6);
            this.fld_txtMMOperationName.Name = "fld_txtMMOperationName";
            this.fld_txtMMOperationName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMOperationName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMOperationName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMOperationName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMOperationName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMOperationName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMOperationName.Screen = null;
            this.fld_txtMMOperationName.Size = new System.Drawing.Size(130, 20);
            this.fld_txtMMOperationName.TabIndex = 3;
            this.fld_txtMMOperationName.Tag = "DC";
            // 
            // fld_medMMOperationDesc
            // 
            this.fld_medMMOperationDesc.BOSComment = "";
            this.fld_medMMOperationDesc.BOSDataMember = "MMOperationDesc";
            this.fld_medMMOperationDesc.BOSDataSource = "MMOperations";
            this.fld_medMMOperationDesc.BOSDescription = null;
            this.fld_medMMOperationDesc.BOSError = "";
            this.fld_medMMOperationDesc.BOSFieldGroup = "";
            this.fld_medMMOperationDesc.BOSFieldRelation = "";
            this.fld_medMMOperationDesc.BOSPrivilege = "";
            this.fld_medMMOperationDesc.BOSPropertyName = "Text";
            this.fld_medMMOperationDesc.Location = new System.Drawing.Point(105, 112);
            this.fld_medMMOperationDesc.Name = "fld_medMMOperationDesc";
            this.fld_medMMOperationDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMOperationDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMOperationDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMOperationDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMOperationDesc.Screen = null;
            this.fld_medMMOperationDesc.Size = new System.Drawing.Size(130, 41);
            this.fld_medMMOperationDesc.TabIndex = 28;
            this.fld_medMMOperationDesc.Tag = "DC";
            // 
            // fld_txtMMOperationNo
            // 
            this.fld_txtMMOperationNo.BOSComment = "";
            this.fld_txtMMOperationNo.BOSDataMember = "MMOperationNo";
            this.fld_txtMMOperationNo.BOSDataSource = "MMOperations";
            this.fld_txtMMOperationNo.BOSDescription = null;
            this.fld_txtMMOperationNo.BOSError = "Mã kho không thể rỗng";
            this.fld_txtMMOperationNo.BOSFieldGroup = "";
            this.fld_txtMMOperationNo.BOSFieldRelation = "";
            this.fld_txtMMOperationNo.BOSPrivilege = "";
            this.fld_txtMMOperationNo.BOSPropertyName = "Text";
            this.fld_txtMMOperationNo.Location = new System.Drawing.Point(105, 6);
            this.fld_txtMMOperationNo.Name = "fld_txtMMOperationNo";
            this.fld_txtMMOperationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMOperationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMOperationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMOperationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMOperationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMOperationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMOperationNo.Screen = null;
            this.fld_txtMMOperationNo.Size = new System.Drawing.Size(130, 20);
            this.fld_txtMMOperationNo.TabIndex = 1;
            this.fld_txtMMOperationNo.Tag = "DC";
            // 
            // fld_dgcMMLineOperations
            // 
            this.fld_dgcMMLineOperations.AllowDrop = true;
            this.fld_dgcMMLineOperations.BOSComment = "";
            this.fld_dgcMMLineOperations.BOSDataMember = "";
            this.fld_dgcMMLineOperations.BOSDataSource = "MMLineOperations";
            this.fld_dgcMMLineOperations.BOSDescription = null;
            this.fld_dgcMMLineOperations.BOSError = null;
            this.fld_dgcMMLineOperations.BOSFieldGroup = "";
            this.fld_dgcMMLineOperations.BOSFieldRelation = "";
            this.fld_dgcMMLineOperations.BOSGridType = null;
            this.fld_dgcMMLineOperations.BOSPrivilege = "";
            this.fld_dgcMMLineOperations.BOSPropertyName = "";
            this.fld_dgcMMLineOperations.CommodityType = "";
            this.fld_dgcMMLineOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMLineOperations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMLineOperations.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMLineOperations.MainView = this.fld_dgvGridControl1;
            this.fld_dgcMMLineOperations.Name = "fld_dgcMMLineOperations";
            this.fld_dgcMMLineOperations.PrintReport = false;
            this.fld_dgcMMLineOperations.Screen = null;
            this.fld_dgcMMLineOperations.Size = new System.Drawing.Size(994, 462);
            this.fld_dgcMMLineOperations.TabIndex = 0;
            this.fld_dgcMMLineOperations.Tag = "DC";
            this.fld_dgcMMLineOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl1});
            // 
            // fld_dgvGridControl1
            // 
            this.fld_dgvGridControl1.GridControl = this.fld_dgcMMLineOperations;
            this.fld_dgvGridControl1.Name = "fld_dgvGridControl1";
            this.fld_dgvGridControl1.PaintStyleName = "Office2003";
            // 
            // fld_chkMMOperationCostCalculationCheck
            // 
            this.fld_chkMMOperationCostCalculationCheck.BOSComment = null;
            this.fld_chkMMOperationCostCalculationCheck.BOSDataMember = "MMOperationCostCalculationCheck";
            this.fld_chkMMOperationCostCalculationCheck.BOSDataSource = "MMOperations";
            this.fld_chkMMOperationCostCalculationCheck.BOSDescription = null;
            this.fld_chkMMOperationCostCalculationCheck.BOSError = null;
            this.fld_chkMMOperationCostCalculationCheck.BOSFieldGroup = null;
            this.fld_chkMMOperationCostCalculationCheck.BOSFieldRelation = null;
            this.fld_chkMMOperationCostCalculationCheck.BOSPrivilege = null;
            this.fld_chkMMOperationCostCalculationCheck.BOSPropertyName = "EditValue";
            this.fld_chkMMOperationCostCalculationCheck.Location = new System.Drawing.Point(532, 60);
            this.fld_chkMMOperationCostCalculationCheck.Name = "fld_chkMMOperationCostCalculationCheck";
            this.fld_chkMMOperationCostCalculationCheck.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_chkMMOperationCostCalculationCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkMMOperationCostCalculationCheck.Properties.Caption = "Tính giá thành";
            this.fld_chkMMOperationCostCalculationCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkMMOperationCostCalculationCheck, true);
            this.fld_chkMMOperationCostCalculationCheck.Size = new System.Drawing.Size(101, 20);
            this.fld_chkMMOperationCostCalculationCheck.TabIndex = 20;
            this.fld_chkMMOperationCostCalculationCheck.Tag = "DC";
            this.fld_chkMMOperationCostCalculationCheck.CheckedChanged += new System.EventHandler(this.Fld_chkMMOperationCostCalculationCheck_CheckedChanged);
            // 
            // fld_txtMMOperationOrder
            // 
            this.fld_txtMMOperationOrder.BOSComment = "";
            this.fld_txtMMOperationOrder.BOSDataMember = "MMOperationOrder";
            this.fld_txtMMOperationOrder.BOSDataSource = "MMOperations";
            this.fld_txtMMOperationOrder.BOSDescription = null;
            this.fld_txtMMOperationOrder.BOSError = "Mã kho không thể rỗng";
            this.fld_txtMMOperationOrder.BOSFieldGroup = "";
            this.fld_txtMMOperationOrder.BOSFieldRelation = "";
            this.fld_txtMMOperationOrder.BOSPrivilege = "";
            this.fld_txtMMOperationOrder.BOSPropertyName = "Text";
            this.fld_txtMMOperationOrder.Location = new System.Drawing.Point(105, 32);
            this.fld_txtMMOperationOrder.Name = "fld_txtMMOperationOrder";
            this.fld_txtMMOperationOrder.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMOperationOrder.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMOperationOrder.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMOperationOrder.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMOperationOrder.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMOperationOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMOperationOrder.Screen = null;
            this.fld_txtMMOperationOrder.Size = new System.Drawing.Size(130, 20);
            this.fld_txtMMOperationOrder.TabIndex = 5;
            this.fld_txtMMOperationOrder.Tag = "DC";
            // 
            // fld_chkMMOperationInOutStockCheck
            // 
            this.fld_chkMMOperationInOutStockCheck.BOSComment = null;
            this.fld_chkMMOperationInOutStockCheck.BOSDataMember = "MMOperationInOutStockCheck";
            this.fld_chkMMOperationInOutStockCheck.BOSDataSource = "MMOperations";
            this.fld_chkMMOperationInOutStockCheck.BOSDescription = null;
            this.fld_chkMMOperationInOutStockCheck.BOSError = null;
            this.fld_chkMMOperationInOutStockCheck.BOSFieldGroup = null;
            this.fld_chkMMOperationInOutStockCheck.BOSFieldRelation = null;
            this.fld_chkMMOperationInOutStockCheck.BOSPrivilege = null;
            this.fld_chkMMOperationInOutStockCheck.BOSPropertyName = "EditValue";
            this.fld_chkMMOperationInOutStockCheck.Location = new System.Drawing.Point(532, 84);
            this.fld_chkMMOperationInOutStockCheck.Name = "fld_chkMMOperationInOutStockCheck";
            this.fld_chkMMOperationInOutStockCheck.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_chkMMOperationInOutStockCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkMMOperationInOutStockCheck.Properties.Caption = "Nhập kho";
            this.fld_chkMMOperationInOutStockCheck.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_chkMMOperationInOutStockCheck, true);
            this.fld_chkMMOperationInOutStockCheck.Size = new System.Drawing.Size(129, 20);
            this.fld_chkMMOperationInOutStockCheck.TabIndex = 22;
            this.fld_chkMMOperationInOutStockCheck.Tag = "DC";
            this.fld_chkMMOperationInOutStockCheck.CheckedChanged += new System.EventHandler(this.fld_chkMMOperationInOutStockCheck_CheckedChanged);
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
            this.bosLabel1.Location = new System.Drawing.Point(15, 36);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(86, 13);
            this.bosLabel1.TabIndex = 4;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Thứ tự công đoạn";
            // 
            // fld_lkeMMOperationGroup
            // 
            this.fld_lkeMMOperationGroup.BOSAllowAddNew = false;
            this.fld_lkeMMOperationGroup.BOSAllowDummy = false;
            this.fld_lkeMMOperationGroup.BOSComment = "";
            this.fld_lkeMMOperationGroup.BOSDataMember = "MMOperationGroup";
            this.fld_lkeMMOperationGroup.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationGroup.BOSDescription = null;
            this.fld_lkeMMOperationGroup.BOSError = null;
            this.fld_lkeMMOperationGroup.BOSFieldGroup = "";
            this.fld_lkeMMOperationGroup.BOSFieldParent = "";
            this.fld_lkeMMOperationGroup.BOSFieldRelation = "";
            this.fld_lkeMMOperationGroup.BOSPrivilege = "";
            this.fld_lkeMMOperationGroup.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationGroup.BOSSelectType = "";
            this.fld_lkeMMOperationGroup.BOSSelectTypeValue = "";
            this.fld_lkeMMOperationGroup.CurrentDisplayText = "";
            this.fld_lkeMMOperationGroup.Location = new System.Drawing.Point(364, 32);
            this.fld_lkeMMOperationGroup.Name = "fld_lkeMMOperationGroup";
            this.fld_lkeMMOperationGroup.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMOperationGroup.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationGroup.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationGroup.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationGroup.Properties.ColumnName = null;
            this.fld_lkeMMOperationGroup.Properties.NullText = "";
            this.fld_lkeMMOperationGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationGroup.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMOperationGroup, true);
            this.fld_lkeMMOperationGroup.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeMMOperationGroup.TabIndex = 7;
            this.fld_lkeMMOperationGroup.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(274, 35);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(83, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Nhóm công đoạn";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(532, 9);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(20, 13);
            this.bosLabel3.TabIndex = 16;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "Loại";
            // 
            // fld_lkeMMOperationType
            // 
            this.fld_lkeMMOperationType.BOSAllowAddNew = false;
            this.fld_lkeMMOperationType.BOSAllowDummy = true;
            this.fld_lkeMMOperationType.BOSComment = "";
            this.fld_lkeMMOperationType.BOSDataMember = "MMOperationType";
            this.fld_lkeMMOperationType.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationType.BOSDescription = null;
            this.fld_lkeMMOperationType.BOSError = null;
            this.fld_lkeMMOperationType.BOSFieldGroup = "";
            this.fld_lkeMMOperationType.BOSFieldParent = "";
            this.fld_lkeMMOperationType.BOSFieldRelation = "";
            this.fld_lkeMMOperationType.BOSPrivilege = "";
            this.fld_lkeMMOperationType.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationType.BOSSelectType = "";
            this.fld_lkeMMOperationType.BOSSelectTypeValue = "";
            this.fld_lkeMMOperationType.CurrentDisplayText = "";
            this.fld_lkeMMOperationType.Location = new System.Drawing.Point(679, 6);
            this.fld_lkeMMOperationType.Name = "fld_lkeMMOperationType";
            this.fld_lkeMMOperationType.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMOperationType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationType.Properties.ColumnName = null;
            this.fld_lkeMMOperationType.Properties.NullText = "";
            this.fld_lkeMMOperationType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationType.Screen = null;
            this.fld_lkeMMOperationType.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeMMOperationType.TabIndex = 17;
            this.fld_lkeMMOperationType.Tag = "DC";
            // 
            // fld_lkeFK_ACAccountID
            // 
            this.fld_lkeFK_ACAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACAccountID.BOSAllowDummy = true;
            this.fld_lkeFK_ACAccountID.BOSComment = null;
            this.fld_lkeFK_ACAccountID.BOSDataMember = "FK_ACAccountID";
            this.fld_lkeFK_ACAccountID.BOSDataSource = "MMOperations";
            this.fld_lkeFK_ACAccountID.BOSDescription = null;
            this.fld_lkeFK_ACAccountID.BOSError = null;
            this.fld_lkeFK_ACAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACAccountID.Location = new System.Drawing.Point(105, 84);
            this.fld_lkeFK_ACAccountID.Name = "fld_lkeFK_ACAccountID";
            this.fld_lkeFK_ACAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACAccountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACAccountID.Properties.NullText = "";
            this.fld_lkeFK_ACAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACAccountID.Screen = null;
            this.fld_lkeFK_ACAccountID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_ACAccountID.TabIndex = 13;
            this.fld_lkeFK_ACAccountID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = "";
            this.bosLabel4.BOSDataMember = "";
            this.bosLabel4.BOSDataSource = "";
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = "";
            this.bosLabel4.BOSFieldRelation = "";
            this.bosLabel4.BOSPrivilege = "";
            this.bosLabel4.BOSPropertyName = "";
            this.bosLabel4.Location = new System.Drawing.Point(15, 87);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(54, 13);
            this.bosLabel4.TabIndex = 12;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "TK dở dang";
            // 
            // fld_txtMMOperationAcronym
            // 
            this.fld_txtMMOperationAcronym.BOSComment = "";
            this.fld_txtMMOperationAcronym.BOSDataMember = "MMOperationAcronym";
            this.fld_txtMMOperationAcronym.BOSDataSource = "MMOperations";
            this.fld_txtMMOperationAcronym.BOSDescription = null;
            this.fld_txtMMOperationAcronym.BOSError = "";
            this.fld_txtMMOperationAcronym.BOSFieldGroup = "";
            this.fld_txtMMOperationAcronym.BOSFieldRelation = "";
            this.fld_txtMMOperationAcronym.BOSPrivilege = "";
            this.fld_txtMMOperationAcronym.BOSPropertyName = "Text";
            this.fld_txtMMOperationAcronym.Location = new System.Drawing.Point(364, 84);
            this.fld_txtMMOperationAcronym.Name = "fld_txtMMOperationAcronym";
            this.fld_txtMMOperationAcronym.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMOperationAcronym.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMOperationAcronym.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMOperationAcronym.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMOperationAcronym.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMOperationAcronym.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMOperationAcronym.Screen = null;
            this.fld_txtMMOperationAcronym.Size = new System.Drawing.Size(130, 20);
            this.fld_txtMMOperationAcronym.TabIndex = 15;
            this.fld_txtMMOperationAcronym.Tag = "DC";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
            this.bosLabel5.Appearance.Options.UseFont = true;
            this.bosLabel5.Appearance.Options.UseForeColor = true;
            this.bosLabel5.BOSComment = "";
            this.bosLabel5.BOSDataMember = "";
            this.bosLabel5.BOSDataSource = "";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = "";
            this.bosLabel5.BOSFieldRelation = "";
            this.bosLabel5.BOSPrivilege = "";
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(274, 87);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(52, 13);
            this.bosLabel5.TabIndex = 14;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Serie prefix";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel6.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel6.Appearance.Options.UseBackColor = true;
            this.bosLabel6.Appearance.Options.UseForeColor = true;
            this.bosLabel6.BOSComment = "";
            this.bosLabel6.BOSDataMember = "";
            this.bosLabel6.BOSDataSource = "";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = "";
            this.bosLabel6.BOSFieldRelation = "";
            this.bosLabel6.BOSPrivilege = "";
            this.bosLabel6.BOSPropertyName = "";
            this.bosLabel6.Location = new System.Drawing.Point(15, 62);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(66, 13);
            this.bosLabel6.TabIndex = 8;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "TK BTP/TP CD";
            // 
            // fld_lkeFK_ACDebitAccountID
            // 
            this.fld_lkeFK_ACDebitAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACDebitAccountID.BOSAllowDummy = true;
            this.fld_lkeFK_ACDebitAccountID.BOSComment = null;
            this.fld_lkeFK_ACDebitAccountID.BOSDataMember = "FK_ACIngrogressAccountID";
            this.fld_lkeFK_ACDebitAccountID.BOSDataSource = "MMOperations";
            this.fld_lkeFK_ACDebitAccountID.BOSDescription = null;
            this.fld_lkeFK_ACDebitAccountID.BOSError = null;
            this.fld_lkeFK_ACDebitAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACDebitAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACDebitAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACDebitAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACDebitAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACDebitAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACDebitAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACDebitAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACDebitAccountID.Location = new System.Drawing.Point(105, 59);
            this.fld_lkeFK_ACDebitAccountID.Name = "fld_lkeFK_ACDebitAccountID";
            this.fld_lkeFK_ACDebitAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACDebitAccountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACDebitAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACDebitAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACDebitAccountID.Properties.NullText = "";
            this.fld_lkeFK_ACDebitAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACDebitAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACDebitAccountID.Screen = null;
            this.fld_lkeFK_ACDebitAccountID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_ACDebitAccountID.TabIndex = 9;
            this.fld_lkeFK_ACDebitAccountID.Tag = "DC";
            // 
            // fld_lkeFK_ACCostAccountID
            // 
            this.fld_lkeFK_ACCostAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACCostAccountID.BOSAllowDummy = true;
            this.fld_lkeFK_ACCostAccountID.BOSComment = null;
            this.fld_lkeFK_ACCostAccountID.BOSDataMember = "FK_ACCostAccountID";
            this.fld_lkeFK_ACCostAccountID.BOSDataSource = "MMOperations";
            this.fld_lkeFK_ACCostAccountID.BOSDescription = null;
            this.fld_lkeFK_ACCostAccountID.BOSError = null;
            this.fld_lkeFK_ACCostAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACCostAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACCostAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACCostAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACCostAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACCostAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACCostAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACCostAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACCostAccountID.Location = new System.Drawing.Point(364, 59);
            this.fld_lkeFK_ACCostAccountID.Name = "fld_lkeFK_ACCostAccountID";
            this.fld_lkeFK_ACCostAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACCostAccountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACCostAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACCostAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACCostAccountID.Properties.NullText = "";
            this.fld_lkeFK_ACCostAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACCostAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACCostAccountID.Screen = null;
            this.fld_lkeFK_ACCostAccountID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_ACCostAccountID.TabIndex = 11;
            this.fld_lkeFK_ACCostAccountID.Tag = "DC";
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment = "";
            this.bosLabel7.BOSDataMember = "";
            this.bosLabel7.BOSDataSource = "";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = "";
            this.bosLabel7.BOSFieldRelation = "";
            this.bosLabel7.BOSPrivilege = "";
            this.bosLabel7.BOSPropertyName = "";
            this.bosLabel7.Location = new System.Drawing.Point(274, 62);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(62, 13);
            this.bosLabel7.TabIndex = 10;
            this.bosLabel7.Tag = "";
            this.bosLabel7.Text = "TK chi phí CD";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 159);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(996, 487);
            this.bosTabControl1.TabIndex = 29;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage3,
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcMMLineOperations);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.PageVisible = false;
            this.xtraTabPage1.Size = new System.Drawing.Size(994, 462);
            this.xtraTabPage1.Text = "Chuyền";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.fld_dgcMMProductionComplexityByOperations);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(994, 462);
            this.xtraTabPage3.Text = "Cấu hình";
            // 
            // fld_dgcMMProductionComplexityByOperations
            // 
            this.fld_dgcMMProductionComplexityByOperations.AllowDrop = true;
            this.fld_dgcMMProductionComplexityByOperations.BOSComment = "";
            this.fld_dgcMMProductionComplexityByOperations.BOSDataMember = "";
            this.fld_dgcMMProductionComplexityByOperations.BOSDataSource = "MMProductionComplexityByOperations";
            this.fld_dgcMMProductionComplexityByOperations.BOSDescription = null;
            this.fld_dgcMMProductionComplexityByOperations.BOSError = null;
            this.fld_dgcMMProductionComplexityByOperations.BOSFieldGroup = "";
            this.fld_dgcMMProductionComplexityByOperations.BOSFieldRelation = "";
            this.fld_dgcMMProductionComplexityByOperations.BOSGridType = null;
            this.fld_dgcMMProductionComplexityByOperations.BOSPrivilege = "";
            this.fld_dgcMMProductionComplexityByOperations.BOSPropertyName = "";
            this.fld_dgcMMProductionComplexityByOperations.CommodityType = "";
            this.fld_dgcMMProductionComplexityByOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMProductionComplexityByOperations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMProductionComplexityByOperations.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMProductionComplexityByOperations.MainView = this.gridView2;
            this.fld_dgcMMProductionComplexityByOperations.Name = "fld_dgcMMProductionComplexityByOperations";
            this.fld_dgcMMProductionComplexityByOperations.PrintReport = false;
            this.fld_dgcMMProductionComplexityByOperations.Screen = null;
            this.fld_dgcMMProductionComplexityByOperations.Size = new System.Drawing.Size(994, 462);
            this.fld_dgcMMProductionComplexityByOperations.TabIndex = 1;
            this.fld_dgcMMProductionComplexityByOperations.Tag = "DC";
            this.fld_dgcMMProductionComplexityByOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMProductionComplexityByOperations;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosPanel1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(980, 455);
            this.xtraTabPage2.Text = "Nhóm máy";
            // 
            // bosPanel1
            // 
            this.bosPanel1.AutoScroll = true;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_dgcMMOperationMachineGroups);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(980, 455);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_dgcMMOperationMachineGroups
            // 
            this.fld_dgcMMOperationMachineGroups.AllowDrop = true;
            this.fld_dgcMMOperationMachineGroups.BOSComment = "";
            this.fld_dgcMMOperationMachineGroups.BOSDataMember = "";
            this.fld_dgcMMOperationMachineGroups.BOSDataSource = "MMOperationMachineGroups";
            this.fld_dgcMMOperationMachineGroups.BOSDescription = null;
            this.fld_dgcMMOperationMachineGroups.BOSError = null;
            this.fld_dgcMMOperationMachineGroups.BOSFieldGroup = "";
            this.fld_dgcMMOperationMachineGroups.BOSFieldRelation = "";
            this.fld_dgcMMOperationMachineGroups.BOSGridType = null;
            this.fld_dgcMMOperationMachineGroups.BOSPrivilege = "";
            this.fld_dgcMMOperationMachineGroups.BOSPropertyName = "";
            this.fld_dgcMMOperationMachineGroups.CommodityType = "";
            this.fld_dgcMMOperationMachineGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMOperationMachineGroups.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMOperationMachineGroups.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMOperationMachineGroups.MainView = this.gridView1;
            this.fld_dgcMMOperationMachineGroups.Name = "fld_dgcMMOperationMachineGroups";
            this.fld_dgcMMOperationMachineGroups.PrintReport = false;
            this.fld_dgcMMOperationMachineGroups.Screen = null;
            this.fld_dgcMMOperationMachineGroups.Size = new System.Drawing.Size(980, 455);
            this.fld_dgcMMOperationMachineGroups.TabIndex = 22;
            this.fld_dgcMMOperationMachineGroups.Tag = "DC";
            this.fld_dgcMMOperationMachineGroups.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMOperationMachineGroups;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosPanel2
            // 
            this.bosPanel2.AutoScroll = true;
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel2.Controls.Add(this.bosLabel8);
            this.bosPanel2.Controls.Add(this.fld_lblOperationSync);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_MMOperationID);
            this.bosPanel2.Controls.Add(this.fld_ckeMMOperationIsBeginOperation);
            this.bosPanel2.Controls.Add(this.fld_chkMMOperationIsOutSourcing);
            this.bosPanel2.Controls.Add(this.fld_ckeMMOperationNeedQC);
            this.bosPanel2.Controls.Add(this.fld_lblLabel12);
            this.bosPanel2.Controls.Add(this.bosTabControl1);
            this.bosPanel2.Controls.Add(this.fld_txtMMOperationNo);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ACCostAccountID);
            this.bosPanel2.Controls.Add(this.fld_medMMOperationDesc);
            this.bosPanel2.Controls.Add(this.bosLabel7);
            this.bosPanel2.Controls.Add(this.fld_txtMMOperationName);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ACDebitAccountID);
            this.bosPanel2.Controls.Add(this.fld_lblLabel18);
            this.bosPanel2.Controls.Add(this.bosLabel6);
            this.bosPanel2.Controls.Add(this.fld_lblLabel14);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_ACAccountID);
            this.bosPanel2.Controls.Add(this.fld_chkMMOperationCostCalculationCheck);
            this.bosPanel2.Controls.Add(this.bosLabel4);
            this.bosPanel2.Controls.Add(this.fld_chkMMOperationForParentSyncCheck);
            this.bosPanel2.Controls.Add(this.fld_ckeMMOperationSyncProductCheck);
            this.bosPanel2.Controls.Add(this.fld_ckeMMOperationIsPlan);
            this.bosPanel2.Controls.Add(this.fld_chkMMOperationInOutStockCheck);
            this.bosPanel2.Controls.Add(this.fld_lkeMMOperationType);
            this.bosPanel2.Controls.Add(this.fld_txtMMOperationOrder);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Controls.Add(this.fld_lkeMMOperationGroup);
            this.bosPanel2.Controls.Add(this.fld_txtMMOperationAcronym);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.bosLabel5);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1002, 649);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = false;
            this.fld_lkeFK_BRBranchID.BOSComment = null;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "MMOperations";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(364, 110);
            this.fld_lkeFK_BRBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = "";
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 105;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseFont = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment = "";
            this.bosLabel8.BOSDataMember = "";
            this.bosLabel8.BOSDataSource = "";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = "";
            this.bosLabel8.BOSFieldRelation = "";
            this.bosLabel8.BOSPrivilege = "";
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(274, 113);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel8, true);
            this.bosLabel8.Size = new System.Drawing.Size(48, 13);
            this.bosLabel8.TabIndex = 106;
            this.bosLabel8.Tag = "";
            this.bosLabel8.Text = "Chi nhánh";
            // 
            // fld_lblOperationSync
            // 
            this.fld_lblOperationSync.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblOperationSync.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblOperationSync.Appearance.Options.UseBackColor = true;
            this.fld_lblOperationSync.Appearance.Options.UseForeColor = true;
            this.fld_lblOperationSync.BOSComment = null;
            this.fld_lblOperationSync.BOSDataMember = "";
            this.fld_lblOperationSync.BOSDataSource = "";
            this.fld_lblOperationSync.BOSDescription = null;
            this.fld_lblOperationSync.BOSError = null;
            this.fld_lblOperationSync.BOSFieldGroup = "";
            this.fld_lblOperationSync.BOSFieldRelation = null;
            this.fld_lblOperationSync.BOSPrivilege = null;
            this.fld_lblOperationSync.BOSPropertyName = null;
            this.fld_lblOperationSync.Location = new System.Drawing.Point(532, 36);
            this.fld_lblOperationSync.Name = "fld_lblOperationSync";
            this.fld_lblOperationSync.Screen = null;
            this.fld_lblOperationSync.Size = new System.Drawing.Size(115, 13);
            this.fld_lblOperationSync.TabIndex = 18;
            this.fld_lblOperationSync.Text = "CĐ sử dụng SL để KTĐB";
            // 
            // fld_lkeFK_MMOperationID
            // 
            this.fld_lkeFK_MMOperationID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMOperationID.BOSAllowDummy = true;
            this.fld_lkeFK_MMOperationID.BOSComment = null;
            this.fld_lkeFK_MMOperationID.BOSDataMember = "FK_MMOperationSynID";
            this.fld_lkeFK_MMOperationID.BOSDataSource = "MMOperations";
            this.fld_lkeFK_MMOperationID.BOSDescription = null;
            this.fld_lkeFK_MMOperationID.BOSError = "";
            this.fld_lkeFK_MMOperationID.BOSFieldGroup = null;
            this.fld_lkeFK_MMOperationID.BOSFieldParent = null;
            this.fld_lkeFK_MMOperationID.BOSFieldRelation = null;
            this.fld_lkeFK_MMOperationID.BOSPrivilege = null;
            this.fld_lkeFK_MMOperationID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMOperationID.BOSSelectType = "";
            this.fld_lkeFK_MMOperationID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMOperationID.CurrentDisplayText = null;
            this.fld_lkeFK_MMOperationID.Location = new System.Drawing.Point(679, 33);
            this.fld_lkeFK_MMOperationID.Name = "fld_lkeFK_MMOperationID";
            this.fld_lkeFK_MMOperationID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_MMOperationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMOperationID.Properties.ColumnName = null;
            this.fld_lkeFK_MMOperationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMOperationName", "Công đoạn")});
            this.fld_lkeFK_MMOperationID.Properties.DisplayMember = "MMOperationName";
            this.fld_lkeFK_MMOperationID.Properties.NullText = "";
            this.fld_lkeFK_MMOperationID.Properties.PopupWidth = 40;
            this.fld_lkeFK_MMOperationID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMOperationID.Properties.ValueMember = "MMOperationID";
            this.fld_lkeFK_MMOperationID.Screen = null;
            this.fld_lkeFK_MMOperationID.Size = new System.Drawing.Size(130, 20);
            this.fld_lkeFK_MMOperationID.TabIndex = 19;
            this.fld_lkeFK_MMOperationID.Tag = "DC";
            this.fld_lkeFK_MMOperationID.Visible = false;
            // 
            // fld_ckeMMOperationIsBeginOperation
            // 
            this.fld_ckeMMOperationIsBeginOperation.BOSComment = null;
            this.fld_ckeMMOperationIsBeginOperation.BOSDataMember = "MMOperationIsBeginOperation";
            this.fld_ckeMMOperationIsBeginOperation.BOSDataSource = "MMOperations";
            this.fld_ckeMMOperationIsBeginOperation.BOSDescription = null;
            this.fld_ckeMMOperationIsBeginOperation.BOSError = null;
            this.fld_ckeMMOperationIsBeginOperation.BOSFieldGroup = null;
            this.fld_ckeMMOperationIsBeginOperation.BOSFieldRelation = null;
            this.fld_ckeMMOperationIsBeginOperation.BOSPrivilege = null;
            this.fld_ckeMMOperationIsBeginOperation.BOSPropertyName = "EditValue";
            this.fld_ckeMMOperationIsBeginOperation.Location = new System.Drawing.Point(679, 85);
            this.fld_ckeMMOperationIsBeginOperation.Name = "fld_ckeMMOperationIsBeginOperation";
            this.fld_ckeMMOperationIsBeginOperation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_ckeMMOperationIsBeginOperation.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckeMMOperationIsBeginOperation.Properties.Caption = "CD bắt đầu";
            this.fld_ckeMMOperationIsBeginOperation.Screen = null;
            this.fld_ckeMMOperationIsBeginOperation.Size = new System.Drawing.Size(129, 20);
            this.fld_ckeMMOperationIsBeginOperation.TabIndex = 25;
            this.fld_ckeMMOperationIsBeginOperation.Tag = "DC";
            // 
            // fld_chkMMOperationIsOutSourcing
            // 
            this.fld_chkMMOperationIsOutSourcing.BOSComment = null;
            this.fld_chkMMOperationIsOutSourcing.BOSDataMember = "MMOperationIsOutSourcing";
            this.fld_chkMMOperationIsOutSourcing.BOSDataSource = "MMOperations";
            this.fld_chkMMOperationIsOutSourcing.BOSDescription = null;
            this.fld_chkMMOperationIsOutSourcing.BOSError = null;
            this.fld_chkMMOperationIsOutSourcing.BOSFieldGroup = null;
            this.fld_chkMMOperationIsOutSourcing.BOSFieldRelation = null;
            this.fld_chkMMOperationIsOutSourcing.BOSPrivilege = null;
            this.fld_chkMMOperationIsOutSourcing.BOSPropertyName = "EditValue";
            this.fld_chkMMOperationIsOutSourcing.Location = new System.Drawing.Point(680, 134);
            this.fld_chkMMOperationIsOutSourcing.Name = "fld_chkMMOperationIsOutSourcing";
            this.fld_chkMMOperationIsOutSourcing.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_chkMMOperationIsOutSourcing.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkMMOperationIsOutSourcing.Properties.Caption = "Gia công";
            this.fld_chkMMOperationIsOutSourcing.Screen = null;
            this.fld_chkMMOperationIsOutSourcing.Size = new System.Drawing.Size(129, 20);
            this.fld_chkMMOperationIsOutSourcing.TabIndex = 23;
            this.fld_chkMMOperationIsOutSourcing.Tag = "DC";
            // 
            // fld_ckeMMOperationNeedQC
            // 
            this.fld_ckeMMOperationNeedQC.BOSComment = null;
            this.fld_ckeMMOperationNeedQC.BOSDataMember = "MMOperationNeedQC";
            this.fld_ckeMMOperationNeedQC.BOSDataSource = "MMOperations";
            this.fld_ckeMMOperationNeedQC.BOSDescription = null;
            this.fld_ckeMMOperationNeedQC.BOSError = null;
            this.fld_ckeMMOperationNeedQC.BOSFieldGroup = null;
            this.fld_ckeMMOperationNeedQC.BOSFieldRelation = null;
            this.fld_ckeMMOperationNeedQC.BOSPrivilege = null;
            this.fld_ckeMMOperationNeedQC.BOSPropertyName = "EditValue";
            this.fld_ckeMMOperationNeedQC.Location = new System.Drawing.Point(679, 60);
            this.fld_ckeMMOperationNeedQC.Name = "fld_ckeMMOperationNeedQC";
            this.fld_ckeMMOperationNeedQC.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_ckeMMOperationNeedQC.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckeMMOperationNeedQC.Properties.Caption = "QC năng suất";
            this.fld_ckeMMOperationNeedQC.Screen = null;
            this.fld_ckeMMOperationNeedQC.Size = new System.Drawing.Size(129, 20);
            this.fld_ckeMMOperationNeedQC.TabIndex = 23;
            this.fld_ckeMMOperationNeedQC.Tag = "DC";
            // 
            // fld_chkMMOperationForParentSyncCheck
            // 
            this.fld_chkMMOperationForParentSyncCheck.BOSComment = null;
            this.fld_chkMMOperationForParentSyncCheck.BOSDataMember = "MMOperationForParentSyncCheck";
            this.fld_chkMMOperationForParentSyncCheck.BOSDataSource = "MMOperations";
            this.fld_chkMMOperationForParentSyncCheck.BOSDescription = null;
            this.fld_chkMMOperationForParentSyncCheck.BOSError = null;
            this.fld_chkMMOperationForParentSyncCheck.BOSFieldGroup = null;
            this.fld_chkMMOperationForParentSyncCheck.BOSFieldRelation = null;
            this.fld_chkMMOperationForParentSyncCheck.BOSPrivilege = null;
            this.fld_chkMMOperationForParentSyncCheck.BOSPropertyName = "EditValue";
            this.fld_chkMMOperationForParentSyncCheck.Location = new System.Drawing.Point(679, 110);
            this.fld_chkMMOperationForParentSyncCheck.Name = "fld_chkMMOperationForParentSyncCheck";
            this.fld_chkMMOperationForParentSyncCheck.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_chkMMOperationForParentSyncCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkMMOperationForParentSyncCheck.Properties.Caption = "S.dụng SL KTĐB chi tiết cha";
            this.fld_chkMMOperationForParentSyncCheck.Screen = null;
            this.fld_chkMMOperationForParentSyncCheck.Size = new System.Drawing.Size(161, 20);
            this.fld_chkMMOperationForParentSyncCheck.TabIndex = 24;
            this.fld_chkMMOperationForParentSyncCheck.Tag = "DC";
            this.fld_chkMMOperationForParentSyncCheck.CheckedChanged += new System.EventHandler(this.Fld_ckeMMOperationSyncProductCheck_CheckedChanged);
            // 
            // fld_ckeMMOperationSyncProductCheck
            // 
            this.fld_ckeMMOperationSyncProductCheck.BOSComment = null;
            this.fld_ckeMMOperationSyncProductCheck.BOSDataMember = "MMOperationSyncProductCheck";
            this.fld_ckeMMOperationSyncProductCheck.BOSDataSource = "MMOperations";
            this.fld_ckeMMOperationSyncProductCheck.BOSDescription = null;
            this.fld_ckeMMOperationSyncProductCheck.BOSError = null;
            this.fld_ckeMMOperationSyncProductCheck.BOSFieldGroup = null;
            this.fld_ckeMMOperationSyncProductCheck.BOSFieldRelation = null;
            this.fld_ckeMMOperationSyncProductCheck.BOSPrivilege = null;
            this.fld_ckeMMOperationSyncProductCheck.BOSPropertyName = "EditValue";
            this.fld_ckeMMOperationSyncProductCheck.Location = new System.Drawing.Point(532, 109);
            this.fld_ckeMMOperationSyncProductCheck.Name = "fld_ckeMMOperationSyncProductCheck";
            this.fld_ckeMMOperationSyncProductCheck.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_ckeMMOperationSyncProductCheck.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckeMMOperationSyncProductCheck.Properties.Caption = "Cần K.Tra đồng bộ";
            this.fld_ckeMMOperationSyncProductCheck.Screen = null;
            this.fld_ckeMMOperationSyncProductCheck.Size = new System.Drawing.Size(137, 20);
            this.fld_ckeMMOperationSyncProductCheck.TabIndex = 24;
            this.fld_ckeMMOperationSyncProductCheck.Tag = "DC";
            this.fld_ckeMMOperationSyncProductCheck.CheckedChanged += new System.EventHandler(this.Fld_ckeMMOperationSyncProductCheck_CheckedChanged);
            // 
            // fld_ckeMMOperationIsPlan
            // 
            this.fld_ckeMMOperationIsPlan.BOSComment = null;
            this.fld_ckeMMOperationIsPlan.BOSDataMember = "MMOperationIsPlan";
            this.fld_ckeMMOperationIsPlan.BOSDataSource = "MMOperations";
            this.fld_ckeMMOperationIsPlan.BOSDescription = null;
            this.fld_ckeMMOperationIsPlan.BOSError = null;
            this.fld_ckeMMOperationIsPlan.BOSFieldGroup = null;
            this.fld_ckeMMOperationIsPlan.BOSFieldRelation = null;
            this.fld_ckeMMOperationIsPlan.BOSPrivilege = null;
            this.fld_ckeMMOperationIsPlan.BOSPropertyName = "EditValue";
            this.fld_ckeMMOperationIsPlan.Location = new System.Drawing.Point(532, 134);
            this.fld_ckeMMOperationIsPlan.Name = "fld_ckeMMOperationIsPlan";
            this.fld_ckeMMOperationIsPlan.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_ckeMMOperationIsPlan.Properties.Appearance.Options.UseBackColor = true;
            this.fld_ckeMMOperationIsPlan.Properties.Caption = "Có KHSX chi tiết";
            this.fld_ckeMMOperationIsPlan.Screen = null;
            this.fld_ckeMMOperationIsPlan.Size = new System.Drawing.Size(129, 20);
            this.fld_ckeMMOperationIsPlan.TabIndex = 26;
            this.fld_ckeMMOperationIsPlan.Tag = "DC";
            this.fld_ckeMMOperationIsPlan.CheckedChanged += new System.EventHandler(this.fld_chkMMOperationInOutStockCheck_CheckedChanged);
            // 
            // DMOP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1002, 649);
            this.Controls.Add(this.bosPanel2);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMOP100.IconOptions.Icon")));
            this.Name = "DMOP100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMOperationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMLineOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMOperationCostCalculationCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMOperationInOutStockCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMOperationAcronym.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDebitAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionComplexityByOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMOperationMachineGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMOperationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMMOperationIsBeginOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMOperationIsOutSourcing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMMOperationNeedQC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkMMOperationForParentSyncCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMMOperationSyncProductCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_ckeMMOperationIsPlan.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel18;
        private BOSComponent.BOSTextBox fld_txtMMOperationName;
        private BOSComponent.BOSMemoEdit fld_medMMOperationDesc;
        private BOSComponent.BOSTextBox fld_txtMMOperationNo;
        private IContainer components;
        private MMLineOperationGridControl fld_dgcMMLineOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl1;
        private BOSComponent.BOSCheckEdit fld_chkMMOperationCostCalculationCheck;
        private BOSComponent.BOSTextBox fld_txtMMOperationOrder;
        private BOSComponent.BOSCheckEdit fld_chkMMOperationInOutStockCheck;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationGroup;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationType;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACAccountID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSTextBox fld_txtMMOperationAcronym;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACDebitAccountID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACCostAccountID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSPanel bosPanel1;
        private MMOperationMachineGroupsGridControl fld_dgcMMOperationMachineGroups;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSCheckEdit fld_ckeMMOperationNeedQC;
        private BOSComponent.BOSCheckEdit fld_ckeMMOperationSyncProductCheck;
        private BOSComponent.BOSCheckEdit fld_ckeMMOperationIsBeginOperation;
        private BOSComponent.BOSCheckEdit fld_ckeMMOperationIsPlan;
        private BOSComponent.BOSLabel fld_lblOperationSync;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMOperationID;
        private BOSComponent.BOSCheckEdit fld_chkMMOperationForParentSyncCheck;
        private BOSComponent.BOSCheckEdit fld_chkMMOperationIsOutSourcing;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSComponent.BOSLabel bosLabel8;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private MMProductionComplexityByOperationsGridControl fld_dgcMMProductionComplexityByOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}
