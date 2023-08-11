using BOSComponent;
using Localization;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BOSERP.Modules.InitializedInventoryStock
{
    public class InitializedInventoryStockModule : BaseModuleERP
    {
        #region Constants
        public const string DateToDateEditName = "fld_dteDateTo";
        #endregion
        #region Public Properties
        private BOSDateEdit DateToDateEdit;
        public bool isApproved = false;
        #endregion
        public InitializedInventoryStockModule()
        {
            Name = "InitializedInventoryStock";
            CurrentModuleEntity = new InitializedInventoryStockEntities();
            CurrentModuleEntity.Module = this;
            InitializeModule();


            DateToDateEdit = (BOSDateEdit)Controls[InitializedInventoryStockModule.DateToDateEditName];
        }
        protected override System.Data.DataSet GetSearchData(ref string searchQuery)
        {
            ICInitializedInventoryStocksInfo searchObject = (ICInitializedInventoryStocksInfo)CurrentModuleEntity.SearchObject;
            String productNo = searchObject.ICProductNo;
            String productSerieNo = searchObject.ICProductSerieNo;
            DateTime dateTo = searchObject.ICInitializedInventoryStockToDate;

            ICInitializedInventoryStocksController objICInitializedInventoryStocksController = new ICInitializedInventoryStocksController();
            DataSet ds = objICInitializedInventoryStocksController.GetInitializedInventoryStocks(productNo, productSerieNo, dateTo);
            return ds;
        }
        public void InitInventoryStocks()
        {

            isApproved = false;
            InitializedInventoryStockEntities entity = (InitializedInventoryStockEntities)CurrentModuleEntity;
            DateTime dateTo = Convert.ToDateTime(DateToDateEdit.EditValue);
            if (dateTo == DateTime.MinValue || dateTo == DateTime.MaxValue)
            {
                MessageBox.Show("Bạn chưa chọn ngày", CommonLocalizedResources.MessageBoxDefaultCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ActionNew();
            ICInitializedInventoryStocksController objICInitializedInventoryStocksController = new ICInitializedInventoryStocksController();
            //Kiểm tra đã tồn tại dữ liệu theo ngày đã tồn tại trong table ICInitializedInventoryStocks
            ICInitializedInventoryStocksInfo objICInitializedInventoryStocksInfo = objICInitializedInventoryStocksController.GetFirstInitializedInventoryStockByDateTo(dateTo);
            List<ICInitializedInventoryStocksInfo> initializedInventoryStocks = new List<ICInitializedInventoryStocksInfo>();
            if (objICInitializedInventoryStocksInfo != null)
            {
                if (objICInitializedInventoryStocksInfo.ICInitializedInventoryStockStatus == "Approved")
                {
                    isApproved = true;
                }
                initializedInventoryStocks = objICInitializedInventoryStocksController.GetExistedInitializedInventoryStocksByDateTo(dateTo);
            }
            else
            {
                initializedInventoryStocks = objICInitializedInventoryStocksController.GetInitializedInventoryStocksByDateTo(dateTo);
            }
            if (initializedInventoryStocks != null)
            {
                entity.InitializedInventoryStockList.Clear();
                initializedInventoryStocks.ForEach(x =>
                {
                    entity.InitializedInventoryStockList.Add(x);
                });
                entity.InitializedInventoryStockList.GridControl.RefreshDataSource();
            }

        }
        public void ApproveInitializedInventoryStocks()
        {
            if (Toolbar.IsNullOrNoneAction() && !isApproved)
            {
                InitializedInventoryStockEntities entity = (InitializedInventoryStockEntities)CurrentModuleEntity;
                if (entity.InitializedInventoryStockList.Count > 0)
                {
                    entity.InitializedInventoryStockList.ForEach(x => x.ICInitializedInventoryStockStatus = "Approved");
                    entity.InitializedInventoryStockList.SaveItemObjects();
                    isApproved = true;
                }

            }
        }
    }
}
