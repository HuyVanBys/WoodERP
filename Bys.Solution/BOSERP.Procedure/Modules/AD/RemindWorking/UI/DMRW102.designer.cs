using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RemindWorking.UI
{
	/// <summary>
	/// Summary description for DMRW102
	/// </summary>
	partial class DMRW102
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMRW102));
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel29 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtARCustomerNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel16 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_ARCustomerResourceID = new BOSComponent.BOSLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerResourceID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = string.Empty;
            this.bosTextBox1.BOSDataMember = "ARCustomerNoOfOldSys";
            this.bosTextBox1.BOSDataSource = "ARCustomers";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = string.Empty;
            this.bosTextBox1.BOSFieldGroup = string.Empty;
            this.bosTextBox1.BOSFieldRelation = string.Empty;
            this.bosTextBox1.BOSPrivilege = string.Empty;
            this.bosTextBox1.BOSPropertyName = "Text";
            resources.ApplyResources(this.bosTextBox1, "bosTextBox1");
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.bosTextBox1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosTextBox1, ((bool)(resources.GetObject("bosTextBox1.ShowHelp"))));
            this.bosTextBox1.Tag = "DC";
            // 
            // bosLabel29
            // 
            this.bosLabel29.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel29.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel29.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel29.Appearance.Options.UseBackColor = true;
            this.bosLabel29.Appearance.Options.UseFont = true;
            this.bosLabel29.Appearance.Options.UseForeColor = true;
            this.bosLabel29.BOSComment = string.Empty;
            this.bosLabel29.BOSDataMember = string.Empty;
            this.bosLabel29.BOSDataSource = string.Empty;
            this.bosLabel29.BOSDescription = null;
            this.bosLabel29.BOSError = null;
            this.bosLabel29.BOSFieldGroup = string.Empty;
            this.bosLabel29.BOSFieldRelation = string.Empty;
            this.bosLabel29.BOSPrivilege = string.Empty;
            this.bosLabel29.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel29, "bosLabel29");
            this.bosLabel29.Name = "bosLabel29";
            this.bosLabel29.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel29, ((bool)(resources.GetObject("bosLabel29.ShowHelp"))));
            this.bosLabel29.Tag = string.Empty;
            // 
            // fld_txtARCustomerNo1
            // 
            this.fld_txtARCustomerNo1.BOSComment = string.Empty;
            this.fld_txtARCustomerNo1.BOSDataMember = "ARCustomerNo";
            this.fld_txtARCustomerNo1.BOSDataSource = "ARCustomers";
            this.fld_txtARCustomerNo1.BOSDescription = null;
            this.fld_txtARCustomerNo1.BOSError = string.Empty;
            this.fld_txtARCustomerNo1.BOSFieldGroup = string.Empty;
            this.fld_txtARCustomerNo1.BOSFieldRelation = string.Empty;
            this.fld_txtARCustomerNo1.BOSPrivilege = string.Empty;
            this.fld_txtARCustomerNo1.BOSPropertyName = "Text";
            resources.ApplyResources(this.fld_txtARCustomerNo1, "fld_txtARCustomerNo1");
            this.fld_txtARCustomerNo1.Name = "fld_txtARCustomerNo1";
            this.fld_txtARCustomerNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtARCustomerNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtARCustomerNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtARCustomerNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtARCustomerNo1.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("fld_txtARCustomerNo1.Properties.Mask.UseMaskAsDisplayFormat")));
            this.fld_txtARCustomerNo1.Screen = null;
            this.fld_txtARCustomerNo1.Tag = "DC";
            // 
            // fld_lblLabel16
            // 
            this.fld_lblLabel16.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel16.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel16.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel16.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel16.Appearance.Options.UseFont = true;
            this.fld_lblLabel16.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel16.BOSComment = string.Empty;
            this.fld_lblLabel16.BOSDataMember = string.Empty;
            this.fld_lblLabel16.BOSDataSource = string.Empty;
            this.fld_lblLabel16.BOSDescription = null;
            this.fld_lblLabel16.BOSError = null;
            this.fld_lblLabel16.BOSFieldGroup = string.Empty;
            this.fld_lblLabel16.BOSFieldRelation = string.Empty;
            this.fld_lblLabel16.BOSPrivilege = string.Empty;
            this.fld_lblLabel16.BOSPropertyName = null;
            resources.ApplyResources(this.fld_lblLabel16, "fld_lblLabel16");
            this.fld_lblLabel16.Name = "fld_lblLabel16";
            this.fld_lblLabel16.Screen = null;
            this.fld_lblLabel16.Tag = string.Empty;
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseFont = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = string.Empty;
            this.bosLabel1.BOSDataMember = string.Empty;
            this.bosLabel1.BOSDataSource = string.Empty;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = string.Empty;
            this.bosLabel1.BOSFieldRelation = string.Empty;
            this.bosLabel1.BOSPrivilege = string.Empty;
            this.bosLabel1.BOSPropertyName = null;
            resources.ApplyResources(this.bosLabel1, "bosLabel1");
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel1, ((bool)(resources.GetObject("bosLabel1.ShowHelp"))));
            this.bosLabel1.Tag = string.Empty;
            // 
            // fld_lkeFK_ARCustomerResourceID
            // 
            this.fld_lkeFK_ARCustomerResourceID.BOSAllowAddNew = false;
            this.fld_lkeFK_ARCustomerResourceID.BOSAllowDummy = true;
            this.fld_lkeFK_ARCustomerResourceID.BOSComment = string.Empty;
            this.fld_lkeFK_ARCustomerResourceID.BOSDataMember = "";
            this.fld_lkeFK_ARCustomerResourceID.BOSDataSource = "";
            this.fld_lkeFK_ARCustomerResourceID.BOSDescription = null;
            this.fld_lkeFK_ARCustomerResourceID.BOSError = null;
            this.fld_lkeFK_ARCustomerResourceID.BOSFieldGroup = string.Empty;
            this.fld_lkeFK_ARCustomerResourceID.BOSFieldParent = string.Empty;
            this.fld_lkeFK_ARCustomerResourceID.BOSFieldRelation = string.Empty;
            this.fld_lkeFK_ARCustomerResourceID.BOSPrivilege = string.Empty;
            this.fld_lkeFK_ARCustomerResourceID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_ARCustomerResourceID.BOSSelectType = string.Empty;
            this.fld_lkeFK_ARCustomerResourceID.BOSSelectTypeValue = string.Empty;
            this.fld_lkeFK_ARCustomerResourceID.CurrentDisplayText = null;
            resources.ApplyResources(this.fld_lkeFK_ARCustomerResourceID, "fld_lkeFK_ARCustomerResourceID");
            this.fld_lkeFK_ARCustomerResourceID.Name = "fld_lkeFK_ARCustomerResourceID";
            this.fld_lkeFK_ARCustomerResourceID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_ARCustomerResourceID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_ARCustomerResourceID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_ARCustomerResourceID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_ARCustomerResourceID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("fld_lkeFK_ARCustomerResourceID.Properties.Buttons"))))});
            this.fld_lkeFK_ARCustomerResourceID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ARCustomerResourceID.Properties.Columns"), resources.GetString("fld_lkeFK_ARCustomerResourceID.Properties.Columns1")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ARCustomerResourceID.Properties.Columns2"), resources.GetString("fld_lkeFK_ARCustomerResourceID.Properties.Columns3")),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo(resources.GetString("fld_lkeFK_ARCustomerResourceID.Properties.Columns4"), resources.GetString("fld_lkeFK_ARCustomerResourceID.Properties.Columns5"))});
            this.fld_lkeFK_ARCustomerResourceID.Properties.DisplayMember = "ARCustomerResourceName";
            this.fld_lkeFK_ARCustomerResourceID.Properties.NullText = string.Empty;
            this.fld_lkeFK_ARCustomerResourceID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_ARCustomerResourceID.Properties.ValueMember = "ARCustomerResourceID";
            this.fld_lkeFK_ARCustomerResourceID.Screen = null;
            this.fld_lkeFK_ARCustomerResourceID.Tag = "DC";
            // 
            // DMRW102
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fld_lkeFK_ARCustomerResourceID);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.bosLabel29);
            this.Controls.Add(this.fld_txtARCustomerNo1);
            this.Controls.Add(this.fld_lblLabel16);
            this.Name = "DMRW102";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.fld_lblLabel16, 0);
            this.Controls.SetChildIndex(this.fld_txtARCustomerNo1, 0);
            this.Controls.SetChildIndex(this.bosLabel29, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_ARCustomerResourceID, 0);
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtARCustomerNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_ARCustomerResourceID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSLabel bosLabel29;
        private BOSComponent.BOSTextBox fld_txtARCustomerNo1;
        private BOSComponent.BOSLabel fld_lblLabel16;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_ARCustomerResourceID;
	}
}
