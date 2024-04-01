using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.FalseConditional.UI
{
	/// <summary>
	/// Summary description for DMLM100
	/// </summary>
	partial class DMFC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMFC100));
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.bosTextBox4 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtMMFalseConditionalSoftFault = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMFalseConditionalHardFault = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMFalseConditionalAveragePercent = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMFalseConditionalHyperLink = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosMemoEdit1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACObjectAccessKey = new BOSERP.AccObjectLookupEdit(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRCheckerEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosTextBox3 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HRReceiverEmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductAttributeWoodTypeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMFalseConditionalItems = new BOSERP.Modules.FalseConditional.FalseConditionalItemsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMFalseConditionalStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMFalseConditionalDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMFalseConditionalNo = new BOSComponent.BOSTextBox(this.components);
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).BeginInit();
            this.bosLine5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMFalseConditionalHyperLink.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRCheckerEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRReceiverEmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeWoodTypeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMFalseConditionalItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMFalseConditionalStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMFalseConditionalDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMFalseConditionalDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMFalseConditionalNo.Properties)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_grcGroupControl);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1282, 699);
            this.bosPanel1.TabIndex = 0;
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = null;
            this.fld_grcGroupControl.BOSDataSource = null;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = null;
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = null;
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox4);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel18);
            this.fld_grcGroupControl.Controls.Add(this.bosLine5);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeACObjectAccessKey);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel8);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRCheckerEmployeeID);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox3);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox2);
            this.fld_grcGroupControl.Controls.Add(this.bosTextBox1);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel4);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel6);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel7);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel3);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeFK_HRReceiverEmployeeID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeICProductAttributeWoodTypeID);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel1);
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMFalseConditionalItems);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel9);
            this.fld_grcGroupControl.Controls.Add(this.fld_lkeMMFalseConditionalStatus);
            this.fld_grcGroupControl.Controls.Add(this.bosLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_dteMMFalseConditionalDate);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel4);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtMMFalseConditionalNo);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(3, 3);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(1279, 696);
            this.fld_grcGroupControl.TabIndex = 0;
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // bosTextBox4
            // 
            this.bosTextBox4.BOSComment = "";
            this.bosTextBox4.BOSDataMember = "MMFalseConditionalCheckQty";
            this.bosTextBox4.BOSDataSource = "MMFalseConditionals";
            this.bosTextBox4.BOSDescription = null;
            this.bosTextBox4.BOSError = "";
            this.bosTextBox4.BOSFieldGroup = "";
            this.bosTextBox4.BOSFieldRelation = "";
            this.bosTextBox4.BOSPrivilege = "";
            this.bosTextBox4.BOSPropertyName = "Text";
            this.bosTextBox4.Location = new System.Drawing.Point(916, 71);
            this.bosTextBox4.Name = "bosTextBox4";
            this.bosTextBox4.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox4.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox4.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox4.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox4.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox4.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox4.Properties.MaskSettings.Set("mask", "n");
            this.bosTextBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox4, true);
            this.bosTextBox4.Size = new System.Drawing.Size(129, 20);
            this.bosTextBox4.TabIndex = 27;
            this.bosTextBox4.Tag = "DC";
            this.bosTextBox4.Validated += new System.EventHandler(this.bosTextBox4_Validated);
            // 
            // bosLabel18
            // 
            this.bosLabel18.BOSComment = null;
            this.bosLabel18.BOSDataMember = null;
            this.bosLabel18.BOSDataSource = null;
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = null;
            this.bosLabel18.BOSFieldRelation = null;
            this.bosLabel18.BOSPrivilege = null;
            this.bosLabel18.BOSPropertyName = null;
            this.bosLabel18.Location = new System.Drawing.Point(826, 74);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(75, 13);
            this.bosLabel18.TabIndex = 26;
            this.bosLabel18.Text = "Số kiện kiểm tra";
            // 
            // bosLine5
            // 
            this.bosLine5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.bosLookupEdit2);
            this.bosLine5.Controls.Add(this.bosLookupEdit1);
            this.bosLine5.Controls.Add(this.fld_txtMMFalseConditionalSoftFault);
            this.bosLine5.Controls.Add(this.fld_txtMMFalseConditionalHardFault);
            this.bosLine5.Controls.Add(this.fld_txtMMFalseConditionalAveragePercent);
            this.bosLine5.Controls.Add(this.fld_txtMMFalseConditionalHyperLink);
            this.bosLine5.Controls.Add(this.bosLabel17);
            this.bosLine5.Controls.Add(this.bosMemoEdit1);
            this.bosLine5.Controls.Add(this.bosLabel16);
            this.bosLine5.Controls.Add(this.bosLabel15);
            this.bosLine5.Controls.Add(this.bosLabel14);
            this.bosLine5.Controls.Add(this.bosLabel13);
            this.bosLine5.Controls.Add(this.bosLabel12);
            this.bosLine5.Controls.Add(this.bosLabel11);
            this.bosLine5.Controls.Add(this.bosLabel10);
            this.bosLine5.Location = new System.Drawing.Point(5, 575);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(1157, 109);
            this.bosLine5.TabIndex = 25;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Mô tả và kết luận";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = false;
            this.bosLookupEdit2.BOSComment = null;
            this.bosLookupEdit2.BOSDataMember = "MMFalseConditionalCondition";
            this.bosLookupEdit2.BOSDataSource = "MMFalseConditionals";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = null;
            this.bosLookupEdit2.BOSFieldParent = null;
            this.bosLookupEdit2.BOSFieldRelation = null;
            this.bosLookupEdit2.BOSPrivilege = null;
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = null;
            this.bosLookupEdit2.BOSSelectTypeValue = null;
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(151, 80);
            this.bosLookupEdit2.MenuManager = this.screenToolbar;
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(106, 20);
            this.bosLookupEdit2.TabIndex = 75;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = false;
            this.bosLookupEdit1.BOSComment = null;
            this.bosLookupEdit1.BOSDataMember = "MMFalseConditionalResult";
            this.bosLookupEdit1.BOSDataSource = "MMFalseConditionals";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = null;
            this.bosLookupEdit1.BOSFieldParent = null;
            this.bosLookupEdit1.BOSFieldRelation = null;
            this.bosLookupEdit1.BOSPrivilege = null;
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = null;
            this.bosLookupEdit1.BOSSelectTypeValue = null;
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(151, 52);
            this.bosLookupEdit1.MenuManager = this.screenToolbar;
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(106, 20);
            this.bosLookupEdit1.TabIndex = 74;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // fld_txtMMFalseConditionalSoftFault
            // 
            this.fld_txtMMFalseConditionalSoftFault.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMFalseConditionalSoftFault.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMFalseConditionalSoftFault.Appearance.Options.UseBackColor = true;
            this.fld_txtMMFalseConditionalSoftFault.Appearance.Options.UseForeColor = true;
            this.fld_txtMMFalseConditionalSoftFault.BOSComment = null;
            this.fld_txtMMFalseConditionalSoftFault.BOSDataMember = "MMFalseConditionalSoftFault";
            this.fld_txtMMFalseConditionalSoftFault.BOSDataSource = "MMFalseConditionals";
            this.fld_txtMMFalseConditionalSoftFault.BOSDescription = null;
            this.fld_txtMMFalseConditionalSoftFault.BOSError = null;
            this.fld_txtMMFalseConditionalSoftFault.BOSFieldGroup = null;
            this.fld_txtMMFalseConditionalSoftFault.BOSFieldRelation = null;
            this.fld_txtMMFalseConditionalSoftFault.BOSPrivilege = null;
            this.fld_txtMMFalseConditionalSoftFault.BOSPropertyName = null;
            this.fld_txtMMFalseConditionalSoftFault.Location = new System.Drawing.Point(393, 83);
            this.fld_txtMMFalseConditionalSoftFault.Name = "fld_txtMMFalseConditionalSoftFault";
            this.fld_txtMMFalseConditionalSoftFault.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMFalseConditionalSoftFault, true);
            this.fld_txtMMFalseConditionalSoftFault.Size = new System.Drawing.Size(12, 13);
            this.fld_txtMMFalseConditionalSoftFault.TabIndex = 73;
            this.fld_txtMMFalseConditionalSoftFault.Text = "08";
            // 
            // fld_txtMMFalseConditionalHardFault
            // 
            this.fld_txtMMFalseConditionalHardFault.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMFalseConditionalHardFault.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMFalseConditionalHardFault.Appearance.Options.UseBackColor = true;
            this.fld_txtMMFalseConditionalHardFault.Appearance.Options.UseForeColor = true;
            this.fld_txtMMFalseConditionalHardFault.BOSComment = null;
            this.fld_txtMMFalseConditionalHardFault.BOSDataMember = "MMFalseConditionalHardFault";
            this.fld_txtMMFalseConditionalHardFault.BOSDataSource = "MMFalseConditionals";
            this.fld_txtMMFalseConditionalHardFault.BOSDescription = null;
            this.fld_txtMMFalseConditionalHardFault.BOSError = null;
            this.fld_txtMMFalseConditionalHardFault.BOSFieldGroup = null;
            this.fld_txtMMFalseConditionalHardFault.BOSFieldRelation = null;
            this.fld_txtMMFalseConditionalHardFault.BOSPrivilege = null;
            this.fld_txtMMFalseConditionalHardFault.BOSPropertyName = null;
            this.fld_txtMMFalseConditionalHardFault.Location = new System.Drawing.Point(393, 55);
            this.fld_txtMMFalseConditionalHardFault.Name = "fld_txtMMFalseConditionalHardFault";
            this.fld_txtMMFalseConditionalHardFault.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMFalseConditionalHardFault, true);
            this.fld_txtMMFalseConditionalHardFault.Size = new System.Drawing.Size(12, 13);
            this.fld_txtMMFalseConditionalHardFault.TabIndex = 72;
            this.fld_txtMMFalseConditionalHardFault.Text = "08";
            // 
            // fld_txtMMFalseConditionalAveragePercent
            // 
            this.fld_txtMMFalseConditionalAveragePercent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMFalseConditionalAveragePercent.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMFalseConditionalAveragePercent.Appearance.Options.UseBackColor = true;
            this.fld_txtMMFalseConditionalAveragePercent.Appearance.Options.UseForeColor = true;
            this.fld_txtMMFalseConditionalAveragePercent.BOSComment = null;
            this.fld_txtMMFalseConditionalAveragePercent.BOSDataMember = "MMFalseConditionalAveragePercent";
            this.fld_txtMMFalseConditionalAveragePercent.BOSDataSource = "MMFalseConditionals";
            this.fld_txtMMFalseConditionalAveragePercent.BOSDescription = null;
            this.fld_txtMMFalseConditionalAveragePercent.BOSError = null;
            this.fld_txtMMFalseConditionalAveragePercent.BOSFieldGroup = null;
            this.fld_txtMMFalseConditionalAveragePercent.BOSFieldRelation = null;
            this.fld_txtMMFalseConditionalAveragePercent.BOSPrivilege = null;
            this.fld_txtMMFalseConditionalAveragePercent.BOSPropertyName = null;
            this.fld_txtMMFalseConditionalAveragePercent.Location = new System.Drawing.Point(151, 25);
            this.fld_txtMMFalseConditionalAveragePercent.Name = "fld_txtMMFalseConditionalAveragePercent";
            this.fld_txtMMFalseConditionalAveragePercent.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMFalseConditionalAveragePercent, true);
            this.fld_txtMMFalseConditionalAveragePercent.Size = new System.Drawing.Size(12, 13);
            this.fld_txtMMFalseConditionalAveragePercent.TabIndex = 69;
            this.fld_txtMMFalseConditionalAveragePercent.Text = "08";
            // 
            // fld_txtMMFalseConditionalHyperLink
            // 
            this.fld_txtMMFalseConditionalHyperLink.BOSComment = "";
            this.fld_txtMMFalseConditionalHyperLink.BOSDataMember = "MMFalseConditionalHyperLink";
            this.fld_txtMMFalseConditionalHyperLink.BOSDataSource = "MMFalseConditionals";
            this.fld_txtMMFalseConditionalHyperLink.BOSDescription = null;
            this.fld_txtMMFalseConditionalHyperLink.BOSError = "";
            this.fld_txtMMFalseConditionalHyperLink.BOSFieldGroup = "";
            this.fld_txtMMFalseConditionalHyperLink.BOSFieldRelation = "";
            this.fld_txtMMFalseConditionalHyperLink.BOSPrivilege = "";
            this.fld_txtMMFalseConditionalHyperLink.BOSPropertyName = "Text";
            this.fld_txtMMFalseConditionalHyperLink.Location = new System.Drawing.Point(815, 43);
            this.fld_txtMMFalseConditionalHyperLink.Name = "fld_txtMMFalseConditionalHyperLink";
            this.fld_txtMMFalseConditionalHyperLink.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMFalseConditionalHyperLink.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMFalseConditionalHyperLink.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMFalseConditionalHyperLink.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMFalseConditionalHyperLink.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMFalseConditionalHyperLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMFalseConditionalHyperLink.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMFalseConditionalHyperLink, true);
            this.fld_txtMMFalseConditionalHyperLink.Size = new System.Drawing.Size(290, 20);
            this.fld_txtMMFalseConditionalHyperLink.TabIndex = 68;
            this.fld_txtMMFalseConditionalHyperLink.Tag = "DC";
            this.fld_txtMMFalseConditionalHyperLink.Click += new System.EventHandler(this.fld_txtMMFalseConditionalHyperLink_Click);
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel17.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseFont = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = "";
            this.bosLabel17.BOSDataMember = "";
            this.bosLabel17.BOSDataSource = "";
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = "";
            this.bosLabel17.BOSFieldRelation = "";
            this.bosLabel17.BOSPrivilege = "";
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(815, 25);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(171, 13);
            this.bosLabel17.TabIndex = 67;
            this.bosLabel17.Tag = "";
            this.bosLabel17.Text = "Hình ảnh chi tiết lỗi (link tới folder lỗi)";
            // 
            // bosMemoEdit1
            // 
            this.bosMemoEdit1.BOSComment = "";
            this.bosMemoEdit1.BOSDataMember = "MMFalseConditionalDesc";
            this.bosMemoEdit1.BOSDataSource = "MMFalseConditionals";
            this.bosMemoEdit1.BOSDescription = null;
            this.bosMemoEdit1.BOSError = null;
            this.bosMemoEdit1.BOSFieldGroup = "";
            this.bosMemoEdit1.BOSFieldRelation = "";
            this.bosMemoEdit1.BOSPrivilege = "";
            this.bosMemoEdit1.BOSPropertyName = "EditValue";
            this.bosMemoEdit1.EditValue = "";
            this.bosMemoEdit1.Location = new System.Drawing.Point(479, 44);
            this.bosMemoEdit1.Name = "bosMemoEdit1";
            this.bosMemoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosMemoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosMemoEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosMemoEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosMemoEdit1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosMemoEdit1, true);
            this.bosMemoEdit1.Size = new System.Drawing.Size(269, 56);
            this.bosMemoEdit1.TabIndex = 66;
            this.bosMemoEdit1.Tag = "DC";
            // 
            // bosLabel16
            // 
            this.bosLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel16.Appearance.Options.UseBackColor = true;
            this.bosLabel16.Appearance.Options.UseFont = true;
            this.bosLabel16.Appearance.Options.UseForeColor = true;
            this.bosLabel16.BOSComment = "";
            this.bosLabel16.BOSDataMember = "";
            this.bosLabel16.BOSDataSource = "";
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = "";
            this.bosLabel16.BOSFieldRelation = "";
            this.bosLabel16.BOSPrivilege = "";
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(479, 25);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel16, true);
            this.bosLabel16.Size = new System.Drawing.Size(99, 13);
            this.bosLabel16.TabIndex = 7;
            this.bosLabel16.Tag = "";
            this.bosLabel16.Text = "Ghi chú và xin ý kiến";
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel15.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel15.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel15.Appearance.Options.UseBackColor = true;
            this.bosLabel15.Appearance.Options.UseFont = true;
            this.bosLabel15.Appearance.Options.UseForeColor = true;
            this.bosLabel15.BOSComment = "";
            this.bosLabel15.BOSDataMember = "";
            this.bosLabel15.BOSDataSource = "";
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = "";
            this.bosLabel15.BOSFieldRelation = "";
            this.bosLabel15.BOSPrivilege = "";
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(295, 83);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel15, true);
            this.bosLabel15.Size = new System.Drawing.Size(55, 13);
            this.bosLabel15.TabIndex = 6;
            this.bosLabel15.Tag = "";
            this.bosLabel15.Text = "% lỗi nhẹ:";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseFont = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(295, 55);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel14, true);
            this.bosLabel14.Size = new System.Drawing.Size(62, 13);
            this.bosLabel14.TabIndex = 5;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "% lỗi nặng:";
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
            this.bosLabel13.Location = new System.Drawing.Point(295, 25);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel13, true);
            this.bosLabel13.Size = new System.Drawing.Size(81, 13);
            this.bosLabel13.TabIndex = 4;
            this.bosLabel13.Tag = "";
            this.bosLabel13.Text = "Chi tiết % theo lô:";
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
            this.bosLabel12.Location = new System.Drawing.Point(13, 83);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel12, true);
            this.bosLabel12.Size = new System.Drawing.Size(48, 13);
            this.bosLabel12.TabIndex = 3;
            this.bosLabel12.Tag = "";
            this.bosLabel12.Text = "Điều kiện:";
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel11.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel11.Appearance.Options.UseBackColor = true;
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.Appearance.Options.UseForeColor = true;
            this.bosLabel11.BOSComment = "";
            this.bosLabel11.BOSDataMember = "";
            this.bosLabel11.BOSDataSource = "";
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = "";
            this.bosLabel11.BOSFieldRelation = "";
            this.bosLabel11.BOSPrivilege = "";
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(13, 55);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel11, true);
            this.bosLabel11.Size = new System.Drawing.Size(40, 13);
            this.bosLabel11.TabIndex = 2;
            this.bosLabel11.Tag = "";
            this.bosLabel11.Text = "Kết quả:";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel10.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel10.Appearance.Options.UseBackColor = true;
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.Appearance.Options.UseForeColor = true;
            this.bosLabel10.BOSComment = "";
            this.bosLabel10.BOSDataMember = "";
            this.bosLabel10.BOSDataSource = "";
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = "";
            this.bosLabel10.BOSFieldRelation = "";
            this.bosLabel10.BOSPrivilege = "";
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(13, 25);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(117, 13);
            this.bosLabel10.TabIndex = 1;
            this.bosLabel10.Tag = "";
            this.bosLabel10.Text = "Phần trăm trung bình/ lô:";
            // 
            // fld_lkeACObjectAccessKey
            // 
            this.fld_lkeACObjectAccessKey.BOSAllowAddNew = false;
            this.fld_lkeACObjectAccessKey.BOSAllowDummy = true;
            this.fld_lkeACObjectAccessKey.BOSComment = "";
            this.fld_lkeACObjectAccessKey.BOSDataMember = "ACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.BOSDataSource = "MMFalseConditionals";
            this.fld_lkeACObjectAccessKey.BOSDescription = null;
            this.fld_lkeACObjectAccessKey.BOSError = null;
            this.fld_lkeACObjectAccessKey.BOSFieldGroup = "";
            this.fld_lkeACObjectAccessKey.BOSFieldParent = "";
            this.fld_lkeACObjectAccessKey.BOSFieldRelation = "";
            this.fld_lkeACObjectAccessKey.BOSModuleType = null;
            this.fld_lkeACObjectAccessKey.BOSPrivilege = "";
            this.fld_lkeACObjectAccessKey.BOSPropertyName = "EditValue";
            this.fld_lkeACObjectAccessKey.BOSSelectType = "";
            this.fld_lkeACObjectAccessKey.BOSSelectTypeValue = "";
            this.fld_lkeACObjectAccessKey.CurrentDisplayText = null;
            this.fld_lkeACObjectAccessKey.LastedUpdate = new System.DateTime(((long)(0)));
            this.fld_lkeACObjectAccessKey.Location = new System.Drawing.Point(370, 45);
            this.fld_lkeACObjectAccessKey.Name = "fld_lkeACObjectAccessKey";
            this.fld_lkeACObjectAccessKey.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACObjectAccessKey.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACObjectAccessKey.Properties.ColumnName = null;
            this.fld_lkeACObjectAccessKey.Properties.DisplayMember = "ACObjectName";
            this.fld_lkeACObjectAccessKey.Properties.NullText = "";
            this.fld_lkeACObjectAccessKey.Properties.PopupWidth = 40;
            this.fld_lkeACObjectAccessKey.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACObjectAccessKey.Properties.ValueMember = "ACObjectID";
            this.fld_lkeACObjectAccessKey.Screen = null;
            this.fld_lkeACObjectAccessKey.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeACObjectAccessKey.TabIndex = 24;
            this.fld_lkeACObjectAccessKey.Tag = "DC";
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
            this.bosLabel8.Location = new System.Drawing.Point(560, 100);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(69, 13);
            this.bosLabel8.TabIndex = 22;
            this.bosLabel8.Text = "Người kiểm tra";
            // 
            // fld_lkeFK_HRCheckerEmployeeID
            // 
            this.fld_lkeFK_HRCheckerEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSComment = null;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSDataMember = "FK_HRCheckerEmployeeID";
            this.fld_lkeFK_HRCheckerEmployeeID.BOSDataSource = "MMFalseConditionals";
            this.fld_lkeFK_HRCheckerEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSError = null;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRCheckerEmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HRCheckerEmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRCheckerEmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HRCheckerEmployeeID.Location = new System.Drawing.Point(648, 97);
            this.fld_lkeFK_HRCheckerEmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HRCheckerEmployeeID.Name = "fld_lkeFK_HRCheckerEmployeeID";
            this.fld_lkeFK_HRCheckerEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRCheckerEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRCheckerEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên")});
            this.fld_lkeFK_HRCheckerEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRCheckerEmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HRCheckerEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRCheckerEmployeeID.Screen = null;
            this.fld_lkeFK_HRCheckerEmployeeID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_HRCheckerEmployeeID.TabIndex = 23;
            this.fld_lkeFK_HRCheckerEmployeeID.Tag = "DC";
            // 
            // bosTextBox3
            // 
            this.bosTextBox3.BOSComment = "";
            this.bosTextBox3.BOSDataMember = "MMFalseConditionalPercentNorm";
            this.bosTextBox3.BOSDataSource = "MMFalseConditionals";
            this.bosTextBox3.BOSDescription = null;
            this.bosTextBox3.BOSError = "";
            this.bosTextBox3.BOSFieldGroup = "";
            this.bosTextBox3.BOSFieldRelation = "";
            this.bosTextBox3.BOSPrivilege = "";
            this.bosTextBox3.BOSPropertyName = "Text";
            this.bosTextBox3.Location = new System.Drawing.Point(916, 45);
            this.bosTextBox3.Name = "bosTextBox3";
            this.bosTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox3.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox3, true);
            this.bosTextBox3.Size = new System.Drawing.Size(129, 20);
            this.bosTextBox3.TabIndex = 21;
            this.bosTextBox3.Tag = "DC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "MMFalseConditionalSerialNo";
            this.bosTextBox2.BOSDataSource = "MMFalseConditionals";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = "";
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(650, 71);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox2, true);
            this.bosTextBox2.Size = new System.Drawing.Size(129, 20);
            this.bosTextBox2.TabIndex = 20;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "MMFalseConditionalPONo";
            this.bosTextBox1.BOSDataSource = "MMFalseConditionals";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(650, 45);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, true);
            this.bosTextBox1.Size = new System.Drawing.Size(129, 20);
            this.bosTextBox1.TabIndex = 19;
            this.bosTextBox1.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(824, 48);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(72, 13);
            this.bosLabel4.TabIndex = 18;
            this.bosLabel4.Text = "Định mức % lỗi";
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
            this.bosLabel6.Location = new System.Drawing.Point(560, 74);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(57, 13);
            this.bosLabel6.TabIndex = 16;
            this.bosLabel6.Text = "Số kiện giao";
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
            this.bosLabel7.Location = new System.Drawing.Point(560, 48);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(38, 13);
            this.bosLabel7.TabIndex = 14;
            this.bosLabel7.Text = "Số ĐMH";
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
            this.bosLabel3.Location = new System.Drawing.Point(288, 100);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(55, 13);
            this.bosLabel3.TabIndex = 12;
            this.bosLabel3.Text = "Người nhận";
            // 
            // fld_lkeFK_HRReceiverEmployeeID
            // 
            this.fld_lkeFK_HRReceiverEmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSComment = null;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSDataMember = "FK_HRReceiverEmployeeID";
            this.fld_lkeFK_HRReceiverEmployeeID.BOSDataSource = "MMFalseConditionals";
            this.fld_lkeFK_HRReceiverEmployeeID.BOSDescription = null;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSError = null;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSFieldGroup = null;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSFieldParent = null;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSFieldRelation = null;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSPrivilege = null;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HRReceiverEmployeeID.BOSSelectType = null;
            this.fld_lkeFK_HRReceiverEmployeeID.BOSSelectTypeValue = null;
            this.fld_lkeFK_HRReceiverEmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HRReceiverEmployeeID.Location = new System.Drawing.Point(370, 97);
            this.fld_lkeFK_HRReceiverEmployeeID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_HRReceiverEmployeeID.Name = "fld_lkeFK_HRReceiverEmployeeID";
            this.fld_lkeFK_HRReceiverEmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HRReceiverEmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HRReceiverEmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Nhân viên")});
            this.fld_lkeFK_HRReceiverEmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HRReceiverEmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HRReceiverEmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HRReceiverEmployeeID.Screen = null;
            this.fld_lkeFK_HRReceiverEmployeeID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeFK_HRReceiverEmployeeID.TabIndex = 13;
            this.fld_lkeFK_HRReceiverEmployeeID.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(288, 74);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(34, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Text = "Loại gỗ";
            // 
            // fld_lkeICProductAttributeWoodTypeID
            // 
            this.fld_lkeICProductAttributeWoodTypeID.BOSAllowAddNew = false;
            this.fld_lkeICProductAttributeWoodTypeID.BOSAllowDummy = false;
            this.fld_lkeICProductAttributeWoodTypeID.BOSComment = null;
            this.fld_lkeICProductAttributeWoodTypeID.BOSDataMember = "FK_ICProductAttributeWoodTypeID";
            this.fld_lkeICProductAttributeWoodTypeID.BOSDataSource = "MMFalseConditionals";
            this.fld_lkeICProductAttributeWoodTypeID.BOSDescription = null;
            this.fld_lkeICProductAttributeWoodTypeID.BOSError = null;
            this.fld_lkeICProductAttributeWoodTypeID.BOSFieldGroup = null;
            this.fld_lkeICProductAttributeWoodTypeID.BOSFieldParent = null;
            this.fld_lkeICProductAttributeWoodTypeID.BOSFieldRelation = null;
            this.fld_lkeICProductAttributeWoodTypeID.BOSPrivilege = null;
            this.fld_lkeICProductAttributeWoodTypeID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductAttributeWoodTypeID.BOSSelectType = null;
            this.fld_lkeICProductAttributeWoodTypeID.BOSSelectTypeValue = null;
            this.fld_lkeICProductAttributeWoodTypeID.CurrentDisplayText = null;
            this.fld_lkeICProductAttributeWoodTypeID.Location = new System.Drawing.Point(370, 71);
            this.fld_lkeICProductAttributeWoodTypeID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductAttributeWoodTypeID.Name = "fld_lkeICProductAttributeWoodTypeID";
            this.fld_lkeICProductAttributeWoodTypeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductAttributeWoodTypeID.Properties.ColumnName = null;
            this.fld_lkeICProductAttributeWoodTypeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductAttributeValue", "Chất lượng")});
            this.fld_lkeICProductAttributeWoodTypeID.Properties.DisplayMember = "ICProductAttributeValue";
            this.fld_lkeICProductAttributeWoodTypeID.Properties.NullText = "";
            this.fld_lkeICProductAttributeWoodTypeID.Properties.ValueMember = "ICProductAttributeID";
            this.fld_lkeICProductAttributeWoodTypeID.Screen = null;
            this.fld_lkeICProductAttributeWoodTypeID.Size = new System.Drawing.Size(131, 20);
            this.fld_lkeICProductAttributeWoodTypeID.TabIndex = 11;
            this.fld_lkeICProductAttributeWoodTypeID.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(288, 48);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 8;
            this.bosLabel1.Text = "Nhà cung cấp";
            // 
            // fld_dgcMMFalseConditionalItems
            // 
            this.fld_dgcMMFalseConditionalItems.AllowDrop = true;
            this.fld_dgcMMFalseConditionalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMFalseConditionalItems.BOSComment = null;
            this.fld_dgcMMFalseConditionalItems.BOSDataMember = null;
            this.fld_dgcMMFalseConditionalItems.BOSDataSource = "MMFalseConditionalItems";
            this.fld_dgcMMFalseConditionalItems.BOSDescription = null;
            this.fld_dgcMMFalseConditionalItems.BOSError = null;
            this.fld_dgcMMFalseConditionalItems.BOSFieldGroup = null;
            this.fld_dgcMMFalseConditionalItems.BOSFieldRelation = null;
            this.fld_dgcMMFalseConditionalItems.BOSGridType = null;
            this.fld_dgcMMFalseConditionalItems.BOSPrivilege = null;
            this.fld_dgcMMFalseConditionalItems.BOSPropertyName = null;
            this.fld_dgcMMFalseConditionalItems.CommodityType = "";
            this.fld_dgcMMFalseConditionalItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMFalseConditionalItems.Location = new System.Drawing.Point(5, 141);
            this.fld_dgcMMFalseConditionalItems.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcMMFalseConditionalItems.Name = "fld_dgcMMFalseConditionalItems";
            this.fld_dgcMMFalseConditionalItems.PrintReport = false;
            this.fld_dgcMMFalseConditionalItems.Screen = null;
            this.fld_dgcMMFalseConditionalItems.Size = new System.Drawing.Size(1269, 427);
            this.fld_dgcMMFalseConditionalItems.TabIndex = 7;
            this.fld_dgcMMFalseConditionalItems.Tag = "DC";
            this.fld_dgcMMFalseConditionalItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcMMFalseConditionalItems;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
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
            this.bosLabel9.Location = new System.Drawing.Point(22, 100);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(49, 13);
            this.bosLabel9.TabIndex = 4;
            this.bosLabel9.Text = "Tình trạng";
            // 
            // fld_lkeMMFalseConditionalStatus
            // 
            this.fld_lkeMMFalseConditionalStatus.BOSAllowAddNew = false;
            this.fld_lkeMMFalseConditionalStatus.BOSAllowDummy = false;
            this.fld_lkeMMFalseConditionalStatus.BOSComment = null;
            this.fld_lkeMMFalseConditionalStatus.BOSDataMember = "MMFalseConditionalStatus";
            this.fld_lkeMMFalseConditionalStatus.BOSDataSource = "MMFalseConditionals";
            this.fld_lkeMMFalseConditionalStatus.BOSDescription = null;
            this.fld_lkeMMFalseConditionalStatus.BOSError = null;
            this.fld_lkeMMFalseConditionalStatus.BOSFieldGroup = null;
            this.fld_lkeMMFalseConditionalStatus.BOSFieldParent = null;
            this.fld_lkeMMFalseConditionalStatus.BOSFieldRelation = null;
            this.fld_lkeMMFalseConditionalStatus.BOSPrivilege = null;
            this.fld_lkeMMFalseConditionalStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMFalseConditionalStatus.BOSSelectType = null;
            this.fld_lkeMMFalseConditionalStatus.BOSSelectTypeValue = null;
            this.fld_lkeMMFalseConditionalStatus.CurrentDisplayText = null;
            this.fld_lkeMMFalseConditionalStatus.Enabled = false;
            this.fld_lkeMMFalseConditionalStatus.Location = new System.Drawing.Point(109, 97);
            this.fld_lkeMMFalseConditionalStatus.MenuManager = this.screenToolbar;
            this.fld_lkeMMFalseConditionalStatus.Name = "fld_lkeMMFalseConditionalStatus";
            this.fld_lkeMMFalseConditionalStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMFalseConditionalStatus.Properties.ColumnName = null;
            this.fld_lkeMMFalseConditionalStatus.Properties.NullText = "";
            this.fld_lkeMMFalseConditionalStatus.Screen = null;
            this.fld_lkeMMFalseConditionalStatus.Size = new System.Drawing.Size(118, 20);
            this.fld_lkeMMFalseConditionalStatus.TabIndex = 5;
            this.fld_lkeMMFalseConditionalStatus.Tag = "DC";
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
            this.bosLabel5.Location = new System.Drawing.Point(22, 74);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(72, 13);
            this.bosLabel5.TabIndex = 2;
            this.bosLabel5.Text = "Ngày chứng từ";
            // 
            // fld_dteMMFalseConditionalDate
            // 
            this.fld_dteMMFalseConditionalDate.BOSComment = null;
            this.fld_dteMMFalseConditionalDate.BOSDataMember = "MMFalseConditionalDate";
            this.fld_dteMMFalseConditionalDate.BOSDataSource = "MMFalseConditionals";
            this.fld_dteMMFalseConditionalDate.BOSDescription = null;
            this.fld_dteMMFalseConditionalDate.BOSError = null;
            this.fld_dteMMFalseConditionalDate.BOSFieldGroup = null;
            this.fld_dteMMFalseConditionalDate.BOSFieldRelation = null;
            this.fld_dteMMFalseConditionalDate.BOSPrivilege = null;
            this.fld_dteMMFalseConditionalDate.BOSPropertyName = "EditValue";
            this.fld_dteMMFalseConditionalDate.EditValue = null;
            this.fld_dteMMFalseConditionalDate.Location = new System.Drawing.Point(109, 71);
            this.fld_dteMMFalseConditionalDate.MenuManager = this.screenToolbar;
            this.fld_dteMMFalseConditionalDate.Name = "fld_dteMMFalseConditionalDate";
            this.fld_dteMMFalseConditionalDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMFalseConditionalDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMFalseConditionalDate.Screen = null;
            this.fld_dteMMFalseConditionalDate.Size = new System.Drawing.Size(118, 20);
            this.fld_dteMMFalseConditionalDate.TabIndex = 3;
            this.fld_dteMMFalseConditionalDate.Tag = "DC";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseFont = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = null;
            this.fld_lblLabel4.Location = new System.Drawing.Point(22, 48);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel4, true);
            this.fld_lblLabel4.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel4.TabIndex = 0;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Mã chứng từ";
            // 
            // fld_txtMMFalseConditionalNo
            // 
            this.fld_txtMMFalseConditionalNo.BOSComment = "";
            this.fld_txtMMFalseConditionalNo.BOSDataMember = "MMFalseConditionalNo";
            this.fld_txtMMFalseConditionalNo.BOSDataSource = "MMFalseConditionals";
            this.fld_txtMMFalseConditionalNo.BOSDescription = null;
            this.fld_txtMMFalseConditionalNo.BOSError = "";
            this.fld_txtMMFalseConditionalNo.BOSFieldGroup = "";
            this.fld_txtMMFalseConditionalNo.BOSFieldRelation = "";
            this.fld_txtMMFalseConditionalNo.BOSPrivilege = "";
            this.fld_txtMMFalseConditionalNo.BOSPropertyName = "Text";
            this.fld_txtMMFalseConditionalNo.Location = new System.Drawing.Point(109, 45);
            this.fld_txtMMFalseConditionalNo.Name = "fld_txtMMFalseConditionalNo";
            this.fld_txtMMFalseConditionalNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMFalseConditionalNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMFalseConditionalNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMFalseConditionalNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMFalseConditionalNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMFalseConditionalNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMFalseConditionalNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMFalseConditionalNo, true);
            this.fld_txtMMFalseConditionalNo.Size = new System.Drawing.Size(118, 20);
            this.fld_txtMMFalseConditionalNo.TabIndex = 1;
            this.fld_txtMMFalseConditionalNo.Tag = "DC";
            // 
            // DMFC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1282, 699);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMFC100.IconOptions.Icon")));
            this.Name = "DMFC100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox4.Properties)).EndInit();
            this.bosLine5.ResumeLayout(false);
            this.bosLine5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMFalseConditionalHyperLink.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosMemoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACObjectAccessKey.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRCheckerEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HRReceiverEmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductAttributeWoodTypeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMFalseConditionalItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMFalseConditionalStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMFalseConditionalDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMFalseConditionalDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMFalseConditionalNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSTextBox fld_txtMMFalseConditionalNo;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSDateEdit fld_dteMMFalseConditionalDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeMMFalseConditionalStatus;
        private FalseConditional.FalseConditionalItemsGridControl fld_dgcMMFalseConditionalItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRCheckerEmployeeID;
        private BOSComponent.BOSTextBox bosTextBox3;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HRReceiverEmployeeID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeICProductAttributeWoodTypeID;
        private BOSComponent.BOSLabel bosLabel1;
        private AccObjectLookupEdit fld_lkeACObjectAccessKey;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLabel bosLabel12;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSLabel bosLabel10;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSLabel bosLabel14;
        private BOSComponent.BOSLabel bosLabel13;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSMemoEdit bosMemoEdit1;
        private BOSComponent.BOSTextBox fld_txtMMFalseConditionalHyperLink;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel fld_txtMMFalseConditionalSoftFault;
        private BOSComponent.BOSLabel fld_txtMMFalseConditionalHardFault;
        private BOSComponent.BOSLabel fld_txtMMFalseConditionalAveragePercent;
        private BOSComponent.BOSTextBox bosTextBox4;
        private BOSComponent.BOSLabel bosLabel18;
    }
}
