using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EndingAllocationDeclaration.UI
{
	/// <summary>
	/// Summary description for DMEAD100
	/// </summary>
	partial class DMEAD100
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
            this.bosGroupControl3 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcACEndingAllocationDeclarationItemReceives = new BOSERP.Modules.EndingAllocationDeclaration.ACEndingAllocationDeclarationItemReceivesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcACEndingAllocationDeclarationItems = new BOSERP.Modules.EndingAllocationDeclaration.ACEndingAllocationDeclarationItemsGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_txtACEndingAllocationDeclarationNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACEndingAllocationDeclarationMethod = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_medACEndingAllocationDeclarationDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACEndingAllocationDeclarationType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACEndingAllocationDeclarationName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACEndingAllocationDeclarationOrderNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).BeginInit();
            this.bosGroupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocationDeclarationItemReceives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).BeginInit();
            this.bosGroupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocationDeclarationItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationDeclarationNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEndingAllocationDeclarationMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACEndingAllocationDeclarationDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEndingAllocationDeclarationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationDeclarationName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationDeclarationOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.bosPanel1.Controls.Add(this.splitContainerControl1);
            this.bosPanel1.Controls.Add(this.bosGroupControl1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 673);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosGroupControl3
            // 
            this.bosGroupControl3.BOSComment = null;
            this.bosGroupControl3.BOSDataMember = null;
            this.bosGroupControl3.BOSDataSource = null;
            this.bosGroupControl3.BOSDescription = null;
            this.bosGroupControl3.BOSError = null;
            this.bosGroupControl3.BOSFieldGroup = null;
            this.bosGroupControl3.BOSFieldRelation = null;
            this.bosGroupControl3.BOSPrivilege = null;
            this.bosGroupControl3.BOSPropertyName = null;
            this.bosGroupControl3.Controls.Add(this.fld_dgcACEndingAllocationDeclarationItemReceives);
            this.bosGroupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl3.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl3.Name = "bosGroupControl3";
            this.bosGroupControl3.Screen = null;
            this.bosGroupControl3.Size = new System.Drawing.Size(856, 279);
            this.bosGroupControl3.TabIndex = 589;
            this.bosGroupControl3.Text = "Danh sách nhận phân bổ";
            // 
            // fld_dgcACEndingAllocationDeclarationItemReceives
            // 
            this.fld_dgcACEndingAllocationDeclarationItemReceives.AllowDrop = true;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSComment = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSDataMember = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSDataSource = "ACEndingAllocationDeclarationItemReceives";
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSDescription = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSError = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSFieldGroup = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSFieldRelation = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSGridType = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSPrivilege = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.BOSPropertyName = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEndingAllocationDeclarationItemReceives.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcACEndingAllocationDeclarationItemReceives.MainView = this.gridView1;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.Name = "fld_dgcACEndingAllocationDeclarationItemReceives";
            this.fld_dgcACEndingAllocationDeclarationItemReceives.PrintReport = false;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.Screen = null;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.Size = new System.Drawing.Size(852, 255);
            this.fld_dgcACEndingAllocationDeclarationItemReceives.TabIndex = 0;
            this.fld_dgcACEndingAllocationDeclarationItemReceives.Tag = "DC";
            this.fld_dgcACEndingAllocationDeclarationItemReceives.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcACEndingAllocationDeclarationItemReceives;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // bosGroupControl2
            // 
            this.bosGroupControl2.BOSComment = null;
            this.bosGroupControl2.BOSDataMember = null;
            this.bosGroupControl2.BOSDataSource = null;
            this.bosGroupControl2.BOSDescription = null;
            this.bosGroupControl2.BOSError = null;
            this.bosGroupControl2.BOSFieldGroup = null;
            this.bosGroupControl2.BOSFieldRelation = null;
            this.bosGroupControl2.BOSPrivilege = null;
            this.bosGroupControl2.BOSPropertyName = null;
            this.bosGroupControl2.Controls.Add(this.fld_dgcACEndingAllocationDeclarationItems);
            this.bosGroupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl2.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl2.Name = "bosGroupControl2";
            this.bosGroupControl2.Screen = null;
            this.bosGroupControl2.Size = new System.Drawing.Size(856, 199);
            this.bosGroupControl2.TabIndex = 588;
            this.bosGroupControl2.Text = "Danh sách phân bổ";
            // 
            // fld_dgcACEndingAllocationDeclarationItems
            // 
            this.fld_dgcACEndingAllocationDeclarationItems.AllowDrop = true;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSComment = null;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSDataMember = null;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSDataSource = "ACEndingAllocationDeclarationItems";
            this.fld_dgcACEndingAllocationDeclarationItems.BOSDescription = null;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSError = null;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSFieldGroup = null;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSFieldRelation = null;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSGridType = null;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSPrivilege = null;
            this.fld_dgcACEndingAllocationDeclarationItems.BOSPropertyName = null;
            this.fld_dgcACEndingAllocationDeclarationItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACEndingAllocationDeclarationItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEndingAllocationDeclarationItems.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcACEndingAllocationDeclarationItems.MainView = this.gridView2;
            this.fld_dgcACEndingAllocationDeclarationItems.Name = "fld_dgcACEndingAllocationDeclarationItems";
            this.fld_dgcACEndingAllocationDeclarationItems.PrintReport = false;
            this.fld_dgcACEndingAllocationDeclarationItems.Screen = null;
            this.fld_dgcACEndingAllocationDeclarationItems.Size = new System.Drawing.Size(852, 175);
            this.fld_dgcACEndingAllocationDeclarationItems.TabIndex = 0;
            this.fld_dgcACEndingAllocationDeclarationItems.Tag = "DC";
            this.fld_dgcACEndingAllocationDeclarationItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcACEndingAllocationDeclarationItems;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
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
            this.bosGroupControl1.Controls.Add(this.fld_txtACEndingAllocationDeclarationNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel4);
            this.bosGroupControl1.Controls.Add(this.bosLabel1);
            this.bosGroupControl1.Controls.Add(this.fld_lkeACEndingAllocationDeclarationMethod);
            this.bosGroupControl1.Controls.Add(this.fld_medACEndingAllocationDeclarationDesc);
            this.bosGroupControl1.Controls.Add(this.bosLabel17);
            this.bosGroupControl1.Controls.Add(this.bosLabel3);
            this.bosGroupControl1.Controls.Add(this.fld_lkeACEndingAllocationDeclarationType);
            this.bosGroupControl1.Controls.Add(this.bosLabel15);
            this.bosGroupControl1.Controls.Add(this.fld_txtACEndingAllocationDeclarationName);
            this.bosGroupControl1.Controls.Add(this.fld_txtACEndingAllocationDeclarationOrderNo);
            this.bosGroupControl1.Controls.Add(this.bosLabel2);
            this.bosGroupControl1.Location = new System.Drawing.Point(3, 3);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(856, 181);
            this.bosGroupControl1.TabIndex = 587;
            this.bosGroupControl1.Text = "Thông tin chung";
            // 
            // fld_txtACEndingAllocationDeclarationNo
            // 
            this.fld_txtACEndingAllocationDeclarationNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo.BOSDataMember = "ACEndingAllocationDeclarationNo";
            this.fld_txtACEndingAllocationDeclarationNo.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_txtACEndingAllocationDeclarationNo.BOSDescription = null;
            this.fld_txtACEndingAllocationDeclarationNo.BOSError = null;
            this.fld_txtACEndingAllocationDeclarationNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo.BOSPropertyName = "Text";
            this.fld_txtACEndingAllocationDeclarationNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationNo.Location = new System.Drawing.Point(106, 35);
            this.fld_txtACEndingAllocationDeclarationNo.Name = "fld_txtACEndingAllocationDeclarationNo";
            this.fld_txtACEndingAllocationDeclarationNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACEndingAllocationDeclarationNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACEndingAllocationDeclarationNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACEndingAllocationDeclarationNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACEndingAllocationDeclarationNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACEndingAllocationDeclarationNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACEndingAllocationDeclarationNo.Screen = null;
            this.fld_txtACEndingAllocationDeclarationNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACEndingAllocationDeclarationNo.TabIndex = 0;
            this.fld_txtACEndingAllocationDeclarationNo.Tag = "DC";
            // 
            // bosLabel4
            // 
            this.bosLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel4.Appearance.Options.UseBackColor = true;
            this.bosLabel4.Appearance.Options.UseForeColor = true;
            this.bosLabel4.BOSComment = null;
            this.bosLabel4.BOSDataMember = null;
            this.bosLabel4.BOSDataSource = null;
            this.bosLabel4.BOSDescription = null;
            this.bosLabel4.BOSError = null;
            this.bosLabel4.BOSFieldGroup = null;
            this.bosLabel4.BOSFieldRelation = null;
            this.bosLabel4.BOSPrivilege = null;
            this.bosLabel4.BOSPropertyName = null;
            this.bosLabel4.Location = new System.Drawing.Point(291, 90);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel4, true);
            this.bosLabel4.Size = new System.Drawing.Size(45, 13);
            this.bosLabel4.TabIndex = 586;
            this.bosLabel4.Text = "Tiêu thức";
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
            this.bosLabel1.Location = new System.Drawing.Point(22, 38);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(56, 13);
            this.bosLabel1.TabIndex = 11;
            this.bosLabel1.Text = "Mã phân bổ";
            // 
            // fld_lkeACEndingAllocationDeclarationMethod
            // 
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSAllowAddNew = false;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSAllowDummy = false;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSComment = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSDataMember = "ACEndingAllocationDeclarationMethod";
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSDescription = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSError = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSFieldGroup = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSFieldParent = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSFieldRelation = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSPrivilege = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSPropertyName = "EditValue";
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationMethod.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationMethod.CurrentDisplayText = null;
            this.fld_lkeACEndingAllocationDeclarationMethod.Location = new System.Drawing.Point(375, 87);
            this.fld_lkeACEndingAllocationDeclarationMethod.Name = "fld_lkeACEndingAllocationDeclarationMethod";
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationMethod.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACEndingAllocationDeclarationMethod.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACEndingAllocationDeclarationMethod, true);
            this.fld_lkeACEndingAllocationDeclarationMethod.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACEndingAllocationDeclarationMethod.TabIndex = 585;
            this.fld_lkeACEndingAllocationDeclarationMethod.Tag = "DC";
            // 
            // fld_medACEndingAllocationDeclarationDesc
            // 
            this.fld_medACEndingAllocationDeclarationDesc.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACEndingAllocationDeclarationDesc.BOSDataMember = "ACEndingAllocationDeclarationDesc";
            this.fld_medACEndingAllocationDeclarationDesc.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_medACEndingAllocationDeclarationDesc.BOSDescription = null;
            this.fld_medACEndingAllocationDeclarationDesc.BOSError = null;
            this.fld_medACEndingAllocationDeclarationDesc.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACEndingAllocationDeclarationDesc.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACEndingAllocationDeclarationDesc.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACEndingAllocationDeclarationDesc.BOSPropertyName = "EditValue";
            this.fld_medACEndingAllocationDeclarationDesc.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_medACEndingAllocationDeclarationDesc.Location = new System.Drawing.Point(106, 113);
            this.fld_medACEndingAllocationDeclarationDesc.Name = "fld_medACEndingAllocationDeclarationDesc";
            this.fld_medACEndingAllocationDeclarationDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medACEndingAllocationDeclarationDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medACEndingAllocationDeclarationDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medACEndingAllocationDeclarationDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medACEndingAllocationDeclarationDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medACEndingAllocationDeclarationDesc, true);
            this.fld_medACEndingAllocationDeclarationDesc.Size = new System.Drawing.Size(419, 52);
            this.fld_medACEndingAllocationDeclarationDesc.TabIndex = 5;
            this.fld_medACEndingAllocationDeclarationDesc.Tag = "DC";
            // 
            // bosLabel17
            // 
            this.bosLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel17.Appearance.Options.UseBackColor = true;
            this.bosLabel17.Appearance.Options.UseForeColor = true;
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(22, 90);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel17, true);
            this.bosLabel17.Size = new System.Drawing.Size(62, 13);
            this.bosLabel17.TabIndex = 584;
            this.bosLabel17.Text = "Kiểu phân bổ";
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
            this.bosLabel3.Location = new System.Drawing.Point(22, 116);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(40, 13);
            this.bosLabel3.TabIndex = 79;
            this.bosLabel3.Text = "Diễn giải";
            // 
            // fld_lkeACEndingAllocationDeclarationType
            // 
            this.fld_lkeACEndingAllocationDeclarationType.BOSAllowAddNew = false;
            this.fld_lkeACEndingAllocationDeclarationType.BOSAllowDummy = false;
            this.fld_lkeACEndingAllocationDeclarationType.BOSComment = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSDataMember = "ACEndingAllocationDeclarationType";
            this.fld_lkeACEndingAllocationDeclarationType.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_lkeACEndingAllocationDeclarationType.BOSDescription = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSError = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSFieldGroup = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSFieldParent = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSFieldRelation = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSPrivilege = null;
            this.fld_lkeACEndingAllocationDeclarationType.BOSPropertyName = "EditValue";
            this.fld_lkeACEndingAllocationDeclarationType.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationType.CurrentDisplayText = null;
            this.fld_lkeACEndingAllocationDeclarationType.Location = new System.Drawing.Point(106, 87);
            this.fld_lkeACEndingAllocationDeclarationType.Name = "fld_lkeACEndingAllocationDeclarationType";
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeACEndingAllocationDeclarationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACEndingAllocationDeclarationType.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeACEndingAllocationDeclarationType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeACEndingAllocationDeclarationType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeACEndingAllocationDeclarationType, true);
            this.fld_lkeACEndingAllocationDeclarationType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeACEndingAllocationDeclarationType.TabIndex = 583;
            this.fld_lkeACEndingAllocationDeclarationType.Tag = "DC";
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
            this.bosLabel15.Location = new System.Drawing.Point(22, 64);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(60, 13);
            this.bosLabel15.TabIndex = 579;
            this.bosLabel15.Text = "Tên phân bổ";
            // 
            // fld_txtACEndingAllocationDeclarationName
            // 
            this.fld_txtACEndingAllocationDeclarationName.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationName.BOSDataMember = "ACEndingAllocationDeclarationName";
            this.fld_txtACEndingAllocationDeclarationName.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_txtACEndingAllocationDeclarationName.BOSDescription = null;
            this.fld_txtACEndingAllocationDeclarationName.BOSError = null;
            this.fld_txtACEndingAllocationDeclarationName.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationName.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationName.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationName.BOSPropertyName = "Text";
            this.fld_txtACEndingAllocationDeclarationName.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationName.Location = new System.Drawing.Point(106, 61);
            this.fld_txtACEndingAllocationDeclarationName.Name = "fld_txtACEndingAllocationDeclarationName";
            this.fld_txtACEndingAllocationDeclarationName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACEndingAllocationDeclarationName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACEndingAllocationDeclarationName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACEndingAllocationDeclarationName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACEndingAllocationDeclarationName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACEndingAllocationDeclarationName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACEndingAllocationDeclarationName.Screen = null;
            this.fld_txtACEndingAllocationDeclarationName.Size = new System.Drawing.Size(419, 20);
            this.fld_txtACEndingAllocationDeclarationName.TabIndex = 582;
            this.fld_txtACEndingAllocationDeclarationName.Tag = "DC";
            // 
            // fld_txtACEndingAllocationDeclarationOrderNo
            // 
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSDataMember = "ACEndingAllocationDeclarationOrderNo";
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSDataSource = "ACEndingAllocationDeclarations";
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSDescription = null;
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSError = null;
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationOrderNo.BOSPropertyName = "Text";
            this.fld_txtACEndingAllocationDeclarationOrderNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACEndingAllocationDeclarationOrderNo.Location = new System.Drawing.Point(375, 35);
            this.fld_txtACEndingAllocationDeclarationOrderNo.Name = "fld_txtACEndingAllocationDeclarationOrderNo";
            this.fld_txtACEndingAllocationDeclarationOrderNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACEndingAllocationDeclarationOrderNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACEndingAllocationDeclarationOrderNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACEndingAllocationDeclarationOrderNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACEndingAllocationDeclarationOrderNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACEndingAllocationDeclarationOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACEndingAllocationDeclarationOrderNo.Screen = null;
            this.fld_txtACEndingAllocationDeclarationOrderNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACEndingAllocationDeclarationOrderNo.TabIndex = 580;
            this.fld_txtACEndingAllocationDeclarationOrderNo.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(291, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(18, 13);
            this.bosLabel2.TabIndex = 581;
            this.bosLabel2.Text = "STT";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 186);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl2);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.bosGroupControl3);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(856, 484);
            this.splitContainerControl1.SplitterPosition = 199;
            this.splitContainerControl1.TabIndex = 590;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // DMEAD100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 673);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMEAD100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl3)).EndInit();
            this.bosGroupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocationDeclarationItemReceives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl2)).EndInit();
            this.bosGroupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEndingAllocationDeclarationItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            this.bosGroupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationDeclarationNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEndingAllocationDeclarationMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medACEndingAllocationDeclarationDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACEndingAllocationDeclarationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationDeclarationName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACEndingAllocationDeclarationOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACEndingAllocationDeclarationNo;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medACEndingAllocationDeclarationDesc;
        private ACEndingAllocationDeclarationItemsGridControl fld_dgcACEndingAllocationDeclarationItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;

        private BOSComponent.BOSButton fld_btnAddProduct;
        private BOSComponent.BOSLabel bosLabel15;
        private BOSComponent.BOSTextBox fld_txtACEndingAllocationDeclarationName;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtACEndingAllocationDeclarationOrderNo;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeACEndingAllocationDeclarationMethod;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLookupEdit fld_lkeACEndingAllocationDeclarationType;
        private BOSComponent.BOSGroupControl bosGroupControl1;
        private BOSComponent.BOSGroupControl bosGroupControl3;
        private ACEndingAllocationDeclarationItemReceivesGridControl fld_dgcACEndingAllocationDeclarationItemReceives;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSGroupControl bosGroupControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
	}
}
