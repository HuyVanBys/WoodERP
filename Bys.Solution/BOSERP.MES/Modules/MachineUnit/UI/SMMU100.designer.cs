using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.MachineUnit.UI
{
	/// <summary>
	/// Summary description for SMMU100
	/// </summary>
	partial class SMMU100
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
            this.fld_txtMMMachineUnitName = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtMMMachineUnitNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_trlMMMachineUnits = new BOSERP.Modules.MachineUnit.MMMachineUnitsTreeListControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMMachineUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_lblLabel
            // 
            this.fld_lblLabel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel.Appearance.Options.UseFont = true;
            this.fld_lblLabel.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel.BOSComment = "";
            this.fld_lblLabel.BOSDataMember = "";
            this.fld_lblLabel.BOSDataSource = "";
            this.fld_lblLabel.BOSDescription = null;
            this.fld_lblLabel.BOSError = null;
            this.fld_lblLabel.BOSFieldGroup = "";
            this.fld_lblLabel.BOSFieldRelation = "";
            this.fld_lblLabel.BOSPrivilege = "";
            this.fld_lblLabel.BOSPropertyName = null;
            this.fld_lblLabel.Location = new System.Drawing.Point(28, 15);
            this.fld_lblLabel.Name = "fld_lblLabel";
            this.fld_lblLabel.Screen = null;
            this.fld_lblLabel.Size = new System.Drawing.Size(27, 13);
            this.fld_lblLabel.TabIndex = 15;
            this.fld_lblLabel.Tag = "SI";
            this.fld_lblLabel.Text = "Mã tổ";
            // 
            // fld_txtMMMachineUnitName
            // 
            this.fld_txtMMMachineUnitName.BOSComment = "";
            this.fld_txtMMMachineUnitName.BOSDataMember = "MMMachineUnitName";
            this.fld_txtMMMachineUnitName.BOSDataSource = "MMMachineUnits";
            this.fld_txtMMMachineUnitName.BOSDescription = null;
            this.fld_txtMMMachineUnitName.BOSError = "";
            this.fld_txtMMMachineUnitName.BOSFieldGroup = "";
            this.fld_txtMMMachineUnitName.BOSFieldRelation = "";
            this.fld_txtMMMachineUnitName.BOSPrivilege = "";
            this.fld_txtMMMachineUnitName.BOSPropertyName = "Text";
            this.fld_txtMMMachineUnitName.Location = new System.Drawing.Point(122, 38);
            this.fld_txtMMMachineUnitName.Name = "fld_txtMMMachineUnitName";
            this.fld_txtMMMachineUnitName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMMachineUnitName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMMachineUnitName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMMachineUnitName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMMachineUnitName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMMachineUnitName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMMachineUnitName.Screen = null;
            this.fld_txtMMMachineUnitName.Size = new System.Drawing.Size(159, 20);
            this.fld_txtMMMachineUnitName.TabIndex = 14;
            this.fld_txtMMMachineUnitName.Tag = "SC";
            // 
            // fld_txtMMMachineUnitNo
            // 
            this.fld_txtMMMachineUnitNo.BOSComment = "";
            this.fld_txtMMMachineUnitNo.BOSDataMember = "MMMachineUnitNo";
            this.fld_txtMMMachineUnitNo.BOSDataSource = "MMMachineUnits";
            this.fld_txtMMMachineUnitNo.BOSDescription = null;
            this.fld_txtMMMachineUnitNo.BOSError = "";
            this.fld_txtMMMachineUnitNo.BOSFieldGroup = "";
            this.fld_txtMMMachineUnitNo.BOSFieldRelation = "";
            this.fld_txtMMMachineUnitNo.BOSPrivilege = "";
            this.fld_txtMMMachineUnitNo.BOSPropertyName = "Text";
            this.fld_txtMMMachineUnitNo.Location = new System.Drawing.Point(122, 12);
            this.fld_txtMMMachineUnitNo.Name = "fld_txtMMMachineUnitNo";
            this.fld_txtMMMachineUnitNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtMMMachineUnitNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtMMMachineUnitNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtMMMachineUnitNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtMMMachineUnitNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtMMMachineUnitNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtMMMachineUnitNo.Screen = null;
            this.fld_txtMMMachineUnitNo.Size = new System.Drawing.Size(159, 20);
            this.fld_txtMMMachineUnitNo.TabIndex = 13;
            this.fld_txtMMMachineUnitNo.Tag = "SC";
            // 
            // fld_lblLabel1
            // 
            this.fld_lblLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel1.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel1.Appearance.Options.UseFont = true;
            this.fld_lblLabel1.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel1.BOSComment = "";
            this.fld_lblLabel1.BOSDataMember = "";
            this.fld_lblLabel1.BOSDataSource = "";
            this.fld_lblLabel1.BOSDescription = null;
            this.fld_lblLabel1.BOSError = null;
            this.fld_lblLabel1.BOSFieldGroup = "";
            this.fld_lblLabel1.BOSFieldRelation = "";
            this.fld_lblLabel1.BOSPrivilege = "";
            this.fld_lblLabel1.BOSPropertyName = null;
            this.fld_lblLabel1.Location = new System.Drawing.Point(28, 41);
            this.fld_lblLabel1.Name = "fld_lblLabel1";
            this.fld_lblLabel1.Screen = null;
            this.fld_lblLabel1.Size = new System.Drawing.Size(31, 13);
            this.fld_lblLabel1.TabIndex = 16;
            this.fld_lblLabel1.Tag = "SI";
            this.fld_lblLabel1.Text = "Tên tổ";
            // 
            // fld_trlMMMachineUnits
            // 
            this.fld_trlMMMachineUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMMachineUnits.BOSComment = null;
            this.fld_trlMMMachineUnits.BOSDataMember = null;
            this.fld_trlMMMachineUnits.BOSDataSource = "MMMachineUnits";
            this.fld_trlMMMachineUnits.BOSDescription = null;
            this.fld_trlMMMachineUnits.BOSDisplayOption = false;
            this.fld_trlMMMachineUnits.BOSDisplayRoot = false;
            this.fld_trlMMMachineUnits.BOSError = null;
            this.fld_trlMMMachineUnits.BOSFieldGroup = null;
            this.fld_trlMMMachineUnits.BOSFieldRelation = null;
            this.fld_trlMMMachineUnits.BOSPrivilege = null;
            this.fld_trlMMMachineUnits.BOSPropertyName = null;
            this.fld_trlMMMachineUnits.Location = new System.Drawing.Point(2, 92);
            this.fld_trlMMMachineUnits.Name = "fld_trlMMMachineUnits";
            this.fld_trlMMMachineUnits.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMMachineUnits.Screen = null;
            this.fld_trlMMMachineUnits.Size = new System.Drawing.Size(868, 469);
            this.fld_trlMMMachineUnits.TabIndex = 17;
            this.fld_trlMMMachineUnits.Tag = "SR";
            // 
            // SMMU100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(868, 573);
            this.Controls.Add(this.fld_trlMMMachineUnits);
            this.Controls.Add(this.fld_lblLabel);
            this.Controls.Add(this.fld_txtMMMachineUnitName);
            this.Controls.Add(this.fld_txtMMMachineUnitNo);
            this.Controls.Add(this.fld_lblLabel1);
            this.Name = "SMMU100";
            this.Text = "Danh sách công đoạn";
            this.Controls.SetChildIndex(this.fld_lblLabel1, 0);
            this.Controls.SetChildIndex(this.fld_txtMMMachineUnitNo, 0);
            this.Controls.SetChildIndex(this.fld_txtMMMachineUnitName, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel, 0);
            this.Controls.SetChildIndex(this.fld_trlMMMachineUnits, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtMMMachineUnitNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMMachineUnits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSComponent.BOSLabel fld_lblLabel;
        private BOSComponent.BOSTextBox fld_txtMMMachineUnitName;
        private BOSComponent.BOSTextBox fld_txtMMMachineUnitNo;
        private BOSComponent.BOSLabel fld_lblLabel1;
        private IContainer components;
        private BOSERP.Modules.MachineUnit.MMMachineUnitsTreeListControl fld_trlMMMachineUnits;
	}
}
