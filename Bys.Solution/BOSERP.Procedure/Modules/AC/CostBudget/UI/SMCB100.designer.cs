using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.CostBudget.UI
{
	/// <summary>
	/// Summary description for SMCB100
	/// </summary>
	partial class SMCB100
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
            this.fld_dgcACCostBudget = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACCostBudgetNo1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACCostBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostBudgetNo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcACCostBudget
            // 
            this.fld_dgcACCostBudget.BOSComment = null;
            this.fld_dgcACCostBudget.BOSDataMember = null;
            this.fld_dgcACCostBudget.BOSDataSource = "ACCostBudgets";
            this.fld_dgcACCostBudget.BOSDescription = null;
            this.fld_dgcACCostBudget.BOSError = null;
            this.fld_dgcACCostBudget.BOSFieldGroup = null;
            this.fld_dgcACCostBudget.BOSFieldRelation = null;
            this.fld_dgcACCostBudget.BOSPrivilege = null;
            this.fld_dgcACCostBudget.BOSPropertyName = null;
            this.fld_dgcACCostBudget.Location = new System.Drawing.Point(274, 266);
            this.fld_dgcACCostBudget.MenuManager = this.screenToolbar;
            this.fld_dgcACCostBudget.Name = "fld_dgcACCostBudget";
            this.fld_dgcACCostBudget.Screen = null;
            this.fld_dgcACCostBudget.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACCostBudget.TabIndex = 15;
            this.fld_dgcACCostBudget.Tag = "SR";
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
            // fld_txtACCostBudgetNo1
            // 
            this.fld_txtACCostBudgetNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostBudgetNo1.BOSDataMember = "ACCostBudgetNo";
            this.fld_txtACCostBudgetNo1.BOSDataSource = "ACCostBudgets";
            this.fld_txtACCostBudgetNo1.BOSDescription = null;
            this.fld_txtACCostBudgetNo1.BOSError = null;
            this.fld_txtACCostBudgetNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostBudgetNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostBudgetNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostBudgetNo1.BOSPropertyName = "Text";
            this.fld_txtACCostBudgetNo1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACCostBudgetNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtACCostBudgetNo1.Name = "fld_txtACCostBudgetNo1";
            this.fld_txtACCostBudgetNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACCostBudgetNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACCostBudgetNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACCostBudgetNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACCostBudgetNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACCostBudgetNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACCostBudgetNo1.Screen = null;
            this.fld_txtACCostBudgetNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACCostBudgetNo1.TabIndex = 11;
            this.fld_txtACCostBudgetNo1.Tag = "SC";
            // 
            // SMCB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcACCostBudget);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACCostBudgetNo1);
            this.Name = "SMCB100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACCostBudgetNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcACCostBudget, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACCostBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACCostBudgetNo1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcACCostBudget;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACCostBudgetNo1;
        private IContainer components;
	}
}
