using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.TimeSheetScale.UI
{
	/// <summary>
	/// Summary description for SMTSS100
	/// </summary>
	partial class SMTSS100
	{
		private BOSSearchResultsGridControl fld_dgcTimeSheetScales;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvTimeSheetScales;


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
            this.fld_dgcTimeSheetScales = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvTimeSheetScales = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTimeSheetScales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvTimeSheetScales)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcTimeSheetScales
            // 
            this.fld_dgcTimeSheetScales.AllowDrop = true;
            this.fld_dgcTimeSheetScales.BOSComment = "";
            this.fld_dgcTimeSheetScales.BOSDataMember = "";
            this.fld_dgcTimeSheetScales.BOSDataSource = "HRTimeSheetScales";
            this.fld_dgcTimeSheetScales.BOSDescription = null;
            this.fld_dgcTimeSheetScales.BOSError = null;
            this.fld_dgcTimeSheetScales.BOSFieldGroup = "";
            this.fld_dgcTimeSheetScales.BOSFieldRelation = "";
            this.fld_dgcTimeSheetScales.BOSPrivilege = "";
            this.fld_dgcTimeSheetScales.BOSPropertyName = "";
            this.fld_dgcTimeSheetScales.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcTimeSheetScales.Location = new System.Drawing.Point(77, 117);
            this.fld_dgcTimeSheetScales.MainView = this.fld_dgvTimeSheetScales;
            this.fld_dgcTimeSheetScales.Name = "fld_dgcTimeSheetScales";
            this.fld_dgcTimeSheetScales.Screen = null;
            this.fld_dgcTimeSheetScales.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcTimeSheetScales.TabIndex = 4;
            this.fld_dgcTimeSheetScales.Tag = "SR";
            this.fld_dgcTimeSheetScales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvTimeSheetScales});
            // 
            // fld_dgvTimeSheetScales
            // 
            this.fld_dgvTimeSheetScales.GridControl = this.fld_dgcTimeSheetScales;
            this.fld_dgvTimeSheetScales.Name = "fld_dgvTimeSheetScales";
            this.fld_dgvTimeSheetScales.PaintStyleName = "Office2003";
            // 
            // SMTSS100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_dgcTimeSheetScales);
            this.Name = "SMTSS100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcTimeSheetScales, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTimeSheetScales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvTimeSheetScales)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
	}
}
