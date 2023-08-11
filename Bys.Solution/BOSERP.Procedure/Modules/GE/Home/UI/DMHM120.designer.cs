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
    partial class DMHM120
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
            this.fld_dgcAPPaymentProposals = new BOSERP.Modules.Home.APPaymentProposalsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dtePaymentProposalFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dtePaymentProposalToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentProposals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentProposalFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentProposalFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentProposalToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentProposalToDate.Properties)).BeginInit();
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
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcAPPaymentProposals);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 50);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 409);
            this.fld_grcGroupControl.TabIndex = 7;
            this.fld_grcGroupControl.Tag = string.Empty;
            this.fld_grcGroupControl.Text = "Đề nghị thanh toán";
            // 
            // fld_dgcAPPaymentProposals
            // 
            this.fld_dgcAPPaymentProposals.AllowDrop = true;
            this.fld_dgcAPPaymentProposals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPPaymentProposals.BOSComment = string.Empty;
            this.fld_dgcAPPaymentProposals.BOSDataMember = string.Empty;
            this.fld_dgcAPPaymentProposals.BOSDataSource = "GEPaymentProposals";
            this.fld_dgcAPPaymentProposals.BOSDescription = null;
            this.fld_dgcAPPaymentProposals.BOSError = null;
            this.fld_dgcAPPaymentProposals.BOSFieldGroup = string.Empty;
            this.fld_dgcAPPaymentProposals.BOSFieldRelation = string.Empty;
            this.fld_dgcAPPaymentProposals.BOSGridType = null;
            this.fld_dgcAPPaymentProposals.BOSPrivilege = string.Empty;
            this.fld_dgcAPPaymentProposals.BOSPropertyName = string.Empty;
            this.fld_dgcAPPaymentProposals.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPaymentProposals.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcAPPaymentProposals.MainView = this.gridView1;
            this.fld_dgcAPPaymentProposals.Name = "fld_dgcAPPaymentProposals";
            this.fld_dgcAPPaymentProposals.PrintReport = false;
            this.fld_dgcAPPaymentProposals.Screen = null;
            this.fld_dgcAPPaymentProposals.Size = new System.Drawing.Size(862, 387);
            this.fld_dgcAPPaymentProposals.TabIndex = 5;
            this.fld_dgcAPPaymentProposals.Tag = "DC";
            this.fld_dgcAPPaymentProposals.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcAPPaymentProposals;
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
            this.bosPanel2.Controls.Add(this.fld_dtePaymentProposalFromDate);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dtePaymentProposalToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 50);
            this.bosPanel2.TabIndex = 6;
            // 
            // fld_dtePaymentProposalFromDate
            // 
            this.fld_dtePaymentProposalFromDate.BOSComment = null;
            this.fld_dtePaymentProposalFromDate.BOSDataMember = "DateEdit";
            this.fld_dtePaymentProposalFromDate.BOSDataSource = string.Empty;
            this.fld_dtePaymentProposalFromDate.BOSDescription = null;
            this.fld_dtePaymentProposalFromDate.BOSError = null;
            this.fld_dtePaymentProposalFromDate.BOSFieldGroup = null;
            this.fld_dtePaymentProposalFromDate.BOSFieldRelation = null;
            this.fld_dtePaymentProposalFromDate.BOSPrivilege = null;
            this.fld_dtePaymentProposalFromDate.BOSPropertyName = "EditValue";
            this.fld_dtePaymentProposalFromDate.EditValue = null;
            this.fld_dtePaymentProposalFromDate.Location = new System.Drawing.Point(90, 15);
            this.fld_dtePaymentProposalFromDate.Name = "fld_dtePaymentProposalFromDate";
            this.fld_dtePaymentProposalFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePaymentProposalFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePaymentProposalFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePaymentProposalFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePaymentProposalFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePaymentProposalFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePaymentProposalFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePaymentProposalFromDate, true);
            this.fld_dtePaymentProposalFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dtePaymentProposalFromDate.TabIndex = 0;
            this.fld_dtePaymentProposalFromDate.Tag = "DC";
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
            // fld_dtePaymentProposalToDate
            // 
            this.fld_dtePaymentProposalToDate.BOSComment = null;
            this.fld_dtePaymentProposalToDate.BOSDataMember = "DateEdit";
            this.fld_dtePaymentProposalToDate.BOSDataSource = string.Empty;
            this.fld_dtePaymentProposalToDate.BOSDescription = null;
            this.fld_dtePaymentProposalToDate.BOSError = null;
            this.fld_dtePaymentProposalToDate.BOSFieldGroup = null;
            this.fld_dtePaymentProposalToDate.BOSFieldRelation = null;
            this.fld_dtePaymentProposalToDate.BOSPrivilege = null;
            this.fld_dtePaymentProposalToDate.BOSPropertyName = "EditValue";
            this.fld_dtePaymentProposalToDate.EditValue = null;
            this.fld_dtePaymentProposalToDate.Location = new System.Drawing.Point(339, 15);
            this.fld_dtePaymentProposalToDate.Name = "fld_dtePaymentProposalToDate";
            this.fld_dtePaymentProposalToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dtePaymentProposalToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dtePaymentProposalToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dtePaymentProposalToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dtePaymentProposalToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dtePaymentProposalToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dtePaymentProposalToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dtePaymentProposalToDate, true);
            this.fld_dtePaymentProposalToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dtePaymentProposalToDate.TabIndex = 1;
            this.fld_dtePaymentProposalToDate.Tag = "DC";
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
            // DMHM120
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 459);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM120";
            this.Text = "Nhắc nhở đơn xin nghỉ phép nhân viên";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPaymentProposals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentProposalFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentProposalFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentProposalToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dtePaymentProposalToDate.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private BOSGroupControl fld_grcGroupControl;
        private APPaymentProposalsGridControl fld_dgcAPPaymentProposals;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BOSPanel bosPanel2;
        private BOSDateEdit fld_dtePaymentProposalFromDate;
        private BOSLabel fld_lblLabel61;
        private BOSLabel fld_lblLabel62;
        private BOSDateEdit fld_dtePaymentProposalToDate;
        private BOSButton fld_btnShow;
	}
}
