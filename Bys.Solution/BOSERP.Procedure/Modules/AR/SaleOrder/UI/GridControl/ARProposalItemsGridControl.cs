using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using DevExpress.XtraGrid.Views.Base;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.SaleOrder
{
    public partial class ARProposalItemsGridControl : ItemGridControl
    {
        private enum ProposalItemColumnName
        {
            ARProposalItemProductName,
            ARProposalItemProductDesc,
            ARProposalItemProductNo,
            ARProposalItemProductNoOfOldSys,
            ARProposalItemProductCustomerNumber,
            FK_ICMeasureUnitID,
            ARProposalItemProductQty,
            ARProposalItemProductUnitPrice,
            ARProposalItemProductUnitPrice2,
            ARProposalItemTotalAmount2,
            ARProposalItemPrice,
            ARProposalItemDiscountFix,
            ARProposalItemDiscountAmount,
            ARProposalItemProductTaxPercent,
            ARProposalItemTaxAmount,
            ARProposalItemTotalAmount
        }

        public void InvalidateDataSource(List<ARProposalItemsInfo> dataSource)
        {
            BindingSource bds = new BindingSource();
            bds.DataSource = dataSource;
            DataSource = bds;
            RefreshDataSource();
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Mã báo giá";
            column.FieldName = "ARProposalNo";
            column.OptionsColumn.AllowEdit = false;
            column.Group();
            column.Visible = true;
            column.VisibleIndex = 0;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đối tượng";
            column.FieldName = "ACObjectName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 1;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Nhân viên";
            column.FieldName = "HREmployeeName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 2;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày bắt đầu";
            column.FieldName = "ARProposalDeliveryDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 3;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày hết hạn";
            column.FieldName = "ARProposalValidateDate";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 4;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Chi nhánh";
            column.FieldName = "BRBranchName";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 5;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Tình trạng";
            column.FieldName = "ARProposalStatus";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            column.VisibleIndex = 6;
            gridView.Columns.Add(column);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductNo.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 7;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductName.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 8;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductDesc.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 9;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductCustomerNumber.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 10;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductNoOfOldSys.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 11;
                }                
                else if (gridView.Columns[i].Name == ProposalItemColumnName.FK_ICMeasureUnitID.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 12;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductQty.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 13;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductUnitPrice.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 14;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductUnitPrice2.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 15;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemTotalAmount2.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 16;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemPrice.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 17;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemDiscountFix.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 18;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemDiscountAmount.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 19;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemProductTaxPercent.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 20;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemTaxAmount.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 21;
                }
                else if (gridView.Columns[i].Name == ProposalItemColumnName.ARProposalItemTotalAmount.ToString())
                {
                    gridView.Columns[i].OptionsColumn.AllowEdit = false;
                    gridView.Columns[i].Visible = true;
                    gridView.Columns[i].VisibleIndex = 22;
                } 
            }
            gridView.ExpandAllGroups();
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICMeasureUnitID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("ICMeasureUnits", "ICMeasureUnitID", int.Parse(e.Value.ToString()), "ICMeasureUnitName");
                }
            }
            else if (e.Column.FieldName == "FK_HREmployeeID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("HREmployees", "HREmployeeID", int.Parse(e.Value.ToString()), "HREmployeeName");
                }
            }
            else if (e.Column.FieldName == "FK_BRBranchID")
            {
                if (e.Value != null)
                {
                    e.DisplayText = BOSApp.GetDisplayTextFromCatche("BRBranchs", "BRBranchID", int.Parse(e.Value.ToString()), "BRBranchName");
                }
            }
        }
    }
}
