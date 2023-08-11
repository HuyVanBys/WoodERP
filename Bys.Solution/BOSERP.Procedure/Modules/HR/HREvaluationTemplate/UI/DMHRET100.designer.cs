using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.HREvaluationTemplate.UI
{
	/// <summary>
	/// Summary description for DMHRET100
	/// </summary>
	partial class DMHRET100
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
            this.fld_grcGroupControl1 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_dgcHRTemplateRanks = new BOSERP.Modules.HREvaluationTemplate.HRTemplateRanksGridControl();
            this.fld_dgvHRTemplateRanks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl2 = new BOSComponent.BOSGroupControl(this.components);
            this.fld_btnAddNode = new BOSComponent.BOSButton(this.components);
            this.fld_btnRemoveNode = new BOSComponent.BOSButton(this.components);
            this.fld_Line = new BOSComponent.BOSLine(this.components);
            this.fld_trlHREvaluationStandards = new BOSERP.Modules.HREvaluationTemplate.HREvaluationStandardsTreeListControl();
            this.fld_Line1 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcHRTemplateStandards = new BOSERP.Modules.HREvaluationTemplate.HRTemplateStandardsGridControl();
            this.fld_dgvHRTemplateStandards = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_Line2 = new BOSComponent.BOSLine(this.components);
            this.fld_dgcHRStandardQuestions = new BOSERP.Modules.HREvaluationTemplate.HRStandardQuestionsGridControl();
            this.fld_dgvHRStandardQuestions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_grcGroupControl = new BOSComponent.BOSGroupControl(this.components);
            this.fld_lblLabel5 = new BOSComponent.BOSLabel(this.components);
            this.fld_txtHREvaluationTemplateNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_txtHREvaluationTemplateName1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_medHREvaluationTemplateDesc = new BOSComponent.BOSMemoEdit(this.components);
            this.fld_lblLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel3 = new BOSComponent.BOSLabel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).BeginInit();
            this.fld_grcGroupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTemplateRanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTemplateRanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).BeginInit();
            this.fld_grcGroupControl2.SuspendLayout();
            this.fld_Line.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHREvaluationStandards)).BeginInit();
            this.fld_Line1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTemplateStandards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTemplateStandards)).BeginInit();
            this.fld_Line2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRStandardQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRStandardQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).BeginInit();
            this.fld_grcGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationTemplateNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationTemplateName1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREvaluationTemplateDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_grcGroupControl1
            // 
            this.fld_grcGroupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl1.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl1.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl1.BOSComment = "";
            this.fld_grcGroupControl1.BOSDataMember = "";
            this.fld_grcGroupControl1.BOSDataSource = "";
            this.fld_grcGroupControl1.BOSDescription = null;
            this.fld_grcGroupControl1.BOSError = null;
            this.fld_grcGroupControl1.BOSFieldGroup = "";
            this.fld_grcGroupControl1.BOSFieldRelation = "";
            this.fld_grcGroupControl1.BOSPrivilege = "";
            this.fld_grcGroupControl1.BOSPropertyName = "";
            this.fld_grcGroupControl1.Controls.Add(this.fld_dgcHRTemplateRanks);
            this.fld_grcGroupControl1.Location = new System.Drawing.Point(7, 122);
            this.fld_grcGroupControl1.Name = "fld_grcGroupControl1";
            this.fld_grcGroupControl1.Screen = null;
            this.fld_grcGroupControl1.Size = new System.Drawing.Size(969, 192);
            this.fld_grcGroupControl1.TabIndex = 14;
            this.fld_grcGroupControl1.Tag = "";
            this.fld_grcGroupControl1.Text = "Các thang đánh giá";
            // 
            // fld_dgcHRTemplateRanks
            // 
            this.fld_dgcHRTemplateRanks.AllowDrop = true;
            this.fld_dgcHRTemplateRanks.BOSComment = "";
            this.fld_dgcHRTemplateRanks.BOSDataMember = "";
            this.fld_dgcHRTemplateRanks.BOSDataSource = "HRTemplateRanks";
            this.fld_dgcHRTemplateRanks.BOSDescription = null;
            this.fld_dgcHRTemplateRanks.BOSError = null;
            this.fld_dgcHRTemplateRanks.BOSFieldGroup = "";
            this.fld_dgcHRTemplateRanks.BOSFieldRelation = "";
            this.fld_dgcHRTemplateRanks.BOSGridType = null;
            this.fld_dgcHRTemplateRanks.BOSPrivilege = "";
            this.fld_dgcHRTemplateRanks.BOSPropertyName = "";
            this.fld_dgcHRTemplateRanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRTemplateRanks.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTemplateRanks.Location = new System.Drawing.Point(2, 22);
            this.fld_dgcHRTemplateRanks.MainView = this.fld_dgvHRTemplateRanks;
            this.fld_dgcHRTemplateRanks.Name = "fld_dgcHRTemplateRanks";
            this.fld_dgcHRTemplateRanks.Screen = null;
            this.fld_dgcHRTemplateRanks.Size = new System.Drawing.Size(965, 168);
            this.fld_dgcHRTemplateRanks.TabIndex = 11;
            this.fld_dgcHRTemplateRanks.Tag = "DC";
            this.fld_dgcHRTemplateRanks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRTemplateRanks});
            // 
            // fld_dgvHRTemplateRanks
            // 
            this.fld_dgvHRTemplateRanks.GridControl = this.fld_dgcHRTemplateRanks;
            this.fld_dgvHRTemplateRanks.Name = "fld_dgvHRTemplateRanks";
            this.fld_dgvHRTemplateRanks.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl2
            // 
            this.fld_grcGroupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl2.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl2.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl2.BOSComment = "";
            this.fld_grcGroupControl2.BOSDataMember = "";
            this.fld_grcGroupControl2.BOSDataSource = "";
            this.fld_grcGroupControl2.BOSDescription = null;
            this.fld_grcGroupControl2.BOSError = null;
            this.fld_grcGroupControl2.BOSFieldGroup = "";
            this.fld_grcGroupControl2.BOSFieldRelation = "";
            this.fld_grcGroupControl2.BOSPrivilege = "";
            this.fld_grcGroupControl2.BOSPropertyName = "";
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnAddNode);
            this.fld_grcGroupControl2.Controls.Add(this.fld_btnRemoveNode);
            this.fld_grcGroupControl2.Controls.Add(this.fld_Line);
            this.fld_grcGroupControl2.Controls.Add(this.fld_Line1);
            this.fld_grcGroupControl2.Controls.Add(this.fld_Line2);
            this.fld_grcGroupControl2.Location = new System.Drawing.Point(8, 316);
            this.fld_grcGroupControl2.Name = "fld_grcGroupControl2";
            this.fld_grcGroupControl2.Screen = null;
            this.fld_grcGroupControl2.Size = new System.Drawing.Size(969, 362);
            this.fld_grcGroupControl2.TabIndex = 15;
            this.fld_grcGroupControl2.Tag = "";
            this.fld_grcGroupControl2.Text = "Các tiêu chí đánh giá";
            // 
            // fld_btnAddNode
            // 
            this.fld_btnAddNode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnAddNode.Appearance.Options.UseForeColor = true;
            this.fld_btnAddNode.BOSComment = "";
            this.fld_btnAddNode.BOSDataMember = "";
            this.fld_btnAddNode.BOSDataSource = "";
            this.fld_btnAddNode.BOSDescription = null;
            this.fld_btnAddNode.BOSError = null;
            this.fld_btnAddNode.BOSFieldGroup = "";
            this.fld_btnAddNode.BOSFieldRelation = "";
            this.fld_btnAddNode.BOSPrivilege = "";
            this.fld_btnAddNode.BOSPropertyName = "";
            this.fld_btnAddNode.Location = new System.Drawing.Point(349, 129);
            this.fld_btnAddNode.Name = "fld_btnAddNode";
            this.fld_btnAddNode.Screen = null;
            this.fld_btnAddNode.Size = new System.Drawing.Size(50, 27);
            this.fld_btnAddNode.TabIndex = 18;
            this.fld_btnAddNode.Tag = "";
            this.fld_btnAddNode.Text = ">>";
            this.fld_btnAddNode.Click += new System.EventHandler(this.fld_btnAddNode_Click);
            // 
            // fld_btnRemoveNode
            // 
            this.fld_btnRemoveNode.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_btnRemoveNode.Appearance.Options.UseForeColor = true;
            this.fld_btnRemoveNode.BOSComment = "";
            this.fld_btnRemoveNode.BOSDataMember = "";
            this.fld_btnRemoveNode.BOSDataSource = "";
            this.fld_btnRemoveNode.BOSDescription = null;
            this.fld_btnRemoveNode.BOSError = null;
            this.fld_btnRemoveNode.BOSFieldGroup = "";
            this.fld_btnRemoveNode.BOSFieldRelation = "";
            this.fld_btnRemoveNode.BOSPrivilege = "";
            this.fld_btnRemoveNode.BOSPropertyName = "";
            this.fld_btnRemoveNode.Location = new System.Drawing.Point(349, 172);
            this.fld_btnRemoveNode.Name = "fld_btnRemoveNode";
            this.fld_btnRemoveNode.Screen = null;
            this.fld_btnRemoveNode.Size = new System.Drawing.Size(50, 27);
            this.fld_btnRemoveNode.TabIndex = 19;
            this.fld_btnRemoveNode.Tag = "";
            this.fld_btnRemoveNode.Text = "<<";
            this.fld_btnRemoveNode.Click += new System.EventHandler(this.fld_btnRemoveNode_Click);
            // 
            // fld_Line
            // 
            this.fld_Line.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line.BOSComment = "";
            this.fld_Line.BOSDataMember = "";
            this.fld_Line.BOSDataSource = "";
            this.fld_Line.BOSDescription = null;
            this.fld_Line.BOSError = null;
            this.fld_Line.BOSFieldGroup = "";
            this.fld_Line.BOSFieldRelation = "";
            this.fld_Line.BOSPrivilege = "";
            this.fld_Line.BOSPropertyName = "";
            this.fld_Line.Controls.Add(this.fld_trlHREvaluationStandards);
            this.fld_Line.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fld_Line.Location = new System.Drawing.Point(1, 22);
            this.fld_Line.Name = "fld_Line";
            this.fld_Line.Screen = null;
            this.fld_Line.Size = new System.Drawing.Size(340, 328);
            this.fld_Line.TabIndex = 20;
            this.fld_Line.TabStop = false;
            this.fld_Line.Tag = "";
            this.fld_Line.Text = "Danh sách tiêu chí đánh giá";
            // 
            // fld_trlHREvaluationStandards
            // 
            this.fld_trlHREvaluationStandards.BOSComment = "";
            this.fld_trlHREvaluationStandards.BOSDataMember = "";
            this.fld_trlHREvaluationStandards.BOSDataSource = "HREvaluationStandards";
            this.fld_trlHREvaluationStandards.BOSDescription = null;
            this.fld_trlHREvaluationStandards.BOSDisplayOption = false;
            this.fld_trlHREvaluationStandards.BOSDisplayRoot = false;
            this.fld_trlHREvaluationStandards.BOSError = null;
            this.fld_trlHREvaluationStandards.BOSFieldGroup = "";
            this.fld_trlHREvaluationStandards.BOSFieldRelation = "";
            this.fld_trlHREvaluationStandards.BOSPrivilege = "";
            this.fld_trlHREvaluationStandards.BOSPropertyName = "";
            this.fld_trlHREvaluationStandards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_trlHREvaluationStandards.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_trlHREvaluationStandards.Location = new System.Drawing.Point(3, 17);
            this.fld_trlHREvaluationStandards.Name = "fld_trlHREvaluationStandards";
            this.fld_trlHREvaluationStandards.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.fld_trlHREvaluationStandards.OptionsView.ShowColumns = false;
            this.fld_trlHREvaluationStandards.Screen = null;
            this.fld_trlHREvaluationStandards.Size = new System.Drawing.Size(334, 308);
            this.fld_trlHREvaluationStandards.TabIndex = 14;
            this.fld_trlHREvaluationStandards.Tag = "DC";
            // 
            // fld_Line1
            // 
            this.fld_Line1.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line1.BOSComment = "";
            this.fld_Line1.BOSDataMember = "";
            this.fld_Line1.BOSDataSource = "";
            this.fld_Line1.BOSDescription = null;
            this.fld_Line1.BOSError = null;
            this.fld_Line1.BOSFieldGroup = "";
            this.fld_Line1.BOSFieldRelation = "";
            this.fld_Line1.BOSPrivilege = "";
            this.fld_Line1.BOSPropertyName = "";
            this.fld_Line1.Controls.Add(this.fld_dgcHRTemplateStandards);
            this.fld_Line1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line1.Location = new System.Drawing.Point(405, 22);
            this.fld_Line1.Name = "fld_Line1";
            this.fld_Line1.Screen = null;
            this.fld_Line1.Size = new System.Drawing.Size(260, 328);
            this.fld_Line1.TabIndex = 21;
            this.fld_Line1.TabStop = false;
            this.fld_Line1.Tag = "";
            this.fld_Line1.Text = "Tiêu chí đánh giá được chọn";
            // 
            // fld_dgcHRTemplateStandards
            // 
            this.fld_dgcHRTemplateStandards.AllowDrop = true;
            this.fld_dgcHRTemplateStandards.BOSComment = "";
            this.fld_dgcHRTemplateStandards.BOSDataMember = "";
            this.fld_dgcHRTemplateStandards.BOSDataSource = "HRTemplateStandards";
            this.fld_dgcHRTemplateStandards.BOSDescription = null;
            this.fld_dgcHRTemplateStandards.BOSError = null;
            this.fld_dgcHRTemplateStandards.BOSFieldGroup = "";
            this.fld_dgcHRTemplateStandards.BOSFieldRelation = "";
            this.fld_dgcHRTemplateStandards.BOSGridType = null;
            this.fld_dgcHRTemplateStandards.BOSPrivilege = "";
            this.fld_dgcHRTemplateStandards.BOSPropertyName = "";
            this.fld_dgcHRTemplateStandards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRTemplateStandards.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRTemplateStandards.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcHRTemplateStandards.MainView = this.fld_dgvHRTemplateStandards;
            this.fld_dgcHRTemplateStandards.Name = "fld_dgcHRTemplateStandards";
            this.fld_dgcHRTemplateStandards.Screen = null;
            this.fld_dgcHRTemplateStandards.Size = new System.Drawing.Size(254, 308);
            this.fld_dgcHRTemplateStandards.TabIndex = 13;
            this.fld_dgcHRTemplateStandards.Tag = "DC";
            this.fld_dgcHRTemplateStandards.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRTemplateStandards});
            // 
            // fld_dgvHRTemplateStandards
            // 
            this.fld_dgvHRTemplateStandards.GridControl = this.fld_dgcHRTemplateStandards;
            this.fld_dgvHRTemplateStandards.Name = "fld_dgvHRTemplateStandards";
            this.fld_dgvHRTemplateStandards.PaintStyleName = "Office2003";
            // 
            // fld_Line2
            // 
            this.fld_Line2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fld_Line2.BackColor = System.Drawing.Color.Transparent;
            this.fld_Line2.BOSComment = "";
            this.fld_Line2.BOSDataMember = "";
            this.fld_Line2.BOSDataSource = "";
            this.fld_Line2.BOSDescription = null;
            this.fld_Line2.BOSError = null;
            this.fld_Line2.BOSFieldGroup = "";
            this.fld_Line2.BOSFieldRelation = "";
            this.fld_Line2.BOSPrivilege = "";
            this.fld_Line2.BOSPropertyName = "";
            this.fld_Line2.Controls.Add(this.fld_dgcHRStandardQuestions);
            this.fld_Line2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_Line2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Line2.Location = new System.Drawing.Point(671, 22);
            this.fld_Line2.Name = "fld_Line2";
            this.fld_Line2.Screen = null;
            this.fld_Line2.Size = new System.Drawing.Size(286, 328);
            this.fld_Line2.TabIndex = 22;
            this.fld_Line2.TabStop = false;
            this.fld_Line2.Tag = "";
            this.fld_Line2.Text = "Danh sách câu hỏi tương ứng";
            // 
            // fld_dgcHRStandardQuestions
            // 
            this.fld_dgcHRStandardQuestions.AllowDrop = true;
            this.fld_dgcHRStandardQuestions.BOSComment = "";
            this.fld_dgcHRStandardQuestions.BOSDataMember = "";
            this.fld_dgcHRStandardQuestions.BOSDataSource = "HRStandardQuestions";
            this.fld_dgcHRStandardQuestions.BOSDescription = null;
            this.fld_dgcHRStandardQuestions.BOSError = null;
            this.fld_dgcHRStandardQuestions.BOSFieldGroup = "";
            this.fld_dgcHRStandardQuestions.BOSFieldRelation = "";
            this.fld_dgcHRStandardQuestions.BOSGridType = null;
            this.fld_dgcHRStandardQuestions.BOSPrivilege = "";
            this.fld_dgcHRStandardQuestions.BOSPropertyName = "";
            this.fld_dgcHRStandardQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fld_dgcHRStandardQuestions.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcHRStandardQuestions.Location = new System.Drawing.Point(3, 17);
            this.fld_dgcHRStandardQuestions.MainView = this.fld_dgvHRStandardQuestions;
            this.fld_dgcHRStandardQuestions.Name = "fld_dgcHRStandardQuestions";
            this.fld_dgcHRStandardQuestions.Screen = null;
            this.fld_dgcHRStandardQuestions.Size = new System.Drawing.Size(280, 308);
            this.fld_dgcHRStandardQuestions.TabIndex = 15;
            this.fld_dgcHRStandardQuestions.Tag = "DC";
            this.fld_dgcHRStandardQuestions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvHRStandardQuestions});
            // 
            // fld_dgvHRStandardQuestions
            // 
            this.fld_dgvHRStandardQuestions.GridControl = this.fld_dgcHRStandardQuestions;
            this.fld_dgvHRStandardQuestions.Name = "fld_dgvHRStandardQuestions";
            this.fld_dgvHRStandardQuestions.PaintStyleName = "Office2003";
            // 
            // fld_grcGroupControl
            // 
            this.fld_grcGroupControl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.fld_grcGroupControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_grcGroupControl.Appearance.Options.UseBackColor = true;
            this.fld_grcGroupControl.Appearance.Options.UseForeColor = true;
            this.fld_grcGroupControl.BOSComment = "";
            this.fld_grcGroupControl.BOSDataMember = "";
            this.fld_grcGroupControl.BOSDataSource = "";
            this.fld_grcGroupControl.BOSDescription = null;
            this.fld_grcGroupControl.BOSError = null;
            this.fld_grcGroupControl.BOSFieldGroup = "";
            this.fld_grcGroupControl.BOSFieldRelation = "";
            this.fld_grcGroupControl.BOSPrivilege = "";
            this.fld_grcGroupControl.BOSPropertyName = "";
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel5);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREvaluationTemplateNo1);
            this.fld_grcGroupControl.Controls.Add(this.fld_txtHREvaluationTemplateName1);
            this.fld_grcGroupControl.Controls.Add(this.fld_medHREvaluationTemplateDesc);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel2);
            this.fld_grcGroupControl.Controls.Add(this.fld_lblLabel3);
            this.fld_grcGroupControl.Location = new System.Drawing.Point(7, 9);
            this.fld_grcGroupControl.Name = "fld_grcGroupControl";
            this.fld_grcGroupControl.Screen = null;
            this.fld_grcGroupControl.Size = new System.Drawing.Size(969, 108);
            this.fld_grcGroupControl.TabIndex = 13;
            this.fld_grcGroupControl.Tag = "";
            this.fld_grcGroupControl.Text = "Thông tin chung";
            // 
            // fld_lblLabel5
            // 
            this.fld_lblLabel5.BOSComment = null;
            this.fld_lblLabel5.BOSDataMember = null;
            this.fld_lblLabel5.BOSDataSource = null;
            this.fld_lblLabel5.BOSDescription = null;
            this.fld_lblLabel5.BOSError = null;
            this.fld_lblLabel5.BOSFieldGroup = null;
            this.fld_lblLabel5.BOSFieldRelation = null;
            this.fld_lblLabel5.BOSPrivilege = null;
            this.fld_lblLabel5.BOSPropertyName = null;
            this.fld_lblLabel5.Location = new System.Drawing.Point(254, 31);
            this.fld_lblLabel5.Name = "fld_lblLabel5";
            this.fld_lblLabel5.Screen = null;
            this.fld_lblLabel5.Size = new System.Drawing.Size(64, 13);
            this.fld_lblLabel5.TabIndex = 10;
            this.fld_lblLabel5.Text = "Tên biểu mẫu";
            // 
            // fld_txtHREvaluationTemplateNo1
            // 
            this.fld_txtHREvaluationTemplateNo1.BOSComment = "";
            this.fld_txtHREvaluationTemplateNo1.BOSDataMember = "HREvaluationTemplateNo";
            this.fld_txtHREvaluationTemplateNo1.BOSDataSource = "HREvaluationTemplates";
            this.fld_txtHREvaluationTemplateNo1.BOSDescription = null;
            this.fld_txtHREvaluationTemplateNo1.BOSError = null;
            this.fld_txtHREvaluationTemplateNo1.BOSFieldGroup = "";
            this.fld_txtHREvaluationTemplateNo1.BOSFieldRelation = "";
            this.fld_txtHREvaluationTemplateNo1.BOSPrivilege = "";
            this.fld_txtHREvaluationTemplateNo1.BOSPropertyName = "Text";
            this.fld_txtHREvaluationTemplateNo1.EditValue = "";
            this.fld_txtHREvaluationTemplateNo1.Location = new System.Drawing.Point(77, 28);
            this.fld_txtHREvaluationTemplateNo1.Name = "fld_txtHREvaluationTemplateNo1";
            this.fld_txtHREvaluationTemplateNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREvaluationTemplateNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREvaluationTemplateNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREvaluationTemplateNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREvaluationTemplateNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREvaluationTemplateNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREvaluationTemplateNo1.Screen = null;
            this.fld_txtHREvaluationTemplateNo1.Size = new System.Drawing.Size(125, 20);
            this.fld_txtHREvaluationTemplateNo1.TabIndex = 5;
            this.fld_txtHREvaluationTemplateNo1.Tag = "DC";
            // 
            // fld_txtHREvaluationTemplateName1
            // 
            this.fld_txtHREvaluationTemplateName1.BOSComment = "";
            this.fld_txtHREvaluationTemplateName1.BOSDataMember = "HREvaluationTemplateName";
            this.fld_txtHREvaluationTemplateName1.BOSDataSource = "HREvaluationTemplates";
            this.fld_txtHREvaluationTemplateName1.BOSDescription = null;
            this.fld_txtHREvaluationTemplateName1.BOSError = null;
            this.fld_txtHREvaluationTemplateName1.BOSFieldGroup = "";
            this.fld_txtHREvaluationTemplateName1.BOSFieldRelation = "";
            this.fld_txtHREvaluationTemplateName1.BOSPrivilege = "";
            this.fld_txtHREvaluationTemplateName1.BOSPropertyName = "Text";
            this.fld_txtHREvaluationTemplateName1.EditValue = "";
            this.fld_txtHREvaluationTemplateName1.Location = new System.Drawing.Point(374, 28);
            this.fld_txtHREvaluationTemplateName1.Name = "fld_txtHREvaluationTemplateName1";
            this.fld_txtHREvaluationTemplateName1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtHREvaluationTemplateName1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtHREvaluationTemplateName1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtHREvaluationTemplateName1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtHREvaluationTemplateName1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtHREvaluationTemplateName1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtHREvaluationTemplateName1.Screen = null;
            this.fld_txtHREvaluationTemplateName1.Size = new System.Drawing.Size(355, 20);
            this.fld_txtHREvaluationTemplateName1.TabIndex = 6;
            this.fld_txtHREvaluationTemplateName1.Tag = "DC";
            // 
            // fld_medHREvaluationTemplateDesc
            // 
            this.fld_medHREvaluationTemplateDesc.BOSComment = "";
            this.fld_medHREvaluationTemplateDesc.BOSDataMember = "HREvaluationTemplateDesc";
            this.fld_medHREvaluationTemplateDesc.BOSDataSource = "HREvaluationTemplates";
            this.fld_medHREvaluationTemplateDesc.BOSDescription = null;
            this.fld_medHREvaluationTemplateDesc.BOSError = null;
            this.fld_medHREvaluationTemplateDesc.BOSFieldGroup = "";
            this.fld_medHREvaluationTemplateDesc.BOSFieldRelation = "";
            this.fld_medHREvaluationTemplateDesc.BOSPrivilege = "";
            this.fld_medHREvaluationTemplateDesc.BOSPropertyName = "Text";
            this.fld_medHREvaluationTemplateDesc.EditValue = "";
            this.fld_medHREvaluationTemplateDesc.Location = new System.Drawing.Point(77, 52);
            this.fld_medHREvaluationTemplateDesc.Name = "fld_medHREvaluationTemplateDesc";
            this.fld_medHREvaluationTemplateDesc.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_medHREvaluationTemplateDesc.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_medHREvaluationTemplateDesc.Properties.Appearance.Options.UseBackColor = true;
            this.fld_medHREvaluationTemplateDesc.Properties.Appearance.Options.UseForeColor = true;
            this.fld_medHREvaluationTemplateDesc.Screen = null;
            this.fld_medHREvaluationTemplateDesc.Size = new System.Drawing.Size(652, 50);
            this.fld_medHREvaluationTemplateDesc.TabIndex = 7;
            this.fld_medHREvaluationTemplateDesc.Tag = "DC";
            // 
            // fld_lblLabel2
            // 
            this.fld_lblLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel2.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel2.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel2.BOSComment = "";
            this.fld_lblLabel2.BOSDataMember = "";
            this.fld_lblLabel2.BOSDataSource = "";
            this.fld_lblLabel2.BOSDescription = null;
            this.fld_lblLabel2.BOSError = null;
            this.fld_lblLabel2.BOSFieldGroup = "";
            this.fld_lblLabel2.BOSFieldRelation = "";
            this.fld_lblLabel2.BOSPrivilege = "";
            this.fld_lblLabel2.BOSPropertyName = "";
            this.fld_lblLabel2.Location = new System.Drawing.Point(11, 31);
            this.fld_lblLabel2.Name = "fld_lblLabel2";
            this.fld_lblLabel2.Screen = null;
            this.fld_lblLabel2.Size = new System.Drawing.Size(60, 13);
            this.fld_lblLabel2.TabIndex = 8;
            this.fld_lblLabel2.Tag = "";
            this.fld_lblLabel2.Text = "Mã biểu mẫu";
            // 
            // fld_lblLabel3
            // 
            this.fld_lblLabel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lblLabel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel3.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel3.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel3.BOSComment = "";
            this.fld_lblLabel3.BOSDataMember = "";
            this.fld_lblLabel3.BOSDataSource = "";
            this.fld_lblLabel3.BOSDescription = null;
            this.fld_lblLabel3.BOSError = null;
            this.fld_lblLabel3.BOSFieldGroup = "";
            this.fld_lblLabel3.BOSFieldRelation = "";
            this.fld_lblLabel3.BOSPrivilege = "";
            this.fld_lblLabel3.BOSPropertyName = "";
            this.fld_lblLabel3.Location = new System.Drawing.Point(11, 70);
            this.fld_lblLabel3.Name = "fld_lblLabel3";
            this.fld_lblLabel3.Screen = null;
            this.fld_lblLabel3.Size = new System.Drawing.Size(35, 13);
            this.fld_lblLabel3.TabIndex = 9;
            this.fld_lblLabel3.Tag = "";
            this.fld_lblLabel3.Text = "Diễn giải";
            // 
            // DMHRET100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(984, 686);
            this.Controls.Add(this.fld_grcGroupControl1);
            this.Controls.Add(this.fld_grcGroupControl2);
            this.Controls.Add(this.fld_grcGroupControl);
            this.Name = "DMHRET100";
            this.Text = "Thông tin";
            this.Controls.SetChildIndex(this.fld_grcGroupControl, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl2, 0);
            this.Controls.SetChildIndex(this.fld_grcGroupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl1)).EndInit();
            this.fld_grcGroupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTemplateRanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTemplateRanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl2)).EndInit();
            this.fld_grcGroupControl2.ResumeLayout(false);
            this.fld_Line.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_trlHREvaluationStandards)).EndInit();
            this.fld_Line1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRTemplateStandards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRTemplateStandards)).EndInit();
            this.fld_Line2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcHRStandardQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvHRStandardQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_grcGroupControl)).EndInit();
            this.fld_grcGroupControl.ResumeLayout(false);
            this.fld_grcGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationTemplateNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtHREvaluationTemplateName1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_medHREvaluationTemplateDesc.Properties)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private IContainer components;
        private BOSComponent.BOSGroupControl fld_grcGroupControl1;
        private HRTemplateRanksGridControl fld_dgcHRTemplateRanks;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTemplateRanks;
        private BOSComponent.BOSGroupControl fld_grcGroupControl2;
        private BOSComponent.BOSButton fld_btnAddNode;
        private BOSComponent.BOSButton fld_btnRemoveNode;
        private BOSComponent.BOSLine fld_Line;
        private HREvaluationStandardsTreeListControl fld_trlHREvaluationStandards;
        private BOSComponent.BOSLine fld_Line1;
        private HRTemplateStandardsGridControl fld_dgcHRTemplateStandards;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRTemplateStandards;
        private BOSComponent.BOSLine fld_Line2;
        private HRStandardQuestionsGridControl fld_dgcHRStandardQuestions;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvHRStandardQuestions;
        private BOSComponent.BOSGroupControl fld_grcGroupControl;
        private BOSComponent.BOSLabel fld_lblLabel5;
        private BOSComponent.BOSTextBox fld_txtHREvaluationTemplateNo1;
        private BOSComponent.BOSTextBox fld_txtHREvaluationTemplateName1;
        private BOSComponent.BOSMemoEdit fld_medHREvaluationTemplateDesc;
        private BOSComponent.BOSLabel fld_lblLabel2;
        private BOSComponent.BOSLabel fld_lblLabel3;
	}
}
