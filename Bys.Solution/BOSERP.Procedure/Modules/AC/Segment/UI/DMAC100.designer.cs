using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Segment.UI
{
	/// <summary>
	/// Summary description for DMAC100
	/// </summary>
	partial class DMAC100
	{
		private BOSComponent.BOSTextBox fld_txtACSegmentNo1;
		private BOSComponent.BOSTextBox fld_txtACSegmentName1;
        private BOSComponent.BOSMemoEdit fld_medACSegmentDesc;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMAC100));
            this.fld_txtACSegmentNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACSegmentName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medACSegmentDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACSegmentType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACSegmentObjectControls = new BOSERP.Modules.Segment.ACSegmentObjectControlsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcACSegmentDocumentControls = new BOSERP.Modules.Segment.ACSegmentDocumentControlsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lblACSegmentBudgetControlPercent = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACSegmentBudgetControlPercent = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeACCostType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACSegmentExcludeCreditAccountNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACSegmentExcludeDebitAccountNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACSegmentCreditAccountNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACSegmentDebitAccountNo = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACSegmentDesc.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACSegmentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACSegmentObjectControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACSegmentDocumentControls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentBudgetControlPercent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentExcludeCreditAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentExcludeDebitAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentCreditAccountNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentDebitAccountNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACSegmentNo1
            // 
            this.fld_txtACSegmentNo1.BOSComment = "";
            this.fld_txtACSegmentNo1.BOSDataMember = "ACSegmentNo";
            this.fld_txtACSegmentNo1.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentNo1.BOSDescription = null;
            this.fld_txtACSegmentNo1.BOSError = null;
            this.fld_txtACSegmentNo1.BOSFieldGroup = "";
            this.fld_txtACSegmentNo1.BOSFieldRelation = "";
            this.fld_txtACSegmentNo1.BOSPrivilege = "";
            this.fld_txtACSegmentNo1.BOSPropertyName = "Text";
            this.fld_txtACSegmentNo1.EditValue = "";
            this.fld_txtACSegmentNo1.Location = new System.Drawing.Point(128, 9);
            this.fld_txtACSegmentNo1.Name = "fld_txtACSegmentNo1";
            this.fld_txtACSegmentNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSegmentNo1.Screen = null;
            this.fld_txtACSegmentNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSegmentNo1.TabIndex = 1;
            this.fld_txtACSegmentNo1.Tag = "DC";
            // 
            // fld_txtACSegmentName1
            // 
            this.fld_txtACSegmentName1.BOSComment = "";
            this.fld_txtACSegmentName1.BOSDataMember = "ACSegmentName";
            this.fld_txtACSegmentName1.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentName1.BOSDescription = null;
            this.fld_txtACSegmentName1.BOSError = null;
            this.fld_txtACSegmentName1.BOSFieldGroup = "";
            this.fld_txtACSegmentName1.BOSFieldRelation = "";
            this.fld_txtACSegmentName1.BOSPrivilege = "";
            this.fld_txtACSegmentName1.BOSPropertyName = "Text";
            this.fld_txtACSegmentName1.EditValue = "";
            this.fld_txtACSegmentName1.Location = new System.Drawing.Point(128, 35);
            this.fld_txtACSegmentName1.Name = "fld_txtACSegmentName1";
            this.fld_txtACSegmentName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSegmentName1.Screen = null;
            this.fld_txtACSegmentName1.Size = new System.Drawing.Size(445, 20);
            this.fld_txtACSegmentName1.TabIndex = 3;
            this.fld_txtACSegmentName1.Tag = "DC";
            // 
            // fld_medACSegmentDesc
            // 
            this.fld_medACSegmentDesc.BOSComment = "";
            this.fld_medACSegmentDesc.BOSDataMember = "ACSegmentDesc";
            this.fld_medACSegmentDesc.BOSDataSource = "ACSegments";
            this.fld_medACSegmentDesc.BOSDescription = null;
            this.fld_medACSegmentDesc.BOSError = null;
            this.fld_medACSegmentDesc.BOSFieldGroup = "";
            this.fld_medACSegmentDesc.BOSFieldRelation = "";
            this.fld_medACSegmentDesc.BOSPrivilege = "";
            this.fld_medACSegmentDesc.BOSPropertyName = "Text";
            this.fld_medACSegmentDesc.EditValue = "";
            this.fld_medACSegmentDesc.Location = new System.Drawing.Point(128, 139);
            this.fld_medACSegmentDesc.Name = "fld_medACSegmentDesc";
            this.fld_medACSegmentDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACSegmentDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACSegmentDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACSegmentDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACSegmentDesc.Screen = null;
            this.fld_medACSegmentDesc.Size = new System.Drawing.Size(445, 58);
            this.fld_medACSegmentDesc.TabIndex = 19;
            this.fld_medACSegmentDesc.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(12, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(68, 13);
            this.bosLabel1.TabIndex = 0;
            this.bosLabel1.Text = "Mã khoản mục";
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
            this.bosLabel2.Location = new System.Drawing.Point(12, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 2;
            this.bosLabel2.Text = "Tên khoản mục";
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
            this.bosLabel3.Location = new System.Drawing.Point(12, 141);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(27, 13);
            this.bosLabel3.TabIndex = 18;
            this.bosLabel3.Text = "Mô tả";
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
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.fld_lkeACSegmentType);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel8);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.bosTabControl1);
            this.bosPanel1.Controls.Add(this.fld_lblACSegmentBudgetControlPercent);
            this.bosPanel1.Controls.Add(this.fld_txtACSegmentBudgetControlPercent);
            this.bosPanel1.Controls.Add(this.fld_lkeACCostType);
            this.bosPanel1.Controls.Add(this.bosLabel4);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.bosLabel3);
            this.bosPanel1.Controls.Add(this.fld_txtACSegmentExcludeCreditAccountNo);
            this.bosPanel1.Controls.Add(this.fld_txtACSegmentExcludeDebitAccountNo);
            this.bosPanel1.Controls.Add(this.fld_txtACSegmentCreditAccountNo);
            this.bosPanel1.Controls.Add(this.fld_txtACSegmentDebitAccountNo);
            this.bosPanel1.Controls.Add(this.fld_txtACSegmentNo1);
            this.bosPanel1.Controls.Add(this.bosLabel2);
            this.bosPanel1.Controls.Add(this.fld_medACSegmentDesc);
            this.bosPanel1.Controls.Add(this.fld_txtACSegmentName1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(910, 595);
            this.bosPanel1.TabIndex = 0;
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
            this.bosLabel9.Location = new System.Drawing.Point(299, 116);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(99, 13);
            this.bosLabel9.TabIndex = 16;
            this.bosLabel9.Text = "Tài khoản Có loại trừ";
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
            this.bosLabel5.Location = new System.Drawing.Point(299, 90);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(62, 13);
            this.bosLabel5.TabIndex = 12;
            this.bosLabel5.Text = "Tài khoản Có";
            // 
            // fld_lkeACSegmentType
            // 
            this.fld_lkeACSegmentType.BOSAllowAddNew = false;
            this.fld_lkeACSegmentType.BOSAllowDummy = true;
            this.fld_lkeACSegmentType.BOSComment = null;
            this.fld_lkeACSegmentType.BOSDataMember = "ACSegmentType";
            this.fld_lkeACSegmentType.BOSDataSource = "ACSegments";
            this.fld_lkeACSegmentType.BOSDescription = null;
            this.fld_lkeACSegmentType.BOSError = null;
            this.fld_lkeACSegmentType.BOSFieldGroup = null;
            this.fld_lkeACSegmentType.BOSFieldParent = null;
            this.fld_lkeACSegmentType.BOSFieldRelation = null;
            this.fld_lkeACSegmentType.BOSPrivilege = null;
            this.fld_lkeACSegmentType.BOSPropertyName = "EditValue";
            this.fld_lkeACSegmentType.BOSSelectType = "";
            this.fld_lkeACSegmentType.BOSSelectTypeValue = "";
            this.fld_lkeACSegmentType.CurrentDisplayText = null;
            this.fld_lkeACSegmentType.Location = new System.Drawing.Point(423, 61);
            this.fld_lkeACSegmentType.Name = "fld_lkeACSegmentType";
            this.fld_lkeACSegmentType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACSegmentType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACSegmentType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACSegmentType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACSegmentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACSegmentType.Properties.ColumnName = null;
            this.fld_lkeACSegmentType.Properties.NullText = "";
            this.fld_lkeACSegmentType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACSegmentType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACSegmentType, true);
            this.fld_lkeACSegmentType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACSegmentType.TabIndex = 9;
            this.fld_lkeACSegmentType.Tag = "DC";
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
            this.bosLabel6.Location = new System.Drawing.Point(299, 64);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(61, 13);
            this.bosLabel6.TabIndex = 8;
            this.bosLabel6.Text = "Nhóm chi phí";
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
            this.bosLabel8.Location = new System.Drawing.Point(12, 116);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(99, 13);
            this.bosLabel8.TabIndex = 14;
            this.bosLabel8.Text = "Tài khoản Nợ loại trừ";
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
            this.bosLabel7.Location = new System.Drawing.Point(12, 90);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(62, 13);
            this.bosLabel7.TabIndex = 10;
            this.bosLabel7.Text = "Tài khoản Nợ";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 223);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(904, 369);
            this.bosTabControl1.TabIndex = 20;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.bosTabControl1.Visible = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcACSegmentObjectControls);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(902, 344);
            this.xtraTabPage1.Text = "Danh sách đối tượng kiểm soát";
            // 
            // fld_dgcACSegmentObjectControls
            // 
            this.fld_dgcACSegmentObjectControls.AllowDrop = true;
            this.fld_dgcACSegmentObjectControls.BOSComment = null;
            this.fld_dgcACSegmentObjectControls.BOSDataMember = null;
            this.fld_dgcACSegmentObjectControls.BOSDataSource = "ACSegmentObjectControls";
            this.fld_dgcACSegmentObjectControls.BOSDescription = null;
            this.fld_dgcACSegmentObjectControls.BOSError = null;
            this.fld_dgcACSegmentObjectControls.BOSFieldGroup = null;
            this.fld_dgcACSegmentObjectControls.BOSFieldRelation = null;
            this.fld_dgcACSegmentObjectControls.BOSGridType = null;
            this.fld_dgcACSegmentObjectControls.BOSPrivilege = null;
            this.fld_dgcACSegmentObjectControls.BOSPropertyName = null;
            this.fld_dgcACSegmentObjectControls.CommodityType = "";
            this.fld_dgcACSegmentObjectControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACSegmentObjectControls.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACSegmentObjectControls.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACSegmentObjectControls.MainView = this.gridView1;
            this.fld_dgcACSegmentObjectControls.Name = "fld_dgcACSegmentObjectControls";
            this.fld_dgcACSegmentObjectControls.PrintReport = false;
            this.fld_dgcACSegmentObjectControls.Screen = null;
            this.fld_dgcACSegmentObjectControls.Size = new System.Drawing.Size(902, 344);
            this.fld_dgcACSegmentObjectControls.TabIndex = 0;
            this.fld_dgcACSegmentObjectControls.Tag = "DC";
            this.fld_dgcACSegmentObjectControls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACSegmentObjectControls;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcACSegmentDocumentControls);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(888, 337);
            this.xtraTabPage2.Text = "Danh sách chứng từ kiểm soát";
            // 
            // fld_dgcACSegmentDocumentControls
            // 
            this.fld_dgcACSegmentDocumentControls.AllowDrop = true;
            this.fld_dgcACSegmentDocumentControls.BOSComment = null;
            this.fld_dgcACSegmentDocumentControls.BOSDataMember = null;
            this.fld_dgcACSegmentDocumentControls.BOSDataSource = "ACSegmentDocumentControls";
            this.fld_dgcACSegmentDocumentControls.BOSDescription = null;
            this.fld_dgcACSegmentDocumentControls.BOSError = null;
            this.fld_dgcACSegmentDocumentControls.BOSFieldGroup = null;
            this.fld_dgcACSegmentDocumentControls.BOSFieldRelation = null;
            this.fld_dgcACSegmentDocumentControls.BOSGridType = null;
            this.fld_dgcACSegmentDocumentControls.BOSPrivilege = null;
            this.fld_dgcACSegmentDocumentControls.BOSPropertyName = null;
            this.fld_dgcACSegmentDocumentControls.CommodityType = "";
            this.fld_dgcACSegmentDocumentControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACSegmentDocumentControls.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACSegmentDocumentControls.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcACSegmentDocumentControls.MainView = this.gridView2;
            this.fld_dgcACSegmentDocumentControls.Name = "fld_dgcACSegmentDocumentControls";
            this.fld_dgcACSegmentDocumentControls.PrintReport = false;
            this.fld_dgcACSegmentDocumentControls.Screen = null;
            this.fld_dgcACSegmentDocumentControls.Size = new System.Drawing.Size(888, 337);
            this.fld_dgcACSegmentDocumentControls.TabIndex = 28;
            this.fld_dgcACSegmentDocumentControls.Tag = "DC";
            this.fld_dgcACSegmentDocumentControls.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcACSegmentDocumentControls;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // fld_lblACSegmentBudgetControlPercent
            // 
            this.fld_lblACSegmentBudgetControlPercent.BOSComment = null;
            this.fld_lblACSegmentBudgetControlPercent.BOSDataMember = null;
            this.fld_lblACSegmentBudgetControlPercent.BOSDataSource = null;
            this.fld_lblACSegmentBudgetControlPercent.BOSDescription = null;
            this.fld_lblACSegmentBudgetControlPercent.BOSError = null;
            this.fld_lblACSegmentBudgetControlPercent.BOSFieldGroup = null;
            this.fld_lblACSegmentBudgetControlPercent.BOSFieldRelation = null;
            this.fld_lblACSegmentBudgetControlPercent.BOSPrivilege = null;
            this.fld_lblACSegmentBudgetControlPercent.BOSPropertyName = null;
            this.fld_lblACSegmentBudgetControlPercent.Location = new System.Drawing.Point(649, 42);
            this.fld_lblACSegmentBudgetControlPercent.Name = "fld_lblACSegmentBudgetControlPercent";
            this.fld_lblACSegmentBudgetControlPercent.Screen = null;
            this.fld_lblACSegmentBudgetControlPercent.Size = new System.Drawing.Size(19, 13);
            this.fld_lblACSegmentBudgetControlPercent.TabIndex = 5;
            this.fld_lblACSegmentBudgetControlPercent.Text = "(%)";
            this.fld_lblACSegmentBudgetControlPercent.Visible = false;
            // 
            // fld_txtACSegmentBudgetControlPercent
            // 
            this.fld_txtACSegmentBudgetControlPercent.BOSComment = "";
            this.fld_txtACSegmentBudgetControlPercent.BOSDataMember = "ACSegmentBudgetControlPercent";
            this.fld_txtACSegmentBudgetControlPercent.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentBudgetControlPercent.BOSDescription = null;
            this.fld_txtACSegmentBudgetControlPercent.BOSError = null;
            this.fld_txtACSegmentBudgetControlPercent.BOSFieldGroup = "";
            this.fld_txtACSegmentBudgetControlPercent.BOSFieldRelation = "";
            this.fld_txtACSegmentBudgetControlPercent.BOSPrivilege = "";
            this.fld_txtACSegmentBudgetControlPercent.BOSPropertyName = "Text";
            this.fld_txtACSegmentBudgetControlPercent.EditValue = "";
            this.fld_txtACSegmentBudgetControlPercent.Location = new System.Drawing.Point(591, 35);
            this.fld_txtACSegmentBudgetControlPercent.Name = "fld_txtACSegmentBudgetControlPercent";
            this.fld_txtACSegmentBudgetControlPercent.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentBudgetControlPercent.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentBudgetControlPercent.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentBudgetControlPercent.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentBudgetControlPercent.Properties.DisplayFormat.FormatString = "n2";
            this.fld_txtACSegmentBudgetControlPercent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtACSegmentBudgetControlPercent.Properties.EditFormat.FormatString = "n2";
            this.fld_txtACSegmentBudgetControlPercent.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fld_txtACSegmentBudgetControlPercent.Properties.Mask.EditMask = "n2";
            this.fld_txtACSegmentBudgetControlPercent.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtACSegmentBudgetControlPercent.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentBudgetControlPercent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fld_txtACSegmentBudgetControlPercent.Screen = null;
            this.fld_txtACSegmentBudgetControlPercent.Size = new System.Drawing.Size(52, 20);
            this.fld_txtACSegmentBudgetControlPercent.TabIndex = 4;
            this.fld_txtACSegmentBudgetControlPercent.Tag = "DC";
            this.fld_txtACSegmentBudgetControlPercent.Visible = false;
            // 
            // fld_lkeACCostType
            // 
            this.fld_lkeACCostType.BOSAllowAddNew = false;
            this.fld_lkeACCostType.BOSAllowDummy = true;
            this.fld_lkeACCostType.BOSComment = null;
            this.fld_lkeACCostType.BOSDataMember = "ACCostType";
            this.fld_lkeACCostType.BOSDataSource = "ACSegments";
            this.fld_lkeACCostType.BOSDescription = null;
            this.fld_lkeACCostType.BOSError = null;
            this.fld_lkeACCostType.BOSFieldGroup = null;
            this.fld_lkeACCostType.BOSFieldParent = null;
            this.fld_lkeACCostType.BOSFieldRelation = null;
            this.fld_lkeACCostType.BOSPrivilege = null;
            this.fld_lkeACCostType.BOSPropertyName = "EditValue";
            this.fld_lkeACCostType.BOSSelectType = "";
            this.fld_lkeACCostType.BOSSelectTypeValue = "";
            this.fld_lkeACCostType.CurrentDisplayText = null;
            this.fld_lkeACCostType.Location = new System.Drawing.Point(128, 61);
            this.fld_lkeACCostType.Name = "fld_lkeACCostType";
            this.fld_lkeACCostType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACCostType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACCostType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACCostType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACCostType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACCostType.Properties.ColumnName = null;
            this.fld_lkeACCostType.Properties.NullText = "";
            this.fld_lkeACCostType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACCostType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACCostType, true);
            this.fld_lkeACCostType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACCostType.TabIndex = 7;
            this.fld_lkeACCostType.Tag = "DC";
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
            this.bosLabel4.Location = new System.Drawing.Point(12, 64);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(52, 13);
            this.bosLabel4.TabIndex = 6;
            this.bosLabel4.Text = "Loại chi phí";
            // 
            // fld_txtACSegmentExcludeCreditAccountNo
            // 
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSComment = "";
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSDataMember = "ACSegmentExcludeCreditAccountNo";
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSDescription = null;
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSError = null;
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSFieldGroup = "";
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSFieldRelation = "";
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSPrivilege = "";
            this.fld_txtACSegmentExcludeCreditAccountNo.BOSPropertyName = "Text";
            this.fld_txtACSegmentExcludeCreditAccountNo.EditValue = "";
            this.fld_txtACSegmentExcludeCreditAccountNo.Location = new System.Drawing.Point(423, 113);
            this.fld_txtACSegmentExcludeCreditAccountNo.Name = "fld_txtACSegmentExcludeCreditAccountNo";
            this.fld_txtACSegmentExcludeCreditAccountNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentExcludeCreditAccountNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentExcludeCreditAccountNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentExcludeCreditAccountNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentExcludeCreditAccountNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentExcludeCreditAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSegmentExcludeCreditAccountNo.Screen = null;
            this.fld_txtACSegmentExcludeCreditAccountNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSegmentExcludeCreditAccountNo.TabIndex = 17;
            this.fld_txtACSegmentExcludeCreditAccountNo.Tag = "DC";
            // 
            // fld_txtACSegmentExcludeDebitAccountNo
            // 
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSComment = "";
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSDataMember = "ACSegmentExcludeDebitAccountNo";
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSDescription = null;
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSError = null;
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSFieldGroup = "";
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSFieldRelation = "";
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSPrivilege = "";
            this.fld_txtACSegmentExcludeDebitAccountNo.BOSPropertyName = "Text";
            this.fld_txtACSegmentExcludeDebitAccountNo.EditValue = "";
            this.fld_txtACSegmentExcludeDebitAccountNo.Location = new System.Drawing.Point(128, 113);
            this.fld_txtACSegmentExcludeDebitAccountNo.Name = "fld_txtACSegmentExcludeDebitAccountNo";
            this.fld_txtACSegmentExcludeDebitAccountNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentExcludeDebitAccountNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentExcludeDebitAccountNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentExcludeDebitAccountNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentExcludeDebitAccountNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentExcludeDebitAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSegmentExcludeDebitAccountNo.Screen = null;
            this.fld_txtACSegmentExcludeDebitAccountNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSegmentExcludeDebitAccountNo.TabIndex = 15;
            this.fld_txtACSegmentExcludeDebitAccountNo.Tag = "DC";
            // 
            // fld_txtACSegmentCreditAccountNo
            // 
            this.fld_txtACSegmentCreditAccountNo.BOSComment = "";
            this.fld_txtACSegmentCreditAccountNo.BOSDataMember = "ACSegmentCreditAccountNo";
            this.fld_txtACSegmentCreditAccountNo.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentCreditAccountNo.BOSDescription = null;
            this.fld_txtACSegmentCreditAccountNo.BOSError = null;
            this.fld_txtACSegmentCreditAccountNo.BOSFieldGroup = "";
            this.fld_txtACSegmentCreditAccountNo.BOSFieldRelation = "";
            this.fld_txtACSegmentCreditAccountNo.BOSPrivilege = "";
            this.fld_txtACSegmentCreditAccountNo.BOSPropertyName = "Text";
            this.fld_txtACSegmentCreditAccountNo.EditValue = "";
            this.fld_txtACSegmentCreditAccountNo.Location = new System.Drawing.Point(423, 87);
            this.fld_txtACSegmentCreditAccountNo.Name = "fld_txtACSegmentCreditAccountNo";
            this.fld_txtACSegmentCreditAccountNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentCreditAccountNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentCreditAccountNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentCreditAccountNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentCreditAccountNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentCreditAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSegmentCreditAccountNo.Screen = null;
            this.fld_txtACSegmentCreditAccountNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSegmentCreditAccountNo.TabIndex = 13;
            this.fld_txtACSegmentCreditAccountNo.Tag = "DC";
            // 
            // fld_txtACSegmentDebitAccountNo
            // 
            this.fld_txtACSegmentDebitAccountNo.BOSComment = "";
            this.fld_txtACSegmentDebitAccountNo.BOSDataMember = "ACSegmentDebitAccountNo";
            this.fld_txtACSegmentDebitAccountNo.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentDebitAccountNo.BOSDescription = null;
            this.fld_txtACSegmentDebitAccountNo.BOSError = null;
            this.fld_txtACSegmentDebitAccountNo.BOSFieldGroup = "";
            this.fld_txtACSegmentDebitAccountNo.BOSFieldRelation = "";
            this.fld_txtACSegmentDebitAccountNo.BOSPrivilege = "";
            this.fld_txtACSegmentDebitAccountNo.BOSPropertyName = "Text";
            this.fld_txtACSegmentDebitAccountNo.EditValue = "";
            this.fld_txtACSegmentDebitAccountNo.Location = new System.Drawing.Point(128, 87);
            this.fld_txtACSegmentDebitAccountNo.Name = "fld_txtACSegmentDebitAccountNo";
            this.fld_txtACSegmentDebitAccountNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentDebitAccountNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentDebitAccountNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentDebitAccountNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentDebitAccountNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentDebitAccountNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSegmentDebitAccountNo.Screen = null;
            this.fld_txtACSegmentDebitAccountNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSegmentDebitAccountNo.TabIndex = 11;
            this.fld_txtACSegmentDebitAccountNo.Tag = "DC";
            // 
            // DMAC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(910, 595);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMAC100.IconOptions.Icon")));
            this.Name = "DMAC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACSegmentDesc.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACSegmentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACSegmentObjectControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACSegmentDocumentControls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentBudgetControlPercent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACCostType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentExcludeCreditAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentExcludeDebitAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentCreditAccountNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentDebitAccountNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeACCostType;
        private BOSComponent.BOSLabel fld_lblACSegmentBudgetControlPercent;
        private BOSComponent.BOSTextBox fld_txtACSegmentBudgetControlPercent;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ACSegmentObjectControlsGridControl fld_dgcACSegmentObjectControls;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private ACSegmentDocumentControlsGridControl fld_dgcACSegmentDocumentControls;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeACSegmentType;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSTextBox fld_txtACSegmentCreditAccountNo;
        private BOSComponent.BOSTextBox fld_txtACSegmentDebitAccountNo;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSTextBox fld_txtACSegmentExcludeCreditAccountNo;
        private BOSComponent.BOSTextBox fld_txtACSegmentExcludeDebitAccountNo;
    }
}
