namespace WIFASERP.Modules.CompanyConfig
{
    partial class guiConfigurationPeriode
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
            this.fld_dgcPeriode = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ADPeriodeDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADPeriodeDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ADPeriodeDateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPeriode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_dgcPeriode
            // 
            this.fld_dgcPeriode.EmbeddedNavigator.Name = "";
            this.fld_dgcPeriode.Location = new System.Drawing.Point(12, 12);
            this.fld_dgcPeriode.MainView = this.gridView1;
            this.fld_dgcPeriode.Name = "fld_dgcPeriode";
            this.fld_dgcPeriode.Size = new System.Drawing.Size(605, 500);
            this.fld_dgcPeriode.TabIndex = 4;
            this.fld_dgcPeriode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ADPeriodeDesc,
            this.ADPeriodeDateFrom,
            this.ADPeriodeDateTo});
            this.gridView1.GridControl = this.fld_dgcPeriode;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView1.PaintStyleName = "Office2003";
            // 
            // ADPeriodeDesc
            // 
            this.ADPeriodeDesc.Caption = "Bezeichnung";
            this.ADPeriodeDesc.FieldName = "ADPeriodeDesc";
            this.ADPeriodeDesc.Name = "ADPeriodeDesc";
            this.ADPeriodeDesc.Visible = true;
            this.ADPeriodeDesc.VisibleIndex = 0;
            this.ADPeriodeDesc.Width = 297;
            // 
            // ADPeriodeDateFrom
            // 
            this.ADPeriodeDateFrom.Caption = "Von";
            this.ADPeriodeDateFrom.FieldName = "ADPeriodeDateFrom";
            this.ADPeriodeDateFrom.Name = "ADPeriodeDateFrom";
            this.ADPeriodeDateFrom.Visible = true;
            this.ADPeriodeDateFrom.VisibleIndex = 1;
            this.ADPeriodeDateFrom.Width = 145;
            // 
            // ADPeriodeDateTo
            // 
            this.ADPeriodeDateTo.Caption = "Bis";
            this.ADPeriodeDateTo.FieldName = "ADPeriodeDateTo";
            this.ADPeriodeDateTo.Name = "ADPeriodeDateTo";
            this.ADPeriodeDateTo.Visible = true;
            this.ADPeriodeDateTo.VisibleIndex = 2;
            this.ADPeriodeDateTo.Width = 146;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.fld_dgcPeriode;
            this.gridView2.Name = "gridView2";
            // 
            // guiConfigurationPeriode
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 535);
            this.Controls.Add(this.fld_dgcPeriode);
            this.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.LookAndFeel.UseWindowsXPTheme = false;
            this.Name = "guiConfigurationPeriode";
            this.Text = "Periode";
            this.Load += new System.EventHandler(this.guiConfigurationPeriode_Load);
            this.Controls.SetChildIndex(this.fld_dgcPeriode, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcPeriode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl fld_dgcPeriode;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ADPeriodeDesc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ADPeriodeDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn ADPeriodeDateTo;
    }
}