using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace BOSERP.Modules.ListAccountBank.UI
{
	/// <summary>
	/// Summary description for SMAS100
	/// </summary>
    partial class SMLAB100
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
            this.fld_dgcACListAccountBanks = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.bosLabel11 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACListAccountBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcACListAccountBanks
            // 
            this.fld_dgcACListAccountBanks.BOSComment = null;
            this.fld_dgcACListAccountBanks.BOSDataMember = null;
            this.fld_dgcACListAccountBanks.BOSDataSource = "ACListAccountBanks";
            this.fld_dgcACListAccountBanks.BOSDescription = null;
            this.fld_dgcACListAccountBanks.BOSError = null;
            this.fld_dgcACListAccountBanks.BOSFieldGroup = null;
            this.fld_dgcACListAccountBanks.BOSFieldRelation = null;
            this.fld_dgcACListAccountBanks.BOSPrivilege = null;
            this.fld_dgcACListAccountBanks.BOSPropertyName = null;
            this.fld_dgcACListAccountBanks.Location = new System.Drawing.Point(56, 179);
            this.fld_dgcACListAccountBanks.MenuManager = this.screenToolbar;
            this.fld_dgcACListAccountBanks.Name = "fld_dgcACListAccountBanks";
            this.fld_dgcACListAccountBanks.Screen = null;
            this.fld_dgcACListAccountBanks.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACListAccountBanks.TabIndex = 11;
            this.fld_dgcACListAccountBanks.Tag = "SR";
            // 
            // bosLabel11
            // 
            this.bosLabel11.BOSComment = null;
            this.bosLabel11.BOSDataMember = null;
            this.bosLabel11.BOSDataSource = null;
            this.bosLabel11.BOSDescription = null;
            this.bosLabel11.BOSError = null;
            this.bosLabel11.BOSFieldGroup = null;
            this.bosLabel11.BOSFieldRelation = null;
            this.bosLabel11.BOSPrivilege = null;
            this.bosLabel11.BOSPropertyName = null;
            this.bosLabel11.Location = new System.Drawing.Point(32, 31);
            this.bosLabel11.Name = "bosLabel11";
            this.bosLabel11.Screen = null;
            this.bosLabel11.Size = new System.Drawing.Size(61, 13);
            this.bosLabel11.TabIndex = 13;
            this.bosLabel11.Tag = "SI";
            this.bosLabel11.Text = "Mã chứng từ";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = null;
            this.bosTextBox1.BOSDataMember = "ACListAccountBankNo";
            this.bosTextBox1.BOSDataSource = "ACListAccountBanks";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = null;
            this.bosTextBox1.BOSFieldGroup = null;
            this.bosTextBox1.BOSFieldRelation = null;
            this.bosTextBox1.BOSPrivilege = null;
            this.bosTextBox1.BOSPropertyName = "EditValue";
            this.bosTextBox1.Location = new System.Drawing.Point(119, 28);
            this.bosTextBox1.MenuManager = this.screenToolbar;
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(160, 20);
            this.bosTextBox1.TabIndex = 12;
            this.bosTextBox1.Tag = "SC";
            // 
            // SMLAB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(788, 480);
            this.Controls.Add(this.bosLabel11);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.fld_dgcACListAccountBanks);
            this.Name = "SMLAB100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcACListAccountBanks, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.bosLabel11, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACListAccountBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSSearchResultsGridControl fld_dgcACListAccountBanks;
        private BOSComponent.BOSLabel bosLabel11;
        private BOSComponent.BOSTextBox bosTextBox1;
	}
}
