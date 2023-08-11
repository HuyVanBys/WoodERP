using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using BOSComponent;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using Localization;
using DevExpress.XtraEditors.Repository;

namespace BOSERP.Modules.LeaveApplication
{
    public partial class HRLeaveApplicationsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            LeaveApplicationEntities entity = (LeaveApplicationEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.LeaveApplicationList;
            DataSource = bds;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.Caption = "Từ giờ";
            column.FieldName = "HRLeaveApplicationFromHour";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Đến giờ";
            column.FieldName = "HRLeaveApplicationToHour";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }
        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridColumn column = new GridColumn();
            RepositoryItemDateEdit repositoryItemDateEdit = new RepositoryItemDateEdit();
            repositoryItemDateEdit.AutoHeight = false;
            repositoryItemDateEdit.DisplayFormat.FormatString = "HH:mm:ss";
            repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            repositoryItemDateEdit.Mask.EditMask = "HH:mm:ss";
            repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            repositoryItemDateEdit.Name = "rpDate";

            column = gridView.Columns["HRLeaveApplicationFromHour"];
            if (column != null)
            {
                column.ColumnEdit = repositoryItemDateEdit;
            }

            column = gridView.Columns["HRLeaveApplicationToHour"];
            if (column != null)
            {
                column.ColumnEdit = repositoryItemDateEdit;
            }
            
            return gridView;
        }
    }
}
