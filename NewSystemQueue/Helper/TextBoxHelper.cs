using System.Windows.Forms;

namespace NewSystemQueue.Helper
{
    public static class TextBoxHelper
    {
        /// <summary>
        /// this method to clear text inside text box 
        /// </summary>
        /// <param name="form">form control pass to clear data</param>
        public static void ClearText(Form form)
        {

            foreach (Control control in form.Controls)
            {
                if (control is TextBox text)
                {
                    text.Clear();
                }
            }
        }
        /// <summary>
        /// this method to Check If Text in Text Box is Number
        /// </summary>
        /// <param name="form">form control pass to clear data</param>
        public static bool CheckIfNegtiaveNumber(params TextBox[] texts)
        {

            foreach (TextBox text in texts)
            {
                if (text.Text.Contains("-"))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
