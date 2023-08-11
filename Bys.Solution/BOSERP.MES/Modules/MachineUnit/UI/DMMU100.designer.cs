using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.MachineUnit.UI
{
	/// <summary>
	/// Summary description for DMMU100
	/// </summary>
	partial class DMMU100
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMMU100));
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMMachineUnitName = new BOSComponent.BOSTextBox(this.components);
            this.fld_medMMMachineUnitDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_txtMMMachineUnitNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMMachineUnitOperations = new BOSERP.Modules.MachineUnit.MMMachineUnitOperationGridControl();
            this.fld_dgvGridControl1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.fld_tabMachine = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcMMMachineUnitItems = new BOSERP.Modules.MachineUnit.MMMachineItemsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_tabOperation = new DevExpress.XtraTab.XtraTabPage();
            this.fld_btnAdd = new BOSComponent.BOSButton(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMMachineUnitSetupTime = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMMachineUnitQty = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMMachineUnitCapacity = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_MMWorkShopID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMLineID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMMachineUnitDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMachineUnitOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.fld_tabMachine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMachineUnitItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.fld_tabOperation.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitSetupTime.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitCapacity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
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
            this.fld_lblLabel12.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel12.TabIndex = 0;
            this.fld_lblLabel12.Tag = "";
            this.fld_lblLabel12.Text = "Mã tổ";
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
            this.fld_lblLabel14.Location = new System.Drawing.Point(15, 35);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(31, 13);
            this.fld_lblLabel14.TabIndex = 6;
            this.fld_lblLabel14.Tag = "";
            this.fld_lblLabel14.Text = "Tên tổ";
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
            this.fld_lblLabel18.Location = new System.Drawing.Point(15, 64);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(41, 13);
            this.fld_lblLabel18.TabIndex = 12;
            this.fld_lblLabel18.Tag = "";
            this.fld_lblLabel18.Text = "Diễn giải";
            // 
            // fld_txtMMMachineUnitName
            // 
            this.fld_txtMMMachineUnitName.BOSComment = "";
            this.fld_txtMMMachineUnitName.BOSDataMember = "MMMachineUnitName";
            this.fld_txtMMMachineUnitName.BOSDataSource = "MMMachineUnits";
            this.fld_txtMMMachineUnitName.BOSDescription = null;
            this.fld_txtMMMachineUnitName.BOSError = "";
            this.fld_txtMMMachineUnitName.BOSFieldGroup = "";
            this.fld_txtMMMachineUnitName.BOSFieldRelation = "";
            this.fld_txtMMMachineUnitName.BOSPrivilege = "";
            this.fld_txtMMMachineUnitName.BOSPropertyName = "Text";
            this.fld_txtMMMachineUnitName.Location = new System.Drawing.Point(76, 32);
            this.fld_txtMMMachineUnitName.Name = "fld_txtMMMachineUnitName";
            this.fld_txtMMMachineUnitName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMMachineUnitName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMMachineUnitName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMMachineUnitName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMMachineUnitName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMMachineUnitName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMMachineUnitName.Screen = null;
            this.fld_txtMMMachineUnitName.Size = new System.Drawing.Size(179, 20);
            this.fld_txtMMMachineUnitName.TabIndex = 7;
            this.fld_txtMMMachineUnitName.Tag = "DC";
            // 
            // fld_medMMMachineUnitDesc
            // 
            this.fld_medMMMachineUnitDesc.BOSComment = "";
            this.fld_medMMMachineUnitDesc.BOSDataMember = "MMMachineUnitDesc";
            this.fld_medMMMachineUnitDesc.BOSDataSource = "MMMachineUnits";
            this.fld_medMMMachineUnitDesc.BOSDescription = null;
            this.fld_medMMMachineUnitDesc.BOSError = "";
            this.fld_medMMMachineUnitDesc.BOSFieldGroup = "";
            this.fld_medMMMachineUnitDesc.BOSFieldRelation = "";
            this.fld_medMMMachineUnitDesc.BOSPrivilege = "";
            this.fld_medMMMachineUnitDesc.BOSPropertyName = "Text";
            this.fld_medMMMachineUnitDesc.Location = new System.Drawing.Point(76, 58);
            this.fld_medMMMachineUnitDesc.Name = "fld_medMMMachineUnitDesc";
            this.fld_medMMMachineUnitDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medMMMachineUnitDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medMMMachineUnitDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medMMMachineUnitDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medMMMachineUnitDesc.Screen = null;
            this.fld_medMMMachineUnitDesc.Size = new System.Drawing.Size(436, 46);
            this.fld_medMMMachineUnitDesc.TabIndex = 13;
            this.fld_medMMMachineUnitDesc.Tag = "DC";
            // 
            // fld_txtMMMachineUnitNo
            // 
            this.fld_txtMMMachineUnitNo.BOSComment = "";
            this.fld_txtMMMachineUnitNo.BOSDataMember = "MMMachineUnitNo";
            this.fld_txtMMMachineUnitNo.BOSDataSource = "MMMachineUnits";
            this.fld_txtMMMachineUnitNo.BOSDescription = null;
            this.fld_txtMMMachineUnitNo.BOSError = "Mã kho không thể rỗng";
            this.fld_txtMMMachineUnitNo.BOSFieldGroup = "";
            this.fld_txtMMMachineUnitNo.BOSFieldRelation = "";
            this.fld_txtMMMachineUnitNo.BOSPrivilege = "";
            this.fld_txtMMMachineUnitNo.BOSPropertyName = "Text";
            this.fld_txtMMMachineUnitNo.Location = new System.Drawing.Point(76, 6);
            this.fld_txtMMMachineUnitNo.Name = "fld_txtMMMachineUnitNo";
            this.fld_txtMMMachineUnitNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMMachineUnitNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMMachineUnitNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMMachineUnitNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMMachineUnitNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMMachineUnitNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMMachineUnitNo.Screen = null;
            this.fld_txtMMMachineUnitNo.Size = new System.Drawing.Size(179, 20);
            this.fld_txtMMMachineUnitNo.TabIndex = 1;
            this.fld_txtMMMachineUnitNo.Tag = "DC";
            // 
            // fld_dgcMMMachineUnitOperations
            // 
            this.fld_dgcMMMachineUnitOperations.AllowDrop = true;
            this.fld_dgcMMMachineUnitOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMachineUnitOperations.BOSComment = "";
            this.fld_dgcMMMachineUnitOperations.BOSDataMember = "";
            this.fld_dgcMMMachineUnitOperations.BOSDataSource = "MMMachineUnitOperations";
            this.fld_dgcMMMachineUnitOperations.BOSDescription = null;
            this.fld_dgcMMMachineUnitOperations.BOSError = null;
            this.fld_dgcMMMachineUnitOperations.BOSFieldGroup = "";
            this.fld_dgcMMMachineUnitOperations.BOSFieldRelation = "";
            this.fld_dgcMMMachineUnitOperations.BOSGridType = null;
            this.fld_dgcMMMachineUnitOperations.BOSPrivilege = "";
            this.fld_dgcMMMachineUnitOperations.BOSPropertyName = "";
            this.fld_dgcMMMachineUnitOperations.CommodityType = "";
            this.fld_dgcMMMachineUnitOperations.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMMachineUnitOperations.Location = new System.Drawing.Point(0, 41);
            this.fld_dgcMMMachineUnitOperations.MainView = this.fld_dgvGridControl1;
            this.fld_dgcMMMachineUnitOperations.Name = "fld_dgcMMMachineUnitOperations";
            this.fld_dgcMMMachineUnitOperations.PrintReport = false;
            this.fld_dgcMMMachineUnitOperations.Screen = null;
            this.fld_dgcMMMachineUnitOperations.Size = new System.Drawing.Size(981, 509);
            this.fld_dgcMMMachineUnitOperations.TabIndex = 0;
            this.fld_dgcMMMachineUnitOperations.Tag = "DC";
            this.fld_dgcMMMachineUnitOperations.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGridControl1});
            // 
            // fld_dgvGridControl1
            // 
            this.fld_dgvGridControl1.GridControl = this.fld_dgcMMMachineUnitOperations;
            this.fld_dgvGridControl1.Name = "fld_dgvGridControl1";
            this.fld_dgvGridControl1.PaintStyleName = "Office2003";
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 110);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.fld_tabMachine;
            this.bosTabControl1.Size = new System.Drawing.Size(997, 582);
            this.bosTabControl1.TabIndex = 18;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tabMachine,
            this.fld_tabOperation});
            // 
            // fld_tabMachine
            // 
            this.fld_tabMachine.Controls.Add(this.fld_dgcMMMachineUnitItems);
            this.fld_tabMachine.Name = "fld_tabMachine";
            this.fld_tabMachine.Size = new System.Drawing.Size(995, 557);
            this.fld_tabMachine.Text = "Danh sách máy";
            // 
            // fld_dgcMMMachineUnitItems
            // 
            this.fld_dgcMMMachineUnitItems.AllowDrop = true;
            this.fld_dgcMMMachineUnitItems.BOSComment = "";
            this.fld_dgcMMMachineUnitItems.BOSDataMember = "";
            this.fld_dgcMMMachineUnitItems.BOSDataSource = "MMMachineUnitItems";
            this.fld_dgcMMMachineUnitItems.BOSDescription = null;
            this.fld_dgcMMMachineUnitItems.BOSError = null;
            this.fld_dgcMMMachineUnitItems.BOSFieldGroup = "";
            this.fld_dgcMMMachineUnitItems.BOSFieldRelation = "";
            this.fld_dgcMMMachineUnitItems.BOSGridType = null;
            this.fld_dgcMMMachineUnitItems.BOSPrivilege = "";
            this.fld_dgcMMMachineUnitItems.BOSPropertyName = "";
            this.fld_dgcMMMachineUnitItems.CommodityType = "";
            this.fld_dgcMMMachineUnitItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMMachineUnitItems.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMMachineUnitItems.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcMMMachineUnitItems.MainView = this.gridView1;
            this.fld_dgcMMMachineUnitItems.Name = "fld_dgcMMMachineUnitItems";
            this.fld_dgcMMMachineUnitItems.PrintReport = false;
            this.fld_dgcMMMachineUnitItems.Screen = null;
            this.fld_dgcMMMachineUnitItems.Size = new System.Drawing.Size(995, 557);
            this.fld_dgcMMMachineUnitItems.TabIndex = 0;
            this.fld_dgcMMMachineUnitItems.Tag = "DC";
            this.fld_dgcMMMachineUnitItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMMachineUnitItems;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_tabOperation
            // 
            this.fld_tabOperation.Controls.Add(this.fld_btnAdd);
            this.fld_tabOperation.Controls.Add(this.fld_dgcMMMachineUnitOperations);
            this.fld_tabOperation.Name = "fld_tabOperation";
            this.fld_tabOperation.Size = new System.Drawing.Size(981, 550);
            this.fld_tabOperation.Text = "Danh sách công đoạn";
            // 
            // fld_btnAdd
            // 
            this.fld_btnAdd.BOSComment = null;
            this.fld_btnAdd.BOSDataMember = null;
            this.fld_btnAdd.BOSDataSource = null;
            this.fld_btnAdd.BOSDescription = null;
            this.fld_btnAdd.BOSError = null;
            this.fld_btnAdd.BOSFieldGroup = null;
            this.fld_btnAdd.BOSFieldRelation = null;
            this.fld_btnAdd.BOSPrivilege = null;
            this.fld_btnAdd.BOSPropertyName = null;
            this.fld_btnAdd.Location = new System.Drawing.Point(8, 10);
            this.fld_btnAdd.Name = "fld_btnAdd";
            this.fld_btnAdd.Screen = null;
            this.fld_btnAdd.Size = new System.Drawing.Size(124, 25);
            this.fld_btnAdd.TabIndex = 8;
            this.fld_btnAdd.Tag = "DC";
            this.fld_btnAdd.Text = "Thêm công đoạn";
            this.fld_btnAdd.Click += new System.EventHandler(this.Fld_btnAdd_Click);
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
            this.bosPanel2.Controls.Add(this.bosTextBox1);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.bosLabel3);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.bosLabel22);
            this.bosPanel2.Controls.Add(this.fld_txtMMMachineUnitSetupTime);
            this.bosPanel2.Controls.Add(this.fld_txtMMMachineUnitQty);
            this.bosPanel2.Controls.Add(this.fld_txtMMMachineUnitCapacity);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_MMWorkShopID);
            this.bosPanel2.Controls.Add(this.fld_lkeFK_MMLineID);
            this.bosPanel2.Controls.Add(this.bosLabel9);
            this.bosPanel2.Controls.Add(this.bosLabel8);
            this.bosPanel2.Controls.Add(this.fld_lblLabel12);
            this.bosPanel2.Controls.Add(this.bosTabControl1);
            this.bosPanel2.Controls.Add(this.fld_txtMMMachineUnitNo);
            this.bosPanel2.Controls.Add(this.fld_medMMMachineUnitDesc);
            this.bosPanel2.Controls.Add(this.fld_txtMMMachineUnitName);
            this.bosPanel2.Controls.Add(this.fld_lblLabel18);
            this.bosPanel2.Controls.Add(this.fld_lblLabel14);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1000, 695);
            this.bosPanel2.TabIndex = 0;
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
            this.bosLabel1.Location = new System.Drawing.Point(540, 87);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(78, 13);
            this.bosLabel1.TabIndex = 16;
            this.bosLabel1.Text = "Hệ số năng suất";
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
            this.bosLabel3.Location = new System.Drawing.Point(540, 61);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(76, 13);
            this.bosLabel3.TabIndex = 14;
            this.bosLabel3.Text = "TG setup (phút)";
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
            this.bosLabel2.Location = new System.Drawing.Point(540, 35);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(64, 13);
            this.bosLabel2.TabIndex = 10;
            this.bosLabel2.Text = "SL nhân công";
            // 
            // bosLabel22
            // 
            this.bosLabel22.BOSComment = null;
            this.bosLabel22.BOSDataMember = null;
            this.bosLabel22.BOSDataSource = null;
            this.bosLabel22.BOSDescription = null;
            this.bosLabel22.BOSError = null;
            this.bosLabel22.BOSFieldGroup = null;
            this.bosLabel22.BOSFieldRelation = null;
            this.bosLabel22.BOSPrivilege = null;
            this.bosLabel22.BOSPropertyName = null;
            this.bosLabel22.Location = new System.Drawing.Point(540, 9);
            this.bosLabel22.Name = "bosLabel22";
            this.bosLabel22.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel22, true);
            this.bosLabel22.Size = new System.Drawing.Size(98, 13);
            this.bosLabel22.TabIndex = 4;
            this.bosLabel22.Text = "Số giờ làm việc/ngày";
            // 
            // fld_txtMMMachineUnitSetupTime
            // 
            this.fld_txtMMMachineUnitSetupTime.BOSComment = "";
            this.fld_txtMMMachineUnitSetupTime.BOSDataMember = "MMMachineUnitSetupTime";
            this.fld_txtMMMachineUnitSetupTime.BOSDataSource = "MMMachineUnits";
            this.fld_txtMMMachineUnitSetupTime.BOSDescription = null;
            this.fld_txtMMMachineUnitSetupTime.BOSError = null;
            this.fld_txtMMMachineUnitSetupTime.BOSFieldGroup = "";
            this.fld_txtMMMachineUnitSetupTime.BOSFieldRelation = "";
            this.fld_txtMMMachineUnitSetupTime.BOSPrivilege = "";
            this.fld_txtMMMachineUnitSetupTime.BOSPropertyName = "Text";
            this.fld_txtMMMachineUnitSetupTime.Location = new System.Drawing.Point(644, 58);
            this.fld_txtMMMachineUnitSetupTime.Name = "fld_txtMMMachineUnitSetupTime";
            this.fld_txtMMMachineUnitSetupTime.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMMachineUnitSetupTime.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMMachineUnitSetupTime.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMMachineUnitSetupTime.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMMachineUnitSetupTime.Properties.Mask.EditMask = "n";
            this.fld_txtMMMachineUnitSetupTime.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMMMachineUnitSetupTime.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMMachineUnitSetupTime.Screen = null;
            this.fld_txtMMMachineUnitSetupTime.Size = new System.Drawing.Size(179, 20);
            this.fld_txtMMMachineUnitSetupTime.TabIndex = 15;
            this.fld_txtMMMachineUnitSetupTime.Tag = "DC";
            // 
            // fld_txtMMMachineUnitQty
            // 
            this.fld_txtMMMachineUnitQty.BOSComment = "";
            this.fld_txtMMMachineUnitQty.BOSDataMember = "MMMachineUnitQty";
            this.fld_txtMMMachineUnitQty.BOSDataSource = "MMMachineUnits";
            this.fld_txtMMMachineUnitQty.BOSDescription = null;
            this.fld_txtMMMachineUnitQty.BOSError = null;
            this.fld_txtMMMachineUnitQty.BOSFieldGroup = "";
            this.fld_txtMMMachineUnitQty.BOSFieldRelation = "";
            this.fld_txtMMMachineUnitQty.BOSPrivilege = "";
            this.fld_txtMMMachineUnitQty.BOSPropertyName = "Text";
            this.fld_txtMMMachineUnitQty.Location = new System.Drawing.Point(644, 32);
            this.fld_txtMMMachineUnitQty.Name = "fld_txtMMMachineUnitQty";
            this.fld_txtMMMachineUnitQty.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMMachineUnitQty.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMMachineUnitQty.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMMachineUnitQty.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMMachineUnitQty.Properties.Mask.EditMask = "n";
            this.fld_txtMMMachineUnitQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMMMachineUnitQty.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMMachineUnitQty.Screen = null;
            this.fld_txtMMMachineUnitQty.Size = new System.Drawing.Size(179, 20);
            this.fld_txtMMMachineUnitQty.TabIndex = 11;
            this.fld_txtMMMachineUnitQty.Tag = "DC";
            // 
            // fld_txtMMMachineUnitCapacity
            // 
            this.fld_txtMMMachineUnitCapacity.BOSComment = "";
            this.fld_txtMMMachineUnitCapacity.BOSDataMember = "MMMachineUnitCapacity";
            this.fld_txtMMMachineUnitCapacity.BOSDataSource = "MMMachineUnits";
            this.fld_txtMMMachineUnitCapacity.BOSDescription = null;
            this.fld_txtMMMachineUnitCapacity.BOSError = null;
            this.fld_txtMMMachineUnitCapacity.BOSFieldGroup = "";
            this.fld_txtMMMachineUnitCapacity.BOSFieldRelation = "";
            this.fld_txtMMMachineUnitCapacity.BOSPrivilege = "";
            this.fld_txtMMMachineUnitCapacity.BOSPropertyName = "Text";
            this.fld_txtMMMachineUnitCapacity.Cursor = System.Windows.Forms.Cursors.Default;
            this.fld_txtMMMachineUnitCapacity.Location = new System.Drawing.Point(644, 6);
            this.fld_txtMMMachineUnitCapacity.Name = "fld_txtMMMachineUnitCapacity";
            this.fld_txtMMMachineUnitCapacity.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMMachineUnitCapacity.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMMachineUnitCapacity.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMMachineUnitCapacity.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMMachineUnitCapacity.Properties.Mask.EditMask = "n2";
            this.fld_txtMMMachineUnitCapacity.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.fld_txtMMMachineUnitCapacity.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMMachineUnitCapacity.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMMachineUnitCapacity, true);
            this.fld_txtMMMachineUnitCapacity.Size = new System.Drawing.Size(179, 20);
            this.fld_txtMMMachineUnitCapacity.TabIndex = 5;
            this.fld_txtMMMachineUnitCapacity.Tag = "DC";
            this.fld_txtMMMachineUnitCapacity.Validated += new System.EventHandler(this.fld_txtMMMachineUnitCapacity_Validated);
            // 
            // fld_lkeFK_MMWorkShopID
            // 
            this.fld_lkeFK_MMWorkShopID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMWorkShopID.BOSAllowDummy = true;
            this.fld_lkeFK_MMWorkShopID.BOSComment = "";
            this.fld_lkeFK_MMWorkShopID.BOSDataMember = "FK_MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.BOSDataSource = "MMMachineUnits";
            this.fld_lkeFK_MMWorkShopID.BOSDescription = null;
            this.fld_lkeFK_MMWorkShopID.BOSError = null;
            this.fld_lkeFK_MMWorkShopID.BOSFieldGroup = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldParent = "";
            this.fld_lkeFK_MMWorkShopID.BOSFieldRelation = "";
            this.fld_lkeFK_MMWorkShopID.BOSPrivilege = "";
            this.fld_lkeFK_MMWorkShopID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMWorkShopID.BOSSelectType = "";
            this.fld_lkeFK_MMWorkShopID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMWorkShopID.CurrentDisplayText = "";
            this.fld_lkeFK_MMWorkShopID.Location = new System.Drawing.Point(333, 6);
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
            this.fld_lkeFK_MMWorkShopID.Properties.NullText = "";
            this.fld_lkeFK_MMWorkShopID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMWorkShopID.Properties.ValueMember = "MMWorkShopID";
            this.fld_lkeFK_MMWorkShopID.Screen = null;
            this.fld_lkeFK_MMWorkShopID.Size = new System.Drawing.Size(179, 20);
            this.fld_lkeFK_MMWorkShopID.TabIndex = 3;
            this.fld_lkeFK_MMWorkShopID.Tag = "DC";
            this.fld_lkeFK_MMWorkShopID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.Fld_lkeFK_MMWorkShopID_QueryPopUp);
            this.fld_lkeFK_MMWorkShopID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.Fld_lkeFK_MMWorkShopID_CloseUp);
            // 
            // fld_lkeFK_MMLineID
            // 
            this.fld_lkeFK_MMLineID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMLineID.BOSAllowDummy = true;
            this.fld_lkeFK_MMLineID.BOSComment = "";
            this.fld_lkeFK_MMLineID.BOSDataMember = "FK_MMLineID";
            this.fld_lkeFK_MMLineID.BOSDataSource = "MMMachineUnits";
            this.fld_lkeFK_MMLineID.BOSDescription = null;
            this.fld_lkeFK_MMLineID.BOSError = null;
            this.fld_lkeFK_MMLineID.BOSFieldGroup = "";
            this.fld_lkeFK_MMLineID.BOSFieldParent = "";
            this.fld_lkeFK_MMLineID.BOSFieldRelation = "";
            this.fld_lkeFK_MMLineID.BOSPrivilege = "";
            this.fld_lkeFK_MMLineID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMLineID.BOSSelectType = "";
            this.fld_lkeFK_MMLineID.BOSSelectTypeValue = "";
            this.fld_lkeFK_MMLineID.CurrentDisplayText = "";
            this.fld_lkeFK_MMLineID.Location = new System.Drawing.Point(333, 32);
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
            this.fld_lkeFK_MMLineID.Properties.NullText = "";
            this.fld_lkeFK_MMLineID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMLineID.Properties.ValueMember = "MMLineID";
            this.fld_lkeFK_MMLineID.Screen = null;
            this.fld_lkeFK_MMLineID.Size = new System.Drawing.Size(179, 20);
            this.fld_lkeFK_MMLineID.TabIndex = 9;
            this.fld_lkeFK_MMLineID.Tag = "DC";
            this.fld_lkeFK_MMLineID.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.fld_lkeFK_MMLineID_QueryPopUp);
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
            this.bosLabel9.Location = new System.Drawing.Point(276, 9);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(31, 13);
            this.bosLabel9.TabIndex = 2;
            this.bosLabel9.Text = "Xưởng";
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
            this.bosLabel8.Location = new System.Drawing.Point(276, 35);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(37, 13);
            this.bosLabel8.TabIndex = 8;
            this.bosLabel8.Text = "Chuyền";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "MMMachineUnitCapacityCoefficient";
            this.bosTextBox1.BOSDataSource = "MMMachineUnits";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(644, 84);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.bosTextBox1.Properties.MaskSettings.Set("mask", "n2");
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(179, 20);
            this.bosTextBox1.TabIndex = 19;
            this.bosTextBox1.Tag = "DC";
            // 
            // DMMU100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1000, 695);
            this.Controls.Add(this.bosPanel2);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMMU100.IconOptions.Icon")));
            this.Name = "DMMU100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMMachineUnitDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMachineUnitOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.fld_tabMachine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMachineUnitItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.fld_tabOperation.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitSetupTime.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitCapacity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMWorkShopID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMLineID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLabel fld_lblLabel18;
        private BOSComponent.BOSTextBox fld_txtMMMachineUnitName;
        private BOSComponent.BOSMemoEdit fld_medMMMachineUnitDesc;
        private BOSComponent.BOSTextBox fld_txtMMMachineUnitNo;
        private IContainer components;
        private MMMachineUnitOperationGridControl fld_dgcMMMachineUnitOperations;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGridControl1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage fld_tabOperation;
        private DevExpress.XtraTab.XtraTabPage fld_tabMachine;
        private MMMachineItemsGridControl fld_dgcMMMachineUnitItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMWorkShopID;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMLineID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSButton fld_btnAdd;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel22;
        private BOSComponent.BOSTextBox fld_txtMMMachineUnitCapacity;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox fld_txtMMMachineUnitQty;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSTextBox fld_txtMMMachineUnitSetupTime;
        private BOSComponent.BOSTextBox bosTextBox1;
    }
}
