namespace BOSCommon
{
    #region Common
    public enum Status
    {
        Alive,
        Delete,
        Dummy,
        Approved,
        Edit,
        New,
        Complete,
        Canceled,
        Closed,
        Increase,
        Decrease,
        Verified,
        NeedApprove
    }

    public enum AddressType
    {
        Contact,
        Invoice,
        Delivery,
        Payment,
        Stock
    }

    public enum ObjectType
    {
        Customer,
        Supplier,
        Employee,
        Branch,
        Plan,
        Sale,
        Project,
        ProjectType,
        ProjectNorm
    }

    /// <summary>
    /// Set of report type
    /// </summary>
    public enum ReportType
    {
        Sale,
        Customer,
        Purchasing,
        Staff,
        Inventory,
        Accounting,
        PrintedDocument
    }

    public enum ObjectHistoryAction
    {
        Create,
        Change,
        Delete
    }

    public enum ReportViewType
    {
        PrintViewer,
        Form
    }

    public enum TemplateType
    {
        Proposal,
        Contract,
        CustomsClearance,
        BatchProposal
    }
    #endregion

    #region Inventory
    /// <summary>
    /// Set of return values for inventory validation
    /// </summary>
    public enum InventoryStatus
    {
        Empty = 1,
        LessThanMinQty = 2,
        GreaterThanMaxQty = 3,
        Valid = 4,
        WoodQtyInValid = 5
    }

    /// <summary>
    /// Set of inventory type
    /// </summary>
    public enum InventoryType
    {
        OnHand,
        SaleOrder,
        PurchaseOrder,
        Proposal,
        TransitIn,
        TransitOut,
        Maintenance,
        AllocationPlan,
        PurchasePlan
    }

    public enum TransactionType
    {
        Sale,
        Purchase,
        Other
    }

    public enum ReceiptType
    {
        PurchaseReceipt,
        ReturnReceipt,
        DryWoodRedundantReceipt,
        DryWoodReturnReceipt,
        Receipt,
        LumberReceipt,
        ProductionReceipt,
        DryLumberReceipt,
        SemiProductReceipt,
        SemiProductReceiptDC,
        MaterialReceipt,
        SubRoundWood,
        EquipmentReceipt,
        FreshLumber,
        ReceiptHeat,//Nhập kho lò sấy
        MaterialRedundantReceipt,
        MaterialReturnReceipt,
        Product,
        ReceiptCD,
        AssetIncreasing,
        SemiProductReceiptTransfer,
        OutsourcingReceipt,
        AssemblyReceipt, //Nhập kho lắp ráp
        ReturnShipping,
        AssembleReceipt,
        DisassembleReceipt
    }

    public enum ReceiptItemType
    {
        MultiPackage,
        MultiProduct,
        MultiPackageProduct
    }
    public enum ReceiptStatus
    {
        New,
        Complete,
        Confirmed
    }
    public enum ContainerLoaderStatus
    {
        New,
        Complete,

    }
    public enum ProductionPlanningStatus
    {
        New,
        Complete,
        Canceled
    }
    public enum AssetReceiptStatus
    {
        New,
        Complete
    }

    public enum ShipmentType
    {
        SaleShipment,
        PresentingShipment,
        ReturnShipment,
        Shipment,
        EquipmentShipment,
        EquipmentIncreasing,
        EquipmentDecreasing,
        FreshLumber,
        RoundwoodShipment,
        SemiProductShipment,
        SemiProductShipmentDC,
        MaterialShipment,
        Wood,
        DryLumber,
        ShipmentHeat, // Xuất kho lò sấy,
        ProductionShipment,
        AssetShipment,
        ShipmentCD,
        SemiProductShipmentTransfer,
        MaterialShipmentConstruction,
        OutsourcingReceipt,
        AssemblyShipment, // Xuất kho lắp ráp
        AssembleShipment,  //Rã Bộ
        DisassembleShipment
    }

    public enum ReceiptReceiptType
    {
        Lumber,
        Roundwood,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        Equipment,
        Verneer,
        ArtificialBoard,
        OutSourcing,
        MechanicOutSourcing
    }

    public enum ShipmentStatus
    {
        New,
        Complete,
        EditAfterComplete,
        Close,
        Canceled,
    }

    public enum ShipmentShipmentType
    {
        Wood,
        Hardware,
        IngredientPackaging,
        IngredientPaint,
        FreshLumber,
        DryLumber,
        Other,
        OtherMaterial
    }

    public enum StockType
    {
        Sale,
        Purchase,
        Central,
        TransitIn,
        TransitOut,
        Maintenance,
        SaleOrder,
        AllocationPlan,
        PurchasePlan
    }

    public enum TransferType
    {
        Transfer,
        TransferReceipt
    }

    public enum TransferTransferType
    {
        Transfer,
        TransferConstruction,
        TransferAdditional,
        TransferOutsourcing
    }

    public enum TransferStatus
    {
        New,
        Post,
        Incomplete,
        Complete,
        Close
    }

    public enum ProductDepreciationMethod
    {
        Once,
        Many
    }
    public enum InventoryStockCountStatus
    {
        New,
        Checked,
        Approved,
    }
    #endregion

    #region Human Resources
    public enum TimesheetEmployeeLateConfigType
    {
        BackSoon,
        ComeLate
    }
    public enum EmployeeStatus
    {
        Working,
        ThoiViec,
        ThuViec,
        Resigned,
        Pause
    }

    public enum EmployeeContactType
    {
        DiaChiThuongTru,
        DiaChiTamTru,
        DiaChiLienHe
    }

    public enum AllowanceConfigName
    {
        Productivity,
        Quality,
        Manage,
        Diligence,
        HeavyToxic,
        Perennial,
        Other,
        Meal,
        LodgingHouse,
        BHXH,
        Technical
    }

    public enum EmployeeContractType
    {
        ThuViec,
        KhongThoiHan,
        HocViec,
        ThuMoiNhanViec
    }

    public enum AllowanceCategory
    {
        Normal,
        ForManage
    }
    public enum AllowanceOption
    {
        AddToSalary,
        Now
    }
    public enum AllowanceType
    {
        Percent,
        Amount,
        Other,
        WorkingQty,
        OTHours,
        WorkingQtyNight,
        WorkingQtyTotal,
        OTQty,
        C,
        CD,
        Bus,
        DH,
        CNight,
        Effective,
        Diligence,
        HeavyToxic,
        Perennial,
        DiLai,
        OmDau,
        TienCom,
        TruyLanh,
        NuoiCon,
        NangSuat,
        Meal,
        WorkFees
    }
    public enum TimeSheetType
    {
        Day,
        Hour
    }

    public enum TimeSheetStatus
    {
        New,
        SalaryCalculated,
        Approved
    }

    public enum TimeSheetParamType
    {
        Day,
        Hour,
        Common,
        BonusTime,
        LeavedaySpecial,
        LE,
        NKP,
        NCP1P2,
        NCP,
        PN,
        NCL,
        PN1P2,
        NKP1P2,
        TC,
        TS,
        CTCN,
        NCD,
        NCDO,
        KTC
    }

    public enum PayRollType
    {
        Day,
        Hour
    }

    public enum PayRollStatus
    {
        New,
        Posted,
        Complete,
        Approved
    }

    public enum CalculatedSalaryType
    {
        Basic,
        Working
    }

    public enum CalendarType
    {
        Holiday
    }


    public enum MailPriority
    {
        VeryImportant,
        High,
        Normal,
        Low
    }

    public enum Priority
    {
        VeryImportant,
        High,
        Normal,
        Low
    }
    public enum MailType
    {
        Inbox,
        SentItem
    }

    public enum OTFactorType
    {
        Holiday,
        EndOfWeek,
        WorkingDay
    }
    public enum AttachmentFileType
    {
        KB,
        MB
    }
    public enum LeaveDaysType
    {
        Annual,
        Sick,
        Birth,
        OT,
        Normal
    }
    public enum TrainningEmployee
    {
        Teacher,
        Student
    }
    public enum EmployeeEvaluationType
    {
        Evaluating,
        Evaluated
    }

    public enum RewardType
    {
        Percent,
        Amount,
        Other,
        WorkingQytFull,
        WorkDay,
        Nangsuat,
        Quarter,
        PNTL,
        Omdauthaisan
    }

    public enum DisciplineType
    {
        Percent,
        Amount,
        WorkDay,
        Other,
        Absence,
        BHTN,
        PhiTheTu,
        PhiTheATM,
        PhiAo,
        MatCCDC,
        DieuChinh,
        MinusBonus
    }
    public enum CalenderType
    {
        Holiday
    }
    public class ProductGroup
    {
        public const string PaintNo = "04";
        public const string PackagingNo = "03";
        public const string RoundWoodNo = "01";
        public const string ReuseWoodNo = "05";
        public const string LumberWoodNo = "02";
        public const string WoodMaterialNo = "09";
        public const string GroupNo = "01";//Cụm
        public const string DetailNo = "02";//Cụm
        public const string GroupPackagingNo = "02";//Nhóm
        public const int ProductGroupCartonID = 11;

    }

