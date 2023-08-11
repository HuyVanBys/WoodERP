using BOSComponent;
using BOSLib;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using System.Windows.Forms;


namespace BOSERP.Modules.Home
{
    public partial class ARDeliveryPlanTruckPointsGridControl : BOSGridControl
    {
        public override void InitGridControlDataSource()
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            BindingSource bds = new BindingSource();
            bds.DataSource = entity.DeliveryPlanTruckPointList;
            DataSource = bds;
        }

        public enum DeliveryPlanTruckPointsColumnName
        {
            ARDeliveryPlanTruckPointNote,
            ARDeliveryPlanTruckPointEstimatedHour
        }

        protected override void AddColumnsToGridView(string strTableName, GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            //gridView.DoubleClick += new EventHandler(GridView_DoubleClick);
            gridView.RowStyle += new RowStyleEventHandler(gridView_RowStyle);

            if (gridView.Columns[DeliveryPlanTruckPointsColumnName.ARDeliveryPlanTruckPointEstimatedHour.ToString()] != null)
            {
                GridColumn column = gridView.Columns[DeliveryPlanTruckPointsColumnName.ARDeliveryPlanTruckPointEstimatedHour.ToString()];
                RepositoryItemDateEdit repositoryItemDateEdit = new RepositoryItemDateEdit();
                repositoryItemDateEdit.AutoHeight = false;
                repositoryItemDateEdit.EditFormat.FormatString = "HH:mm";
                repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                repositoryItemDateEdit.Mask.EditMask = "HH:mm";
                repositoryItemDateEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                repositoryItemDateEdit.Mask.UseMaskAsDisplayFormat = true;
                column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItemDateEdit)repositoryItemDateEdit;
                this.RepositoryItems.Add(repositoryItemDateEdit);
            }
            return gridView;
        }

        void gridView_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
                ADConfigValuesInfo objConfigValuesInfo = objConfigValuesController.GetObjectByConfigKey("DeliveryPlanTruckPointStatusIssued");
                string status = View.GetRowCellDisplayText(e.RowHandle, View.Columns["ARDeliveryPlanTruckPointStatus"]).ToString();

                if (status == objConfigValuesInfo.ADConfigText)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.Red;
                    e.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                }
            }

        }
        protected override void GridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            HomeEntities entity = (HomeEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            entity.DeliveryPlanTruckPointList.SetEndCurrentEdit();
            return;
        }
    }
}
