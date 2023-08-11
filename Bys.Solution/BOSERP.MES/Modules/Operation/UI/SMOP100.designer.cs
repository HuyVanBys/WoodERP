using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Operation.UI
{
	/// <summary>
	/// Summary description for SMOP100
	/// </summary>
	partial class SMOP100
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
            this.fld_trlMMOperations = new BOSERP.Modules.Operation.MMOperationsTreeListControl();
            this.fld_lblLabel12 = new BOSComponent.BOSLabel(this.components);
            this.bosTextBox1 = new BOSComponent.BOSTextBox(this.components);
            this.bosTextBox2 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lblLabel14 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationType = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeMMOperationGroup = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMOperations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationGroup.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_trlMMOperations
            // 
            this.fld_trlMMOperations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_trlMMOperations.BOSComment = null;
            this.fld_trlMMOperations.BOSDataMember = null;
            this.fld_trlMMOperations.BOSDataSource = "MMOperations";
            this.fld_trlMMOperations.BOSDescription = null;
            this.fld_trlMMOperations.BOSDisplayOption = false;
            this.fld_trlMMOperations.BOSDisplayRoot = false;
            this.fld_trlMMOperations.BOSError = null;
            this.fld_trlMMOperations.BOSFieldGroup = null;
            this.fld_trlMMOperations.BOSFieldRelation = null;
            this.fld_trlMMOperations.BOSPrivilege = null;
            this.fld_trlMMOperations.BOSPropertyName = null;
            this.fld_trlMMOperations.Location = new System.Drawing.Point(12, 145);
            this.fld_trlMMOperations.Name = "fld_trlMMOperations";
            this.fld_trlMMOperations.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlMMOperations.Screen = null;
            this.fld_trlMMOperations.Size = new System.Drawing.Size(866, 411);
            this.fld_trlMMOperations.TabIndex = 17;
            this.fld_trlMMOperations.Tag = "SR";
            // 
            // fld_lblLabel12
            // 
            this.fld_lblLabel12.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel12.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel12.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel12.Appearance.Options.UseFont = true;
            this.fld_lblLabel12.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel12.BOSComment = "";
            this.fld_lblLabel12.BOSDataMember = "";
            this.fld_lblLabel12.BOSDataSource = "";
            this.fld_lblLabel12.BOSDescription = null;
            this.fld_lblLabel12.BOSError = null;
            this.fld_lblLabel12.BOSFieldGroup = "";
            this.fld_lblLabel12.BOSFieldRelation = "";
            this.fld_lblLabel12.BOSPrivilege = "";
            this.fld_lblLabel12.BOSPropertyName = null;
            this.fld_lblLabel12.Location = new System.Drawing.Point(37, 35);
            this.fld_lblLabel12.Name = "fld_lblLabel12";
            this.fld_lblLabel12.Screen = null;
            this.fld_lblLabel12.Size = new System.Drawing.Size(70, 13);
            this.fld_lblLabel12.TabIndex = 18;
            this.fld_lblLabel12.Tag = "SI";
            this.fld_lblLabel12.Text = "Mã công đoạn";
            // 
            // bosTextBox1
            // 
            this.bosTextBox1.BOSComment = "";
            this.bosTextBox1.BOSDataMember = "MMOperationNo";
            this.bosTextBox1.BOSDataSource = "MMOperations";
            this.bosTextBox1.BOSDescription = null;
            this.bosTextBox1.BOSError = "Mã kho không thể rỗng";
            this.bosTextBox1.BOSFieldGroup = "";
            this.bosTextBox1.BOSFieldRelation = "";
            this.bosTextBox1.BOSPrivilege = "";
            this.bosTextBox1.BOSPropertyName = "Text";
            this.bosTextBox1.Location = new System.Drawing.Point(127, 31);
            this.bosTextBox1.Name = "bosTextBox1";
            this.bosTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox1.Screen = null;
            this.bosTextBox1.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox1.TabIndex = 0;
            this.bosTextBox1.Tag = "SC";
            // 
            // bosTextBox2
            // 
            this.bosTextBox2.BOSComment = "";
            this.bosTextBox2.BOSDataMember = "MMOperationName";
            this.bosTextBox2.BOSDataSource = "MMOperations";
            this.bosTextBox2.BOSDescription = null;
            this.bosTextBox2.BOSError = "";
            this.bosTextBox2.BOSFieldGroup = "";
            this.bosTextBox2.BOSFieldRelation = "";
            this.bosTextBox2.BOSPrivilege = "";
            this.bosTextBox2.BOSPropertyName = "Text";
            this.bosTextBox2.Location = new System.Drawing.Point(127, 57);
            this.bosTextBox2.Name = "bosTextBox2";
            this.bosTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.bosTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.bosTextBox2.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.bosTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bosTextBox2.Screen = null;
            this.bosTextBox2.Size = new System.Drawing.Size(150, 20);
            this.bosTextBox2.TabIndex = 1;
            this.bosTextBox2.Tag = "SC";
            // 
            // fld_lblLabel14
            // 
            this.fld_lblLabel14.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fld_lblLabel14.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel14.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel14.Appearance.Options.UseFont = true;
            this.fld_lblLabel14.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel14.BOSComment = "";
            this.fld_lblLabel14.BOSDataMember = "";
            this.fld_lblLabel14.BOSDataSource = "";
            this.fld_lblLabel14.BOSDescription = null;
            this.fld_lblLabel14.BOSError = null;
            this.fld_lblLabel14.BOSFieldGroup = "";
            this.fld_lblLabel14.BOSFieldRelation = "";
            this.fld_lblLabel14.BOSPrivilege = "";
            this.fld_lblLabel14.BOSPropertyName = null;
            this.fld_lblLabel14.Location = new System.Drawing.Point(37, 61);
            this.fld_lblLabel14.Name = "fld_lblLabel14";
            this.fld_lblLabel14.Screen = null;
            this.fld_lblLabel14.Size = new System.Drawing.Size(74, 13);
            this.fld_lblLabel14.TabIndex = 20;
            this.fld_lblLabel14.Tag = "SI";
            this.fld_lblLabel14.Text = "Tên công đoạn";
            // 
            // fld_lkeMMOperationType
            // 
            this.fld_lkeMMOperationType.BOSAllowAddNew = false;
            this.fld_lkeMMOperationType.BOSAllowDummy = true;
            this.fld_lkeMMOperationType.BOSComment = "";
            this.fld_lkeMMOperationType.BOSDataMember = "MMOperationType";
            this.fld_lkeMMOperationType.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationType.BOSDescription = null;
            this.fld_lkeMMOperationType.BOSError = null;
            this.fld_lkeMMOperationType.BOSFieldGroup = "";
            this.fld_lkeMMOperationType.BOSFieldParent = "";
            this.fld_lkeMMOperationType.BOSFieldRelation = "";
            this.fld_lkeMMOperationType.BOSPrivilege = "";
            this.fld_lkeMMOperationType.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationType.BOSSelectType = "";
            this.fld_lkeMMOperationType.BOSSelectTypeValue = "";
            this.fld_lkeMMOperationType.CurrentDisplayText = "";
            this.fld_lkeMMOperationType.Location = new System.Drawing.Point(127, 109);
            this.fld_lkeMMOperationType.Name = "fld_lkeMMOperationType";
            this.fld_lkeMMOperationType.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMOperationType.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationType.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationType.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationType.Properties.ColumnName = null;
            this.fld_lkeMMOperationType.Properties.NullText = "";
            this.fld_lkeMMOperationType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationType.Screen = null;
            this.fld_lkeMMOperationType.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMOperationType.TabIndex = 3;
            this.fld_lkeMMOperationType.Tag = "SC";
            // 
            // bosLabel3
            // 
            this.bosLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel3.Appearance.Options.UseBackColor = true;
            this.bosLabel3.Appearance.Options.UseFont = true;
            this.bosLabel3.Appearance.Options.UseForeColor = true;
            this.bosLabel3.BOSComment = "";
            this.bosLabel3.BOSDataMember = "";
            this.bosLabel3.BOSDataSource = "";
            this.bosLabel3.BOSDescription = null;
            this.bosLabel3.BOSError = null;
            this.bosLabel3.BOSFieldGroup = "";
            this.bosLabel3.BOSFieldRelation = "";
            this.bosLabel3.BOSPrivilege = "";
            this.bosLabel3.BOSPropertyName = null;
            this.bosLabel3.Location = new System.Drawing.Point(37, 113);
            this.bosLabel3.Name = "bosLabel3";
            this.bosLabel3.Screen = null;
            this.bosLabel3.Size = new System.Drawing.Size(20, 13);
            this.bosLabel3.TabIndex = 24;
            this.bosLabel3.Tag = "SI";
            this.bosLabel3.Text = "Loại";
            // 
            // fld_lkeMMOperationGroup
            // 
            this.fld_lkeMMOperationGroup.BOSAllowAddNew = false;
            this.fld_lkeMMOperationGroup.BOSAllowDummy = true;
            this.fld_lkeMMOperationGroup.BOSComment = "";
            this.fld_lkeMMOperationGroup.BOSDataMember = "MMOperationGroup";
            this.fld_lkeMMOperationGroup.BOSDataSource = "MMOperations";
            this.fld_lkeMMOperationGroup.BOSDescription = null;
            this.fld_lkeMMOperationGroup.BOSError = null;
            this.fld_lkeMMOperationGroup.BOSFieldGroup = "";
            this.fld_lkeMMOperationGroup.BOSFieldParent = "";
            this.fld_lkeMMOperationGroup.BOSFieldRelation = "";
            this.fld_lkeMMOperationGroup.BOSPrivilege = "";
            this.fld_lkeMMOperationGroup.BOSPropertyName = "EditValue";
            this.fld_lkeMMOperationGroup.BOSSelectType = "";
            this.fld_lkeMMOperationGroup.BOSSelectTypeValue = "";
            this.fld_lkeMMOperationGroup.CurrentDisplayText = "";
            this.fld_lkeMMOperationGroup.Location = new System.Drawing.Point(127, 83);
            this.fld_lkeMMOperationGroup.Name = "fld_lkeMMOperationGroup";
            this.fld_lkeMMOperationGroup.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.fld_lkeMMOperationGroup.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeMMOperationGroup.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeMMOperationGroup.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeMMOperationGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeMMOperationGroup.Properties.ColumnName = null;
            this.fld_lkeMMOperationGroup.Properties.NullText = "";
            this.fld_lkeMMOperationGroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeMMOperationGroup.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_lkeMMOperationGroup, true);
            this.fld_lkeMMOperationGroup.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeMMOperationGroup.TabIndex = 2;
            this.fld_lkeMMOperationGroup.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bosLabel2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseFont = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = "";
            this.bosLabel2.BOSDataMember = "";
            this.bosLabel2.BOSDataSource = "";
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = "";
            this.bosLabel2.BOSFieldRelation = "";
            this.bosLabel2.BOSPrivilege = "";
            this.bosLabel2.BOSPropertyName = null;
            this.bosLabel2.Location = new System.Drawing.Point(37, 87);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(83, 13);
            this.bosLabel2.TabIndex = 22;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Nhóm công đoạn";
            // 
            // SMOP100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(890, 568);
            this.Controls.Add(this.fld_lblLabel12);
            this.Controls.Add(this.bosTextBox1);
            this.Controls.Add(this.bosTextBox2);
            this.Controls.Add(this.fld_lblLabel14);
            this.Controls.Add(this.fld_lkeMMOperationType);
            this.Controls.Add(this.bosLabel3);
            this.Controls.Add(this.fld_lkeMMOperationGroup);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.fld_trlMMOperations);
            this.Name = "SMOP100";
            this.Text = "Danh sách công đoạn";
            this.Controls.SetChildIndex(this.fld_trlMMOperations, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMOperationGroup, 0);
            this.Controls.SetChildIndex(this.bosLabel3, 0);
            this.Controls.SetChildIndex(this.fld_lkeMMOperationType, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel14, 0);
            this.Controls.SetChildIndex(this.bosTextBox2, 0);
            this.Controls.SetChildIndex(this.bosTextBox1, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlMMOperations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeMMOperationGroup.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        private IContainer components;
        private BOSERP.Modules.Operation.MMOperationsTreeListControl fld_trlMMOperations;
        private BOSComponent.BOSLabel fld_lblLabel12;
        private BOSComponent.BOSTextBox bosTextBox1;
        private BOSComponent.BOSTextBox bosTextBox2;
        private BOSComponent.BOSLabel fld_lblLabel14;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationType;
        private BOSComponent.BOSLabel bosLabel3;
        private BOSComponent.BOSLookupEdit fld_lkeMMOperationGroup;
        private BOSComponent.BOSLabel bosLabel2;
    }
}
