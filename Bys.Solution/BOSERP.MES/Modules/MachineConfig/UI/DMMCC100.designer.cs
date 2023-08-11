using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.MachineConfig.UI
{
    /// <summary>
    /// Summary description for DMMCC100
    /// </summary>
    partial class DMMCC100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMMCC100));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.fld_tabCompany = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabMachineList = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnSemiSave = new BOSComponent.BOSButton(this.components);
            this.fld_spcMachine = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLine5 = new BOSComponent.BOSLine(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtUnitNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtUnitName = new BOSComponent.BOSTextBox(this.components);
            this.fld_btnFind = new BOSComponent.BOSButton(this.components);
            this.fld_dgcMMMachineUnits = new BOSERP.Modules.MachineConfig.MachinesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcICProductSemis = new BOSERP.Modules.MachineConfig.SemisGridControl();
            this.bosLine6 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcMMMachineUnitOperations = new BOSERP.Modules.MachineConfig.OperationsGridControl();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).BeginInit();
            this.fld_tabCompany.SuspendLayout();
            this.fld_tabMachineList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_spcMachine)).BeginInit();
            this.fld_spcMachine.SuspendLayout();
            this.bosLine5.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUnitNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMachineUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductSemis)).BeginInit();
            this.bosLine6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMachineUnitOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.fld_tabCompany);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1096, 710);
            this.xtraScrollableControl1.TabIndex = 6;
            // 
            // fld_tabCompany
            // 
            this.fld_tabCompany.BOSComment = null;
            this.fld_tabCompany.BOSDataMember = null;
            this.fld_tabCompany.BOSDataSource = null;
            this.fld_tabCompany.BOSDescription = null;
            this.fld_tabCompany.BOSError = null;
            this.fld_tabCompany.BOSFieldGroup = null;
            this.fld_tabCompany.BOSFieldRelation = null;
            this.fld_tabCompany.BOSPrivilege = null;
            this.fld_tabCompany.BOSPropertyName = null;
            this.fld_tabCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tabCompany.Location = new System.Drawing.Point(0, 0);
            this.fld_tabCompany.Name = "fld_tabCompany";
            this.fld_tabCompany.Screen = null;
            this.fld_tabCompany.SelectedTabPage = this.fld_tabMachineList;
            this.ScreenHelper.SetShowHelp(this.fld_tabCompany, true);
            this.fld_tabCompany.Size = new System.Drawing.Size(1096, 710);
            this.fld_tabCompany.TabIndex = 63;
            this.fld_tabCompany.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabMachineList});
            // 
            // fld_tabMachineList
            // 
            this.fld_tabMachineList.Controls.Add(this.fld_btnSemiSave);
            this.fld_tabMachineList.Controls.Add(this.fld_spcMachine);
            this.fld_tabMachineList.Name = "fld_tabMachineList";
            this.fld_tabMachineList.Size = new System.Drawing.Size(1090, 682);
            this.fld_tabMachineList.Text = "Danh sách máy";
            // 
            // fld_btnSemiSave
            // 
            this.fld_btnSemiSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnSemiSave.BOSComment = null;
            this.fld_btnSemiSave.BOSDataMember = null;
            this.fld_btnSemiSave.BOSDataSource = null;
            this.fld_btnSemiSave.BOSDescription = null;
            this.fld_btnSemiSave.BOSError = null;
            this.fld_btnSemiSave.BOSFieldGroup = null;
            this.fld_btnSemiSave.BOSFieldRelation = null;
            this.fld_btnSemiSave.BOSPrivilege = null;
            this.fld_btnSemiSave.BOSPropertyName = null;
            this.fld_btnSemiSave.Location = new System.Drawing.Point(1013, 653);
            this.fld_btnSemiSave.Name = "fld_btnSemiSave";
            this.fld_btnSemiSave.Screen = null;
            this.fld_btnSemiSave.Size = new System.Drawing.Size(70, 26);
            this.fld_btnSemiSave.TabIndex = 410;
            this.fld_btnSemiSave.Text = "Lưu";
            this.fld_btnSemiSave.Click += new System.EventHandler(this.fld_btnSemiSave_Click);
            // 
            // fld_spcMachine
            // 
            this.fld_spcMachine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_spcMachine.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.fld_spcMachine.Location = new System.Drawing.Point(3, 0);
            this.fld_spcMachine.Name = "fld_spcMachine";
            this.fld_spcMachine.Panel1.Controls.Add(this.bosLine5);
            this.fld_spcMachine.Panel1.Text = "Panel1";
            this.fld_spcMachine.Panel2.Controls.Add(this.bosLine1);
            this.fld_spcMachine.Panel2.Controls.Add(this.bosLine6);
            this.fld_spcMachine.Panel2.Text = "Panel2";
            this.fld_spcMachine.Size = new System.Drawing.Size(1089, 649);
            this.fld_spcMachine.SplitterPosition = 509;
            this.fld_spcMachine.TabIndex = 409;
            this.fld_spcMachine.Text = "splitContainerControl2";
            // 
            // bosLine5
            // 
            this.bosLine5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine5.BOSComment = null;
            this.bosLine5.BOSDataMember = null;
            this.bosLine5.BOSDataSource = null;
            this.bosLine5.BOSDescription = null;
            this.bosLine5.BOSError = null;
            this.bosLine5.BOSFieldGroup = null;
            this.bosLine5.BOSFieldRelation = null;
            this.bosLine5.BOSPrivilege = null;
            this.bosLine5.BOSPropertyName = null;
            this.bosLine5.Controls.Add(this.bosLine2);
            this.bosLine5.Controls.Add(this.fld_dgcMMMachineUnits);
            this.bosLine5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine5.Location = new System.Drawing.Point(3, 1);
            this.bosLine5.Name = "bosLine5";
            this.bosLine5.Screen = null;
            this.bosLine5.Size = new System.Drawing.Size(505, 646);
            this.bosLine5.TabIndex = 407;
            this.bosLine5.TabStop = false;
            this.bosLine5.Text = "Danh sách máy móc";
            // 
            // bosLine2
            // 
            this.bosLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.bosLabel2);
            this.bosLine2.Controls.Add(this.fld_txtUnitNo);
            this.bosLine2.Controls.Add(this.bosLabel1);
            this.bosLine2.Controls.Add(this.fld_txtUnitName);
            this.bosLine2.Controls.Add(this.fld_btnFind);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(3, 20);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(496, 74);
            this.bosLine2.TabIndex = 122;
            this.bosLine2.TabStop = false;
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
            this.bosLabel2.Location = new System.Drawing.Point(7, 23);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(27, 13);
            this.bosLabel2.TabIndex = 17;
            this.bosLabel2.Tag = "";
            this.bosLabel2.Text = "Mã tổ";
            // 
            // fld_txtUnitNo
            // 
            this.fld_txtUnitNo.BOSComment = "";
            this.fld_txtUnitNo.BOSDataMember = "";
            this.fld_txtUnitNo.BOSDataSource = "";
            this.fld_txtUnitNo.BOSDescription = null;
            this.fld_txtUnitNo.BOSError = null;
            this.fld_txtUnitNo.BOSFieldGroup = "";
            this.fld_txtUnitNo.BOSFieldRelation = "";
            this.fld_txtUnitNo.BOSPrivilege = "";
            this.fld_txtUnitNo.BOSPropertyName = "Text";
            this.fld_txtUnitNo.EditValue = "";
            this.fld_txtUnitNo.Location = new System.Drawing.Point(54, 20);
            this.fld_txtUnitNo.Name = "fld_txtUnitNo";
            this.fld_txtUnitNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtUnitNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtUnitNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtUnitNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtUnitNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtUnitNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtUnitNo.Screen = null;
            this.fld_txtUnitNo.Size = new System.Drawing.Size(131, 20);
            this.fld_txtUnitNo.TabIndex = 18;
            this.fld_txtUnitNo.Tag = "DC";
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
            this.bosLabel1.Location = new System.Drawing.Point(7, 49);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(31, 13);
            this.bosLabel1.TabIndex = 20;
            this.bosLabel1.Tag = "";
            this.bosLabel1.Text = "Tên tổ";
            // 
            // fld_txtUnitName
            // 
            this.fld_txtUnitName.BOSComment = "";
            this.fld_txtUnitName.BOSDataMember = "";
            this.fld_txtUnitName.BOSDataSource = "";
            this.fld_txtUnitName.BOSDescription = null;
            this.fld_txtUnitName.BOSError = null;
            this.fld_txtUnitName.BOSFieldGroup = "";
            this.fld_txtUnitName.BOSFieldRelation = "";
            this.fld_txtUnitName.BOSPrivilege = "";
            this.fld_txtUnitName.BOSPropertyName = "Text";
            this.fld_txtUnitName.EditValue = "";
            this.fld_txtUnitName.Location = new System.Drawing.Point(54, 46);
            this.fld_txtUnitName.Name = "fld_txtUnitName";
            this.fld_txtUnitName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtUnitName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtUnitName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtUnitName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtUnitName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtUnitName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtUnitName.Screen = null;
            this.fld_txtUnitName.Size = new System.Drawing.Size(131, 20);
            this.fld_txtUnitName.TabIndex = 19;
            this.fld_txtUnitName.Tag = "DC";
            // 
            // fld_btnFind
            // 
            this.fld_btnFind.BOSComment = null;
            this.fld_btnFind.BOSDataMember = null;
            this.fld_btnFind.BOSDataSource = null;
            this.fld_btnFind.BOSDescription = null;
            this.fld_btnFind.BOSError = null;
            this.fld_btnFind.BOSFieldGroup = null;
            this.fld_btnFind.BOSFieldRelation = null;
            this.fld_btnFind.BOSPrivilege = null;
            this.fld_btnFind.BOSPropertyName = null;
            this.fld_btnFind.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnFind.ImageOptions.Image")));
            this.fld_btnFind.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.fld_btnFind.Location = new System.Drawing.Point(191, 42);
            this.fld_btnFind.Name = "fld_btnFind";
            this.fld_btnFind.Screen = null;
            this.fld_btnFind.Size = new System.Drawing.Size(70, 26);
            this.fld_btnFind.TabIndex = 16;
            this.fld_btnFind.Click += new System.EventHandler(this.fld_btnFind_Click);
            // 
            // fld_dgcMMMachineUnits
            // 
            this.fld_dgcMMMachineUnits.AllowDrop = true;
            this.fld_dgcMMMachineUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMachineUnits.BOSComment = "";
            this.fld_dgcMMMachineUnits.BOSDataMember = null;
            this.fld_dgcMMMachineUnits.BOSDataSource = "MMMachineUnits";
            this.fld_dgcMMMachineUnits.BOSDescription = null;
            this.fld_dgcMMMachineUnits.BOSError = "";
            this.fld_dgcMMMachineUnits.BOSFieldGroup = "";
            this.fld_dgcMMMachineUnits.BOSFieldRelation = null;
            this.fld_dgcMMMachineUnits.BOSGridType = null;
            this.fld_dgcMMMachineUnits.BOSPrivilege = "";
            this.fld_dgcMMMachineUnits.BOSPropertyName = null;
            this.fld_dgcMMMachineUnits.CommodityType = "";
            this.fld_dgcMMMachineUnits.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMMachineUnits.Location = new System.Drawing.Point(6, 100);
            this.fld_dgcMMMachineUnits.MainView = this.gridView2;
            this.fld_dgcMMMachineUnits.Name = "fld_dgcMMMachineUnits";
            this.fld_dgcMMMachineUnits.PrintReport = false;
            this.fld_dgcMMMachineUnits.Screen = null;
            this.fld_dgcMMMachineUnits.Size = new System.Drawing.Size(493, 540);
            this.fld_dgcMMMachineUnits.TabIndex = 62;
            this.fld_dgcMMMachineUnits.Tag = "DC";
            this.fld_dgcMMMachineUnits.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcMMMachineUnits;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_dgcICProductSemis);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(1, 202);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(570, 445);
            this.bosLine1.TabIndex = 406;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Năng suất theo sản phẩm";
            // 
            // fld_dgcICProductSemis
            // 
            this.fld_dgcICProductSemis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICProductSemis.BOSComment = null;
            this.fld_dgcICProductSemis.BOSDataMember = null;
            this.fld_dgcICProductSemis.BOSDataSource = "ICProductSemis";
            this.fld_dgcICProductSemis.BOSDescription = null;
            this.fld_dgcICProductSemis.BOSError = null;
            this.fld_dgcICProductSemis.BOSFieldGroup = null;
            this.fld_dgcICProductSemis.BOSFieldRelation = null;
            this.fld_dgcICProductSemis.BOSGridType = null;
            this.fld_dgcICProductSemis.BOSPrivilege = null;
            this.fld_dgcICProductSemis.BOSPropertyName = null;
            this.fld_dgcICProductSemis.CommodityType = "";
            this.fld_dgcICProductSemis.Location = new System.Drawing.Point(3, 20);
            this.fld_dgcICProductSemis.MenuManager = this.screenToolbar;
            this.fld_dgcICProductSemis.Name = "fld_dgcICProductSemis";
            this.fld_dgcICProductSemis.PrintReport = false;
            this.fld_dgcICProductSemis.Screen = null;
            this.fld_dgcICProductSemis.Size = new System.Drawing.Size(566, 419);
            this.fld_dgcICProductSemis.TabIndex = 2;
            // 
            // bosLine6
            // 
            this.bosLine6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine6.BOSComment = null;
            this.bosLine6.BOSDataMember = null;
            this.bosLine6.BOSDataSource = null;
            this.bosLine6.BOSDescription = null;
            this.bosLine6.BOSError = null;
            this.bosLine6.BOSFieldGroup = null;
            this.bosLine6.BOSFieldRelation = null;
            this.bosLine6.BOSPrivilege = null;
            this.bosLine6.BOSPropertyName = null;
            this.bosLine6.Controls.Add(this.fld_dgcMMMachineUnitOperations);
            this.bosLine6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine6.Location = new System.Drawing.Point(0, 1);
            this.bosLine6.Name = "bosLine6";
            this.bosLine6.Screen = null;
            this.bosLine6.Size = new System.Drawing.Size(570, 195);
            this.bosLine6.TabIndex = 405;
            this.bosLine6.TabStop = false;
            this.bosLine6.Text = "Danh sách công đoạn";
            // 
            // fld_dgcMMMachineUnitOperations
            // 
            this.fld_dgcMMMachineUnitOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMachineUnitOperations.BOSComment = null;
            this.fld_dgcMMMachineUnitOperations.BOSDataMember = null;
            this.fld_dgcMMMachineUnitOperations.BOSDataSource = "MMMachineUnitOperations";
            this.fld_dgcMMMachineUnitOperations.BOSDescription = null;
            this.fld_dgcMMMachineUnitOperations.BOSError = null;
            this.fld_dgcMMMachineUnitOperations.BOSFieldGroup = null;
            this.fld_dgcMMMachineUnitOperations.BOSFieldRelation = null;
            this.fld_dgcMMMachineUnitOperations.BOSGridType = null;
            this.fld_dgcMMMachineUnitOperations.BOSPrivilege = null;
            this.fld_dgcMMMachineUnitOperations.BOSPropertyName = null;
            this.fld_dgcMMMachineUnitOperations.CommodityType = "";
            this.fld_dgcMMMachineUnitOperations.Location = new System.Drawing.Point(3, 20);
            this.fld_dgcMMMachineUnitOperations.MenuManager = this.screenToolbar;
            this.fld_dgcMMMachineUnitOperations.Name = "fld_dgcMMMachineUnitOperations";
            this.fld_dgcMMMachineUnitOperations.PrintReport = false;
            this.fld_dgcMMMachineUnitOperations.Screen = null;
            this.fld_dgcMMMachineUnitOperations.Size = new System.Drawing.Size(566, 169);
            this.fld_dgcMMMachineUnitOperations.TabIndex = 2;
            // 
            // DMMCC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1096, 710);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "DMMCC100";
            this.Text = "Cấu hình máy móc - BTP/TP - công đoạn - năng suất";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tabCompany)).EndInit();
            this.fld_tabCompany.ResumeLayout(false);
            this.fld_tabMachineList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_spcMachine)).EndInit();
            this.fld_spcMachine.ResumeLayout(false);
            this.bosLine5.ResumeLayout(false);
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUnitNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMachineUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICProductSemis)).EndInit();
            this.bosLine6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMachineUnitOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private BOSComponent.BOSTabControl fld_tabCompany;
        private DevExpress.XtraTab.XtraTabPage fld_tabMachineList;
        private MachinesGridControl fld_dgcMMMachineUnits;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SplitContainerControl fld_spcMachine;
        private BOSComponent.BOSLine bosLine5;
        private BOSComponent.BOSLine bosLine1;
        private SemisGridControl fld_dgcICProductSemis;
        private BOSComponent.BOSLine bosLine6;
        private OperationsGridControl fld_dgcMMMachineUnitOperations;
        private BOSComponent.BOSButton fld_btnSemiSave;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSButton fld_btnFind;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtUnitNo;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtUnitName;
    }
}
