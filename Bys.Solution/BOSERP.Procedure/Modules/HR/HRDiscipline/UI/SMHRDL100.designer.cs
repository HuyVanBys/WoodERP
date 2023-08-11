using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HRDiscipline.UI
{
	/// <summary>
	/// Summary description for SMHRDL100
	/// </summary>
	partial class SMHRDL100
	{
		private BOSComponent.BOSLabel fld_lblLabel;
		private BOSComponent.BOSLabel fld_lblLabel1;
		private BOSComponent.BOSTextBox fld_txtHRDisciplineNo;
		private BOSComponent.BOSTextBox fld_txtHRDisciplineName;
		private BOSSearchResultsGridControl fld_dgcHRDiscipline;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRDisciplines;


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
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHRDisciplineNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHRDisciplineName = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcHRDiscipline = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHRDisciplines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDiscipline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDisciplines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel.Location = new System.Drawing.Point(108, 135);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(49, 13);
            this.fld_lblLabel.TabIndex = 4;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã kỷ luật";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lblLabel1.Location = new System.Drawing.Point(108, 161);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(26, 13);
            this.fld_lblLabel1.TabIndex = 5;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Lý do";
            // 
            // fld_txtHRDisciplineNo
            // 
            this.fld_txtHRDisciplineNo.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo.BOSDataMember = "HRDisciplineNo";
            this.fld_txtHRDisciplineNo.BOSDataSource = "HRDisciplines";
            this.fld_txtHRDisciplineNo.BOSDescription = null;
            this.fld_txtHRDisciplineNo.BOSError = null;
            this.fld_txtHRDisciplineNo.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo.BOSPropertyName = "Text";
            this.fld_txtHRDisciplineNo.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineNo.Location = new System.Drawing.Point(173, 132);
            this.fld_txtHRDisciplineNo.Name = "fld_txtHRDisciplineNo";
            this.fld_txtHRDisciplineNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDisciplineNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDisciplineNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDisciplineNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDisciplineNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDisciplineNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDisciplineNo.Screen = null;
            this.fld_txtHRDisciplineNo.Size = new System.Drawing.Size(152, 20);
            this.fld_txtHRDisciplineNo.TabIndex = 6;
            this.fld_txtHRDisciplineNo.Tag = "SC";
            // 
            // fld_txtHRDisciplineName
            // 
            this.fld_txtHRDisciplineName.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName.BOSDataMember = "HRDisciplineName";
            this.fld_txtHRDisciplineName.BOSDataSource = "HRDisciplines";
            this.fld_txtHRDisciplineName.BOSDescription = null;
            this.fld_txtHRDisciplineName.BOSError = null;
            this.fld_txtHRDisciplineName.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName.BOSPropertyName = "Text";
            this.fld_txtHRDisciplineName.EditValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_txtHRDisciplineName.Location = new System.Drawing.Point(173, 158);
            this.fld_txtHRDisciplineName.Name = "fld_txtHRDisciplineName";
            this.fld_txtHRDisciplineName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHRDisciplineName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHRDisciplineName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHRDisciplineName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHRDisciplineName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHRDisciplineName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHRDisciplineName.Screen = null;
            this.fld_txtHRDisciplineName.Size = new System.Drawing.Size(151, 20);
            this.fld_txtHRDisciplineName.TabIndex = 7;
            this.fld_txtHRDisciplineName.Tag = "SC";
            // 
            // fld_dgcHRDiscipline
            // 
            this.fld_dgcHRDiscipline.AllowDrop = true;
            this.fld_dgcHRDiscipline.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRDiscipline.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRDiscipline.BOSDataSource = "HRDisciplines";
            this.fld_dgcHRDiscipline.BOSDescription = null;
            this.fld_dgcHRDiscipline.BOSError = null;
            this.fld_dgcHRDiscipline.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRDiscipline.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRDiscipline.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_dgcHRDiscipline.BOSPropertyName = "Search Result";
            this.fld_dgcHRDiscipline.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRDiscipline.Location = new System.Drawing.Point(108, 235);
            this.fld_dgcHRDiscipline.MainView = this.fld_dgvHRDisciplines;
            this.fld_dgcHRDiscipline.Name = "fld_dgcHRDiscipline";
            this.fld_dgcHRDiscipline.Screen = null;
            this.fld_dgcHRDiscipline.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHRDiscipline.TabIndex = 8;
            this.fld_dgcHRDiscipline.Tag = "SR";
            this.fld_dgcHRDiscipline.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRDisciplines});
            // 
            // fld_dgvHRDisciplines
            // 
            this.fld_dgvHRDisciplines.GridControl = this.fld_dgcHRDiscipline;
            this.fld_dgvHRDisciplines.Name = "fld_dgvHRDisciplines";
            this.fld_dgvHRDisciplines.PaintStyleName = "Office2003";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataMember = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDataSource = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.BOSPropertyName = global::Localization.InvoiceLocalizedResources.Contact2;
            this.bosLabel3.Location = new System.Drawing.Point(108, 187);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(48, 13);
            this.bosLabel3.TabIndex = 20;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID
            // 
            this.fld_lkeFK_BRBranchID.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID.BOSComment = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID.BOSDataSource = "HRDisciplines";
            this.fld_lkeFK_BRBranchID.BOSDescription = null;
            this.fld_lkeFK_BRBranchID.BOSError = null;
            this.fld_lkeFK_BRBranchID.BOSFieldGroup = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldParent = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSFieldRelation = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPrivilege = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID.BOSSelectType = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.BOSSelectTypeValue = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID.Location = new System.Drawing.Point(173, 184);
            this.fld_lkeFK_BRBranchID.Name = "fld_lkeFK_BRBranchID";
            this.fld_lkeFK_BRBranchID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID.Properties.NullText = global::Localization.InvoiceLocalizedResources.Contact2;
            this.fld_lkeFK_BRBranchID.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID.Screen = null;
            this.fld_lkeFK_BRBranchID.Size = new System.Drawing.Size(152, 20);
            this.fld_lkeFK_BRBranchID.TabIndex = 19;
            this.fld_lkeFK_BRBranchID.Tag = "SC";
            // 
            // SMHRDL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeFK_BRBranchID);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_txtHRDisciplineNo);
            this.Controls.Add(this.fld_txtHRDisciplineName);
            this.Controls.Add(this.fld_dgcHRDiscipline);
            this.Name = "SMHRDL100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcHRDiscipline, 0);
            this.Controls.SetChildIndex(this.fld_txtHRDisciplineName, 0);
            this.Controls.SetChildIndex(this.fld_txtHRDisciplineNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHRDisciplineName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRDiscipline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRDisciplines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID;
	}
}