    public enum EvaluationStatus
    {
        New,
        InProgress,
        Closed,
    }

    public enum HRDayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public enum PaymentProposalStatus
    {
        New,
        Confirmed,
        Canceled,
        ApprovePayment,
        Approved,
        Checked
    }
    public enum PaymentProposalApproveStatus
    {
        Approved,
        Rejected,
        Canceled,
        New,
        Checked
    }
    public enum EmployeeSocialInsuranceType
    {
        IncreaseLabor,
        IncreaseRate,
        IncreaseBHYT,
        IncreaseBHTN,
        DecreaseLabor,
        DecreaseRate,
        DecreaseBHYT,
        DecreaseBHTN,
        Change
    }

    public enum PayRollAuditStatus
    {
        New,
        Posted
    }

    public enum PayRollAuditType
    {
        Day,
        Hour
    }

    public enum TimeSheetAuditStatus
    {
        New,
        SalaryCalculated
    }

    public enum TimeSheetAuditType
    {
        Day,
        Hour
    }

    public enum WorkingShiftDayOffWeek
    {
        T2 = 1,
        T3 = 2,
        T4 = 3,
        T5 = 4,
        T6 = 5,
        T7 = 6,
        CN = 0,
        All = -1
    }
    #endregion

    #region Sale
    public enum CustomerType
    {
        Personal,
        Company
    }

    public enum PriceLevel
    {
        Regular,
        VIP,
        Employee,
        WholeSale
    }

    public enum PaymentMethod
    {
        Cash,
        EFTPOS,
        Check,
        CreditCard,
        Account,
        CreditNote,
        GiftVoucher,
        BankTransfer,
        PaymentOrder,
        CashSec,
        TransferSec,
        OwingExchange,
        DepositTransfer,
        Clearing
    }

    public enum AssetType
    {
        Factory,
        Machine,
        Vehicle,
        Device,
        Other
    }

    public enum InvoiceType
    {
        SaleReceipt,
        GiftReceipt,
        SaleOrder,
        SaleReturn,
        InvoiceAndShipment
    }

    public enum EmployeeWorkScheduleStatus
    {
        New,
        Approved,
        CancelScheduleNo,
        UnApproved
    }

    public enum BreakTimeType
    {
        InSiesta,
        OutSiesta
    }

    public enum ProductType
    {
        Product,
        Component,
        SemiProduct,
        SemiProductForSyncProduct,
        Ingredient,
        //ByProduct,
        IngredientPaint,
        IngredientPackaging,
        Hardware,
        Roundwood,
        Reuse,
        Lumber,
        ArtificialBoard,
        Verneer,
        Instrument,
        VVP,
        MMTB,
        Car,
        Equipment,
        OutSourcingAndManafacturing,
        Service,
        OutSourcing,
        Other,
        AlloyCover,
        Rent,
        WoodMDFOutSourcing,
        MechanicOutSourcing,
        Repair,
        Detail,
        Work,
        Section,
        Device,
        AddMaterial,
        Electric,
        BuildingMaterials,
        Decorative,
        ElecWater,
        BuildingMaterial,
        Rock,
        Glasses,
        Cloth,
        StyroFoam,
        Sponges,
        BoardOf,
        GeneralMaterial,
        Steel,
        Material,
        Wood,
        Asset
    }

    public enum ProductOrigin
    {
        Production,
        Outsourcing,
        DomesticPurchase,
        Import,
        Service
    }


    public enum InvoiceStatus
    {
        /// <summary>
        /// The invoice has been created
        /// </summary>
        New,

        /// <summary>
        /// The invoice has been completed and can not modify
        /// </summary>
        Complete,

        /// <summary>
        /// The invoice has been paid
        /// </summary>
        Paid,
    }

    public enum SaleOrderType
    {
        LayBy,
        SaleOrder,
        Proposal, //Báo giá
        //SampleProduction, // Sản xuất mẫu
        MassProduction, //Sản xuất đại trà
        PaymentSample,//1.       Mẫu tính tiền
        FOCSample,//2.       Mẫu FOC
        PaymentSpareSample,//3.       Spare tính tiền
        SpareFOCSample,//4.       Spare FOC
        OutSourcing,
        Other,
        SaleForecast,
        //Roundwood,
        //FreshLumber,
        //DryLumber
        AnnexContract,//phụ lục hợp đồng
    }
    public enum SaleOrderProductType
    {
        Roundwood,
        FreshLumber,
        DryLumber,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        SemiProduct,
        Other,
        Verneer,
        ArtificialBoard,
        Product,
        Kitchen,
        Interior,
        AvailableInterior
    }

    public enum SaleOrderBatchStatus
    {
        Proposed,
        Producing,
        Complete
    }

    public enum SaleOrderStatus
    {
        New,
        Approved,
        Confirmed,
        Canceled,
        Incomplete,
        Shipped,
        Complete,
        Manafacturing,
        EditAfterComplete,
        Closed,
        EditAfterPayment
    }

    public enum PriceSheetStatus
    {
        New,
        Verified,
        Approved
    }
    public enum PriceSheetType
    {
        SupplierPriceSheet,
        PlanPriceSheet
    }

    public enum PriceSheetApprovedStatus
    {
        None,
        NotActive,
        IsActive,
        OutOfActive
    }

    public enum SaleForecastType
    {
        LayBy,
        SaleForecast
    }

    public enum SaleForecastSaleType
    {
        National,
        International
    }
    public enum SaleForecastStatus
    {
        /// <summary>
        /// Sale order has been created, wait for approval
        /// </summary>
        New,

        /// <summary>
        /// Sale order has been approved, wait for customer's confirmation
        /// </summary>
        Approved,

        /// <summary>
        /// Sale order has been confirmed by customer, wait for shipment
        /// </summary>
        Confirmed,

        /// <summary>
        /// Sale order has been canceled by customer
        /// </summary>
        Canceled,

        /// <summary>
        /// Sale order has been invoiced, but still has no full shipment
        /// </summary>
        Incomplete,

        /// <summary>
        /// Sale order has been shipped
        /// </summary>
        Shipped,
        Complete
    }

    public enum CustomerPaymentType
    {
        Deposit,
        SaleReceipt,
        SaleOrder,
        Repaid,
        AdvancePayment
    }

    public enum CustomerPaymentFromType
    {
        ReceiptVoucher,
        BankTransfer,
        OwingExchange,
        AdvancePayment,
    }

    public enum CustomerStatus
    {
        New,
        Sightseeing,
        WaitQuote,
        BeQuoted,
        Ordered,
        AdvancedPayment
    }

    public enum CustomerSex
    {
        Male,
        Female,
        Orther
    }

    public enum SaleReturnStatus
    {
        /// <summary>
        /// The sale return has been created
        /// </summary>
        New,

        /// <summary>
        /// The sale return has been completed
        /// </summary>
        Complete
    }

    public enum ReturnSupplierStatus
    {
        New,
        Complete
    }

    public enum ReturnShippingStatus
    {
        /// <summary>
        /// The sale return has been created
        /// </summary>
        New,

        /// <summary>
        /// The sale return has been completed
        /// </summary>
        Complete
    }

    public enum CancelVoucherStatus
    {
        /// <summary>
        /// The cancel voucher has been created
        /// </summary>
        New,
        Complete
    }

    public enum CancelSaleForecastStatus
    {
        /// <summary>
        /// The cancel SaleForecast has been created
        /// </summary>
        New,
        Complete
    }
    public enum AdjustSaleOrderQuantityStatus
    {
        /// <summary>
        /// The cancel SaleForecast has been created
        /// </summary>
        New,
        Approved
    }
    public enum CancelAllocationPlanStatus
    {
        New,
        Approved
    }

    public enum CreditNoteType
    {
        CreditNote,
        GiftVoucher
    }

    public enum ReceiptVoucherType
    {
        Receipt,
        CustomerPayment,
        Deposit
    }
    public enum BatchItemPlanStatus
    {
        New,
        Canceled,
        Validated,
        Approved,
        Completed,
        InProcess
    }
    public enum WoodPlanStatus
    {
        New,
        Canceled,
        Validated,
        Approved,
        Completed,
        InProcess
    }
    public enum BatchProductItemPlanStatus
    {
        New,
        Confirmed,
        Canceled,
        InComplete,
        Completed,
        PlanProcess
    }
    public enum BatchItemWoodDetailPlanType
    {
        Allocation,
        Purchase,
        Reuse,
    }
    public enum ExchangeRateConfigOperationType
    {
        Plus,
        Minus,
        Multi,
        Split
    }
    public enum ExchangeRateConfigLumberType
    {
        Fresh,
        Dry
    }

