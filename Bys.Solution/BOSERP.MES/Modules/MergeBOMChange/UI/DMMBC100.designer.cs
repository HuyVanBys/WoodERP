using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.MergeBOMChange.UI
{
	/// <summary>
	/// Summary description for DMMBC100
	/// </summary>
	partial class DMMBC100
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
            this.fld_tcChangeInfomation = new BOSComponent.BOSTabControl(this.components);
            this.fld_tpItem = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMMergeBOMChangeItemBOMLogs = new BOSERP.Modules.MergeBOMChange.MMMergeBOMChangeItemBOMLogsGridControl();
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMMergeBOMChangeItemBPLogs = new BOSERP.Modules.MergeBOMChange.MMMergeBOMChangeItemBPLogsGridControl();
            this.fld_tpMaterial = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLabel12 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs = new BOSERP.Modules.MergeBOMChange.MMMergeBOMChangeItemMaterialBOMLogsGridControl();
            this.bosLabel13 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs = new BOSERP.Modules.MergeBOMChange.MMMergeBOMChangeItemMaterialBPLogsGridControl();
            this.fld_tpProcess = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.bosLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs = new BOSERP.Modules.MergeBOMChange.MMMergeBOMChangeItemProcessBOMLogsGridControl();
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs = new BOSERP.Modules.MergeBOMChange.MMMergeBOMChangeItemProcessBPLogsGridControl();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLabel20 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel21 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel17 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel18 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnLoadChange = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_txtMMMergeBOMChangeNo = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMMergeBOMChangeType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMProductionNormApproveLogID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteMMMergeBOMChangeDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMMergeBOMChangeStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_lkeFK_MMProductionNormID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_medMMMergeBOMChangeDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcMMMergeBOMChangeBatchProducts = new BOSERP.Modules.MergeBOMChange.MMMergeBOMChangeBatchProductsGridControl();
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMBatchProductID = new BOSComponent.BOSLookupEdit(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvMMMergeBOMChangeItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_tcChangeInfomation)).BeginInit();
            this.fld_tcChangeInfomation.SuspendLayout();
            this.fld_tpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemBOMLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemBPLogs)).BeginInit();
            this.fld_tpMaterial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs)).BeginInit();
            this.fld_tpProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemProcessBPLogs)).BeginInit();
            this.bosPanel2.SuspendLayout();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMergeBOMChangeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMMergeBOMChangeType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormApproveLogID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMMergeBOMChangeDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMMergeBOMChangeDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMMergeBOMChangeStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMMergeBOMChangeDesc.Properties)).BeginInit();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeBatchProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMMergeBOMChangeItems)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.fld_tcChangeInfomation);
            this.bosPanel1.Controls.Add(this.bosPanel2);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(1175, 527);
            this.bosPanel1.TabIndex = 6;
            // 
            // fld_tcChangeInfomation
            // 
            this.fld_tcChangeInfomation.BOSComment = null;
            this.fld_tcChangeInfomation.BOSDataMember = null;
            this.fld_tcChangeInfomation.BOSDataSource = null;
            this.fld_tcChangeInfomation.BOSDescription = null;
            this.fld_tcChangeInfomation.BOSError = null;
            this.fld_tcChangeInfomation.BOSFieldGroup = null;
            this.fld_tcChangeInfomation.BOSFieldRelation = null;
            this.fld_tcChangeInfomation.BOSPrivilege = null;
            this.fld_tcChangeInfomation.BOSPropertyName = null;
            this.fld_tcChangeInfomation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_tcChangeInfomation.Location = new System.Drawing.Point(0, 210);
            this.fld_tcChangeInfomation.Name = "fld_tcChangeInfomation";
            this.fld_tcChangeInfomation.Screen = null;
            this.fld_tcChangeInfomation.SelectedTabPage = this.fld_tpItem;
            this.fld_tcChangeInfomation.Size = new System.Drawing.Size(1175, 317);
            this.fld_tcChangeInfomation.TabIndex = 118;
            this.fld_tcChangeInfomation.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.fld_tpItem,
            this.fld_tpMaterial,
            this.fld_tpProcess});
            // 
            // fld_tpItem
            // 
            this.fld_tpItem.Controls.Add(this.splitContainerControl1);
            this.fld_tpItem.Name = "fld_tpItem";
            this.fld_tpItem.Size = new System.Drawing.Size(1168, 288);
            this.fld_tpItem.Text = "Chi tiết thay đổi";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.bosLabel10);
            this.splitContainerControl1.Panel1.Controls.Add(this.fld_dgcMMMergeBOMChangeItemBOMLogs);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.bosLabel11);
            this.splitContainerControl1.Panel2.Controls.Add(this.fld_dgcMMMergeBOMChangeItemBPLogs);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1168, 288);
            this.splitContainerControl1.SplitterPosition = 626;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // bosLabel10
            // 
            this.bosLabel10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel10.Appearance.Options.UseFont = true;
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(3, 3);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.bosLabel10.Size = new System.Drawing.Size(83, 13);
            this.bosLabel10.TabIndex = 1;
            this.bosLabel10.Text = "Bảng định mức";
            // 
            // fld_dgcMMMergeBOMChangeItemBOMLogs
            // 
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSComment = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSDataMember = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSDataSource = "MMMergeBOMChangeItemBOMLogs";
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSDescription = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSError = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSFieldGroup = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSFieldRelation = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSGridType = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSPrivilege = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.BOSPropertyName = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.CommodityType = "";
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.MenuManager = this.screenToolbar;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.Name = "fld_dgcMMMergeBOMChangeItemBOMLogs";
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.PrintReport = false;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.Screen = null;
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.Size = new System.Drawing.Size(624, 263);
            this.fld_dgcMMMergeBOMChangeItemBOMLogs.TabIndex = 0;
            // 
            // bosLabel11
            // 
            this.bosLabel11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel11.Appearance.Options.UseFont = true;
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(9, 3);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(79, 13);
            this.bosLabel11.TabIndex = 3;
            this.bosLabel11.Text = "Lệnh sản xuất";
            // 
            // fld_dgcMMMergeBOMChangeItemBPLogs
            // 
            this.fld_dgcMMMergeBOMChangeItemBPLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSComment = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSDataMember = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSDataSource = "MMMergeBOMChangeItemBPLogs";
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSDescription = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSError = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSFieldGroup = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSFieldRelation = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSGridType = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSPrivilege = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.BOSPropertyName = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.CommodityType = "";
            this.fld_dgcMMMergeBOMChangeItemBPLogs.Location = new System.Drawing.Point(3, 22);
            this.fld_dgcMMMergeBOMChangeItemBPLogs.MenuManager = this.screenToolbar;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.Name = "fld_dgcMMMergeBOMChangeItemBPLogs";
            this.fld_dgcMMMergeBOMChangeItemBPLogs.PrintReport = false;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.Screen = null;
            this.fld_dgcMMMergeBOMChangeItemBPLogs.Size = new System.Drawing.Size(529, 263);
            this.fld_dgcMMMergeBOMChangeItemBPLogs.TabIndex = 2;
            // 
            // fld_tpMaterial
            // 
            this.fld_tpMaterial.Controls.Add(this.splitContainerControl2);
            this.fld_tpMaterial.Name = "fld_tpMaterial";
            this.fld_tpMaterial.Size = new System.Drawing.Size(1168, 288);
            this.fld_tpMaterial.Text = "Nguyên liệu gỗ";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.bosLabel12);
            this.splitContainerControl2.Panel1.Controls.Add(this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.bosLabel13);
            this.splitContainerControl2.Panel2.Controls.Add(this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1168, 288);
            this.splitContainerControl2.SplitterPosition = 626;
            this.splitContainerControl2.TabIndex = 120;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // bosLabel12
            // 
            this.bosLabel12.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel12.Appearance.Options.UseFont = true;
            this.bosLabel12.BOSComment = null;
            this.bosLabel12.BOSDataMember = null;
            this.bosLabel12.BOSDataSource = null;
            this.bosLabel12.BOSDescription = null;
            this.bosLabel12.BOSError = null;
            this.bosLabel12.BOSFieldGroup = null;
            this.bosLabel12.BOSFieldRelation = null;
            this.bosLabel12.BOSPrivilege = null;
            this.bosLabel12.BOSPropertyName = null;
            this.bosLabel12.Location = new System.Drawing.Point(3, 3);
            this.bosLabel12.Name = "bosLabel12";
            this.bosLabel12.Screen = null;
            this.bosLabel12.Size = new System.Drawing.Size(83, 13);
            this.bosLabel12.TabIndex = 1;
            this.bosLabel12.Text = "Bảng định mức";
            // 
            // fld_dgcMMMergeBOMChangeItemMaterialBOMLogs
            // 
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSComment = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSDataMember = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSDataSource = "MMMergeBOMChangeItemMaterialBOMLogs";
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSDescription = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSError = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSFieldGroup = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSFieldRelation = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSGridType = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSPrivilege = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.BOSPropertyName = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.CommodityType = "";
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.MenuManager = this.screenToolbar;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.Name = "fld_dgcMMMergeBOMChangeItemMaterialBOMLogs";
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.PrintReport = false;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.Screen = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.Size = new System.Drawing.Size(624, 263);
            this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs.TabIndex = 0;
            // 
            // bosLabel13
            // 
            this.bosLabel13.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel13.Appearance.Options.UseFont = true;
            this.bosLabel13.BOSComment = null;
            this.bosLabel13.BOSDataMember = null;
            this.bosLabel13.BOSDataSource = null;
            this.bosLabel13.BOSDescription = null;
            this.bosLabel13.BOSError = null;
            this.bosLabel13.BOSFieldGroup = null;
            this.bosLabel13.BOSFieldRelation = null;
            this.bosLabel13.BOSPrivilege = null;
            this.bosLabel13.BOSPropertyName = null;
            this.bosLabel13.Location = new System.Drawing.Point(9, 3);
            this.bosLabel13.Name = "bosLabel13";
            this.bosLabel13.Screen = null;
            this.bosLabel13.Size = new System.Drawing.Size(79, 13);
            this.bosLabel13.TabIndex = 3;
            this.bosLabel13.Text = "Lệnh sản xuất";
            // 
            // fld_dgcMMMergeBOMChangeItemMaterialBPLogs
            // 
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSComment = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSDataMember = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSDataSource = "MMMergeBOMChangeItemMaterialBPLogs";
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSDescription = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSError = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSFieldGroup = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSFieldRelation = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSGridType = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSPrivilege = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.BOSPropertyName = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.CommodityType = "";
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.Location = new System.Drawing.Point(3, 22);
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.MenuManager = this.screenToolbar;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.Name = "fld_dgcMMMergeBOMChangeItemMaterialBPLogs";
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.PrintReport = false;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.Screen = null;
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.Size = new System.Drawing.Size(529, 263);
            this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs.TabIndex = 2;
            // 
            // fld_tpProcess
            // 
            this.fld_tpProcess.Controls.Add(this.splitContainerControl3);
            this.fld_tpProcess.Name = "fld_tpProcess";
            this.fld_tpProcess.Size = new System.Drawing.Size(1168, 288);
            this.fld_tpProcess.Text = "QTSX";
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.bosLabel14);
            this.splitContainerControl3.Panel1.Controls.Add(this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.bosLabel15);
            this.splitContainerControl3.Panel2.Controls.Add(this.fld_dgcMMMergeBOMChangeItemProcessBPLogs);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1168, 288);
            this.splitContainerControl3.SplitterPosition = 626;
            this.splitContainerControl3.TabIndex = 1;
            this.splitContainerControl3.Text = "splitContainerControl3";
            // 
            // bosLabel14
            // 
            this.bosLabel14.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel14.Appearance.Options.UseFont = true;
            this.bosLabel14.BOSComment = null;
            this.bosLabel14.BOSDataMember = null;
            this.bosLabel14.BOSDataSource = null;
            this.bosLabel14.BOSDescription = null;
            this.bosLabel14.BOSError = null;
            this.bosLabel14.BOSFieldGroup = null;
            this.bosLabel14.BOSFieldRelation = null;
            this.bosLabel14.BOSPrivilege = null;
            this.bosLabel14.BOSPropertyName = null;
            this.bosLabel14.Location = new System.Drawing.Point(3, 3);
            this.bosLabel14.Name = "bosLabel14";
            this.bosLabel14.Screen = null;
            this.bosLabel14.Size = new System.Drawing.Size(83, 13);
            this.bosLabel14.TabIndex = 1;
            this.bosLabel14.Text = "Bảng định mức";
            // 
            // fld_dgcMMMergeBOMChangeItemProcessBOMLogs
            // 
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSComment = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSDataMember = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSDataSource = "MMMergeBOMChangeItemProcessBOMLogs";
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSDescription = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSError = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSFieldGroup = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSFieldRelation = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSGridType = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSPrivilege = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.BOSPropertyName = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.CommodityType = "";
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.MenuManager = this.screenToolbar;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.Name = "fld_dgcMMMergeBOMChangeItemProcessBOMLogs";
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.PrintReport = false;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.Screen = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.Size = new System.Drawing.Size(624, 263);
            this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs.TabIndex = 0;
            // 
            // bosLabel15
            // 
            this.bosLabel15.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.bosLabel15.Appearance.Options.UseFont = true;
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(9, 3);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(79, 13);
            this.bosLabel15.TabIndex = 3;
            this.bosLabel15.Text = "Lệnh sản xuất";
            // 
            // fld_dgcMMMergeBOMChangeItemProcessBPLogs
            // 
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSComment = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSDataMember = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSDataSource = "MMMergeBOMChangeItemProcessBPLogs";
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSDescription = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSError = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSFieldGroup = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSFieldRelation = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSGridType = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSPrivilege = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.BOSPropertyName = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.CommodityType = "";
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.Location = new System.Drawing.Point(3, 22);
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.MenuManager = this.screenToolbar;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.Name = "fld_dgcMMMergeBOMChangeItemProcessBPLogs";
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.PrintReport = false;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.Screen = null;
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.Size = new System.Drawing.Size(529, 263);
            this.fld_dgcMMMergeBOMChangeItemProcessBPLogs.TabIndex = 2;
            // 
            // bosPanel2
            // 
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosLabel20);
            this.bosPanel2.Controls.Add(this.bosLabel21);
            this.bosPanel2.Controls.Add(this.bosLabel17);
            this.bosPanel2.Controls.Add(this.bosLabel18);
            this.bosPanel2.Controls.Add(this.bosLabel16);
            this.bosPanel2.Controls.Add(this.bosLabel19);
            this.bosPanel2.Controls.Add(this.fld_btnLoadChange);
            this.bosPanel2.Controls.Add(this.bosLine1);
            this.bosPanel2.Controls.Add(this.bosLine2);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(1175, 210);
            this.bosPanel2.TabIndex = 119;
            // 
            // bosLabel20
            // 
            this.bosLabel20.BOSComment = null;
            this.bosLabel20.BOSDataMember = null;
            this.bosLabel20.BOSDataSource = null;
            this.bosLabel20.BOSDescription = null;
            this.bosLabel20.BOSError = null;
            this.bosLabel20.BOSFieldGroup = null;
            this.bosLabel20.BOSFieldRelation = null;
            this.bosLabel20.BOSPrivilege = null;
            this.bosLabel20.BOSPropertyName = null;
            this.bosLabel20.Location = new System.Drawing.Point(359, 183);
            this.bosLabel20.Name = "bosLabel20";
            this.bosLabel20.Screen = null;
            this.bosLabel20.Size = new System.Drawing.Size(48, 13);
            this.bosLabel20.TabIndex = 147;
            this.bosLabel20.Text = "Chỉnh sửa";
            // 
            // bosLabel21
            // 
            this.bosLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel21.Appearance.BackColor = System.Drawing.Color.LightYellow;
            this.bosLabel21.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel21.Appearance.Options.UseBackColor = true;
            this.bosLabel21.Appearance.Options.UseFont = true;
            this.bosLabel21.Appearance.Options.UseForeColor = true;
            this.bosLabel21.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bosLabel21.BOSComment = "";
            this.bosLabel21.BOSDataMember = "ICProductNo";
            this.bosLabel21.BOSDataSource = "ICProducts";
            this.bosLabel21.BOSDescription = null;
            this.bosLabel21.BOSError = null;
            this.bosLabel21.BOSFieldGroup = "";
            this.bosLabel21.BOSFieldRelation = "";
            this.bosLabel21.BOSPrivilege = "";
            this.bosLabel21.BOSPropertyName = "";
            this.bosLabel21.Location = new System.Drawing.Point(327, 183);
            this.bosLabel21.Name = "bosLabel21";
            this.bosLabel21.Screen = null;
            this.bosLabel21.Size = new System.Drawing.Size(23, 15);
            this.bosLabel21.TabIndex = 146;
            this.bosLabel21.Tag = "";
            this.bosLabel21.Text = "       ";
            // 
            // bosLabel17
            // 
            this.bosLabel17.BOSComment = null;
            this.bosLabel17.BOSDataMember = null;
            this.bosLabel17.BOSDataSource = null;
            this.bosLabel17.BOSDescription = null;
            this.bosLabel17.BOSError = null;
            this.bosLabel17.BOSFieldGroup = null;
            this.bosLabel17.BOSFieldRelation = null;
            this.bosLabel17.BOSPrivilege = null;
            this.bosLabel17.BOSPropertyName = null;
            this.bosLabel17.Location = new System.Drawing.Point(277, 183);
            this.bosLabel17.Name = "bosLabel17";
            this.bosLabel17.Screen = null;
            this.bosLabel17.Size = new System.Drawing.Size(37, 13);
            this.bosLabel17.TabIndex = 145;
            this.bosLabel17.Text = "Tạo mới";
            // 
            // bosLabel18
            // 
            this.bosLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel18.Appearance.BackColor = System.Drawing.Color.LightGreen;
            this.bosLabel18.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel18.Appearance.Options.UseBackColor = true;
            this.bosLabel18.Appearance.Options.UseFont = true;
            this.bosLabel18.Appearance.Options.UseForeColor = true;
            this.bosLabel18.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bosLabel18.BOSComment = "";
            this.bosLabel18.BOSDataMember = "ICProductNo";
            this.bosLabel18.BOSDataSource = "ICProducts";
            this.bosLabel18.BOSDescription = null;
            this.bosLabel18.BOSError = null;
            this.bosLabel18.BOSFieldGroup = "";
            this.bosLabel18.BOSFieldRelation = "";
            this.bosLabel18.BOSPrivilege = "";
            this.bosLabel18.BOSPropertyName = "";
            this.bosLabel18.Location = new System.Drawing.Point(245, 183);
            this.bosLabel18.Name = "bosLabel18";
            this.bosLabel18.Screen = null;
            this.bosLabel18.Size = new System.Drawing.Size(23, 15);
            this.bosLabel18.TabIndex = 144;
            this.bosLabel18.Tag = "";
            this.bosLabel18.Text = "       ";
            // 
            // bosLabel16
            // 
            this.bosLabel16.BOSComment = null;
            this.bosLabel16.BOSDataMember = null;
            this.bosLabel16.BOSDataSource = null;
            this.bosLabel16.BOSDescription = null;
            this.bosLabel16.BOSError = null;
            this.bosLabel16.BOSFieldGroup = null;
            this.bosLabel16.BOSFieldRelation = null;
            this.bosLabel16.BOSPrivilege = null;
            this.bosLabel16.BOSPropertyName = null;
            this.bosLabel16.Location = new System.Drawing.Point(211, 183);
            this.bosLabel16.Name = "bosLabel16";
            this.bosLabel16.Screen = null;
            this.bosLabel16.Size = new System.Drawing.Size(18, 13);
            this.bosLabel16.TabIndex = 143;
            this.bosLabel16.Text = "Xóa";
            // 
            // bosLabel19
            // 
            this.bosLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bosLabel19.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.bosLabel19.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel19.Appearance.Options.UseBackColor = true;
            this.bosLabel19.Appearance.Options.UseFont = true;
            this.bosLabel19.Appearance.Options.UseForeColor = true;
            this.bosLabel19.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bosLabel19.BOSComment = "";
            this.bosLabel19.BOSDataMember = "ICProductNo";
            this.bosLabel19.BOSDataSource = "ICProducts";
            this.bosLabel19.BOSDescription = null;
            this.bosLabel19.BOSError = null;
            this.bosLabel19.BOSFieldGroup = "";
            this.bosLabel19.BOSFieldRelation = "";
            this.bosLabel19.BOSPrivilege = "";
            this.bosLabel19.BOSPropertyName = "";
            this.bosLabel19.Location = new System.Drawing.Point(179, 183);
            this.bosLabel19.Name = "bosLabel19";
            this.bosLabel19.Screen = null;
            this.bosLabel19.Size = new System.Drawing.Size(23, 15);
            this.bosLabel19.TabIndex = 142;
            this.bosLabel19.Tag = "";
            this.bosLabel19.Text = "       ";
            // 
            // fld_btnLoadChange
            // 
            this.fld_btnLoadChange.BOSComment = null;
            this.fld_btnLoadChange.BOSDataMember = null;
            this.fld_btnLoadChange.BOSDataSource = null;
            this.fld_btnLoadChange.BOSDescription = null;
            this.fld_btnLoadChange.BOSError = null;
            this.fld_btnLoadChange.BOSFieldGroup = null;
            this.fld_btnLoadChange.BOSFieldRelation = null;
            this.fld_btnLoadChange.BOSPrivilege = null;
            this.fld_btnLoadChange.BOSPropertyName = null;
            this.fld_btnLoadChange.Location = new System.Drawing.Point(5, 177);
            this.fld_btnLoadChange.Name = "fld_btnLoadChange";
            this.fld_btnLoadChange.Screen = null;
            this.fld_btnLoadChange.Size = new System.Drawing.Size(159, 27);
            this.fld_btnLoadChange.TabIndex = 117;
            this.fld_btnLoadChange.Text = "Xem thay đổi";
            this.fld_btnLoadChange.Click += new System.EventHandler(this.fld_btnLoadChange_Click);
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
            this.bosLine1.Controls.Add(this.fld_txtMMMergeBOMChangeNo);
            this.bosLine1.Controls.Add(this.bosLabel7);
            this.bosLine1.Controls.Add(this.fld_lkeMMMergeBOMChangeType);
            this.bosLine1.Controls.Add(this.bosLabel1);
            this.bosLine1.Controls.Add(this.bosLabel6);
            this.bosLine1.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.bosLine1.Controls.Add(this.fld_lkeFK_MMProductionNormApproveLogID);
            this.bosLine1.Controls.Add(this.bosLabel9);
            this.bosLine1.Controls.Add(this.bosLabel4);
            this.bosLine1.Controls.Add(this.fld_dteMMMergeBOMChangeDate);
            this.bosLine1.Controls.Add(this.bosLabel2);
            this.bosLine1.Controls.Add(this.fld_lkeMMMergeBOMChangeStatus);
            this.bosLine1.Controls.Add(this.fld_lkeFK_MMProductionNormID);
            this.bosLine1.Controls.Add(this.bosLabel3);
            this.bosLine1.Controls.Add(this.bosLabel5);
            this.bosLine1.Controls.Add(this.fld_medMMMergeBOMChangeDesc);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(3, 3);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(556, 168);
            this.bosLine1.TabIndex = 115;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Thông tin chung";
            // 
            // fld_txtMMMergeBOMChangeNo
            // 
            this.fld_txtMMMergeBOMChangeNo.BOSComment = null;
            this.fld_txtMMMergeBOMChangeNo.BOSDataMember = "MMMergeBOMChangeNo";
            this.fld_txtMMMergeBOMChangeNo.BOSDataSource = "MMMergeBOMChanges";
            this.fld_txtMMMergeBOMChangeNo.BOSDescription = null;
            this.fld_txtMMMergeBOMChangeNo.BOSError = null;
            this.fld_txtMMMergeBOMChangeNo.BOSFieldGroup = null;
            this.fld_txtMMMergeBOMChangeNo.BOSFieldRelation = null;
            this.fld_txtMMMergeBOMChangeNo.BOSPrivilege = null;
            this.fld_txtMMMergeBOMChangeNo.BOSPropertyName = "EditValue";
            this.fld_txtMMMergeBOMChangeNo.Location = new System.Drawing.Point(94, 20);
            this.fld_txtMMMergeBOMChangeNo.MenuManager = this.screenToolbar;
            this.fld_txtMMMergeBOMChangeNo.Name = "fld_txtMMMergeBOMChangeNo";
            this.fld_txtMMMergeBOMChangeNo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_txtMMMergeBOMChangeNo, true);
            this.fld_txtMMMergeBOMChangeNo.Size = new System.Drawing.Size(171, 20);
            this.fld_txtMMMergeBOMChangeNo.TabIndex = 90;
            this.fld_txtMMMergeBOMChangeNo.Tag = "DC";
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
            this.bosLabel7.Location = new System.Drawing.Point(286, 23);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(72, 13);
            this.bosLabel7.TabIndex = 99;
            this.bosLabel7.Text = "Ngày chứng từ";
            // 
            // fld_lkeMMMergeBOMChangeType
            // 
            this.fld_lkeMMMergeBOMChangeType.BOSAllowAddNew = false;
            this.fld_lkeMMMergeBOMChangeType.BOSAllowDummy = false;
            this.fld_lkeMMMergeBOMChangeType.BOSComment = "";
            this.fld_lkeMMMergeBOMChangeType.BOSDataMember = "MMMergeBOMChangeType";
            this.fld_lkeMMMergeBOMChangeType.BOSDataSource = "MMMergeBOMChanges";
            this.fld_lkeMMMergeBOMChangeType.BOSDescription = null;
            this.fld_lkeMMMergeBOMChangeType.BOSError = null;
            this.fld_lkeMMMergeBOMChangeType.BOSFieldGroup = "";
            this.fld_lkeMMMergeBOMChangeType.BOSFieldParent = "";
            this.fld_lkeMMMergeBOMChangeType.BOSFieldRelation = "";
            this.fld_lkeMMMergeBOMChangeType.BOSPrivilege = "";
            this.fld_lkeMMMergeBOMChangeType.BOSPropertyName = "EditValue";
            this.fld_lkeMMMergeBOMChangeType.BOSSelectType = "";
            this.fld_lkeMMMergeBOMChangeType.BOSSelectTypeValue = "";
            this.fld_lkeMMMergeBOMChangeType.CurrentDisplayText = "";
            this.fld_lkeMMMergeBOMChangeType.Location = new System.Drawing.Point(376, 111);
            this.fld_lkeMMMergeBOMChangeType.Name = "fld_lkeMMMergeBOMChangeType";
            this.fld_lkeMMMergeBOMChangeType.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMMergeBOMChangeType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMMergeBOMChangeType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMMergeBOMChangeType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMMergeBOMChangeType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMMergeBOMChangeType.Properties.NullText = "";
            this.fld_lkeMMMergeBOMChangeType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMMergeBOMChangeType.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMMergeBOMChangeType, true);
            this.fld_lkeMMMergeBOMChangeType.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeMMMergeBOMChangeType.TabIndex = 113;
            this.fld_lkeMMMergeBOMChangeType.Tag = "DC";
            this.fld_lkeMMMergeBOMChangeType.EditValueChanged += new System.EventHandler(this.fld_lkeMMMergeBOMChangeType_EditValueChanged);
            this.fld_lkeMMMergeBOMChangeType.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeMMMergeBOMChangeType_CloseUp);
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
            this.bosLabel1.Location = new System.Drawing.Point(11, 23);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, true);
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 98;
            this.bosLabel1.Text = "Mã chứng từ";
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
            this.bosLabel6.Location = new System.Drawing.Point(286, 114);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel6, true);
            this.bosLabel6.Size = new System.Drawing.Size(61, 13);
            this.bosLabel6.TabIndex = 114;
            this.bosLabel6.Text = "Loại thay đổi";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMMergeBOMChanges";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(94, 46);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 91;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // fld_lkeFK_MMProductionNormApproveLogID
            // 
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSAllowDummy = false;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSComment = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSDataMember = "FK_MMProductionNormApproveLogID";
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSDataSource = "MMMergeBOMChanges";
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSDescription = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSError = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.Location = new System.Drawing.Point(94, 137);
            this.fld_lkeFK_MMProductionNormApproveLogID.Name = "fld_lkeFK_MMProductionNormApproveLogID";
            this.fld_lkeFK_MMProductionNormApproveLogID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionNormApproveLogID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormApproveLogDate", "Ngày duyệt", 20, DevExpress.Utils.FormatType.DateTime, "dd/MM/yyyy HH:mm tt", true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormApproveLogDesc", "Mô tả")});
            this.fld_lkeFK_MMProductionNormApproveLogID.Properties.DisplayMember = "MMProductionNormApproveLogDate";
            this.fld_lkeFK_MMProductionNormApproveLogID.Properties.NullText = "";
            this.fld_lkeFK_MMProductionNormApproveLogID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionNormApproveLogID.Properties.ValueMember = "MMProductionNormApproveLogID";
            this.fld_lkeFK_MMProductionNormApproveLogID.Screen = null;
            this.fld_lkeFK_MMProductionNormApproveLogID.Size = new System.Drawing.Size(453, 20);
            this.fld_lkeFK_MMProductionNormApproveLogID.TabIndex = 111;
            this.fld_lkeFK_MMProductionNormApproveLogID.Tag = "DC";
            this.fld_lkeFK_MMProductionNormApproveLogID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMProductionNormApproveLogID_CloseUp);
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
            this.bosLabel9.Location = new System.Drawing.Point(11, 114);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(22, 13);
            this.bosLabel9.TabIndex = 97;
            this.bosLabel9.Text = "BOM";
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
            this.bosLabel4.Location = new System.Drawing.Point(11, 140);
            this.bosLabel4.Name = "bosLabel4";
            this.bosLabel4.Screen = null;
            this.bosLabel4.Size = new System.Drawing.Size(48, 13);
            this.bosLabel4.TabIndex = 112;
            this.bosLabel4.Text = "Lần duyệt";
            // 
            // fld_dteMMMergeBOMChangeDate
            // 
            this.fld_dteMMMergeBOMChangeDate.BOSComment = "";
            this.fld_dteMMMergeBOMChangeDate.BOSDataMember = "MMMergeBOMChangeDate";
            this.fld_dteMMMergeBOMChangeDate.BOSDataSource = "MMMergeBOMChanges";
            this.fld_dteMMMergeBOMChangeDate.BOSDescription = null;
            this.fld_dteMMMergeBOMChangeDate.BOSError = null;
            this.fld_dteMMMergeBOMChangeDate.BOSFieldGroup = "";
            this.fld_dteMMMergeBOMChangeDate.BOSFieldRelation = "";
            this.fld_dteMMMergeBOMChangeDate.BOSPrivilege = "";
            this.fld_dteMMMergeBOMChangeDate.BOSPropertyName = "EditValue";
            this.fld_dteMMMergeBOMChangeDate.EditValue = null;
            this.fld_dteMMMergeBOMChangeDate.Location = new System.Drawing.Point(376, 20);
            this.fld_dteMMMergeBOMChangeDate.Name = "fld_dteMMMergeBOMChangeDate";
            this.fld_dteMMMergeBOMChangeDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteMMMergeBOMChangeDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteMMMergeBOMChangeDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteMMMergeBOMChangeDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteMMMergeBOMChangeDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteMMMergeBOMChangeDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteMMMergeBOMChangeDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteMMMergeBOMChangeDate, true);
            this.fld_dteMMMergeBOMChangeDate.Size = new System.Drawing.Size(171, 20);
            this.fld_dteMMMergeBOMChangeDate.TabIndex = 92;
            this.fld_dteMMMergeBOMChangeDate.Tag = "DC";
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
            this.bosLabel2.Location = new System.Drawing.Point(11, 49);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(45, 13);
            this.bosLabel2.TabIndex = 100;
            this.bosLabel2.Text = "Người lập";
            // 
            // fld_lkeMMMergeBOMChangeStatus
            // 
            this.fld_lkeMMMergeBOMChangeStatus.BOSAllowAddNew = false;
            this.fld_lkeMMMergeBOMChangeStatus.BOSAllowDummy = false;
            this.fld_lkeMMMergeBOMChangeStatus.BOSComment = "";
            this.fld_lkeMMMergeBOMChangeStatus.BOSDataMember = "MMMergeBOMChangeStatus";
            this.fld_lkeMMMergeBOMChangeStatus.BOSDataSource = "MMMergeBOMChanges";
            this.fld_lkeMMMergeBOMChangeStatus.BOSDescription = null;
            this.fld_lkeMMMergeBOMChangeStatus.BOSError = null;
            this.fld_lkeMMMergeBOMChangeStatus.BOSFieldGroup = "";
            this.fld_lkeMMMergeBOMChangeStatus.BOSFieldParent = "";
            this.fld_lkeMMMergeBOMChangeStatus.BOSFieldRelation = "";
            this.fld_lkeMMMergeBOMChangeStatus.BOSPrivilege = "";
            this.fld_lkeMMMergeBOMChangeStatus.BOSPropertyName = "EditValue";
            this.fld_lkeMMMergeBOMChangeStatus.BOSSelectType = "";
            this.fld_lkeMMMergeBOMChangeStatus.BOSSelectTypeValue = "";
            this.fld_lkeMMMergeBOMChangeStatus.CurrentDisplayText = "";
            this.fld_lkeMMMergeBOMChangeStatus.Location = new System.Drawing.Point(376, 46);
            this.fld_lkeMMMergeBOMChangeStatus.Name = "fld_lkeMMMergeBOMChangeStatus";
            this.fld_lkeMMMergeBOMChangeStatus.Properties.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fld_lkeMMMergeBOMChangeStatus.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMMergeBOMChangeStatus.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMMergeBOMChangeStatus.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMMergeBOMChangeStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMMergeBOMChangeStatus.Properties.NullText = "";
            this.fld_lkeMMMergeBOMChangeStatus.Properties.ReadOnly = true;
            this.fld_lkeMMMergeBOMChangeStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMMergeBOMChangeStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMMergeBOMChangeStatus, true);
            this.fld_lkeMMMergeBOMChangeStatus.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeMMMergeBOMChangeStatus.TabIndex = 108;
            this.fld_lkeMMMergeBOMChangeStatus.Tag = "DC";
            // 
            // fld_lkeFK_MMProductionNormID
            // 
            this.fld_lkeFK_MMProductionNormID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionNormID.BOSAllowDummy = true;
            this.fld_lkeFK_MMProductionNormID.BOSComment = null;
            this.fld_lkeFK_MMProductionNormID.BOSDataMember = "FK_MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.BOSDataSource = "MMMergeBOMChanges";
            this.fld_lkeFK_MMProductionNormID.BOSDescription = null;
            this.fld_lkeFK_MMProductionNormID.BOSError = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionNormID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionNormID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionNormID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionNormID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionNormID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionNormID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionNormID.Location = new System.Drawing.Point(94, 111);
            this.fld_lkeFK_MMProductionNormID.Name = "fld_lkeFK_MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionNormID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormNo", "Mã BOM"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormName", "Tên"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionNormOldProductNo", "Mã HT củ")});
            this.fld_lkeFK_MMProductionNormID.Properties.DisplayMember = "MMProductionNormNo";
            this.fld_lkeFK_MMProductionNormID.Properties.NullText = "";
            this.fld_lkeFK_MMProductionNormID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionNormID.Properties.ValueMember = "MMProductionNormID";
            this.fld_lkeFK_MMProductionNormID.Screen = null;
            this.fld_lkeFK_MMProductionNormID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeFK_MMProductionNormID.TabIndex = 94;
            this.fld_lkeFK_MMProductionNormID.Tag = "DC";
            this.fld_lkeFK_MMProductionNormID.EditValueChanged += new System.EventHandler(this.fld_lkeFK_MMProductionNormID_EditValueChanged);
            this.fld_lkeFK_MMProductionNormID.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.fld_lkeFK_MMProductionNormID_CloseUp);
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
            this.bosLabel3.Location = new System.Drawing.Point(286, 49);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel3, true);
            this.bosLabel3.Size = new System.Drawing.Size(49, 13);
            this.bosLabel3.TabIndex = 109;
            this.bosLabel3.Text = "Tình trạng";
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
            this.bosLabel5.Location = new System.Drawing.Point(11, 75);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel5, true);
            this.bosLabel5.Size = new System.Drawing.Size(40, 13);
            this.bosLabel5.TabIndex = 106;
            this.bosLabel5.Text = "Diễn giải";
            // 
            // fld_medMMMergeBOMChangeDesc
            // 
            this.fld_medMMMergeBOMChangeDesc.BOSComment = null;
            this.fld_medMMMergeBOMChangeDesc.BOSDataMember = "MMMergeBOMChangeDesc";
            this.fld_medMMMergeBOMChangeDesc.BOSDataSource = "MMMergeBOMChanges";
            this.fld_medMMMergeBOMChangeDesc.BOSDescription = null;
            this.fld_medMMMergeBOMChangeDesc.BOSError = null;
            this.fld_medMMMergeBOMChangeDesc.BOSFieldGroup = null;
            this.fld_medMMMergeBOMChangeDesc.BOSFieldRelation = null;
            this.fld_medMMMergeBOMChangeDesc.BOSPrivilege = null;
            this.fld_medMMMergeBOMChangeDesc.BOSPropertyName = "EditValue";
            this.fld_medMMMergeBOMChangeDesc.Location = new System.Drawing.Point(94, 72);
            this.fld_medMMMergeBOMChangeDesc.MenuManager = this.screenToolbar;
            this.fld_medMMMergeBOMChangeDesc.Name = "fld_medMMMergeBOMChangeDesc";
            this.fld_medMMMergeBOMChangeDesc.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_medMMMergeBOMChangeDesc, true);
            this.fld_medMMMergeBOMChangeDesc.Size = new System.Drawing.Size(453, 33);
            this.fld_medMMMergeBOMChangeDesc.TabIndex = 104;
            this.fld_medMMMergeBOMChangeDesc.Tag = "DC";
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
            this.bosLine2.Controls.Add(this.fld_dgcMMMergeBOMChangeBatchProducts);
            this.bosLine2.Controls.Add(this.bosLabel8);
            this.bosLine2.Controls.Add(this.fld_lkeMMBatchProductID);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(565, 3);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(607, 168);
            this.bosLine2.TabIndex = 116;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Thông tin LSX";
            // 
            // fld_dgcMMMergeBOMChangeBatchProducts
            // 
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSComment = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSDataMember = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSDataSource = "MMMergeBOMChangeBatchProducts";
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSDescription = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSError = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSFieldGroup = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSFieldRelation = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSGridType = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSPrivilege = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.BOSPropertyName = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.CommodityType = "";
            this.fld_dgcMMMergeBOMChangeBatchProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMMergeBOMChangeBatchProducts.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcMMMergeBOMChangeBatchProducts.MenuManager = this.screenToolbar;
            this.fld_dgcMMMergeBOMChangeBatchProducts.Name = "fld_dgcMMMergeBOMChangeBatchProducts";
            this.fld_dgcMMMergeBOMChangeBatchProducts.PrintReport = false;
            this.fld_dgcMMMergeBOMChangeBatchProducts.Screen = null;
            this.fld_dgcMMMergeBOMChangeBatchProducts.Size = new System.Drawing.Size(601, 148);
            this.fld_dgcMMMergeBOMChangeBatchProducts.TabIndex = 100;
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
            this.bosLabel8.Location = new System.Drawing.Point(28, 49);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(17, 13);
            this.bosLabel8.TabIndex = 99;
            this.bosLabel8.Text = "LSX";
            this.bosLabel8.Visible = false;
            // 
            // fld_lkeMMBatchProductID
            // 
            this.fld_lkeMMBatchProductID.BOSAllowAddNew = false;
            this.fld_lkeMMBatchProductID.BOSAllowDummy = false;
            this.fld_lkeMMBatchProductID.BOSComment = null;
            this.fld_lkeMMBatchProductID.BOSDataMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.BOSDataSource = "MMBatchProducts";
            this.fld_lkeMMBatchProductID.BOSDescription = null;
            this.fld_lkeMMBatchProductID.BOSError = null;
            this.fld_lkeMMBatchProductID.BOSFieldGroup = null;
            this.fld_lkeMMBatchProductID.BOSFieldParent = null;
            this.fld_lkeMMBatchProductID.BOSFieldRelation = null;
            this.fld_lkeMMBatchProductID.BOSPrivilege = null;
            this.fld_lkeMMBatchProductID.BOSPropertyName = "EditValue";
            this.fld_lkeMMBatchProductID.BOSSelectType = null;
            this.fld_lkeMMBatchProductID.BOSSelectTypeValue = null;
            this.fld_lkeMMBatchProductID.CurrentDisplayText = null;
            this.fld_lkeMMBatchProductID.Location = new System.Drawing.Point(72, 46);
            this.fld_lkeMMBatchProductID.Name = "fld_lkeMMBatchProductID";
            this.fld_lkeMMBatchProductID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMBatchProductID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMBatchProductNo", "Mã LSX")});
            this.fld_lkeMMBatchProductID.Properties.DisplayMember = "MMBatchProductNo";
            this.fld_lkeMMBatchProductID.Properties.NullText = "";
            this.fld_lkeMMBatchProductID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMBatchProductID.Properties.ValueMember = "MMBatchProductID";
            this.fld_lkeMMBatchProductID.Screen = null;
            this.fld_lkeMMBatchProductID.Size = new System.Drawing.Size(171, 20);
            this.fld_lkeMMBatchProductID.TabIndex = 98;
            this.fld_lkeMMBatchProductID.Tag = "DC";
            this.fld_lkeMMBatchProductID.Visible = false;
            this.fld_lkeMMBatchProductID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fld_lkeMMBatchProductID_KeyUp);
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // fld_dgvMMMergeBOMChangeItems
            // 
            this.fld_dgvMMMergeBOMChangeItems.Name = "fld_dgvMMMergeBOMChangeItems";
            this.fld_dgvMMMergeBOMChangeItems.PaintStyleName = "Office2003";
            // 
            // DMMBC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(1175, 527);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMMBC100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_tcChangeInfomation)).EndInit();
            this.fld_tcChangeInfomation.ResumeLayout(false);
            this.fld_tpItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemBOMLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemBPLogs)).EndInit();
            this.fld_tpMaterial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemMaterialBOMLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemMaterialBPLogs)).EndInit();
            this.fld_tpProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemProcessBOMLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeItemProcessBPLogs)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            this.bosLine1.ResumeLayout(false);
            this.bosLine1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMergeBOMChangeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMMergeBOMChangeType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormApproveLogID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMMergeBOMChangeDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteMMMergeBOMChangeDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMMergeBOMChangeStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionNormID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medMMMergeBOMChangeDesc.Properties)).EndInit();
            this.bosLine2.ResumeLayout(false);
            this.bosLine2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChangeBatchProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMBatchProductID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMMergeBOMChangeItems)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionNormID;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSDateEdit fld_dteMMMergeBOMChangeDate;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMMergeBOMChangeNo;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLookupEdit fld_lkeMMMergeBOMChangeStatus;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSMemoEdit fld_medMMMergeBOMChangeDesc;
        private BOSComponent.BOSLabel bosLabel5;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMMergeBOMChangeItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionNormApproveLogID;
        private BOSComponent.BOSLabel bosLabel4;
        private BOSComponent.BOSLookupEdit fld_lkeMMMergeBOMChangeType;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLine bosLine1;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLookupEdit fld_lkeMMBatchProductID;
        private MMMergeBOMChangeBatchProductsGridControl fld_dgcMMMergeBOMChangeBatchProducts;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private BOSComponent.BOSTabControl fld_tcChangeInfomation;
        private DevExpress.XtraTab.XtraTabPage fld_tpItem;
        private DevExpress.XtraTab.XtraTabPage fld_tpMaterial;
        private DevExpress.XtraTab.XtraTabPage fld_tpProcess;
        private BOSComponent.BOSLabel bosLabel10;
        private MMMergeBOMChangeItemBOMLogsGridControl fld_dgcMMMergeBOMChangeItemBOMLogs;
        private BOSComponent.BOSLabel bosLabel11;
        private MMMergeBOMChangeItemBPLogsGridControl fld_dgcMMMergeBOMChangeItemBPLogs;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private BOSComponent.BOSLabel bosLabel12;
        private MMMergeBOMChangeItemMaterialBOMLogsGridControl fld_dgcMMMergeBOMChangeItemMaterialBOMLogs;
        private BOSComponent.BOSLabel bosLabel13;
        private MMMergeBOMChangeItemMaterialBPLogsGridControl fld_dgcMMMergeBOMChangeItemMaterialBPLogs;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private BOSComponent.BOSLabel bosLabel14;
        private MMMergeBOMChangeItemProcessBOMLogsGridControl fld_dgcMMMergeBOMChangeItemProcessBOMLogs;
        private BOSComponent.BOSLabel bosLabel15;
        private MMMergeBOMChangeItemProcessBPLogsGridControl fld_dgcMMMergeBOMChangeItemProcessBPLogs;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSButton fld_btnLoadChange;
        private BOSComponent.BOSLabel bosLabel19;
        private BOSComponent.BOSLabel bosLabel17;
        private BOSComponent.BOSLabel bosLabel18;
        private BOSComponent.BOSLabel bosLabel16;
        private BOSComponent.BOSLabel bosLabel20;
        private BOSComponent.BOSLabel bosLabel21;
	}
}
