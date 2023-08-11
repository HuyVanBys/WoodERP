using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREvaluationTemplate.UI
{
	/// <summary>
	/// Summary description for SMHRET100
	/// </summary>
	partial class SMHRET100
	{
		private BOSSearchResultsGridControl fld_dgcHREvaluationTemplate;
		private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHREvaluationTemplate;
		private BOSComponent.BOSTextBox fld_txtHREvaluationTemplateNo;
		private BOSComponent.BOSTextBox fld_txtHREvaluationTemplateName;
		private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSLabel fld_lblLabel1;


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
            this.fld_dgcHREvaluationTemplate = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvHREvaluationTemplate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_txtHREvaluationTemplateNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREvaluationTemplateName = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREvaluationTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREvaluationTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationTemplateNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationTemplateName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcHREvaluationTemplate
            // 
            this.fld_dgcHREvaluationTemplate.AllowDrop = true;
            this.fld_dgcHREvaluationTemplate.BOSComment = "";
            this.fld_dgcHREvaluationTemplate.BOSDataMember = "";
            this.fld_dgcHREvaluationTemplate.BOSDataSource = "HREvaluationTemplates";
            this.fld_dgcHREvaluationTemplate.BOSDescription = null;
            this.fld_dgcHREvaluationTemplate.BOSError = null;
            this.fld_dgcHREvaluationTemplate.BOSFieldGroup = "";
            this.fld_dgcHREvaluationTemplate.BOSFieldRelation = "";
            this.fld_dgcHREvaluationTemplate.BOSPrivilege = "";
            this.fld_dgcHREvaluationTemplate.BOSPropertyName = "";
            this.fld_dgcHREvaluationTemplate.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHREvaluationTemplate.Location = new System.Drawing.Point(9, 108);
            this.fld_dgcHREvaluationTemplate.MainView = this.fld_dgvHREvaluationTemplate;
            this.fld_dgcHREvaluationTemplate.Name = "fld_dgcHREvaluationTemplate";
            this.fld_dgcHREvaluationTemplate.Screen = null;
            this.fld_dgcHREvaluationTemplate.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcHREvaluationTemplate.TabIndex = 4;
            this.fld_dgcHREvaluationTemplate.Tag = "SR";
            this.fld_dgcHREvaluationTemplate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHREvaluationTemplate});
            // 
            // fld_dgvHREvaluationTemplate
            // 
            this.fld_dgvHREvaluationTemplate.GridControl = this.fld_dgcHREvaluationTemplate;
            this.fld_dgvHREvaluationTemplate.Name = "fld_dgvHREvaluationTemplate";
            this.fld_dgvHREvaluationTemplate.PaintStyleName = "Office2003";
            // 
            // fld_txtHREvaluationTemplateNo
            // 
            this.fld_txtHREvaluationTemplateNo.BOSComment = "";
            this.fld_txtHREvaluationTemplateNo.BOSDataMember = "HREvaluationTemplateNo";
            this.fld_txtHREvaluationTemplateNo.BOSDataSource = "HREvaluationTemplates";
            this.fld_txtHREvaluationTemplateNo.BOSDescription = null;
            this.fld_txtHREvaluationTemplateNo.BOSError = null;
            this.fld_txtHREvaluationTemplateNo.BOSFieldGroup = "";
            this.fld_txtHREvaluationTemplateNo.BOSFieldRelation = "";
            this.fld_txtHREvaluationTemplateNo.BOSPrivilege = "";
            this.fld_txtHREvaluationTemplateNo.BOSPropertyName = "Text";
            this.fld_txtHREvaluationTemplateNo.EditValue = "";
            this.fld_txtHREvaluationTemplateNo.Location = new System.Drawing.Point(140, 34);
            this.fld_txtHREvaluationTemplateNo.Name = "fld_txtHREvaluationTemplateNo";
            this.fld_txtHREvaluationTemplateNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREvaluationTemplateNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREvaluationTemplateNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREvaluationTemplateNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREvaluationTemplateNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREvaluationTemplateNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREvaluationTemplateNo.Screen = null;
            this.fld_txtHREvaluationTemplateNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREvaluationTemplateNo.TabIndex = 5;
            this.fld_txtHREvaluationTemplateNo.Tag = "SC";
            // 
            // fld_txtHREvaluationTemplateName
            // 
            this.fld_txtHREvaluationTemplateName.BOSComment = "";
            this.fld_txtHREvaluationTemplateName.BOSDataMember = "HREvaluationTemplateName";
            this.fld_txtHREvaluationTemplateName.BOSDataSource = "HREvaluationTemplates";
            this.fld_txtHREvaluationTemplateName.BOSDescription = null;
            this.fld_txtHREvaluationTemplateName.BOSError = null;
            this.fld_txtHREvaluationTemplateName.BOSFieldGroup = "";
            this.fld_txtHREvaluationTemplateName.BOSFieldRelation = "";
            this.fld_txtHREvaluationTemplateName.BOSPrivilege = "";
            this.fld_txtHREvaluationTemplateName.BOSPropertyName = "Text";
            this.fld_txtHREvaluationTemplateName.EditValue = "";
            this.fld_txtHREvaluationTemplateName.Location = new System.Drawing.Point(140, 60);
            this.fld_txtHREvaluationTemplateName.Name = "fld_txtHREvaluationTemplateName";
            this.fld_txtHREvaluationTemplateName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREvaluationTemplateName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREvaluationTemplateName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREvaluationTemplateName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREvaluationTemplateName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREvaluationTemplateName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREvaluationTemplateName.Screen = null;
            this.fld_txtHREvaluationTemplateName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtHREvaluationTemplateName.TabIndex = 6;
            this.fld_txtHREvaluationTemplateName.Tag = "SC";
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
            this.fld_lblLabel.Location = new System.Drawing.Point(53, 37);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel.TabIndex = 7;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã biểu mẫu";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = "";
            this.fld_lblLabel1.Location = new System.Drawing.Point(53, 63);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel1.TabIndex = 8;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên biểu mẫu";
            // 
            // SMHRET100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcHREvaluationTemplate);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtHREvaluationTemplateNo);
            this.Controls.Add(this.fld_lblLabel1);
            this.Controls.Add(this.fld_txtHREvaluationTemplateName);
            this.Name = "SMHRET100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtHREvaluationTemplateName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtHREvaluationTemplateNo, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_dgcHREvaluationTemplate, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHREvaluationTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHREvaluationTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationTemplateNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationTemplateName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
	}
}
