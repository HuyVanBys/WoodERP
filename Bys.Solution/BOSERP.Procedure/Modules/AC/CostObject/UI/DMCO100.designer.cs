using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CostObject.UI
{
	/// <summary>
	/// Summary description for DMCO100
	/// </summary>
	partial class DMCO100
	{
		private BOSComponent.BOSLabel fld_lblLabel2;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSTextBox fld_txtACCostObjectNo1;
		private BOSComponent.BOSTextBox fld_txtACCostObjectName1;
        private BOSComponent.BOSMemoEdit fld_medACCostObjectDesc;
		private BOSComponent.BOSLabel fld_lblLabel7;
        private BOSComponent.BOSTextBox fld_txtACCostObjectAllocationMonths;


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
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostObjectNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACCostObjectName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medACCostObjectDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostObjectAllocationMonths = new BOSComponent.BOSTextBox(this.components);
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit2 = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_ACCostAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_PMProjectID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel25 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteFK_ACDepreciationWaitAccountID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_BRCostedBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_tabCostObjectItems = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabPageCostObjectItems = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACCostObjectItems = new BOSERP.Modules.CostObject.ACCostObjectItemsGridControl();
            this.fld_dgvACCostObjectItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACCostObjectDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectAllocationMonths.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFK_ACDepreciationWaitAccountID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRCostedBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCostObjectItems)).BeginInit();
            this.fld_tabCostObjectItems.SuspendLayout();
            this.fld_tabPageCostObjectItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACCostObjectItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACCostObjectItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(16, 32);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(63, 13);
            this.fld_lblLabel2.TabIndex = 4;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã đối tượng";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(16, 110);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel3.TabIndex = 5;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Diễn giải";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(294, 32);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(67, 13);
            this.fld_lblLabel4.TabIndex = 6;
            this.fld_lblLabel4.Tag = "";
            this.fld_lblLabel4.Text = "Tên đối tượng";
            // 
            // fld_txtACCostObjectNo1
            // 
            this.fld_txtACCostObjectNo1.BOSComment = "";
            this.fld_txtACCostObjectNo1.BOSDataMember = "ACCostObjectNo";
            this.fld_txtACCostObjectNo1.BOSDataSource = "ACCostObjects";
            this.fld_txtACCostObjectNo1.BOSDescription = null;
            this.fld_txtACCostObjectNo1.BOSError = null;
            this.fld_txtACCostObjectNo1.BOSFieldGroup = "";
            this.fld_txtACCostObjectNo1.BOSFieldRelation = "";
            this.fld_txtACCostObjectNo1.BOSPrivilege = "";
            this.fld_txtACCostObjectNo1.BOSPropertyName = "Text";
            this.fld_txtACCostObjectNo1.EditValue = "";
            this.fld_txtACCostObjectNo1.Location = new System.Drawing.Point(121, 29);
            this.fld_txtACCostObjectNo1.Name = "fld_txtACCostObjectNo1";
            this.fld_txtACCostObjectNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostObjectNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostObjectNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostObjectNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostObjectNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostObjectNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostObjectNo1.Screen = null;
            this.fld_txtACCostObjectNo1.Size = new System.Drawing.Size(151, 20);
            this.fld_txtACCostObjectNo1.TabIndex = 0;
            this.fld_txtACCostObjectNo1.Tag = "DC";
            // 
            // fld_txtACCostObjectName1
            // 
            this.fld_txtACCostObjectName1.BOSComment = "";
            this.fld_txtACCostObjectName1.BOSDataMember = "ACCostObjectName";
            this.fld_txtACCostObjectName1.BOSDataSource = "ACCostObjects";
            this.fld_txtACCostObjectName1.BOSDescription = null;
            this.fld_txtACCostObjectName1.BOSError = null;
            this.fld_txtACCostObjectName1.BOSFieldGroup = "";
            this.fld_txtACCostObjectName1.BOSFieldRelation = "";
            this.fld_txtACCostObjectName1.BOSPrivilege = "";
            this.fld_txtACCostObjectName1.BOSPropertyName = "Text";
            this.fld_txtACCostObjectName1.EditValue = "";
            this.fld_txtACCostObjectName1.Location = new System.Drawing.Point(399, 29);
            this.fld_txtACCostObjectName1.Name = "fld_txtACCostObjectName1";
            this.fld_txtACCostObjectName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostObjectName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostObjectName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostObjectName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostObjectName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostObjectName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostObjectName1.Screen = null;
            this.fld_txtACCostObjectName1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostObjectName1.TabIndex = 1;
            this.fld_txtACCostObjectName1.Tag = "DC";
            // 
            // fld_medACCostObjectDesc
            // 
            this.fld_medACCostObjectDesc.BOSComment = "";
            this.fld_medACCostObjectDesc.BOSDataMember = "ACCostObjectDesc";
            this.fld_medACCostObjectDesc.BOSDataSource = "ACCostObjects";
            this.fld_medACCostObjectDesc.BOSDescription = null;
            this.fld_medACCostObjectDesc.BOSError = null;
            this.fld_medACCostObjectDesc.BOSFieldGroup = "";
            this.fld_medACCostObjectDesc.BOSFieldRelation = "";
            this.fld_medACCostObjectDesc.BOSPrivilege = "";
            this.fld_medACCostObjectDesc.BOSPropertyName = "Text";
            this.fld_medACCostObjectDesc.EditValue = "";
            this.fld_medACCostObjectDesc.Location = new System.Drawing.Point(121, 107);
            this.fld_medACCostObjectDesc.Name = "fld_medACCostObjectDesc";
            this.fld_medACCostObjectDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACCostObjectDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACCostObjectDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACCostObjectDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACCostObjectDesc.Screen = null;
            this.fld_medACCostObjectDesc.Size = new System.Drawing.Size(688, 46);
            this.fld_medACCostObjectDesc.TabIndex = 9;
            this.fld_medACCostObjectDesc.Tag = "DC";
            // 
            // fld_lblLabel7
            // 
            this.fld_lblLabel7.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel7.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel7.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel7.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel7.BOSComment = "";
            this.fld_lblLabel7.BOSDataMember = "";
            this.fld_lblLabel7.BOSDataSource = "";
            this.fld_lblLabel7.BOSDescription = null;
            this.fld_lblLabel7.BOSError = null;
            this.fld_lblLabel7.BOSFieldGroup = "";
            this.fld_lblLabel7.BOSFieldRelation = "";
            this.fld_lblLabel7.BOSPrivilege = "";
            this.fld_lblLabel7.BOSPropertyName = "";
            this.fld_lblLabel7.Location = new System.Drawing.Point(16, 84);
            this.fld_lblLabel7.Name = "fld_lblLabel7";
            this.fld_lblLabel7.Screen = null;
            this.fld_lblLabel7.Size = new System.Drawing.Size(68, 13);
            this.fld_lblLabel7.TabIndex = 14;
            this.fld_lblLabel7.Tag = "";
            this.fld_lblLabel7.Text = "Số kỳ phân bổ";
            // 
            // fld_txtACCostObjectAllocationMonths
            // 
            this.fld_txtACCostObjectAllocationMonths.BOSComment = "";
            this.fld_txtACCostObjectAllocationMonths.BOSDataMember = "ACCostObjectAllocationMonths";
            this.fld_txtACCostObjectAllocationMonths.BOSDataSource = "ACCostObjects";
            this.fld_txtACCostObjectAllocationMonths.BOSDescription = null;
            this.fld_txtACCostObjectAllocationMonths.BOSError = null;
            this.fld_txtACCostObjectAllocationMonths.BOSFieldGroup = "";
            this.fld_txtACCostObjectAllocationMonths.BOSFieldRelation = "";
            this.fld_txtACCostObjectAllocationMonths.BOSPrivilege = "";
            this.fld_txtACCostObjectAllocationMonths.BOSPropertyName = "Text";
            this.fld_txtACCostObjectAllocationMonths.EditValue = "";
            this.fld_txtACCostObjectAllocationMonths.Location = new System.Drawing.Point(122, 81);
            this.fld_txtACCostObjectAllocationMonths.Name = "fld_txtACCostObjectAllocationMonths";
            this.fld_txtACCostObjectAllocationMonths.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostObjectAllocationMonths.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostObjectAllocationMonths.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostObjectAllocationMonths.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostObjectAllocationMonths.Properties.Mask.EditMask = "n0";
            this.fld_txtACCostObjectAllocationMonths.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACCostObjectAllocationMonths.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostObjectAllocationMonths.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostObjectAllocationMonths.Screen = null;
            this.fld_txtACCostObjectAllocationMonths.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostObjectAllocationMonths.TabIndex = 6;
            this.fld_txtACCostObjectAllocationMonths.Tag = "DC";
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
            this.bosGroupControl1.Controls.Add(this.bosLine2);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit2);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_ACCostAccountID);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel7);
            this.bosGroupControl1.Controls.Add(this.bosLookupEdit1);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.bosLabel5);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_PMProjectID);
            this.bosGroupControl1.Controls.Add(this.fld_txtACCostObjectAllocationMonths);
            this.bosGroupControl1.Controls.Add(this.bosLabel25);
            this.bosGroupControl1.Controls.Add(this.fld_dteFK_ACDepreciationWaitAccountID);
            this.bosGroupControl1.Controls.Add(this.fld_lkeFK_BRCostedBranchID);
            this.bosGroupControl1.Controls.Add(this.fld_txtACCostObjectNo1);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel2);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_lblLabel4);
            this.bosGroupControl1.Controls.Add(this.fld_medACCostObjectDesc);
            this.bosGroupControl1.Controls.Add(this.fld_txtACCostObjectName1);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(1087, 165);
            this.bosGroupControl1.TabIndex = 16;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // bosLine2
            // 
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = "";
            this.bosLine2.BOSDataMember = "";
            this.bosLine2.BOSDataSource = "";
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = "";
            this.bosLine2.BOSFieldRelation = "";
            this.bosLine2.BOSPrivilege = "";
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.bosTextBox2);
            this.bosLine2.Controls.Add(this.bosTextBox1);
            this.bosLine2.Controls.Add(this.bosLabel6);
            this.bosLine2.Controls.Add(this.bosLabel14);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.bosLine2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLine2.Location = new System.Drawing.Point(825, 25);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(168, 76);
            this.bosLine2.TabIndex = 684;
            this.bosLine2.TabStop = false;
            this.bosLine2.Tag = "";
            this.bosLine2.Text = "Ghi chú";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "";
            this.bosTextBox2.BOSDataSource = "";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = null;
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.EditValue = "";
            this.bosTextBox2.Enabled = false;
            this.bosTextBox2.Location = new System.Drawing.Point(116, 46);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.Properties.ReadOnly = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(46, 20);
            this.bosTextBox2.TabIndex = 12;
            this.bosTextBox2.Tag = "DC";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "";
            this.bosTextBox1.BOSDataSource = "";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = "";
            this.bosTextBox1.Enabled = false;
            this.bosTextBox1.Location = new System.Drawing.Point(116, 20);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.Properties.ReadOnly = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(46, 20);
            this.bosTextBox1.TabIndex = 11;
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel6
            // 
            this.bosLabel6.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel6.Location = new System.Drawing.Point(9, 49);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(82, 13);
            this.bosLabel6.TabIndex = 10;
            this.bosLabel6.Tag = "";
            this.bosLabel6.Text = "Đã chạy phân bổ";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel14.Appearance.Options.UseBackColor = true;
            this.bosLabel14.Appearance.Options.UseForeColor = true;
            this.bosLabel14.BOSComment = "";
            this.bosLabel14.BOSDataMember = "";
            this.bosLabel14.BOSDataSource = "";
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = "";
            this.bosLabel14.BOSFieldRelation = "";
            this.bosLabel14.BOSPrivilege = "";
            this.bosLabel14.BOSPropertyName = "";
            this.bosLabel14.Location = new System.Drawing.Point(9, 23);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(94, 13);
            this.bosLabel14.TabIndex = 9;
            this.bosLabel14.Tag = "";
            this.bosLabel14.Text = "Chưa chạy phân bổ";
            // 
            // bosLookupEdit2
            // 
            this.bosLookupEdit2.BOSAllowAddNew = false;
            this.bosLookupEdit2.BOSAllowDummy = true;
            this.bosLookupEdit2.BOSComment = "";
            this.bosLookupEdit2.BOSDataMember = "FK_ACSegmentID";
            this.bosLookupEdit2.BOSDataSource = "ACCostObjects";
            this.bosLookupEdit2.BOSDescription = null;
            this.bosLookupEdit2.BOSError = null;
            this.bosLookupEdit2.BOSFieldGroup = "";
            this.bosLookupEdit2.BOSFieldParent = "";
            this.bosLookupEdit2.BOSFieldRelation = "";
            this.bosLookupEdit2.BOSPrivilege = "";
            this.bosLookupEdit2.BOSPropertyName = "EditValue";
            this.bosLookupEdit2.BOSSelectType = "";
            this.bosLookupEdit2.BOSSelectTypeValue = "";
            this.bosLookupEdit2.CurrentDisplayText = null;
            this.bosLookupEdit2.Location = new System.Drawing.Point(661, 81);
            this.bosLookupEdit2.Name = "bosLookupEdit2";
            this.bosLookupEdit2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit2.Properties.ColumnName = null;
            this.bosLookupEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACSegmentName", "Tên")});
            this.bosLookupEdit2.Properties.DisplayMember = "ACSegmentName";
            this.bosLookupEdit2.Properties.NullText = "";
            this.bosLookupEdit2.Properties.PopupWidth = 40;
            this.bosLookupEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit2.Properties.ValueMember = "ACSegmentID";
            this.bosLookupEdit2.Screen = null;
            this.bosLookupEdit2.Size = new System.Drawing.Size(148, 20);
            this.bosLookupEdit2.TabIndex = 8;
            this.bosLookupEdit2.Tag = "DC";
            // 
            // fld_lkeFK_ACCostAccountID
            // 
            this.fld_lkeFK_ACCostAccountID.BOSAllowAddNew = false;
            this.fld_lkeFK_ACCostAccountID.BOSAllowDummy = true;
            this.fld_lkeFK_ACCostAccountID.BOSComment = null;
            this.fld_lkeFK_ACCostAccountID.BOSDataMember = "FK_ACCostAccountID";
            this.fld_lkeFK_ACCostAccountID.BOSDataSource = "ACCostObjects";
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
            this.fld_lkeFK_ACCostAccountID.Location = new System.Drawing.Point(399, 55);
            this.fld_lkeFK_ACCostAccountID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_ACCostAccountID.Name = "fld_lkeFK_ACCostAccountID";
            this.fld_lkeFK_ACCostAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_ACCostAccountID.Properties.ColumnName = null;
            this.fld_lkeFK_ACCostAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_lkeFK_ACCostAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_lkeFK_ACCostAccountID.Screen = null;
            this.fld_lkeFK_ACCostAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_ACCostAccountID.TabIndex = 4;
            this.fld_lkeFK_ACCostAccountID.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(570, 84);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(85, 13);
            this.bosLabel4.TabIndex = 683;
            this.bosLabel4.Tag = "";
            this.bosLabel4.Text = "Khoản mục chi phí";
            // 
            // bosLookupEdit1
            // 
            this.bosLookupEdit1.BOSAllowAddNew = false;
            this.bosLookupEdit1.BOSAllowDummy = true;
            this.bosLookupEdit1.BOSComment = "";
            this.bosLookupEdit1.BOSDataMember = "FK_ACCostCenterID";
            this.bosLookupEdit1.BOSDataSource = "ACCostObjects";
            this.bosLookupEdit1.BOSDescription = null;
            this.bosLookupEdit1.BOSError = null;
            this.bosLookupEdit1.BOSFieldGroup = "";
            this.bosLookupEdit1.BOSFieldParent = "";
            this.bosLookupEdit1.BOSFieldRelation = "";
            this.bosLookupEdit1.BOSPrivilege = "";
            this.bosLookupEdit1.BOSPropertyName = "EditValue";
            this.bosLookupEdit1.BOSSelectType = "";
            this.bosLookupEdit1.BOSSelectTypeValue = "";
            this.bosLookupEdit1.CurrentDisplayText = null;
            this.bosLookupEdit1.Location = new System.Drawing.Point(661, 55);
            this.bosLookupEdit1.Name = "bosLookupEdit1";
            this.bosLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.bosLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.bosLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit1.Properties.ColumnName = null;
            this.bosLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCostCenterNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACCostCenterName", "Tên")});
            this.bosLookupEdit1.Properties.DisplayMember = "ACCostCenterName";
            this.bosLookupEdit1.Properties.NullText = "";
            this.bosLookupEdit1.Properties.PopupWidth = 40;
            this.bosLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.bosLookupEdit1.Properties.ValueMember = "ACCostCenterID";
            this.bosLookupEdit1.Screen = null;
            this.bosLookupEdit1.Size = new System.Drawing.Size(148, 20);
            this.bosLookupEdit1.TabIndex = 5;
            this.bosLookupEdit1.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = "";
            this.bosLabel1.BOSDataMember = "";
            this.bosLabel1.BOSDataSource = "";
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = "";
            this.bosLabel1.BOSFieldRelation = "";
            this.bosLabel1.BOSPrivilege = "";
            this.bosLabel1.BOSPropertyName = "";
            this.bosLabel1.Location = new System.Drawing.Point(16, 58);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 14;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // bosLabel5
            // 
            this.bosLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel5.Appearance.Options.UseBackColor = true;
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
            this.bosLabel5.Location = new System.Drawing.Point(570, 58);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(83, 13);
            this.bosLabel5.TabIndex = 681;
            this.bosLabel5.Tag = "";
            this.bosLabel5.Text = "Trung tâm chi phí";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = "";
            this.bosLabel2.Location = new System.Drawing.Point(294, 58);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(46, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "TK chi phí";
            // 
            // fld_lkeFK_PMProjectID
            // 
            this.fld_lkeFK_PMProjectID.BOSAllowAddNew = false;
            this.fld_lkeFK_PMProjectID.BOSAllowDummy = true;
            this.fld_lkeFK_PMProjectID.BOSComment = "";
            this.fld_lkeFK_PMProjectID.BOSDataMember = "FK_PMProjectID";
            this.fld_lkeFK_PMProjectID.BOSDataSource = "ACCostObjects";
            this.fld_lkeFK_PMProjectID.BOSDescription = null;
            this.fld_lkeFK_PMProjectID.BOSError = null;
            this.fld_lkeFK_PMProjectID.BOSFieldGroup = "";
            this.fld_lkeFK_PMProjectID.BOSFieldParent = "";
            this.fld_lkeFK_PMProjectID.BOSFieldRelation = "";
            this.fld_lkeFK_PMProjectID.BOSPrivilege = "";
            this.fld_lkeFK_PMProjectID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_PMProjectID.BOSSelectType = "";
            this.fld_lkeFK_PMProjectID.BOSSelectTypeValue = "";
            this.fld_lkeFK_PMProjectID.CurrentDisplayText = null;
            this.fld_lkeFK_PMProjectID.Location = new System.Drawing.Point(661, 29);
            this.fld_lkeFK_PMProjectID.Name = "fld_lkeFK_PMProjectID";
            this.fld_lkeFK_PMProjectID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_PMProjectID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_PMProjectID.Properties.ColumnName = null;
            this.fld_lkeFK_PMProjectID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectNo", "Mã dự án"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PMProjectName", "Tên dự án")});
            this.fld_lkeFK_PMProjectID.Properties.DisplayMember = "PMProjectNo";
            this.fld_lkeFK_PMProjectID.Properties.NullText = "";
            this.fld_lkeFK_PMProjectID.Properties.PopupWidth = 40;
            this.fld_lkeFK_PMProjectID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_PMProjectID.Properties.ValueMember = "PMProjectID";
            this.fld_lkeFK_PMProjectID.Screen = null;
            this.fld_lkeFK_PMProjectID.Size = new System.Drawing.Size(148, 20);
            this.fld_lkeFK_PMProjectID.TabIndex = 2;
            this.fld_lkeFK_PMProjectID.Tag = "DC";
            // 
            // bosLabel25
            // 
            this.bosLabel25.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel25.Appearance.Options.UseBackColor = true;
            this.bosLabel25.Appearance.Options.UseForeColor = true;
            this.bosLabel25.BOSComment = "";
            this.bosLabel25.BOSDataMember = "";
            this.bosLabel25.BOSDataSource = "";
            this.bosLabel25.BOSDescription = null;
            this.bosLabel25.BOSError = null;
            this.bosLabel25.BOSFieldGroup = "";
            this.bosLabel25.BOSFieldRelation = "";
            this.bosLabel25.BOSPrivilege = "";
            this.bosLabel25.BOSPropertyName = null;
            this.bosLabel25.Location = new System.Drawing.Point(570, 32);
            this.bosLabel25.Name = "bosLabel25";
            this.bosLabel25.Screen = null;
            this.bosLabel25.Size = new System.Drawing.Size(45, 13);
            this.bosLabel25.TabIndex = 679;
            this.bosLabel25.Tag = "";
            this.bosLabel25.Text = "Mã dự án";
            // 
            // fld_dteFK_ACDepreciationWaitAccountID
            // 
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSAllowAddNew = false;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSAllowDummy = true;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSComment = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSDataMember = "FK_ACDepreciationWaitAccountID";
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSDataSource = "ACCostObjects";
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSDescription = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSError = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSFieldGroup = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSFieldParent = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSFieldRelation = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSPrivilege = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSPropertyName = "EditValue";
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSSelectType = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.BOSSelectTypeValue = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.CurrentDisplayText = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.Location = new System.Drawing.Point(399, 81);
            this.fld_dteFK_ACDepreciationWaitAccountID.MenuManager = this.screenToolbar;
            this.fld_dteFK_ACDepreciationWaitAccountID.Name = "fld_dteFK_ACDepreciationWaitAccountID";
            this.fld_dteFK_ACDepreciationWaitAccountID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFK_ACDepreciationWaitAccountID.Properties.ColumnName = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountNo", "Mã tài khoản"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAccountName", "Tên tài khoản")});
            this.fld_dteFK_ACDepreciationWaitAccountID.Properties.DisplayMember = "ACAccountNo";
            this.fld_dteFK_ACDepreciationWaitAccountID.Properties.ValueMember = "ACAccountID";
            this.fld_dteFK_ACDepreciationWaitAccountID.Screen = null;
            this.fld_dteFK_ACDepreciationWaitAccountID.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFK_ACDepreciationWaitAccountID.TabIndex = 7;
            this.fld_dteFK_ACDepreciationWaitAccountID.Tag = "DC";
            // 
            // fld_lkeFK_BRCostedBranchID
            // 
            this.fld_lkeFK_BRCostedBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRCostedBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRCostedBranchID.BOSComment = null;
            this.fld_lkeFK_BRCostedBranchID.BOSDataMember = "FK_BRCostedBranchID";
            this.fld_lkeFK_BRCostedBranchID.BOSDataSource = "ACCostObjects";
            this.fld_lkeFK_BRCostedBranchID.BOSDescription = null;
            this.fld_lkeFK_BRCostedBranchID.BOSError = null;
            this.fld_lkeFK_BRCostedBranchID.BOSFieldGroup = null;
            this.fld_lkeFK_BRCostedBranchID.BOSFieldParent = null;
            this.fld_lkeFK_BRCostedBranchID.BOSFieldRelation = null;
            this.fld_lkeFK_BRCostedBranchID.BOSPrivilege = null;
            this.fld_lkeFK_BRCostedBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRCostedBranchID.BOSSelectType = null;
            this.fld_lkeFK_BRCostedBranchID.BOSSelectTypeValue = null;
            this.fld_lkeFK_BRCostedBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRCostedBranchID.Location = new System.Drawing.Point(122, 55);
            this.fld_lkeFK_BRCostedBranchID.MenuManager = this.screenToolbar;
            this.fld_lkeFK_BRCostedBranchID.Name = "fld_lkeFK_BRCostedBranchID";
            this.fld_lkeFK_BRCostedBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRCostedBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRCostedBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRCostedBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRCostedBranchID.Screen = null;
            this.fld_lkeFK_BRCostedBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRCostedBranchID.TabIndex = 3;
            this.fld_lkeFK_BRCostedBranchID.Tag = "DC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = "";
            this.bosLabel3.Location = new System.Drawing.Point(294, 84);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(74, 13);
            this.bosLabel3.TabIndex = 16;
            this.bosLabel3.Tag = "";
            this.bosLabel3.Text = "TK chờ phân bổ";
            // 
            // fld_tabCostObjectItems
            // 
            this.fld_tabCostObjectItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_tabCostObjectItems.BOSComment = null;
            this.fld_tabCostObjectItems.BOSDataMember = null;
            this.fld_tabCostObjectItems.BOSDataSource = null;
            this.fld_tabCostObjectItems.BOSDescription = null;
            this.fld_tabCostObjectItems.BOSError = null;
            this.fld_tabCostObjectItems.BOSFieldGroup = null;
            this.fld_tabCostObjectItems.BOSFieldRelation = null;
            this.fld_tabCostObjectItems.BOSPrivilege = null;
            this.fld_tabCostObjectItems.BOSPropertyName = null;
            this.fld_tabCostObjectItems.Location = new System.Drawing.Point(3, 171);
            this.fld_tabCostObjectItems.Name = "fld_tabCostObjectItems";
            this.fld_tabCostObjectItems.Screen = null;
            this.fld_tabCostObjectItems.SelectedTabPage = this.fld_tabPageCostObjectItems;
            this.fld_tabCostObjectItems.Size = new System.Drawing.Size(1087, 435);
            this.fld_tabCostObjectItems.TabIndex = 17;
            this.fld_tabCostObjectItems.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabPageCostObjectItems});
            // 
            // fld_tabPageCostObjectItems
            // 
            this.fld_tabPageCostObjectItems.Controls.Add(this.fld_dgcACCostObjectItems);
            this.fld_tabPageCostObjectItems.Name = "fld_tabPageCostObjectItems";
            this.fld_tabPageCostObjectItems.Size = new System.Drawing.Size(1081, 407);
            this.fld_tabPageCostObjectItems.Text = "Theo dõi chi phí chờ phân bổ";
            // 
            // fld_dgcACCostObjectItems
            // 
            this.fld_dgcACCostObjectItems.AllowDrop = true;
            this.fld_dgcACCostObjectItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcACCostObjectItems.BOSComment = "";
            this.fld_dgcACCostObjectItems.BOSDataMember = "";
            this.fld_dgcACCostObjectItems.BOSDataSource = "ACCostObjectItems";
            this.fld_dgcACCostObjectItems.BOSDescription = null;
            this.fld_dgcACCostObjectItems.BOSError = null;
            this.fld_dgcACCostObjectItems.BOSFieldGroup = "";
            this.fld_dgcACCostObjectItems.BOSFieldRelation = "";
            this.fld_dgcACCostObjectItems.BOSGridType = null;
            this.fld_dgcACCostObjectItems.BOSPrivilege = "";
            this.fld_dgcACCostObjectItems.BOSPropertyName = null;
            this.fld_dgcACCostObjectItems.CommodityType = "";
            this.fld_dgcACCostObjectItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACCostObjectItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACCostObjectItems.MainView = this.fld_dgvACCostObjectItems;
            this.fld_dgcACCostObjectItems.Name = "fld_dgcACCostObjectItems";
            this.fld_dgcACCostObjectItems.PrintReport = false;
            this.fld_dgcACCostObjectItems.Screen = null;
            this.fld_dgcACCostObjectItems.Size = new System.Drawing.Size(1074, 406);
            this.fld_dgcACCostObjectItems.TabIndex = 0;
            this.fld_dgcACCostObjectItems.Tag = "DC";
            this.fld_dgcACCostObjectItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACCostObjectItems});
            // 
            // fld_dgvACCostObjectItems
            // 
            this.fld_dgvACCostObjectItems.GridControl = this.fld_dgcACCostObjectItems;
            this.fld_dgvACCostObjectItems.Name = "fld_dgvACCostObjectItems";
            this.fld_dgvACCostObjectItems.PaintStyleName = "Office2003";
            // 
            // panel1
            // 
            this.panel1.BOSComment = null;
            this.panel1.BOSDataMember = null;
            this.panel1.BOSDataSource = null;
            this.panel1.BOSDescription = null;
            this.panel1.BOSError = null;
            this.panel1.BOSFieldGroup = null;
            this.panel1.BOSFieldRelation = null;
            this.panel1.BOSPrivilege = null;
            this.panel1.BOSPropertyName = null;
            this.panel1.Controls.Add(this.bosGroupControl1);
            this.panel1.Controls.Add(this.fld_tabCostObjectItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Screen = null;
            this.panel1.Size = new System.Drawing.Size(1093, 609);
            this.panel1.TabIndex = 18;
            // 
            // DMCO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1093, 609);
            this.Controls.Add(this.panel1);
            this.Name = "DMCO100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACCostObjectDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostObjectAllocationMonths.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ACCostAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_PMProjectID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFK_ACDepreciationWaitAccountID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRCostedBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCostObjectItems)).EndInit();
            this.fld_tabCostObjectItems.ResumeLayout(false);
            this.fld_tabPageCostObjectItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACCostObjectItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACCostObjectItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRCostedBranchID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ACCostAccountID;
        private BOSComponent.BOSLookupEdit fld_dteFK_ACDepreciationWaitAccountID;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit bosLookupEdit2;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit bosLookupEdit1;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLookupEdit fld_lkeFK_PMProjectID;
        private BOSComponent.BOSLabel bosLabel25;
        private BOSComponent.BOSTabControl fld_tabCostObjectItems;
        private DevExpress.XtraTab.XtraTabPage fld_tabPageCostObjectItems;
        private BOSERP.Modules.CostObject.ACCostObjectItemsGridControl fld_dgcACCostObjectItems;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACCostObjectItems;
        private BOSComponent.BOSPanel panel1;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel14;
    }
}
