using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RevenueBudget.UI
{
	/// <summary>
	/// Summary description for SMRB100
	/// </summary>
	partial class SMRB100
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
            this.fld_dgcACRevenueBudget = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtACRevenueBudgetNo1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRevenueBudget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRevenueBudgetNo1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcACRevenueBudget
            // 
            this.fld_dgcACRevenueBudget.BOSComment = null;
            this.fld_dgcACRevenueBudget.BOSDataMember = null;
            this.fld_dgcACRevenueBudget.BOSDataSource = "ACRevenueBudgets";
            this.fld_dgcACRevenueBudget.BOSDescription = null;
            this.fld_dgcACRevenueBudget.BOSError = null;
            this.fld_dgcACRevenueBudget.BOSFieldGroup = null;
            this.fld_dgcACRevenueBudget.BOSFieldRelation = null;
            this.fld_dgcACRevenueBudget.BOSPrivilege = null;
            this.fld_dgcACRevenueBudget.BOSPropertyName = null;
            this.fld_dgcACRevenueBudget.Location = new System.Drawing.Point(274, 266);
            this.fld_dgcACRevenueBudget.MenuManager = this.screenToolbar;
            this.fld_dgcACRevenueBudget.Name = "fld_dgcACRevenueBudget";
            this.fld_dgcACRevenueBudget.Screen = null;
            this.fld_dgcACRevenueBudget.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACRevenueBudget.TabIndex = 15;
            this.fld_dgcACRevenueBudget.Tag = "SR";
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
            // fld_txtACRevenueBudgetNo1
            // 
            this.fld_txtACRevenueBudgetNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACRevenueBudgetNo1.BOSDataMember = "ACRevenueBudgetNo";
            this.fld_txtACRevenueBudgetNo1.BOSDataSource = "ACRevenueBudgets";
            this.fld_txtACRevenueBudgetNo1.BOSDescription = null;
            this.fld_txtACRevenueBudgetNo1.BOSError = null;
            this.fld_txtACRevenueBudgetNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACRevenueBudgetNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACRevenueBudgetNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACRevenueBudgetNo1.BOSPropertyName = "Text";
            this.fld_txtACRevenueBudgetNo1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtACRevenueBudgetNo1.Location = new System.Drawing.Point(109, 9);
            this.fld_txtACRevenueBudgetNo1.Name = "fld_txtACRevenueBudgetNo1";
            this.fld_txtACRevenueBudgetNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACRevenueBudgetNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACRevenueBudgetNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACRevenueBudgetNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACRevenueBudgetNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACRevenueBudgetNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACRevenueBudgetNo1.Screen = null;
            this.fld_txtACRevenueBudgetNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACRevenueBudgetNo1.TabIndex = 11;
            this.fld_txtACRevenueBudgetNo1.Tag = "SC";
            // 
            // SMRB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcACRevenueBudget);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACRevenueBudgetNo1);
            this.Name = "SMRB100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACRevenueBudgetNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_dgcACRevenueBudget, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACRevenueBudget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACRevenueBudgetNo1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcACRevenueBudget;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSTextBox fld_txtACRevenueBudgetNo1;
        private IContainer components;
	}
}