    public enum AllocationPlanItemHWQtySource
    {
        HWQtySource1,
        HWQtySource2,
        HWQtySource3
    }

    public enum PurchaseOrderItemDivision
    {
        Product,
        Work,
        Material
    }

    public enum SourceSellingPriceMethod
    {
        MasterData,
        PriceSheet,
        Typing,
        Config
    }
    #endregion

    #region Purchase
    public enum InvoiceInType
    {
        PurchaseReceipt,
        Return,
        Lumber,
        Roundwood,
        Product,
        Service,
        Ingredient,
        Material,
        Verneer,
        ArtificialBoard
    }

    public enum InvoiceInStatus
    {
        New,
        Completed,
        Incompleted
    }

    public enum PurchaseOrderStatus
    {
        New,
        Confirmed,
        Canceled,
        Completed,
        Incompleted,
        Packaged,
        Approved,
        Closed
    }

    public enum PurchasePlanStatus
    {
        New,
        Confirmed,
        Canceled,
        Completed,
        Incompleted,
        Packaged,
        Approved
    }

    public enum PurchaseOrderType
    {
        SaleOrder,
        Inventory,
        Maintenance,
        OutSourcing,
        Material,
        RoundWood,
        Service,
        OutSourcingService
    }

    public enum SaleOrderItemType
    {
        Material,
        Asset
    }

    public enum PurchaseProposalStatus
    {
        New,
        Confirmed,
        Canceled,
        Approved,
        Ordered
    }


    public enum PurchaseProposalType
    {
        SaleOrder,
        Inventory,
        Operating,
        Maintenance,
        OutSourcing
    }

    public enum PurchaseProposalItemStatus
    {
        New,
        Confirmed,
        Canceled,
        Approved,
        Purchased
    }

    public enum AllocationProposalItemStatus
    {
        New,
        Canceled,
        Confirmed,
        Approved,
        CantPurchase
    }

    public enum BatchProposalStatus
    {
        New,
        Approved,
        Canceled,
        InProcess,
        Processed,
        Completed
    }

    public enum BatchProposalItemStatus
    {
        New,
        Approved,
        InProcess,
        Processed,
        Completed,
        Cancel
    }

    public enum BatchProductStatus
    {
        New,
        Approved,
        Confirmed,
        Canceled,
        Incomplete,
        Complete,
        Producing,
        Verified,
        Closed
    }
    public enum BatchProductPlanStatus
    {
        New,
        Canceled,
        Confirmed,
        Approved,
        Completed,
        InComplete,
        Close
    }

    public enum MMProductionCostStatus
    {
        New,
        Completed,
        Canceled
    }

    public enum BatchProductPlanProposalStatus
    {
        New,
        Confirmed,
        Canceled,
        Approved,
        InComplete,
        Completed
    }
    public enum AllocationPlanStatus
    {
        New,
        Saved,
        Close
    }
    public enum OperationDetailPlanType
    {
        New,
        Production,
        Compensate,
        OutSourcing
    }
    public enum AllocationPlanType
    {
        Wood,
        Hardware,
        IngredientPackaging,
        IngredientPaint,
        Equipment,
        GeneralMaterial,
        Other,
        SemiProduct,
        DryLumber,
        Steel,
        Meterial
    }

    public enum AllocationPlanCreateFrom
    {
        BatchProduct,
        Normal
    }

    public enum AllocationPlanPurpose
    {
        Production,
        OutSourcing
    }

    public enum BatchProductSheduleAllocationStatus
    {
        New,
        Confirmed,
        Canceled,
        Approved,
        InComplete,
        Completed,
        Process
    }

    public enum OperationDetailPlanStatus
    {
        New,
        Canceled,
        Approved,
        Completed,
    }
    public enum DetailPlanItemChildStatus
    {
        New,
        Canceled,
        JobCreated,
        Closed,
    }
    public enum OperationDetailPlanCapacityStatus
    {
        New,
        Canceled,
        Completed,
    }

    public enum BatchProductItemStatus
    {
        New,
        Approved,
        Confirmed,
        Canceled,
        Incomplete,
        Completed,
        Close
    }

    public enum BatchProductDeliveryStatus
    {
        InComplete,
        Completed
    }

    public enum ProductBranchPriceType
    {
        Sale,
        Purchase
    }
    public enum BatchProductSheduleWoodAllowcationType
    {
        DryLumber,
        FreshLumber,
    }
    public enum SupplierPaymentType
    {
        SupplierPayment,
        PaymentProposal
    }

    public enum PaymentVoucherType
    {
        Payment,
        SupplierPayment,
        CustomerRepaid
    }
    public enum SupplierPaymentStatus
    {
        New,
        Approved,
        Completed,
        Canceled
    }

    public enum PaymentVoucherStatus
    {
        New,
        Approved,
        Completed,
        Canceled
    }

    public enum CancelPurchaseProposalStatus
    {
        New,
        Canceled,
        Approved
    }

    public enum CancelPurchaseProposalItemStatus
    {
        New,
        Confirmed,
        Canceled,
        Approved,
        Purchased
    }

    public enum DocumentStatus
    {
        New,
        Canceled,
        Complete
    }

    public enum DocumentAllocationCriteria
    {
        Amount,
        Qty
    }
    #endregion

    #region Bank Transaction
    public enum BankTransactionType
    {
        BankTransfer,
        PaymentOrder,
        PaymentCash
    }

    public enum BankTransactionStatus
    {
        New,
        Approved,
        Completed
    }
    #endregion

    #region Accounting
    public enum AccDocumentType
    {
        #region Sale
        BanHangCongNo,
        BanLe,
        BanDichVu,
        HangBanTraLai,
        PhieuTangHang,
        TraTienKhachHang,
        #endregion

        #region Purchase
        MuaHangCongNoNoiDia,
        MuaHangCongNoNhapKhau,
        ThanhToanPhi,
        #endregion

        #region Bank Transaction
        NopTienVaoTaiKhoan,
        UyNhiemChi,
        SecTienMat,
        NhanTienDieuChuyen,
        #endregion

        #region Inventory
        XuatKhoBanHang,
        XuatKhoBanHangDuAn,
        XuatKho,
        XuatKhoTangHang,
        NhapKhoMuaHangHoaDon,
        NhapKhoMuaHang,
        NhapKhoHangTra,
        NhapKho,
        NhapKhoRapBo,
        NhapKhoRaBo,
        NhapKhoNVL,
        XuatKhoGoTron,
        NhapKhoPhachTuoiCongDoanCua,
        XuatKhoPhachTuoiCongDoanCua,
        XuatKhoPhachTuoiCongDoanSay,
        NhapKhoPhachKhoCongDoanSay,
        NhapKhoBTP,
        XuatKhoBTP,
        XuatKhoPhachKhoCongDoanPhoi,
        NhapKhoThanhPhamCongDoanDongGoi,
        NhapKhoMuaGo,
        NhapKhoLongCon,
        NhapKhoMuaGoHoaDon,
        XuatKhoVatTu,
        NhapKhoVatTu,
        XuatKhoLoSay,
        NhapKhoLoSay,
        XuatKhoDiCuaXe,
        NhapKhoThanhPham,
        XuatKhoRapBo,
        XuatKhoRaBo,
        NhapKhoGiaCong,
        ChuyenKhoGiaCong,
        TraHangNhapKho,
        TraHangHoaDon,
        XuatKhoLapRap,
        NhapKhoLapRap,
        #endregion

        #region Budget
        PhieuThu,
        PhieuChi,
        ThanhToanTrucTiep,
        #endregion

        #region Human Resources
        HachToanLuong,
        DeNghiHoanUngCoHoaDon,
        DeNghiHoanUngKhongHoaDon,
        KheUocVay,
        ToKhaiHaiQuan,
        #endregion

        #region Asset
        TangTSCD,
        GiamTSCD,
        DieuChuyenTSCD,
        NhapKhoTaiSan,
        XuatKhoTaiSan,
        Bangluong,
        DieuChinhTang,
        DieuChinhGiam,
        #endregion

        #region Equipment
        NhapCCDC,
        XuatCCDC,
        DieuChuyenCCDC,
        TangCCDC,
        GiamCCDC,
        #endregion

        #region General
        NghiepVuKhac,
        PhanBoChiPhi,
        KhauTruThue,
        TinhThueTNDN,
        XacDinhKQKD,
        DanhGiaNgoaiTe,
        ChenhLechTyGia,
        KhauHaoTSCD,
        PhanBoCCDC,
        KetChuyenChiPhi,
        CanTru,
        BuTruCongNo,
        #endregion

        #region Manufacturing
        XuatKhoSanXuat,
        #endregion
        PhanBoChiPhi6279,

