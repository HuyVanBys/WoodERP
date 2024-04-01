using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PaintProcessConfig.UI
{
	/// <summary>
	/// Summary description for SMNTS100
	/// </summary>
    partial class SMPPC100
    {
		private BOSComponent.BOSTextBox fld_txtMMProcessNo;
        private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel3;
        private BOSComponent.BOSLabel fld_lblLabel4;
		private BOSComponent.BOSDateEdit fld_dteSearchFromMMProcessDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToMMProcessDate;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMPPC100));
            this.fld_txtMMProcessNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromMMProcessDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToMMProcessDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dgcMMPaintProcessConfigs = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.bosLookupEdit3 = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProcessNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMProcessDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMProcessDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMProcessDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMProcessDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPaintProcessConfigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtMMProcessNo
            // 
            this.fld_txtMMProcessNo.BOSComment = "";
            this.fld_txtMMProcessNo.BOSDataMember = "MMPaintProcessConfigNo";
            this.fld_txtMMProcessNo.BOSDataSource = "MMPaintProcessConfigs";
            this.fld_txtMMProcessNo.BOSDescription = null;
            this.fld_txtMMProcessNo.BOSError = null;
            this.fld_txtMMProcessNo.BOSFieldGroup = "";
            this.fld_txtMMProcessNo.BOSFieldRelation = "";
            this.fld_txtMMProcessNo.BOSPrivilege = "";
            this.fld_txtMMProcessNo.BOSPropertyName = "Text";
            this.fld_txtMMProcessNo.EditValue = "";
            this.fld_txtMMProcessNo.Location = new System.Drawing.Point(130, 20);
            this.fld_txtMMProcessNo.Name = "fld_txtMMProcessNo";
            this.fld_txtMMProcessNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProcessNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProcessNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProcessNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProcessNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProcessNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProcessNo.Screen = null;
            this.fld_txtMMProcessNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProcessNo.TabIndex = 0;
            this.fld_txtMMProcessNo.Tag = "SC";
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = "";
            this.fld_lblLabel.Location = new System.Drawing.Point(47, 23);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 5;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(47, 102);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(40, 13);
            this.fld_lblLabel3.TabIndex = 8;
            this.fld_lblLabel3.Tag = "SI";
            this.fld_lblLabel3.Text = "Từ ngày";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = "";
            this.fld_lblLabel4.BOSDataMember = "";
            this.fld_lblLabel4.BOSDataSource = "";
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = "";
            this.fld_lblLabel4.BOSFieldRelation = "";
            this.fld_lblLabel4.BOSPrivilege = "";
            this.fld_lblLabel4.BOSPropertyName = "";
            this.fld_lblLabel4.Location = new System.Drawing.Point(309, 102);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(47, 13);
            this.fld_lblLabel4.TabIndex = 9;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Đến ngày";
            // 
            // fld_dteSearchFromMMProcessDate
            // 
            this.fld_dteSearchFromMMProcessDate.BOSComment = "";
            this.fld_dteSearchFromMMProcessDate.BOSDataMember = "MMPaintProcessConfigDateFrom";
            this.fld_dteSearchFromMMProcessDate.BOSDataSource = "MMPaintProcessConfigs";
            this.fld_dteSearchFromMMProcessDate.BOSDescription = null;
            this.fld_dteSearchFromMMProcessDate.BOSError = null;
            this.fld_dteSearchFromMMProcessDate.BOSFieldGroup = "";
            this.fld_dteSearchFromMMProcessDate.BOSFieldRelation = "";
            this.fld_dteSearchFromMMProcessDate.BOSPrivilege = "";
            this.fld_dteSearchFromMMProcessDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromMMProcessDate.EditValue = null;
            this.fld_dteSearchFromMMProcessDate.Location = new System.Drawing.Point(130, 98);
            this.fld_dteSearchFromMMProcessDate.Name = "fld_dteSearchFromMMProcessDate";
            this.fld_dteSearchFromMMProcessDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromMMProcessDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromMMProcessDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromMMProcessDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromMMProcessDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromMMProcessDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromMMProcessDate.Screen = null;
            this.fld_dteSearchFromMMProcessDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromMMProcessDate.TabIndex = 4;
            this.fld_dteSearchFromMMProcessDate.Tag = "SC";
            // 
            // fld_dteSearchToMMProcessDate
            // 
            this.fld_dteSearchToMMProcessDate.BOSComment = "";
            this.fld_dteSearchToMMProcessDate.BOSDataMember = "MMPaintProcessConfigDateTo";
            this.fld_dteSearchToMMProcessDate.BOSDataSource = "MMPaintProcessConfigs";
            this.fld_dteSearchToMMProcessDate.BOSDescription = null;
            this.fld_dteSearchToMMProcessDate.BOSError = null;
            this.fld_dteSearchToMMProcessDate.BOSFieldGroup = "";
            this.fld_dteSearchToMMProcessDate.BOSFieldRelation = "";
            this.fld_dteSearchToMMProcessDate.BOSPrivilege = "";
            this.fld_dteSearchToMMProcessDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToMMProcessDate.EditValue = null;
            this.fld_dteSearchToMMProcessDate.Location = new System.Drawing.Point(382, 98);
            this.fld_dteSearchToMMProcessDate.Name = "fld_dteSearchToMMProcessDate";
            this.fld_dteSearchToMMProcessDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToMMProcessDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToMMProcessDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToMMProcessDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToMMProcessDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToMMProcessDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToMMProcessDate.Screen = null;
            this.fld_dteSearchToMMProcessDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToMMProcessDate.TabIndex = 5;
            this.fld_dteSearchToMMProcessDate.Tag = "SC";
            // 
            // fld_dgcMMPaintProcessConfigs
            // 
            this.fld_dgcMMPaintProcessConfigs.BOSComment = null;
            this.fld_dgcMMPaintProcessConfigs.BOSDataMember = null;
            this.fld_dgcMMPaintProcessConfigs.BOSDataSource = "MMPaintProcessConfigs";
            this.fld_dgcMMPaintProcessConfigs.BOSDescription = null;
            this.fld_dgcMMPaintProcessConfigs.BOSError = null;
            this.fld_dgcMMPaintProcessConfigs.BOSFieldGroup = null;
            this.fld_dgcMMPaintProcessConfigs.BOSFieldRelation = null;
            this.fld_dgcMMPaintProcessConfigs.BOSGridType = null;
            this.fld_dgcMMPaintProcessConfigs.BOSPrivilege = null;
            this.fld_dgcMMPaintProcessConfigs.BOSPropertyName = null;
            this.fld_dgcMMPaintProcessConfigs.CommodityType = "";
            this.fld_dgcMMPaintProcessConfigs.Location = new System.Drawing.Point(13, 165);
            this.fld_dgcMMPaintProcessConfigs.MenuManager = this.screenToolbar;
            this.fld_dgcMMPaintProcessConfigs.Name = "fld_dgcMMPaintProcessConfigs";
            this.fld_dgcMMPaintProcessConfigs.PrintReport = false;
            this.fld_dgcMMPaintProcessConfigs.Screen = null;
            this.fld_dgcMMPaintProcessConfigs.Size = new System.Drawing.Size(868, 398);
            this.fld_dgcMMPaintProcessConfigs.TabIndex = 10;
            this.fld_dgcMMPaintProcessConfigs.Tag = "SR";
            // 
            // bosLabel3
            // 
            this.bosLabel3.BOSComment = null;
            this.bosLabel3.BOSDataMember = null;
            this.bosLabel3.BOSDataSource = null;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = null;
            this.bosLabel3.BOSFieldRelation = null;
            this.bosLabel3.BOSPrivilege = null;
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(47, 49);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 12;
            this.bosLabel3.Text = "Nhân viên";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = false;
            this.fld_lkeFK_HREmployeeID.BOSComment = "";
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "MMPaintProcessConfigs";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = "";
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = "";
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = "";
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = "";
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = "";
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = "";
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(130, 46);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.ColumnName = null;
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "Mã người bán"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Tên người bán")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = "";
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeFK_HREmployeeID, true);
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 1;
            this.fld_lkeFK_HREmployeeID.Tag = "DC";
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(47, 75);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.bosLabel9.Size = new System.Drawing.Size(49, 13);
            this.bosLabel9.TabIndex = 15;
            this.bosLabel9.Text = "Trạng thái";
            // 
            // bosLookupEdit3
            // 
            this.bosLookupEdit3.BOSAllowAddNew = false;
            this.bosLookupEdit3.BOSAllowDummy = false;
            this.bosLookupEdit3.BOSComment = null;
            this.bosLookupEdit3.BOSDataMember = "MMPaintProcessConfigStatus";
            this.bosLookupEdit3.BOSDataSource = "MMPaintProcessConfigs";
            this.bosLookupEdit3.BOSDescription = null;
            this.bosLookupEdit3.BOSError = null;
            this.bosLookupEdit3.BOSFieldGroup = null;
            this.bosLookupEdit3.BOSFieldParent = null;
            this.bosLookupEdit3.BOSFieldRelation = null;
            this.bosLookupEdit3.BOSPrivilege = null;
            this.bosLookupEdit3.BOSPropertyName = "EditValue";
            this.bosLookupEdit3.BOSSelectType = null;
            this.bosLookupEdit3.BOSSelectTypeValue = null;
            this.bosLookupEdit3.CurrentDisplayText = null;
            this.bosLookupEdit3.Location = new System.Drawing.Point(130, 72);
            this.bosLookupEdit3.MenuManager = this.screenToolbar;
            this.bosLookupEdit3.Name = "bosLookupEdit3";
            this.bosLookupEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bosLookupEdit3.Properties.ColumnName = null;
            this.bosLookupEdit3.Properties.NullText = "";
            this.bosLookupEdit3.Screen = null;
            this.bosLookupEdit3.Size = new System.Drawing.Size(150, 20);
            this.bosLookupEdit3.TabIndex = 3;
            this.bosLookupEdit3.Tag = "DC";
            // 
            // SMPPC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(910, 582);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Controls.Add(this.bosLabel9);
            this.Controls.Add(this.bosLookupEdit3);
            this.Controls.Add(this.fld_dgcMMPaintProcessConfigs);
            this.Controls.Add(this.fld_txtMMProcessNo);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel3);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_dteSearchFromMMProcessDate);
            this.Controls.Add(this.fld_dteSearchToMMProcessDate);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("SMPPC100.IconOptions.Icon")));
            this.Name = "SMPPC100";
            this.Tag = "SI";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteSearchToMMProcessDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromMMProcessDate, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_txtMMProcessNo, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMPaintProcessConfigs, 0);
            this.Controls.SetChildIndex(this.bosLookupEdit3, 0);
            this.Controls.SetChildIndex(this.bosLabel9, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProcessNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMProcessDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromMMProcessDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMProcessDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToMMProcessDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMPaintProcessConfigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosLookupEdit3.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcMMPaintProcessConfigs;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;
        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSLookupEdit bosLookupEdit3;
    }
}
