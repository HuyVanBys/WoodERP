namespace BOSERP.Modules.PaymentProposal
{
    partial class guiProposalApprovals
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiProposalApprovals));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
            this.HREmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.cardView1;
            this.gridControl1.MenuManager = this.screenToolbar;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(510, 437);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.cardView1});
            // 
            // cardView1
            // 
            this.cardView1.Appearance.FieldCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardView1.Appearance.FieldCaption.Options.UseFont = true;
            this.cardView1.CardWidth = 520;
            this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.HREmployeeName,
            this.layoutViewColumn1,
            this.layoutViewColumn3});
            this.cardView1.GridControl = this.gridControl1;
            this.cardView1.Name = "cardView1";
            this.cardView1.OptionsBehavior.AllowExpandCollapse = false;
            this.cardView1.OptionsBehavior.AutoHorzWidth = true;
            this.cardView1.OptionsView.ShowLines = false;
            this.cardView1.OptionsView.ShowQuickCustomizeButton = false;
            this.cardView1.CustomDrawCardCaption += new DevExpress.XtraGrid.Views.Card.CardCaptionCustomDrawEventHandler(this.cardView1_CustomDrawCardCaption);
            // 
            // HREmployeeName
            // 
            this.HREmployeeName.Caption = "Người duyệt";
            this.HREmployeeName.FieldName = "HREmployeeName";
            this.HREmployeeName.Name = "HREmployeeName";
            this.HREmployeeName.OptionsColumn.AllowEdit = false;
            this.HREmployeeName.Visible = true;
            this.HREmployeeName.VisibleIndex = 0;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "Ngày duyệt";
            this.layoutViewColumn1.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm";
            this.layoutViewColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.layoutViewColumn1.FieldName = "APPaymentProposalApprovalDate";
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            this.layoutViewColumn1.OptionsColumn.AllowEdit = false;
            this.layoutViewColumn1.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
            this.layoutViewColumn1.Visible = true;
            this.layoutViewColumn1.VisibleIndex = 1;
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Lời nhắn";
            this.layoutViewColumn3.FieldName = "APPaymentProposalApprovalMessages";
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            this.layoutViewColumn3.OptionsColumn.AllowEdit = false;
            this.layoutViewColumn3.Visible = true;
            this.layoutViewColumn3.VisibleIndex = 2;
            // 
            // guiProposalApprovals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 437);
            this.ControlBox = true;
            this.Controls.Add(this.gridControl1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("guiProposalApprovals.IconOptions.Icon")));
            this.Name = "guiProposalApprovals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin xét duyệt";
            this.Load += new System.EventHandler(this.guiAllocationPlanItems_Load);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Card.CardView cardView1;
        private DevExpress.XtraGrid.Columns.GridColumn HREmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn3;
    }
}