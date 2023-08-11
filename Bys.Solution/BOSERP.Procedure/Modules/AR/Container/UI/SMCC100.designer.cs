using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Container.UI
{
	/// <summary>
	/// Summary description for SMPT100
	/// </summary>
	partial class SMCC100
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
            this.fld_medGEContainerName = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lkeGEContainerType = new BOSComponent.BOSLookupEdit(this.components);
            this.fld_txtGEContainerNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcGEContainer = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvGEPaymentTerm = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_lbLoai = new BOSComponent.BOSLabel(this.components);
            this.fld_lbPaymentTermNo = new BOSComponent.BOSLabel(this.components);
            this.fld_lbPaymentTermName = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medGEContainerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGEContainerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEPaymentTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_medGEContainerName
            // 
            this.fld_medGEContainerName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEContainerName.BOSDataMember = "GEContainerName";
            this.fld_medGEContainerName.BOSDataSource = "GEContainers";
            this.fld_medGEContainerName.BOSDescription = null;
            this.fld_medGEContainerName.BOSError = null;
            this.fld_medGEContainerName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEContainerName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEContainerName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEContainerName.BOSPropertyName = "Text";
            this.fld_medGEContainerName.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_medGEContainerName.Location = new System.Drawing.Point(146, 36);
            this.fld_medGEContainerName.Name = "fld_medGEContainerName";
            this.fld_medGEContainerName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medGEContainerName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medGEContainerName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medGEContainerName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medGEContainerName.Screen = null;
            this.fld_medGEContainerName.Size = new System.Drawing.Size(315, 43);
            this.fld_medGEContainerName.TabIndex = 22;
            this.fld_medGEContainerName.Tag = "SC";
            // 
            // fld_lkeGEContainerType
            // 
            this.fld_lkeGEContainerType.BOSAllowAddNew = false;
            this.fld_lkeGEContainerType.BOSAllowDummy = false;
            this.fld_lkeGEContainerType.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSDataMember = "GEContainerType";
            this.fld_lkeGEContainerType.BOSDataSource = "GEContainers";
            this.fld_lkeGEContainerType.BOSDescription = null;
            this.fld_lkeGEContainerType.BOSError = null;
            this.fld_lkeGEContainerType.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSFieldParent = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSPropertyName = "EditValue";
            this.fld_lkeGEContainerType.BOSSelectType = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.CurrentDisplayText = null;
            this.fld_lkeGEContainerType.Location = new System.Drawing.Point(146, 85);
            this.fld_lkeGEContainerType.Name = "fld_lkeGEContainerType";
            this.fld_lkeGEContainerType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeGEContainerType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeGEContainerType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeGEContainerType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeGEContainerType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGEContainerType.Properties.NullText = global::Localization.ReportLocalizedResources.String1;
            this.fld_lkeGEContainerType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeGEContainerType.Screen = null;
            this.fld_lkeGEContainerType.Size = new System.Drawing.Size(315, 20);
            this.fld_lkeGEContainerType.TabIndex = 24;
            this.fld_lkeGEContainerType.Tag = "SC";
            // 
            // fld_txtGEContainerNo
            // 
            this.fld_txtGEContainerNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.BOSDataMember = "GEContainerNo";
            this.fld_txtGEContainerNo.BOSDataSource = "GEContainers";
            this.fld_txtGEContainerNo.BOSDescription = null;
            this.fld_txtGEContainerNo.BOSError = null;
            this.fld_txtGEContainerNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.BOSPropertyName = "Text";
            this.fld_txtGEContainerNo.EditValue = global::Localization.ReportLocalizedResources.String1;
            this.fld_txtGEContainerNo.Location = new System.Drawing.Point(146, 10);
            this.fld_txtGEContainerNo.Name = "fld_txtGEContainerNo";
            this.fld_txtGEContainerNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtGEContainerNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtGEContainerNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtGEContainerNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtGEContainerNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtGEContainerNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtGEContainerNo.Screen = null;
            this.fld_txtGEContainerNo.Size = new System.Drawing.Size(133, 20);
            this.fld_txtGEContainerNo.TabIndex = 21;
            this.fld_txtGEContainerNo.Tag = "SC";
            // 
            // fld_dgcGEContainer
            // 
            this.fld_dgcGEContainer.AllowDrop = true;
            this.fld_dgcGEContainer.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEContainer.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEContainer.BOSDataSource = "GEContainers";
            this.fld_dgcGEContainer.BOSDescription = null;
            this.fld_dgcGEContainer.BOSError = null;
            this.fld_dgcGEContainer.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEContainer.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEContainer.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEContainer.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_dgcGEContainer.Font = new System.Drawing.Font("Arial", 8.25F);
            this.fld_dgcGEContainer.Location = new System.Drawing.Point(30, 124);
            this.fld_dgcGEContainer.MainView = this.fld_dgvGEPaymentTerm;
            this.fld_dgcGEContainer.Name = "fld_dgcGEContainer";
            this.fld_dgcGEContainer.Screen = null;
            this.fld_dgcGEContainer.Size = new System.Drawing.Size(508, 428);
            this.fld_dgcGEContainer.TabIndex = 25;
            this.fld_dgcGEContainer.Tag = "SR";
            this.fld_dgcGEContainer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvGEPaymentTerm});
            // 
            // fld_dgvGEPaymentTerm
            // 
            this.fld_dgvGEPaymentTerm.GridControl = this.fld_dgcGEContainer;
            this.fld_dgvGEPaymentTerm.Name = "fld_dgvGEPaymentTerm";
            this.fld_dgvGEPaymentTerm.PaintStyleName = "Office2003";
            // 
            // fld_lbLoai
            // 
            this.fld_lbLoai.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbLoai.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lbLoai.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbLoai.Appearance.Options.UseBackColor = true;
            this.fld_lbLoai.Appearance.Options.UseFont = true;
            this.fld_lbLoai.Appearance.Options.UseForeColor = true;
            this.fld_lbLoai.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSDescription = null;
            this.fld_lbLoai.BOSError = null;
            this.fld_lbLoai.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbLoai.Location = new System.Drawing.Point(4, 88);
            this.fld_lbLoai.Name = "fld_lbLoai";
            this.fld_lbLoai.Screen = null;
            this.fld_lbLoai.Size = new System.Drawing.Size(67, 13);
            this.fld_lbLoai.TabIndex = 27;
            this.fld_lbLoai.Tag = "SI";
            this.fld_lbLoai.Text = "Loại container";
            // 
            // fld_lbPaymentTermNo
            // 
            this.fld_lbPaymentTermNo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermNo.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermNo.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTermNo.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTermNo.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSDescription = null;
            this.fld_lbPaymentTermNo.BOSError = null;
            this.fld_lbPaymentTermNo.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermNo.Location = new System.Drawing.Point(4, 13);
            this.fld_lbPaymentTermNo.Name = "fld_lbPaymentTermNo";
            this.fld_lbPaymentTermNo.Screen = null;
            this.fld_lbPaymentTermNo.Size = new System.Drawing.Size(64, 13);
            this.fld_lbPaymentTermNo.TabIndex = 26;
            this.fld_lbPaymentTermNo.Tag = "SI";
            this.fld_lbPaymentTermNo.Text = "Mã Container";
            // 
            // fld_lbPaymentTermName
            // 
            this.fld_lbPaymentTermName.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lbPaymentTermName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lbPaymentTermName.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lbPaymentTermName.Appearance.Options.UseBackColor = true;
            this.fld_lbPaymentTermName.Appearance.Options.UseFont = true;
            this.fld_lbPaymentTermName.Appearance.Options.UseForeColor = true;
            this.fld_lbPaymentTermName.BOSComment = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDataMember = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDataSource = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSDescription = null;
            this.fld_lbPaymentTermName.BOSError = null;
            this.fld_lbPaymentTermName.BOSFieldGroup = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSFieldRelation = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSPrivilege = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.BOSPropertyName = global::Localization.ReportLocalizedResources.String1;
            this.fld_lbPaymentTermName.Location = new System.Drawing.Point(4, 39);
            this.fld_lbPaymentTermName.Name = "fld_lbPaymentTermName";
            this.fld_lbPaymentTermName.Screen = null;
            this.fld_lbPaymentTermName.Size = new System.Drawing.Size(66, 13);
            this.fld_lbPaymentTermName.TabIndex = 23;
            this.fld_lbPaymentTermName.Tag = "SI";
            this.fld_lbPaymentTermName.Text = "Tên container";
            // 
            // SMCC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(572, 567);
            this.Controls.Add(this.fld_medGEContainerName);
            this.Controls.Add(this.fld_lkeGEContainerType);
            this.Controls.Add(this.fld_txtGEContainerNo);
            this.Controls.Add(this.fld_dgcGEContainer);
            this.Controls.Add(this.fld_lbLoai);
            this.Controls.Add(this.fld_lbPaymentTermNo);
            this.Controls.Add(this.fld_lbPaymentTermName);
            this.Name = "SMCC100";
            this.Tag = "SM";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_lbPaymentTermName, 0);
            this.Controls.SetChildIndex(this.fld_lbPaymentTermNo, 0);
            this.Controls.SetChildIndex(this.fld_lbLoai, 0);
            this.Controls.SetChildIndex(this.fld_dgcGEContainer, 0);
            this.Controls.SetChildIndex(this.fld_txtGEContainerNo, 0);
            this.Controls.SetChildIndex(this.fld_lkeGEContainerType, 0);
            this.Controls.SetChildIndex(this.fld_medGEContainerName, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_medGEContainerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGEContainerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtGEContainerNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcGEContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvGEPaymentTerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSMemoEdit fld_medGEContainerName;
        private BOSComponent.BOSLookupEdit fld_lkeGEContainerType;
        private BOSComponent.BOSTextBox fld_txtGEContainerNo;
        private BOSSearchResultsGridControl fld_dgcGEContainer;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvGEPaymentTerm;
        private BOSComponent.BOSLabel fld_lbLoai;
        private BOSComponent.BOSLabel fld_lbPaymentTermNo;
        private BOSComponent.BOSLabel fld_lbPaymentTermName;
        private IContainer components;
	}
}
