using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.Segment.UI
{
	/// <summary>
	/// Summary description for SMAC100
	/// </summary>
	partial class SMAC100
	{
		private BOSComponent.BOSTextBox fld_txtACSegmentNo;
        private BOSComponent.BOSTextBox fld_txtACSegmentName;


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
            this.fld_txtACSegmentNo = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtACSegmentName = new BOSComponent.BOSTextBox(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcACSegment = new BOSERP.BOSSearchResultsGridControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACSegment)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_txtACSegmentNo
            // 
            this.fld_txtACSegmentNo.BOSComment = "";
            this.fld_txtACSegmentNo.BOSDataMember = "ACSegmentNo";
            this.fld_txtACSegmentNo.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentNo.BOSDescription = null;
            this.fld_txtACSegmentNo.BOSError = null;
            this.fld_txtACSegmentNo.BOSFieldGroup = "";
            this.fld_txtACSegmentNo.BOSFieldRelation = "";
            this.fld_txtACSegmentNo.BOSPrivilege = "";
            this.fld_txtACSegmentNo.BOSPropertyName = "Text";
            this.fld_txtACSegmentNo.EditValue = "";
            this.fld_txtACSegmentNo.Location = new System.Drawing.Point(123, 32);
            this.fld_txtACSegmentNo.Name = "fld_txtACSegmentNo";
            this.fld_txtACSegmentNo.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentNo.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentNo.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentNo.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentNo.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSegmentNo.Screen = null;
            this.fld_txtACSegmentNo.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSegmentNo.TabIndex = 0;
            this.fld_txtACSegmentNo.Tag = "SC";
            // 
            // fld_txtACSegmentName
            // 
            this.fld_txtACSegmentName.BOSComment = "";
            this.fld_txtACSegmentName.BOSDataMember = "ACSegmentName";
            this.fld_txtACSegmentName.BOSDataSource = "ACSegments";
            this.fld_txtACSegmentName.BOSDescription = null;
            this.fld_txtACSegmentName.BOSError = null;
            this.fld_txtACSegmentName.BOSFieldGroup = "";
            this.fld_txtACSegmentName.BOSFieldRelation = "";
            this.fld_txtACSegmentName.BOSPrivilege = "";
            this.fld_txtACSegmentName.BOSPropertyName = "Text";
            this.fld_txtACSegmentName.EditValue = "";
            this.fld_txtACSegmentName.Location = new System.Drawing.Point(123, 58);
            this.fld_txtACSegmentName.Name = "fld_txtACSegmentName";
            this.fld_txtACSegmentName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtACSegmentName.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtACSegmentName.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtACSegmentName.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtACSegmentName.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtACSegmentName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtACSegmentName.Screen = null;
            this.fld_txtACSegmentName.Size = new System.Drawing.Size(150, 20);
            this.fld_txtACSegmentName.TabIndex = 1;
            this.fld_txtACSegmentName.Tag = "SC";
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
            this.bosLabel2.Location = new System.Drawing.Point(38, 61);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(72, 13);
            this.bosLabel2.TabIndex = 9;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Tên khoản mục";
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
            this.bosLabel1.Location = new System.Drawing.Point(38, 35);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(68, 13);
            this.bosLabel1.TabIndex = 8;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Mã khoản mục";
            // 
            // fld_dgcACSegment
            // 
            this.fld_dgcACSegment.BOSComment = null;
            this.fld_dgcACSegment.BOSDataMember = null;
            this.fld_dgcACSegment.BOSDataSource = "ACSegments";
            this.fld_dgcACSegment.BOSDescription = null;
            this.fld_dgcACSegment.BOSError = null;
            this.fld_dgcACSegment.BOSFieldGroup = null;
            this.fld_dgcACSegment.BOSFieldRelation = null;
            this.fld_dgcACSegment.BOSPrivilege = null;
            this.fld_dgcACSegment.BOSPropertyName = null;
            this.fld_dgcACSegment.Location = new System.Drawing.Point(123, 197);
            this.fld_dgcACSegment.MenuManager = this.screenToolbar;
            this.fld_dgcACSegment.Name = "fld_dgcACSegment";
            this.fld_dgcACSegment.Screen = null;
            this.fld_dgcACSegment.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcACSegment.TabIndex = 10;
            this.fld_dgcACSegment.Tag = "SR";
            // 
            // SMAC100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcACSegment);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_txtACSegmentNo);
            this.Controls.Add(this.fld_txtACSegmentName);
            this.Name = "SMAC100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_txtACSegmentName, 0);
            this.Controls.SetChildIndex(this.fld_txtACSegmentNo, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_dgcACSegment, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtACSegmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcACSegment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSSearchResultsGridControl fld_dgcACSegment;
	}
}
