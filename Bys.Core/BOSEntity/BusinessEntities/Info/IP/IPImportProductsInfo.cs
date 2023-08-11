using BOSLib;

namespace BOSERP
{
    public class IPImportProductsInfo : BusinessObject
    {
        public string ICProductSortOrder { get; set; }
        public string ICDepartmentNo { get; set; }                  //Ngành hàng
        public string ICProductGroup1No { get; set; }               //Nhóm hàng 1
        public string ICProductGroup2No { get; set; }               //Nhóm hàng 2
        public string ICProductSupplierNo { get; set; }             //Mã NCC
        public string ICMeasureUnitName { get; set; }               //Đơn vị tính
        public decimal ICProductSupplierPrice { get; set; }         //Giá mua
        public string ICProductSupplierNumber { get; set; }         //Mã sản phẩm NCC
        public string ICProductNo { get; set; }                     //Mã sản phẩm
        public string ICProductName { get; set; }                   //Tên sản phẩm (tiếng anh)
        public string ICProductDesc { get; set; }                   //Mô tả
        public bool ICProductActiveCheck { get; set; }              //Hoạt động
        public decimal ICProductLength { get; set; }                //Dài
        public decimal ICProductHeight { get; set; }                //Cao/Dày
        public decimal ICProductWidth { get; set; }                 //Rộng
        public decimal ICProductWeight { get; set; }                //
        public decimal ICProductBarCode { get; set; }               //Mã vạch
        public decimal ICProductStockMin { get; set; }              //Số lượng tối thiểu
        public decimal ICProductStockMax { get; set; }              //Số lượng tối đa
        public decimal ICProductPrice01 { get; set; }               //Giá bán
        public string ICProductType { get; set; }                   //Loại Sản phẩm
        public string ICProductModelNo { get; set; }                //
        public string ICProductGuaranteeTerm { get; set; }
        public int ICProductGuaranteeMonths { get; set; }           //Số tháng bảo hành
        public string ICProductDepreciationMethod { get; set; }     //Kiểu phân bổ
        public int ICProductDepreciationMonths { get; set; }        //Số tháng phân bổ
        public string ICProductComment { get; set; }                //Ghi chú sản phẩm
        public string ICProductAccountNo { get; set; }              //TK Tồn kho
        public string ICProductAttributeWoodTypeName { get; set; }  //Loại gỗ/ Loại nguyên liệu
        public string ICProductAttributeColorName { get; set; }     //Màu sơn
        public string ICProductPaintNoOfManufacture { get; set; }   //Mã màu săc NSX
        public string ICProductAttributeFinishingName { get; set; } //Xác định hoàn thiện
        public string ICProductJoinery { get; set; }                //Ghi chú mộng
        public string ICProductSizeAndSpecifiCations { get; set; }  //Kích thước/ quy cách
        public string ICProductPurchaseType { get; set; }           //Loại mua hàng
        public string ICProductCode { get; set; }                   //Mã code
        public string ICProductNoOfOldSys { get; set; }             //Mã hệ thống cũ
        public string ICProductCustomerNumber { get; set; }         //Mã SP KH/ Mã SP đối tác
        //public string FK_GECountryID { get; set; }        
        public string ICProductName2 { get; set; }                  //Tên SP tiếng việt (Tên HDDT)
        public string ICProductWoodTypeAttribute { get; set; }      //Loại gỗ khác/ Nguyên liệu khác
        public string ICProductColorAttribute { get; set; }         //Màu sơn khác
        //FK_ICProdAttPackingMaterialSpecialityID
        //FK_ICProdAttPackingMaterialSizeID
        //FK_ICProdAttPackingMaterialWeightPerVolumeID
        //FK_ICProductAttributeSemiProductSpecialityID
        public string ICProductDepreciationCostAccountNo { get; set; }  //Tài khoản chi phí
        public decimal ICProductOriginalAmount { get; set; }            //Nguyên giá
        public decimal ICProductDepreciatedAmount { get; set; }         //Giá trị đã khấu hao
        public string ICProductDepreciationAccountNo { get; set; }      //Tài khoản phân bổ
        //public string ICProductAttributeFinishing { get; set; }
        //public string ICProductAttributeFinishingText { get; set; }
        public string ICProductWoodGroup { get; set; }                  //Nhóm gỗ
        //public string ICProductWorkGroupName { get; set; }
        public string ICProductWorkType { get; set; }                   //Loại hình thực hiện
        //public decimal ICProductWorkUnitPrice { get; set; }
        //public decimal ICProductMaterialUnitPrice { get; set; }
        //public decimal ICProductEquipmentUnitPrice { get; set; }
        public string ICProductOriginOfProduct { get; set; }            //Nguồn gốc
        //ICProductMinLength
        //ICProductMaxHeight
        //public string ICProductTargetType { get; set; }
        public string ICProductOrigin { get; set; }                     //Xuất xứ
        public string ICModelName { get; set; }                         //Nhãn hiệu
        public string ICProductOtherSize { get; set; }                  //Kích thước/Quy cách
        public string ICProductAccountRevenueInternalNo { get; set; }   //TK Doanh thu nội bộ
        public string ICProductAccountCostPriceNo { get; set; }         //TK Giá vốn
        public string ICProductAccountRevenueNo { get; set; }           //Tài khoản danh thu
        public string ICProductAccountSaleReturnNo { get; set; }        //TK Hàng bán trả lại
        public string ICProductAccountDiscountNo { get; set; }          //TK Chiết Khấu
        //public string ICProductLicensePlate { get; set; }
        public decimal ICProductBulk { get; set; }                      //Trọng tải
        public decimal ICProductCapacity { get; set; }                  //Dung tích
        public decimal ICProductDepth { get; set; }                     //Độ dày (mm)
        public decimal ICProductRadius { get; set; }                    //Bán kính (mm)
        public decimal ICProductDiameter { get; set; }                  //Đường kính (mm) 
        public decimal ICProductThickness { get; set; }
        public string ICProductGroupHeightID { get; set; }
        public string ICProductFormulaPriceConfigName { get; set; }     //CT tính giá
        public decimal ICProductGuaranteeMonth { get; set; }
        public string ICProductTemplateType { get; set; }               //Loại hàng
        public string ICProductTypeAccountConfigName { get; set; }      //Nhóm tài khoản
        public string ICProductUses { get; set; }                       //Hình thức sử dụng
        public string ICProductTrademark { get; set; }                  //Thương hiệu
        public string ICProductDepartmentGroup { get; set; }
        public string BRBranchName { get; set; }                        //Chi nhánh
        public string ACCostCenterName { get; set; }                    //Trung tâm chi phí
        public string ACSegmentname { get; set; }                       //Khoản mục chi phí
        //FK_ACEquipmentTypeAccountConfigID
        public string ICPriceCalculationMethodName { get; set; }        //Phương pháp tính giá vốn 

