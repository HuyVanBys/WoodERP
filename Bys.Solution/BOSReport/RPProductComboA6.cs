using BOSERP;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace BOSReport
{
    public partial class RPProductComboA6 : BaseReport
    {
        private List<ICProductComponentsInfo> ProductComponentsList { get; set; }

        public RPProductComboA6(List<ICProductComponentsInfo> productComponentsList)
        {
            InitializeComponent();
            this.ProductComponentsList = productComponentsList;
            if (ProductComponentsList == null)
                ProductComponentsList = new List<ICProductComponentsInfo>();
            else if (productComponentsList.Count > 0)
            {
                this.xrTblProductComponents.Rows.Clear();
            }
            InvalidateProductComponent(ProductComponentsList);
        }

        public void InvalidateProductComponent(List<ICProductComponentsInfo> productComponentsList)
        {
            productComponentsList.ForEach(o =>
            {
                this.xrTblProductComponents.Rows.Add(AddProductComponentsInTableRow(o));
            });
        }

        private XRTableRow AddProductComponentsInTableRow(ICProductComponentsInfo objProductComponentsInfo)
        {
            XRTableRow xrTableRowCustom = new XRTableRow();
            XRTableCell xrTableCellCustom1 = new XRTableCell();
            XRTableCell xrTableCellCustom2 = new XRTableCell();
            XRTableCell xrTableCellCustom3 = new XRTableCell();
            XRTableCell xrTableCellCustom4 = new XRTableCell();
            XRPictureBox xrPictureBoxCustom = new XRPictureBox();
            xrTableCellCustom1 = new XRTableCell();
            //
            //xrTableCellCustom1
            //
            xrTableCellCustom1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCellCustom1.Name = "xrTableCellCustom1";
            xrTableCellCustom1.StylePriority.UseBorders = false;
            xrTableCellCustom1.Weight = 1.0004911376488803;
            xrTableCellCustom1.Text = objProductComponentsInfo.ICProductName;
            xrTableCellCustom1.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom1.StylePriority.UseBorders = false;
            xrTableCellCustom1.StylePriority.UseFont = false;
            xrTableCellCustom1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 2, 0, 100F);
            xrTableCellCustom1.StylePriority.UseBorders = false;
            xrTableCellCustom1.StylePriority.UseFont = false;
            xrTableCellCustom1.StylePriority.UsePadding = false;
            xrTableCellCustom1.StylePriority.UseTextAlignment = false;
            xrTableCellCustom1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            //
            //xrTableCellCustom2
            //
            xrTableCellCustom2.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCellCustom2.Name = "xrTableCellCustom2";
            xrTableCellCustom2.StylePriority.UseBorders = false;
            xrTableCellCustom2.Weight = 0.77565833416392271;
            xrTableCellCustom2.Text = objProductComponentsInfo.ICProductNo;
            xrTableCellCustom2.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom2.StylePriority.UseBorders = false;
            xrTableCellCustom2.StylePriority.UseFont = false;
            xrTableCellCustom2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 2, 0, 100F);
            xrTableCellCustom2.StylePriority.UseBorders = false;
            xrTableCellCustom2.StylePriority.UseFont = false;
            xrTableCellCustom2.StylePriority.UsePadding = false;
            xrTableCellCustom2.StylePriority.UseTextAlignment = false;
            xrTableCellCustom2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell4
            // 
            xrTableCellCustom3.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrTableCellCustom3.Name = "xrTableCellCustom3";
            xrTableCellCustom3.StylePriority.UseBorders = false;
            xrTableCellCustom3.Weight = 0.68943864635428376;
            xrTableCellCustom3.Text = objProductComponentsInfo.ICProductPrice.ToString("n0");
            xrTableCellCustom3.Font = new System.Drawing.Font("Times New Roman", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            xrTableCellCustom3.StylePriority.UseBorders = false;
            xrTableCellCustom3.StylePriority.UseFont = false;
            xrTableCellCustom3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 0, 2, 0, 100F);
            xrTableCellCustom3.StylePriority.UseBorders = false;
            xrTableCellCustom3.StylePriority.UseFont = false;
            xrTableCellCustom3.StylePriority.UsePadding = false;
            xrTableCellCustom3.StylePriority.UseTextAlignment = false;
            xrTableCellCustom3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableCell5
            // 
            xrTableCellCustom4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            xrPictureBoxCustom});
            xrTableCellCustom4.Name = "xrTableCell5";
            xrTableCellCustom4.Weight = 0.56396853652255607;
            xrTableCellCustom4.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0);
            // 
            // xrPictureBox5
            // 
            xrPictureBoxCustom.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            xrPictureBoxCustom.BorderWidth = 0;
            xrPictureBoxCustom.Image = objProductComponentsInfo.ICProductBarcodeImage;
            xrPictureBoxCustom.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            xrPictureBoxCustom.Name = "xrPictureBox5";
            xrPictureBoxCustom.SizeF = new System.Drawing.SizeF(38F, 38F);
            xrPictureBoxCustom.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            xrPictureBoxCustom.StylePriority.UseBorders = false;
            xrPictureBoxCustom.StylePriority.UseBorderWidth = false;
            // 
            // xrTableRowCustom
            // 
            xrTableRowCustom.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
                xrTableCellCustom1,
                xrTableCellCustom2,
                xrTableCellCustom3,
                xrTableCellCustom4});
            xrTableRow1.Name = "xrTableRowCustom";
            xrTableRow1.Weight = 1;
            return xrTableRowCustom;
        }
    }
}
