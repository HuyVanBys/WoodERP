using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using BOSComponent;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
    /// Summary description for DMHM113
	/// </summary>
    partial class DMHM113
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
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteBatchProductFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteBatchProductToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcMMBatchProductsGridControl = new BOSERP.Modules.Home.MMBatchProductsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteBatchProductFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteBatchProductFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteBatchProductToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteBatchProductToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProductsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            this.SuspendLayout();
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
            this.bosPanel2.Controls.Add(this.fld_dteBatchProductFromDate);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteBatchProductToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 50);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_dteBatchProductFromDate
            // 
            this.fld_dteBatchProductFromDate.BOSComment = null;
            this.fld_dteBatchProductFromDate.BOSDataMember = "DateEdit";
            this.fld_dteBatchProductFromDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteBatchProductFromDate.BOSDescription = null;
            this.fld_dteBatchProductFromDate.BOSError = null;
            this.fld_dteBatchProductFromDate.BOSFieldGroup = null;
            this.fld_dteBatchProductFromDate.BOSFieldRelation = null;
            this.fld_dteBatchProductFromDate.BOSPrivilege = null;
            this.fld_dteBatchProductFromDate.BOSPropertyName = "EditValue";
            this.fld_dteBatchProductFromDate.EditValue = null;
            this.fld_dteBatchProductFromDate.Location = new System.Drawing.Point(90, 15);
            this.fld_dteBatchProductFromDate.Name = "fld_dteBatchProductFromDate";
            this.fld_dteBatchProductFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteBatchProductFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteBatchProductFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteBatchProductFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteBatchProductFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteBatchProductFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteBatchProductFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteBatchProductFromDate, true);
            this.fld_dteBatchProductFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteBatchProductFromDate.TabIndex = 0;
            this.fld_dteBatchProductFromDate.Tag = "DC";
            // 
            // fld_lblLabel61
            // 
            this.fld_lblLabel61.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel61.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel61.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel61.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel61.BOSComment = null;
            this.fld_lblLabel61.BOSDataMember = null;
            this.fld_lblLabel61.BOSDataSource = null;
            this.fld_lblLabel61.BOSDescription = null;
            this.fld_lblLabel61.BOSError = null;
            this.fld_lblLabel61.BOSFieldGroup = null;
            this.fld_lblLabel61.BOSFieldRelation = null;
            this.fld_lblLabel61.BOSPrivilege = null;
            this.fld_lblLabel61.BOSPropertyName = null;
            this.fld_lblLabel61.Location = new System.Drawing.Point(23, 18);
            this.fld_lblLabel61.Name = "fld_lblLabel61";
            this.fld_lblLabel61.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel61, true);
            this.fld_lblLabel61.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel61.TabIndex = 17;
            this.fld_lblLabel61.Text = "Từ ngày";
            // 
            // fld_lblLabel62
            // 
            this.fld_lblLabel62.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel62.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel62.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel62.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel62.BOSComment = null;
            this.fld_lblLabel62.BOSDataMember = null;
            this.fld_lblLabel62.BOSDataSource = null;
            this.fld_lblLabel62.BOSDescription = null;
            this.fld_lblLabel62.BOSError = null;
            this.fld_lblLabel62.BOSFieldGroup = null;
            this.fld_lblLabel62.BOSFieldRelation = null;
            this.fld_lblLabel62.BOSPrivilege = null;
            this.fld_lblLabel62.BOSPropertyName = null;
            this.fld_lblLabel62.Location = new System.Drawing.Point(267, 18);
            this.fld_lblLabel62.Name = "fld_lblLabel62";
            this.fld_lblLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel62, true);
            this.fld_lblLabel62.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel62.TabIndex = 18;
            this.fld_lblLabel62.Text = "Đến ngày";
            // 
            // fld_dteBatchProductToDate
            // 
            this.fld_dteBatchProductToDate.BOSComment = null;
            this.fld_dteBatchProductToDate.BOSDataMember = "DateEdit";
            this.fld_dteBatchProductToDate.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_dteBatchProductToDate.BOSDescription = null;
            this.fld_dteBatchProductToDate.BOSError = null;
            this.fld_dteBatchProductToDate.BOSFieldGroup = null;
            this.fld_dteBatchProductToDate.BOSFieldRelation = null;
            this.fld_dteBatchProductToDate.BOSPrivilege = null;
            this.fld_dteBatchProductToDate.BOSPropertyName = "EditValue";
            this.fld_dteBatchProductToDate.EditValue = null;
            this.fld_dteBatchProductToDate.Location = new System.Drawing.Point(339, 15);
            this.fld_dteBatchProductToDate.Name = "fld_dteBatchProductToDate";
            this.fld_dteBatchProductToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteBatchProductToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteBatchProductToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteBatchProductToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteBatchProductToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteBatchProductToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteBatchProductToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteBatchProductToDate, true);
            this.fld_dteBatchProductToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteBatchProductToDate.TabIndex = 1;
            this.fld_dteBatchProductToDate.Tag = "DC";
            // 
            // fld_btnShow
            // 
            this.fld_btnShow.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnShow.Appearance.Options.UseForeColor = true;
            this.fld_btnShow.BOSComment = null;
            this.fld_btnShow.BOSDataMember = null;
            this.fld_btnShow.BOSDataSource = null;
            this.fld_btnShow.BOSDescription = null;
            this.fld_btnShow.BOSError = null;
            this.fld_btnShow.BOSFieldGroup = null;
            this.fld_btnShow.BOSFieldRelation = null;
            this.fld_btnShow.BOSPrivilege = null;
            this.fld_btnShow.BOSPropertyName = null;
            this.fld_btnShow.Location = new System.Drawing.Point(538, 9);
            this.fld_btnShow.Name = "fld_btnShow";
            this.fld_btnShow.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShow, true);
            this.fld_btnShow.Size = new System.Drawing.Size(75, 27);
            this.fld_btnShow.TabIndex = 3;
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcMMBatchProductsGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 50);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 429);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = global::Localization.ReportLocalizedResources.String1;
            this.fld_grcGroupControl.Text = "Danh sách lệnh sản xuất chưa có kế hoạch mua hàng";
            // 
            // fld_dgcMMBatchProductsGridControl
            // 
            this.fld_dgcMMBatchProductsGridControl.AllowDrop = true;
            this.fld_dgcMMBatchProductsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcMMBatchProductsGridControl.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMBatchProductsGridControl.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMBatchProductsGridControl.BOSDataSource = "MMBatchProducts";
            this.fld_dgcMMBatchProductsGridControl.BOSDescription = null;
            this.fld_dgcMMBatchProductsGridControl.BOSError = null;
            this.fld_dgcMMBatchProductsGridControl.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMBatchProductsGridControl.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMBatchProductsGridControl.BOSGridType = null;
            this.fld_dgcMMBatchProductsGridControl.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMBatchProductsGridControl.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcMMBatchProductsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMBatchProductsGridControl.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcMMBatchProductsGridControl.MainView = this.gridView1;
            this.fld_dgcMMBatchProductsGridControl.Name = "fld_dgcMMBatchProductsGridControl";
            this.fld_dgcMMBatchProductsGridControl.PrintReport = false;
            this.fld_dgcMMBatchProductsGridControl.Screen = null;
            this.fld_dgcMMBatchProductsGridControl.Size = new System.Drawing.Size(862, 407);
            this.fld_dgcMMBatchProductsGridControl.TabIndex = 5;
            this.fld_dgcMMBatchProductsGridControl.Tag = "DC";
            this.fld_dgcMMBatchProductsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcMMBatchProductsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // DMHM113
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM113";
            this.Text = "Danh sách lệnh sản xuất chưa có kế hoạch mua hàng";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteBatchProductFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteBatchProductFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteBatchProductToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteBatchProductToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMBatchProductsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteBatchProductFromDate;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteBatchProductToDate;
        private BOSComponent.BOSButton fld_btnShow;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private MMBatchProductsGridControl fld_dgcMMBatchProductsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}
