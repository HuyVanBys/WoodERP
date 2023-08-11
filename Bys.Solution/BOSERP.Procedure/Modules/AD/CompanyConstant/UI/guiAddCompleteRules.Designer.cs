
namespace BOSERP
{
    partial class guiAddCompleteRules
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.fld_btnExist = new DevExpress.XtraEditors.SimpleButton();
            this.fld_btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.fld_flcCompleteRules = new DevExpress.XtraEditors.FilterControl();
            this.fld_txtViewResult = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fld_btnExist);
            this.panel1.Controls.Add(this.fld_btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 45);
            this.panel1.TabIndex = 1;
            // 
            // fld_btnExist
            // 
            this.fld_btnExist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnExist.Location = new System.Drawing.Point(450, 10);
            this.fld_btnExist.Name = "fld_btnExist";
            this.fld_btnExist.Size = new System.Drawing.Size(75, 23);
            this.fld_btnExist.TabIndex = 1;
            this.fld_btnExist.Text = "Hủy bỏ";
            this.fld_btnExist.Click += new System.EventHandler(this.fld_btnExist_Click);
            // 
            // fld_btnOK
            // 
            this.fld_btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_btnOK.Location = new System.Drawing.Point(369, 10);
            this.fld_btnOK.Name = "fld_btnOK";
            this.fld_btnOK.Size = new System.Drawing.Size(75, 23);
            this.fld_btnOK.TabIndex = 0;
            this.fld_btnOK.Text = "Đồng ý";
            this.fld_btnOK.Click += new System.EventHandler(this.fld_btnOK_Click);
            // 
            // fld_flcCompleteRules
            // 
            this.fld_flcCompleteRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_flcCompleteRules.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fld_flcCompleteRules.Location = new System.Drawing.Point(0, 3);
            this.fld_flcCompleteRules.Name = "fld_flcCompleteRules";
            this.fld_flcCompleteRules.Size = new System.Drawing.Size(537, 175);
            this.fld_flcCompleteRules.TabIndex = 2;
            this.fld_flcCompleteRules.Text = "filterControl1";
            this.fld_flcCompleteRules.FilterChanged += new DevExpress.XtraEditors.FilterChangedEventHandler(this.fld_flcCompleteRules_FilterChanged);
            this.fld_flcCompleteRules.BeforeShowValueEditor += new DevExpress.XtraEditors.Filtering.ShowValueEditorEventHandler(this.fld_flcCompleteRules_BeforeShowValueEditor);
            // 
            // fld_txtViewResult
            // 
            this.fld_txtViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_txtViewResult.BackColor = System.Drawing.Color.White;
            this.fld_txtViewResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fld_txtViewResult.Location = new System.Drawing.Point(0, 175);
            this.fld_txtViewResult.Name = "fld_txtViewResult";
            this.fld_txtViewResult.ReadOnly = true;
            this.fld_txtViewResult.Size = new System.Drawing.Size(537, 96);
            this.fld_txtViewResult.TabIndex = 2;
            this.fld_txtViewResult.Text = "";
            // 
            // guiAddCompleteRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 319);
            this.Controls.Add(this.fld_txtViewResult);
            this.Controls.Add(this.fld_flcCompleteRules);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "guiAddCompleteRules";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo điều kiện duyệt";
            this.Load += new System.EventHandler(this.guiAddCompleteRules_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton fld_btnExist;
        private DevExpress.XtraEditors.SimpleButton fld_btnOK;
        private DevExpress.XtraEditors.FilterControl fld_flcCompleteRules;
        private System.Windows.Forms.RichTextBox fld_txtViewResult;
    }
}