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
	/// Summary description for DMHM112
	/// </summary>
    partial class DMHM112
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
            this.fld_dteARRemindFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteARRemindToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcARRemindsGridControl = new BOSERP.Modules.Home.ARRemindGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRemindFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRemindFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRemindToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRemindToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRemindsGridControl)).BeginInit();
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
            this.bosPanel2.Controls.Add(this.fld_dteARRemindFromDate);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteARRemindToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 50);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_dteARRemindFromDate
            // 
            this.fld_dteARRemindFromDate.BOSComment = null;
            this.fld_dteARRemindFromDate.BOSDataMember = "DateEdit";
            this.fld_dteARRemindFromDate.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteARRemindFromDate.BOSDescription = null;
            this.fld_dteARRemindFromDate.BOSError = null;
            this.fld_dteARRemindFromDate.BOSFieldGroup = null;
            this.fld_dteARRemindFromDate.BOSFieldRelation = null;
            this.fld_dteARRemindFromDate.BOSPrivilege = null;
            this.fld_dteARRemindFromDate.BOSPropertyName = "EditValue";
            this.fld_dteARRemindFromDate.EditValue = null;
            this.fld_dteARRemindFromDate.Location = new System.Drawing.Point(90, 15);
            this.fld_dteARRemindFromDate.Name = "fld_dteARRemindFromDate";
            this.fld_dteARRemindFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARRemindFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARRemindFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARRemindFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARRemindFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARRemindFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARRemindFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteARRemindFromDate, true);
            this.fld_dteARRemindFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARRemindFromDate.TabIndex = 0;
            this.fld_dteARRemindFromDate.Tag = "DC";
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
            // fld_dteARRemindToDate
            // 
            this.fld_dteARRemindToDate.BOSComment = null;
            this.fld_dteARRemindToDate.BOSDataMember = "DateEdit";
            this.fld_dteARRemindToDate.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteARRemindToDate.BOSDescription = null;
            this.fld_dteARRemindToDate.BOSError = null;
            this.fld_dteARRemindToDate.BOSFieldGroup = null;
            this.fld_dteARRemindToDate.BOSFieldRelation = null;
            this.fld_dteARRemindToDate.BOSPrivilege = null;
            this.fld_dteARRemindToDate.BOSPropertyName = "EditValue";
            this.fld_dteARRemindToDate.EditValue = null;
            this.fld_dteARRemindToDate.Location = new System.Drawing.Point(339, 15);
            this.fld_dteARRemindToDate.Name = "fld_dteARRemindToDate";
            this.fld_dteARRemindToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteARRemindToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteARRemindToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteARRemindToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteARRemindToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteARRemindToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteARRemindToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteARRemindToDate, true);
            this.fld_dteARRemindToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteARRemindToDate.TabIndex = 1;
            this.fld_dteARRemindToDate.Tag = "DC";
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
            this.fld_grcGroupControl.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcARRemindsGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 50);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 429);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = global::Localization.CommonLocalizedResources.String1;
            this.fld_grcGroupControl.Text = "Danh sách đơn bán hàng";
            // 
            // fld_dgcARRemindsGridControl
            // 
            this.fld_dgcARRemindsGridControl.AllowDrop = true;
            this.fld_dgcARRemindsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcARRemindsGridControl.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARRemindsGridControl.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARRemindsGridControl.BOSDataSource = "ARReminds";
            this.fld_dgcARRemindsGridControl.BOSDescription = null;
            this.fld_dgcARRemindsGridControl.BOSError = null;
            this.fld_dgcARRemindsGridControl.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARRemindsGridControl.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARRemindsGridControl.BOSGridType = null;
            this.fld_dgcARRemindsGridControl.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARRemindsGridControl.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcARRemindsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcARRemindsGridControl.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcARRemindsGridControl.MainView = this.gridView1;
            this.fld_dgcARRemindsGridControl.Name = "fld_dgcARRemindsGridControl";
            this.fld_dgcARRemindsGridControl.PrintReport = false;
            this.fld_dgcARRemindsGridControl.Screen = null;
            this.fld_dgcARRemindsGridControl.Size = new System.Drawing.Size(862, 407);
            this.fld_dgcARRemindsGridControl.TabIndex = 5;
            this.fld_dgcARRemindsGridControl.Tag = "DC";
            this.fld_dgcARRemindsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcARRemindsGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // DMHM112
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM112";
            this.Text = "Thông tin đơn mua hàng";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRemindFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRemindFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRemindToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteARRemindToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcARRemindsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteARRemindFromDate;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteARRemindToDate;
        private BOSComponent.BOSButton fld_btnShow;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private ARRemindGridControl fld_dgcARRemindsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}
