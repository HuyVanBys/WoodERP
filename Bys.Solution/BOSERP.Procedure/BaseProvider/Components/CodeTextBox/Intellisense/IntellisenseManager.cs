using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BOSERP
{
    public class IntellisenseManager
    {
        #region Variables
        private CodeTextBox m_CodeTextBox = null;
        private bool m_LastCharWasAScopeOperator;
        #endregion

        #region Constructors
        public IntellisenseManager(CodeTextBox parent)
        {
            m_CodeTextBox = parent;
        }
        #endregion

        public CodeTextBox CodeTextBox
        {
            get
            {
                return m_CodeTextBox;
            }
        }

        #region Methods
        /// <summary>
        /// Show intellisense box
        /// </summary>
        /// <param name="value">Value is used to update intellisense</param>
        public virtual void ShowIntellisenseBox(object value)
        {

        }

        /// <summary>
        /// Shows the intellisense box.
        /// </summary>
        public void ShowIntellisenseBox(IList<string> items)
        {
            if (m_CodeTextBox.IntellisenseTree == null)
            {
                return;
            }

            //If our box has no elements, do not show it...
            if (!UpdateIntellisense(items))
            {
                return;
            }

            ShowIntellisenseBoxWithoutUpdate();
        }

        internal void ShowIntellisenseBoxWithoutUpdate()
        {
            if (m_CodeTextBox.IntellisenseTree == null)
            {
                return;
            }

            //our box has some elements, choose the first
            try
            {
                m_CodeTextBox.IntellisenseBox.SelectedIndex = 0;
            }
            catch { }


            //Get top-left coordinate for our intellisenseBox
            Point topLeft = m_CodeTextBox.GetPositionFromCharIndex(m_CodeTextBox.SelectionStart);
            topLeft.Offset(-10, 15);

            #region Place the intellisense box, to fit the space...
            if (m_CodeTextBox.Size.Height < (topLeft.Y + m_CodeTextBox.IntellisenseBox.Height / 3))
            {
                topLeft.Offset(0, -15 - m_CodeTextBox.IntellisenseBox.Height);
            }

            if (m_CodeTextBox.Size.Width < (topLeft.X + m_CodeTextBox.IntellisenseBox.Width / 3))
            {
                topLeft.Offset(-m_CodeTextBox.IntellisenseBox.Width, 0);
            }

            if (topLeft.X < 0)
            {
                topLeft.X = 0;
            }

            if (topLeft.Y < 0)
            {
                topLeft.Y = 0;
            }
            #endregion

            m_CodeTextBox.IntellisenseBox.Location = topLeft;
            m_CodeTextBox.IntellisenseBox.Visible = true;
            m_CodeTextBox.Focus();
        }
        /// <summary>
        /// Hides the intellisense box.
        /// </summary>
        public void HideIntellisenseBox()
        {
            m_CodeTextBox.IntellisenseBox.Items.Clear();
            m_CodeTextBox.IntellisenseBox.Visible = false;
        }
        /// <summary>
        /// Navigates up in the intellisense box.
        /// </summary>
        public void NavigateUp(int elements)
        {
            #region Some checkings for the intellisense box
            //Do nothing if the intellisense is not visible...
            if (!m_CodeTextBox.IntellisenseBox.Visible)
            {
                return;
            }
            //If our box has no elements, do not show it...
            if (m_CodeTextBox.IntellisenseBox.Items.Count <= 0)
            {
                return;
            }
            #endregion

            if (m_CodeTextBox.IntellisenseBox.SelectedIndex > elements - 1)
            {
                m_CodeTextBox.IntellisenseBox.SelectedIndex -= elements;
            }
            else
            {
                m_CodeTextBox.IntellisenseBox.SelectedIndex = 0;
            }
        }
        /// <summary>
        /// Navigates down in the intellisense box.
        /// </summary>
        public void NavigateDown(int elements)
        {
            #region Some checkings for the intellisense box
            //Do nothing if the intellisense is not visible...
            if (!m_CodeTextBox.IntellisenseBox.Visible)
            {
                return;
            }
            //If our box has no elements, do not show it...
            if (m_CodeTextBox.IntellisenseBox.Items.Count <= 0)
            {
                return;
            }
            #endregion

            if (m_CodeTextBox.IntellisenseBox.SelectedIndex < m_CodeTextBox.IntellisenseBox.Items.Count - elements - 1)
            {
                m_CodeTextBox.IntellisenseBox.SelectedIndex += elements;
            }
            else
            {
                m_CodeTextBox.IntellisenseBox.SelectedIndex = m_CodeTextBox.IntellisenseBox.Items.Count - 1;
            }
        }
        /// <summary>
        /// Navigates to the first element in the intellisense box.
        /// </summary>
        public void NavigateHome()
        {
            #region Some checkings for the intellisense box
            //Do nothing if the intellisense is not visible...
            if (!m_CodeTextBox.IntellisenseBox.Visible)
            {
                return;
            }
            //If our box has no elements, do not show it...
            if (m_CodeTextBox.IntellisenseBox.Items.Count <= 0)
            {
                return;
            }
            #endregion

            m_CodeTextBox.IntellisenseBox.SelectedIndex = 0;
        }
        /// <summary>
        /// Navigates to the last element in the intellisense box.
        /// </summary>
        public void NavigateEnd()
        {
            #region Some checkings for the intellisense box
            //Do nothing if the intellisense is not visible...
            if (!m_CodeTextBox.IntellisenseBox.Visible)
            {
                return;
            }
            //If our box has no elements, do not show it...
            if (m_CodeTextBox.IntellisenseBox.Items.Count <= 0)
            {
                return;
            }
            #endregion

            m_CodeTextBox.IntellisenseBox.SelectedIndex = m_CodeTextBox.IntellisenseBox.Items.Count - 1;
        }

        /// <summary>
        /// Updates the intellisense box's elements to show the right object list.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public bool UpdateIntellisense(IList<string> items)
        {
            //Clear all elements
            m_CodeTextBox.IntellisenseBox.Items.Clear();

            foreach (string item in items)
            {
                ImageListItem li = new ImageListItem();
                li.Text = item;
                li.Image = m_CodeTextBox.CodeImage_Method;

                m_CodeTextBox.IntellisenseBox.Items.Add(li);
            }

            //Not show, when no elements available...
            if (m_CodeTextBox.IntellisenseBox.Items.Count > 0)
            {
                ShowIntellisenseBoxWithoutUpdate();
                return true;
            }

            HideIntellisenseBox();
            return false;
        }

        /// <summary>
        /// Confirms the selection from the intellisense, and write the selected text back to the textbox.
        /// </summary>
        public virtual void ConfirmIntellisense()
        {
            string wordSelected;

            try
            {
                wordSelected = ((ImageListItem)m_CodeTextBox.IntellisenseBox.SelectedItem).Text;
            }
            catch
            {
                return;
            }

            //Get the actual position
            int currentPosition = m_CodeTextBox.SelectionStart;
            //Get the start position of the last word
            int lastWordPosition = GetLastWordStartPosition(m_CodeTextBox, m_CodeTextBox.CodeWords_ScopeOperators);

            //Set selection
            m_CodeTextBox.SelectionStart = lastWordPosition;
            m_CodeTextBox.SelectionLength = currentPosition - lastWordPosition;

            //Change the word
            m_CodeTextBox.SelectedText = wordSelected;

            //Hide the intellisense
            HideIntellisenseBox();
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Searches for the first node in the given node's nodes, which name starts with the text.
        /// If the node is null, it searches the tree.
        /// </summary>
        /// <param name="node"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private TreeNode SearchLike(TreeNode node, string text)
        {
            if (node == null)
            {
                //search tree
                foreach (TreeNode n in m_CodeTextBox.IntellisenseTree.Nodes)
                {
                    if (Like(n, text))
                    {
                        return n;
                    }
                }
            }
            else
            {
                //search node
                foreach (TreeNode n in node.Nodes)
                {
                    if (Like(n, text))
                    {
                        return n;
                    }
                }
            }

            return null;
        }
        /// <summary>
        /// Returns true if the tag's name likes the text
        /// </summary>
        /// <param name="node"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool Like(TreeNode node, string text)
        {
            if (text == "")
            {
                return true;
            }

            return node.Name.ToLower().StartsWith(text.ToLower());
        }

        /// <summary>
        /// Returns the position of the last word. Position searching takes care of scope operators!
        /// </summary>
        /// <param name="richTextbox"></param>
        /// <param name="scopeOperators"></param>
        /// <returns></returns>
        public int GetLastWordStartPosition(RichTextBox richTextbox, List<string> scopeOperators)
        {
            int pos = richTextbox.SelectionStart;
            List<string> lastScopeOperatorChars = GetLastCharsOfScopeOperators();

            //If the last char was a scope separator, we need the current position...
            if (m_LastCharWasAScopeOperator)
            {
                return richTextbox.SelectionStart;
            }
            try
            {
                //If we deleted the last char, and arrive at a scope operator...
                string lastWord = RichTextboxHelper.GetLastWord(m_CodeTextBox);
                string lastChar = lastWord.Substring(lastWord.Length - 1, 1);
                if (lastScopeOperatorChars.Contains(lastChar))
                {
                    return richTextbox.SelectionStart;
                }
            }
            catch { }

            while (pos > 1)
            {
                string substr = richTextbox.Text.Substring(pos - 1, 1);

                if (Char.IsWhiteSpace(substr, 0) || substr == "\n" || substr == "\t" || ":(),{}=.[]".Contains(substr))
                {
                    return pos;
                }
                else if (lastScopeOperatorChars.Contains(substr))
                {
                    return pos;
                }

                pos--;
            }

            return 0;
        }
        /// <summary>
        /// Returns the last chars of scope operators
        /// </summary>
        /// <returns></returns>
        private List<string> GetLastCharsOfScopeOperators()
        {
            List<string> scopeOperatorLastCharList = new List<string>();

            foreach (string s in m_CodeTextBox.CodeWords_ScopeOperators)
            {
                if (String.IsNullOrEmpty(s))
                {
                    continue;
                }
                scopeOperatorLastCharList.Add(s.Substring(s.Length - 1, 1));
            }

            return scopeOperatorLastCharList;
        }
        /// <summary>
        /// Checks, if the actual char is a scope operator, and sets the state of the
        /// m_LastCharWasAScopeOperator variable
        /// </summary>
        /// <param name="c"></param>
        internal void CheckScopeOperator(char c)
        {
            List<string> lastScopeOperatorLetters = GetLastCharsOfScopeOperators();
            m_LastCharWasAScopeOperator = lastScopeOperatorLetters.Contains(c.ToString());
        }
        #endregion      
    }
}
