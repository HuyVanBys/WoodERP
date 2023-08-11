using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.RemindWorking.UI
{
	/// <summary>
	/// Summary description for DMRW101
	/// </summary>
	partial class DMRW101
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMRW101));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.fld_dgcADRemindWorkingSentMessagesGridControl = new BOSERP.Modules.RemindWorking.ADRemindWorkingSentsGridControl();
            this.fld_dgvARSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_btnAddNewRemainWorking = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADRemindWorkingSentMessagesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Controls.Add(this.fld_dgcADRemindWorkingSentMessagesGridControl);
            this.groupControl1.Name = "groupControl1";
            this.ScreenHelper.SetShowHelp(this.groupControl1, ((bool)(resources.GetObject("groupControl1.ShowHelp"))));
            // 
            // fld_dgcADRemindWorkingSentMessagesGridControl
            // 
            this.fld_dgcADRemindWorkingSentMessagesGridControl.AllowDrop = true;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSComment = null;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSDataMember = null;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSDataSource = "ADRemindWorkings";
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSDescription = null;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSError = null;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSFieldGroup = null;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSFieldRelation = null;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSGridType = null;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSPrivilege = null;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.BOSPropertyName = null;
            resources.ApplyResources(this.fld_dgcADRemindWorkingSentMessagesGridControl, "fld_dgcADRemindWorkingSentMessagesGridControl");
            this.fld_dgcADRemindWorkingSentMessagesGridControl.MainView = this.fld_dgvARSaleOrder;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.Name = "fld_dgcADRemindWorkingSentMessagesGridControl";
            this.fld_dgcADRemindWorkingSentMessagesGridControl.PrintReport = false;
            this.fld_dgcADRemindWorkingSentMessagesGridControl.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dgcADRemindWorkingSentMessagesGridControl, ((bool)(resources.GetObject("fld_dgcADRemindWorkingSentMessagesGridControl.ShowHelp"))));
            this.fld_dgcADRemindWorkingSentMessagesGridControl.Tag = "DC";
            this.fld_dgcADRemindWorkingSentMessagesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvARSaleOrder});
            // 
            // fld_dgvARSaleOrder
            // 
            this.fld_dgvARSaleOrder.GridControl = this.fld_dgcADRemindWorkingSentMessagesGridControl;
            this.fld_dgvARSaleOrder.Name = "fld_dgvARSaleOrder";
            this.fld_dgvARSaleOrder.PaintStyleName = "Office2003";
            // 
            // fld_btnAddNewRemainWorking
            // 
            this.fld_btnAddNewRemainWorking.Image = ((System.Drawing.Image)(resources.GetObject("fld_btnAddNewRemainWorking.Image")));
            resources.ApplyResources(this.fld_btnAddNewRemainWorking, "fld_btnAddNewRemainWorking");
            this.fld_btnAddNewRemainWorking.Name = "fld_btnAddNewRemainWorking";
            this.ScreenHelper.SetShowHelp(this.fld_btnAddNewRemainWorking, ((bool)(resources.GetObject("fld_btnAddNewRemainWorking.ShowHelp"))));
            this.fld_btnAddNewRemainWorking.Click += new System.EventHandler(this.fld_btnAddNewRemainWorking_Click);
            // 
            // DMRW101
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.fld_btnAddNewRemainWorking);
            this.Controls.Add(this.groupControl1);
            this.Name = "DMRW101";
            this.ScreenHelper.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
            this.Controls.SetChildIndex(this.groupControl1, 0);
            this.Controls.SetChildIndex(this.fld_btnAddNewRemainWorking, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcADRemindWorkingSentMessagesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvARSaleOrder)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private BOSERP.Modules.RemindWorking.ADRemindWorkingSentsGridControl fld_dgcADRemindWorkingSentMessagesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvARSaleOrder;
        private DevExpress.XtraEditors.SimpleButton fld_btnAddNewRemainWorking;
	}
}