        ToKhaiHaiQuanNK,
        ToKhaiHaiQuanXK,
        ThanhToanPhiNhapKhau,
        ThanhToanPhiHoaDonBanHang,
        PhanBoChiPhiNhapKhau,
        NhapDoiTra,
        DeNghiHoanUng,
    }

    public enum AccEntryType
    {
        #region Sale
        DoanhThuBanHang,
        DoanhThuChuaThucHien,
        ChietKhauThuongMai,
        ChietKhauThanhToan,
        GiamGiaHangBan,
        ThueGTGTPhaiNop,
        ThuChietKhauHangTra,
        HangBanTraLai,
        DoanhThuChiPhi,
        #endregion

        #region Purchase
        PhaiTraNguoiBan,
        PhaiThuNguoiBan,
        ChiPhiMuaHang,
        ChiPhiBanHang,
        ThueGTGTDuocKhauTru,
        XuatKhoTraHang,
        #endregion

        #region Inventory
        NhapKhoMuaHang,
        NhapKhoHangTra,
        NhapKhoDieuChinh,
        NhapKhoRapBo,
        NhapKhoRaBo,
        XuatKhoBanHang,
        XuatKhoDieuChinh,
        XuatKhoRapBo,
        XuatKhoRaBo,
        XuatKhoTangHang,
        NhapKhoNVL,
        XuatKhoGoTron,
        NhapKhoPhachTuoiCongDoanCua,
        XuatKhoPhachTuoiCongDoanCua,
        XuatKhoPhachTuoiCongDoanSay,
        NhapKhoPhachKhoCongDoanSay,
        NhapKhoBTP,
        XuatKhoBTP,
        XuatKhoPhachKhoCongDoanPhoi,
        NhapKhoThanhPhamCongDoanDongGoi,
        NhapKhoMuaGo,
        NhapKhoLongCon,
        XuatKhoVatTu,
        NhapKhoVatTu,
        XuatKhoLoSay,
        NhapKhoLoSay,
        XuatKhoDiCuaXe,
        NhapKhoThanhPham,
        NhapKhoGiaCong,
        NhapChuyenKhoGiaCong,
        XuatChuyenKhoGiaCong,
        NhapKhoLapRap,
        XuatKhoLapRap,
        #endregion

        #region Budget
        ThuTienKhachHang,
        ThuTienNhaCungCap,
        ThuTienUngTruoc,
        TraTienKhachHang,
        TraTienNCC,
        TamUng,
        TamUngVay,
        PhieuThu,
        PhieuChi,
        CanTru,
        TamUngLuong,
        TamUngCongTac,
        ChenhLechLai,
        ChenhLechLo,
        #endregion

        #region Bank
        NopTienNganHang,
        #endregion

        #region Human Resources
        DeNghiHoanUng,
        LuongNhanVien,
        BHXHNhanVienDong,
        BHXHDoanhNghiepDong,
        BHTNNhanVienDong,
        BHTNDoanhNghiepDong,
        BHYTNhanVienDong,
        BHYTDoanhNghiepDong,
        PhiCongDoanNVDong,
        PhiCongDoanDNDong,
        ThueTNCN,
        #endregion

        #region Asset
        TangTSCD,
        GiamTSCDHaoMon,
        GiamTSCDGiaTriConLai,
        NhapKhoTaiSan,
        XuatKhoTaiSan,
        DieuChinhTang,
        DieuChinhGiam,
        #endregion

        #region Equipment
        NhapCCDC,
        XuatCCDC,
        XuatCCDCPhanBo,
        GhiGiamCCDC,
        #endregion

        #region General
        PhanBoChiPhiMuaHang,
        KhauTruThueGTGT,
        TinhThueTNDN,
        KetChuyenGiaVon,
        KetChuyenChiPhiBanHang,
        KetChuyenChiPhiQLDN,
        KetChuyenChiPhiTaiChinh,
        KetChuyenChiPhiKhac,
        KetChuyenChiPhiThueTNDN,
        KetChuyenCKTM,
        KetChuyenGiamGiaHangBan,
        KetChuyenHangBanTraLai,
        KetChuyenDoanhThuBanHang,
        KetChuyenDoanhThuTaiChinh,
        KetChuyenThuNhapKhac,
        KetChuyenLaiLo,
        DanhGiaNgoaiTe,
        ChenhLechTyGia,
        KhauHaoTSCD,
        PhanBoCCDC,
        PhanBoChiPhiTraTruoc,
        BuTruCongNo,
        #endregion

        #region Other
        CanTruCongNoNCC,
        CanTruCoc,
        ThuPhieuGhiCo,
        ThuCocBangPhieuGhiCo,
        ThuTheTinDung,
        ThuCocBangTheTinDung,
        TienChuyenDen,
        PhiNganHang,
        #endregion

        XuatChuyenKho,
        NhapChuyenKho,
        PhanBoChiPhi6279CongDoanPhoi,
        PhanBoChiPhi6279CongDoanSoChe,
        PhanBoChiPhi6279CongDoanTinhChe,
        PhanBoChiPhi6279CongDoanLapRap,
        PhanBoChiPhi6279CongDoanSon,
        PhanBoChiPhi6279CongDoanDongGoi,
        ThuTienHoanUng,
        ChiTienHoanUng,
        ThueNhapKhau,
        ThueTieuThuDacBiet,
        ThueBVMT,
        ThueGTGT,
        NghiepVuKhac,
        TruLuongTraNoVay,
        NhapDoiTra,
    }

    public enum AccAccountType
    {
        DebitBalance,
        CreditBalance,
        DebitCreditBalance,
        NoBalance
    }

    public enum AccPostingType
    {
        Credit,
        Debit
    }

    public enum AccCostMethod
    {
        SpecificIdentification,
        ContinuousWeightedAverage,
        PeriodicWeightedAverage
    }

    public enum AccountType
    {
        DebitBalance,
        CreditBalance,
        DebitCreditBalance,
        NoBalance
    }

    public enum AccountPostingRule
    {
        IncreasingByDebit,
        IncreasingByCredit
    }

    public enum AssetStatus
    {
        Purchased,
        Using,
        UsingWithoutDepreciation,
        Shipped,
        SuspendedDepreciation
    }

    public enum AssetReceiptType
    {
        NewIncrease,
        FromUnfinishedConstructionCost,
        Receipt
    }

    public enum AssetDepreciationMethod
    {
        StraightLine
    }

    public enum StopDepreciationAssetType
    {
        Stop,
        Continue
    }

    public enum EquipmentDepreciationMethod
    {
        Once,
        Many
    }

    #endregion

    #region Data Exchange
    public enum DataExchangeStatus
    {
        New,
        Posting,
        Complete,
        Failed
    }

    public enum DataExchangeType
    {
        Inventory,
        Sale,
        Customer,
        Purchase,
        Accounting,
        HumanResource,
        AccountInitData
    }

    public enum BranchType
    {
        Central,
        Branch
    }
    public enum ShipmentProposalStatus
    {
        New,
        Approved,
        Shipping,
        Finish,
        Canceled
    }
    public enum ShipmentProposalItemStatus
    {
        New,
        Approved,
        Shipping,
        Finish,
        Canceled
    }
    #endregion

    #region Production Norm
    public enum MMProposalType
    {
        Lumber,
        Roundwood,
        MassProduction,
        //SampleProduction,
        Proposal,
        Plan,
        SaleOrder,
        InventoryStock,
        PaymentSample,//1.       Mẫu tính tiền
        FOCSample,//2.       Mẫu FOC
        PaymentSpareSample,//3.       Spare tính tiền
        SpareFOCSample//4.       Spare FOC
    }
    public enum ProductionNormType
    {
        Proposal, //Báo giá
        SampleProduction, //Sản xuất mẫu
        MassProduction, //Sản xuất đại trà
        ProductionContract, //Sản xuất theo hợp đồng
        ProductionCompany, //Sản xuất cho công ty
        Template, //BĐM mẫu (không sản xuất)
        Maintenance //Bảo hành bảo trì
    }
    public enum MMProposalItemStatus
    {
        New,
        Approved,
        InProcess,
        Processed,
        Completed,
        Cancel
    }
    public enum MMProposalBatchStatus
    {
        New,
        Approved,
        Canceled,
        InProcess,
        Processed,
        Completed
    }
    #endregion

    public enum MMProductionNormStatus
    {
        New,
        Validated,
        UnValidated,
        Approved,
        UnApproved,
        Edit
    }

    public enum LabouringConfigDateType
    {
        Date,
        Month,
        Year
    }

    public enum SaleOrderPaymentTimePaymentType
    {
        Deposit,
        Payment
    }
    public enum OperationDetailPlanCancelStatus
    {
        New,
        Complete
    }

    public enum ProposalPaymentTimePaymentType
    {
        Deposit,
        Payment,
    }

    public enum SaleOrderPaymentTimeStatus
    {
        New,
        InvoiceOut,
        Completed,
        Paid,
        Canceled
    }

