using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CompanyConstant.UI
{
	/// <summary>
	/// Summary description for DMCS100
	/// </summary>
    partial class DMCS119
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
            this.bosLine2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcACEInvoiceTypes = new BOSERP.Modules.CompanyConstant.ACEInvoiceTypesGridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcAPPurchaseContractGroups = new BOSERP.Modules.CompanyConstant.APPurchaseContractGroupsGridControl();
            this.bosPanel1.SuspendLayout();
            this.bosLine2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseContractGroups)).BeginInit();
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
            this.bosPanel1.Controls.Add(this.bosLine2);
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(815, 763);
            this.bosPanel1.TabIndex = 334;
            // 
            // bosLine2
            // 
            this.bosLine2.BOSComment = null;
            this.bosLine2.BOSDataMember = null;
            this.bosLine2.BOSDataSource = null;
            this.bosLine2.BOSDescription = null;
            this.bosLine2.BOSError = null;
            this.bosLine2.BOSFieldGroup = null;
            this.bosLine2.BOSFieldRelation = null;
            this.bosLine2.BOSPrivilege = null;
            this.bosLine2.BOSPropertyName = null;
            this.bosLine2.Controls.Add(this.fld_dgcACEInvoiceTypes);
            this.bosLine2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine2.Location = new System.Drawing.Point(11, 250);
            this.bosLine2.Name = "bosLine2";
            this.bosLine2.Screen = null;
            this.bosLine2.Size = new System.Drawing.Size(786, 232);
            this.bosLine2.TabIndex = 65;
            this.bosLine2.TabStop = false;
            this.bosLine2.Text = "Danh sách Mã hóa đơn GTGT";
            // 
            // fld_dgcACEInvoiceTypes
            // 
            this.fld_dgcACEInvoiceTypes.AllowDrop = true;
            this.fld_dgcACEInvoiceTypes.BOSComment = "";
            this.fld_dgcACEInvoiceTypes.BOSDataMember = null;
            this.fld_dgcACEInvoiceTypes.BOSDataSource = "ACEInvoiceTypes";
            this.fld_dgcACEInvoiceTypes.BOSDescription = null;
            this.fld_dgcACEInvoiceTypes.BOSError = "";
            this.fld_dgcACEInvoiceTypes.BOSFieldGroup = "";
            this.fld_dgcACEInvoiceTypes.BOSFieldRelation = null;
            this.fld_dgcACEInvoiceTypes.BOSGridType = null;
            this.fld_dgcACEInvoiceTypes.BOSPrivilege = "";
            this.fld_dgcACEInvoiceTypes.BOSPropertyName = null;
            this.fld_dgcACEInvoiceTypes.CommodityType = "";
            this.fld_dgcACEInvoiceTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcACEInvoiceTypes.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACEInvoiceTypes.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcACEInvoiceTypes.MainView = this.gridView2;
            this.fld_dgcACEInvoiceTypes.Name = "fld_dgcACEInvoiceTypes";
            this.fld_dgcACEInvoiceTypes.PrintReport = false;
            this.fld_dgcACEInvoiceTypes.Screen = null;
            this.fld_dgcACEInvoiceTypes.Size = new System.Drawing.Size(780, 212);
            this.fld_dgcACEInvoiceTypes.TabIndex = 63;
            this.fld_dgcACEInvoiceTypes.Tag = "DC";
            this.fld_dgcACEInvoiceTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcACEInvoiceTypes;
            this.gridView2.Name = "gridView2";
            this.gridView2.PaintStyleName = "Office2003";
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
            this.bosLine1.Controls.Add(this.fld_dgcAPPurchaseContractGroups);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(11, 12);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.bosLine1.Size = new System.Drawing.Size(786, 232);
            this.bosLine1.TabIndex = 64;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Nhóm hợp đồng mua";
            // 
            // fld_dgcAPPurchaseContractGroups
            // 
            this.fld_dgcAPPurchaseContractGroups.BOSComment = null;
            this.fld_dgcAPPurchaseContractGroups.BOSDataMember = null;
            this.fld_dgcAPPurchaseContractGroups.BOSDataSource = "APPurchaseContractGroups";
            this.fld_dgcAPPurchaseContractGroups.BOSDescription = null;
            this.fld_dgcAPPurchaseContractGroups.BOSError = null;
            this.fld_dgcAPPurchaseContractGroups.BOSFieldGroup = null;
            this.fld_dgcAPPurchaseContractGroups.BOSFieldRelation = null;
            this.fld_dgcAPPurchaseContractGroups.BOSGridType = null;
            this.fld_dgcAPPurchaseContractGroups.BOSPrivilege = null;
            this.fld_dgcAPPurchaseContractGroups.BOSPropertyName = null;
            this.fld_dgcAPPurchaseContractGroups.CommodityType = "";
            this.fld_dgcAPPurchaseContractGroups.Location = new System.Drawing.Point(3, 21);
            this.fld_dgcAPPurchaseContractGroups.MenuManager = this.screenToolbar;
            this.fld_dgcAPPurchaseContractGroups.Name = "fld_dgcAPPurchaseContractGroups";
            this.fld_dgcAPPurchaseContractGroups.PrintReport = false;
            this.fld_dgcAPPurchaseContractGroups.Screen = null;
            this.fld_dgcAPPurchaseContractGroups.Size = new System.Drawing.Size(777, 204);
            this.fld_dgcAPPurchaseContractGroups.TabIndex = 0;
            // 
            // DMCS119
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(815, 763);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMCS119";
            this.Text = "Cấu hình công ty";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.bosPanel1.ResumeLayout(false);
            this.bosLine2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACEInvoiceTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseContractGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
        private BOSComponent.BOSLine bosLine1;
        private APPurchaseContractGroupsGridControl fld_dgcAPPurchaseContractGroups;
        private BOSComponent.BOSLine bosLine2;
        private CompanyConstant.ACEInvoiceTypesGridControl fld_dgcACEInvoiceTypes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}
