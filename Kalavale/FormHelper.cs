using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Kalavale {
    static class FormHelper {
        // tyhjentää kontrollin täytettävät kentät
        public static void ClearFields(Control control) {
            Action<Control.ControlCollection> Clear = null;

            Clear = (controls) => {
                foreach (Control c in controls)
                    if (c is TextBox) {
                        c.Text = "";
                    } else if (c is ComboBox) {
                        ComboBox cbo = c as ComboBox;

                        if (cbo.DataSource != null) {
                            cbo.SelectedIndex = 0;
                        }
                    } else if (c is NumericUpDown)
                        (c as NumericUpDown).Value = (c as NumericUpDown).Minimum;
                    else
                        Clear(c.Controls);
            };

            Clear(control.Controls);
        }

        // true jos kaikki kontrollin tekstikentät on täytetty
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
