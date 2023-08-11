using BOSComponent;

namespace BOSERP.Modules.Report
{
    partial class TemplateParamForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new BOSComponent.BOSGridControl(this.components);
            this.ParamGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 31);
            this.panel1.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(88, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 31);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOK.Location = new System.Drawing.Point(0, 0);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 31);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Đồ&ng ý";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BOSComment = null;
            this.dataGridView1.BOSDataMember = null;
            this.dataGridView1.BOSDataSource = null;
            this.dataGridView1.BOSDescription = null;
            this.dataGridView1.BOSError = null;
            this.dataGridView1.BOSFieldGroup = null;
            this.dataGridView1.BOSFieldRelation = null;
            this.dataGridView1.BOSGridType = null;
            this.dataGridView1.BOSPrivilege = null;
            this.dataGridView1.BOSPropertyName = null;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MainView = this.ParamGridView;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.PrintReport = false;
            this.dataGridView1.Screen = null;
            this.dataGridView1.Size = new System.Drawing.Size(351, 257);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ParamGridView});
            // 
            // ParamGridView
            // 
            this.ParamGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colValue});
            this.ParamGridView.GridControl = this.dataGridView1;
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
            // TemplateParamForm
            // 
            this.AcceptButton = this.btnOK;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(351, 288);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "TemplateParamForm";
            this.Text = "Report paramater";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParamGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private BOSGridControl dataGridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView ParamGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
    }
}