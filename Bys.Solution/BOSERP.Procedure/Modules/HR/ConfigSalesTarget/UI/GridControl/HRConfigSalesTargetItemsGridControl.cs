using BOSComponent;
using BOSLib;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Drawing;
using System.Linq;

namespace BOSERP.Modules.ConfigSalesTarget
{

    public class HRConfigSalesTargetItemsGridControl : BOSGridControl
    {
        public DataTable dt;
        public BOSList<HRConfigSalesTargetItemsInfo> ConfigSalesTargetItemList { get; set; }
        public override void InitGridControlDataSource()
        {
            ConfigSalesTargetEntities entity = (ConfigSalesTargetEntities)((BaseModuleERP)Screen.Module).CurrentModuleEntity;
            ConfigSalesTargetItemList = entity.ConfigSalesTargetItemList;
            dt = new DataTable();
            dt = InitDataTable();
            FillDataTable(dt, ConfigSalesTargetItemList);
            this.DataSource = dt;
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
        }
        public GridView GridViewMain { get; set; }

        public override void InitializeControl()
        {
            base.InitializeControl();
            BandedGridView bandedView = InitializeBandedGridView(GridViewMain);
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            bandedView.CellValueChanged += new CellValueChangedEventHandler(gridView_CellValueChanged);
            bandedView.RowCellStyle += new RowCellStyleEventHandler(gridView_RowCellStyle);
        }
        protected override DevExpress.XtraGrid.Views.Grid.GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            GridViewMain = gridView;
            gridView.OptionsView.ShowAutoFilterRow = true;
            if (gridView.Columns["ARSaleOrderItemProductQty"] != null)
            {
                gridView.Columns["ARSaleOrderItemProductQty"].OptionsColumn.AllowEdit = true;
            }
            return gridView;
        }
        public BandedGridView InitializeBandedGridView(GridView gridView)
        {
            BandedGridView bandedView = InitBandedGridView();
            //  bandedView.EndSorting += new EventHandler(bandedView_EndSorting);
            return bandedView;
        }
        public BandedGridView InitBandedGridView()
        {
            BandedGridView bandedView = new BandedGridView();
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = false;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            GridBand gridBand = CreateNewGridBand("HRObjectName", "Đối tượng");
            gridBand.MinWidth = 300;
            bandedView.Bands.Add(gridBand);
            ADConfigValuesController objConfigValuesController = new ADConfigValuesController();
            DataSet ds = objConfigValuesController.GetActiveConfigValuesByADConfigKeyGroup("ConfigSalesTargetApplicableSubjects");
            DataTable ConfigSalesTargetApplicableSubjectsDataTable = new DataTable();
            string objectType = string.Empty;
            if (ds != null)
                ConfigSalesTargetApplicableSubjectsDataTable = ds.Tables[0];

            BandedGridColumn gridColumnObjectName = new BandedGridColumn();
            if (ConfigSalesTargetItemList.Count >= 1)
            {
                foreach (DataRow row in ConfigSalesTargetApplicableSubjectsDataTable.Rows)
                {
                    foreach (DataColumn column in row.Table.Columns)
                    {
                        if (column.ColumnName == "Value" && row[column.ColumnName].ToString() == ConfigSalesTargetItemList.First().HRObjectType)
                        {
                            objectType = row["Text"].ToString();
                            break;
                        }
                    }
                }
                gridColumnObjectName = CreateNewColumn("HRObjectName", objectType, gridBand, false);
            }
            bandedView.Columns.Add(gridColumnObjectName);
            if (ConfigSalesTargetItemList != null && ConfigSalesTargetItemList.Count > 0)
            {
                GridBand band = new GridBand();
                ConfigSalesTargetItemList.GroupBy(o => o.HRConfigSalesTargetItemName).All(x =>
                    {
                        BandedGridColumn gridColumnTargetItemValue = CreateNewColumn(x.First().HRConfigSalesTargetItemName, x.First().HRConfigSalesTargetItemName, band, true);
                        bandedView.Columns.Add(gridColumnTargetItemValue);
                        return true;
                    });
            }
            return bandedView;
        }

