using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using BOSComponent;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using Localization;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.AdvanceRefundDirect
{
    public partial class DocumentEntryGridControl : BaseDocumentEntryGridControl
    {
        public override void InitGridControlDataSource()
        {
            AdvanceRefundDirectEntities entity = (AdvanceRefundDirectEntities)(((BaseModuleERP)Screen.Module).CurrentModuleEntity);
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.AdvanceDocumentEntryList;
            DataSource = bds;
        }

        protected override void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            GridView gridView = (GridView)sender;
            AdvanceRefundDirectEntities entity = (AdvanceRefundDirectEntities)(this.Screen.Module as BaseModuleERP).CurrentModuleEntity;
            if (entity.AdvanceDocumentEntryList.CurrentIndex >= 0)
            {
                ACDocumentEntrysInfo item = entity.AdvanceDocumentEntryList[entity.AdvanceDocumentEntryList.CurrentIndex];

                if (e.Column.FieldName == "FK_ACUnfinishedConstructionCostID")
                {
                    if (gridView.FocusedRowHandle >= 0)
                    {
                        item = (ACDocumentEntrysInfo)gridView.GetRow(gridView.FocusedRowHandle);
                        ((AdvanceRefundDirectModule)Screen.Module).UpdateAccountDebitDocumentEntrys(item);
                    }
                }
            }
        }
    }
}
