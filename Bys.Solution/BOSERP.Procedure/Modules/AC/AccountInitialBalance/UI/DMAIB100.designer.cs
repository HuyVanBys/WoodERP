using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.AccountInitialBalance.UI
{
	/// <summary>
	/// Summary description for DMAIB100
	/// </summary>
	partial class DMAIB100
	{
        private AccountTreeListControl fld_trlACAccounts;


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
            this.fld_trlACAccounts = new BOSERP.Modules.AccountInitialBalance.AccountTreeListControl();
            this.bosPanel1 = new BOSComponent.BOSPanel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlACAccounts)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_trlACAccounts
            // 
            this.fld_trlACAccounts.BOSComment = "";
            this.fld_trlACAccounts.BOSDataMember = "";
            this.fld_trlACAccounts.BOSDataSource = "ACAccounts";
            this.fld_trlACAccounts.BOSDescription = null;
            this.fld_trlACAccounts.BOSDisplayOption = false;
            this.fld_trlACAccounts.BOSDisplayRoot = true;
            this.fld_trlACAccounts.BOSError = null;
            this.fld_trlACAccounts.BOSFieldGroup = "";
            this.fld_trlACAccounts.BOSFieldRelation = "";
            this.fld_trlACAccounts.BOSPrivilege = "";
            this.fld_trlACAccounts.BOSPropertyName = "";
            this.fld_trlACAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlACAccounts.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlACAccounts.Location = new System.Drawing.Point(0, 0);
            this.fld_trlACAccounts.Name = "fld_trlACAccounts";
            this.fld_trlACAccounts.OptionsBehavior.AllowExpandOnDblClick = false;
            this.fld_trlACAccounts.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlACAccounts.Screen = null;
            this.fld_trlACAccounts.Size = new System.Drawing.Size(766, 567);
            this.fld_trlACAccounts.TabIndex = 4;
            this.fld_trlACAccounts.Tag = "DC";
            // 
            // bosPanel1
            // 
            this.bosPanel1.BOSComment = null;
            this.bosPanel1.BOSDataMember = null;
            this.bosPanel1.BOSDataSource = null;
            this.bosPanel1.BOSDescription = null;
            this.bosPanel1.BOSError = null;
            this.bosPanel1.BOSFieldGroup = null;
            this.bosPanel1.BOSFieldRelation = null;
            this.bosPanel1.BOSPrivilege = null;
            this.bosPanel1.BOSPropertyName = null;
            this.bosPanel1.Controls.Add(this.fld_trlACAccounts);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.bosPanel1.Screen = null;
            this.bosPanel1.Size = new System.Drawing.Size(766, 567);
            this.bosPanel1.TabIndex = 6;
            // 
            // DMAIB100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(766, 567);
            this.Controls.Add(this.bosPanel1);
            this.Name = "DMAIB100";
            this.Text = "Số dư ban đầu";
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlACAccounts)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSPanel bosPanel1;
	}
}
