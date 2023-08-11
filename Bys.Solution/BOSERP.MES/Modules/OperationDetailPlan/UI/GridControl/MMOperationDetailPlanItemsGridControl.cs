using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BOSComponent;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using System.Data;
using BOSLib;
using BOSCommon;
using Localization;
using DevExpress.XtraGrid;
using System.Drawing;
using DevExpress.Utils;

namespace BOSERP.Modules.OperationDetailPlan
{
    public class MMOperationDetailPlanItemsGridControl : BOSGridControl
    {
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            gridView.ExpandAllGroups();        
            return gridView;
        }

        void gridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_MMWorkShopID")
            {
                if (e.Value != null)
                {
                    int workShopID = int.Parse(e.Value.ToString());
                    MMWorkShopsController objWorkShopsController = new MMWorkShopsController();
                    String workShopName = objWorkShopsController.GetObjectNameByID(workShopID);
                    if (workShopName != null && workShopName != "")
                    {
                        e.DisplayText = workShopName;
                    }
                }
            }
            if (e.Column.FieldName == "FK_MMLineID")
            {
                if (e.Value != null)
                {
                    int lineID = int.Parse(e.Value.ToString());
                    MMLinesController objLinesController = new MMLinesController();
                    String lineName = objLinesController.GetObjectNameByID(lineID);
                    if (lineName != null && lineName != "")
                    {
                        e.DisplayText = lineName;
                    }
                }
            }
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            gridView.Columns.Clear();
        }

        void gridView_EndGrouping(object sender, EventArgs e)
        {
            GridView gridView = (GridView)sender;
            gridView.ExpandAllGroups();
        }
        private void GridView_DoubleClick(object sender, EventArgs e)
        {
            ShowInventory();
        }
        /// <summary>
        /// Show inventory details of the current item
        /// </summary>
        private void ShowInventory()
        {
            GridView gridView = (GridView)MainView;
            if (gridView.FocusedRowHandle >= 0)
            {
                DataRow item = gridView.GetDataRow(gridView.FocusedRowHandle);
                if (item != null)
                {
                    int productID = 0;
                    if (int.TryParse(item["FK_ICProductID"].ToString(), out productID))
                    {
                        string desc = "";
                        if (productID > 0)
                        {
                            ((BaseTransactionModule)Screen.Module).ShowInventory(productID, desc, 0, 0);
                        }
                    }
                }
            }
        }

        private void SetFormat(string col, string f, GridView gridView)
        {
            if (gridView.Columns[col] != null)
            {
                gridView.Columns[col].DisplayFormat.FormatType = FormatType.Numeric;
                gridView.Columns[col].DisplayFormat.FormatString = "{0:" + f + "}";
            }
        }
    }
}
