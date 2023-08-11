using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq;

namespace BOSERP.Modules.Report
{
    public partial class RP049CurrencyACDocumentEntrysGridControl : ReportGridControl
    {
        public int RowHandle { get; set; }

        public override void InitializeControl()
        {
            base.InitializeControl();

            //Init banded view and make it the main view
            BandedGridView bandedView = InitializeBandedGridView((GridView)MainView);
            //bandedView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            MainView = bandedView;
            ViewCollection.AddRange(new BaseView[] { bandedView });
            ShowOnlyPredefinedDetails = true;
            UseEmbeddedNavigator = true;
        }

        public enum DocumentEntrysColumnName
        {
            StartPeriodDebitExchangeBalance,
            StartPeriodDebitBalance,
            StartPeriodCreditExchangeBalance,
            StartPeriodCreditBalance,
            ACDocumentEntryDebitExchangeAmount,
            ACDocumentEntryDebitAmount,
            ACDocumentEntryCreditExchangeAmount,
            ACDocumentEntryCreditAmount,
            EndPeriodDebitExchangeBalance,
            EndPeriodDebitBalance,
            EndPeriodCreditExchangeBalance,
            EndPeriodCreditBalance
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);

            new DocumentEntrysColumnName[]
            {
                DocumentEntrysColumnName.StartPeriodDebitExchangeBalance,
                DocumentEntrysColumnName.StartPeriodCreditExchangeBalance,
                DocumentEntrysColumnName.ACDocumentEntryDebitExchangeAmount,
                DocumentEntrysColumnName.ACDocumentEntryCreditExchangeAmount,
                DocumentEntrysColumnName.EndPeriodDebitExchangeBalance,
                DocumentEntrysColumnName.EndPeriodCreditExchangeBalance
            }
            .All(o =>
                {
                    gridView.Columns.Add(CreateGridColumn(o.ToString(), "VND", false));
                    return true;
                });

            new DocumentEntrysColumnName[]
            {
                DocumentEntrysColumnName.StartPeriodDebitBalance,
                DocumentEntrysColumnName.StartPeriodCreditBalance,
                DocumentEntrysColumnName.ACDocumentEntryDebitAmount,
                DocumentEntrysColumnName.ACDocumentEntryCreditAmount,
                DocumentEntrysColumnName.EndPeriodDebitBalance,
                DocumentEntrysColumnName.EndPeriodCreditBalance
            }
            .All(o =>
            {
                gridView.Columns.Add(CreateGridColumn(o.ToString(), "Ngoại tệ", false));
                return true;
            });
        }

        private GridColumn CreateGridColumn(string name, string caption, bool allowEdit)
        {
            GridColumn column = new GridColumn();
            column.FieldName = name;
            column.Caption = caption;
            column.OptionsColumn.AllowEdit = allowEdit;
            column.Visible = true;

            return column;
        }

        protected override GridView InitializeGridView()
        {
            GridView gridView = base.InitializeGridView();
            return gridView;
        }

