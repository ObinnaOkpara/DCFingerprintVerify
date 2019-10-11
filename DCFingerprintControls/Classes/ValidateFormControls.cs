using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCFingerprintControls.Classes
{
    public static class ValidateFormControls
    {
        public static bool CheckTextboxes(Control control, ErrorProvider ep)
        {
            //var txtboxes = control.OfType<TextBox>();//.Where(box => box.Name.StartsWith("_"));

            foreach (var tbox in GetAllChildren(control).OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(tbox.Text))
                {
                    ep.SetError(tbox, "Please fill the required field");
                    return false;
                }
                ep.SetError(tbox, null);
            }

            return true;
        }

        public static bool CheckComboBoxes(Control control, ErrorProvider ep)
        {
            //var txtboxes = control.OfType<TextBox>();//.Where(box => box.Name.StartsWith("_"));
            foreach (var cmbox in GetAllChildren(control).OfType<ComboBox>())
            {
                if (cmbox.SelectedIndex == -1)
                {
                    ep.SetError(cmbox, "Please select the required field");
                    return false;
                }
                else if (cmbox.Text == "--Select--")
                {
                    ep.SetError(cmbox, "Please select the required field");
                    return false;
                }

                ep.SetError(cmbox, null);
            }

            return true;
        }

        public static bool CheckPassword(string first_password, string second_password)
        {
            //confirm password
            if (!string.Equals(first_password, second_password))
            {
                MessageBox.Show("Password not the same");
                return false;
            }
            return true;
        }

        public static IEnumerable<Control> GetAllChildren(this Control root)
        {
            var stack = new Stack<Control>();
            stack.Push(root);

            while (stack.Any())
            {
                var next = stack.Pop();
                foreach (Control child in next.Controls)
                    stack.Push(child);
                yield return next;
            }
        }
    }
}
