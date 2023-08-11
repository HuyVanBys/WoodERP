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
    /// Summary description for DMHM115
	/// </summary>
    partial class DMHM115
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
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHREmployeesGridControl = new BOSERP.Modules.Home.HREmployeesGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteHREmployeeFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteHREmployeeToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = string.Empty;
            this.fld_grcGroupControl.BOSDataMember = string.Empty;
            this.fld_grcGroupControl.BOSDataSource = string.Empty;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = string.Empty;
            this.fld_grcGroupControl.BOSFieldRelation = string.Empty;
            this.fld_grcGroupControl.BOSPrivilege = string.Empty;
            this.fld_grcGroupControl.BOSPropertyName = string.Empty;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcHREmployeesGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 50);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 429);
            this.fld_grcGroupControl.TabIndex = 9;
            this.fld_grcGroupControl.Tag = string.Empty;
            this.fld_grcGroupControl.Text = "Danh sách nhân viên sắp hết hạn hợp đồng, phụ lục hợp đồng, hợp đồng thử việc";
            // 
            // fld_dgcHREmployeesGridControl
            // 
            this.fld_dgcHREmployeesGridControl.AllowDrop = true;
            this.fld_dgcHREmployeesGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeesGridControl.BOSComment = string.Empty;
            this.fld_dgcHREmployeesGridControl.BOSDataMember = string.Empty;
            this.fld_dgcHREmployeesGridControl.BOSDataSource = "HREmployees";
            this.fld_dgcHREmployeesGridControl.BOSDescription = null;
            this.fld_dgcHREmployeesGridControl.BOSError = null;
            this.fld_dgcHREmployeesGridControl.BOSFieldGroup = string.Empty;
            this.fld_dgcHREmployeesGridControl.BOSFieldRelation = string.Empty;
            this.fld_dgcHREmployeesGridControl.BOSGridType = null;
            this.fld_dgcHREmployeesGridControl.BOSPrivilege = string.Empty;
            this.fld_dgcHREmployeesGridControl.BOSPropertyName = string.Empty;
            this.fld_dgcHREmployeesGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREmployeesGridControl.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcHREmployeesGridControl.MainView = this.gridView1;
            this.fld_dgcHREmployeesGridControl.Name = "fld_dgcHREmployeesGridControl";
            this.fld_dgcHREmployeesGridControl.PrintReport = false;
            this.fld_dgcHREmployeesGridControl.Screen = null;
            this.fld_dgcHREmployeesGridControl.Size = new System.Drawing.Size(862, 407);
            this.fld_dgcHREmployeesGridControl.TabIndex = 5;
            this.fld_dgcHREmployeesGridControl.Tag = "DC";
            this.fld_dgcHREmployeesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHREmployeesGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
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
            this.bosPanel2.Controls.Add(this.fld_dteHREmployeeFromDate);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteHREmployeeToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 50);
            this.bosPanel2.TabIndex = 8;
            // 
            // fld_dteHREmployeeFromDate
            // 
            this.fld_dteHREmployeeFromDate.BOSComment = null;
            this.fld_dteHREmployeeFromDate.BOSDataMember = "DateEdit";
            this.fld_dteHREmployeeFromDate.BOSDataSource = string.Empty;
            this.fld_dteHREmployeeFromDate.BOSDescription = null;
            this.fld_dteHREmployeeFromDate.BOSError = null;
            this.fld_dteHREmployeeFromDate.BOSFieldGroup = null;
            this.fld_dteHREmployeeFromDate.BOSFieldRelation = null;
            this.fld_dteHREmployeeFromDate.BOSPrivilege = null;
            this.fld_dteHREmployeeFromDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeFromDate.EditValue = null;
            this.fld_dteHREmployeeFromDate.Location = new System.Drawing.Point(90, 15);
            this.fld_dteHREmployeeFromDate.Name = "fld_dteHREmployeeFromDate";
            this.fld_dteHREmployeeFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeFromDate, true);
            this.fld_dteHREmployeeFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHREmployeeFromDate.TabIndex = 0;
            this.fld_dteHREmployeeFromDate.Tag = "DC";
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
            // fld_dteHREmployeeToDate
            // 
            this.fld_dteHREmployeeToDate.BOSComment = null;
            this.fld_dteHREmployeeToDate.BOSDataMember = "DateEdit";
            this.fld_dteHREmployeeToDate.BOSDataSource = string.Empty;
            this.fld_dteHREmployeeToDate.BOSDescription = null;
            this.fld_dteHREmployeeToDate.BOSError = null;
            this.fld_dteHREmployeeToDate.BOSFieldGroup = null;
            this.fld_dteHREmployeeToDate.BOSFieldRelation = null;
            this.fld_dteHREmployeeToDate.BOSPrivilege = null;
            this.fld_dteHREmployeeToDate.BOSPropertyName = "EditValue";
            this.fld_dteHREmployeeToDate.EditValue = null;
            this.fld_dteHREmployeeToDate.Location = new System.Drawing.Point(339, 15);
            this.fld_dteHREmployeeToDate.Name = "fld_dteHREmployeeToDate";
            this.fld_dteHREmployeeToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteHREmployeeToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteHREmployeeToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteHREmployeeToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteHREmployeeToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteHREmployeeToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteHREmployeeToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteHREmployeeToDate, true);
            this.fld_dteHREmployeeToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteHREmployeeToDate.TabIndex = 1;
            this.fld_dteHREmployeeToDate.Tag = "DC";
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
            // DMHM115
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM115";
            this.Text = "Nhắc nhở hợp đồng nhân viên";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteHREmployeeToDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private BOSGroupControl fld_grcGroupControl;
        private HREmployeesGridControl fld_dgcHREmployeesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSPanel bosPanel2;
        private BOSDateEdit fld_dteHREmployeeFromDate;
        private BOSLabel fld_lblLabel61;
        private BOSLabel fld_lblLabel62;
        private BOSDateEdit fld_dteHREmployeeToDate;
        private BOSButton fld_btnShow;
	}
}
