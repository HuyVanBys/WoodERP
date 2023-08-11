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
    /// Summary description for DMHM114
	/// </summary>
    partial class DMHM117
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
            this.fld_dteTransferProposalFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteTransferProposalToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcICTransferProposalsGridControl = new BOSERP.Modules.Home.ICTransferProposalsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTransferProposalFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTransferProposalFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTransferProposalToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTransferProposalToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferProposalsGridControl)).BeginInit();
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
            this.bosPanel2.Controls.Add(this.fld_dteTransferProposalFromDate);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteTransferProposalToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 50);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_dteTransferProposalFromDate
            // 
            this.fld_dteTransferProposalFromDate.BOSComment = null;
            this.fld_dteTransferProposalFromDate.BOSDataMember = "DateEdit";
            this.fld_dteTransferProposalFromDate.BOSDataSource = string.Empty;
            this.fld_dteTransferProposalFromDate.BOSDescription = null;
            this.fld_dteTransferProposalFromDate.BOSError = null;
            this.fld_dteTransferProposalFromDate.BOSFieldGroup = null;
            this.fld_dteTransferProposalFromDate.BOSFieldRelation = null;
            this.fld_dteTransferProposalFromDate.BOSPrivilege = null;
            this.fld_dteTransferProposalFromDate.BOSPropertyName = "EditValue";
            this.fld_dteTransferProposalFromDate.EditValue = null;
            this.fld_dteTransferProposalFromDate.Location = new System.Drawing.Point(90, 15);
            this.fld_dteTransferProposalFromDate.Name = "fld_dteTransferProposalFromDate";
            this.fld_dteTransferProposalFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteTransferProposalFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteTransferProposalFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteTransferProposalFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteTransferProposalFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteTransferProposalFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteTransferProposalFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteTransferProposalFromDate, true);
            this.fld_dteTransferProposalFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteTransferProposalFromDate.TabIndex = 0;
            this.fld_dteTransferProposalFromDate.Tag = "DC";
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
            // fld_dteTransferProposalToDate
            // 
            this.fld_dteTransferProposalToDate.BOSComment = null;
            this.fld_dteTransferProposalToDate.BOSDataMember = "DateEdit";
            this.fld_dteTransferProposalToDate.BOSDataSource = string.Empty;
            this.fld_dteTransferProposalToDate.BOSDescription = null;
            this.fld_dteTransferProposalToDate.BOSError = null;
            this.fld_dteTransferProposalToDate.BOSFieldGroup = null;
            this.fld_dteTransferProposalToDate.BOSFieldRelation = null;
            this.fld_dteTransferProposalToDate.BOSPrivilege = null;
            this.fld_dteTransferProposalToDate.BOSPropertyName = "EditValue";
            this.fld_dteTransferProposalToDate.EditValue = null;
            this.fld_dteTransferProposalToDate.Location = new System.Drawing.Point(339, 15);
            this.fld_dteTransferProposalToDate.Name = "fld_dteTransferProposalToDate";
            this.fld_dteTransferProposalToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteTransferProposalToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteTransferProposalToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteTransferProposalToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteTransferProposalToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteTransferProposalToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteTransferProposalToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteTransferProposalToDate, true);
            this.fld_dteTransferProposalToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteTransferProposalToDate.TabIndex = 1;
            this.fld_dteTransferProposalToDate.Tag = "DC";
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
            this.fld_grcGroupControl.BOSComment = string.Empty;
            this.fld_grcGroupControl.BOSDataMember = string.Empty;
            this.fld_grcGroupControl.BOSDataSource = string.Empty;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = string.Empty;
            this.fld_grcGroupControl.BOSFieldRelation = string.Empty;
            this.fld_grcGroupControl.BOSPrivilege = string.Empty;
            this.fld_grcGroupControl.BOSPropertyName = string.Empty;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcICTransferProposalsGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 50);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 429);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = string.Empty;
            this.fld_grcGroupControl.Text = "Danh sách đề nghị chuyển kho đã duyệt";
            // 
            // fld_dgcICTransferProposalsGridControl
            // 
            this.fld_dgcICTransferProposalsGridControl.AllowDrop = true;
            this.fld_dgcICTransferProposalsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcICTransferProposalsGridControl.BOSComment = string.Empty;
            this.fld_dgcICTransferProposalsGridControl.BOSDataMember = string.Empty;
            this.fld_dgcICTransferProposalsGridControl.BOSDataSource = "ICTransferProposals";
            this.fld_dgcICTransferProposalsGridControl.BOSDescription = null;
            this.fld_dgcICTransferProposalsGridControl.BOSError = null;
            this.fld_dgcICTransferProposalsGridControl.BOSFieldGroup = string.Empty;
            this.fld_dgcICTransferProposalsGridControl.BOSFieldRelation = string.Empty;
            this.fld_dgcICTransferProposalsGridControl.BOSGridType = null;
            this.fld_dgcICTransferProposalsGridControl.BOSPrivilege = string.Empty;
            this.fld_dgcICTransferProposalsGridControl.BOSPropertyName = string.Empty;
            this.fld_dgcICTransferProposalsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcICTransferProposalsGridControl.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcICTransferProposalsGridControl.MainView = this.gridView1;
            this.fld_dgcICTransferProposalsGridControl.Name = "fld_dgcICTransferProposalsGridControl";
            this.fld_dgcICTransferProposalsGridControl.PrintReport = false;
            this.fld_dgcICTransferProposalsGridControl.Screen = null;
            this.fld_dgcICTransferProposalsGridControl.Size = new System.Drawing.Size(862, 407);
            this.fld_dgcICTransferProposalsGridControl.TabIndex = 5;
            this.fld_dgcICTransferProposalsGridControl.Tag = "DC";
            this.fld_dgcICTransferProposalsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcICTransferProposalsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // DMHM117
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM117";
            this.Text = "Nhắc nhở chuyển kho";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTransferProposalFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTransferProposalFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTransferProposalToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTransferProposalToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcICTransferProposalsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteTransferProposalFromDate;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteTransferProposalToDate;
        private BOSComponent.BOSButton fld_btnShow;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private ICTransferProposalsGridControl fld_dgcICTransferProposalsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}
