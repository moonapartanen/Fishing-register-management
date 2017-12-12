using System;
using System.Windows.Forms;

namespace Kalavale {
    static class FormHelper {
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

        public static void ClearErrors(Control control, ErrorProvider provider) {
            foreach (Control c in control.Controls) {
                provider.SetError(c, string.Empty);
                ClearErrors(c, provider);
            }
        }

        public static bool ValidateTextFields(Control control, ErrorProvider provider) {
            Action<Control.ControlCollection> Validate = null;
            bool isValid = true;

            Validate = (controls) => {
                foreach (Control c in controls) {
                    if (c is TextBox) {
                        if (c.Text.Length < 1) {
                            isValid = false;
                            provider.SetError(c, "Tämä kenttä on pakollinen");
                        }
                    } else {
                        Validate(c.Controls);
                    }
                }
            };

            Validate(control.Controls);

            return isValid;
        }
    }
}
