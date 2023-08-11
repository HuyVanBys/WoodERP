using System;
using System.Drawing;
using System.Windows.Forms;


namespace BOSERP.Utilities
{
    /// <summary>
    /// An object that converts RTF to HTML
    /// </summary>
    public class RtfConverter
    {
        #region Private Members
        /// <summary>
        /// A RichTextBox control to use to help with parsing.
        /// </summary>
        private RichTextBoxExtended SourceRichTextBoxExtended;
        #endregion

        #region Read/Write Properties

        /// <summary>
        /// Gets/Sets The RTF formatted text to parse
        /// </summary>
        public string RichTextBoxExtended { get; set; }
        #endregion

        #region ReadOnly Properties

        /// <summary>
        /// Returns the HTML code for the provided RTF
        /// </summary>
        public string Html
        {
            get { return GetHtml(); }
        }

        #endregion

        #region Constructor
        public RtfConverter()
        {
            SourceRichTextBoxExtended = new RichTextBoxExtended();
        }
        #endregion

        #region Private Functions

        /// <summary>
        /// Returns an HTML Formated Color string for the style from a system.drawing.color
        /// </summary>
        /// <param name="color">The color you wish to convert</param>
        private string HtmlColorFromColor(Color color)
        {
            string stringReturn = "";
            if (color.IsNamedColor)
            {
                stringReturn = color.Name.ToLower();
            }
            else
            {
                stringReturn = color.Name;
                if (stringReturn.Length > 6)
                {
                    stringReturn = stringReturn.Substring(stringReturn.Length - 6, 6);
                }
                stringReturn = "#" + stringReturn;
            }
            return stringReturn;
        }

        /// <summary>
        /// Provides the font style per given font
        /// </summary>
        /// <param name="font">The font you wish to convert</param>
        private string HtmlFontStyleFromFont(Font font)
        {
            string stringReturn = "";
            //style
            if (font.Italic)
            {
                stringReturn += "italic ";
            }
            else
            {
                stringReturn += "normal ";
            }
            //variant
            stringReturn += "normal ";
            //font weight
            if (font.Bold)
            {
                stringReturn += "bold ";
            }
            else
            {
                stringReturn += "normal ";
            }
            //size
            stringReturn += font.SizeInPoints + "pt/normal ";
            // font family
            stringReturn += font.FontFamily.Name;
            return stringReturn;
        }

        /// <summary>
        /// Parses the given rich text and returns the html.
        /// </summary>
        private string GetHtml()
        {
            SourceRichTextBoxExtended.RichTextBox.Rtf = RichTextBoxExtended;
            string stringReturn = "<div>";
            Color colorForeColor = Color.Black;
            Color colorBackColor = Color.Black;
            Font currentFont = SourceRichTextBoxExtended.Font;
            HorizontalAlignment currentHorizontalAlignment = HorizontalAlignment.Left;
            int pos = 0;
            for (pos = 0; pos <= SourceRichTextBoxExtended.RichTextBox.Text.Length - 1; pos++)
            {
                SourceRichTextBoxExtended.RichTextBox.Select(pos, 1);
                //Forecolor
                if (pos == 0)
                {
                    stringReturn += "<span style=\"color:" + HtmlColorFromColor(SourceRichTextBoxExtended.RichTextBox.SelectionColor) + "\">";
                    colorForeColor = SourceRichTextBoxExtended.RichTextBox.SelectionColor;
                }
                else
                {
                    if (SourceRichTextBoxExtended.RichTextBox.SelectionColor != colorForeColor)
                    {
                        stringReturn += "</span>";
                        stringReturn += "<span style=\"color:" + HtmlColorFromColor(SourceRichTextBoxExtended.RichTextBox.SelectionColor) + "\">";
                        colorForeColor = SourceRichTextBoxExtended.RichTextBox.SelectionColor;
                    }
                }
                //Background color
                if (pos == 0)
                {
                    stringReturn += "<span style=\"background-color:" + HtmlColorFromColor(SourceRichTextBoxExtended.RichTextBox.SelectionBackColor) + "\">";
                    colorBackColor = SourceRichTextBoxExtended.RichTextBox.SelectionBackColor;
                }
                else
                {
                    if (SourceRichTextBoxExtended.RichTextBox.SelectionBackColor != colorBackColor)
                    {
                        stringReturn += "</span>";
                        stringReturn += "<span style=\"background-color:" + HtmlColorFromColor(SourceRichTextBoxExtended.RichTextBox.SelectionBackColor) + "\">";
                        colorBackColor = SourceRichTextBoxExtended.RichTextBox.SelectionBackColor;
                    }
                }
                //Font
                if (pos == 0)
                {
                    stringReturn += "<span style=\"font:" + HtmlFontStyleFromFont(SourceRichTextBoxExtended.RichTextBox.SelectionFont) + "\">";
                    currentFont = SourceRichTextBoxExtended.RichTextBox.SelectionFont;
                }
                else
                {
                    if (SourceRichTextBoxExtended.RichTextBox.SelectionFont.GetHashCode() != currentFont.GetHashCode())
                    {
                        stringReturn += "</span>";
                        stringReturn += "<span style=\"font:" + HtmlFontStyleFromFont(SourceRichTextBoxExtended.RichTextBox.SelectionFont) + "\">";
                        currentFont = SourceRichTextBoxExtended.RichTextBox.SelectionFont;
                    }
                }
                //Alignment
                if (pos == 0)
                {
                    stringReturn += "<p style=\"text-align:" + SourceRichTextBoxExtended.RichTextBox.SelectionAlignment.ToString() + "\">";
                    currentHorizontalAlignment = SourceRichTextBoxExtended.RichTextBox.SelectionAlignment;
                }
                else
                {
                    if (SourceRichTextBoxExtended.RichTextBox.SelectionAlignment != currentHorizontalAlignment)
                    {
                        stringReturn += "</p>";
                        stringReturn += "<p style=\"text-align:" + SourceRichTextBoxExtended.RichTextBox.SelectionAlignment.ToString() + "\">";
                        currentHorizontalAlignment = SourceRichTextBoxExtended.RichTextBox.SelectionAlignment;
                    }
                }
                stringReturn += SourceRichTextBoxExtended.RichTextBox.Text.Substring(pos, 1);
            }
            //close all the spans
            stringReturn += "</span>";
            stringReturn += "</span>";
            stringReturn += "</span>";
            stringReturn += "</p>";
            stringReturn += "</div>";
            stringReturn = stringReturn.Replace((Convert.ToChar(10)).ToString(), "<br />");
            return stringReturn;
        }

        #endregion

    }
}