    public enum ProposalPaymentTimeStatus
    {
        New,
    }

    public enum PaymentTermType
    {
        Day,
        DateInMonth
    }

    public enum GELocationType
    {
        City,
        Country,
        District,
        Region,
        StateProvince,
        Ward
    }

    public enum CustomerPaymentTimePaymentType
    {
        SODeposit,
        SaleOrder,
        Invoice
    }
    //TNDLoc [ADD][07/11/2015][Sale Payment Process],END
    public enum PurchaseOrderPaymentTimePaymentType
    {
        Deposit,
        Payment
    }

    public enum PurchaseOrderPaymentTermRequest
    {
        Normal,
        Other
    }

    public enum PurchaseOrderPaymentTimeStatus
    {
        New,
        InvoiceOut,
        Completed,
        Paid,
        Canceled
    }

    public enum PaymentProposalItemType
    {
        PODeposit,
        PurchaseOrder,
        InvoiceIn,
        FeePayment,
        PurchaseOrderInvoiceInDetail,
        Order,
        NghiepVuKhac
    }

    public enum ReportRP077ObjectType
    {
        PurchaseOrder,
        InvoiceIn,
        SupplierPayment
    }

    //TNDLoc [ADD][09/11/2015][Production Norm Operation],START
    public enum ProductionNormOperationStatus
    {
        New,
        Approved
    }
    //TNDLoc [ADD][09/11/2015][Production Norm Operation],END
    public enum ReportRP096ObjectType
    {
        SaleOrder,
        Invoice,
        CustomerPayment
    }

    public enum BatchProductType
    {
        //    MassProduction,
        //    PaymentSample,
        //    Proposal,
        //    Product,
        //    LumberProduct
        Roundwood,
        Lumber
    }

    public enum BatchProductGroup
    {
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        SemiProduct,
        GeneralMaterial
    }
    public enum ReceiptPurchaseType
    {
        Roundwood,
        Lumber,

    }
    public enum ProductAttributeGroup
    {
        WoodType,
        Quality,
        TTMT,
        COLOR,
        PackingMaterialSpeciality,
        PackingMaterialSize,
        PackingMaterialWeightPerVolume,
        Speciality,
        HTType,
        AddMaterial
    }
    public enum LevelNecessarySkills
    {

    }
    public enum AllocationProposalStatus
    {
        New,
        Approved,
        Confirmed,
        Shipping,
        Finish,
        Canceled,
        CantPurchase
    }
    public enum AllocationProposalProductType
    {
        FreshLumber,
        RoundWood,
        Hardware,
        IngredientPackaging,
        IngredientPaint,
        Equipment,
        Other,
        DryLumber,
        GeneralMaterial,
        Roundwood,
        Steel,
        Meterial,
        SemiProduct
    }
    public enum ICShipmentType
    {
        OutputWorkAsset
    }
    public enum AllocationProposalNewFrom
    {
        Normal,
        FromBatchLumber,
        FromBatchProductScheduleEquipment,
        FromBatchProductScheduleHW,
        FromBatchProductSchedulePackaging,
        FromBatchProductSchedulePaint,
        FromBatchProductScheduleWood,
        FromBatchProductSheduleInstrument,
        FromBatchProductSheduleEquipment,
        FromGeneralMaterial,
        FromSteel,
        FromMeterial,
        FromBatchProductScheduleSemiProduct
    }

    public enum BatchProductProductionNormItemResourceType
    {
        Manafacturing,
        OutSourcingAndManafacturing,
        OutSourcing
    }

    public enum ChangeBOMInformationStatus
    {
        New,
        Validated,
        Approved
    }

    public enum ModifiedStatus
    {
        New,
        Modified,
        Delete
    }

    public enum PurchasePlanItemPurchaseType
    {
        DryLumber,
        Roundwood,
        FreshLumber,
        InventoryStock
    }

    public enum CreateFrom
    {
        BatchProduct,
        ImportBalance
    }

    public enum OverallInsideDimensionConfigType
    {
        Length,
        Height,
        Width
    }

    public enum OperationType
    {
        Plus,
        Multi,
        Minus,
        Split,
        ChiTietTuPhach,
        RapChiTiet,
        Cum,
        RapTPTuChiTiet,
        RapCum,
        ThanhPham,
        ChiTiet
    }

    public enum AllocationProposalType
    {
        BOM,
        BeyondBOM,
        OutOfBOM,
        Other
    }
    public enum ReceiptProductType
    {
        FreshLumber,
        DryLumber
    }
    public enum OverallInsideDimensionConfigOperationType
    {
        OverallInsideDimensionConfigOperationType
    }

    public enum PurchaseOrderChannel
    {
        HinterLand,
        Import
    }

    public enum InvoiceInChannel
    {
        HinterLand,
        Import
    }
    public enum ShipmentProposalType
    {
        MassProduction,
        PaymentSample,
        FOCSample,
        PaymentSpareSample,
        SpareFOCSample,
        OutSourcing,
        Other,
        Roundwood,
        FreshLumber,
        DryLumber,
    }
    public enum InvoiceSOType
    {
        MassProduction,
        PaymentSample,
        FOCSample,
        PaymentSpareSample,
        SpareFOCSample,
        OutSourcing,
        Other,
        Roundwood,
        FreshLumber,
        DryLumber,
    }
    public enum ShipmentProposalProductType
    {
        Roundwood,
        FreshLumber,
        DryLumber,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        SemiProduct,
        Other,
        Verneer,
        ArtificialBoard,
        Product,
        Equipment
    }
    public enum ProposalAPType
    {
        Lumber,
        Roundwood,
        Product,
        Verneer,
        ArtificialBoard,
        Asset,
        Equipment,
        Ingredient,
        Material,
        IngredientPaint,
        Hardware,
        Other
    }
    public enum ProposalItemStatus
    {
        Canceled
    }
    public enum ReceiptAcceptanceType
    {
        Acceptance,
        None,
        Allocation,
        BatchProduct,
        RoundWoodSplit,
        LumberCDAcceptance,
        RoundWoodCDAcceptance,
    }
    public enum ShipmentAcceptanceType
    {
        Acceptance,
        Allocation,
        BatchProduct,
        None,
        RoundWoodSplit,
        Production,
        LumberCDAcceptance,
        RoundWoodCDAcceptance
    }
    public enum PurchaseOrderReceiptType
    {
        Lumber,
        Roundwood,
        Product,
        Verneer,
        ArtificialBoard,
        OutSourcing,
        WoodMDFOutSourcing,
        MechanicOutSourcing,
        AlloyCover,
        Repair,
        IngredientPaint
    }
    public enum CancelPurchaseOrderStatus
    {
        New,
        Complete

    }
    public enum ProductionCostType
    {
        ProductionCost,
        ProductionCostWood
    }
    public enum AdvanceRequestStatus
    {
        New,
        Complete,
        Advanced,
    }
    public enum ChangeBOMItemType
    {
        NewWoodParent,
        NewWoodChild,
        NewPaint,
        NewHW,
        NewPackagingParent,
        NewPackagingChild,
        Update,
        Delete
    }
    public enum SaleType
    {
        National,
        International
    }
    public enum ProductGroupName
    {
        Indoor,
        Outdoor
    }
    public enum ReceiptCDAcceptanceType
    {
        RoundWood,
        Lumber
    }
    public enum CurrencyNo
    {
        VND,
        USD,
        EURO,
        RMB
    }

    public enum BatchProductResourceType
    {
        Manafacturing,
        OutSourcingAndManafacturing,
        OutSourcing
    }
    public enum AccountingFormulaItemType
    {
        N,
        C
    }
    public enum PaymentTermItemPaymentType
    {
        Payment,
        Deposit
    }
    public enum PaymentTermItemPaymentDate
    {
        IsAfterDelivery,
        IsBeforeDelivery,
        IsContract,
        IsInvoiceIn
    }
    public enum AccountingFormulaType
    {
        BCDKT,
        LCTT,
        KQHDKD
    }
    public enum BatchProductCancelStatus
    {
        New,
        Complete
    }

    public enum TemplateStatus
    {
        New,
        Completed,
        Approved,
        Edit
    }

    public enum TemplateItemType
    {
        Phase,
        WorkGroup,
        Work,
        Section
    }

    public enum TemplateItemWorkType
    {
        Work,
        Subcontractor,
        Production,
        Purchase
    }

    public enum SaleOrderItemWorkProductType
    {
        Material,
        Asset,
        Work
    }

    public enum ProductItemType
    {
        Product,
        Material,
        Asset,
        Work,
        Service
    }
    public enum ProductWorkItemType
    {
        Product,
        Material,
        Asset,
        Work
    }
    public enum RoutingType
    {
        ByOperationPlan,
        ByBatchProduct
    }
    public enum EstimateItemProductType
    {
        Material,
        Cost,
        Work,
        Section,
    }

