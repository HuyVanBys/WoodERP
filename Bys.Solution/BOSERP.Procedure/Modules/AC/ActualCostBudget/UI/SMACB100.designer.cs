using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.ActualCostBudget.UI
{
	/// <summary>
	/// Summary description for SMACB100
	/// </summary>
	partial class SMACB100
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
            this.fld_dgcACActualCostBudget = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACActualCostBudgetNo1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACActualCostBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACActualCostBudgetNo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcACActualCostBudget
            // 
            this.fld_dgcACActualCostBudget.BOSComment = null;
            this.fld_dgcACActualCostBudget.BOSDataMember = null;
            this.fld_dgcACActualCostBudget.BOSDataSource = "ACActualCostBudgets";
            this.fld_dgcACActualCostBudget.BOSDescription = null;
            this.fld_dgcACActualCostBudget.BOSError = null;
            this.fld_dgcACActualCostBudget.BOSFieldGroup = null;
            this.fld_dgcACActualCostBudget.BOSFieldRelation = null;
            this.fld_dgcACActualCostBudget.BOSPrivilege = null;
            this.fld_dgcACActualCostBudget.BOSPropertyName = null;
            this.fld_dgcACActualCostBudget.Location = new System.Drawing.Point(274, 266);
            this.fld_dgcACActualCostBudget.MenuManager = this.screenToolbar;
            this.fld_dgcACActualCostBudget.Name = "fld_dgcACActualCostBudget";
            this.fld_dgcACActualCostBudget.Screen = null;
            this.fld_dgcACActualCostBudget.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACActualCostBudget.TabIndex = 15;
            this.fld_dgcACActualCostBudget.Tag = "SR";
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
            // fld_txtACActualCostBudgetNo1
            // 
            this.fld_txtACActualCostBudgetNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo1.BOSDataMember = "ACActualCostBudgetNo";
            this.fld_txtACActualCostBudgetNo1.BOSDataSource = "ACActualCostBudgets";
            this.fld_txtACActualCostBudgetNo1.BOSDescription = null;
            this.fld_txtACActualCostBudgetNo1.BOSError = null;
            this.fld_txtACActualCostBudgetNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo1.BOSPropertyName = "Text";
            this.fld_txtACActualCostBudgetNo1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACActualCostBudgetNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtACActualCostBudgetNo1.Name = "fld_txtACActualCostBudgetNo1";
            this.fld_txtACActualCostBudgetNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACActualCostBudgetNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACActualCostBudgetNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACActualCostBudgetNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACActualCostBudgetNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACActualCostBudgetNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACActualCostBudgetNo1.Screen = null;
            this.fld_txtACActualCostBudgetNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACActualCostBudgetNo1.TabIndex = 11;
            this.fld_txtACActualCostBudgetNo1.Tag = "SC";
            // 
            // SMACB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcACActualCostBudget);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACActualCostBudgetNo1);
            this.Name = "SMACB100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACActualCostBudgetNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcACActualCostBudget, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACActualCostBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACActualCostBudgetNo1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcACActualCostBudget;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACActualCostBudgetNo1;
        private IContainer components;
	}
}
