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
    /// Summary description for DMHM119
	/// </summary>
    partial class DMHM119
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
            this.fld_dgcHRRequestLeaveDays = new BOSERP.Modules.Home.HRRequestLeaveDaysGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteLeaveApplicationFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteLeaveApplicationToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRequestLeaveDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteLeaveApplicationFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteLeaveApplicationFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteLeaveApplicationToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteLeaveApplicationToDate.Properties)).BeginInit();
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
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcHRRequestLeaveDays);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 50);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 429);
            this.fld_grcGroupControl.TabIndex = 7;
            this.fld_grcGroupControl.Tag = string.Empty;
            this.fld_grcGroupControl.Text = "Nhắc nhở duyệt đơn xin nghỉ phép";
            // 
            // fld_dgcHRRequestLeaveDays
            // 
            this.fld_dgcHRRequestLeaveDays.AllowDrop = true;
            this.fld_dgcHRRequestLeaveDays.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHRRequestLeaveDays.BOSComment = string.Empty;
            this.fld_dgcHRRequestLeaveDays.BOSDataMember = string.Empty;
            this.fld_dgcHRRequestLeaveDays.BOSDataSource = "HRRequestLeaveDays";
            this.fld_dgcHRRequestLeaveDays.BOSDescription = null;
            this.fld_dgcHRRequestLeaveDays.BOSError = null;
            this.fld_dgcHRRequestLeaveDays.BOSFieldGroup = string.Empty;
            this.fld_dgcHRRequestLeaveDays.BOSFieldRelation = string.Empty;
            this.fld_dgcHRRequestLeaveDays.BOSGridType = null;
            this.fld_dgcHRRequestLeaveDays.BOSPrivilege = string.Empty;
            this.fld_dgcHRRequestLeaveDays.BOSPropertyName = string.Empty;
            this.fld_dgcHRRequestLeaveDays.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRRequestLeaveDays.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcHRRequestLeaveDays.MainView = this.gridView1;
            this.fld_dgcHRRequestLeaveDays.Name = "fld_dgcHRRequestLeaveDays";
            this.fld_dgcHRRequestLeaveDays.PrintReport = false;
            this.fld_dgcHRRequestLeaveDays.Screen = null;
            this.fld_dgcHRRequestLeaveDays.Size = new System.Drawing.Size(862, 407);
            this.fld_dgcHRRequestLeaveDays.TabIndex = 5;
            this.fld_dgcHRRequestLeaveDays.Tag = "DC";
            this.fld_dgcHRRequestLeaveDays.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcHRRequestLeaveDays;
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
            this.bosPanel2.Controls.Add(this.fld_dteLeaveApplicationFromDate);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteLeaveApplicationToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 50);
            this.bosPanel2.TabIndex = 6;
            // 
            // fld_dteLeaveApplicationFromDate
            // 
            this.fld_dteLeaveApplicationFromDate.BOSComment = null;
            this.fld_dteLeaveApplicationFromDate.BOSDataMember = "DateEdit";
            this.fld_dteLeaveApplicationFromDate.BOSDataSource = string.Empty;
            this.fld_dteLeaveApplicationFromDate.BOSDescription = null;
            this.fld_dteLeaveApplicationFromDate.BOSError = null;
            this.fld_dteLeaveApplicationFromDate.BOSFieldGroup = null;
            this.fld_dteLeaveApplicationFromDate.BOSFieldRelation = null;
            this.fld_dteLeaveApplicationFromDate.BOSPrivilege = null;
            this.fld_dteLeaveApplicationFromDate.BOSPropertyName = "EditValue";
            this.fld_dteLeaveApplicationFromDate.EditValue = null;
            this.fld_dteLeaveApplicationFromDate.Location = new System.Drawing.Point(90, 15);
            this.fld_dteLeaveApplicationFromDate.Name = "fld_dteLeaveApplicationFromDate";
            this.fld_dteLeaveApplicationFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteLeaveApplicationFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteLeaveApplicationFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteLeaveApplicationFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteLeaveApplicationFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteLeaveApplicationFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteLeaveApplicationFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteLeaveApplicationFromDate, true);
            this.fld_dteLeaveApplicationFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteLeaveApplicationFromDate.TabIndex = 0;
            this.fld_dteLeaveApplicationFromDate.Tag = "DC";
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
            // fld_dteLeaveApplicationToDate
            // 
            this.fld_dteLeaveApplicationToDate.BOSComment = null;
            this.fld_dteLeaveApplicationToDate.BOSDataMember = "DateEdit";
            this.fld_dteLeaveApplicationToDate.BOSDataSource = string.Empty;
            this.fld_dteLeaveApplicationToDate.BOSDescription = null;
            this.fld_dteLeaveApplicationToDate.BOSError = null;
            this.fld_dteLeaveApplicationToDate.BOSFieldGroup = null;
            this.fld_dteLeaveApplicationToDate.BOSFieldRelation = null;
            this.fld_dteLeaveApplicationToDate.BOSPrivilege = null;
            this.fld_dteLeaveApplicationToDate.BOSPropertyName = "EditValue";
            this.fld_dteLeaveApplicationToDate.EditValue = null;
            this.fld_dteLeaveApplicationToDate.Location = new System.Drawing.Point(339, 15);
            this.fld_dteLeaveApplicationToDate.Name = "fld_dteLeaveApplicationToDate";
            this.fld_dteLeaveApplicationToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteLeaveApplicationToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteLeaveApplicationToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteLeaveApplicationToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteLeaveApplicationToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteLeaveApplicationToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteLeaveApplicationToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteLeaveApplicationToDate, true);
            this.fld_dteLeaveApplicationToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteLeaveApplicationToDate.TabIndex = 1;
            this.fld_dteLeaveApplicationToDate.Tag = "DC";
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
            // DMHM119
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM119";
            this.Text = "Nhắc nhở đơn xin nghỉ phép nhân viên";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRRequestLeaveDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteLeaveApplicationFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteLeaveApplicationFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteLeaveApplicationToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteLeaveApplicationToDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private BOSGroupControl fld_grcGroupControl;
        private HRRequestLeaveDaysGridControl fld_dgcHRRequestLeaveDays;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSPanel bosPanel2;
        private BOSDateEdit fld_dteLeaveApplicationFromDate;
        private BOSLabel fld_lblLabel61;
        private BOSLabel fld_lblLabel62;
        private BOSDateEdit fld_dteLeaveApplicationToDate;
        private BOSButton fld_btnShow;
	}
}
