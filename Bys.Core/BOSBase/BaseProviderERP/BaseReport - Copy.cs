using BOSComponent;
using BOSERP;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BOSReport
{
    public partial class BaseReport : DevExpress.XtraReports.UI.XtraReport
    {
        public BaseReport()
        {
            BeforePrint += new System.Drawing.Printing.PrintEventHandler(BaseReport_BeforePrint);
        }

        private void BaseReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            foreach (Band band in Bands)
            {
                SetTextTableCell(band);
            }
        }

        /// <summary>
        /// Set text for table cell 
        /// </summary>
        /// <param name="band">Given band in report</param>
        public void SetTextTableCell(Band band)
        {
            foreach (XRControl control in band)
            {
                if (control.GetType() == typeof(XRTable))
                {
                    XRTable table = (XRTable)control;
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        foreach (XRTableCell tableCell in table.Rows[i].Cells)
                        {
                            if (tableCell.DataBindings.Count > 0)
                                tableCell.BeforePrint += new System.Drawing.Printing.PrintEventHandler(TableCell_BeforePrint);
                            foreach(XRControl control1 in tableCell)
                            {
                                if (control1.GetType() == typeof(XRPictureBox))
                                {
                                    XRPictureBox pictureBox = (XRPictureBox)control1;
                                    pictureBox.BeforePrint += new System.Drawing.Printing.PrintEventHandler(PictureBox_BeforePrint);   
                                }    
                            }    
                        }
                    }
                }
                else if (control.GetType() == typeof(XRRichText))
                {
                    XRRichText richText = (XRRichText)control;
                    if (!string.IsNullOrEmpty(richText.NavigateUrl))
                    {
                        var currValue = this.GetCurrentColumnValue(richText.NavigateUrl);
                        if (currValue != null)
                        {
                            MemoryStream RTFStream = new MemoryStream((byte[])currValue);
                            BOSRichEditControl tempcontrol = new BOSRichEditControl();
                            tempcontrol.LoadDocument(RTFStream, DocumentFormat.Rtf);
                            richText.Rtf = tempcontrol.RtfText;
                        }
                    }
                }
            }
        }

        private void TableCell_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRTableCell tableCell = (XRTableCell)sender;
            SetTextTableCell(tableCell);
        }
        private void PictureBox_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            XRPictureBox pictureBox = (XRPictureBox)sender;
            if (!string.IsNullOrEmpty(pictureBox.ImageUrl))
            {
                pictureBox.Image = BOSApp.GetProductPictureImageByLink(pictureBox.ImageUrl);
            }
            else
                pictureBox.Image = null;
        }

        /// <summary>
        /// Set text for table cell 
        /// </summary>
        /// <param name="tableCell">Given table cell</param>
        public virtual void SetTextTableCell(XRTableCell tableCell)
        {
            if (!string.IsNullOrEmpty(tableCell.Text))
            {
                XRBinding biding = tableCell.DataBindings[0];
                double cellValue = 0;
                if (double.TryParse(tableCell.Text, out cellValue))
                {
                    if (cellValue < 0)
                    {
                        if (tableCell.Text.StartsWith("-"))
                        {
                            tableCell.Text = tableCell.Text.Remove(0, 1);
                        }
                        tableCell.Text = string.Format("({0})", tableCell.Text);
                        tableCell.ForeColor = Color.Red;
                    }
                    else if (cellValue > 0)
                    {
                        tableCell.ForeColor = Color.Black;
                    }
                    else if (cellValue == 0)
                    {
                        //tableCell.Text = string.Empty;
                    }
                }
                else
                {
                    DateTime dateTime = DateTime.MaxValue;
                    if (DateTime.TryParse(tableCell.Text, out dateTime))
                    {
                        if (dateTime.Date == DateTime.MaxValue.Date)
                        {
                            tableCell.Text = string.Empty;
                        }
                    }
                }
            }
        }
    }
}
