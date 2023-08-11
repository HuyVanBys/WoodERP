using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Data;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using DevExpress.XtraGrid;
using DevExpress.Data;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using BOSCommon;
using DevExpress.XtraGrid.Views.Base;
using System.Globalization;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using BOSLib;
using System.Reflection;

using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class BatchProductItemsTreeListControl : BOSTreeListControl
    {
        // The variables that will store summary values. 
        #region  properties
        #endregion

        
        public override void InitializeControl()
        {
            base.InitializeControl();
            this.ExpandAll();
            this.OptionsBehavior.DragNodes = true;
            this.OptionsView.AutoWidth = false;
            this.HorzScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Auto;
            this.OptionsView.ShowSummaryFooter = true;
            this.BOSDisplayRoot = true;
            this.BOSDisplayOption = true;
            this.ForceInitialize();
            this.BestFitColumns();
        
          
            
        }

      

        public override void InitTreeListColumns(string strTableName)
        {
            base.InitTreeListColumns(strTableName);
            Columns.Clear();
            AddTreeListColumns(0, "MMBatchProductItemProductNo");
            AddTreeListColumns(1, "MMBatchProductItemProductName");
            AddTreeListColumns(1, "MMBatchProductItemProductDesc");
            AddTreeListColumns(1, "MMBatchProductItemProductSerial");
            AddTreeListColumns(1, "MMBatchProductItemDesc");
            AddTreeListColumns(1, "MMBatchProductItemProductQty");
            AddTreeListColumns(1, "FK_MMProductionNormID");
            
            
            

            this.OptionsView.ShowSummaryFooter = true;
            this.OptionsBehavior.ImmediateEditor = true;
        }
        public void AddTreeListColumns(int visibleIndex, string fieldName)
        {
            this.BeginUpdate();
            TreeListColumn column = Columns.Add();
            column.Visible = true;
            column.OptionsColumn.AllowEdit = false;
            column.OptionsColumn.ReadOnly = true;
            this.OptionsView.AutoWidth = false;

            if (fieldName == "MMBatchProductItemProductNo")
            {
                column.Caption = "Mã đối tượng";
            }

            //Get Caption
            AAColumnAliasController objAAColumnAliasController = new AAColumnAliasController();
            DataSet dsColumns = objAAColumnAliasController.GetAAColumnAliasByTableName(TableName.MMBatchProductItemsTableName);
            if (dsColumns.Tables.Count > 0)
            {
                foreach (DataRow rowColumn in dsColumns.Tables[0].Rows)
                {
                    AAColumnAliasInfo objAAColumnAliasInfo = (AAColumnAliasInfo)objAAColumnAliasController.GetObjectFromDataRow(rowColumn);
                    if (objAAColumnAliasInfo != null)
                    {
                        if (fieldName == objAAColumnAliasInfo.AAColumnAliasName)
                        {
                            column.Caption = objAAColumnAliasInfo.AAColumnAliasCaption;
                        }
                    }
                }
            }

            this.EndUpdate();
            this.Update();
        }
       

     
    }
}