    public enum EstimateStatus
    {
        New,
        Completed,
        Propasaled,
        Approved,
    }

    public enum ProjectStatus
    {
        New,
        Approved,
        Estimated,
    }

    public enum ProposalStatus
    {
        New,
        Approved,
        Confirmed,
        Canceled,
        Ordered,
    }

    public enum ProposalItemProductType
    {
        Material,
        Cost,
        Work,
        Section,
        Asset
    }

    public enum ProposalItemType
    {
        Work,
        Subcontractor,
        Purchase,
        Production,
        Cost,
    }

    public enum ProductWorkType
    {
        Work,
        Subcontractor,
        Material,
        Asset
    }

    public enum WorkQtyType
    {
        TS,
        PN,//Nghỉ phép năm
        NKP,
        NCD,
        NPN,
        LE, //Nghỉ lễ
        NCP1P2, //Nghỉ 1/2 ngày có phép
        NKP1P2, //Nghỉ không phép 1/2 ngày
        NCP,//Nghỉ có phép
        NCL, //Nghỉ phép 1/2 chế độ
        PN1P2,//Nghỉ phép năm 1/2
        BonusTime,//Cộng thêm giờ
        LeavedaySpecial//Nghỉ đặc biệt

    }

    public enum DeliveryPlanStatus
    {
        New,
        Verified,
        Completed,
        Canceled,
        Shipmented
    }

    public enum AllocationStatus
    {
        New,
        Complete
    }

    public enum CanceledDeliveryPlanStatus
    {
        New,
        Complete
    }

    public enum ConfigSalesTargetStatus
    {
        New,
        Approved
    }

    public enum ConfigSalesTargetType
    {
        Week,
        Month,
        Quarterly,
        Year,
        FromDateToDate
    }

    public enum ReceiptVoucherStatus
    {
        New,
        Completed,
        Canceled
    }

    public enum CustomerPaymentStatus
    {
        New,
        Completed,
        Canceled
    }

    public enum ReceptionStatus
    {
        New,
        Complete
    }

    public enum DeliveryPlanType
    {
        Week,
        Day,
        Transfer
    }

    public enum DeliveryPlanAddNewType
    {
        New,
        Incomplete
    }

    public enum DeliveryPlanItemStatus
    {
        New,
        Deliveried
    }

    public enum ObjectType01
    {
        WorkPlan,
        WorkSale,
    }

    public enum TaskStatus
    {
        New,
        Completed,
        Canceled,
    }

    public enum ProductCriteriaStatus
    {
        New,
        Completed,
        Checked
    }

    public enum CollectionItemType
    {
        Product,
        Material,
        Work
    }

    public enum SegmentBudgetControl
    {
        None,
        Warning,
        Limit,
        NotAllowed
    }

    public enum RevenueBudgetStatus
    {
        New,
        Approved,
        Canceled
    }
    public enum CostBudgetStatus
    {
        New,
        Approved,
        Canceled
    }

    public enum ActualCostBudgetStatus
    {
        New,
        Approved,
        Canceled
    }

    public enum SegmentType
    {
        Revenue,
        Cost,
        SaleCost,
        ManageCost,
        FinanceRevenue,
        FinanceCost,
        OtherIncome
    }

    public enum ReportItemType
    {
        Item,
        Group
    }

    public enum ConfigSalesTargetApplicableSubjects
    {
        Company,
        Branch,
        Employee
    }

    public enum ProductCriteriaDiscountType
    {
        Percent,
        Price
    }

    public enum DeliveryPlanTruckSource
    {
        Company,
        Outsource
    }

    public enum AdvanceRefundStatus
    {
        New,
        Complete,
        Canceled
    }

    public enum AdvanceRefundPaymentType
    {
        Receipt,
        Payment
    }


    public enum AdvanceRefundType
    {
        HasInvoice,
        NoneInvoice,
        DirectPayment
    }

    public enum AcceptanceStatus
    {
        New,
        Complete,
    }

    public enum ProductTemplateType
    {
        Available,
        Design,
    }

    public enum DeliveryPlanItemProductTemplateType
    {
        Available,
        Design,
        Decorative
    }

    public enum SaleWorkStatus
    {
        New
    }
    public enum SaleOrderDocumentType
    {
        Contract,
        Annex,
        SaleOrder
    }
    public enum BankTransactionFromType
    {
        Bank,
        CashFund
    }
    public enum BankTransactionToType
    {
        Bank,
        CashFund
    }
    public enum SaleOrderItemGrantedFrom
    {
        Production,
        Purchase,
        Inventory,
        Service
    }
    public enum AssembleProductStatus
    {
        New,
        Approved
    }

    public enum DisassembleProductStatus
    {
        New,
        Approved
    }

    public enum BillOfLadingStatus
    {
        New,
        Complete
    }

    public enum PaymentVoucherPurpose
    {
        SupplierPayment,
        Payment,
        AdvanceRefund,
        DirectPayment,
        LoanReceipt,
        BillOfLading,
        PaymentAdvanceRequest,
        CustomerRepaid

    }

    public enum TransferItemType
    {
        Material,
        Product
    }

    public enum ShipmentItemType
    {
        Material,
        Product
    }

    public enum KPIFormStatus
    {
        New,
        Approved,
        CancelApply
    }

    public enum KPIRegistrationStatus
    {
        New,
        Approved,
        Evaluated
    }

    public enum KPIEvaluationStatus
    {
        New,
        Approved
    }

    public enum LoanReceiptProfitMethod
    {
        OriginalDebt,
        OutstandingDebt,
        FixedNeedles,
        OriginalPaypal,
        OutstandingDebtIncreasing
    }

    public enum KPIFormType
    {
        Company,
        Branch,
        Department,
        DepartmentRoom
    }

    public enum ConfigSalesFormulaPayrollStatus
    {
        New,
        Approved
    }

    public enum ConfigSalesFormulaPayrollType
    {
        Management,
        Seller
    }

    public enum CircumstancesRewardType
    {
        Sales,
        SalesTargetOfMonth,
        OverTarget,
        TrimesterTarget
    }

    public enum ConfigSalesFormulaPayrollItemDependenceType
    {
        Company,
        Branch
    }
    public enum ReceiptSemiProductType
    {
        Product,
        SemiProduct,
        BatchProduct
    }

    public enum ProductIdentifiedEquipmentStatus
    {
        Using,
        StopUsing,
        SuspendedUsing
    }
    public enum ProcessType
    {
        MassProduction,
        Proposal
    }
    public enum TransferProposalStatus
    {
        New,
        Approved,
        CancelApproved,
        Transferring,
        Completed
    }
    public enum MaterialConfigCalByType
    {
        Circumcircle,
        Longest
    }
    public enum DataViewPermissionAppStaff
    {
        DataViewPermissionAppStaffType
    }

    public enum ADDataViewPermissionAppStaffGroupType
    {
        UserGroup,
        User
    }

    public enum RPSaleOrderType
    {
        Vinmus,
        Vinmo,
        TinhKhac,
        TPHCM
    }

    public enum PrintProposal
    {
        Estimate,
        Proposal
    }

    public enum ProposalQuotationType
    {
        Official,
        Estimates
    }

    public enum AdvanceRequestType
    {
        UL,
        UCT,
        ULMH,
        ULH,
        Loan,
        Construction
    }

    public enum AdvanceRequestItemPaymentType
    {
        AddToSalary
    }

    public enum BankTransactionCreateFrom
    {
        Normal,
        NewFromPayRoll,
        LoanReceipt,
        DirectPayment,
        NewFromAdvanceRefund,
        PaymentAdvanceRequest,
        CustomerRepaid,
        SupplierRepaid,
        BillOfLading
    }
    public enum AllocationCostStatus
    {
        New,
        Complete
    }

    public enum AllocationCostCriterion
    {
        Qty,
        Amount
    }

    public enum PreDeliverySurvey
    {
        PreDeliverySurveyTrue,
        PreDeliverySurveyFalse
    }

    public enum SalesOrderDeliveryFloorType
    {
        Ground,
        Upstairs
    }

    public enum CustomerPaymentProposalNewType
    {
        FromPaymentTerm,
        FromManual
    }

    public enum RPSaleOrder_ProposalPriceType
    {
        TPHCM,
        TinhKhac
    }
    public enum MaterialConfigType
    {
        m3,
        m2,
        Packing
    }
    public enum ProductionNormCostFactorProductGroup
    {
        SemiProduct,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        Other
    }
    public enum ReceiptVoucherPurpose
    {
        AdvanceRefund,
        Normal,
        SupplierRepaid
    }


    public enum RPSaleOrder_PrintFormType
    {
        Draft,
        Official
    }
    public enum CarcassBOMGetType
    {
        Carcass,
        Color
    }
    public enum ProductionNormStatus
    {
        New,
        Approved,
        Edit,
        None,
        Canceled
    }
    public enum RecruitmentNeedStatus
    {
        New,
        Approved,
        NotApproved
    }

