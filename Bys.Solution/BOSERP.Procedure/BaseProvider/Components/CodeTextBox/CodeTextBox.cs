using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BOSERP
{
    public partial class CodeTextBox : RichTextBox
    {
        #region Variables
        [StructLayout(LayoutKind.Sequential)]
        private struct STRUCT_RECT
        {
            public Int32 Left;
            public Int32 Top;
            public Int32 Right;
            public Int32 Bottom;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct STRUCT_CHARRANGE
        {
            public Int32 CpMin;
            public Int32 CpMax;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct STRUCT_FORMATRANGE
        {
            public IntPtr Hdc;
            public IntPtr HdcTarget;
            public STRUCT_RECT Rc;
            public STRUCT_RECT RcPage;
            public STRUCT_CHARRANGE Chrg;
        }
        [DllImport("user32.dll")]
        private static extern Int32 SendMessage(IntPtr hWnd, Int32 msg,
                                                Int32 wParam, IntPtr lParam);

        private const Int32 WM_USER = 0x400;
        private const Int32 EM_FORMATRANGE = WM_USER + 57;
        #endregion
        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern IntPtr LoadLibrary(string lpFileName);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                if (LoadLibrary("msftedit.dll") != IntPtr.Zero)
                {
                    param.ClassName = "RICHEDIT50W";
                }
                return param;
            }

        }

        #region Variables
        private SyntaxHighlighter m_SyntaxHighLighter = new SyntaxHighlighter();
        private IntellisenseManager m_IntellisenseManager;
        private ImageListBox mp_IntellisenseBox;
        private TreeView mp_IntellisenseTree;
        private Keys mp_IntellisenseKey = Keys.Space;

        #region Drawing
        /// <summary>
        /// Enables or disables control's painting - internal
        /// </summary>
        private bool mp_EnablePainting = true;
        #endregion

        #region Word lists
        private List<string> mp_CodeWords_Keywords;
        private List<string> mp_CodeWords_Types;
        private List<string> mp_CodeWords_Functions;
        private List<string> mp_CodeWords_Comments;
        private List<string> mp_CodeWords_ScopeOperators;
        #endregion

        #region Syntax highlightning colors
        private Color mp_CodeColor_Keyword = Color.Blue;
        private Color mp_CodeColor_Type = Color.CornflowerBlue;
        private Color mp_CodeColor_Function = Color.CornflowerBlue;
        private Color mp_CodeColor_Comment = Color.Green;
        private Color mp_CodeColor_PlainText = Color.Black;
        #endregion

        #region Intellisense images
        private Image mp_CodeImage_Class = Resources._class;
        private Image mp_CodeImage_Event = Resources._event;
        private Image mp_CodeImage_Interface = Resources._interface;
        private Image mp_CodeImage_Method = Resources._method;
        private Image mp_CodeImage_Namespace = Resources._namespace;
        private Image mp_CodeImage_Property = Resources._property;
        #endregion

        #endregion

        #region Properties
        #region Public properties

        #region Word lists
        /// <summary>
        /// Gets or Sets the keywords used for syntax highlightning and intellisense.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the keywords used for syntax highlightning and intellisense.")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public List<string> CodeWords_Keywords
        {
            get { return mp_CodeWords_Keywords; }
            set { mp_CodeWords_Keywords = value; }
        }

        /// <summary>
        /// Gets or Sets the types used for syntax highlightning and intellisense.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the types used for syntax highlightning and intellisense.")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public List<string> CodeWords_Types
        {
            get { return mp_CodeWords_Types; }
            set { mp_CodeWords_Types = value; }
        }

        /// <summary>
        /// Gets or Sets the functions used for syntax highlightning and intellisense.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the functions used for syntax highlightning and intellisense.")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public List<string> CodeWords_Functions
        {
            get { return mp_CodeWords_Functions; }
            set { mp_CodeWords_Functions = value; }
        }

        /// <summary>
        /// Gets or Sets the comment strings used for syntax highlightning.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the comment strings used for syntax highlightning.")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public List<string> CodeWords_Comments
        {
            get { return mp_CodeWords_Comments; }
            set { mp_CodeWords_Comments = value; }
        }

        /// <summary>
        /// Gets or Sets the comment strings used for syntax highlightning.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the object separator strings used for intellisense.")]
        [Editor("System.Windows.Forms.Design.StringCollectionEditor, System.Design", "System.Drawing.Design.UITypeEditor, System.Drawing")]
        public List<string> CodeWords_ScopeOperators
        {
            get { return mp_CodeWords_ScopeOperators; }
            set { mp_CodeWords_ScopeOperators = value; }
        }
        #endregion

        #region Syntax highlightning colors
        /// <summary>
        /// Gets or Sets the color of plain texts for syntax highlightning.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the color of plain texts for syntax highlightning.")]
        public Color CodeColor_PlainText
        {
            get { return mp_CodeColor_PlainText; }
            set { mp_CodeColor_PlainText = value; }
        }

        /// <summary>
        /// Gets or Sets the color of keywords for syntax highlightning.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the color of keywords for syntax highlightning.")]
        public Color CodeColor_Keyword
        {
            get { return mp_CodeColor_Keyword; }
            set { mp_CodeColor_Keyword = value; }
        }

        /// <summary>
        /// Gets or Sets the color of types for syntax highlightning.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the color of types for syntax highlightning.")]
        public Color CodeColor_Type
        {
            get { return mp_CodeColor_Type; }
            set { mp_CodeColor_Type = value; }
        }

        /// <summary>
        /// Gets or Sets the color of functions for syntax highlightning.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the color of functions for syntax highlightning.")]
        public Color CodeColor_Function
        {
            get { return mp_CodeColor_Function; }
            set { mp_CodeColor_Function = value; }
        }

        /// <summary>
        /// Gets or Sets the color of comments for syntax highlightning.
        /// </summary>
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the color of comments for syntax highlightning.")]
        public Color CodeColor_Comment
        {
            get { return mp_CodeColor_Comment; }
            set { mp_CodeColor_Comment = value; }
        }
        #endregion

        #region Intellisense images
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the intellisense image of keywords.")]
        public Image CodeImage_Class
        {
            get { return mp_CodeImage_Class; }
            set { mp_CodeImage_Class = value; }
        }

        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the intellisense image of events.")]
        public Image CodeImage_Event
        {
            get { return mp_CodeImage_Event; }
            set { mp_CodeImage_Event = value; }
        }

        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the intellisense image of interfaces.")]
        public Image CodeImage_Interface
        {
            get { return mp_CodeImage_Interface; }
            set { mp_CodeImage_Interface = value; }
        }

        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the intellisense image of methods.")]
        public Image CodeImage_Method
        {
            get { return mp_CodeImage_Method; }
            set { mp_CodeImage_Method = value; }
        }

        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the intellisense image of namespaces.")]
        public Image CodeImage_Namespace
        {
            get { return mp_CodeImage_Namespace; }
            set { mp_CodeImage_Namespace = value; }
        }

        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the intellisense image of properties.")]
        public Image CodeImage_Property
        {
            get { return mp_CodeImage_Property; }
            set { mp_CodeImage_Property = value; }
        }
        #endregion

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the intellisense item tree.")]
        public TreeView IntellisenseTree
        {
            get { return mp_IntellisenseTree; }
            set { mp_IntellisenseTree = value; }
        }

        [Browsable(true), Category("CodeTexbox"), Description("Gets or Sets the key to open intellisense.")]
        public Keys IntellisenseKey
        {
            get { return mp_IntellisenseKey; }
            set { mp_IntellisenseKey = value; }
        }

        public IntellisenseManager IntellisenseManager
        {
            get
            {
                return m_IntellisenseManager;
            }
            set
            {
                m_IntellisenseManager = value;
            }
        }

        public SyntaxHighlighter SyntaxHighlighter
        {
            get
            {
                return m_SyntaxHighLighter;
            }
        }
        #endregion

        #region Internal Properties
        /// <summary>
        /// Enables or disables the control's paint event.
        /// </summary>
        internal bool EnablePainting
        {
            get { return mp_EnablePainting; }
            set { mp_EnablePainting = value; }
        }
        /// <summary>
        /// Gets the intellisense's ImageListBox
        /// </summary>
        internal ImageListBox IntellisenseBox
        {
            get { return mp_IntellisenseBox; }
        }

        #endregion
        #endregion

        #region Constructors
        public CodeTextBox()
        {
            InitializeComponent();

            //Set some defaults...
            this.AcceptsTab = true;
            this.Font = new System.Drawing.Font(FontFamily.GenericMonospace, 8f);

            // TODO
            //
            //Do not enable drag and dropping text
            //The same problem, as paste - the onDragDrop event fires, BEFORE the text is written into the textbox
            //Need to be handled in WndPrc
            this.EnableAutoDragDrop = false;

            this.DetectUrls = false;
            this.WordWrap = false;
            this.AutoWordSelection = true;

            #region Instantiate Syntax highlightning and Intellisense members
            //Instantiate word lists
            mp_CodeWords_Keywords = new List<string>();
            mp_CodeWords_Types = new List<string>();
            mp_CodeWords_Functions = new List<string>();
            mp_CodeWords_Comments = new List<string>();
            mp_CodeWords_ScopeOperators = new List<string>();

            //Instantiate intellisense manager
            m_IntellisenseManager = new IntellisenseManager(this);

            //Instantiate the intellisense box
            mp_IntellisenseBox = new ImageListBox();

            //Instantiate intellisense tree
            mp_IntellisenseTree = new TreeView();
            #endregion

            #region Setup intellisense box
            //Setup intellisense box
            this.Controls.Add(mp_IntellisenseBox);
            mp_IntellisenseBox.Size = new Size(250, 150);
            mp_IntellisenseBox.Visible = false;
            mp_IntellisenseBox.KeyDown += new KeyEventHandler(mp_IntellisenseBox_KeyDown);
            mp_IntellisenseBox.DoubleClick += new EventHandler(mp_IntellisenseBox_DoubleClick);
            #endregion
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Force a full update of syntax highlightning
        /// </summary>
        public void UpdateSyntaxHightlight()
        {
            m_SyntaxHighLighter.Update(this);
            m_SyntaxHighLighter.DoSyntaxHightlight_AllLines(this);
        }
        #endregion

        #region Overridden methods

        #region Some overridden native function...
        private const int WM_COPY = 0x301;
        private const int WM_CUT = 0x300;
        private const int WM_PASTE = 0x302;
        private const int WM_CLEAR = 0x303;
        private const int WM_UNDO = 0x304;
        private const int EM_UNDO = 0xC7;
        private const int EM_CANUNDO = 0xC6;
        private const int WM_PAINT = 0x000F;
        private const int WM_CHAR = 0x102;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool PostMessage(
        IntPtr hWnd,// handle to destination window
        UInt32 Msg, // message
        IntPtr wParam, // first message parameter
        IntPtr lParam // second message parameter
        );

        /// <summary>
        /// Let control enable and disable it's drawing...
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case WM_PAINT:
                    {
                        #region PAINT
                        if (mp_EnablePainting)
                        {
                            base.WndProc(ref m);
                        }
                        else
                        {
                            m.Result = IntPtr.Zero;
                        }
                        #endregion
                    }
                    break;

                case WM_PASTE:
                    {
                        #region PASTE_Clipboard Contain Text
                        if (Clipboard.ContainsText())
                        {
                            int selectionStart = this.SelectionStart;
                            int selectionLength = 0;

                            string text = Clipboard.GetText();


                            #region Hack to find out correct selection length
                            //Hack...
                            //The text's length readed from the clipboard doesn't match the length pasted to the richTextBox
                            //So I used a dummy richtextbox, to find out the correct length of the text...
                            RichTextBox rtxt = new RichTextBox();
                            rtxt.SelectionStart = 0;
                            rtxt.SelectedText = text;
                            selectionLength = rtxt.Text.Length;
                            #endregion


                            //Paste text from the clipboard...
                            this.SelectedText = text;

                            m_SyntaxHighLighter.DoSyntaxHightlight_Selection(this, selectionStart, selectionLength);
                        }
                        #endregion
                        #region PASTE_Clipboard Contain Images
                        else
                        {
                            DataFormats.Format dataFormat;
                            dataFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                            System.Collections.Specialized.StringCollection stringCollection = Clipboard.GetFileDropList();
                            if (stringCollection.Count != 0)
                            {
                                Image image = Image.FromFile(stringCollection[0]);
                                Clipboard.Clear();
                                Clipboard.SetImage(image);
                                if (Clipboard.ContainsImage() && this.CanPaste(dataFormat))
                                {
                                    this.Paste(dataFormat);
                                }
                            }
                            else
                            {
                                dataFormat = DataFormats.GetFormat(DataFormats.Rtf);
                                this.Paste(dataFormat);
                            }
                        }
                        #endregion
                    }
                    break;
                case WM_COPY:
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(this.SelectedRtf, TextDataFormat.Rtf);
                    }
                    break;
                default:
                    {
                        base.WndProc(ref m);
                    }
                    break;
            }
        }
        /// <summary>
        /// I needed this for the WM_PASTE event to fire...
        /// </summary>
        /// <param name="m"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message m, Keys keyData)
        {
            switch (keyData)
            {
                #region Paste
                case Keys.Control | Keys.V:
                    {
                        PostMessage(this.Handle, WM_PASTE, IntPtr.Zero, IntPtr.Zero);
                        return true;
                    }
                case Keys.Shift | Keys.Insert:
                    {
                        PostMessage(this.Handle, WM_PASTE, IntPtr.Zero, IntPtr.Zero);
                        return true;
                    }
                #endregion

                #region Copy
                case Keys.Control | Keys.C:
                    {
                        PostMessage(this.Handle, WM_COPY, IntPtr.Zero, IntPtr.Zero);
                        return true;
                    }
                case Keys.Control | Keys.Insert:
                    {
                        PostMessage(this.Handle, WM_COPY, IntPtr.Zero, IntPtr.Zero);
                        return true;
                    }
                #endregion

                #region Cut
                case Keys.Control | Keys.X:
                    {
                        PostMessage(this.Handle, WM_CUT, IntPtr.Zero, IntPtr.Zero);
                        return true;
                    }
                case Keys.Shift | Keys.Delete:
                    {
                        PostMessage(this.Handle, WM_CUT, IntPtr.Zero, IntPtr.Zero);
                        return true;
                    }
                #endregion

                #region Delete
                case Keys.Control | Keys.Delete:
                    {
                        PostMessage(this.Handle, WM_CLEAR, IntPtr.Zero, IntPtr.Zero);
                        return true;
                    }
                #endregion

                #region Undo
                case Keys.Control | Keys.Z:
                    {
                        PostMessage(this.Handle, WM_UNDO, IntPtr.Zero, IntPtr.Zero);
                        return true;
                    }
                #endregion

                default:
                    return base.ProcessCmdKey(ref m, keyData);
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (EnablePainting)
            {
                base.OnPaint(pe);
            }
        }

        void mp_IntellisenseBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Let the textbox handle keypresses inside the intellisense box            
            OnKeyDown(e);
        }
        void mp_IntellisenseBox_DoubleClick(object sender, EventArgs e)
        {
            m_IntellisenseManager.ConfirmIntellisense();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (mp_IntellisenseBox.Visible)
            {
                #region ESCAPE - Hide Intellisense
                if (e.KeyCode == Keys.Escape)
                {
                    m_IntellisenseManager.HideIntellisenseBox();
                    e.Handled = true;
                }
                #endregion

                #region Navigation - Up, Down, PageUp, PageDown, Home, End
                else if (e.KeyCode == Keys.Up)
                {
                    m_IntellisenseManager.NavigateUp(1);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Down)
                {
                    m_IntellisenseManager.NavigateDown(1);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.PageUp)
                {
                    m_IntellisenseManager.NavigateUp(10);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.PageDown)
                {
                    m_IntellisenseManager.NavigateDown(10);
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.Home)
                {
                    m_IntellisenseManager.NavigateHome();
                    e.Handled = true;
                }
                else if (e.KeyCode == Keys.End)
                {
                    m_IntellisenseManager.NavigateEnd();
                    e.Handled = true;
                }
                #endregion
                else if (e.KeyCode == Keys.Enter)
                {
                    m_IntellisenseManager.ConfirmIntellisense();
                    e.Handled = true;
                }
            }

            this.Focus();
            base.OnKeyDown(e);
        }
        #endregion

        private void CodeTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                string keyWord = RichTextboxHelper.GetKeyWord(this);
                if (!string.IsNullOrEmpty(keyWord))
                {
                    IntellisenseManager.ShowIntellisenseBox(keyWord);
                }
                else
                {
                    IntellisenseManager.HideIntellisenseBox();
                }
            }
        }

        private void CodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //string keyWord = RichTextboxHelper.GetKeyWord(this);
            //if (!string.IsNullOrEmpty(keyWord))
            //{
            //    e.Handled = true;
            //}
            //else
            //{
            //    e.Handled = false;
            //}
            //IntellisenseManager.HideIntellisenseBox();
        }

        #region Print
        /// <summary>
        /// Calculate or render the contents of our RichTextBox for printing
        /// </summary>
        /// <param name="measureOnly">If true, only the calculation is performed,
        /// otherwise the text is rendered as well</param>
        /// <param name="e">The PrintPageEventArgs object from the
        /// PrintPage event</param>
        /// <param name="charFrom">Index of first character to be printed</param>
        /// <param name="charTo">Index of last character to be printed</param>
        /// <returns>(Index of last character that fitted on the
        /// page) + 1</returns>
        public int FormatRange(bool measureOnly, PrintPageEventArgs e, int charFrom, int charTo)
        {
            // Specify which characters to print
            STRUCT_CHARRANGE cr;
            cr.CpMin = charFrom;
            cr.CpMax = charTo;

            // Specify the area inside page margins
            STRUCT_RECT rc;
            rc.Top = HundredthInchToTwips(e.MarginBounds.Top);
            rc.Bottom = HundredthInchToTwips(e.MarginBounds.Bottom);
            rc.Left = HundredthInchToTwips(e.MarginBounds.Left);
            rc.Right = HundredthInchToTwips(e.MarginBounds.Right);

            // Specify the page area
            STRUCT_RECT rcPage;
            rcPage.Top = HundredthInchToTwips(e.PageBounds.Top);
            rcPage.Bottom = HundredthInchToTwips(e.PageBounds.Bottom);
            rcPage.Left = HundredthInchToTwips(e.PageBounds.Left);
            rcPage.Right = HundredthInchToTwips(e.PageBounds.Right);

            // Get device context of output device
            IntPtr hdc = e.Graphics.GetHdc();

            // Fill in the FORMATRANGE struct
            STRUCT_FORMATRANGE fr;
            fr.Chrg = cr;
            fr.Hdc = hdc;
            fr.HdcTarget = hdc;
            fr.Rc = rc;
            fr.RcPage = rcPage;

            // Non-Zero wParam means render, Zero means measure
            Int32 wParam = (measureOnly ? 0 : 1);

            // Allocate memory for the FORMATRANGE struct and
            // copy the contents of our struct to this memory
            IntPtr lParam = Marshal.AllocCoTaskMem(Marshal.SizeOf(fr));
            Marshal.StructureToPtr(fr, lParam, false);

            // Send the actual Win32 message
            int res = SendMessage(Handle, EM_FORMATRANGE, wParam, lParam);

            // Free allocated memory
            Marshal.FreeCoTaskMem(lParam);

            // and release the device context
            e.Graphics.ReleaseHdc(hdc);

            return res;
        }

        /// <summary>
        /// Convert between 1/100 inch (unit used by the .NET framework)
        /// and twips (1/1440 inch, used by Win32 API calls)
        /// </summary>
        /// <param name="n">Value in 1/100 inch</param>
        /// <returns>Value in twips</returns>
        private Int32 HundredthInchToTwips(int n)
        {
            return (Int32)(n * 14.4);
        }

        /// <summary>
        /// Free cached data from rich edit control after printing
        /// </summary>
        public void FormatRangeDone()
        {
            IntPtr lParam = new IntPtr(0);
            SendMessage(Handle, EM_FORMATRANGE, 0, lParam);
        }
        #endregion
    }
}
