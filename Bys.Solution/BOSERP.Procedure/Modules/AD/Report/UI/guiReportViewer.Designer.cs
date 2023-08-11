namespace BOSERP.Modules.Report
{
    partial class guiReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(guiReportViewer));
            this.fld_rptReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // fld_rptReportViewer
            // 
            this.fld_rptReportViewer.ActiveViewIndex = -1;
            this.fld_rptReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_rptReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fld_rptReportViewer.DisplayGroupTree = false;
            this.fld_rptReportViewer.Location = new System.Drawing.Point(275, 0);
            this.fld_rptReportViewer.Name = "fld_rptReportViewer";
            this.fld_rptReportViewer.SelectionFormula = "";
            this.fld_rptReportViewer.Size = new System.Drawing.Size(1000, 875);
            this.fld_rptReportViewer.TabIndex = 6;
            this.fld_rptReportViewer.ViewTimeSelectionFormula = "";
            // 
            // guiReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 875);
            this.ControlBox = true;
            this.Controls.Add(this.fld_rptReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "guiReportViewer";
            this.Text = "guiReportViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer fld_rptReportViewer;
    }
}