    public enum DeliveryPlanFromType
    {
        SaleReturn,
        Tranfer
    }

    public enum ProductPackageMethodType
    {
        FinalProduct,
        ProductDetails,
        MixOthers
    }

    public enum ProductPackageStatus
    {
        New,
        Approved
    }

    public enum AdjustIncreaseOrDecreaseAssetType
    {
        Increase,
        Decrease
    }

    public enum CustomerCRMType
    {
        Prospect,
        Customer
    }
    public enum EmployeePayRollCalculatedWorkType
    {
        Default,
        TableWork
    }
    public enum InProgressStatisticType
    {
        Opening,
        Ending
    }

    public enum ProductionCostAllocationType
    {
        PhanbotheoM3,
        PhanbotheoM2,
        Tructiep,
        PhanbotheoSLSX,
        Phanbotheoheso,
        Theoyeutokhac,
    }
    public enum ProductionNormStatusType
    {
        WoodStatus,
        HardwareStatus,
        PackingMaterialStatus,
        PaintStatus,
        GeneralMaterialStatus,
        CarcassProccessStatus,
        ColorProccessStatus
    }
    public enum PriceType
    {
        Product,
        BatchProduct

    }
    public enum MergeBOMChangeType
    {
        WoodStatus,
        HardwareStatus,
        PaintStatus,
        PackingMaterialStatus,
        GeneralMaterialStatus,
        CarcassProccessStatus,
        ColorProccessStatus
    }

    public enum MergeBOMChangeActionType
    {
        New,
        Update,
        Delete
    }

    public enum MMFormatType
    {
        Group
    }

    public enum ProductionCompletionTimeConfigType
    {
        Before, After
    }

    public enum ImageFolderType
    {
        SampleItemImage,
        TechnicalDrawing,
        QCDefectivePhotos,
        QCPackingPhotos
    }

    public enum ProductionNormApproveLogType
    {
        CarcassProccessStatus,
        ColorProccessStatus,
        GeneralMaterialStatus,
        HardwareStatus,
        PackingMaterialStatus,
        PaintStatus,
        WoodStatus
    }
    public enum ProductionNormApproveLogUpdateType
    {
        All, Some, Normal
    }
    public enum RecruitmentPlanStatus
    {
        New,
        Approved,
        NotApproved
    }
    public enum ProductionCostCollectType
    {
        Tructiep
    }
    public enum PostedTransactionStatus
    {
        Posted,
        UnPosted
    }
    public enum LeaveApplicationStatus
    {
        New,
        Approve,
        Unapprove
    }
    public enum OverTimeStatus
    {
        New,
        Approved,
        NotApproved,
        Confirmed
    }

    public enum PriceCalculationMethod
    {
        Average,
        Specific,
    }

    public enum BonusSaleStatus
    {
        New,
        Approved
    }
    public enum BonusSaleItemPercentageRetainedType
    {
        TT,
        CN
    }

    public enum PaymentProposalType
    {
        PaymentProposal,
        AdvanceRefund
    }

    public enum PercentageRetainedType
    {
        Manager,
        Employee
    }

    public enum AllocationCostType
    {
        Import,
        LumberOutSourcing
    }

    public enum ProductApplyPriceStatus
    {
        New,
        Verified,
        Approved
    }

    public enum ProductApplyPriceType
    {
        SalePrice,
        PurchasePrice
    }

    public enum AdvanceRefundItemInvoiceType
    {
        HasInvoice,
        NoneInvoice
    }

    public enum AdvanceRefundItemInvoiceStatus
    {
        Allowable,
        NotAllowable
    }

    public enum AdvanceRefundItemRequestStatus
    {
        Allowable,
        NotAllowable
    }

    public enum ListAccountBankStatus
    {
        New,
        Complete
    }
    public enum EmployeeWorkingForm
    {
        Probationary,
        Apprentice,
        Official
    }

    public enum HRFormAllowanceType
    {
        CaNhan,
        CoDinh,
        MucChung
    }

    public enum HRFormAllowanceNameType
    {
        Phucapdienthoai,
        Phucapchuyencan,
        Phucapxang,
        Phucapnhao,
        ThuongKPI,
        Phucaptrachnhiem,
        Phucapthuviec,
        Phucapthamnien,
        Phucapcongtac,
        Phucapcom,
        Phucapcadem,
        PCBaoduongxe,
        PhuCapDiTinh,
        Chucvu,
        Capbac,
        Dochai,
        Tuytson,
        Ngoixe,
        Orther,
        Comtangca,
        Comdicongtrinh,
        Phucaptaynghe,
        Phucapmuahang,
        Phucaptangca,
        Phucaptiendo,
        Phucapchatluong,
        Phucapantoanlaodong,
        PhucapfiveS,
        Phucapbaocao
    }

    public enum FromMasterData
    {
        Calamviec,
        Ditre,
        Tangca,
        DanhMucTinhLuong,
        Phucap
    }

    public enum EmployeePayrollFormulaCalculation
    {
        Nomal,
        TruChuNhat,
        All,
        TruCuoiTuan,
    }

    public enum EmployeeControllerType
    {
        BHXH,
        Working,
        Resigned
    }

    public enum ValidatePayRoll
    {
        KPI,
        Allowance,
        Discipline,
        PieceWage
    }

    public enum DisciplineDocumentType
    {
        Phone,
        Other
    }

    public enum DocumentCreateFrom
    {
        PurchaseReceipt,
        InvoiceInternalReceipt,
        TransferReceipt,
        InvoiceIn,
        Invoice
    }

    public enum VehicleStatus
    {
        Using,
        Guarantee,
        NotUse
    }

    public enum ProductTemplateRootType
    {
        Official,
        Temporary
    }

    public enum ProductTemplateStatus
    {
        New,
        Complete,
        Canceled
    }

    public enum MoneyChangeStatus
    {
        New,
        Approved,
        Completed
    }

    public enum ReceptionType
    {
        Return,
        Lost
    }

    public enum SalaryCalculationStatus
    {
        New,
        Posted,
        UnPosted
    }

    public enum AdvanceRequestItemLoanDetailStatus
    {
        New,
        Paid
    }

    public enum PurchaseContractStatus
    {
        New,
        Inprogress,
        Completed
    }

    public enum PurchaseContractType
    {
        Root,
        Appendix
    }

    public enum SaleContractType
    {
        OriginalContract,
        ContractAddendum
    }

    public enum ReturnShippingType
    {
        Return,
        ReplaceDifferenceProduct,
        ReplaceSameProduct
    }

    public enum InventoryStockPurchaseStatus
    {
        Late
        , OnTime
        , EnoughInventory
    }

    public enum EInvoiceGeneralStatus
    {
        New,
        Completed,
        Value1,
        Value2,
        Value3,
        Value4,
        Value5,
        Value6,
        Value7,
        Value8,
        Value9,
        Value10,
        Value11,
        Value12
    }
    public enum EInvoiceGeneralType
    {
        Original = 1,
        Delete = 7,
        Replace = 3,
        Adjust = 5
    }

    public enum SalesmanType
    {
        MainSeller,
        SubSeller
    }

    public enum OutputVATDocumentType
    {
        InvoiceType1,
        InvoiceType2,
        InvoiceType3,
        InvoiceType4,
        InvoiceType5,
        InvoiceType6
    }

    public enum AllocationPlanItemGroup
    {
        Material,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        GeneralMaterial,
        OtherMaterial,
        SemiProduct
    }

    public enum PurchasePlanType
    {
        GeneralMaterial,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        Material,
        OtherMaterial,
        SemiProduct
    }

    public enum ProductionNormItemGroup
    {
        Product,
        SemiProduct,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        GeneralMaterial,
        Material,
        OtherMaterial
    }

    public enum AllocationPlanItemStatus
    {
        New,
        Approved,
        Planed,
        Allocated,
        Close,
        Canceled
    }

    public enum MaterialType
    {
        Material,
        OtherMaterial
    }

    public enum InvoiceTypeCombo
    {
        Sell,
        Purchase
    }
    public enum TemplateParamColumn
    {
        ADTemplateParamNo,
        ADTemplateParamName,
        ADTemplateParamValue,
        ADTemplateParamIsDisplay,
        FK_ADTemplateID,
        ADTemplateParamOrder,
        ADTemplateParamDataType,
        ADTemplateParamLookupEdit,
        ADTemplateParamColumns,
        ADTemplateParamFilter,
        ADTemplateParamParentField,
        ADTemplateParamFieldRelation,
        ADTemplateParamIsNotNull
    }

    public enum DataType
    {
        Date,
        DateTime,
        Number,
        bit,
        boolean,
        currentuser,
        currentbranch,
        multiselect,
        Text,
    }
    public enum BillOfLadingImportExportType
    {
        Export,
        Import
    }

