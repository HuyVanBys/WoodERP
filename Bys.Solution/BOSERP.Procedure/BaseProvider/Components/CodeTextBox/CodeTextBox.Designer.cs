namespace BOSERP
{
    partial class CodeTextBox
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CodeTextBox
            // 
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(CodeTextBox_MouseDoubleClick);            
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodeTextBox_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
