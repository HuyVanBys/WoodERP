using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.MoneyChange.UI
{
	/// <summary>
    /// Summary description for SMMOC100
	/// </summary>
    partial class SMMOC100
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
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACMoneyChangeNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dteACMoneyChangeFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteACMoneyChangeToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_dgcACMoneyChanges = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvACDocument = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACMoneyChangeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACMoneyChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocument)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel.Location = new System.Drawing.Point(29, 23);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 24;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_lblLabel4
            // 
            this.fld_lblLabel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel4.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel4.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSDescription = null;
            this.fld_lblLabel4.BOSError = null;
            this.fld_lblLabel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel4.Location = new System.Drawing.Point(29, 75);
            this.fld_lblLabel4.Name = "fld_lblLabel4";
            this.fld_lblLabel4.Screen = null;
            this.fld_lblLabel4.Size = new System.Drawing.Size(72, 13);
            this.fld_lblLabel4.TabIndex = 28;
            this.fld_lblLabel4.Tag = "SI";
            this.fld_lblLabel4.Text = "Ngày chứng từ";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel5.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel5.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel5.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel5.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel5.Location = new System.Drawing.Point(290, 75);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(20, 13);
            this.fld_lblLabel5.TabIndex = 29;
            this.fld_lblLabel5.Tag = "SI";
            this.fld_lblLabel5.Text = "Đến";
            // 
            // fld_txtACMoneyChangeNo
            // 
            this.fld_txtACMoneyChangeNo.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACMoneyChangeNo.BOSDataMember = "ACMoneyChangeNo";
            this.fld_txtACMoneyChangeNo.BOSDataSource = "ACMoneyChanges";
            this.fld_txtACMoneyChangeNo.BOSDescription = null;
            this.fld_txtACMoneyChangeNo.BOSError = null;
            this.fld_txtACMoneyChangeNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACMoneyChangeNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACMoneyChangeNo.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACMoneyChangeNo.BOSPropertyName = "Text";
            this.fld_txtACMoneyChangeNo.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACMoneyChangeNo.Location = new System.Drawing.Point(112, 20);
            this.fld_txtACMoneyChangeNo.Name = "fld_txtACMoneyChangeNo";
            this.fld_txtACMoneyChangeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACMoneyChangeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACMoneyChangeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACMoneyChangeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACMoneyChangeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACMoneyChangeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACMoneyChangeNo.Screen = null;
            this.fld_txtACMoneyChangeNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACMoneyChangeNo.TabIndex = 0;
            this.fld_txtACMoneyChangeNo.Tag = "SC";
            // 
            // fld_dteACMoneyChangeFromDate
            // 
            this.fld_dteACMoneyChangeFromDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACMoneyChangeFromDate.BOSDataMember = "ACMoneyChangeFromDate";
            this.fld_dteACMoneyChangeFromDate.BOSDataSource = "ACMoneyChanges";
            this.fld_dteACMoneyChangeFromDate.BOSDescription = null;
            this.fld_dteACMoneyChangeFromDate.BOSError = null;
            this.fld_dteACMoneyChangeFromDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACMoneyChangeFromDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACMoneyChangeFromDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACMoneyChangeFromDate.BOSPropertyName = "EditValue";
            this.fld_dteACMoneyChangeFromDate.EditValue = null;
            this.fld_dteACMoneyChangeFromDate.Location = new System.Drawing.Point(112, 72);
            this.fld_dteACMoneyChangeFromDate.Name = "fld_dteACMoneyChangeFromDate";
            this.fld_dteACMoneyChangeFromDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACMoneyChangeFromDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACMoneyChangeFromDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACMoneyChangeFromDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACMoneyChangeFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACMoneyChangeFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACMoneyChangeFromDate.Screen = null;
            this.fld_dteACMoneyChangeFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACMoneyChangeFromDate.TabIndex = 2;
            this.fld_dteACMoneyChangeFromDate.Tag = "SC";
            // 
            // fld_dteACMoneyChangeToDate
            // 
            this.fld_dteACMoneyChangeToDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACMoneyChangeToDate.BOSDataMember = "ACMoneyChangeToDate";
            this.fld_dteACMoneyChangeToDate.BOSDataSource = "ACMoneyChanges";
            this.fld_dteACMoneyChangeToDate.BOSDescription = null;
            this.fld_dteACMoneyChangeToDate.BOSError = null;
            this.fld_dteACMoneyChangeToDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACMoneyChangeToDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACMoneyChangeToDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteACMoneyChangeToDate.BOSPropertyName = "EditValue";
            this.fld_dteACMoneyChangeToDate.EditValue = null;
            this.fld_dteACMoneyChangeToDate.Location = new System.Drawing.Point(334, 72);
            this.fld_dteACMoneyChangeToDate.Name = "fld_dteACMoneyChangeToDate";
            this.fld_dteACMoneyChangeToDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteACMoneyChangeToDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteACMoneyChangeToDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteACMoneyChangeToDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteACMoneyChangeToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteACMoneyChangeToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteACMoneyChangeToDate.Screen = null;
            this.fld_dteACMoneyChangeToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteACMoneyChangeToDate.TabIndex = 3;
            this.fld_dteACMoneyChangeToDate.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(29, 49);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(48, 13);
            this.bosLabel2.TabIndex = 40;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "ACMoneyChanges";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(112, 46);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.ColumnName = null;
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 1;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // fld_dgcACMoneyChanges
            // 
            this.fld_dgcACMoneyChanges.AllowDrop = true;
            this.fld_dgcACMoneyChanges.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACMoneyChanges.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACMoneyChanges.BOSDataSource = "ACMoneyChanges";
            this.fld_dgcACMoneyChanges.BOSDescription = null;
            this.fld_dgcACMoneyChanges.BOSError = null;
            this.fld_dgcACMoneyChanges.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACMoneyChanges.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACMoneyChanges.BOSGridType = null;
            this.fld_dgcACMoneyChanges.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACMoneyChanges.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACMoneyChanges.CommodityType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcACMoneyChanges.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcACMoneyChanges.Location = new System.Drawing.Point(49, 151);
            this.fld_dgcACMoneyChanges.MainView = this.fld_dgvACDocument;
            this.fld_dgcACMoneyChanges.Name = "fld_dgcACMoneyChanges";
            this.fld_dgcACMoneyChanges.PrintReport = false;
            this.fld_dgcACMoneyChanges.Screen = null;
            this.fld_dgcACMoneyChanges.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACMoneyChanges.TabIndex = 41;
            this.fld_dgcACMoneyChanges.Tag = "SR";
            this.fld_dgcACMoneyChanges.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvACDocument});
            // 
            // fld_dgvACDocument
            // 
            this.fld_dgvACDocument.GridControl = this.fld_dgcACMoneyChanges;
            this.fld_dgvACDocument.Name = "fld_dgvACDocument";
            this.fld_dgvACDocument.PaintStyleName = "Office2003";
            // 
            // SMMOC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(540, 430);
            this.Controls.Add(this.fld_dgcACMoneyChanges);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel4);
            this.Controls.Add(this.fld_lblLabel5);
            this.Controls.Add(this.fld_txtACMoneyChangeNo);
            this.Controls.Add(this.fld_dteACMoneyChangeFromDate);
            this.Controls.Add(this.fld_dteACMoneyChangeToDate);
            this.Name = "SMMOC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dteACMoneyChangeToDate, 0);
            this.Controls.SetChildIndex(this.fld_dteACMoneyChangeFromDate, 0);
            this.Controls.SetChildIndex(this.fld_txtACMoneyChangeNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel5, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel4, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcACMoneyChanges, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACMoneyChangeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteACMoneyChangeToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACMoneyChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvACDocument)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel4;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSTextBox fld_txtACMoneyChangeNo;
        private BOSComponent.BOSDateEdit fld_dteACMoneyChangeFromDate;
        private BOSComponent.BOSDateEdit fld_dteACMoneyChangeToDate;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
        private BOSSearchResultsGridControl fld_dgcACMoneyChanges;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvACDocument;
	}
}