        private GridBand CreateNewGridBand(string name, string header)
        {
            GridBand gridBand1 = new GridBand();
            gridBand1.Caption = header;
            gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
            gridBand1.Name = name;
            return gridBand1;
        }
        private BandedGridColumn CreateNewColumn(string name, string header, GridBand owner, bool allowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = name;
            bandedColumn.Caption = header;
            bandedColumn.FieldName = name;
            bandedColumn.Visible = true;
            bandedColumn.OptionsColumn.AllowEdit = allowEdit;
            bandedColumn.OwnerBand = owner;
            return bandedColumn;
        }
        protected void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            base.GridView_CellValueChanged(sender, e);
            BandedGridView gridView = (BandedGridView)sender;
            if (gridView.FocusedRowHandle >= 0)
            {
                DataRow row = gridView.GetDataRow(gridView.FocusedRowHandle);
                //((guiAttributionItemToTruck)Screen).ChangeRowItemlist(row);
            }
        }

        protected void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "ARDeliveryPlanItemRemainedQty")
            {
                if (Decimal.Parse(e.CellValue.ToString()) < 0)
                {
                    e.Appearance.BackColor = Color.Red;
                    e.Appearance.BackColor2 = Color.OrangeRed;
                }
                else if (Decimal.Parse(e.CellValue.ToString()) == 0)
                {
                    e.Appearance.BackColor = Color.Green;
                }
            }
        }

        private DataTable InitDataTable()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("FK_HRObjectID", typeof(string)));
            dt.Columns.Add(new DataColumn("HRObjectName", typeof(string)));

            if (ConfigSalesTargetItemList != null && ConfigSalesTargetItemList.Count > 0)
            {
                foreach (var item in ConfigSalesTargetItemList.GroupBy(o => o.HRConfigSalesTargetItemName))
                {
                    dt.Columns.Add(new DataColumn(item.First().HRConfigSalesTargetItemName, typeof(string)));
                }
            }

            return dt;
        }

        private void FillDataTable(DataTable dt, BOSList<HRConfigSalesTargetItemsInfo> configSalesTargetItemList)
        {
            foreach (var item1 in configSalesTargetItemList.GroupBy(o => o.FK_HRObjectID))
            {
                DataRow newRow = dt.NewRow();
                newRow["FK_HRObjectID"] = item1.First().FK_HRObjectID;
                newRow["HRObjectName"] = item1.First().HRObjectName;

                foreach (HRConfigSalesTargetItemsInfo item in configSalesTargetItemList)
                {
                    if (item.FK_HRObjectID == item1.First().FK_HRObjectID)
                    {
                        //newRow[item.HRConfigSalesTargetItemName] = decimal.Parse(item.HRConfigSalesTargetItemValue.ToString("N2"));
                        newRow[item.HRConfigSalesTargetItemName] = item.HRConfigSalesTargetItemValue.ToString("N2");
                    }
                }
                dt.Rows.Add(newRow);
            }
        }

        public void InvalidateData()
        {
            foreach (DataRow row in dt.Rows)
            {
                int objectID = 0;
                foreach (DataColumn column in row.Table.Columns)
                {

                    if (column.ColumnName == "FK_HRObjectID")
                    {
                        objectID = int.Parse(row[column.ColumnName].ToString());
                    }
                    else
                    {
                        ConfigSalesTargetItemList.Where(o => o.FK_HRObjectID == objectID).All(o =>
                            {
                                if (column.ColumnName == o.HRConfigSalesTargetItemName)
                                {
                                    o.HRConfigSalesTargetItemValue = string.IsNullOrEmpty(row[column.ColumnName].ToString()) ? 0 : decimal.Parse(row[column.ColumnName].ToString());
                                }
                                return true;
                            });
                    }
                }
            }
        }
    }
}
