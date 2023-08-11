using BOSComponent;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP.Modules.Transfer
{
    public partial class ICTransferProposaltemsGridControl : BOSGridControl
    {

        public void InvalidateDataSource(List<ICTransferProposalItemsInfo> dataSource)
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
            column.FieldName = "ICTransferProposalNo";
            column.Caption = "Mã đề nghị";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.Caption = "Ngày đề nghị";
            column.FieldName = "ICTransferProposalDate";
            column.OptionsColumn.AllowEdit = false;
            gridView.Columns.Add(column);
        }

        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            DevExpress.XtraGrid.Views.Grid.GridView gridView = base.InitializeGridView();
            gridView.CustomColumnDisplayText += new CustomColumnDisplayTextEventHandler(gridView_CustomColumnDisplayText);
            GridColumn column = gridView.Columns["ICTransferProposalNo"];
            if (column != null)
            {
                column.Group();
            }
            return gridView;
        }

        private void gridView_CustomColumnDisplayText(object sender, CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "FK_ICProductAttributeColorID" || e.Column.FieldName == "FK_ICProductAttributeWoodTypeID")
            {
                if (e.Value != null)
                {
                    int attributeID = int.Parse(e.Value.ToString());
                    ICProductAttributesController objProductAttributesController = new ICProductAttributesController();
                    ICProductAttributesInfo objProductAttributesInfo = (ICProductAttributesInfo)objProductAttributesController.GetObjectByID(attributeID);
                    if (objProductAttributesInfo != null)
                        e.DisplayText = objProductAttributesInfo.ICProductAttributeNo;
                    else
                        e.DisplayText = "";
                }
                else
                    e.DisplayText = "";
            }

            if (e.Column.FieldName == "ICTransferProposalItemProductColorAttribute" || e.Column.FieldName == "ICTransferProposalItemProductWoodAttribute")
            {
                if (e.Value != null)
                {
                    e.DisplayText = ((TransferModule)Screen.Module).GetAttributeText(e.Value.ToString());
                }
                else
                    e.DisplayText = string.Empty;
            }
        }
    }
}
