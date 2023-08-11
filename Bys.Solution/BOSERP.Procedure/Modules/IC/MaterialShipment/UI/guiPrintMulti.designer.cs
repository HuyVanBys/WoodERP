
namespace BOSERP.Modules.MaterialShipment
{
    partial class guiPrintMulti
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
            this.components = new System.ComponentModel.Container();
            this.bosLabel9 = new BOSComponent.BOSLabel(this.components);
            this.fld_dteSearchFromDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToDate = new BOSComponent.BOSDateEdit(this.components);
            this.bosLabel10 = new BOSComponent.BOSLabel(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnSearch = new BOSComponent.BOSButton(this.components);
            this.bosLine1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcPrintMultiMaterialShipmentsGridControl = new BOSERP.Modules.MaterialShipment.PrintMultiMaterialShipmentsGridControl();
            this.fld_dgvICShipmentItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bosPanel1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.bosLine1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPrintMultiMaterialShipmentsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).BeginInit();
            this.bosPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bosLabel9
            // 
            this.bosLabel9.BOSComment = null;
            this.bosLabel9.BOSDataMember = null;
            this.bosLabel9.BOSDataSource = null;
            this.bosLabel9.BOSDescription = null;
            this.bosLabel9.BOSError = null;
            this.bosLabel9.BOSFieldGroup = null;
            this.bosLabel9.BOSFieldRelation = null;
            this.bosLabel9.BOSPrivilege = null;
            this.bosLabel9.BOSPropertyName = null;
            this.bosLabel9.Location = new System.Drawing.Point(285, 15);
            this.bosLabel9.Name = "bosLabel9";
            this.bosLabel9.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel9, true);
            this.bosLabel9.Size = new System.Drawing.Size(47, 13);
            this.bosLabel9.TabIndex = 23;
            this.bosLabel9.Text = "Đến ngày";
            // 
            // fld_dteSearchFromDate
            // 
            this.fld_dteSearchFromDate.BOSComment = null;
            this.fld_dteSearchFromDate.BOSDataMember = null;
            this.fld_dteSearchFromDate.BOSDataSource = null;
            this.fld_dteSearchFromDate.BOSDescription = null;
            this.fld_dteSearchFromDate.BOSError = null;
            this.fld_dteSearchFromDate.BOSFieldGroup = null;
            this.fld_dteSearchFromDate.BOSFieldRelation = null;
            this.fld_dteSearchFromDate.BOSPrivilege = null;
            this.fld_dteSearchFromDate.BOSPropertyName = null;
            this.fld_dteSearchFromDate.EditValue = null;
            this.fld_dteSearchFromDate.Location = new System.Drawing.Point(105, 12);
            this.fld_dteSearchFromDate.Name = "fld_dteSearchFromDate";
            this.fld_dteSearchFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchFromDate, true);
            this.fld_dteSearchFromDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromDate.TabIndex = 20;
            this.fld_dteSearchFromDate.Tag = "DC";
            // 
            // fld_dteSearchToDate
            // 
            this.fld_dteSearchToDate.BOSComment = null;
            this.fld_dteSearchToDate.BOSDataMember = null;
            this.fld_dteSearchToDate.BOSDataSource = null;
            this.fld_dteSearchToDate.BOSDescription = null;
            this.fld_dteSearchToDate.BOSError = null;
            this.fld_dteSearchToDate.BOSFieldGroup = null;
            this.fld_dteSearchToDate.BOSFieldRelation = null;
            this.fld_dteSearchToDate.BOSPrivilege = null;
            this.fld_dteSearchToDate.BOSPropertyName = null;
            this.fld_dteSearchToDate.EditValue = null;
            this.fld_dteSearchToDate.Location = new System.Drawing.Point(350, 12);
            this.fld_dteSearchToDate.Name = "fld_dteSearchToDate";
            this.fld_dteSearchToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToDate.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_dteSearchToDate, true);
            this.fld_dteSearchToDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToDate.TabIndex = 22;
            this.fld_dteSearchToDate.Tag = "DC";
            // 
            // bosLabel10
            // 
            this.bosLabel10.BOSComment = null;
            this.bosLabel10.BOSDataMember = null;
            this.bosLabel10.BOSDataSource = null;
            this.bosLabel10.BOSDescription = null;
            this.bosLabel10.BOSError = null;
            this.bosLabel10.BOSFieldGroup = null;
            this.bosLabel10.BOSFieldRelation = null;
            this.bosLabel10.BOSPrivilege = null;
            this.bosLabel10.BOSPropertyName = null;
            this.bosLabel10.Location = new System.Drawing.Point(38, 15);
            this.bosLabel10.Name = "bosLabel10";
            this.bosLabel10.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLabel10, true);
            this.bosLabel10.Size = new System.Drawing.Size(40, 13);
            this.bosLabel10.TabIndex = 21;
            this.bosLabel10.Text = "Từ ngày";
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 615);
            this.panelControl2.Name = "panelControl2";
            this.ScreenHelper.SetShowHelp(this.panelControl2, true);
            this.panelControl2.Size = new System.Drawing.Size(987, 10);
            this.panelControl2.TabIndex = 9;
            // 
            // fld_btnClose
            // 
            this.fld_btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnClose.BOSComment = null;
            this.fld_btnClose.BOSDataMember = null;
            this.fld_btnClose.BOSDataSource = null;
            this.fld_btnClose.BOSDescription = null;
            this.fld_btnClose.BOSError = null;
            this.fld_btnClose.BOSFieldGroup = null;
            this.fld_btnClose.BOSFieldRelation = null;
            this.fld_btnClose.BOSPrivilege = null;
            this.fld_btnClose.BOSPropertyName = null;
            this.fld_btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnClose.Location = new System.Drawing.Point(893, 537);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnClose, true);
            this.fld_btnClose.Size = new System.Drawing.Size(84, 27);
            this.fld_btnClose.TabIndex = 1;
            this.fld_btnClose.Text = "Thoát";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_btnPrint
            // 
            this.fld_btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnPrint.BOSComment = null;
            this.fld_btnPrint.BOSDataMember = null;
            this.fld_btnPrint.BOSDataSource = null;
            this.fld_btnPrint.BOSDescription = null;
            this.fld_btnPrint.BOSError = null;
            this.fld_btnPrint.BOSFieldGroup = null;
            this.fld_btnPrint.BOSFieldRelation = null;
            this.fld_btnPrint.BOSPrivilege = null;
            this.fld_btnPrint.BOSPropertyName = null;
            this.fld_btnPrint.Location = new System.Drawing.Point(782, 537);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnPrint, true);
            this.fld_btnPrint.Size = new System.Drawing.Size(92, 27);
            this.fld_btnPrint.TabIndex = 0;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
            // 
            // fld_btnSearch
            // 
            this.fld_btnSearch.BOSComment = null;
            this.fld_btnSearch.BOSDataMember = null;
            this.fld_btnSearch.BOSDataSource = null;
            this.fld_btnSearch.BOSDescription = null;
            this.fld_btnSearch.BOSError = null;
            this.fld_btnSearch.BOSFieldGroup = null;
            this.fld_btnSearch.BOSFieldRelation = null;
            this.fld_btnSearch.BOSPrivilege = null;
            this.fld_btnSearch.BOSPropertyName = null;
            this.fld_btnSearch.Location = new System.Drawing.Point(549, 8);
            this.fld_btnSearch.Name = "fld_btnSearch";
            this.fld_btnSearch.Screen = null;
            this.ScreenHelper.SetShowHelp(this.fld_btnSearch, true);
            this.fld_btnSearch.Size = new System.Drawing.Size(84, 27);
            this.fld_btnSearch.TabIndex = 24;
            this.fld_btnSearch.Text = "Xem";
            this.fld_btnSearch.Click += new System.EventHandler(this.fld_btnSearch_Click);
            // 
            // bosLine1
            // 
            this.bosLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bosLine1.BOSComment = null;
            this.bosLine1.BOSDataMember = null;
            this.bosLine1.BOSDataSource = null;
            this.bosLine1.BOSDescription = null;
            this.bosLine1.BOSError = null;
            this.bosLine1.BOSFieldGroup = null;
            this.bosLine1.BOSFieldRelation = null;
            this.bosLine1.BOSPrivilege = null;
            this.bosLine1.BOSPropertyName = null;
            this.bosLine1.Controls.Add(this.fld_btnClose);
            this.bosLine1.Controls.Add(this.fld_btnPrint);
            this.bosLine1.Controls.Add(this.fld_dgcPrintMultiMaterialShipmentsGridControl);
            this.bosLine1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.bosLine1.Location = new System.Drawing.Point(2, 45);
            this.bosLine1.Name = "bosLine1";
            this.bosLine1.Screen = null;
            this.ScreenHelper.SetShowHelp(this.bosLine1, true);
            this.bosLine1.Size = new System.Drawing.Size(984, 575);
            this.bosLine1.TabIndex = 567;
            this.bosLine1.TabStop = false;
            this.bosLine1.Text = "Phiếu xuất kho";
            // 
            // fld_dgcPrintMultiMaterialShipmentsGridControl
            // 
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.AllowDrop = true;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSComment = string.Empty;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSDataMember = string.Empty;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSDataSource = "ICShipments";
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSDescription = null;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSError = null;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSFieldGroup = string.Empty;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSFieldRelation = string.Empty;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSGridType = null;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSPrivilege = string.Empty;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.BOSPropertyName = null;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.Location = new System.Drawing.Point(6, 20);
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.MainView = this.fld_dgvICShipmentItems;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.Name = "fld_dgcPrintMultiMaterialShipmentsGridControl";
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.PrintReport = false;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.Screen = null;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.Size = new System.Drawing.Size(971, 511);
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.TabIndex = 2;
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.Tag = "DC";
            this.fld_dgcPrintMultiMaterialShipmentsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvICShipmentItems});
            // 
            // fld_dgvICShipmentItems
            // 
            this.fld_dgvICShipmentItems.GridControl = this.fld_dgcPrintMultiMaterialShipmentsGridControl;
            this.fld_dgvICShipmentItems.Name = "fld_dgvICShipmentItems";
            this.fld_dgvICShipmentItems.PaintStyleName = "Office2003";
            // 
            // bosPanel1
            // 
            this.bosPanel1.Controls.Add(this.bosLine1);
            this.bosPanel1.Controls.Add(this.fld_btnSearch);
            this.bosPanel1.Controls.Add(this.panelControl2);
            this.bosPanel1.Controls.Add(this.bosLabel10);
            this.bosPanel1.Controls.Add(this.fld_dteSearchToDate);
            this.bosPanel1.Controls.Add(this.fld_dteSearchFromDate);
            this.bosPanel1.Controls.Add(this.bosLabel9);
            this.bosPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bosPanel1.Location = new System.Drawing.Point(0, 0);
            this.bosPanel1.Name = "bosPanel1";
            this.ScreenHelper.SetShowHelp(this.bosPanel1, true);
            this.bosPanel1.Size = new System.Drawing.Size(991, 627);
            this.bosPanel1.TabIndex = 9;
            // 
            // guiPrintMulti
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 627);
            this.ControlBox = true;
            this.Controls.Add(this.bosPanel1);
            this.Name = "guiPrintMulti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn bán hàng";
            this.Load += new System.EventHandler(this.guiPrintMulti_Load);
            this.Controls.SetChildIndex(this.bosPanel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.bosLine1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPrintMultiMaterialShipmentsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvICShipmentItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bosPanel1)).EndInit();
            this.bosPanel1.ResumeLayout(false);
            this.bosPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BOSComponent.BOSLabel bosLabel9;
        private BOSComponent.BOSDateEdit fld_dteSearchFromDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToDate;
        private BOSComponent.BOSLabel bosLabel10;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSButton fld_btnSearch;
        private BOSComponent.BOSLine bosLine1;
        private DevExpress.XtraEditors.PanelControl bosPanel1;
        private PrintMultiMaterialShipmentsGridControl fld_dgcPrintMultiMaterialShipmentsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvICShipmentItems;
    }
}