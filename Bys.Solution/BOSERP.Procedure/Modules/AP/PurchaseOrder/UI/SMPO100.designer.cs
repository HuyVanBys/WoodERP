using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace BOSERP.Modules.PurchaseOrder.UI
{
    /// <summary>
    /// Summary description for SMPO100
    /// </summary>
    partial class SMPO100
    {
        private BOSComponent.BOSLabel fld_Lablel1;
        private BOSComponent.BOSLabel fld_Lablel2;
        private BOSComponent.BOSLabel fld_Lablel3;
        private BOSComponent.BOSLabel fld_Lablel4;
        private BOSComponent.BOSLabel fld_lblLabel17;
        private BOSSearchResultsGridControl fld_dgcAPPurchaseOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView fld_dgvAPPurchaseOrder;
        private BOSComponent.BOSDateEdit fld_dteSearchFromAPPurchaseOrderDate;
        private BOSComponent.BOSDateEdit fld_dteSearchToAPPurchaseOrderDate;
        private BOSComponent.BOSTextBox fld_txtAPPurchaseOrderNo1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_HREmployeeID;


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
            this.fld_Lablel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel3 = new BOSComponent.BOSLabel(this.components);
            this.fld_Lablel4 = new BOSComponent.BOSLabel(this.components);
            this.fld_lblLabel17 = new BOSComponent.BOSLabel(this.components);
            this.fld_dgcAPPurchaseOrder = new BOSERP.BOSSearchResultsGridControl(this.components);
            this.fld_dgvAPPurchaseOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fld_dteSearchFromAPPurchaseOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_dteSearchToAPPurchaseOrderDate = new BOSComponent.BOSDateEdit(this.components);
            this.fld_txtAPPurchaseOrderNo1 = new BOSComponent.BOSTextBox(this.components);
            this.fld_lkeFK_HREmployeeID = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel1 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeFK_BRBranchID1 = new BOSComponent.BOSLookupEdit(this.components);
            this.bosLabel2 = new BOSComponent.BOSLabel(this.components);
            this.fld_lkeGELocationID = new BOSComponent.BOSLookupEdit(this.components);
            this.accObjectLookupEdit1 = new BOSERP.AccObjectLookupEdit(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseOrderDate.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderNo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGELocationID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accObjectLookupEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fld_Lablel1
            // 
            this.fld_Lablel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel1.Appearance.Options.UseBackColor = true;
            this.fld_Lablel1.Appearance.Options.UseForeColor = true;
            this.fld_Lablel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSDescription = null;
            this.fld_Lablel1.BOSError = null;
            this.fld_Lablel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel1.Location = new System.Drawing.Point(20, 48);
            this.fld_Lablel1.Name = "fld_Lablel1";
            this.fld_Lablel1.Screen = null;
            this.fld_Lablel1.Size = new System.Drawing.Size(61, 13);
            this.fld_Lablel1.TabIndex = 5;
            this.fld_Lablel1.Tag = "SI";
            this.fld_Lablel1.Text = "Mã chứng từ";
            // 
            // fld_Lablel2
            // 
            this.fld_Lablel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel2.Appearance.Options.UseBackColor = true;
            this.fld_Lablel2.Appearance.Options.UseForeColor = true;
            this.fld_Lablel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel2.BOSDescription = null;
            this.fld_Lablel2.BOSError = null;
            this.fld_Lablel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel2.Location = new System.Drawing.Point(19, 74);
            this.fld_Lablel2.Name = "fld_Lablel2";
            this.fld_Lablel2.Screen = null;
            this.fld_Lablel2.Size = new System.Drawing.Size(48, 13);
            this.fld_Lablel2.TabIndex = 6;
            this.fld_Lablel2.Tag = "SI";
            this.fld_Lablel2.Text = "Đối tượng";
            // 
            // fld_Lablel3
            // 
            this.fld_Lablel3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel3.Appearance.Options.UseBackColor = true;
            this.fld_Lablel3.Appearance.Options.UseForeColor = true;
            this.fld_Lablel3.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSDescription = null;
            this.fld_Lablel3.BOSError = null;
            this.fld_Lablel3.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel3.Location = new System.Drawing.Point(20, 100);
            this.fld_Lablel3.Name = "fld_Lablel3";
            this.fld_Lablel3.Screen = null;
            this.fld_Lablel3.Size = new System.Drawing.Size(48, 13);
            this.fld_Lablel3.TabIndex = 7;
            this.fld_Lablel3.Tag = "SI";
            this.fld_Lablel3.Text = "Nhân viên";
            // 
            // fld_Lablel4
            // 
            this.fld_Lablel4.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_Lablel4.Appearance.Options.UseBackColor = true;
            this.fld_Lablel4.Appearance.Options.UseForeColor = true;
            this.fld_Lablel4.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSDescription = null;
            this.fld_Lablel4.BOSError = null;
            this.fld_Lablel4.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_Lablel4.Location = new System.Drawing.Point(20, 179);
            this.fld_Lablel4.Name = "fld_Lablel4";
            this.fld_Lablel4.Screen = null;
            this.fld_Lablel4.Size = new System.Drawing.Size(86, 13);
            this.fld_Lablel4.TabIndex = 8;
            this.fld_Lablel4.Tag = "SI";
            this.fld_Lablel4.Text = "Ngày chứng từ từ";
            // 
            // fld_lblLabel17
            // 
            this.fld_lblLabel17.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lblLabel17.Appearance.Options.UseBackColor = true;
            this.fld_lblLabel17.Appearance.Options.UseForeColor = true;
            this.fld_lblLabel17.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSDescription = null;
            this.fld_lblLabel17.BOSError = null;
            this.fld_lblLabel17.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lblLabel17.Location = new System.Drawing.Point(300, 179);
            this.fld_lblLabel17.Name = "fld_lblLabel17";
            this.fld_lblLabel17.Screen = null;
            this.fld_lblLabel17.Size = new System.Drawing.Size(23, 13);
            this.fld_lblLabel17.TabIndex = 11;
            this.fld_lblLabel17.Tag = "SI";
            this.fld_lblLabel17.Text = "Đến ";
            // 
            // fld_dgcAPPurchaseOrder
            // 
            this.fld_dgcAPPurchaseOrder.AllowDrop = true;
            this.fld_dgcAPPurchaseOrder.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSDataSource = "APPurchaseOrders";
            this.fld_dgcAPPurchaseOrder.BOSDescription = null;
            this.fld_dgcAPPurchaseOrder.BOSError = null;
            this.fld_dgcAPPurchaseOrder.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dgcAPPurchaseOrder.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.fld_dgcAPPurchaseOrder.Location = new System.Drawing.Point(19, 254);
            this.fld_dgcAPPurchaseOrder.MainView = this.fld_dgvAPPurchaseOrder;
            this.fld_dgcAPPurchaseOrder.Name = "fld_dgcAPPurchaseOrder";
            this.fld_dgcAPPurchaseOrder.Screen = null;
            this.fld_dgcAPPurchaseOrder.Size = new System.Drawing.Size(400, 200);
            this.fld_dgcAPPurchaseOrder.TabIndex = 7;
            this.fld_dgcAPPurchaseOrder.Tag = "SR";
            this.fld_dgcAPPurchaseOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.fld_dgvAPPurchaseOrder});
            // 
            // fld_dgvAPPurchaseOrder
            // 
            this.fld_dgvAPPurchaseOrder.GridControl = this.fld_dgcAPPurchaseOrder;
            this.fld_dgvAPPurchaseOrder.Name = "fld_dgvAPPurchaseOrder";
            this.fld_dgvAPPurchaseOrder.PaintStyleName = "Office2003";
            // 
            // fld_dteSearchFromAPPurchaseOrderDate
            // 
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSDataMember = "PurchaseOrderDateFrom";
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSDataSource = "APPurchaseOrders";
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSDescription = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSError = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchFromAPPurchaseOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchFromAPPurchaseOrderDate.EditValue = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.Location = new System.Drawing.Point(135, 176);
            this.fld_dteSearchFromAPPurchaseOrderDate.Name = "fld_dteSearchFromAPPurchaseOrderDate";
            this.fld_dteSearchFromAPPurchaseOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchFromAPPurchaseOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchFromAPPurchaseOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchFromAPPurchaseOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchFromAPPurchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchFromAPPurchaseOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchFromAPPurchaseOrderDate.Screen = null;
            this.fld_dteSearchFromAPPurchaseOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchFromAPPurchaseOrderDate.TabIndex = 5;
            this.fld_dteSearchFromAPPurchaseOrderDate.Tag = "SC";
            // 
            // fld_dteSearchToAPPurchaseOrderDate
            // 
            this.fld_dteSearchToAPPurchaseOrderDate.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSDataMember = "PurchaseOrderDateTo";
            this.fld_dteSearchToAPPurchaseOrderDate.BOSDataSource = "APPurchaseOrders";
            this.fld_dteSearchToAPPurchaseOrderDate.BOSDescription = null;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSError = null;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_dteSearchToAPPurchaseOrderDate.BOSPropertyName = "EditValue";
            this.fld_dteSearchToAPPurchaseOrderDate.EditValue = null;
            this.fld_dteSearchToAPPurchaseOrderDate.Location = new System.Drawing.Point(339, 176);
            this.fld_dteSearchToAPPurchaseOrderDate.Name = "fld_dteSearchToAPPurchaseOrderDate";
            this.fld_dteSearchToAPPurchaseOrderDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_dteSearchToAPPurchaseOrderDate.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_dteSearchToAPPurchaseOrderDate.Properties.Appearance.Options.UseBackColor = true;
            this.fld_dteSearchToAPPurchaseOrderDate.Properties.Appearance.Options.UseForeColor = true;
            this.fld_dteSearchToAPPurchaseOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_dteSearchToAPPurchaseOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fld_dteSearchToAPPurchaseOrderDate.Screen = null;
            this.fld_dteSearchToAPPurchaseOrderDate.Size = new System.Drawing.Size(150, 20);
            this.fld_dteSearchToAPPurchaseOrderDate.TabIndex = 6;
            this.fld_dteSearchToAPPurchaseOrderDate.Tag = "SC";
            // 
            // fld_txtAPPurchaseOrderNo1
            // 
            this.fld_txtAPPurchaseOrderNo1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo1.BOSDataMember = "APPurchaseOrderNo";
            this.fld_txtAPPurchaseOrderNo1.BOSDataSource = "APPurchaseOrders";
            this.fld_txtAPPurchaseOrderNo1.BOSDescription = null;
            this.fld_txtAPPurchaseOrderNo1.BOSError = null;
            this.fld_txtAPPurchaseOrderNo1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo1.BOSPropertyName = "Text";
            this.fld_txtAPPurchaseOrderNo1.EditValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_txtAPPurchaseOrderNo1.Location = new System.Drawing.Point(135, 45);
            this.fld_txtAPPurchaseOrderNo1.Name = "fld_txtAPPurchaseOrderNo1";
            this.fld_txtAPPurchaseOrderNo1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_txtAPPurchaseOrderNo1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_txtAPPurchaseOrderNo1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_txtAPPurchaseOrderNo1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_txtAPPurchaseOrderNo1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.fld_txtAPPurchaseOrderNo1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fld_txtAPPurchaseOrderNo1.Screen = null;
            this.fld_txtAPPurchaseOrderNo1.Size = new System.Drawing.Size(150, 20);
            this.fld_txtAPPurchaseOrderNo1.TabIndex = 0;
            this.fld_txtAPPurchaseOrderNo1.Tag = "SC";
            // 
            // fld_lkeFK_HREmployeeID
            // 
            this.fld_lkeFK_HREmployeeID.BOSAllowAddNew = false;
            this.fld_lkeFK_HREmployeeID.BOSAllowDummy = true;
            this.fld_lkeFK_HREmployeeID.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSDataMember = "FK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_HREmployeeID.BOSDescription = null;
            this.fld_lkeFK_HREmployeeID.BOSError = null;
            this.fld_lkeFK_HREmployeeID.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSPropertyName = "EditValue";
            this.fld_lkeFK_HREmployeeID.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.CurrentDisplayText = null;
            this.fld_lkeFK_HREmployeeID.Location = new System.Drawing.Point(135, 97);
            this.fld_lkeFK_HREmployeeID.Name = "fld_lkeFK_HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_HREmployeeID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_HREmployeeID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeNo", "No", 20, DevExpress.Utils.FormatType.Numeric, global::Localization.ReportLocalizedResources.tutu, true, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HREmployeeName", "Name")});
            this.fld_lkeFK_HREmployeeID.Properties.DisplayMember = "HREmployeeName";
            this.fld_lkeFK_HREmployeeID.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_HREmployeeID.Properties.PopupWidth = 40;
            this.fld_lkeFK_HREmployeeID.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_HREmployeeID.Properties.ValueMember = "HREmployeeID";
            this.fld_lkeFK_HREmployeeID.Screen = null;
            this.fld_lkeFK_HREmployeeID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_HREmployeeID.TabIndex = 2;
            this.fld_lkeFK_HREmployeeID.Tag = "SC";
            // 
            // bosLabel1
            // 
            this.bosLabel1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel1.Appearance.Options.UseBackColor = true;
            this.bosLabel1.Appearance.Options.UseForeColor = true;
            this.bosLabel1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSDescription = null;
            this.bosLabel1.BOSError = null;
            this.bosLabel1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel1.Location = new System.Drawing.Point(19, 152);
            this.bosLabel1.Name = "bosLabel1";
            this.bosLabel1.Screen = null;
            this.bosLabel1.Size = new System.Drawing.Size(48, 13);
            this.bosLabel1.TabIndex = 14;
            this.bosLabel1.Tag = "SI";
            this.bosLabel1.Text = "Chi nhánh";
            // 
            // fld_lkeFK_BRBranchID1
            // 
            this.fld_lkeFK_BRBranchID1.BOSAllowAddNew = false;
            this.fld_lkeFK_BRBranchID1.BOSAllowDummy = true;
            this.fld_lkeFK_BRBranchID1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID1.BOSDataMember = "FK_BRBranchID";
            this.fld_lkeFK_BRBranchID1.BOSDataSource = "APPurchaseOrders";
            this.fld_lkeFK_BRBranchID1.BOSDescription = null;
            this.fld_lkeFK_BRBranchID1.BOSError = null;
            this.fld_lkeFK_BRBranchID1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID1.BOSPropertyName = "EditValue";
            this.fld_lkeFK_BRBranchID1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID1.CurrentDisplayText = null;
            this.fld_lkeFK_BRBranchID1.Location = new System.Drawing.Point(135, 149);
            this.fld_lkeFK_BRBranchID1.Name = "fld_lkeFK_BRBranchID1";
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseBackColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Appearance.Options.UseForeColor = true;
            this.fld_lkeFK_BRBranchID1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeFK_BRBranchID1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchNo", "Mã chi nhánh"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BRBranchName", "Tên chi nhánh")});
            this.fld_lkeFK_BRBranchID1.Properties.DisplayMember = "BRBranchName";
            this.fld_lkeFK_BRBranchID1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.fld_lkeFK_BRBranchID1.Properties.PopupWidth = 40;
            this.fld_lkeFK_BRBranchID1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.fld_lkeFK_BRBranchID1.Properties.ValueMember = "BRBranchID";
            this.fld_lkeFK_BRBranchID1.Screen = null;
            this.fld_lkeFK_BRBranchID1.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeFK_BRBranchID1.TabIndex = 4;
            this.fld_lkeFK_BRBranchID1.Tag = "SC";
            // 
            // bosLabel2
            // 
            this.bosLabel2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bosLabel2.Appearance.Options.UseBackColor = true;
            this.bosLabel2.Appearance.Options.UseForeColor = true;
            this.bosLabel2.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataMember = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDataSource = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSDescription = null;
            this.bosLabel2.BOSError = null;
            this.bosLabel2.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.BOSPropertyName = global::Localization.ReportLocalizedResources.tutu;
            this.bosLabel2.Location = new System.Drawing.Point(20, 125);
            this.bosLabel2.Name = "bosLabel2";
            this.bosLabel2.Screen = null;
            this.bosLabel2.Size = new System.Drawing.Size(21, 13);
            this.bosLabel2.TabIndex = 14;
            this.bosLabel2.Tag = "SI";
            this.bosLabel2.Text = "Vị trí";
            // 
            // fld_lkeGELocationID
            // 
            this.fld_lkeGELocationID.BOSAllowAddNew = false;
            this.fld_lkeGELocationID.BOSAllowDummy = true;
            this.fld_lkeGELocationID.BOSComment = null;
            this.fld_lkeGELocationID.BOSDataMember = "GELocationID";
            this.fld_lkeGELocationID.BOSDataSource = "GELocations";
            this.fld_lkeGELocationID.BOSDescription = null;
            this.fld_lkeGELocationID.BOSError = null;
            this.fld_lkeGELocationID.BOSFieldGroup = null;
            this.fld_lkeGELocationID.BOSFieldParent = null;
            this.fld_lkeGELocationID.BOSFieldRelation = null;
            this.fld_lkeGELocationID.BOSPrivilege = null;
            this.fld_lkeGELocationID.BOSPropertyName = "EditValue";
            this.fld_lkeGELocationID.BOSSelectType = null;
            this.fld_lkeGELocationID.BOSSelectTypeValue = null;
            this.fld_lkeGELocationID.CurrentDisplayText = null;
            this.fld_lkeGELocationID.Location = new System.Drawing.Point(135, 123);
            this.fld_lkeGELocationID.MenuManager = this.screenToolbar;
            this.fld_lkeGELocationID.Name = "fld_lkeGELocationID";
            this.fld_lkeGELocationID.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fld_lkeGELocationID.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GELocationName", "Vị trí")});
            this.fld_lkeGELocationID.Properties.DisplayMember = "GELocationName";
            this.fld_lkeGELocationID.Properties.ValueMember = "GELocationID";
            this.fld_lkeGELocationID.Screen = null;
            this.fld_lkeGELocationID.Size = new System.Drawing.Size(150, 20);
            this.fld_lkeGELocationID.TabIndex = 3;
            this.fld_lkeGELocationID.Tag = "SC";
            // 
            // accObjectLookupEdit1
            // 
            this.accObjectLookupEdit1.BOSAllowAddNew = false;
            this.accObjectLookupEdit1.BOSAllowDummy = true;
            this.accObjectLookupEdit1.BOSComment = global::Localization.ReportLocalizedResources.tutu;
            this.accObjectLookupEdit1.BOSDataMember = "ACAssObjectAccessKey";
            this.accObjectLookupEdit1.BOSDataSource = "APPurchaseOrders";
            this.accObjectLookupEdit1.BOSDescription = null;
            this.accObjectLookupEdit1.BOSError = null;
            this.accObjectLookupEdit1.BOSFieldGroup = global::Localization.ReportLocalizedResources.tutu;
            this.accObjectLookupEdit1.BOSFieldParent = global::Localization.ReportLocalizedResources.tutu;
            this.accObjectLookupEdit1.BOSFieldRelation = global::Localization.ReportLocalizedResources.tutu;
            this.accObjectLookupEdit1.BOSPrivilege = global::Localization.ReportLocalizedResources.tutu;
            this.accObjectLookupEdit1.BOSPropertyName = "EditValue";
            this.accObjectLookupEdit1.BOSSelectType = global::Localization.ReportLocalizedResources.tutu;
            this.accObjectLookupEdit1.BOSSelectTypeValue = global::Localization.ReportLocalizedResources.tutu;
            this.accObjectLookupEdit1.CurrentDisplayText = null;
            this.accObjectLookupEdit1.Location = new System.Drawing.Point(135, 71);
            this.accObjectLookupEdit1.Name = "accObjectLookupEdit1";
            this.accObjectLookupEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.accObjectLookupEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.accObjectLookupEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.accObjectLookupEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.accObjectLookupEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.accObjectLookupEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectNo", "Mã đối tượng"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ACObjectName", "Tên đối tượng")});
            this.accObjectLookupEdit1.Properties.DisplayMember = "ACObjectName";
            this.accObjectLookupEdit1.Properties.NullText = global::Localization.ReportLocalizedResources.tutu;
            this.accObjectLookupEdit1.Properties.PopupWidth = 40;
            this.accObjectLookupEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.accObjectLookupEdit1.Properties.ValueMember = "ACObjectID";
            this.accObjectLookupEdit1.Screen = null;
            this.accObjectLookupEdit1.Size = new System.Drawing.Size(150, 20);
            this.accObjectLookupEdit1.TabIndex = 1;
            this.accObjectLookupEdit1.Tag = "SC";
            // 
            // SMPO100
            // 
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Appearance.Options.UseForeColor = true;
            this.ClientSize = new System.Drawing.Size(862, 567);
            this.Controls.Add(this.accObjectLookupEdit1);
            this.Controls.Add(this.fld_lkeGELocationID);
            this.Controls.Add(this.bosLabel2);
            this.Controls.Add(this.bosLabel1);
            this.Controls.Add(this.fld_lkeFK_BRBranchID1);
            this.Controls.Add(this.fld_Lablel1);
            this.Controls.Add(this.fld_Lablel2);
            this.Controls.Add(this.fld_Lablel3);
            this.Controls.Add(this.fld_Lablel4);
            this.Controls.Add(this.fld_lblLabel17);
            this.Controls.Add(this.fld_dgcAPPurchaseOrder);
            this.Controls.Add(this.fld_dteSearchFromAPPurchaseOrderDate);
            this.Controls.Add(this.fld_dteSearchToAPPurchaseOrderDate);
            this.Controls.Add(this.fld_txtAPPurchaseOrderNo1);
            this.Controls.Add(this.fld_lkeFK_HREmployeeID);
            this.Name = "SMPO100";
            this.Text = "Tiềm kiếm";
            this.Controls.SetChildIndex(this.fld_lkeFK_HREmployeeID, 0);
            this.Controls.SetChildIndex(this.fld_txtAPPurchaseOrderNo1, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchToAPPurchaseOrderDate, 0);
            this.Controls.SetChildIndex(this.fld_dteSearchFromAPPurchaseOrderDate, 0);
            this.Controls.SetChildIndex(this.fld_dgcAPPurchaseOrder, 0);
            this.Controls.SetChildIndex(this.fld_lblLabel17, 0);
            this.Controls.SetChildIndex(this.fld_Lablel4, 0);
            this.Controls.SetChildIndex(this.fld_Lablel3, 0);
            this.Controls.SetChildIndex(this.fld_Lablel2, 0);
            this.Controls.SetChildIndex(this.fld_Lablel1, 0);
            this.Controls.SetChildIndex(this.fld_lkeFK_BRBranchID1, 0);
            this.Controls.SetChildIndex(this.bosLabel1, 0);
            this.Controls.SetChildIndex(this.bosLabel2, 0);
            this.Controls.SetChildIndex(this.fld_lkeGELocationID, 0);
            this.Controls.SetChildIndex(this.accObjectLookupEdit1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgcAPPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dgvAPPurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchFromAPPurchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseOrderDate.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_dteSearchToAPPurchaseOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_txtAPPurchaseOrderNo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_HREmployeeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeFK_BRBranchID1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fld_lkeGELocationID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accObjectLookupEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private IContainer components;
        private BOSComponent.BOSLabel bosLabel1;
        private BOSComponent.BOSLookupEdit fld_lkeFK_BRBranchID1;
        private BOSComponent.BOSLabel bosLabel2;
        private BOSComponent.BOSLookupEdit fld_lkeGELocationID;
        private AccObjectLookupEdit accObjectLookupEdit1;
    }
}