        public decimal ICProductBlock { get; set; }                     //Khối tinh
        public decimal ICProductVolume { get; set; }
        //FK_MMFormulaIDPaintA
        //FK_MMFormulaIDPaintB
        //FK_ICProductAttributeQualityID
        public decimal ICProductDepreciationRate { get; set; }
        public decimal ICProductDepreciationQty { get; set; }
        public string ARCustomerName { get; set; }                      //Khách hàng
        public string APSupplierName { get; set; }                      //Nhà cung cấp
        //FK_MMFormulaIDPaintC
        public decimal ICProductCartonBlock { get; set; }
        public decimal ICProductInsideDimensionLength { get; set; }
        public decimal ICProductInsideDimensionWidth { get; set; }
        public decimal ICProductInsideDimensionHeight { get; set; }
        public decimal ICProductOverallDimensionLength { get; set; }
        public decimal ICProductOverallDimensionWidth { get; set; }
        public decimal ICProductOverallDimensionHeight { get; set; }
        public int ICProductQtyInBox { get; set; }                      //Số lượng SP/thùng
        public decimal ICProductNetWeight { get; set; }                 //Khối lượng tịnh
        public decimal ICProductGrossWeight { get; set; }               //Khối lượng sản phẩm
        public decimal ICProductLeadTime { get; set; }                  //Leadtime (day)
        public decimal ICProductBoxArea { get; set; }
        public decimal ICProductBoxUnitPrice { get; set; }
        //FK_ICProductCarcassID
        //FK_ICProductStockSaveID
        public int ICProductStockSaveDate { get; set; }        
        //FK_ICPerimeterGroupID
        //FK_ICLengthGroupID
        //FK_ICStockGroupID
        //FK_ICProductWoodIngredientID
        //FK_MMProcessID        
        public bool ICProductIsFollowInventoryStock { get; set; }       //Theo dõi tồn kho
        public decimal ICProductConsumable { get; set; }
        public string ICProductResourceType { get; set; }
        //FK_ICProductThickGroupID
        public int ICProductStorageDay { get; set; }                //Số ngày lưu kho
        public string ICProductUsingMethod { get; set; }
        public int ICProductCreateNumber { get; set; }
        //FK_ACAccountRevenueHinterLandID
        public string ICProductContType { get; set; }
        public decimal ICProductInRadius { get; set; }
        public decimal ICProductInDiameter { get; set; }
        public decimal ICProductWarping { get; set; }
        public string ICProductNumberSign { get; set; }
        //ICProductIsInventory
        public string ICProductProductionComment { get; set; }      //Ghi chú sản xuất
        public string ICProductPackagingDetail { get; set; }        //Thông tin đóng gói
        public string ICProductStorageCondition { get; set; }
        public decimal ICProductExpiryDay { get; set; }
        //FK_ICWidthGroupID { get; set; }
        public decimal ICProductCollection { get; set; }            //Collection