        private BandedGridView InitializeBandedGridView(GridView gridView)
        {
            //Creat a banded grid view
            BandedGridView bandedView = new BandedGridView();
            GridBand gridBand1 = CreateGridBand("gridBand1", string.Empty);
            GridBand gridBand2 = CreateGridBand("gridBand2", string.Empty); ;
            GridBand gridBand3 = CreateGridBand("gridBand3", string.Empty); ;
            GridBand gridBand4 = CreateGridBand("gridBand4", "Đầu kì");
            GridBand gridBand5 = CreateGridBand("gridBand5", "Phát sinh");
            GridBand gridBand6 = CreateGridBand("gridBand6", "Cuối kì");
            GridBand gridBand7 = CreateGridBand("gridBand7", "Nợ");
            GridBand gridBand8 = CreateGridBand("gridBand8", "Có");
            GridBand gridBand9 = CreateGridBand("gridBand9", "Nợ");
            GridBand gridBand10 = CreateGridBand("gridBand10", "Có");
            GridBand gridBand11 = CreateGridBand("gridBand11", "Nợ");
            GridBand gridBand12 = CreateGridBand("gridBand12", "Có");
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
                gridBand1,
                gridBand2,
                gridBand3,
                gridBand4,
                gridBand5,
                gridBand6});
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = true;
            bandedView.OptionsView.ColumnAutoWidth = false;
            bandedView.OptionsView.ShowGroupPanel = false;

            gridBand4.Children.Add(gridBand7);
            gridBand4.Children.Add(gridBand8);
            gridBand5.Children.Add(gridBand9);
            gridBand5.Children.Add(gridBand10);
            gridBand6.Children.Add(gridBand11);
            gridBand6.Children.Add(gridBand12);

            foreach (GridColumn column in gridView.Columns)
            {
                if (column != null && ((column.FieldName == "ACObjectNo")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand1;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && ((column.FieldName == "ACObjectName")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand2;
                    bandedColumn.Width = 200;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && (column.FieldName == "GECurrencyName"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand3;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && (column.FieldName == "StartPeriodDebitExchangeBalance"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand7;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && (column.FieldName == "StartPeriodDebitBalance"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand7;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }

                if (column != null && (column.FieldName == "StartPeriodCreditExchangeBalance"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand8;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && (column.FieldName == "StartPeriodCreditBalance"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand8;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }

                if (column != null && (column.FieldName == "ACDocumentEntryDebitExchangeAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand9;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && (column.FieldName == "ACDocumentEntryDebitAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand9;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }

                if (column != null && (column.FieldName == "ACDocumentEntryCreditExchangeAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand10;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && (column.FieldName == "ACDocumentEntryCreditAmount"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand10;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }

                if (column != null && (column.FieldName == "EndPeriodDebitExchangeBalance"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand11;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && (column.FieldName == "EndPeriodDebitBalance"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand11;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }

                if (column != null && (column.FieldName == "EndPeriodCreditExchangeBalance"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand12;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
                if (column != null && (column.FieldName == "EndPeriodCreditBalance"))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand12;
                    bandedColumn.Width = 80;
                    bandedColumn.OptionsColumn.AllowEdit = false;
                }
            }

            bandedView.CustomDrawCell += new RowCellCustomDrawEventHandler(BandedView_CustomDrawCell);
            bandedView.CellValueChanged += new CellValueChangedEventHandler(BandedView_CellValueChanged);
            bandedView.RowClick += new RowClickEventHandler(BandedView_RowClick);
            return bandedView;
        }

        private GridBand CreateGridBand(string name, string caption)
        {
            GridBand gridBand = new GridBand();
            gridBand.Name = name;
            gridBand.Caption = caption;
            gridBand.AppearanceHeader.Options.UseTextOptions = true;
            gridBand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            gridBand.AppearanceHeader.TextOptions.WordWrap = WordWrap.Wrap;

            return gridBand;
        }

        private void BandedView_RowClick(object sender, RowClickEventArgs e)
        {
            RowHandle = e.RowHandle;
        }

        protected void BandedView_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                GridView gridView = (GridView)MainView;
            }
        }

        protected void BandedView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            BandedGridView bandedView = (BandedGridView)MainView;

        }

        public BandedGridColumn ConvertToBandedColumn(GridColumn gridColumn, bool isAllowEdit)
        {
            BandedGridColumn bandedColumn = new BandedGridColumn();
            bandedColumn.Name = gridColumn.Name;
            bandedColumn.FieldName = gridColumn.FieldName;
            bandedColumn.Caption = gridColumn.Caption;
            bandedColumn.OptionsColumn.AllowEdit = isAllowEdit;
            bandedColumn.Visible = true;
            bandedColumn.Width = gridColumn.Width;
            bandedColumn.AppearanceHeader.Options.UseTextOptions = true;
            bandedColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            bandedColumn.OptionsFilter.AllowFilter = true;
            bandedColumn.OptionsFilter.AllowAutoFilter = true;
            return bandedColumn;
        }

        public void InitColumnRepositoryText(BandedGridColumn column, string fomatType)
        {

            RepositoryItemTextEdit repositoryItemTextEdit = new RepositoryItemTextEdit()
            {
                Mask =
                {
                    MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric,
                    EditMask = fomatType,
                    UseMaskAsDisplayFormat = true
                }
            };
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            column.DisplayFormat.FormatString = "{0:" + fomatType + "}";
            column.OptionsColumn.AllowEdit = true;
            column.ColumnEdit = (DevExpress.XtraEditors.Repository.RepositoryItem)repositoryItemTextEdit;
            column.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
        }
    }

}
