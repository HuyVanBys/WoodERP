using BOSCommon;
using System.Linq;
using BOSComponent;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;

namespace BOSERP.Modules.EInvoiceConfig
{
    public partial class BKAV_EInvoiceConfigsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            EInvoiceConfigEntities entity = (EInvoiceConfigEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.BKAVEInvoiceConfigsList;
            this.DataSource = bds;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            foreach (GridColumn column in gridView.Columns)
                column.OptionsColumn.AllowEdit = true;
            return gridView;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            GridColumn newColumn = new GridColumn();
            newColumn.Caption = "Đơn vị thuế";
            newColumn.FieldName = "FK_ACTaxUnitID";
            newColumn.OptionsColumn.AllowEdit = true;
            newColumn.Visible = true;
            newColumn.VisibleIndex = 1;
            ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
            RepositoryItemLookUpEdit repositoryItemLookUpEdit = new RepositoryItemLookUpEdit();
            repositoryItemLookUpEdit.DataSource = objTaxUnitsController.GetAllACTaxUnits();
            repositoryItemLookUpEdit.DisplayMember = "ACTaxUnitName";
            repositoryItemLookUpEdit.ValueMember = "ACTaxUnitID";
            repositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            repositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoFilter;
            repositoryItemLookUpEdit.NullText = string.Empty;
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACTaxUnitNo", "Mã đơn vị thuế"));
            repositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo("ACTaxUnitName", "Tên đơn vị thuế"));
            repositoryItemLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            repositoryItemLookUpEdit.QueryPopUp += new System.ComponentModel.CancelEventHandler(repositoryItemLookUpEditTaxUnit_QueryPopUp);
            newColumn.ColumnEdit = repositoryItemLookUpEdit;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "Link webservice";
            newColumn.FieldName = "ACEInvoiceConfigLinkWS";
            newColumn.OptionsColumn.AllowEdit = true;
            newColumn.Visible = true;
            newColumn.VisibleIndex = 2;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "BkavPartnerGUID";
            newColumn.FieldName = "ACEInvoiceConfigBkavPartnerGUID";
            newColumn.OptionsColumn.AllowEdit = true;
            newColumn.Visible = true;
            newColumn.VisibleIndex = 3;
            gridView.Columns.Add(newColumn);

            newColumn = new GridColumn();
            newColumn.Caption = "BkavPartnerToken";
            newColumn.FieldName = "ACEInvoiceConfigBkavPartnerToken";
            newColumn.OptionsColumn.AllowEdit = true;
            newColumn.Visible = true;
            newColumn.VisibleIndex = 4;
            gridView.Columns.Add(newColumn);
        }

        protected void repositoryItemLookUpEditTaxUnit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            LookUpEdit lke = (LookUpEdit)sender;
            ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
            List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
            lke.Properties.DataSource = listTaxUnitsInfo;
        }

        protected override void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            base.GridView_KeyUp(sender, e);

            GridView gridView = (GridView)sender;
            if (e.KeyCode == Keys.Delete)
            {
                if (gridView.FocusedRowHandle >= 0)
                {
                    ((EInvoiceConfigModule)Screen.Module).RemoveSelectedEInvoiceConfigsListBKAV();
                }
            }
        }

        protected override void GridView_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            base.GridView_InitNewRow(sender, e);

            GridView gridView = (GridView)sender;
            ACEInvoiceConfigsInfo objEInvoiceConfigsInfo = (ACEInvoiceConfigsInfo)gridView.GetRow(gridView.FocusedRowHandle);
            if(objEInvoiceConfigsInfo != null)
            {
                objEInvoiceConfigsInfo.ACEInvoiceConfigPartnerType = EInvoiceConfigPartnerType.BKAV.ToString();
                ACTaxUnitsController objTaxUnitsController = new ACTaxUnitsController();
                List<ACTaxUnitsInfo> listTaxUnitsInfo = objTaxUnitsController.GetAllACTaxUnits();
                if(listTaxUnitsInfo != null && listTaxUnitsInfo.Count == 1)
                {
                    objEInvoiceConfigsInfo.FK_ACTaxUnitID = listTaxUnitsInfo.FirstOrDefault().ACTaxUnitID;
                }
            }
        }
    }
}
