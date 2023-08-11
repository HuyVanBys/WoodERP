using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.EmployeeLeaveCalculate.UI
{
	/// <summary>
	/// Summary description for DMELC100
	/// </summary>
	partial class DMELC100
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
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLastDateCal = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLastYear = new BOSComponent.BOSLabel(this.components);
            this.bosLabel7 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteYearDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_btnCalculate = new BOSComponent.BOSButton(this.components);
            this.fld_btnRemove = new BOSComponent.BOSButton(this.components);
            this.fld_btnView = new BOSComponent.BOSButton(this.components);
            this.fld_dgcHREmployeeLRegs = new BOSERP.Modules.EmployeeLeaveCalculate.EmployeeLeaveCalculateGridControl();
            this.bosPanel2 = new BOSComponent.BOSPanel(this.components);
            this.fld_btnSave = new BOSComponent.BOSButton(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteYearDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteYearDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeLRegs)).BeginInit();
            this.bosPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.fld_btnSave);
            this.bosPanel1.Controls.Add(this.bosLabel1);
            this.bosPanel1.Controls.Add(this.fld_lblLastDateCal);
            this.bosPanel1.Controls.Add(this.fld_lblLastYear);
            this.bosPanel1.Controls.Add(this.bosLabel7);
            this.bosPanel1.Controls.Add(this.fld_lblLabel4);
            this.bosPanel1.Controls.Add(this.fld_dteYearDate);
            this.bosPanel1.Controls.Add(this.fld_btnCalculate);
            this.bosPanel1.Controls.Add(this.fld_btnRemove);
            this.bosPanel1.Controls.Add(this.fld_btnView);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Size = new System.Drawing.Size(881, 101);
            this.bosPanel1.TabIndex = 0;
            // 
            // bosLabel1
            // 
            this.bosLabel1.BOSComment = null;
            this.bosLabel1.BOSDataMember = null;
            this.bosLabel1.BOSDataSource = null;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = null;
            this.bosLabel1.BOSFieldRelation = null;
            this.bosLabel1.BOSPrivilege = null;
            this.bosLabel1.BOSPropertyName = null;
            this.bosLabel1.Location = new System.Drawing.Point(29, 79);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(116, 13);
            this.bosLabel1.TabIndex = 12;
            this.bosLabel1.Text = "Ngày cập nhật gần nhất";
            // 
            // fld_lblLastDateCal
            // 
            this.fld_lblLastDateCal.BOSComment = null;
            this.fld_lblLastDateCal.BOSDataMember = null;
            this.fld_lblLastDateCal.BOSDataSource = null;
            this.fld_lblLastDateCal.BOSDescription = null;
            this.fld_lblLastDateCal.BOSError = null;
            this.fld_lblLastDateCal.BOSFieldGroup = null;
            this.fld_lblLastDateCal.BOSFieldRelation = null;
            this.fld_lblLastDateCal.BOSPrivilege = null;
            this.fld_lblLastDateCal.BOSPropertyName = null;
            this.fld_lblLastDateCal.Location = new System.Drawing.Point(181, 79);
            this.fld_lblLastDateCal.Name = "fld_lblLastDateCal";
            this.fld_lblLastDateCal.Screen = null;
            this.fld_lblLastDateCal.Size = new System.Drawing.Size(56, 13);
            this.fld_lblLastDateCal.TabIndex = 12;
            this.fld_lblLastDateCal.Text = "00/00/0000";
            // 
            // fld_lblLastYear
            // 
            this.fld_lblLastYear.BOSComment = null;
            this.fld_lblLastYear.BOSDataMember = null;
            this.fld_lblLastYear.BOSDataSource = null;
            this.fld_lblLastYear.BOSDescription = null;
            this.fld_lblLastYear.BOSError = null;
            this.fld_lblLastYear.BOSFieldGroup = null;
            this.fld_lblLastYear.BOSFieldRelation = null;
            this.fld_lblLastYear.BOSPrivilege = null;
            this.fld_lblLastYear.BOSPropertyName = null;
            this.fld_lblLastYear.Location = new System.Drawing.Point(181, 55);
            this.fld_lblLastYear.Name = "fld_lblLastYear";
            this.fld_lblLastYear.Screen = null;
            this.fld_lblLastYear.Size = new System.Drawing.Size(24, 13);
            this.fld_lblLastYear.TabIndex = 12;
            this.fld_lblLastYear.Text = "0000";
            // 
            // bosLabel7
            // 
            this.bosLabel7.BOSComment = null;
            this.bosLabel7.BOSDataMember = null;
            this.bosLabel7.BOSDataSource = null;
            this.bosLabel7.BOSDescription = null;
            this.bosLabel7.BOSError = null;
            this.bosLabel7.BOSFieldGroup = null;
            this.bosLabel7.BOSFieldRelation = null;
            this.bosLabel7.BOSPrivilege = null;
            this.bosLabel7.BOSPropertyName = null;
            this.bosLabel7.Location = new System.Drawing.Point(29, 55);
            this.bosLabel7.Name = "bosLabel7";
            this.bosLabel7.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel7, true);
            this.bosLabel7.Size = new System.Drawing.Size(118, 13);
            this.bosLabel7.TabIndex = 12;
            this.bosLabel7.Text = "Năm chốt phép gần nhất";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.Location = new System.Drawing.Point(29, 22);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(48, 13);
            this.fld_lblLabel4.TabIndex = 10;
            this.fld_lblLabel4.Tag = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_lblLabel4.Text = "Chọn năm";
            // 
            // fld_dteYearDate
            // 
            this.fld_dteYearDate.BOSComment = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteYearDate.BOSDataMember = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteYearDate.BOSDataSource = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteYearDate.BOSDescription = null;
            this.fld_dteYearDate.BOSError = null;
            this.fld_dteYearDate.BOSFieldGroup = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteYearDate.BOSFieldRelation = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteYearDate.BOSPrivilege = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dteYearDate.BOSPropertyName = "EditValue";
            this.fld_dteYearDate.EditValue = null;
            this.fld_dteYearDate.Location = new System.Drawing.Point(106, 19);
            this.fld_dteYearDate.Name = "fld_dteYearDate";
            this.fld_dteYearDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteYearDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteYearDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteYearDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteYearDate.Properties.Appearance.Options.UseTextOptions = true;
            this.fld_dteYearDate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.fld_dteYearDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteYearDate.Properties.DisplayFormat.FormatString = "yyyy";
            this.fld_dteYearDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteYearDate.Properties.EditFormat.FormatString = "yyyy";
            this.fld_dteYearDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fld_dteYearDate.Properties.Mask.EditMask = "yyyy";
            this.fld_dteYearDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteYearDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fld_dteYearDate.Screen = null;
            this.fld_dteYearDate.Size = new System.Drawing.Size(75, 20);
            this.fld_dteYearDate.TabIndex = 9;
            this.fld_dteYearDate.Tag = "DC";
            // 
            // fld_btnCalculate
            // 
            this.fld_btnCalculate.AccessibleDescription = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_btnCalculate.BOSComment = null;
            this.fld_btnCalculate.BOSDataMember = null;
            this.fld_btnCalculate.BOSDataSource = null;
            this.fld_btnCalculate.BOSDescription = null;
            this.fld_btnCalculate.BOSError = null;
            this.fld_btnCalculate.BOSFieldGroup = null;
            this.fld_btnCalculate.BOSFieldRelation = null;
            this.fld_btnCalculate.BOSPrivilege = null;
            this.fld_btnCalculate.BOSPropertyName = null;
            this.fld_btnCalculate.Location = new System.Drawing.Point(232, 12);
            this.fld_btnCalculate.Name = "fld_btnCalculate";
            this.fld_btnCalculate.Screen = null;
            this.fld_btnCalculate.Size = new System.Drawing.Size(109, 27);
            this.fld_btnCalculate.TabIndex = 8;
            this.fld_btnCalculate.Text = "Chốt phép";
            this.fld_btnCalculate.Click += new System.EventHandler(this.fld_btnCalculate_Click);
            // 
            // fld_btnRemove
            // 
            this.fld_btnRemove.BOSComment = null;
            this.fld_btnRemove.BOSDataMember = null;
            this.fld_btnRemove.BOSDataSource = null;
            this.fld_btnRemove.BOSDescription = null;
            this.fld_btnRemove.BOSError = null;
            this.fld_btnRemove.BOSFieldGroup = null;
            this.fld_btnRemove.BOSFieldRelation = null;
            this.fld_btnRemove.BOSPrivilege = null;
            this.fld_btnRemove.BOSPropertyName = null;
            this.fld_btnRemove.Location = new System.Drawing.Point(361, 12);
            this.fld_btnRemove.Name = "fld_btnRemove";
            this.fld_btnRemove.Screen = null;
            this.fld_btnRemove.Size = new System.Drawing.Size(148, 27);
            this.fld_btnRemove.TabIndex = 8;
            this.fld_btnRemove.Text = "Xóa kết quả chốt phép";
            this.fld_btnRemove.Click += new System.EventHandler(this.fld_btnRemove_Click);
            // 
            // fld_btnView
            // 
            this.fld_btnView.BOSComment = null;
            this.fld_btnView.BOSDataMember = null;
            this.fld_btnView.BOSDataSource = null;
            this.fld_btnView.BOSDescription = null;
            this.fld_btnView.BOSError = null;
            this.fld_btnView.BOSFieldGroup = null;
            this.fld_btnView.BOSFieldRelation = null;
            this.fld_btnView.BOSPrivilege = null;
            this.fld_btnView.BOSPropertyName = null;
            this.fld_btnView.Location = new System.Drawing.Point(528, 12);
            this.fld_btnView.Name = "fld_btnView";
            this.fld_btnView.Screen = null;
            this.fld_btnView.Size = new System.Drawing.Size(93, 27);
            this.fld_btnView.TabIndex = 8;
            this.fld_btnView.Text = "Xem";
            this.fld_btnView.Click += new System.EventHandler(this.fld_btnView_Click);
            // 
            // fld_dgcHREmployeeLRegs
            // 
            this.fld_dgcHREmployeeLRegs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcHREmployeeLRegs.BOSComment = null;
            this.fld_dgcHREmployeeLRegs.BOSDataMember = null;
            this.fld_dgcHREmployeeLRegs.BOSDataSource = "HREmployeeLRegs";
            this.fld_dgcHREmployeeLRegs.BOSDescription = null;
            this.fld_dgcHREmployeeLRegs.BOSError = null;
            this.fld_dgcHREmployeeLRegs.BOSFieldGroup = null;
            this.fld_dgcHREmployeeLRegs.BOSFieldRelation = null;
            this.fld_dgcHREmployeeLRegs.BOSGridType = null;
            this.fld_dgcHREmployeeLRegs.BOSPrivilege = null;
            this.fld_dgcHREmployeeLRegs.BOSPropertyName = null;
            this.fld_dgcHREmployeeLRegs.CommodityType = global::Localization.SaleOrderLocalizedResources.String;
            this.fld_dgcHREmployeeLRegs.GridViewMain = null;
            this.fld_dgcHREmployeeLRegs.Location = new System.Drawing.Point(3, 107);
            this.fld_dgcHREmployeeLRegs.MenuManager = this.screenToolbar;
            this.fld_dgcHREmployeeLRegs.Name = "fld_dgcHREmployeeLRegs";
            this.fld_dgcHREmployeeLRegs.PrintReport = false;
            this.fld_dgcHREmployeeLRegs.RowHandle = 0;
            this.fld_dgcHREmployeeLRegs.Screen = null;
            this.fld_dgcHREmployeeLRegs.Size = new System.Drawing.Size(875, 457);
            this.fld_dgcHREmployeeLRegs.TabIndex = 0;
            this.fld_dgcHREmployeeLRegs.ViewDate = new System.DateTime(((long)(0)));
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
            this.bosPanel2.Controls.Add(this.bosPanel1);
            this.bosPanel2.Controls.Add(this.fld_dgcHREmployeeLRegs);
            this.bosPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel2.Location = new System.Drawing.Point(0, 0);
            this.bosPanel2.Name = "bosPanel2";
            this.bosPanel2.Screen = null;
            this.bosPanel2.Size = new System.Drawing.Size(881, 567);
            this.bosPanel2.TabIndex = 0;
            // 
            // fld_btnSave
            // 
            this.fld_btnSave.BOSComment = null;
            this.fld_btnSave.BOSDataMember = null;
            this.fld_btnSave.BOSDataSource = null;
            this.fld_btnSave.BOSDescription = null;
            this.fld_btnSave.BOSError = null;
            this.fld_btnSave.BOSFieldGroup = null;
            this.fld_btnSave.BOSFieldRelation = null;
            this.fld_btnSave.BOSPrivilege = null;
            this.fld_btnSave.BOSPropertyName = null;
            this.fld_btnSave.Location = new System.Drawing.Point(641, 12);
            this.fld_btnSave.Name = "fld_btnSave";
            this.fld_btnSave.Screen = null;
            this.fld_btnSave.Size = new System.Drawing.Size(93, 27);
            this.fld_btnSave.TabIndex = 13;
            this.fld_btnSave.Text = "Lưu";
            this.fld_btnSave.Click += new System.EventHandler(this.fld_btnSave_Click);
            // 
            // DMELC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(881, 567);
            this.Controls.Add(this.bosPanel2);
            this.Name = "DMELC100";
            this.Text = "Chốt phép";
            this.Controls.SetChildIndex(this.bosPanel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteYearDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteYearDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREmployeeLRegs)).EndInit();
            this.bosPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private BOSComponent.BOSButton fld_btnView;
        private EmployeeLeaveCalculateGridControl fld_dgcHREmployeeLRegs;
        private BOSComponent.BOSPanel bosPanel2;
        private BOSComponent.BOSDateEdit fld_dteYearDate;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSButton fld_btnCalculate;
        private BOSComponent.BOSButton fld_btnRemove;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel7;
        private BOSComponent.BOSLabel fld_lblLastDateCal;
        private BOSComponent.BOSLabel fld_lblLastYear;
        private BOSComponent.BOSButton fld_btnSave;
	}
}
