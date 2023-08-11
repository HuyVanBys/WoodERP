using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ProductionCostCalculation.UI
{
	/// <summary>
	/// Summary description for SMPCC100
	/// </summary>
	partial class SMPCC100
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
            this.fld_dgcMMProductionCostCalculation = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtMMProductionCostCalculationNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_MMProductionCostFormulaID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel15 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostCalculationNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFormulaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcMMProductionCostCalculation
            // 
            this.fld_dgcMMProductionCostCalculation.BOSComment = null;
            this.fld_dgcMMProductionCostCalculation.BOSDataMember = null;
            this.fld_dgcMMProductionCostCalculation.BOSDataSource = "MMProductionCostCalculations";
            this.fld_dgcMMProductionCostCalculation.BOSDescription = null;
            this.fld_dgcMMProductionCostCalculation.BOSError = null;
            this.fld_dgcMMProductionCostCalculation.BOSFieldGroup = null;
            this.fld_dgcMMProductionCostCalculation.BOSFieldRelation = null;
            this.fld_dgcMMProductionCostCalculation.BOSGridType = null;
            this.fld_dgcMMProductionCostCalculation.BOSPrivilege = null;
            this.fld_dgcMMProductionCostCalculation.BOSPropertyName = null;
            this.fld_dgcMMProductionCostCalculation.CommodityType = global::Localization.CommonLocalizedResources.String2;
            this.fld_dgcMMProductionCostCalculation.Location = new System.Drawing.Point(24, 61);
            this.fld_dgcMMProductionCostCalculation.MenuManager = this.screenToolbar;
            this.fld_dgcMMProductionCostCalculation.Name = "fld_dgcMMProductionCostCalculation";
            this.fld_dgcMMProductionCostCalculation.PrintReport = false;
            this.fld_dgcMMProductionCostCalculation.Screen = null;
            this.fld_dgcMMProductionCostCalculation.Size = new System.Drawing.Size(432, 200);
            this.fld_dgcMMProductionCostCalculation.TabIndex = 15;
            this.fld_dgcMMProductionCostCalculation.Tag = "SR";
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
            this.bosLabel1.Size = new System.Drawing.Size(61, 13);
            this.bosLabel1.TabIndex = 13;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã chứng từ";
            // 
            // fld_txtMMProductionCostCalculationNo1
            // 
            this.fld_txtMMProductionCostCalculationNo1.BOSComment = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionCostCalculationNo1.BOSDataMember = "MMProductionCostCalculationNo";
            this.fld_txtMMProductionCostCalculationNo1.BOSDataSource = "MMProductionCostCalculations";
            this.fld_txtMMProductionCostCalculationNo1.BOSDescription = null;
            this.fld_txtMMProductionCostCalculationNo1.BOSError = null;
            this.fld_txtMMProductionCostCalculationNo1.BOSFieldGroup = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionCostCalculationNo1.BOSFieldRelation = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionCostCalculationNo1.BOSPrivilege = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionCostCalculationNo1.BOSPropertyName = "Text";
            this.fld_txtMMProductionCostCalculationNo1.EditValue = global::Localization.CommonLocalizedResources.String2;
            this.fld_txtMMProductionCostCalculationNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtMMProductionCostCalculationNo1.Name = "fld_txtMMProductionCostCalculationNo1";
            this.fld_txtMMProductionCostCalculationNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMProductionCostCalculationNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMProductionCostCalculationNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMProductionCostCalculationNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMProductionCostCalculationNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMProductionCostCalculationNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMProductionCostCalculationNo1.Screen = null;
            this.fld_txtMMProductionCostCalculationNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtMMProductionCostCalculationNo1.TabIndex = 11;
            this.fld_txtMMProductionCostCalculationNo1.Tag = "SC";
            // 
            // fld_lkeFK_MMProductionCostFormulaID
            // 
            this.fld_lkeFK_MMProductionCostFormulaID.BOSAllowAddNew = false;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSAllowDummy = true;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSComment = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDataMember = "FK_MMProductionCostFormulaID";
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDataSource = "MMProductionCostCalculations";
            this.fld_lkeFK_MMProductionCostFormulaID.BOSDescription = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSError = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSFieldGroup = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSFieldParent = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSFieldRelation = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSPrivilege = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_MMProductionCostFormulaID.BOSSelectType = null;
            this.fld_lkeFK_MMProductionCostFormulaID.BOSSelectTypeValue = null;
            this.fld_lkeFK_MMProductionCostFormulaID.CurrentDisplayText = null;
            this.fld_lkeFK_MMProductionCostFormulaID.Location = new System.Drawing.Point(109, 35);
            this.fld_lkeFK_MMProductionCostFormulaID.Name = "fld_lkeFK_MMProductionCostFormulaID";
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.ColumnName = null;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFormulaNo", "Mã công thức"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MMProductionCostFormulaName", "Tên công thức")});
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.DisplayMember = "MMProductionCostFormulaName";
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.NullText = global::Localization.CommonLocalizedResources.String2;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_MMProductionCostFormulaID.Properties.ValueMember = "MMProductionCostFormulaID";
            this.fld_lkeFK_MMProductionCostFormulaID.Screen = null;
            this.fld_lkeFK_MMProductionCostFormulaID.Size = new System.Drawing.Size(347, 20);
            this.fld_lkeFK_MMProductionCostFormulaID.TabIndex = 580;
            this.fld_lkeFK_MMProductionCostFormulaID.Tag = "SC";
            // 
            // bosLabel15
            // 
            this.bosLabel15.BOSComment = null;
            this.bosLabel15.BOSDataMember = null;
            this.bosLabel15.BOSDataSource = null;
            this.bosLabel15.BOSDescription = null;
            this.bosLabel15.BOSError = null;
            this.bosLabel15.BOSFieldGroup = null;
            this.bosLabel15.BOSFieldRelation = null;
            this.bosLabel15.BOSPrivilege = null;
            this.bosLabel15.BOSPropertyName = null;
            this.bosLabel15.Location = new System.Drawing.Point(25, 38);
            this.bosLabel15.Name = "bosLabel15";
            this.bosLabel15.Screen = null;
            this.bosLabel15.Size = new System.Drawing.Size(72, 13);
            this.bosLabel15.TabIndex = 581;
            this.bosLabel15.Tag = "SI";
            this.bosLabel15.Text = "Công thức TGT";
            // 
            // SMPCC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(565, 279);
            this.Controls.Add(this.fld_lkeFK_MMProductionCostFormulaID);
            this.Controls.Add(this.bosLabel15);
            this.Controls.Add(this.fld_dgcMMProductionCostCalculation);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtMMProductionCostCalculationNo1);
            this.Name = "SMPCC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtMMProductionCostCalculationNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcMMProductionCostCalculation, 0);
            this.Controls.SetChildIndex(this.bosLabel15, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_MMProductionCostFormulaID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcMMProductionCostCalculation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMProductionCostCalculationNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_MMProductionCostFormulaID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcMMProductionCostCalculation;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtMMProductionCostCalculationNo1;
        private IContainer components;
        private BOSComponent.BOSLookupEdit fld_lkeFK_MMProductionCostFormulaID;
        private BOSComponent.BOSLabel bosLabel15;
	}
}
