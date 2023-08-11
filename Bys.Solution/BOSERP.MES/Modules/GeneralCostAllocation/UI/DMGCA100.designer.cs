using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSERP.Modules.ProductionCostFormula;

namespace BOSERP.Modules.GeneralCostAllocation.UI
{
	/// <summary>
	/// Summary description for DMPCF100
	/// </summary>
    partial class DMGCA100
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
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_MMProductionCostFactorID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACCreditAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ACDebitAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionCostGeneralCostAllocationToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcDetails = new BOSERP.Modules.GeneralCostAllocation.MMProductionCostGeneralCostAllocationDetailsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteMMProductionCostGeneralCostAllocationDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMProductionCostGeneralCostAllocationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostGeneralCostAllocationNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFactorID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCreditAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDebitAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionCostGeneralCostAllocationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostGeneralCostAllocationNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.fld_txtMMProductionCostGeneralCostAllocationTotalCost);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_MMProductionCostFactorID);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACCreditAccountID);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lkeFK_ACDebitAccountID);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.fld_dteMMProductionCostGeneralCostAllocationToDate);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_dteMMProductionCostGeneralCostAllocationFromDate);
            this.bosPanel1.Controls.Add(this.fld_dteMMProductionCostGeneralCostAllocationDate);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_medMMProductionCostGeneralCostAllocationDesc);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_txtMMProductionCostGeneralCostAllocationNo);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 435);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel10.Location = new System.Drawing.Point(281, 119);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(48, 13);
            this.bosLabel10.TabIndex = 602;
            this.bosLabel10.Tag = "SI";
            this.bosLabel10.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldParent =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(370, 116);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 8;
            this.fld_lkeFK_BRBranchID.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel9.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel9.Appearance.Options.UseBackColor = true;
            this.bosLabel9.Appearance.Options.UseForeColor = true;
            this.bosLabel9.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.Location = new System.Drawing.Point(17, 119);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(57, 13);
            this.bosLabel9.TabIndex = 345;
            this.bosLabel9.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel9.Text = "Tổng chi phí";
            // 
            // fld_txtMMProductionCostGeneralCostAllocationTotalCost
            // 
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSDataMember = "MMProductionCostGeneralCostAllocationTotalCost";
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSDescription = null;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSError = null;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.EditValue = "0.00";
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Location = new System.Drawing.Point(101, 116);
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Name = "fld_txtMMProductionCostGeneralCostAllocationTotalCost";
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties.Mask.EditMask = "n0";
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties.ReadOnly = true;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Screen = null;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.TabIndex = 7;
            this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Tag = "DC";
            // 
            // fld_lkeFK_MMProductionCostFactorID
            // 
            this.fld_lkeFK_MMProductionCostFactorID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionCostFactorID.BOSAllowDummy = false;
            this.fld_lkeFK_MMProductionCostFactorID.BOSComment = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSDataMember = "FK_MMProductionCostFactorID";
            this.fld_lkeFK_MMProductionCostFactorID.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_lkeFK_MMProductionCostFactorID.BOSDescription = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSError = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionCostFactorID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionCostFactorID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionCostFactorID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionCostFactorID.Location = new System.Drawing.Point(101, 90);
            this.fld_lkeFK_MMProductionCostFactorID.Name = "fld_lkeFK_MMProductionCostFactorID";
            this.fld_lkeFK_MMProductionCostFactorID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionCostFactorID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFactorNo", "Mã yếu tố"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFactorName", "Tên yếu tố")});
            this.fld_lkeFK_MMProductionCostFactorID.Properties.DisplayMember = "MMProductionCostFactorName";
            this.fld_lkeFK_MMProductionCostFactorID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_MMProductionCostFactorID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionCostFactorID.Properties.ValueMember = "MMProductionCostFactorID";
            this.fld_lkeFK_MMProductionCostFactorID.Screen = null;
            this.fld_lkeFK_MMProductionCostFactorID.Size = new System.Drawing.Size(419, 20);
            this.fld_lkeFK_MMProductionCostFactorID.TabIndex = 6;
            this.fld_lkeFK_MMProductionCostFactorID.Tag = "DC";
            this.fld_lkeFK_MMProductionCostFactorID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMProductionCostFactorID_CloseUp);
            // 
            // bosLabel8
            // 
            this.bosLabel8.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel8.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel8.Appearance.Options.UseBackColor = true;
            this.bosLabel8.Appearance.Options.UseForeColor = true;
            this.bosLabel8.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.Location = new System.Drawing.Point(17, 93);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(31, 13);
            this.bosLabel8.TabIndex = 338;
            this.bosLabel8.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel8.Text = "Yếu tố";
            // 
            // fld_lkeFK_ACCreditAccountID
            // 
            this.fld_lkeFK_ACCreditAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACCreditAccountID.BOSAllowDummy = true;
            this.fld_lkeFK_ACCreditAccountID.BOSComment = null;
            this.fld_lkeFK_ACCreditAccountID.BOSDataMember = "FK_ACCreditAccountID";
            this.fld_lkeFK_ACCreditAccountID.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_lkeFK_ACCreditAccountID.BOSDescription = null;
            this.fld_lkeFK_ACCreditAccountID.BOSError = null;
            this.fld_lkeFK_ACCreditAccountID.BOSFieldGroup = null;
            this.fld_lkeFK_ACCreditAccountID.BOSFieldParent = null;
            this.fld_lkeFK_ACCreditAccountID.BOSFieldRelation = null;
            this.fld_lkeFK_ACCreditAccountID.BOSPrivilege = null;
            this.fld_lkeFK_ACCreditAccountID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ACCreditAccountID.BOSSelectType = null;
            this.fld_lkeFK_ACCreditAccountID.BOSSelectTypeValue = null;
            this.fld_lkeFK_ACCreditAccountID.CurrentDisplayText = null;
            this.fld_lkeFK_ACCreditAccountID.Location = new System.Drawing.Point(370, 64);
            this.fld_lkeFK_ACCreditAccountID.Name = "fld_lkeFK_ACCreditAccountID";
            this.fld_lkeFK_ACCreditAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACCreditAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACCreditAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACCreditAccountID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ACCreditAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACCreditAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACCreditAccountID.Screen = null;
            this.fld_lkeFK_ACCreditAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACCreditAccountID.TabIndex = 5;
            this.fld_lkeFK_ACCreditAccountID.Tag = "DC";
            this.fld_lkeFK_ACCreditAccountID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACCreditAccountID_CloseUp);
            // 
            // bosLabel7
            // 
            this.bosLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel7.Appearance.Options.UseBackColor = true;
            this.bosLabel7.Appearance.Options.UseForeColor = true;
            this.bosLabel7.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.Location = new System.Drawing.Point(281, 67);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(60, 13);
            this.bosLabel7.TabIndex = 336;
            this.bosLabel7.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel7.Text = "Tài khoản có";
            // 
            // fld_lkeFK_ACDebitAccountID
            // 
            this.fld_lkeFK_ACDebitAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACDebitAccountID.BOSAllowDummy = true;
            this.fld_lkeFK_ACDebitAccountID.BOSComment = null;
            this.fld_lkeFK_ACDebitAccountID.BOSDataMember = "FK_ACDebitAccountID";
            this.fld_lkeFK_ACDebitAccountID.BOSDataSource = "MMProductionCostGeneralCostAllocations";
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
            this.fld_lkeFK_ACDebitAccountID.Location = new System.Drawing.Point(101, 64);
            this.fld_lkeFK_ACDebitAccountID.Name = "fld_lkeFK_ACDebitAccountID";
            this.fld_lkeFK_ACDebitAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACDebitAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_lkeFK_ACDebitAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACDebitAccountID.Properties.NullText =global::Localization.MESLocalizedResources.String1;
            this.fld_lkeFK_ACDebitAccountID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ACDebitAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACDebitAccountID.Screen = null;
            this.fld_lkeFK_ACDebitAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACDebitAccountID.TabIndex = 4;
            this.fld_lkeFK_ACDebitAccountID.Tag = "DC";
            this.fld_lkeFK_ACDebitAccountID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_ACDebitAccountID_CloseUp);
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataMember =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDataSource =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSFieldRelation =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPrivilege =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.BOSPropertyName =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Location = new System.Drawing.Point(17, 67);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(61, 13);
            this.bosLabel4.TabIndex = 334;
            this.bosLabel4.Tag =global::Localization.MESLocalizedResources.String1;
            this.bosLabel4.Text = "Tài khoản nợ";
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
            this.bosLabel6.Location = new System.Drawing.Point(281, 41);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(47, 13);
            this.bosLabel6.TabIndex = 86;
            this.bosLabel6.Text = "Đến ngày";
            // 
            // fld_dteMMProductionCostGeneralCostAllocationToDate
            // 
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSComment = null;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSDataMember = "MMProductionCostGeneralCostAllocationToDate";
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSDescription = null;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSError = null;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSFieldGroup = null;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSFieldRelation = null;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSPrivilege = null;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.EditValue = null;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Location = new System.Drawing.Point(370, 38);
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Name = "fld_dteMMProductionCostGeneralCostAllocationToDate";
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Screen = null;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.TabIndex = 3;
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.Tag = "DC";
            this.fld_dteMMProductionCostGeneralCostAllocationToDate.TextChanged += new System.EventHandler(this.fld_dteMMProductionCostGeneralCostAllocationToDate_TextChanged);
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 190);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(856, 242);
            this.bosTabControl1.TabIndex = 9;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcDetails);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(849, 213);
            this.xtraTabPage1.Text = "Chi tiết";
            // 
            // fld_dgcDetails
            // 
            this.fld_dgcDetails.AllowDrop = true;
            this.fld_dgcDetails.BOSComment = null;
            this.fld_dgcDetails.BOSDataMember = null;
            this.fld_dgcDetails.BOSDataSource = "MMProductionCostGeneralCostAllocationDetails";
            this.fld_dgcDetails.BOSDescription = null;
            this.fld_dgcDetails.BOSError = null;
            this.fld_dgcDetails.BOSFieldGroup = null;
            this.fld_dgcDetails.BOSFieldRelation = null;
            this.fld_dgcDetails.BOSGridType = null;
            this.fld_dgcDetails.BOSPrivilege = null;
            this.fld_dgcDetails.BOSPropertyName = null;
            this.fld_dgcDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcDetails.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcDetails.MainView = this.gridView2;
            this.fld_dgcDetails.Name = "fld_dgcDetails";
            this.fld_dgcDetails.PrintReport = false;
            this.fld_dgcDetails.Screen = null;
            this.fld_dgcDetails.Size = new System.Drawing.Size(849, 213);
            this.fld_dgcDetails.TabIndex = 0;
            this.fld_dgcDetails.Tag = "DC";
            this.fld_dgcDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcDetails;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
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
            this.bosLabel5.Location = new System.Drawing.Point(17, 41);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 84;
            this.bosLabel5.Text = "Từ ngày";
            // 
            // fld_dteMMProductionCostGeneralCostAllocationFromDate
            // 
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSComment = null;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSDataMember = "MMProductionCostGeneralCostAllocationFromDate";
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSDescription = null;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSError = null;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSFieldGroup = null;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSFieldRelation = null;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSPrivilege = null;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.EditValue = null;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Location = new System.Drawing.Point(101, 38);
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Name = "fld_dteMMProductionCostGeneralCostAllocationFromDate";
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Screen = null;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.TabIndex = 2;
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Tag = "DC";
            this.fld_dteMMProductionCostGeneralCostAllocationFromDate.TextChanged += new System.EventHandler(this.fld_dteMMProductionCostGeneralCostAllocationFromDate_TextChanged);
            // 
            // fld_dteMMProductionCostGeneralCostAllocationDate
            // 
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSComment = null;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSDataMember = "MMProductionCostGeneralCostAllocationDate";
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSDescription = null;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSError = null;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSFieldGroup = null;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSFieldRelation = null;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSPrivilege = null;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.BOSPropertyName = "EditValue";
            this.fld_dteMMProductionCostGeneralCostAllocationDate.EditValue = null;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Location = new System.Drawing.Point(370, 12);
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Name = "fld_dteMMProductionCostGeneralCostAllocationDate";
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Screen = null;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteMMProductionCostGeneralCostAllocationDate.TabIndex = 1;
            this.fld_dteMMProductionCostGeneralCostAllocationDate.Tag = "DC";
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
            // fld_medMMProductionCostGeneralCostAllocationDesc
            // 
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSComment = string.Empty;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSDataMember = "MMProductionCostGeneralCostAllocationDesc";
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSDescription = null;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSError = null;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSFieldGroup = string.Empty;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSFieldRelation = string.Empty;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSPrivilege = string.Empty;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.BOSPropertyName = "EditValue";
            this.fld_medMMProductionCostGeneralCostAllocationDesc.EditValue = string.Empty;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Location = new System.Drawing.Point(101, 142);
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Name = "fld_medMMProductionCostGeneralCostAllocationDesc";
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMProductionCostGeneralCostAllocationDesc, true);
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Size = new System.Drawing.Size(419, 42);
            this.fld_medMMProductionCostGeneralCostAllocationDesc.TabIndex = 9;
            this.fld_medMMProductionCostGeneralCostAllocationDesc.Tag = "DC";
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
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 13;
            this.bosLabel2.Text = "Ngày chứng từ";
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
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 11;
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtMMProductionCostGeneralCostAllocationNo
            // 
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSComment = string.Empty;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSDataMember = "MMProductionCostGeneralCostAllocationNo";
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSDataSource = "MMProductionCostGeneralCostAllocations";
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSDescription = null;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSError = null;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSFieldGroup = string.Empty;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSFieldRelation = string.Empty;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSPrivilege = string.Empty;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostGeneralCostAllocationNo.EditValue = string.Empty;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Location = new System.Drawing.Point(101, 12);
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Name = "fld_txtMMProductionCostGeneralCostAllocationNo";
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Screen = null;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionCostGeneralCostAllocationNo.TabIndex = 0;
            this.fld_txtMMProductionCostGeneralCostAllocationNo.Tag = "DC";
            // 
            // DMGCA100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 435);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMGCA100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostGeneralCostAllocationTotalCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFactorID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCreditAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACDebitAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMProductionCostGeneralCostAllocationDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMProductionCostGeneralCostAllocationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostGeneralCostAllocationNo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostGeneralCostAllocationNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medMMProductionCostGeneralCostAllocationDesc;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostGeneralCostAllocationDate;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostGeneralCostAllocationFromDate;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteMMProductionCostGeneralCostAllocationToDate;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private MMProductionCostGeneralCostAllocationDetailsGridControl fld_dgcDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACCreditAccountID;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACDebitAccountID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionCostFactorID;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostGeneralCostAllocationTotalCost;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
     
	}
}
