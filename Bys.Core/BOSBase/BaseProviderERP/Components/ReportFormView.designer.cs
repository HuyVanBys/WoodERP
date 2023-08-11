namespace BOSERP
{
    partial class ReportFormView
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
            this.fld_pnlMainGroup = new System.Windows.Forms.Panel();
            this.fld_btnPrint = new BOSComponent.BOSButton(this.components);
            this.fld_btnClose = new BOSComponent.BOSButton(this.components);
            this.fld_dgcTemplateParamsGridControl = new BOSComponent.BOSGridControl(this.components);
            this.ParamGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fld_pnlParamGroup = new System.Windows.Forms.Panel();
            this.fld_btnView = new BOSComponent.BOSButton(this.components);
            this.fld_pnlMainGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTemplateParamsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamGridView)).BeginInit();
            this.fld_pnlParamGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // fld_pnlMainGroup
            // 
            this.fld_pnlMainGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pnlMainGroup.BackColor = System.Drawing.Color.Transparent;
            this.fld_pnlMainGroup.Controls.Add(this.fld_btnPrint);
            this.fld_pnlMainGroup.Controls.Add(this.fld_btnClose);
            this.fld_pnlMainGroup.Location = new System.Drawing.Point(0, 203);
            this.fld_pnlMainGroup.Name = "fld_pnlMainGroup";
            this.fld_pnlMainGroup.Size = new System.Drawing.Size(896, 373);
            this.fld_pnlMainGroup.TabIndex = 6;
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
            this.fld_btnPrint.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnPrint.Location = new System.Drawing.Point(717, 340);
            this.fld_btnPrint.Name = "fld_btnPrint";
            this.fld_btnPrint.Screen = null;
            this.fld_btnPrint.Size = new System.Drawing.Size(83, 27);
            this.fld_btnPrint.TabIndex = 3;
            this.fld_btnPrint.Text = "In";
            this.fld_btnPrint.Click += new System.EventHandler(this.fld_btnPrint_Click);
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
            this.fld_btnClose.Location = new System.Drawing.Point(806, 340);
            this.fld_btnClose.Name = "fld_btnClose";
            this.fld_btnClose.Screen = null;
            this.fld_btnClose.Size = new System.Drawing.Size(83, 27);
            this.fld_btnClose.TabIndex = 3;
            this.fld_btnClose.Text = "Đóng";
            this.fld_btnClose.Click += new System.EventHandler(this.fld_btnClose_Click);
            // 
            // fld_dgcTemplateParamsGridControl
            // 
            this.fld_dgcTemplateParamsGridControl.BOSComment = null;
            this.fld_dgcTemplateParamsGridControl.BOSDataMember = null;
            this.fld_dgcTemplateParamsGridControl.BOSDataSource = null;
            this.fld_dgcTemplateParamsGridControl.BOSDescription = null;
            this.fld_dgcTemplateParamsGridControl.BOSError = null;
            this.fld_dgcTemplateParamsGridControl.BOSFieldGroup = null;
            this.fld_dgcTemplateParamsGridControl.BOSFieldRelation = null;
            this.fld_dgcTemplateParamsGridControl.BOSGridType = null;
            this.fld_dgcTemplateParamsGridControl.BOSPrivilege = null;
            this.fld_dgcTemplateParamsGridControl.BOSPropertyName = null;
            this.fld_dgcTemplateParamsGridControl.CommodityType = "";
            this.fld_dgcTemplateParamsGridControl.Location = new System.Drawing.Point(3, 3);
            this.fld_dgcTemplateParamsGridControl.MainView = this.ParamGridView;
            this.fld_dgcTemplateParamsGridControl.Name = "fld_dgcTemplateParamsGridControl";
            this.fld_dgcTemplateParamsGridControl.PrintReport = false;
            this.fld_dgcTemplateParamsGridControl.Screen = null;
            this.fld_dgcTemplateParamsGridControl.Size = new System.Drawing.Size(693, 192);
            this.fld_dgcTemplateParamsGridControl.TabIndex = 8;
            this.fld_dgcTemplateParamsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ParamGridView});
            // 
            // ParamGridView
            // 
            this.ParamGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colValue});
            this.ParamGridView.GridControl = this.fld_dgcTemplateParamsGridControl;
            this.ParamGridView.Name = "ParamGridView";
            this.ParamGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.ParamGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.ParamGridView.OptionsCustomization.AllowColumnMoving = false;
            this.ParamGridView.OptionsCustomization.AllowFilter = false;
            this.ParamGridView.OptionsCustomization.AllowGroup = false;
            this.ParamGridView.OptionsCustomization.AllowSort = false;
            this.ParamGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Tham số";
            this.colName.FieldName = "ADTemplateParamName";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colValue
            // 
            this.colValue.Caption = "Giá trị";
            this.colValue.FieldName = "ADTemplateParamValue";
            this.colValue.Name = "colValue";
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 1;
            // 
            // fld_pnlParamGroup
            // 
            this.fld_pnlParamGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_pnlParamGroup.BackColor = System.Drawing.Color.Transparent;
            this.fld_pnlParamGroup.Controls.Add(this.fld_dgcTemplateParamsGridControl);
            this.fld_pnlParamGroup.Controls.Add(this.fld_btnView);
            this.fld_pnlParamGroup.Location = new System.Drawing.Point(0, -1);
            this.fld_pnlParamGroup.Name = "fld_pnlParamGroup";
            this.fld_pnlParamGroup.Size = new System.Drawing.Size(896, 198);
            this.fld_pnlParamGroup.TabIndex = 7;
            // 
            // fld_btnView
            // 
            this.fld_btnView.BOSComment = null;
            this.fld_btnView.BOSDataMember = null;
            this.fld_btnView.BOSDataSource = null;
            this.fld_btnView.BOSDescription = null;
            this.fld_btnView.BOSError = null;
            this.fld_btnView.BOSFieldGroup = null;
            this.fld_btnView.BOSFieldRelation = null;
            this.fld_btnView.BOSPrivilege = null;
            this.fld_btnView.BOSPropertyName = null;
            this.fld_btnView.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.fld_btnView.Location = new System.Drawing.Point(702, 168);
            this.fld_btnView.Name = "fld_btnView";
            this.fld_btnView.Screen = null;
            this.fld_btnView.Size = new System.Drawing.Size(83, 27);
            this.fld_btnView.TabIndex = 4;
            this.fld_btnView.Text = "Xem";
            this.fld_btnView.Click += new System.EventHandler(this.fld_btnView_Click);
            // 
            // ReportFormView
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 576);
            this.Controls.Add(this.fld_pnlParamGroup);
            this.Controls.Add(this.fld_pnlMainGroup);
            this.Name = "ReportFormView";
            this.Text = "ReportFormView";
            this.Controls.SetChildIndex(this.fld_pnlMainGroup, 0);
            this.Controls.SetChildIndex(this.fld_pnlParamGroup, 0);
            this.fld_pnlMainGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcTemplateParamsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamGridView)).EndInit();
            this.fld_pnlParamGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel fld_pnlMainGroup;
        private BOSComponent.BOSButton fld_btnClose;
        private BOSComponent.BOSButton fld_btnPrint;
        private BOSComponent.BOSGridControl fld_dgcTemplateParamsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ParamGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private System.Windows.Forms.Panel fld_pnlParamGroup;
        private BOSComponent.BOSButton fld_btnView;
       

    }
}