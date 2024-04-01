using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductConstant.UI
{
	/// <summary>
	/// Summary description for DMPC101
	/// </summary>
    partial class DMPC119
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMPC119));
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMConfigFalseConditionals = new BOSERP.Modules.ProductConstant.MMConfigFalseConditionalsGridControl();
            this.fld_dgvProductType = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvMMReuseSpecificateConfigs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMConfigFalseConditionals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMReuseSpecificateConfigs)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
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
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMConfigFalseConditionals);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 0);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_grcGroupControl, true);
            this.fld_grcGroupControl.Size = new System.Drawing.Size(890, 581);
            this.fld_grcGroupControl.TabIndex = 6;
            this.fld_grcGroupControl.Text = "Cấu hình danh sách lỗi - Điều kiện - Kết quả";
            // 
            // fld_dgcMMConfigFalseConditionals
            // 
            this.fld_dgcMMConfigFalseConditionals.AllowDrop = true;
            this.fld_dgcMMConfigFalseConditionals.BOSComment = "";
            this.fld_dgcMMConfigFalseConditionals.BOSDataMember = null;
            this.fld_dgcMMConfigFalseConditionals.BOSDataSource = "MMConfigFalseConditionals";
            this.fld_dgcMMConfigFalseConditionals.BOSDescription = null;
            this.fld_dgcMMConfigFalseConditionals.BOSError = "";
            this.fld_dgcMMConfigFalseConditionals.BOSFieldGroup = "";
            this.fld_dgcMMConfigFalseConditionals.BOSFieldRelation = null;
            this.fld_dgcMMConfigFalseConditionals.BOSGridType = null;
            this.fld_dgcMMConfigFalseConditionals.BOSPrivilege = "";
            this.fld_dgcMMConfigFalseConditionals.BOSPropertyName = null;
            this.fld_dgcMMConfigFalseConditionals.CommodityType = "";
            this.fld_dgcMMConfigFalseConditionals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcMMConfigFalseConditionals.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMConfigFalseConditionals.Location = new System.Drawing.Point(2, 23);
            this.fld_dgcMMConfigFalseConditionals.MainView = this.fld_dgvProductType;
            this.fld_dgcMMConfigFalseConditionals.Name = "fld_dgcMMConfigFalseConditionals";
            this.fld_dgcMMConfigFalseConditionals.PrintReport = false;
            this.fld_dgcMMConfigFalseConditionals.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcMMConfigFalseConditionals, true);
            this.fld_dgcMMConfigFalseConditionals.Size = new System.Drawing.Size(886, 556);
            this.fld_dgcMMConfigFalseConditionals.TabIndex = 6;
            this.fld_dgcMMConfigFalseConditionals.Tag = "DC";
            this.fld_dgcMMConfigFalseConditionals.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvProductType});
            // 
            // fld_dgvProductType
            // 
            this.fld_dgvProductType.GridControl = this.fld_dgcMMConfigFalseConditionals;
            this.fld_dgvProductType.Name = "fld_dgvProductType";
            this.fld_dgvProductType.PaintStyleName = "Office2003";
            // 
            // fld_dgvMMReuseSpecificateConfigs
            // 
            this.fld_dgvMMReuseSpecificateConfigs.Name = "fld_dgvMMReuseSpecificateConfigs";
            this.fld_dgvMMReuseSpecificateConfigs.PaintStyleName = "Office2003";
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
            this.bosPanel1.Size = new System.Drawing.Size(890, 581);
            this.bosPanel1.TabIndex = 7;
            // 
            // DMPC119
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(890, 581);
            this.Controls.Add(this.bosPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("DMPC119.IconOptions.Icon")));
            this.Name = "DMPC119";
            this.Text = "Cấu hình danh sách lỗi - Điều kiện - Kết quả";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMConfigFalseConditionals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvProductType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMReuseSpecificateConfigs)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMReuseSpecificateConfigs;
        private IContainer components;
        private MMConfigFalseConditionalsGridControl fld_dgcMMConfigFalseConditionals;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvProductType;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
