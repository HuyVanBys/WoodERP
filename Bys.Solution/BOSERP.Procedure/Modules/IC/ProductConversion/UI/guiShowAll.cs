using System;
using System.Collections.Generic;

namespace BOSERP.Modules.ProductConversion
{
    public partial class guiShowAll : BOSERPScreen
    {
        #region Variables
        public List<ICProductConversionItemsInfo> CurrentList { get; set; }
        #endregion

        public guiShowAll(List<ICProductConversionItemsInfo> currentList)
        {
            InitializeComponent();
            CurrentList = currentList;
            
        }

        private void guiShowAll_Load(object sender, EventArgs e)
        {
            InitializeControls(Controls);
            fld_dgcShowAllTargetProduct.InitGridControlDataSource(CurrentList);
            fld_dgcShowAllTargetProduct.RefreshDataSource();

        }
        public void RemoveItemList(ICProductConversionItemsInfo item)
        {
            CurrentList.RemoveAll(o => o.VirtualID == item.VirtualID);
            CurrentList.RemoveAll(o => o.VirtualParentID == item.VirtualID);
        }
        
    }
}