using BOSERP;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class RPProductionNormVMExtra : BaseReport
    {
        List<MMProductionNormItemMeterialsInfo> ProductionNormItemsMeterialList { get; set; }
        List<MMProductionNormItemPaintsInfo> ProductionNormItemsPaintList { get; set; }
        private float addHeight = 30F;
        private int maxRow = 0;
        private decimal AreaBurnishing = 0;
        #region Contructor
        public RPProductionNormVMExtra(List<MMProductionNormItemMeterialsInfo> productionNormItemsMeterialList, List<MMProductionNormItemPaintsInfo> productionNormItemsPaintList, decimal areaBurnishing)
        {
            InitializeComponent();
            ProductionNormItemsMeterialList = productionNormItemsMeterialList;
            ProductionNormItemsPaintList = productionNormItemsPaintList;
            AreaBurnishing = areaBurnishing;
            if (ProductionNormItemsMeterialList == null)
                productionNormItemsMeterialList = new List<MMProductionNormItemMeterialsInfo>();
            if (ProductionNormItemsPaintList == null)
                ProductionNormItemsPaintList = new List<MMProductionNormItemPaintsInfo>();
            InitSubDetailReport();
            logoCompany.ImageUrl = Application.StartupPath + BOSApp.CurrentCompanyInfo.CSCompanyLogo;
        }
        #endregion

        public void InitSubDetailReport()
        {

            MMProductionNormItemMeterialsInfo objProductionNormItemMeterialEmptysInfo = new MMProductionNormItemMeterialsInfo();
            objProductionNormItemMeterialEmptysInfo.ICProductName = " ";
            MMProductionNormItemPaintsInfo objProductionNormItemPaintEmptysInfo = new MMProductionNormItemPaintsInfo();
            objProductionNormItemPaintEmptysInfo.ICProductAttributeNo = " ";

            maxRow = ProductionNormItemsMeterialList.Count() > ProductionNormItemsPaintList.Count() ? ProductionNormItemsMeterialList.Count() : ProductionNormItemsPaintList.Count();
            if (ProductionNormItemsMeterialList.Count() == ProductionNormItemsPaintList.Count())
            {
                maxRow++;
            }

            this.xrTableProductionNormWood.Rows.Clear();

            if (ProductionNormItemsMeterialList.Count() >= ProductionNormItemsPaintList.Count())
            {
                for (int i = 0; i < ProductionNormItemsPaintList.Count(); i++)
                {
                    ProductionNormItemsMeterialList[i].ICProductAttributeColorNo = ProductionNormItemsPaintList[i].ICProductAttributeNo;
                    ProductionNormItemsMeterialList[i].ICMeasureUnitColorName = ProductionNormItemsPaintList[i].ICMeasureUnitName;
                    ProductionNormItemsMeterialList[i].MMProductionNormItemPaintTotalQty = ProductionNormItemsPaintList[i].MMProductionNormItemPaintTotalQty;
                }
            }
            else
            {
                int rowThan = ProductionNormItemsPaintList.Count() - ProductionNormItemsMeterialList.Count();
                for (int i = 0; i < rowThan; i++)
                {
                    objProductionNormItemMeterialEmptysInfo = new MMProductionNormItemMeterialsInfo();
                    objProductionNormItemMeterialEmptysInfo.ICProductAttributeColorNo = ProductionNormItemsPaintList[i].ICProductAttributeNo;
                    objProductionNormItemMeterialEmptysInfo.ICMeasureUnitColorName = ProductionNormItemsPaintList[i].ICMeasureUnitName;
                    objProductionNormItemMeterialEmptysInfo.MMProductionNormItemPaintTotalQty = ProductionNormItemsPaintList[i].MMProductionNormItemPaintTotalQty;
                    ProductionNormItemsMeterialList.Add(objProductionNormItemMeterialEmptysInfo);
                }
            }
            ProductionNormItemsMeterialList.ForEach(o =>
            {
                this.xrTableProductionNormWood.Rows.Add(AddProductionNormItemWoodInTableRow(o));
            });
            objProductionNormItemMeterialEmptysInfo = new MMProductionNormItemMeterialsInfo();
            this.xrTableProductionNormWood.Rows.Add(AddProductionNormItemWoodLastRow(objProductionNormItemMeterialEmptysInfo));
        }

        private XRTableRow AddProductionNormItemWoodInTableRow(MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo)
        {
            XRTableRow xrTableRowCustom = new XRTableRow();
            XRTableCell xrTableCellCustom1 = new XRTableCell();
            XRTableCell xrTableCellCustom2 = new XRTableCell();
            XRTableCell xrTableCellCustom3 = new XRTableCell();
            XRTableCell xrTableCellCustom4 = new XRTableCell();
            XRTableCell xrTableCellCustom5 = new XRTableCell();
            XRTableCell xrTableCellCustom6 = new XRTableCell();
            XRTableCell xrTableCellCustom7 = new XRTableCell();
            //
            //xrTableCellCustom1
            //
            xrTableCellCustom1.Multiline = true;
            xrTableCellCustom1.WordWrap = true;
            xrTableCellCustom1.Weight = 2.2941927200640837;
            xrTableCellCustom1.Name = "xrTableCellCustom1" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom1.BackColor = Color.White;
            xrTableCellCustom1.StylePriority.UseBorderColor = false;
            xrTableCellCustom1.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom1.SizeF = new SizeF(373.36F, addHeight);
            xrTableCellCustom1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 5, 2, 2, 254F);
            xrTableCellCustom1.StylePriority.UseBorders = false;
            xrTableCellCustom1.StylePriority.UseFont = false;
            xrTableCellCustom1.StylePriority.UsePadding = false;
            xrTableCellCustom1.Text = objProductionNormItemMeterialsInfo.ICProductName == null ? string.Empty : objProductionNormItemMeterialsInfo.ICProductName;
            xrTableCellCustom1.StylePriority.UseTextAlignment = false;
            xrTableCellCustom1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCellCustom1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom1.BorderColor = Color.Black;
            //
            //xrTableCellCustom2
            //
            xrTableCellCustom2.Multiline = true;
            xrTableCellCustom2.WordWrap = true;
            xrTableCellCustom2.Name = "xrTableCellCustom2" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom2.StylePriority.UseBorderColor = false;
            xrTableCellCustom2.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom2.SizeF = new SizeF(135.97F, addHeight);
            xrTableCellCustom2.Weight = 0.67294015366821069;
            xrTableCellCustom2.BackColor = Color.White;
            xrTableCellCustom2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom2.StylePriority.UseBorders = false;
            xrTableCellCustom2.StylePriority.UseFont = false;
            xrTableCellCustom2.StylePriority.UsePadding = false;
            xrTableCellCustom2.Text = objProductionNormItemMeterialsInfo.ICMeasureUnitName == null ? string.Empty : objProductionNormItemMeterialsInfo.ICMeasureUnitName;
            xrTableCellCustom2.StylePriority.UseTextAlignment = false;
            xrTableCellCustom2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom2.BorderColor = Color.Black;
            // 
            // xrTableCellCustom3
            // 
            xrTableCellCustom3.Multiline = true;
            xrTableCellCustom3.WordWrap = true;
            xrTableCellCustom3.Name = "xrTableCellCustom3" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom3.StylePriority.UseBorderColor = false;
            xrTableCellCustom3.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom3.SizeF = new SizeF(131.59F, addHeight);
            xrTableCellCustom3.Weight = 0.97112892535365614;
            xrTableCellCustom3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom3.StylePriority.UseBorders = false;
            xrTableCellCustom3.BackColor = Color.White;
            xrTableCellCustom3.StylePriority.UseFont = false;
            xrTableCellCustom3.StylePriority.UsePadding = false;
            if (objProductionNormItemMeterialsInfo.FK_ICProductID != 0)
                xrTableCellCustom3.Text = objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks.ToString("n4");
            else
                xrTableCellCustom3.Text = " ";
            xrTableCellCustom3.StylePriority.UseTextAlignment = false;
            xrTableCellCustom3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom3.BorderColor = Color.Black;
            // 
            // xrTableCellCustom4
            // 
            xrTableCellCustom4.Multiline = true;
            xrTableCellCustom4.WordWrap = true;
            xrTableCellCustom4.Name = "xrTableCellCustom4" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom4.StylePriority.UseBorderColor = false;
            xrTableCellCustom4.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom4.SizeF = new SizeF(639.95F, 25F);
            xrTableCellCustom4.Weight = 3.9322629276883352;
            xrTableCellCustom4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom4.StylePriority.UseBorders = false;
            xrTableCellCustom4.BackColor = Color.White;
            xrTableCellCustom4.StylePriority.UseFont = false;
            xrTableCellCustom4.StylePriority.UsePadding = false;
            xrTableCellCustom4.StylePriority.UseTextAlignment = false;
            xrTableCellCustom4.Text = objProductionNormItemMeterialsInfo.ICProductNo == null ? string.Empty : objProductionNormItemMeterialsInfo.ICProductNo;
            xrTableCellCustom4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom4.BorderColor = Color.Black;

            // 
            // xrTableCellCustom5
            // 
            xrTableCellCustom5.Multiline = true;
            xrTableCellCustom5.WordWrap = true;
            xrTableCellCustom5.Name = "xrTableCellCustom5" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom5.StylePriority.UseBorderColor = false;
            xrTableCellCustom5.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom4.SizeF = new SizeF(639.95F, 25F);
            xrTableCellCustom5.Weight = 1.173865848787365;
            xrTableCellCustom5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom5.StylePriority.UseBorders = false;
            xrTableCellCustom5.BackColor = Color.White;
            xrTableCellCustom5.StylePriority.UseFont = false;
            xrTableCellCustom5.StylePriority.UsePadding = false;
            xrTableCellCustom5.StylePriority.UseTextAlignment = false;
            string productName = objProductionNormItemMeterialsInfo.ICProductAttributeColorNo == null ? string.Empty : objProductionNormItemMeterialsInfo.ICProductAttributeColorNo;
            xrTableCellCustom5.Text = productName;
            xrTableCellCustom5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom5.BorderColor = Color.Black;

            // 
            // xrTableCellCustom6
            // 
            xrTableCellCustom6.Multiline = true;
            xrTableCellCustom6.WordWrap = true;
            xrTableCellCustom6.Name = "xrTableCellCustom6" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom6.StylePriority.UseBorderColor = false;
            xrTableCellCustom6.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom4.SizeF = new SizeF(639.95F, 25F);
            xrTableCellCustom6.Weight = 1.1840173907591793;
            xrTableCellCustom6.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom6.StylePriority.UseBorders = false;
            xrTableCellCustom6.BackColor = Color.White;
            xrTableCellCustom6.StylePriority.UseFont = false;
            xrTableCellCustom6.StylePriority.UsePadding = false;
            xrTableCellCustom6.StylePriority.UseTextAlignment = false;
            xrTableCellCustom6.Text = objProductionNormItemMeterialsInfo.ICMeasureUnitColorName == null ? string.Empty : objProductionNormItemMeterialsInfo.ICMeasureUnitColorName;
            xrTableCellCustom6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom6.BorderColor = Color.Black;


            // 
            // xrTableCellCustom7
            // 
            xrTableCellCustom7.Multiline = true;
            xrTableCellCustom7.WordWrap = true;
            xrTableCellCustom7.Name = "xrTableCellCustom7" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom7.StylePriority.UseBorderColor = false;
            xrTableCellCustom7.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom4.SizeF = new SizeF(639.95F, 25F);
            xrTableCellCustom7.Weight = 1.3503130222818889;
            xrTableCellCustom7.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom7.StylePriority.UseBorders = false;
            xrTableCellCustom7.BackColor = Color.White;
            xrTableCellCustom7.StylePriority.UseFont = false;
            xrTableCellCustom7.StylePriority.UsePadding = false;
            xrTableCellCustom7.StylePriority.UseTextAlignment = false;
            if (!string.IsNullOrEmpty(objProductionNormItemMeterialsInfo.ICProductAttributeColorNo))
                xrTableCellCustom7.Text = objProductionNormItemMeterialsInfo.MMProductionNormItemPaintTotalQty == 0 ? " " : objProductionNormItemMeterialsInfo.MMProductionNormItemPaintTotalQty.ToString("n4");
            else
                xrTableCellCustom7.Text = " ";
            xrTableCellCustom7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom7.BorderColor = Color.Black;

            // 
            // xrTableRowCustom
            // 
            xrTableRowCustom.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                xrTableCellCustom1,
                xrTableCellCustom2,
                xrTableCellCustom3,
                xrTableCellCustom4,
                xrTableCellCustom5,
                xrTableCellCustom6,
                xrTableCellCustom7});
            xrTableRowCustom.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            xrTableRowCustom.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            xrTableRowCustom.SnapLineMargin = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            xrTableRowCustom.Name = "xrTableRowCustom" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableRowCustom.Weight = 1;
            return xrTableRowCustom;
        }

        private XRTableRow AddProductionNormItemWoodLastRow(MMProductionNormItemMeterialsInfo objProductionNormItemMeterialsInfo)
        {
            XRTableRow xrTableRowCustom = new XRTableRow();
            XRTableCell xrTableCellCustom1 = new XRTableCell();
            XRTableCell xrTableCellCustom2 = new XRTableCell();
            XRTableCell xrTableCellCustom3 = new XRTableCell();
            XRTableCell xrTableCellCustom4 = new XRTableCell();
            XRTableCell xrTableCellCustom5 = new XRTableCell();
            //
            //xrTableCellCustom1
            //
            xrTableCellCustom1.Multiline = true;
            xrTableCellCustom1.WordWrap = true;
            xrTableCellCustom1.Weight = 2.2941927200640837;
            xrTableCellCustom1.Name = "xrTableCellCustom1" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom1.BackColor = Color.White;
            xrTableCellCustom1.StylePriority.UseBorderColor = false;
            xrTableCellCustom1.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom1.SizeF = new SizeF(373.36F, addHeight);
            xrTableCellCustom1.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 5, 2, 2, 254F);
            xrTableCellCustom1.StylePriority.UseBorders = false;
            xrTableCellCustom1.StylePriority.UseFont = false;
            xrTableCellCustom1.StylePriority.UsePadding = false;
            xrTableCellCustom1.Text = objProductionNormItemMeterialsInfo.ICProductName == null ? string.Empty : objProductionNormItemMeterialsInfo.ICProductName;
            xrTableCellCustom1.StylePriority.UseTextAlignment = false;
            xrTableCellCustom1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            xrTableCellCustom1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom1.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom1.BorderColor = Color.Black;
            //
            //xrTableCellCustom2
            //
            xrTableCellCustom2.Multiline = true;
            xrTableCellCustom2.WordWrap = true;
            xrTableCellCustom2.Name = "xrTableCellCustom2" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom2.StylePriority.UseBorderColor = false;
            xrTableCellCustom2.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom2.SizeF = new SizeF(135.97F, addHeight);
            xrTableCellCustom2.Weight = 0.67294015366821069;
            xrTableCellCustom2.BackColor = Color.White;
            xrTableCellCustom2.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom2.StylePriority.UseBorders = false;
            xrTableCellCustom2.StylePriority.UseFont = false;
            xrTableCellCustom2.StylePriority.UsePadding = false;
            xrTableCellCustom2.Text = objProductionNormItemMeterialsInfo.ICMeasureUnitName == null ? string.Empty : objProductionNormItemMeterialsInfo.ICMeasureUnitName;
            xrTableCellCustom2.StylePriority.UseTextAlignment = false;
            xrTableCellCustom2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom2.BorderColor = Color.Black;
            // 
            // xrTableCellCustom3
            // 
            xrTableCellCustom3.Multiline = true;
            xrTableCellCustom3.WordWrap = true;
            xrTableCellCustom3.Name = "xrTableCellCustom3" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom3.StylePriority.UseBorderColor = false;
            xrTableCellCustom3.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom3.SizeF = new SizeF(131.59F, addHeight);
            xrTableCellCustom3.Weight = 0.97112892535365614;
            xrTableCellCustom3.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom3.StylePriority.UseBorders = false;
            xrTableCellCustom3.BackColor = Color.White;
            xrTableCellCustom3.StylePriority.UseFont = false;
            xrTableCellCustom3.StylePriority.UsePadding = false;
            if (objProductionNormItemMeterialsInfo.FK_ICProductID != 0)
                xrTableCellCustom3.Text = objProductionNormItemMeterialsInfo.MMProductionNormItemMeterialWoodBlocks.ToString("n4");
            else
                xrTableCellCustom3.Text = " ";
            xrTableCellCustom3.StylePriority.UseTextAlignment = false;
            xrTableCellCustom3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom3.BorderColor = Color.Black;
            // 
            // xrTableCellCustom4
            // 
            xrTableCellCustom4.Multiline = true;
            xrTableCellCustom4.WordWrap = true;
            xrTableCellCustom4.Name = "xrTableCellCustom4" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom4.StylePriority.UseBorderColor = false;
            xrTableCellCustom4.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom4.SizeF = new SizeF(639.95F, 25F);
            xrTableCellCustom4.Weight = 3.9322629276883352;
            xrTableCellCustom4.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom4.StylePriority.UseBorders = false;
            xrTableCellCustom4.BackColor = Color.White;
            xrTableCellCustom4.StylePriority.UseFont = false;
            xrTableCellCustom4.StylePriority.UsePadding = false;
            xrTableCellCustom4.StylePriority.UseTextAlignment = false;
            xrTableCellCustom4.Text = objProductionNormItemMeterialsInfo.ICProductNo == null ? string.Empty : objProductionNormItemMeterialsInfo.ICProductNo;
            xrTableCellCustom4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom4.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom4.BorderColor = Color.Black;

            // 
            // xrTableCellCustom5
            // 
            xrTableCellCustom5.Multiline = true;
            xrTableCellCustom5.WordWrap = true;
            xrTableCellCustom5.Name = "xrTableCellCustom5" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableCellCustom5.StylePriority.UseBorderColor = false;
            xrTableCellCustom5.StylePriority.UseTextAlignment = false;
            //xrTableCellCustom4.SizeF = new SizeF(639.95F, 25F);
            xrTableCellCustom5.Weight = 3.7081962618284332;
            xrTableCellCustom5.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 2, 2, 254F);
            xrTableCellCustom5.StylePriority.UseBorders = false;
            xrTableCellCustom5.BackColor = Color.White;
            xrTableCellCustom5.StylePriority.UseFont = false;
            xrTableCellCustom5.StylePriority.UsePadding = false;
            xrTableCellCustom5.StylePriority.UseTextAlignment = false;
            xrTableCellCustom5.Text = string.Format("Diện tích đánh bóng = {0} m", AreaBurnishing.ToString("n4"));
            xrTableCellCustom5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            xrTableCellCustom5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom5.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Right)
                        | DevExpress.XtraPrinting.BorderSide.Bottom)));
            xrTableCellCustom5.BorderColor = Color.Black;
            // 
            // xrTableRowCustom
            // 
            xrTableRowCustom.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                xrTableCellCustom1,
                xrTableCellCustom2,
                xrTableCellCustom3,
                xrTableCellCustom4,
                xrTableCellCustom5});
            xrTableRowCustom.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            xrTableRowCustom.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            xrTableRowCustom.SnapLineMargin = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            xrTableRowCustom.Name = "xrTableRowCustom" + objProductionNormItemMeterialsInfo.FK_ICProductID;
            xrTableRowCustom.Weight = 1;
            return xrTableRowCustom;
        }

        private void xrTableCell21_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            XRTable tableHeader = null;
            int groupOrder = 0;
            Int32.TryParse(tableCell.Text, out groupOrder);
            if (groupOrder == 0 || string.IsNullOrEmpty(tableCell.NextCell.Text))
            {
                XRTableRow tableRow = tableCell.Parent as XRTableRow;
                if (tableRow != null)
                {
                    foreach (XRTableCell tableItem in tableRow.Cells)
                    {
                        tableItem.Text = string.Empty;
                        tableItem.CanGrow = true;
                        tableItem.BorderWidth = 0;
                        tableItem.HeightF = 0F;
                        tableItem.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                        tableItem.SnapLineMargin = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                        tableItem.BoundsF = new RectangleF(new PointF(0, 0), new SizeF(0, 0));
                        tableItem.SizeF = new SizeF(0, 0);
                        tableItem.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                        tableItem.Multiline = false;
                        tableItem.Visible = false;
                    }
                    tableRow.CanGrow = true;
                    tableRow.Visible = false;
                    tableRow.LocationF = new PointF(0, 0);
                    tableRow.BorderWidth = 0;
                    tableRow.SnapLinePadding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                    tableRow.SnapLineMargin = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                    tableRow.SizeF = new SizeF(0, 0);
                    tableRow.HeightF = 0F;
                    tableRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                    tableHeader = tableRow.Parent as XRTable;
                }
                if (tableHeader != null)
                {
                    int count = 0;
                    foreach (XRTableRow tableRowItem in tableHeader)
                    {
                        if (tableRowItem != tableRow)
                            count++;
                    }
                    if (count == 0)
                    {
                        tableHeader.HeightF = 0;
                        tableHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                        tableHeader.BorderWidth = 0;
                        tableHeader.Visible = false;
                        GroupHeaderBand groupHeaderBand = tableHeader.Parent as GroupHeaderBand;
                        if (groupHeaderBand != null)
                        {
                            groupHeaderBand.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
                            groupHeaderBand.BorderWidth = 0;
                            groupHeaderBand.HeightF = 0F;
                            groupHeaderBand.Visible = false;
                        }
                    }
                }
            }
        }

        private void xrTableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = sender as XRTableCell;
            decimal strNumber = 0;
            Decimal.TryParse(tableCell.Text, out strNumber);
            tableCell.Text = strNumber.ToString("n0");
        }
    }
}