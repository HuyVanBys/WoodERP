using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.MergeBOMChange.UI
{
	/// <summary>
	/// Summary description for SMMBC100
	/// </summary>
	partial class SMMBC100
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
            this.fld_txtMMMergeBOMChangeNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_dgcMMMergeBOMChanges = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvMMMergeBOMChanges = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMergeBOMChangeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMMergeBOMChanges)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDataSource = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_lblLabel.Location = new System.Drawing.Point(24, 15);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(61, 13);
            this.fld_lblLabel.TabIndex = 366;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã chứng từ";
            // 
            // fld_txtMMMergeBOMChangeNo
            // 
            this.fld_txtMMMergeBOMChangeNo.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMMergeBOMChangeNo.BOSDataMember = "MMMergeBOMChangeNo";
            this.fld_txtMMMergeBOMChangeNo.BOSDataSource = "MMMergeBOMChanges";
            this.fld_txtMMMergeBOMChangeNo.BOSDescription = null;
            this.fld_txtMMMergeBOMChangeNo.BOSError = null;
            this.fld_txtMMMergeBOMChangeNo.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMMergeBOMChangeNo.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMMergeBOMChangeNo.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMMergeBOMChangeNo.BOSPropertyName = "Text";
            this.fld_txtMMMergeBOMChangeNo.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMMergeBOMChangeNo.Location = new System.Drawing.Point(92, 12);
            this.fld_txtMMMergeBOMChangeNo.Name = "fld_txtMMMergeBOMChangeNo";
            this.fld_txtMMMergeBOMChangeNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMMergeBOMChangeNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMMergeBOMChangeNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMMergeBOMChangeNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMMergeBOMChangeNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMMergeBOMChangeNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMMergeBOMChangeNo.Screen = null;
            this.fld_txtMMMergeBOMChangeNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMMergeBOMChangeNo.TabIndex = 357;
            this.fld_txtMMMergeBOMChangeNo.Tag = "SC";
            // 
            // fld_dgcMMMergeBOMChanges
            // 
            this.fld_dgcMMMergeBOMChanges.AllowDrop = true;
            this.fld_dgcMMMergeBOMChanges.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMMergeBOMChanges.BOSDataMember = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMMergeBOMChanges.BOSDataSource = "MMMergeBOMChanges";
            this.fld_dgcMMMergeBOMChanges.BOSDescription = null;
            this.fld_dgcMMMergeBOMChanges.BOSError = null;
            this.fld_dgcMMMergeBOMChanges.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMMergeBOMChanges.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMMergeBOMChanges.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMMergeBOMChanges.BOSPropertyName = global::Localization.MESLocalizedResources.String1;
            this.fld_dgcMMMergeBOMChanges.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcMMMergeBOMChanges.Location = new System.Drawing.Point(92, 211);
            this.fld_dgcMMMergeBOMChanges.MainView = this.fld_dgvMMMergeBOMChanges;
            this.fld_dgcMMMergeBOMChanges.Name = "fld_dgcMMMergeBOMChanges";
            this.fld_dgcMMMergeBOMChanges.Screen = null;
            this.fld_dgcMMMergeBOMChanges.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcMMMergeBOMChanges.TabIndex = 365;
            this.fld_dgcMMMergeBOMChanges.Tag = "SR";
            this.fld_dgcMMMergeBOMChanges.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvMMMergeBOMChanges});
            // 
            // fld_dgvMMMergeBOMChanges
            // 
            this.fld_dgvMMMergeBOMChanges.GridControl = this.fld_dgcMMMergeBOMChanges;
            this.fld_dgvMMMergeBOMChanges.Name = "fld_dgvMMMergeBOMChanges";
            this.fld_dgvMMMergeBOMChanges.PaintStyleName = "Office2003";
            // 
            // SMMBC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(550, 567);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtMMMergeBOMChangeNo);
            this.Controls.Add(this.fld_dgcMMMergeBOMChanges);
            this.Name = "SMMBC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcMMMergeBOMChanges, 0);
            this.Controls.SetChildIndex(this.fld_txtMMMergeBOMChangeNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMergeBOMChangeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMMergeBOMChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvMMMergeBOMChanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtMMMergeBOMChangeNo;
        private BOSSearchResultsGridControl fld_dgcMMMergeBOMChanges;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvMMMergeBOMChanges;
        private IContainer components;
	}
}
