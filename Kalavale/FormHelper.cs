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
                    if (c is TextBox)
                        c.Text = "";
                    else
                        Clear(c.Controls);
            };

            Clear(control.Controls);
        }

        // true jos kaikki kontrollin kentät on täytetty
        public static bool ValidateFields(Control control) {
            Action<Control.ControlCollection> Validate = null;
            bool ret = true;

            Validate = (controls) => {
                foreach (Control c in controls)
                    if (c is TextBox)
                        if(c.Text.Length < 1)
                            ret = false;
                    else
                        Validate(c.Controls);
            };

            if(control != null)
                Validate(control.Controls);

            return ret;
        }
    }
}
