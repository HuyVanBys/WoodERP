using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCostFormula.UI
{
	/// <summary>
	/// Summary description for SMPCF100
	/// </summary>
	partial class SMPCF100
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
            this.fld_dgcMMProductionCostFormula = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostFormulaNo1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostFormulaNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMProductionCostFormula
            // 
            this.fld_dgcMMProductionCostFormula.BOSComment = null;
            this.fld_dgcMMProductionCostFormula.BOSDataMember = null;
            this.fld_dgcMMProductionCostFormula.BOSDataSource = "MMProductionCostFormulas";
            this.fld_dgcMMProductionCostFormula.BOSDescription = null;
            this.fld_dgcMMProductionCostFormula.BOSError = null;
            this.fld_dgcMMProductionCostFormula.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostFormula.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostFormula.BOSPrivilege = null;
            this.fld_dgcMMProductionCostFormula.BOSPropertyName = null;
            this.fld_dgcMMProductionCostFormula.Location = new System.Drawing.Point(24, 61);
            this.fld_dgcMMProductionCostFormula.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionCostFormula.Name = "fld_dgcMMProductionCostFormula";
            this.fld_dgcMMProductionCostFormula.Screen = null;
            this.fld_dgcMMProductionCostFormula.Size = new System.Drawing.Size(432, 200);
            this.fld_dgcMMProductionCostFormula.TabIndex = 15;
            this.fld_dgcMMProductionCostFormula.Tag = "SR";
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
            this.bosLabel1.Location = new System.Drawing.Point(24, 12);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(65, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã công thức";
            // 
            // fld_txtMMProductionCostFormulaNo1
            // 
            this.fld_txtMMProductionCostFormulaNo1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostFormulaNo1.BOSDataMember = "MMProductionCostFormulaNo";
            this.fld_txtMMProductionCostFormulaNo1.BOSDataSource = "MMProductionCostFormulas";
            this.fld_txtMMProductionCostFormulaNo1.BOSDescription = null;
            this.fld_txtMMProductionCostFormulaNo1.BOSError = null;
            this.fld_txtMMProductionCostFormulaNo1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostFormulaNo1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostFormulaNo1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostFormulaNo1.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostFormulaNo1.EditValue = global::Localization.MESLocalizedResources.String1;
            this.fld_txtMMProductionCostFormulaNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtMMProductionCostFormulaNo1.Name = "fld_txtMMProductionCostFormulaNo1";
            this.fld_txtMMProductionCostFormulaNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostFormulaNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostFormulaNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostFormulaNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostFormulaNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostFormulaNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostFormulaNo1.Screen = null;
            this.fld_txtMMProductionCostFormulaNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionCostFormulaNo1.TabIndex = 11;
            this.fld_txtMMProductionCostFormulaNo1.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.BOSComment = null;
            this.bosLabel2.BOSDataMember = null;
            this.bosLabel2.BOSDataSource = null;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = null;
            this.bosLabel2.BOSFieldRelation = null;
            this.bosLabel2.BOSPrivilege = null;
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(24, 38);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(69, 13);
            this.bosLabel2.TabIndex = 17;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Tên công thức";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSDataMember = "MMProductionCostFormulaName";
            this.bosTextBox1.BOSDataSource = "MMProductionCostFormulas";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSFieldRelation = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSPrivilege = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.EditValue = global::Localization.MESLocalizedResources.String1;
            this.bosTextBox1.Location = new System.Drawing.Point(109, 35);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(347, 20);
            this.bosTextBox1.TabIndex = 16;
            this.bosTextBox1.Tag = "SC";
            // 
            // SMPCF100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(471, 279);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.fld_dgcMMProductionCostFormula);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMProductionCostFormulaNo1);
            this.Name = "SMPCF100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtMMProductionCostFormulaNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMProductionCostFormula, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostFormulaNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcMMProductionCostFormula;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostFormulaNo1;
        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSTextBox bosTextBox1;
	}
}
