using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BOSERP.MES.Modules.ProductionNorm
{
    internal class MMImportPNItemWoodsInfo
    {
        public string MMImportPNItemWoodProductCode { get; set; }

        public string MMImportPNItemWoodProductName { get; set; }

        public string MMImportPNItemWoodProductTypeDetails { get; set; }

        public string MMImportPNItemWoodProductParentCode { get; set; }

        public decimal MMImportPNItemWoodProductLength { get; set; }

        public decimal MMImportPNItemWoodProductWidth { get; set; }

        public decimal MMImportPNItemWoodProductHeight { get; set; }

        public decimal MMImportPNItemWoodProductQty{ get; set; }

        public string MMImportPNItemWoodProductAttributeWoodType { get; set; }

        public string MMImportPNItemWoodProductMaterialNo1 { get; set; }

        public string MMImportPNItemWoodProductMaterialNo2 { get; set; }

        //Nothing 12 13

        public string MMImportPNItemWoodProductFrontCNCImage { get; set; }

        public string MMImportPNItemWoodProductBacksideCNCImage { get; set; }

        public string MMImportPNItemWoodProductAddMaterialNo { get; set; }

        public string MMImportPNItemWoodProductFormulaNo { get; set; }
        
        public string MMImportPNItemWoodProductPaintNo1 { get; set; } 

        public string MMImportPNItemWoodProductPaintNo2 { get; set; }

        public string MMImportPNItemWoodProductPaintNo3 { get; set; }

        public decimal MMImportPNItemWoodProductPaint1Area { get; set; }

        public decimal MMImportPNItemWoodProductPaint2Area { get; set; }

        public decimal MMImportPNItemWoodProductPaint3Area { get; set; }

        public bool MMImportPNItemWoodProductIsBurnishing { get; set; }

        public string MMImportPNItemWoodProductJoinery { get; set; }
    }
}
