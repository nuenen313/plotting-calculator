using System;
using System.Linq;
using System.Windows.Forms;

namespace calculate
{
    public class Calculator
    {

        public Calculator()
        {
            
        }

        public static void DisableAllButtonsExcept(params Button[] buttonsToKeepEnabled)
        {
            foreach (Control control in Application.OpenForms[0].Controls)
            {
                if (control is Button button)
                {
                    if (!buttonsToKeepEnabled.Contains(button))
                    {
                        button.Enabled = false;
                    }
                }
            }
        }

        public static void EnableAllButtons()
        {
            foreach (Control control in Application.OpenForms[0].Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                }
            }
        }

        public static bool CheckTextLength(TextBox textEditor, params Button[] buttonsToKeepEnabled)
        {
            if (textEditor.Text.Length > 30)
            {
                textEditor.Text = "Value is too large to compute";
                DisableAllButtonsExcept(buttonsToKeepEnabled);
                return true;
            }
            return false;
        }

    }
}
