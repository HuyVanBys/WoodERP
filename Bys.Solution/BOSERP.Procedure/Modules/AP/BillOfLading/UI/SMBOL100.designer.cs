using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.BillOfLading.UI
{
	/// <summary>
	/// Summary description for SMBOL100
	/// </summary>
	partial class SMBOL100
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
            this.fld_dgcAPBillOfLadings = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPPurchaseOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_Lablel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtAPBillOfLadingNoSearch = new BOSComponent.BOSTextBox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPBillOfLadings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingNoSearch.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcAPBillOfLadings
            // 
            this.fld_dgcAPBillOfLadings.AllowDrop = true;
            this.fld_dgcAPBillOfLadings.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPBillOfLadings.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPBillOfLadings.BOSDataSource = "APBillOfLadings";
            this.fld_dgcAPBillOfLadings.BOSDescription = null;
            this.fld_dgcAPBillOfLadings.BOSError = null;
            this.fld_dgcAPBillOfLadings.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPBillOfLadings.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPBillOfLadings.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPBillOfLadings.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPBillOfLadings.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPBillOfLadings.Location = new System.Drawing.Point(30, 196);
            this.fld_dgcAPBillOfLadings.MainView = this.fld_dgvAPPurchaseOrder;
            this.fld_dgcAPBillOfLadings.Name = "fld_dgcAPBillOfLadings";
            this.fld_dgcAPBillOfLadings.Screen = null;
            this.fld_dgcAPBillOfLadings.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPBillOfLadings.TabIndex = 8;
            this.fld_dgcAPBillOfLadings.Tag = "SR";
            this.fld_dgcAPBillOfLadings.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrder});
            // 
            // fld_dgvAPPurchaseOrder
            // 
            this.fld_dgvAPPurchaseOrder.GridControl = this.fld_dgcAPBillOfLadings;
            this.fld_dgvAPPurchaseOrder.Name = "fld_dgvAPPurchaseOrder";
            this.fld_dgvAPPurchaseOrder.PaintStyleName = "Office2003";
            // 
            // fld_Lablel1
            // 
            this.fld_Lablel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.Options.UseBackColor = true;
            this.fld_Lablel1.Appearance.Options.UseForeColor = true;
            this.fld_Lablel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDescription = null;
            this.fld_Lablel1.BOSError = null;
            this.fld_Lablel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.Location = new System.Drawing.Point(29, 36);
            this.fld_Lablel1.Name = "fld_Lablel1";
            this.fld_Lablel1.Screen = null;
            this.fld_Lablel1.Size = new System.Drawing.Size(53, 13);
            this.fld_Lablel1.TabIndex = 10;
            this.fld_Lablel1.Tag = "SI";
            this.fld_Lablel1.Text = "Vận đơn số";
            // 
            // fld_txtAPBillOfLadingNoSearch
            // 
            this.fld_txtAPBillOfLadingNoSearch.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPBillOfLadingNoSearch.BOSDataMember = "APBillOfLadingNo";
            this.fld_txtAPBillOfLadingNoSearch.BOSDataSource = "APBillOfLadings";
            this.fld_txtAPBillOfLadingNoSearch.BOSDescription = null;
            this.fld_txtAPBillOfLadingNoSearch.BOSError = null;
            this.fld_txtAPBillOfLadingNoSearch.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPBillOfLadingNoSearch.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPBillOfLadingNoSearch.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPBillOfLadingNoSearch.BOSPropertyName = "Text";
            this.fld_txtAPBillOfLadingNoSearch.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPBillOfLadingNoSearch.Location = new System.Drawing.Point(144, 33);
            this.fld_txtAPBillOfLadingNoSearch.Name = "fld_txtAPBillOfLadingNoSearch";
            this.fld_txtAPBillOfLadingNoSearch.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPBillOfLadingNoSearch.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPBillOfLadingNoSearch.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPBillOfLadingNoSearch.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPBillOfLadingNoSearch.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPBillOfLadingNoSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPBillOfLadingNoSearch.Screen = null;
            this.fld_txtAPBillOfLadingNoSearch.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPBillOfLadingNoSearch.TabIndex = 9;
            this.fld_txtAPBillOfLadingNoSearch.Tag = "SC";
            // 
            // SMBOL100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.fld_Lablel1);
            this.Controls.Add(this.fld_txtAPBillOfLadingNoSearch);
            this.Controls.Add(this.fld_dgcAPBillOfLadings);
            this.Name = "SMBOL100";
            this.Text = "Tìm kiếm";
            this.Controls.SetChildIndex(this.fld_dgcAPBillOfLadings, 0);
            this.Controls.SetChildIndex(this.fld_txtAPBillOfLadingNoSearch, 0);
            this.Controls.SetChildIndex(this.fld_Lablel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPBillOfLadings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPBillOfLadingNoSearch.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        private BOSSearchResultsGridControl fld_dgcAPBillOfLadings;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrder;
        private IContainer components;
        private BOSComponent.BOSLabel fld_Lablel1;
        private BOSComponent.BOSTextBox fld_txtAPBillOfLadingNoSearch;
	}
}
