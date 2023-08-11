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
	/// Summary description for DMHM111
	/// </summary>
    partial class DMHM111
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
            this.fld_lkeAPProposalStatus = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dteAPProposalFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel61 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel62 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteAPProposalToDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnShow = new BOSComponent.BOSButton(this.components);
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcAPProposalsFilterGridControl = new BOSERP.Modules.Home.APPurchaseProposalsGridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dgvGEHistoryDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPProposalStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProposalsFilterGridControl)).BeginInit();
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
            this.bosPanel2.Controls.Add(this.fld_lkeAPProposalStatus);
            this.bosPanel2.Controls.Add(this.fld_dteAPProposalFromDate);
            this.bosPanel2.Controls.Add(this.bosLabel1);
            this.bosPanel2.Controls.Add(this.fld_lblLabel61);
            this.bosPanel2.Controls.Add(this.fld_lblLabel62);
            this.bosPanel2.Controls.Add(this.fld_dteAPProposalToDate);
            this.bosPanel2.Controls.Add(this.fld_btnShow);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(862, 76);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_lkeAPProposalStatus
            // 
            this.fld_lkeAPProposalStatus.BOSAllowAddNew = false;
            this.fld_lkeAPProposalStatus.BOSAllowDummy = true;
            this.fld_lkeAPProposalStatus.BOSComment = null;
            this.fld_lkeAPProposalStatus.BOSDataMember = "APPurchaseProposalStatus";
            this.fld_lkeAPProposalStatus.BOSDataSource = "APProposals";
            this.fld_lkeAPProposalStatus.BOSDescription = null;
            this.fld_lkeAPProposalStatus.BOSError = null;
            this.fld_lkeAPProposalStatus.BOSFieldGroup = null;
            this.fld_lkeAPProposalStatus.BOSFieldParent = null;
            this.fld_lkeAPProposalStatus.BOSFieldRelation = null;
            this.fld_lkeAPProposalStatus.BOSPrivilege = null;
            this.fld_lkeAPProposalStatus.BOSPropertyName = null;
            this.fld_lkeAPProposalStatus.BOSSelectType = null;
            this.fld_lkeAPProposalStatus.BOSSelectTypeValue = null;
            this.fld_lkeAPProposalStatus.CurrentDisplayText = null;
            this.fld_lkeAPProposalStatus.Location = new System.Drawing.Point(90, 38);
            this.fld_lkeAPProposalStatus.MenuManager = this.screenToolbar;
            this.fld_lkeAPProposalStatus.Name = "fld_lkeAPProposalStatus";
            this.fld_lkeAPProposalStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeAPProposalStatus.Properties.NullText = global::Localization.CommonLocalizedResources.String1;
            this.fld_lkeAPProposalStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeAPProposalStatus.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeAPProposalStatus, true);
            this.fld_lkeAPProposalStatus.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeAPProposalStatus.TabIndex = 2;
            this.fld_lkeAPProposalStatus.Tag = "DC";
            // 
            // fld_dteAPProposalFromDate
            // 
            this.fld_dteAPProposalFromDate.BOSComment = null;
            this.fld_dteAPProposalFromDate.BOSDataMember = "DateEdit";
            this.fld_dteAPProposalFromDate.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteAPProposalFromDate.BOSDescription = null;
            this.fld_dteAPProposalFromDate.BOSError = null;
            this.fld_dteAPProposalFromDate.BOSFieldGroup = null;
            this.fld_dteAPProposalFromDate.BOSFieldRelation = null;
            this.fld_dteAPProposalFromDate.BOSPrivilege = null;
            this.fld_dteAPProposalFromDate.BOSPropertyName = "EditValue";
            this.fld_dteAPProposalFromDate.EditValue = null;
            this.fld_dteAPProposalFromDate.Location = new System.Drawing.Point(90, 12);
            this.fld_dteAPProposalFromDate.Name = "fld_dteAPProposalFromDate";
            this.fld_dteAPProposalFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPProposalFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPProposalFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPProposalFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPProposalFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPProposalFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPProposalFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPProposalFromDate, true);
            this.fld_dteAPProposalFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPProposalFromDate.TabIndex = 0;
            this.fld_dteAPProposalFromDate.Tag = "DC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(23, 41);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(49, 13);
            this.bosLabel1.TabIndex = 17;
            this.bosLabel1.Text = "Trạng thái";
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
            this.fld_lblLabel62.Location = new System.Drawing.Point(267, 15);
            this.fld_lblLabel62.Name = "fld_lblLabel62";
            this.fld_lblLabel62.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lblLabel62, true);
            this.fld_lblLabel62.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel62.TabIndex = 18;
            this.fld_lblLabel62.Text = "Đến ngày";
            // 
            // fld_dteAPProposalToDate
            // 
            this.fld_dteAPProposalToDate.BOSComment = null;
            this.fld_dteAPProposalToDate.BOSDataMember = "DateEdit";
            this.fld_dteAPProposalToDate.BOSDataSource = global::Localization.CommonLocalizedResources.String1;
            this.fld_dteAPProposalToDate.BOSDescription = null;
            this.fld_dteAPProposalToDate.BOSError = null;
            this.fld_dteAPProposalToDate.BOSFieldGroup = null;
            this.fld_dteAPProposalToDate.BOSFieldRelation = null;
            this.fld_dteAPProposalToDate.BOSPrivilege = null;
            this.fld_dteAPProposalToDate.BOSPropertyName = "EditValue";
            this.fld_dteAPProposalToDate.EditValue = null;
            this.fld_dteAPProposalToDate.Location = new System.Drawing.Point(339, 12);
            this.fld_dteAPProposalToDate.Name = "fld_dteAPProposalToDate";
            this.fld_dteAPProposalToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteAPProposalToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteAPProposalToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteAPProposalToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteAPProposalToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteAPProposalToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteAPProposalToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteAPProposalToDate, true);
            this.fld_dteAPProposalToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteAPProposalToDate.TabIndex = 1;
            this.fld_dteAPProposalToDate.Tag = "DC";
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
            this.fld_grcGroupControl.Controls.Add(this.fld_dgcAPProposalsFilterGridControl);
            this.fld_grcGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_grcGroupControl.Location = new System.Drawing.Point(0, 76);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(862, 403);
            this.fld_grcGroupControl.TabIndex = 1;
            this.fld_grcGroupControl.Tag = global::Localization.SaleOrderLocalizedResources.ARSaleOrderSaleAgreement;
            this.fld_grcGroupControl.Text = "Danh sách mua bán hàng";
            // 
            // fld_dgcAPProposalsFilterGridControl
            // 
            this.fld_dgcAPProposalsFilterGridControl.AllowDrop = true;
            this.fld_dgcAPProposalsFilterGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcAPProposalsFilterGridControl.BOSComment = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcAPProposalsFilterGridControl.BOSDataMember = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcAPProposalsFilterGridControl.BOSDataSource = "APProposals";
            this.fld_dgcAPProposalsFilterGridControl.BOSDescription = null;
            this.fld_dgcAPProposalsFilterGridControl.BOSError = null;
            this.fld_dgcAPProposalsFilterGridControl.BOSFieldGroup = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcAPProposalsFilterGridControl.BOSFieldRelation = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcAPProposalsFilterGridControl.BOSGridType = null;
            this.fld_dgcAPProposalsFilterGridControl.BOSPrivilege = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcAPProposalsFilterGridControl.BOSPropertyName = global::Localization.CommonLocalizedResources.String1;
            this.fld_dgcAPProposalsFilterGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPProposalsFilterGridControl.Location = new System.Drawing.Point(0, 22);
            this.fld_dgcAPProposalsFilterGridControl.MainView = this.gridView1;
            this.fld_dgcAPProposalsFilterGridControl.Name = "fld_dgcAPProposalsFilterGridControl";
            this.fld_dgcAPProposalsFilterGridControl.PrintReport = false;
            this.fld_dgcAPProposalsFilterGridControl.Screen = null;
            this.fld_dgcAPProposalsFilterGridControl.Size = new System.Drawing.Size(862, 381);
            this.fld_dgcAPProposalsFilterGridControl.TabIndex = 5;
            this.fld_dgcAPProposalsFilterGridControl.Tag = "DC";
            this.fld_dgcAPProposalsFilterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.fld_dgcAPProposalsFilterGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // fld_dgvGEHistoryDetails
            // 
            this.fld_dgvGEHistoryDetails.Name = "fld_dgvGEHistoryDetails";
            this.fld_dgvGEHistoryDetails.PaintStyleName = "Office2003";
            // 
            // DMHM111
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 479);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMHM111";
            this.Text = "Thông tin đơn mua hàng";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.bosPanel2.ResumeLayout(false);
            this.bosPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeAPProposalStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteAPProposalToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPProposalsFilterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEHistoryDetails)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteAPProposalFromDate;
        private BOSComponent.BOSLabel fld_lblLabel61;
        private BOSComponent.BOSLabel fld_lblLabel62;
        private BOSComponent.BOSDateEdit fld_dteAPProposalToDate;
        private BOSComponent.BOSButton fld_btnShow;
        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEHistoryDetails;
        private BOSLookupEdit fld_lkeAPProposalStatus;
        private BOSComponent.BOSLabel bosLabel1;
        private APPurchaseProposalsGridControl fld_dgcAPProposalsFilterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
	}
}