        public int FK_ICDepartmentID { get; set; }                  //ICDepartmentNo -- Ngành hàng
        public int FK_ICProductGroupID { get; set; }                //ICProductGroup -- Nhóm hàng
        public int FK_ICProductBasicUnitID { get; set; }            //ICMeasureUnitName -- Đơn vị tính
        public int FK_ICProductSaleUnitID { get; set; }             //ICMeasureUnitName -- Đơn vị tính
        public int FK_ICProductPurchaseUnitID { get; set; }         //ICMeasureUnitName -- Đơn vị tính
        //ICProductAttributeKey
        //ICProductAttribute
        //ICProductAttributeNo
        public int FK_ARCustomerID { get; set; }                    //ARCustomerName -- Khách hàng
        public int FK_APSupplierID { get; set; }                    //ARCustomerName -- Khách hàng
        public int FK_ICProductAttributeWoodTypeID { get; set; }    //ICProductAttributeWoodTypeName -- Loại gỗ/ Loại nguyên liệu
        public int FK_ICProductAttributeColorID { get; set; }       //ICProductAttributeColorName -- Màu sơn
        public int FK_ICProductAttributeFinishingID { get; set; }   //ICProductAttributeFinishingName -- Xác định hoàn thiện        
        //FK_ICProductGroupParentID
        //FK_ICProdAttPackingMaterialSpecialityID
        //FK_ICProdAttPackingMaterialSizeID
        //FK_ICProdAttPackingMaterialWeightPerVolumeID
        //FK_ICProductAttributeSemiProductSpecialityID
        public int FK_ICProductTypeAccountConfigID { get; set; }    //ICProductTypeAccountConfigName -- Nhóm tài khoản
        public int FK_ACAccountID { get; set; }                     //ICProductAccountNo -- TK Tồn kho
        public int FK_ACDepreciationCostAccountID { get; set; }     //ICProductDepreciationCostAccountNo -- Tài khoản chi phí
        public int FK_ACDepreciationAccountID { get; set; }         //ACDepreciationAccountNo -- Tài khoản phân bổ
        public int FK_ACAccountRevenueInternalID { get; set; }      //ICProductAccountRevenueInternalNo -- TK Doanh thu nội bộ
        public int FK_ACAccountCostPriceID { get; set; }            //ICProductAccountCostPriceNo -- TK Giá vốn
        public int FK_ACAccountRevenueID { get; set; }              //ICProductAccountRevenueNo -- Tài khoản danh thu
        public int FK_ACAccountSaleReturnID { get; set; }           //ICProductAccountSaleReturnNo -- TK Hàng bán trả lại
        public int FK_ACAccountDiscountID { get; set; }             //ICProductAccountDiscountNo -- TK Chiết Khấu        
        public int FK_ICProductFormulaPriceConfigID { get; set; }   //ICProductFormulaPriceConfigName -- CT tính giá
        public int FK_BRBranchID { get; set; }                      //BRBranchName -- Chi nhánh
        public int FK_ACCostCenterID { get; set; }                  //ACCostCenterName -- Trung tâm chi phí
        public int FK_ACSegmentID { get; set; }                     //ACSegmentname -- Khoản mục chi phí
        public int FK_ICPriceCalculationMethodID { get; set; }      //ICPriceCalculationMethodName -- Phương pháp tính giá vốn 
                                                                    //FK_ICProductGroupHeightID
                                                                    //FK_ICProductWorkGroupID
                                                                    //FK_ICModelID

        #region Extra
        public string MessageError { get; set; }
        #endregion
    }
}