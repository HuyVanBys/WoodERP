using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.MachineGroup.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class DMMG100
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
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnLuu = new BOSComponent.BOSButton(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMachineGroups = new BOSERP.Modules.MachineGroup.MachineGroupGridControl();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeACAssetID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcMachineGroupTSCD = new BOSERP.Modules.MachineGroup.ICMachineGroupTSCDGridControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeICProductIdentifiedEquipmentID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcMachineGroupCCDC = new BOSERP.Modules.MachineGroup.ICMachineGroupCCDCGridControl();
            this.xtraScrollableControl1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).BeginInit();
            this.bosGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMachineGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMachineGroupTSCD)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifiedEquipmentID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMachineGroupCCDC)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.bosPanel1);
            this.xtraScrollableControl1.Controls.Add(this.splitContainerControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1150, 706);
            this.xtraScrollableControl1.TabIndex = 6;
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
            this.bosPanel1.Controls.Add(this.fld_btnLuu);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel1.Location = new System.Drawing.Point(0, 647);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1150, 59);
            this.bosPanel1.TabIndex = 2;
            // 
            // fld_btnLuu
            // 
            this.fld_btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnLuu.BOSComment = null;
            this.fld_btnLuu.BOSDataMember = null;
            this.fld_btnLuu.BOSDataSource = null;
            this.fld_btnLuu.BOSDescription = null;
            this.fld_btnLuu.BOSError = null;
            this.fld_btnLuu.BOSFieldGroup = null;
            this.fld_btnLuu.BOSFieldRelation = null;
            this.fld_btnLuu.BOSPrivilege = null;
            this.fld_btnLuu.BOSPropertyName = null;
            this.fld_btnLuu.Location = new System.Drawing.Point(1003, 6);
            this.fld_btnLuu.Name = "fld_btnLuu";
            this.fld_btnLuu.Screen = null;
            this.fld_btnLuu.Size = new System.Drawing.Size(125, 44);
            this.fld_btnLuu.TabIndex = 0;
            this.fld_btnLuu.Tag = "DC";
            this.fld_btnLuu.Text = "Lưu";
            this.fld_btnLuu.Click += new System.EventHandler(this.fld_btnLuu_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.bosGroupControl1);
            this.splitContainerControl1.Panel2.Controls.Add(this.bosTabControl1);
            this.splitContainerControl1.Size = new System.Drawing.Size(1147, 641);
            this.splitContainerControl1.SplitterPosition = 477;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosGroupControl1
            // 
            this.bosGroupControl1.BOSComment = null;
            this.bosGroupControl1.BOSDataMember = null;
            this.bosGroupControl1.BOSDataSource = null;
            this.bosGroupControl1.BOSDescription = null;
            this.bosGroupControl1.BOSError = null;
            this.bosGroupControl1.BOSFieldGroup = null;
            this.bosGroupControl1.BOSFieldRelation = null;
            this.bosGroupControl1.BOSPrivilege = null;
            this.bosGroupControl1.BOSPropertyName = null;
            this.bosGroupControl1.Controls.Add(this.fld_dgcMachineGroups);
            this.bosGroupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosGroupControl1.Location = new System.Drawing.Point(0, 0);
            this.bosGroupControl1.Name = "bosGroupControl1";
            this.bosGroupControl1.Screen = null;
            this.bosGroupControl1.Size = new System.Drawing.Size(477, 641);
            this.bosGroupControl1.TabIndex = 0;
            this.bosGroupControl1.Text = "Nhóm máy";
            // 
            // fld_dgcMachineGroups
            // 
            this.fld_dgcMachineGroups.BOSComment = null;
            this.fld_dgcMachineGroups.BOSDataMember = null;
            this.fld_dgcMachineGroups.BOSDataSource = "ICMachines";
            this.fld_dgcMachineGroups.BOSDescription = null;
            this.fld_dgcMachineGroups.BOSError = null;
            this.fld_dgcMachineGroups.BOSFieldGroup = null;
            this.fld_dgcMachineGroups.BOSFieldRelation = null;
            this.fld_dgcMachineGroups.BOSGridType = null;
            this.fld_dgcMachineGroups.BOSPrivilege = null;
            this.fld_dgcMachineGroups.BOSPropertyName = null;
            this.fld_dgcMachineGroups.CommodityType = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_dgcMachineGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMachineGroups.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcMachineGroups.MenuManager = this.screenToolbar;
            this.fld_dgcMachineGroups.Name = "fld_dgcMachineGroups";
            this.fld_dgcMachineGroups.PrintReport = false;
            this.fld_dgcMachineGroups.Screen = null;
            this.fld_dgcMachineGroups.Size = new System.Drawing.Size(473, 617);
            this.fld_dgcMachineGroups.TabIndex = 1;
            this.fld_dgcMachineGroups.Tag = "DC";
            // 
            // bosTabControl1
            // 
            this.bosTabControl1.BOSComment = null;
            this.bosTabControl1.BOSDataMember = null;
            this.bosTabControl1.BOSDataSource = null;
            this.bosTabControl1.BOSDescription = null;
            this.bosTabControl1.BOSError = null;
            this.bosTabControl1.BOSFieldGroup = null;
            this.bosTabControl1.BOSFieldRelation = null;
            this.bosTabControl1.BOSPrivilege = null;
            this.bosTabControl1.BOSPropertyName = null;
            this.bosTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosTabControl1.Location = new System.Drawing.Point(0, 0);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(664, 641);
            this.bosTabControl1.TabIndex = 1;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            this.bosTabControl1.Tag = "DC";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.bosLabel1);
            this.xtraTabPage1.Controls.Add(this.fld_lkeACAssetID);
            this.xtraTabPage1.Controls.Add(this.fld_dgcMachineGroupTSCD);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(657, 612);
            this.xtraTabPage1.Text = "TSCĐ";
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
            this.bosLabel1.Location = new System.Drawing.Point(6, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(60, 13);
            this.bosLabel1.TabIndex = 16;
            this.bosLabel1.Text = "Chọn tài sản";
            // 
            // fld_lkeACAssetID
            // 
            this.fld_lkeACAssetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeACAssetID.BOSAllowAddNew = false;
            this.fld_lkeACAssetID.BOSAllowDummy = false;
            this.fld_lkeACAssetID.BOSComment = null;
            this.fld_lkeACAssetID.BOSDataMember = "ACAssetID";
            this.fld_lkeACAssetID.BOSDataSource = "ACAssets";
            this.fld_lkeACAssetID.BOSDescription = null;
            this.fld_lkeACAssetID.BOSError = null;
            this.fld_lkeACAssetID.BOSFieldGroup = null;
            this.fld_lkeACAssetID.BOSFieldParent = null;
            this.fld_lkeACAssetID.BOSFieldRelation = null;
            this.fld_lkeACAssetID.BOSPrivilege = null;
            this.fld_lkeACAssetID.BOSPropertyName = "EditValue";
            this.fld_lkeACAssetID.BOSSelectType = null;
            this.fld_lkeACAssetID.BOSSelectTypeValue = null;
            this.fld_lkeACAssetID.CurrentDisplayText = null;
            this.fld_lkeACAssetID.Location = new System.Drawing.Point(70, 9);
            this.fld_lkeACAssetID.MenuManager = this.screenToolbar;
            this.fld_lkeACAssetID.Name = "fld_lkeACAssetID";
            this.fld_lkeACAssetID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeACAssetID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetNo", "Mã"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACAssetName", "Tên")});
            this.fld_lkeACAssetID.Properties.DisplayMember = "ACAssetNo";
            this.fld_lkeACAssetID.Properties.NullText = string.Empty;
            this.fld_lkeACAssetID.Properties.ValueMember = "ACAssetID";
            this.fld_lkeACAssetID.Screen = null;
            this.fld_lkeACAssetID.Size = new System.Drawing.Size(582, 20);
            this.fld_lkeACAssetID.TabIndex = 17;
            this.fld_lkeACAssetID.Tag = "DC";
            this.fld_lkeACAssetID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeACAssetID_KeyUp);
            // 
            // fld_dgcMachineGroupTSCD
            // 
            this.fld_dgcMachineGroupTSCD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMachineGroupTSCD.BOSComment = null;
            this.fld_dgcMachineGroupTSCD.BOSDataMember = null;
            this.fld_dgcMachineGroupTSCD.BOSDataSource = "ICMachineGroups";
            this.fld_dgcMachineGroupTSCD.BOSDescription = null;
            this.fld_dgcMachineGroupTSCD.BOSError = null;
            this.fld_dgcMachineGroupTSCD.BOSFieldGroup = null;
            this.fld_dgcMachineGroupTSCD.BOSFieldRelation = null;
            this.fld_dgcMachineGroupTSCD.BOSGridType = null;
            this.fld_dgcMachineGroupTSCD.BOSPrivilege = null;
            this.fld_dgcMachineGroupTSCD.BOSPropertyName = null;
            this.fld_dgcMachineGroupTSCD.CommodityType = string.Empty;
            this.fld_dgcMachineGroupTSCD.Location = new System.Drawing.Point(6, 35);
            this.fld_dgcMachineGroupTSCD.MenuManager = this.screenToolbar;
            this.fld_dgcMachineGroupTSCD.Name = "fld_dgcMachineGroupTSCD";
            this.fld_dgcMachineGroupTSCD.PrintReport = false;
            this.fld_dgcMachineGroupTSCD.Screen = null;
            this.fld_dgcMachineGroupTSCD.Size = new System.Drawing.Size(646, 568);
            this.fld_dgcMachineGroupTSCD.TabIndex = 15;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.bosLabel8);
            this.xtraTabPage2.Controls.Add(this.fld_lkeICProductIdentifiedEquipmentID);
            this.xtraTabPage2.Controls.Add(this.fld_dgcMachineGroupCCDC);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(657, 612);
            this.xtraTabPage2.Text = "CCDC";
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
            this.bosLabel8.Location = new System.Drawing.Point(7, 17);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(56, 13);
            this.bosLabel8.TabIndex = 14;
            this.bosLabel8.Text = "Chọn CCDC";
            // 
            // fld_lkeICProductIdentifiedEquipmentID
            // 
            this.fld_lkeICProductIdentifiedEquipmentID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_lkeICProductIdentifiedEquipmentID.BOSAllowAddNew = false;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSAllowDummy = false;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSComment = null;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSDataMember = "ICProductIdentifiedEquipmentID";
            this.fld_lkeICProductIdentifiedEquipmentID.BOSDataSource = "ICProductIdentifiedEquipments";
            this.fld_lkeICProductIdentifiedEquipmentID.BOSDescription = null;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSError = null;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSFieldGroup = null;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSFieldParent = null;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSFieldRelation = null;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSPrivilege = null;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSPropertyName = "EditValue";
            this.fld_lkeICProductIdentifiedEquipmentID.BOSSelectType = null;
            this.fld_lkeICProductIdentifiedEquipmentID.BOSSelectTypeValue = null;
            this.fld_lkeICProductIdentifiedEquipmentID.CurrentDisplayText = null;
            this.fld_lkeICProductIdentifiedEquipmentID.Location = new System.Drawing.Point(71, 14);
            this.fld_lkeICProductIdentifiedEquipmentID.MenuManager = this.screenToolbar;
            this.fld_lkeICProductIdentifiedEquipmentID.Name = "fld_lkeICProductIdentifiedEquipmentID";
            this.fld_lkeICProductIdentifiedEquipmentID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeICProductIdentifiedEquipmentID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductIdentifiedEquipmentNo", "Mã định danh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ICProductName", "Tên")});
            this.fld_lkeICProductIdentifiedEquipmentID.Properties.DisplayMember = "ICProductIdentifiedEquipmentNo";
            this.fld_lkeICProductIdentifiedEquipmentID.Properties.NullText = string.Empty;
            this.fld_lkeICProductIdentifiedEquipmentID.Properties.ValueMember = "ICProductIdentifiedEquipmentID";
            this.fld_lkeICProductIdentifiedEquipmentID.Screen = null;
            this.fld_lkeICProductIdentifiedEquipmentID.Size = new System.Drawing.Size(582, 20);
            this.fld_lkeICProductIdentifiedEquipmentID.TabIndex = 14;
            this.fld_lkeICProductIdentifiedEquipmentID.Tag = "DC";
            this.fld_lkeICProductIdentifiedEquipmentID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeICProductIdentifiedEquipmentID_KeyUp);
            // 
            // fld_dgcMachineGroupCCDC
            // 
            this.fld_dgcMachineGroupCCDC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMachineGroupCCDC.BOSComment = null;
            this.fld_dgcMachineGroupCCDC.BOSDataMember = null;
            this.fld_dgcMachineGroupCCDC.BOSDataSource = "ICMachineGroups";
            this.fld_dgcMachineGroupCCDC.BOSDescription = null;
            this.fld_dgcMachineGroupCCDC.BOSError = null;
            this.fld_dgcMachineGroupCCDC.BOSFieldGroup = null;
            this.fld_dgcMachineGroupCCDC.BOSFieldRelation = null;
            this.fld_dgcMachineGroupCCDC.BOSGridType = null;
            this.fld_dgcMachineGroupCCDC.BOSPrivilege = null;
            this.fld_dgcMachineGroupCCDC.BOSPropertyName = null;
            this.fld_dgcMachineGroupCCDC.CommodityType = string.Empty;
            this.fld_dgcMachineGroupCCDC.Location = new System.Drawing.Point(7, 40);
            this.fld_dgcMachineGroupCCDC.MenuManager = this.screenToolbar;
            this.fld_dgcMachineGroupCCDC.Name = "fld_dgcMachineGroupCCDC";
            this.fld_dgcMachineGroupCCDC.PrintReport = false;
            this.fld_dgcMachineGroupCCDC.Screen = null;
            this.fld_dgcMachineGroupCCDC.Size = new System.Drawing.Size(646, 568);
            this.fld_dgcMachineGroupCCDC.TabIndex = 1;
            // 
            // DMMG100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1150, 706);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "DMMG100";
            this.Tag = "DM";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.xtraScrollableControl1, 0);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bosGroupControl1)).EndInit();
            this.bosGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMachineGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeACAssetID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMachineGroupTSCD)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeICProductIdentifiedEquipmentID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMachineGroupCCDC)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSTabControl bosTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSLookupEdit fld_lkeICProductIdentifiedEquipmentID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSLookupEdit fld_lkeACAssetID;
        private ICMachineGroupCCDCGridControl fld_dgcMachineGroupCCDC;
        private BOSGroupControl bosGroupControl1;
        private MachineGroupGridControl fld_dgcMachineGroups;
        private ICMachineGroupTSCDGridControl fld_dgcMachineGroupTSCD;
        private BOSPanel bosPanel1;
        private BOSButton fld_btnLuu;
	}
}
