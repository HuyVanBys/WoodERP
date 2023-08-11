using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BOSERP
{
    internal class RichTextboxHelper
    {
        #region Constant
        private const string StartLine = "\\pard";
        private const string EndLine = "\\par";
        private const string BackSlash = "\\";
        private const string AnchorWord = "<#>";
        private const char SpaceChar = ' ';
        private const string SpaceString = " ";
        private const string TabString = "\\tab";
        #endregion

        public static string GetLastWord(RichTextBox richTextbox)
        {
            int pos = richTextbox.SelectionStart;

            while (pos > 1)
            {
                string substr = richTextbox.Text.Substring(pos - 1, 1);

                if (Char.IsWhiteSpace(substr, 0) || ":(),{}=.[]".Contains(substr))
                {
                    return richTextbox.Text.Substring(pos, richTextbox.SelectionStart - pos);
                }

                pos--;
            }

            return richTextbox.Text.Substring(0, richTextbox.SelectionStart);
        }

        public static string GetLastLine(RichTextBox richTextbox)
        {
            int charIndex = richTextbox.SelectionStart;
            int currentLineNumber = richTextbox.GetLineFromCharIndex(charIndex);

            // the carriage return hasn't happened yet... 
            // so the 'previous' line is the current one.
            string previousLineText;
            if (richTextbox.Lines.Length <= currentLineNumber)
                previousLineText = richTextbox.Lines[richTextbox.Lines.Length - 1];
            else
                previousLineText = richTextbox.Lines[currentLineNumber];

            return previousLineText;
        }

        public static string GetCurrentLine(RichTextBox richTextbox)
        {
            int charIndex = richTextbox.SelectionStart;
            int currentLineNumber = richTextbox.GetLineFromCharIndex(charIndex);

            if (currentLineNumber < richTextbox.Lines.Length)
            {
                return richTextbox.Lines[currentLineNumber];
            }
            else
            {
                return string.Empty;
            }
        }

        public static int GetCurrentLineStartIndex(RichTextBox richTextbox)
        {
            return richTextbox.GetFirstCharIndexOfCurrentLine();
        }

        public static string GetKeyWord(RichTextBox rtb, ref int start, ref int end)
        {
            start = rtb.SelectionStart;
            int count = 0;
            while (start > 0 && count < 512)
            {
                char quote = Convert.ToChar(rtb.Text.Substring(start - 1, 1));
                if (quote == 171)
                {
                    break;
                }
                else if (quote == 187)
                {
                    return string.Empty;
                }
                start--;
                count++;
            }

            end = rtb.SelectionStart;
            count = 0;
            while (end < rtb.Text.Length && count < 512)
            {
                char quote = Convert.ToChar(rtb.Text.Substring(end, 1));
                if (quote == 187)
                {
                    break;
                }
                else if (quote == 171)
                {
                    return string.Empty;
                }
                end++;
                count++;
            }

            if (start > 0 && end < rtb.Text.Length)
            {
                return rtb.Text.Substring(start, end - start);
            }
            return string.Empty;
        }

        public static string GetKeyWord(RichTextBox rtb)
        {
            int start = 0;
            int end = 0;
            string keyWord = GetKeyWord(rtb, ref start, ref end);
            return keyWord;
        }

        public static string RemoveAllKeyWords(RichTextBox rtb)
        {
            RichTextBox temp = new RichTextBox();
            temp.Rtf = rtb.Rtf;
            for (int i = 0; i < temp.Text.Length; i++)
            {
                if (temp.Text[i] == Convert.ToChar(171))
                {
                    for (int j = i + 1; j < temp.Text.Length; j++)
                    {
                        if (temp.Text[j] == Convert.ToChar(187))
                        {
                            // Process the words                            
                            temp.SelectionStart = i;
                            temp.SelectionLength = j - i + 1;
                            temp.SelectedText = string.Empty;
                            i--;
                            break;
                        }
                    }
                }
            }
            return temp.Rtf;
        }

        public static void Replace(RichTextBox rtb, string oldValue, string newValue)
        {
            int index = rtb.Text.IndexOf(oldValue, 0);
            while (index >= 0)
            {
                rtb.SelectionStart = index;
                rtb.SelectionLength = oldValue.Length;
                rtb.SelectedText = newValue;
                index = rtb.Text.IndexOf(oldValue, index);
            }
        }

        /// <summary>
        /// Remove entire row in RichTextBoxExtended
        /// </summary>
        public static string RemoveLineFromRichTextBox(RichTextBox richTextBox)
        {
            string rtf = richTextBox.Rtf;
            string rtfEnd = String.Empty;
            char[] charEndLine = Environment.NewLine.ToCharArray();
            string[] lines = rtf.Split(charEndLine);
            for (int i = 0; i < lines.Length - 1; i++)
            {
                #region Line contains anchor word
                if (lines[i].Contains(AnchorWord))
                {
                    string line = lines[i];
                    if (line.Contains(EndLine))
                    {
                        line = RemoveEndLine(line);
                    }

                    bool isRemoved = IsRemovedLine(line);
                    if (isRemoved)
                    {
                        line = RemovePlainText(line);
                        if (line.Contains(SpaceString))
                            line = line.Replace(SpaceString, String.Empty);
                        if (line.Contains(TabString))
                            line = line.Replace(TabString, String.Empty);
                        rtfEnd += line + Environment.NewLine;
                    }
                    else
                    {
                        line = line.Replace(AnchorWord, String.Empty);
                        rtfEnd += line + EndLine + Environment.NewLine;
                    }

                }
                #endregion

                #region Line do not contain anchor word
                else
                {
                    rtfEnd += lines[i] + Environment.NewLine;
                }
                #endregion
            }
            return rtfEnd;
        }

        /// <summary>
        /// Check whether a line should be removed
        /// </summary>
        /// <param name="line">Line needs to be checked</param>
        /// <returns>True if the line should be removed, otherwise false</returns>
        private static bool IsRemovedLine(string line)
        {
            int posAnchorWord = line.IndexOf(AnchorWord);
            string temp = line.Substring(0, posAnchorWord + AnchorWord.Length);
            string subString = line.Substring(posAnchorWord + AnchorWord.Length, line.Length - posAnchorWord - AnchorWord.Length);
            string[] words = subString.Split(new char[] { SpaceChar });
            while (subString.Contains(BackSlash))
            {
                foreach (string word in words)
                {
                    if (word.Contains(BackSlash))
                    {
                        int pos = word.IndexOf(BackSlash);
                        string tempWord = word.Substring(pos, word.Length - pos);
                        subString = subString.Replace(tempWord, String.Empty);
                        words = subString.Split(new char[] { SpaceChar });
                    }
                }
            }
            if (subString.Contains(SpaceChar.ToString()))
            {
                subString = subString.Replace(SpaceChar.ToString(), String.Empty);
            }
            if (string.IsNullOrEmpty(subString))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remove plain text from rtf string
        /// </summary>
        /// <param name="rtf">Rtf string</param>
        /// <returns>String contains rtf characters only</returns>
        public static string RemovePlainText(string rtf)
        {
            string result = string.Empty;
            List<string> words = new List<string>();
            for (int i = 0; i < rtf.Length; i++)
            {
                if (rtf[i].ToString() == BackSlash)
                {
                    string word = BackSlash;
                    for (int j = i + 1; j < rtf.Length; j++)
                    {
                        if (rtf[j] == SpaceChar || rtf[j].ToString() == BackSlash)
                        {
                            i = j - 1;
                            break;
                        }
                        word += rtf[j].ToString();
                    }
                    words.Add(word);
                }
            }

            foreach (string word in words)
            {
                if (!IsPlainText(word))
                {
                    result += word + SpaceChar.ToString();
                }
            }
            return result;
        }

        /// <summary>
        /// Check whether a word is plain text
        /// </summary>
        /// <param name="word">Word</param>
        /// <returns>True if the word is plain text, otherwise false</returns>
        public static bool IsPlainText(string word)
        {
            if (word.Contains("\\'"))
            {
                return true;
            }
            if (word.Contains("\\u"))
            {
                int index = word.IndexOf("\\u");
                if (index + 5 < word.Length)
                {
                    string decNotation = word.Substring(index + 2, 4);
                    int dec;
                    if (int.TryParse(decNotation, out dec))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Remove endline character of rtf line
        /// </summary>
        /// <param name="rtf">Rtf line</param>
        /// <returns>Rtf line after remove endline character</returns>
        public static string RemoveEndLine(string rtf)
        {
            string result = String.Empty;
            int pos = rtf.LastIndexOf(EndLine);
            result = rtf.Substring(0, pos);
            return result;

        }

        /// <summary>
        /// Remove all anchor words from a template
        /// </summary>
        /// <param name="rtb">Rich text box contains the template</param>
        /// <returns>Rtf string after removing</returns>
        public static string RemoveAllAnchorWords(RichTextBox rtb)
        {
            RichTextBox temp = new RichTextBox();
            temp.Rtf = rtb.Rtf;
            RichTextboxHelper.Replace(temp, AnchorWord, string.Empty);
            return temp.Rtf;
        }
    }
}
