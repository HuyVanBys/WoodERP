using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Home.UI
{
	/// <summary>
	/// Summary description for DMHM101
	/// </summary>
	partial class DMHM101
	{
		private BOSComponent.BOSGroupControl fld_grcGroupControl;
		private BOSComponent.BOSButton fld_btnAccept;
		private BOSComponent.BOSButton fld_btnCancelRemind;
		private BOSComponent.BOSCheckEdit fld_chkCheckAll;
		private GEHistoryDetailsGridControl fld_dgcGEHistoryDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;


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
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcGEHistoryDetails = new BOSERP.Modules.Home.GEHistoryDetailsGridControl();
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAccept = new BOSComponent.BOSButton(this.components);
            this.fld_btnCancelRemind = new BOSComponent.BOSButton(this.components);
            this.fld_chkCheckAll = new BOSComponent.BOSCheckEdit(this.components);
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_dteFrom = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteTo = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCheckAll.Properties)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTo.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcGEHistoryDetails);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 44);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 480);
            this.fld_grcGroupControl.TabIndex = 5;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Danh sách thông tin khách hàng thay đổi";
            // 
            // fld_dgcGEHistoryDetails
            // 
            this.fld_dgcGEHistoryDetails.AllowDrop = true;
            this.fld_dgcGEHistoryDetails.BOSComment = "";
            this.fld_dgcGEHistoryDetails.BOSDataMember = "";
            this.fld_dgcGEHistoryDetails.BOSDataSource = "GEHistoryDetails";
            this.fld_dgcGEHistoryDetails.BOSDescription = null;
            this.fld_dgcGEHistoryDetails.BOSError = null;
            this.fld_dgcGEHistoryDetails.BOSFieldGroup = "";
            this.fld_dgcGEHistoryDetails.BOSFieldRelation = "";
            this.fld_dgcGEHistoryDetails.BOSGridType = null;
            this.fld_dgcGEHistoryDetails.BOSPrivilege = "";
            this.fld_dgcGEHistoryDetails.BOSPropertyName = "";
            this.fld_dgcGEHistoryDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcGEHistoryDetails.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcGEHistoryDetails.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcGEHistoryDetails.MainView = this.fld_dgvGEHistoryDetails;
            this.fld_dgcGEHistoryDetails.Name = "fld_dgcGEHistoryDetails";
            this.fld_dgcGEHistoryDetails.Screen = null;
            this.fld_dgcGEHistoryDetails.Size = new System.Drawing.Size(858, 456);
            this.fld_dgcGEHistoryDetails.TabIndex = 4;
            this.fld_dgcGEHistoryDetails.Tag = "DC";
            this.fld_dgcGEHistoryDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGEHistoryDetails});
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.GridControl = this.fld_dgcGEHistoryDetails;
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // fld_btnAccept
            // 
            this.fld_btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnAccept.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAccept.Appearance.Options.UseForeColor = true;
            this.fld_btnAccept.BOSComment = "";
            this.fld_btnAccept.BOSDataMember = "";
            this.fld_btnAccept.BOSDataSource = "";
            this.fld_btnAccept.BOSDescription = null;
            this.fld_btnAccept.BOSError = null;
            this.fld_btnAccept.BOSFieldGroup = "";
            this.fld_btnAccept.BOSFieldRelation = "";
            this.fld_btnAccept.BOSPrivilege = "";
            this.fld_btnAccept.BOSPropertyName = "";
            this.fld_btnAccept.Location = new System.Drawing.Point(647, 6);
            this.fld_btnAccept.Name = "fld_btnAccept";
            this.fld_btnAccept.Screen = null;
            this.fld_btnAccept.Size = new System.Drawing.Size(94, 27);
            this.fld_btnAccept.TabIndex = 7;
            this.fld_btnAccept.Tag = "";
            this.fld_btnAccept.Text = "Duyệt";
            this.fld_btnAccept.Click += new System.EventHandler(this.fld_btnAccept_Click);
            // 
            // fld_btnCancelRemind
            // 
            this.fld_btnCancelRemind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnCancelRemind.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnCancelRemind.Appearance.Options.UseForeColor = true;
            this.fld_btnCancelRemind.BOSComment = "";
            this.fld_btnCancelRemind.BOSDataMember = "";
            this.fld_btnCancelRemind.BOSDataSource = "";
            this.fld_btnCancelRemind.BOSDescription = null;
            this.fld_btnCancelRemind.BOSError = null;
            this.fld_btnCancelRemind.BOSFieldGroup = "";
            this.fld_btnCancelRemind.BOSFieldRelation = "";
            this.fld_btnCancelRemind.BOSPrivilege = "";
            this.fld_btnCancelRemind.BOSPropertyName = "";
            this.fld_btnCancelRemind.Location = new System.Drawing.Point(747, 6);
            this.fld_btnCancelRemind.Name = "fld_btnCancelRemind";
            this.fld_btnCancelRemind.Screen = null;
            this.fld_btnCancelRemind.Size = new System.Drawing.Size(103, 27);
            this.fld_btnCancelRemind.TabIndex = 6;
            this.fld_btnCancelRemind.Tag = "";
            this.fld_btnCancelRemind.Text = "Hủy thay đổi";
            this.fld_btnCancelRemind.Click += new System.EventHandler(this.fld_btnCancelRemind_Click);
            // 
            // fld_chkCheckAll
            // 
            this.fld_chkCheckAll.BOSComment = "";
            this.fld_chkCheckAll.BOSDataMember = "";
            this.fld_chkCheckAll.BOSDataSource = "";
            this.fld_chkCheckAll.BOSDescription = null;
            this.fld_chkCheckAll.BOSError = null;
            this.fld_chkCheckAll.BOSFieldGroup = "";
            this.fld_chkCheckAll.BOSFieldRelation = "";
            this.fld_chkCheckAll.BOSPrivilege = "";
            this.fld_chkCheckAll.BOSPropertyName = "";
            this.fld_chkCheckAll.Location = new System.Drawing.Point(12, 12);
            this.fld_chkCheckAll.Name = "fld_chkCheckAll";
            this.fld_chkCheckAll.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_chkCheckAll.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_chkCheckAll.Properties.Appearance.Options.UseBackColor = true;
            this.fld_chkCheckAll.Properties.Appearance.Options.UseForeColor = true;
            this.fld_chkCheckAll.Properties.Caption = "Chọn tất cả";
            this.fld_chkCheckAll.Screen = null;
            this.fld_chkCheckAll.Size = new System.Drawing.Size(90, 19);
            this.fld_chkCheckAll.TabIndex = 8;
            this.fld_chkCheckAll.Tag = "DC";
            this.fld_chkCheckAll.CheckedChanged += new System.EventHandler(this.fld_chkCheckAll_CheckedChanged);
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
            this.bosPanel1.Controls.Add(this.fld_btnAccept);
            this.bosPanel1.Controls.Add(this.fld_btnCancelRemind);
            this.bosPanel1.Controls.Add(this.fld_chkCheckAll);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bosPanel1.Location = new System.Drawing.Point(0, 524);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(862, 43);
            this.bosPanel1.TabIndex = 9;
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
            this.bosPanel2.Controls.Add(this.fld_dteFrom);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteTo);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 44);
            this.bosPanel2.TabIndex = 10;
            // 
            // fld_dteFrom
            // 
            this.fld_dteFrom.BOSComment = null;
            this.fld_dteFrom.BOSDataMember = "DateEdit";
            this.fld_dteFrom.BOSDataSource = null;
            this.fld_dteFrom.BOSDescription = null;
            this.fld_dteFrom.BOSError = null;
            this.fld_dteFrom.BOSFieldGroup = null;
            this.fld_dteFrom.BOSFieldRelation = null;
            this.fld_dteFrom.BOSPrivilege = null;
            this.fld_dteFrom.BOSPropertyName = "EditValue";
            this.fld_dteFrom.EditValue = null;
            this.fld_dteFrom.Location = new System.Drawing.Point(108, 12);
            this.fld_dteFrom.Name = "fld_dteFrom";
            this.fld_dteFrom.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteFrom.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteFrom.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteFrom.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteFrom.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteFrom, true);
            this.fld_dteFrom.Size = new System.Drawing.Size(150, 20);
            this.fld_dteFrom.TabIndex = 20;
            this.fld_dteFrom.Tag = "DC";
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
            this.fld_lblLabel61.Location = new System.Drawing.Point(23, 15);
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
            this.fld_lblLabel62.Location = new System.Drawing.Point(294, 15);
            this.fld_lblLabel62.Name = "fld_lblLabel62";
            this.fld_lblLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel62, true);
            this.fld_lblLabel62.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel62.TabIndex = 18;
            this.fld_lblLabel62.Text = "Đến ngày";
            // 
            // fld_dteTo
            // 
            this.fld_dteTo.BOSComment = null;
            this.fld_dteTo.BOSDataMember = "DateEdit";
            this.fld_dteTo.BOSDataSource = null;
            this.fld_dteTo.BOSDescription = null;
            this.fld_dteTo.BOSError = null;
            this.fld_dteTo.BOSFieldGroup = null;
            this.fld_dteTo.BOSFieldRelation = null;
            this.fld_dteTo.BOSPrivilege = null;
            this.fld_dteTo.BOSPropertyName = "EditValue";
            this.fld_dteTo.EditValue = null;
            this.fld_dteTo.Location = new System.Drawing.Point(366, 12);
            this.fld_dteTo.Name = "fld_dteTo";
            this.fld_dteTo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteTo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteTo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteTo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteTo.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteTo.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteTo, true);
            this.fld_dteTo.Size = new System.Drawing.Size(150, 20);
            this.fld_dteTo.TabIndex = 21;
            this.fld_dteTo.Tag = "DC";
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
            this.fld_btnShow.Location = new System.Drawing.Point(546, 8);
            this.fld_btnShow.Name = "fld_btnShow";
            this.fld_btnShow.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnShow, true);
            this.fld_btnShow.Size = new System.Drawing.Size(75, 27);
            this.fld_btnShow.TabIndex = 19;
            this.fld_btnShow.Text = "Xem";
            this.fld_btnShow.Click += new System.EventHandler(this.fld_btnShow_Click);
            // 
            // DMHM101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel1);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM101";
            this.Text = "Thông tin khách hàng thay đổi";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_chkCheckAll.Properties)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTo.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteTo.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel1;
        private IContainer components;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteFrom;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteTo;
        private BOSComponent.BOSButton fld_btnShow;
	}
}
