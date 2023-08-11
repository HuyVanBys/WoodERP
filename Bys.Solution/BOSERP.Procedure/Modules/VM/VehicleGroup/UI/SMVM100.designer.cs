using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.VehicleGroup.UI
{
	/// <summary>
	/// Summary description for SMVM100
	/// </summary>
	partial class SMVM100
	{
		private BOSComponent.BOSTextBox fld_txtVMVehicleGroupNo1;
        private BOSComponent.BOSMemoEdit fld_medVMVehicleGroupDesc1;


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
            this.fld_txtVMVehicleGroupNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medVMVehicleGroupDesc1 = new BOSComponent.BOSMemoEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosSearchResultsGridControl1 = new BOSERP.BOSSearchResultsGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleGroupNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medVMVehicleGroupDesc1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosSearchResultsGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtVMVehicleGroupNo1
            // 
            this.fld_txtVMVehicleGroupNo1.BOSComment = "";
            this.fld_txtVMVehicleGroupNo1.BOSDataMember = "VMVehicleGroupNo";
            this.fld_txtVMVehicleGroupNo1.BOSDataSource = "VMVehicleGroups";
            this.fld_txtVMVehicleGroupNo1.BOSDescription = null;
            this.fld_txtVMVehicleGroupNo1.BOSError = null;
            this.fld_txtVMVehicleGroupNo1.BOSFieldGroup = "";
            this.fld_txtVMVehicleGroupNo1.BOSFieldRelation = "";
            this.fld_txtVMVehicleGroupNo1.BOSPrivilege = "";
            this.fld_txtVMVehicleGroupNo1.BOSPropertyName = "Text";
            this.fld_txtVMVehicleGroupNo1.EditValue = "";
            this.fld_txtVMVehicleGroupNo1.Location = new System.Drawing.Point(111, 46);
            this.fld_txtVMVehicleGroupNo1.Name = "fld_txtVMVehicleGroupNo1";
            this.fld_txtVMVehicleGroupNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtVMVehicleGroupNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtVMVehicleGroupNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtVMVehicleGroupNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtVMVehicleGroupNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtVMVehicleGroupNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtVMVehicleGroupNo1.Screen = null;
            this.fld_txtVMVehicleGroupNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtVMVehicleGroupNo1.TabIndex = 4;
            this.fld_txtVMVehicleGroupNo1.Tag = "SC";
            // 
            // fld_medVMVehicleGroupDesc1
            // 
            this.fld_medVMVehicleGroupDesc1.BOSComment = "";
            this.fld_medVMVehicleGroupDesc1.BOSDataMember = "VMVehicleGroupDesc";
            this.fld_medVMVehicleGroupDesc1.BOSDataSource = "VMVehicleGroups";
            this.fld_medVMVehicleGroupDesc1.BOSDescription = null;
            this.fld_medVMVehicleGroupDesc1.BOSError = null;
            this.fld_medVMVehicleGroupDesc1.BOSFieldGroup = "";
            this.fld_medVMVehicleGroupDesc1.BOSFieldRelation = "";
            this.fld_medVMVehicleGroupDesc1.BOSPrivilege = "";
            this.fld_medVMVehicleGroupDesc1.BOSPropertyName = "Text";
            this.fld_medVMVehicleGroupDesc1.EditValue = "";
            this.fld_medVMVehicleGroupDesc1.Location = new System.Drawing.Point(111, 72);
            this.fld_medVMVehicleGroupDesc1.Name = "fld_medVMVehicleGroupDesc1";
            this.fld_medVMVehicleGroupDesc1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medVMVehicleGroupDesc1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medVMVehicleGroupDesc1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medVMVehicleGroupDesc1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medVMVehicleGroupDesc1.Screen = null;
            this.fld_medVMVehicleGroupDesc1.Size = new System.Drawing.Size(335, 54);
            this.fld_medVMVehicleGroupDesc1.TabIndex = 5;
            this.fld_medVMVehicleGroupDesc1.Tag = "SC";
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
            this.bosLabel1.Location = new System.Drawing.Point(25, 49);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(58, 13);
            this.bosLabel1.TabIndex = 6;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã nhóm xe";
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
            this.bosLabel2.Location = new System.Drawing.Point(25, 75);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(27, 13);
            this.bosLabel2.TabIndex = 6;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Mô tả";
            // 
            // bosSearchResultsGridControl1
            // 
            this.bosSearchResultsGridControl1.BOSComment = null;
            this.bosSearchResultsGridControl1.BOSDataMember = null;
            this.bosSearchResultsGridControl1.BOSDataSource = "VMVehicleGroups";
            this.bosSearchResultsGridControl1.BOSDescription = null;
            this.bosSearchResultsGridControl1.BOSError = null;
            this.bosSearchResultsGridControl1.BOSFieldGroup = null;
            this.bosSearchResultsGridControl1.BOSFieldRelation = null;
            this.bosSearchResultsGridControl1.BOSPrivilege = null;
            this.bosSearchResultsGridControl1.BOSPropertyName = null;
            this.bosSearchResultsGridControl1.Location = new System.Drawing.Point(123, 207);
            this.bosSearchResultsGridControl1.MenuManager = this.screenToolbar;
            this.bosSearchResultsGridControl1.Name = "bosSearchResultsGridControl1";
            this.bosSearchResultsGridControl1.Screen = null;
            this.bosSearchResultsGridControl1.Size = new System.Drawing.Size(400, 200);
            this.bosSearchResultsGridControl1.TabIndex = 7;
            this.bosSearchResultsGridControl1.Tag = "SR";
            // 
            // SMVM100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.bosSearchResultsGridControl1);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_medVMVehicleGroupDesc1);
            this.Controls.Add(this.fld_txtVMVehicleGroupNo1);
            this.Name = "SMVM100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtVMVehicleGroupNo1, 0);
            this.Controls.SetChildIndex(this.fld_medVMVehicleGroupDesc1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.bosSearchResultsGridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtVMVehicleGroupNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medVMVehicleGroupDesc1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosSearchResultsGridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSSearchResultsGridControl bosSearchResultsGridControl1;
	}
}
