using System;
using System.Windows.Forms;

namespace Kalavale {
    static class FormHelper {
        // Asetetaan kontrolli ja sen kaikki lapset oletusarvoon rekursiivisesti.
        public static void ClearFields(Control control) {
            foreach (Control c in control.Controls) {
                if (c is TextBox) {
                    c.Text = "";
                } else if (c is ComboBox) {
                    ComboBox cbo = c as ComboBox;
                    if (cbo.DataSource != null)
                        cbo.SelectedIndex = 0;
                } else if (c is NumericUpDown) {
                    NumericUpDown num = c as NumericUpDown;
                    num.Value = num.Minimum;
                } else {
                    ClearFields(c);
                }
            }
        }

        // Poistetaan kontrollin ja sen kaikkien lapsien virheilmoitukset rekursiivisesti.
        public static void ClearErrors(Control control, ErrorProvider provider) {
            foreach (Control c in control.Controls) {
                provider.SetError(c, string.Empty);
                ClearErrors(c, provider);
            }
        }

        public static bool ValidateTextFields(Control control) {
            Action<Control.ControlCollection> Validate = null;
            bool ret = true;

            Validate = (controls) => {
                foreach (Control c in controls)
                    if (c is TextBox && ret == true)
                        ret = c.Text.Length > 0;
                    else
                        Validate(c.Controls);
            };

            Validate(control.Controls);

            return ret;
        }
    }
}
