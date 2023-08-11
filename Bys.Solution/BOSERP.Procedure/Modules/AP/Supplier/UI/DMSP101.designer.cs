using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Supplier.UI
{
	/// <summary>
	/// Summary description for DMSP101
	/// </summary>
	partial class DMSP101
	{
		private BOSComponent.BOSLabel fld_lblLabel18;
		private BOSComponent.BOSLabel fld_lblLabel19;
		private BOSComponent.BOSButton fld_btnHistoryFilter;
		private BOSComponent.BOSLabel fld_lblLabel20;
		private BOSComponent.BOSLabel fld_lblLabel21;
		private BOSComponent.BOSLabel fld_lblLabel22;
        private BOSComponent.BOSLabel fld_lblLabel23;


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
            this.fld_lblLabel18 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel19 = new BOSComponent.BOSLabel(this.components);
            this.fld_btnHistoryFilter = new BOSComponent.BOSButton(this.components);
            this.fld_lblLabel20 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel21 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel22 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel23 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHistoryDateFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteHistoryDateTo = new BOSComponent.BOSDateEdit(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.bosLabel6 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel5 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.bosLine3 = new BOSComponent.BOSLine(this.components);
            this.bosLabel8 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcICReceipts = new BOSERP.Modules.Supplier.ICReceiptsGridControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.fld_dgcAPPurchaseOrders = new BOSERP.Modules.Supplier.APPurchaseOrdersGridControl();
            this.bosTabControl1 = new BOSComponent.BOSTabControl(this.components);
            this.bosPanel3 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceipts)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).BeginInit();
            this.bosTabControl1.SuspendLayout();
            this.bosPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_lblLabel18
            // 
            this.fld_lblLabel18.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel18.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel18.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel18.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel18.BOSComment = "";
            this.fld_lblLabel18.BOSDataMember = "";
            this.fld_lblLabel18.BOSDataSource = "";
            this.fld_lblLabel18.BOSDescription = null;
            this.fld_lblLabel18.BOSError = null;
            this.fld_lblLabel18.BOSFieldGroup = "";
            this.fld_lblLabel18.BOSFieldRelation = "";
            this.fld_lblLabel18.BOSPrivilege = "";
            this.fld_lblLabel18.BOSPropertyName = "";
            this.fld_lblLabel18.Location = new System.Drawing.Point(15, 14);
            this.fld_lblLabel18.Name = "fld_lblLabel18";
            this.fld_lblLabel18.Screen = null;
            this.fld_lblLabel18.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel18.TabIndex = 4;
            this.fld_lblLabel18.Tag = "";
            this.fld_lblLabel18.Text = "Từ ngày";
            // 
            // fld_lblLabel19
            // 
            this.fld_lblLabel19.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel19.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel19.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel19.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel19.BOSComment = "";
            this.fld_lblLabel19.BOSDataMember = "";
            this.fld_lblLabel19.BOSDataSource = "";
            this.fld_lblLabel19.BOSDescription = null;
            this.fld_lblLabel19.BOSError = null;
            this.fld_lblLabel19.BOSFieldGroup = "";
            this.fld_lblLabel19.BOSFieldRelation = "";
            this.fld_lblLabel19.BOSPrivilege = "";
            this.fld_lblLabel19.BOSPropertyName = "";
            this.fld_lblLabel19.Location = new System.Drawing.Point(287, 14);
            this.fld_lblLabel19.Name = "fld_lblLabel19";
            this.fld_lblLabel19.Screen = null;
            this.fld_lblLabel19.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel19.TabIndex = 5;
            this.fld_lblLabel19.Tag = "";
            this.fld_lblLabel19.Text = "Đến";
            // 
            // fld_btnHistoryFilter
            // 
            this.fld_btnHistoryFilter.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnHistoryFilter.Appearance.Options.UseForeColor = true;
            this.fld_btnHistoryFilter.BOSComment = "";
            this.fld_btnHistoryFilter.BOSDataMember = "";
            this.fld_btnHistoryFilter.BOSDataSource = "";
            this.fld_btnHistoryFilter.BOSDescription = null;
            this.fld_btnHistoryFilter.BOSError = null;
            this.fld_btnHistoryFilter.BOSFieldGroup = "";
            this.fld_btnHistoryFilter.BOSFieldRelation = "";
            this.fld_btnHistoryFilter.BOSPrivilege = "";
            this.fld_btnHistoryFilter.BOSPropertyName = "";
            this.fld_btnHistoryFilter.Location = new System.Drawing.Point(487, 8);
            this.fld_btnHistoryFilter.Name = "fld_btnHistoryFilter";
            this.fld_btnHistoryFilter.Screen = null;
            this.fld_btnHistoryFilter.Size = new System.Drawing.Size(75, 27);
            this.fld_btnHistoryFilter.TabIndex = 2;
            this.fld_btnHistoryFilter.Tag = "";
            this.fld_btnHistoryFilter.Text = "Tìm kiếm";
            this.fld_btnHistoryFilter.Click += new System.EventHandler(this.fld_btnHistoryFilter_Click);
            // 
            // fld_lblLabel20
            // 
            this.fld_lblLabel20.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel20.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel20.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel20.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel20.BOSComment = "";
            this.fld_lblLabel20.BOSDataMember = "";
            this.fld_lblLabel20.BOSDataSource = "";
            this.fld_lblLabel20.BOSDescription = null;
            this.fld_lblLabel20.BOSError = null;
            this.fld_lblLabel20.BOSFieldGroup = "";
            this.fld_lblLabel20.BOSFieldRelation = "";
            this.fld_lblLabel20.BOSPrivilege = "";
            this.fld_lblLabel20.BOSPropertyName = "";
            this.fld_lblLabel20.Location = new System.Drawing.Point(14, 40);
            this.fld_lblLabel20.Name = "fld_lblLabel20";
            this.fld_lblLabel20.Screen = null;
            this.fld_lblLabel20.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel20.TabIndex = 7;
            this.fld_lblLabel20.Tag = "";
            this.fld_lblLabel20.Text = "Số tiền";
            // 
            // fld_lblLabel21
            // 
            this.fld_lblLabel21.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel21.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel21.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel21.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel21.BOSComment = "";
            this.fld_lblLabel21.BOSDataMember = "";
            this.fld_lblLabel21.BOSDataSource = "";
            this.fld_lblLabel21.BOSDescription = null;
            this.fld_lblLabel21.BOSError = null;
            this.fld_lblLabel21.BOSFieldGroup = "";
            this.fld_lblLabel21.BOSFieldRelation = "";
            this.fld_lblLabel21.BOSPrivilege = "";
            this.fld_lblLabel21.BOSPropertyName = "";
            this.fld_lblLabel21.Location = new System.Drawing.Point(14, 71);
            this.fld_lblLabel21.Name = "fld_lblLabel21";
            this.fld_lblLabel21.Screen = null;
            this.fld_lblLabel21.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel21.TabIndex = 8;
            this.fld_lblLabel21.Tag = "";
            this.fld_lblLabel21.Text = "Số lượng";
            // 
            // fld_lblLabel22
            // 
            this.fld_lblLabel22.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel22.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel22.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel22.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel22.BOSComment = "";
            this.fld_lblLabel22.BOSDataMember = "";
            this.fld_lblLabel22.BOSDataSource = "";
            this.fld_lblLabel22.BOSDescription = null;
            this.fld_lblLabel22.BOSError = null;
            this.fld_lblLabel22.BOSFieldGroup = "";
            this.fld_lblLabel22.BOSFieldRelation = "";
            this.fld_lblLabel22.BOSPrivilege = "";
            this.fld_lblLabel22.BOSPropertyName = "";
            this.fld_lblLabel22.Location = new System.Drawing.Point(15, 41);
            this.fld_lblLabel22.Name = "fld_lblLabel22";
            this.fld_lblLabel22.Screen = null;
            this.fld_lblLabel22.Size = new System.Drawing.Size(33, 13);
            this.fld_lblLabel22.TabIndex = 9;
            this.fld_lblLabel22.Tag = "";
            this.fld_lblLabel22.Text = "Số tiền";
            // 
            // fld_lblLabel23
            // 
            this.fld_lblLabel23.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel23.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel23.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel23.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel23.BOSComment = "";
            this.fld_lblLabel23.BOSDataMember = "";
            this.fld_lblLabel23.BOSDataSource = "";
            this.fld_lblLabel23.BOSDescription = null;
            this.fld_lblLabel23.BOSError = null;
            this.fld_lblLabel23.BOSFieldGroup = "";
            this.fld_lblLabel23.BOSFieldRelation = "";
            this.fld_lblLabel23.BOSPrivilege = "";
            this.fld_lblLabel23.BOSPropertyName = "";
            this.fld_lblLabel23.Location = new System.Drawing.Point(15, 72);
            this.fld_lblLabel23.Name = "fld_lblLabel23";
            this.fld_lblLabel23.Screen = null;
            this.fld_lblLabel23.Size = new System.Drawing.Size(42, 13);
            this.fld_lblLabel23.TabIndex = 10;
            this.fld_lblLabel23.Tag = "";
            this.fld_lblLabel23.Text = "Số lượng";
            // 
            // fld_dteHistoryDateFrom
            // 
            this.fld_dteHistoryDateFrom.BOSComment = null;
            this.fld_dteHistoryDateFrom.BOSDataMember = null;
            this.fld_dteHistoryDateFrom.BOSDataSource = null;
            this.fld_dteHistoryDateFrom.BOSDescription = null;
            this.fld_dteHistoryDateFrom.BOSError = null;
            this.fld_dteHistoryDateFrom.BOSFieldGroup = null;
            this.fld_dteHistoryDateFrom.BOSFieldRelation = null;
            this.fld_dteHistoryDateFrom.BOSPrivilege = null;
            this.fld_dteHistoryDateFrom.BOSPropertyName = null;
            this.fld_dteHistoryDateFrom.EditValue = null;
            this.fld_dteHistoryDateFrom.Location = new System.Drawing.Point(91, 11);
            this.fld_dteHistoryDateFrom.MenuManager = this.screenToolbar;
            this.fld_dteHistoryDateFrom.Name = "fld_dteHistoryDateFrom";
            this.fld_dteHistoryDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHistoryDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHistoryDateFrom.Screen = null;
            this.fld_dteHistoryDateFrom.Size = new System.Drawing.Size(125, 20);
            this.fld_dteHistoryDateFrom.TabIndex = 0;
            // 
            // fld_dteHistoryDateTo
            // 
            this.fld_dteHistoryDateTo.BOSComment = null;
            this.fld_dteHistoryDateTo.BOSDataMember = null;
            this.fld_dteHistoryDateTo.BOSDataSource = null;
            this.fld_dteHistoryDateTo.BOSDescription = null;
            this.fld_dteHistoryDateTo.BOSError = null;
            this.fld_dteHistoryDateTo.BOSFieldGroup = null;
            this.fld_dteHistoryDateTo.BOSFieldRelation = null;
            this.fld_dteHistoryDateTo.BOSPrivilege = null;
            this.fld_dteHistoryDateTo.BOSPropertyName = null;
            this.fld_dteHistoryDateTo.EditValue = null;
            this.fld_dteHistoryDateTo.Location = new System.Drawing.Point(330, 11);
            this.fld_dteHistoryDateTo.Name = "fld_dteHistoryDateTo";
            this.fld_dteHistoryDateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHistoryDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHistoryDateTo.Screen = null;
            this.fld_dteHistoryDateTo.Size = new System.Drawing.Size(125, 20);
            this.fld_dteHistoryDateTo.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.fld_dteHistoryDateTo);
            this.panelControl1.Controls.Add(this.fld_btnHistoryFilter);
            this.panelControl1.Controls.Add(this.fld_lblLabel19);
            this.panelControl1.Controls.Add(this.fld_dteHistoryDateFrom);
            this.panelControl1.Controls.Add(this.fld_lblLabel18);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(962, 43);
            this.panelControl1.TabIndex = 17;
            // 
            // bosPanel1
            // 
            this.bosPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.bosLabel6);
            this.bosPanel1.Controls.Add(this.bosLabel5);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLabel20);
            this.bosPanel1.Controls.Add(this.fld_lblLabel21);
            this.bosPanel1.Location = new System.Drawing.Point(3, 52);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(295, 120);
            this.bosPanel1.TabIndex = 18;
            // 
            // bosLine2
            // 
            this.bosLine2.BackColor = System.Drawing.Color.Transparent;
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Location = new System.Drawing.Point(3, 20);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(288, 10);
            this.bosLine2.TabIndex = 21;
            this.bosLine2.TabStop = false;
            // 
            // bosLabel6
            // 
            this.bosLabel6.BOSComment = null;
            this.bosLabel6.BOSDataMember = "TotalOrderQty";
            this.bosLabel6.BOSDataSource = "APSuppliers";
            this.bosLabel6.BOSDescription = null;
            this.bosLabel6.BOSError = null;
            this.bosLabel6.BOSFieldGroup = null;
            this.bosLabel6.BOSFieldRelation = null;
            this.bosLabel6.BOSPrivilege = null;
            this.bosLabel6.BOSPropertyName = null;
            this.bosLabel6.Location = new System.Drawing.Point(84, 72);
            this.bosLabel6.Name = "bosLabel6";
            this.bosLabel6.Screen = null;
            this.bosLabel6.Size = new System.Drawing.Size(6, 13);
            this.bosLabel6.TabIndex = 20;
            this.bosLabel6.Text = "0";
            // 
            // bosLabel5
            // 
            this.bosLabel5.BOSComment = null;
            this.bosLabel5.BOSDataMember = "TotalOrderCost";
            this.bosLabel5.BOSDataSource = "APSuppliers";
            this.bosLabel5.BOSDescription = null;
            this.bosLabel5.BOSError = null;
            this.bosLabel5.BOSFieldGroup = null;
            this.bosLabel5.BOSFieldRelation = null;
            this.bosLabel5.BOSPrivilege = null;
            this.bosLabel5.BOSPropertyName = null;
            this.bosLabel5.Location = new System.Drawing.Point(84, 40);
            this.bosLabel5.Name = "bosLabel5";
            this.bosLabel5.Screen = null;
            this.bosLabel5.Size = new System.Drawing.Size(6, 13);
            this.bosLabel5.TabIndex = 20;
            this.bosLabel5.Text = "0";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(61, 7);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(154, 13);
            this.bosLabel1.TabIndex = 19;
            this.bosLabel1.Text = "Tổng số trên đơn mua hàng";
            // 
            // bosPanel2
            // 
            this.bosPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bosPanel2.BOSComment = null;
            this.bosPanel2.BOSDataMember = null;
            this.bosPanel2.BOSDataSource = null;
            this.bosPanel2.BOSDescription = null;
            this.bosPanel2.BOSError = null;
            this.bosPanel2.BOSFieldGroup = null;
            this.bosPanel2.BOSFieldRelation = null;
            this.bosPanel2.BOSPrivilege = null;
            this.bosPanel2.BOSPropertyName = null;
            this.bosPanel2.Controls.Add(this.bosLine3);
            this.bosPanel2.Controls.Add(this.bosLabel8);
            this.bosPanel2.Controls.Add(this.bosLabel2);
            this.bosPanel2.Controls.Add(this.bosLabel7);
            this.bosPanel2.Controls.Add(this.fld_lblLabel22);
            this.bosPanel2.Controls.Add(this.fld_lblLabel23);
            this.bosPanel2.Location = new System.Drawing.Point(304, 52);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(274, 120);
            this.bosPanel2.TabIndex = 18;
            // 
            // bosLine3
            // 
            this.bosLine3.BackColor = System.Drawing.Color.Transparent;
            this.bosLine3.BOSComment = null;
            this.bosLine3.BOSDataMember = null;
            this.bosLine3.BOSDataSource = null;
            this.bosLine3.BOSDescription = null;
            this.bosLine3.BOSError = null;
            this.bosLine3.BOSFieldGroup = null;
            this.bosLine3.BOSFieldRelation = null;
            this.bosLine3.BOSPrivilege = null;
            this.bosLine3.BOSPropertyName = null;
            this.bosLine3.Location = new System.Drawing.Point(3, 20);
            this.bosLine3.Name = "bosLine3";
            this.bosLine3.Screen = null;
            this.bosLine3.Size = new System.Drawing.Size(265, 10);
            this.bosLine3.TabIndex = 21;
            this.bosLine3.TabStop = false;
            // 
            // bosLabel8
            // 
            this.bosLabel8.BOSComment = null;
            this.bosLabel8.BOSDataMember = "TotalPurchaseQty";
            this.bosLabel8.BOSDataSource = "APSuppliers";
            this.bosLabel8.BOSDescription = null;
            this.bosLabel8.BOSError = null;
            this.bosLabel8.BOSFieldGroup = null;
            this.bosLabel8.BOSFieldRelation = null;
            this.bosLabel8.BOSPrivilege = null;
            this.bosLabel8.BOSPropertyName = null;
            this.bosLabel8.Location = new System.Drawing.Point(113, 72);
            this.bosLabel8.Name = "bosLabel8";
            this.bosLabel8.Screen = null;
            this.bosLabel8.Size = new System.Drawing.Size(6, 13);
            this.bosLabel8.TabIndex = 20;
            this.bosLabel8.Text = "0";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(78, 7);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(119, 13);
            this.bosLabel2.TabIndex = 19;
            this.bosLabel2.Text = "Tổng số trên hóa đơn";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = "TotalPurchaseCost";
            this.bosLabel7.BOSDataSource = "APSuppliers";
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(113, 41);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.bosLabel7.Size = new System.Drawing.Size(6, 13);
            this.bosLabel7.TabIndex = 20;
            this.bosLabel7.Text = "0";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.fld_dgcICReceipts);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(941, 329);
            this.xtraTabPage2.Text = "Danh sách nhập kho";
            // 
            // fld_dgcICReceipts
            // 
            this.fld_dgcICReceipts.BOSComment = null;
            this.fld_dgcICReceipts.BOSDataMember = null;
            this.fld_dgcICReceipts.BOSDataSource = "ICReceipts";
            this.fld_dgcICReceipts.BOSDescription = null;
            this.fld_dgcICReceipts.BOSError = null;
            this.fld_dgcICReceipts.BOSFieldGroup = null;
            this.fld_dgcICReceipts.BOSFieldRelation = null;
            this.fld_dgcICReceipts.BOSGridType = null;
            this.fld_dgcICReceipts.BOSPrivilege = null;
            this.fld_dgcICReceipts.BOSPropertyName = null;
            this.fld_dgcICReceipts.CommodityType = "";
            this.fld_dgcICReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcICReceipts.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcICReceipts.MenuManager = this.screenToolbar;
            this.fld_dgcICReceipts.Name = "fld_dgcICReceipts";
            this.fld_dgcICReceipts.PrintReport = false;
            this.fld_dgcICReceipts.Screen = null;
            this.fld_dgcICReceipts.Size = new System.Drawing.Size(941, 329);
            this.fld_dgcICReceipts.TabIndex = 0;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.fld_dgcAPPurchaseOrders);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(941, 329);
            this.xtraTabPage1.Text = "Danh sách đơn mua hàng";
            // 
            // fld_dgcAPPurchaseOrders
            // 
            this.fld_dgcAPPurchaseOrders.BOSComment = null;
            this.fld_dgcAPPurchaseOrders.BOSDataMember = null;
            this.fld_dgcAPPurchaseOrders.BOSDataSource = "APPurchaseOrders";
            this.fld_dgcAPPurchaseOrders.BOSDescription = null;
            this.fld_dgcAPPurchaseOrders.BOSError = null;
            this.fld_dgcAPPurchaseOrders.BOSFieldGroup = null;
            this.fld_dgcAPPurchaseOrders.BOSFieldRelation = null;
            this.fld_dgcAPPurchaseOrders.BOSGridType = null;
            this.fld_dgcAPPurchaseOrders.BOSPrivilege = null;
            this.fld_dgcAPPurchaseOrders.BOSPropertyName = null;
            this.fld_dgcAPPurchaseOrders.CommodityType = "";
            this.fld_dgcAPPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcAPPurchaseOrders.Location = new System.Drawing.Point(0, 0);
            this.fld_dgcAPPurchaseOrders.MenuManager = this.screenToolbar;
            this.fld_dgcAPPurchaseOrders.Name = "fld_dgcAPPurchaseOrders";
            this.fld_dgcAPPurchaseOrders.PrintReport = false;
            this.fld_dgcAPPurchaseOrders.Screen = null;
            this.fld_dgcAPPurchaseOrders.Size = new System.Drawing.Size(941, 329);
            this.fld_dgcAPPurchaseOrders.TabIndex = 19;
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
            this.bosTabControl1.Location = new System.Drawing.Point(3, 178);
            this.bosTabControl1.Name = "bosTabControl1";
            this.bosTabControl1.Screen = null;
            this.bosTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.bosTabControl1.Size = new System.Drawing.Size(947, 357);
            this.bosTabControl1.TabIndex = 20;
            this.bosTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // bosPanel3
            // 
            this.bosPanel3.BOSComment = null;
            this.bosPanel3.BOSDataMember = null;
            this.bosPanel3.BOSDataSource = null;
            this.bosPanel3.BOSDescription = null;
            this.bosPanel3.BOSError = null;
            this.bosPanel3.BOSFieldGroup = null;
            this.bosPanel3.BOSFieldRelation = null;
            this.bosPanel3.BOSPrivilege = null;
            this.bosPanel3.BOSPropertyName = null;
            this.bosPanel3.Controls.Add(this.panelControl1);
            this.bosPanel3.Controls.Add(this.bosPanel1);
            this.bosPanel3.Controls.Add(this.bosPanel2);
            this.bosPanel3.Controls.Add(this.bosTabControl1);
            this.bosPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel3.Location = new System.Drawing.Point(0, 0);
            this.bosPanel3.Name = "bosPanel3";
            this.bosPanel3.Screen = null;
            this.bosPanel3.Size = new System.Drawing.Size(962, 574);
            this.bosPanel3.TabIndex = 21;
            // 
            // DMSP101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(962, 574);
            this.Controls.Add(this.bosPanel3);
            this.Name = "DMSP101";
            this.Text = "Lịch sử mua hàng";
            this.Controls.SetChildIndex(this.bosPanel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHistoryDateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICReceipts)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTabControl1)).EndInit();
            this.bosTabControl1.ResumeLayout(false);
            this.bosPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSDateEdit fld_dteHistoryDateFrom;
        private IContainer components;
        private BOSComponent.BOSDateEdit fld_dteHistoryDateTo;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel6;
        private BOSComponent.BOSLabel bosLabel5;
        private BOSComponent.BOSLabel bosLabel8;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLine bosLine2;
        private BOSComponent.BOSLine bosLine3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private ICReceiptsGridControl fld_dgcICReceipts;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private APPurchaseOrdersGridControl fld_dgcAPPurchaseOrders;
        private BOSComponent.BOSTabControl bosTabControl1;
        private BOSComponent.BOSPanel bosPanel3;
	}
}