    public enum EmployeePayrollFormulaHandleTypeCombo
    {
        FirstLast,
        Double
    }
    public enum ImportAndExportReasonType
    {
        Import,
        Export,
    }
    public enum ProductionPlanningItemStatus
    {
        New,
        Planed,
        Complete,
        Canceled,
        Close
    }

    public enum BatchProductItemOutSourcingGroup
    {
        Product,
        SemiProduct
    }

    public enum BatchProductItemOutSourcingStatus
    {
        New,
        Approved,
        Close
    }

    public enum DiscountProgramStatus
    {
        Approved,
        New
    }

    public enum DiscountProgramType
    {
        Discount,
        Promotion,
        BonusSales,
        PaymentBonus
    }

    public enum DiscountProgramMethodType
    {
        Direct,
        Postpaid
    }

    public enum DiscountProgramApplyOn
    {
        UnitPrice,
        Percent
    }

    public enum DiscountProgramItemTargetType
    {
        Quarter1,
        Quarter2,
        Quarter3,
        Quarter4,
        Year
    }

    public enum DiscountProgramApplyType
    {
        SaleOrder,
        Product
    }

    public enum CalculateDiscountStatus
    {
        New,
        Approved
    }

    public enum SalaryEvaluationStatus
    {
        New,
        Approved,
        Apply
    }

    public enum BatchProductAdjustLogType
    {
        CloseBatchProduct,
        CloseBatchProductItem,
        ChangeBatchProductItemQty,
    }

    public enum BatchProductItemOutSourcingResourceType
    {
        OutSourcing,
        Inventory
    }
    public enum SocialInsuranceDeclarationType
    {
        Reduction,
        Increase,
        Arrears
    }

    public enum SocialInsuranceDeclarationItemObject
    {
        BHYT,
        BHXH,
        BHTN,
        BHTNLĐ,
        BNN
    }

    public enum SocialInsuranceDeclarationStatus
    {
        New,
        Approved
    }

    public enum EmployeeGender
    {
        Male,
        Female
    }

    public enum LicenseStatus
    {
        NoConnecttion,
        Active,
        Inactive
    }

    public enum BlockColumnOperator
    {
        M3,
        Length
    }
    public enum FeePaymentFeeConfigType
    {
        Sale,
        Purchase,
        Commission
    }
    public enum InvoiceCommissionType
    {
        Percent,
        Quantity,
    }

    public enum DepartmentGroup
    {
        ProductNo,
        SemiProductNo,
        IngredientNo,
        HardwareNo,
        IngredientPaintNo,
        IngredientPackagingNo,
        EquipmentNo,
        MMTBNo,
        VPPNo,
        CarNo,
        ServiceNo,
        DeviceNo,
        WorkNo,
        SectionNo
    }

    public enum ProductionCostInProgressClassifyType
    {
        Dodangtpcongdoan,
        Dodangnguyenlieusudung
    }

    public enum ProductionCostInProgressCalType
    {
        Theotylehoanthanh,
        Theotylehoanthanhvanhatkysanxuat,
        Theotiletieuhao,
        Theodinhmuc,
        Khongconhapthanhphamcongdoan
    }

    public enum GroupType
    {
        AllocationReceipt,
        Receipt,
        Shipment,
        ReceiptError,
    }

    public enum ProductionNormCostFactorGroup
    {
        NVL,
        NC,
        CPC
    }
    public enum ProductionNormCostFactorSourceData
    {
        Norm,
        Ledger
    }

    public enum ProposalSaleType
    {
        National,
        International
    }

    public enum SaleOrderToolbarActionName
    {
        NewFromWood,
        NewFromOther
    }


    public enum EquipmentTransferItemType
    {
        Receipt,
        Shipment
    }

    public enum ReturnSupplierReceiptType
    {
        Lumber,
        Roundwood,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        Equipment,
        Verneer,
        ArtificialBoard,
        VVP,
        Product,
        Other,
        AlloyCover,
        MechanicOutSourcing,
        Dichvuvagiacong,
        BothProductAndSemiProduct,
        OutSourcing,
        Rent,
        Repair
    }

    public enum InvoiceProductType
    {
        Roundwood,
        FreshLumber,
        DryLumber,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        SemiProduct,
        Other,
        Verneer,
        ArtificialBoard,
        Kitchen,
        Interior,
        AvailableInterior,
        Product
    }

    public enum CancelVoucherType
    {
        Roundwood,
        FreshLumber,
        DryLumber,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        SemiProduct,
        Other,
        Verneer,
        ArtificialBoard,
        Product,
        Kitchen,
        Interior,
        AvailableInterior
    }

    public enum ReturnSupplierType
    {
        Manual,
        FromReceipt,
        //FromInvoiceIn
    }

    public enum EmployeeMeasureUnitType
    {
        Hour,
        Month
    }

    public enum AllowanceConfigGroup
    {
        Percent,
        General,
        Other,
        NKP, //Nghỉ không phép'
        NCP1P2, //1/2 ngày có phép
        NCP, //Nghỉ có phép'
        PN, //Nghỉ phép năm'
        NCL, //Nghỉ phép 1/2 chế độ'
        PN1P2, //Nghỉ phép năm 1/2
        NKP1P2, //Nghỉ không phép'
        TC, //Trừ cơm'
        CTCN, //Công ty cho nghỉ'
        NCD, //Nghỉ cúp điện
        NCDO, //Nghỉ chế độ'
        KTC, //Xuống ca không trừ cơm'
        LeavedaySpecial //Nghỉ đặc biệt
    }

    public enum EmployeeTransmitStatus
    {
        New,
        Approved
    }

    public enum EmployeeTransmitItemMeasureUnitType
    {
        Hour,
        Month
    }

    public enum ProductionPlanningItemSources
    {
        Process,
        Purchase,
        InventoryStock,
        OutSourcing
    }

    public enum QuarterRewardStatus
    {
        Effective, //ngày hiệu lực
        Expiry     //ngày kết thúc hiệu lực
    }

    public enum EmployeeContractStatus
    {
        Invalid,
        Effective
    }

    public enum TimesheetEmployeeLateType
    {
        Late,
        Early
    }

    public enum EmployeeATMCardManageStatus
    {
        Approved,
        New
    }

    public enum ATMCardPayrollStatus
    {
        New,
        Approved
    }
    public enum AllocationOperationConfigType
    {
        IsPlan,
        IsStock,
        IsPlanAndStock,
        IsPlanOrStock,
        AllOperation
    }

    public enum ShowSocialInsuranceDeclarationType
    {
        Doing,
        New,
        Eligible,
        Unqualified
    }

    public enum ProductConversionItemType
    {
        Source,
        Target
    }

    public enum ProductConversionType
    {
        ManyTarget,
        OnlyTarget
    }

    public enum ProductConversionStatus
    {
        New,
        Complete,
    }

    public enum ProductConversionProductType
    {
        Product,
        LumberOrWood,
        OtherProduct,
        Bamboo
    }

    public enum ProductionNormPrintType
    {
        All,
        SemiProduct,
        Hardware,
        IngredientPaint,
        IngredientPackaging,
        GeneralMaterial,
        Material    }

    public enum ProductConversionRuleOfAllocationFactorGeneration
    {
        Handmade,
        AccordingToQuanity
    }

    public enum ProductUsingMethod
    {
        NoneSpecific,
        SpecificEquipment,
        SpecificAsset
    }

    public enum ProductionPlanningSources
    {
        Process
    }

    public enum UnfinishedConstructionCostStatus
    {
        New,
        Doing,
        Complete,
        ChuyenTSCD
    }

    public enum InvoiceProductSource
    {
        CompanyProduction,
        Outsourcing
    }

    public enum ProposalSourceSellingPriceMethod
    {
        Typing,
        Config
    }

    public enum ConversionProposalStatus
    {
        New,
        Completed
    }

    public enum ConfigMaterialShipmentUtilityType
    {
        ByMasterData,
        BySemiProduct
    }

    public enum BarcodeStatus
    {
        New,
        Printed
    }

    public enum EInvoiceConfigPartnerType
    {
        BKAV,
        MInvoice,
        Viettel
    }

    public enum SaleReturnProductType
    {
        Product
    }

    public enum RetailVATStatus
    {
        New,
        Completed,
        PostedVAT
    }

    public enum SaleOrderSaleType
    {
        National,
        International
    }

    public enum DocumentTaxEntryType
    {
        ThueGTGTDuocKhauTru,
        ThueGTGTPhaiNop
    }    
    public enum PaintProcessesStatus
    {
        New,
        Approve
    }
    public enum PositionType
    {
        Range,
        Wire,
        Line
    }
    public enum UpdatePositionStatus
    {
        New,
        Approved
    }
}
