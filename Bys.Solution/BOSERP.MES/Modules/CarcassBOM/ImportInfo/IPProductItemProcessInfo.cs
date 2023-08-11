namespace BOSERP.MES.Modules.CarcassBOM.ImportInfo
{
    public class IPProductItemProcessInfo
    {
        public string IPProductItemProcessCode { get; set; }

        public string IPProductionItemParentCode { get; set; }

        public string MMOperationNo { get; set; }

        public string MMOperationName { get; set; }

        public int ICProductItemProcessPeriod { get; set; }

        public bool ICProductItemProcessInOutStockCheck { get; set; }

        public bool ICProductItemProcessIsPlan { get; set; }

        public string MMOperationSynNo { get; set; }

        public string MMOperationSynName { get; set; }

        public bool ICProductItemProcessSyncProductCheck { get; set; }

        public bool ICProductItemProcessForParentSyncCheck { get; set; }

        public string MMProcessName { get; set; }

        public string MMProcessNo { get; set; }

        public int FK_MMProcessID { get; set; }

        public int FK_MMOperationID { get; set; }

        public int FK_MMOperationSynID { get; set; }

        public bool ICProductItemProcessIsEndProcess { get; set; }
    }
}
