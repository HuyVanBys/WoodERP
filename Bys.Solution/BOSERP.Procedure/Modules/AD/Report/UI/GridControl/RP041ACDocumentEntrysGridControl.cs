using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace BOSERP.Modules.Report
{
    public partial class RP041ACDocumentEntrysGridControl : ReportGridControl
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
            ACDocumentEntryAccountNo,
            OpenBalanceDebitAmount,
            OpenBalanceCreditAmount,
            TransactionDebitAccount,
            TransactionCreditAccount,
            EndDebitAccount,
            EndCreditAccount
        }

        protected override void AddColumnsToGridView(string strTableName, DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            base.AddColumnsToGridView(strTableName, gridView);
            GridColumn column = new GridColumn();
            column.FieldName = "ACDocumentDate";
            column.Caption = "Ngày, tháng ghi sổ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACDocumentNo";
            column.Caption = "Số hiệu";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACAccountReciprocalNo";
            column.Caption = "Số hiệu TK đối ứng";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACDocumentEntryDebitAmount";
            column.Caption = "Nợ";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);

            column = new GridColumn();
            column.FieldName = "ACDocumentEntryCreditAmount";
            column.Caption = "Có";
            column.OptionsColumn.AllowEdit = false;
            column.Visible = true;
            gridView.Columns.Add(column);
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
            GridBand gridBand2 = CreateGridBand("gridBand2", "Chứng từ ghi sổ");
            GridBand gridBand3 = CreateGridBand("gridBand3", string.Empty);
            GridBand gridBand4 = CreateGridBand("gridBand4", string.Empty);
            GridBand gridBand5 = CreateGridBand("gridBand5", "Số tiền"); ;
            bandedView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
                gridBand1,
                gridBand2,
                gridBand3,
                gridBand4,
                gridBand5,
            });
            bandedView.GridControl = this;
            bandedView.Name = "bandedGridView1";
            bandedView.OptionsCustomization.AllowFilter = true;
            bandedView.OptionsView.ColumnAutoWidth = true;
            bandedView.OptionsView.ShowGroupPanel = false;

            foreach (GridColumn column in gridView.Columns)
            {
                if (column != null && ((column.FieldName == "ACDocumentDate")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand1;
                    bandedColumn.Width = 150;
                }
                if (column != null && ((column.FieldName == "ACDocumentNo")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand2;
                    bandedColumn.Width = 150;
                }
                if (column != null && ((column.FieldName == "ACDocumentEntryDesc")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand3;
                    bandedColumn.Width = 250;
                }
                if (column != null && ((column.FieldName == "ACAccountReciprocalNo")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    bandedColumn.OwnerBand = gridBand4;
                    bandedColumn.Width = 150;
                }
                if (column != null && ((column.FieldName == "ACDocumentEntryDebitAmount")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand5;
                    bandedColumn.Width = 150;
                }
                if (column != null && ((column.FieldName == "ACDocumentEntryCreditAmount")))
                {
                    BandedGridColumn bandedColumn = ConvertToBandedColumn(column, true);
                    InitColumnRepositoryText(bandedColumn, "n2");
                    bandedColumn.OwnerBand = gridBand5;
                    bandedColumn.Width = 150;
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
