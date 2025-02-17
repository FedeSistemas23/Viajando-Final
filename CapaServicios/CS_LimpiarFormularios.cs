using System.Windows.Forms;
using Control = System.Windows.Forms.Control;
using TextBox = System.Windows.Forms.TextBox;

namespace CapaServicios
{
    public class CS_LimpiarFormularios
    {
        public void Limpiar(Control form)
        {
            foreach (Control control in form.Controls)
            {
                // Limpiar TextBox
                if (control is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
                // Limpiar NumericUpDown
                else if (control is NumericUpDown numericUpDown)
                {
                    numericUpDown.Value = 0;
                }
                // Limpiar ComboBox
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.Items.Count > 0)
                    {
                        comboBox.SelectedIndex = 0;
                    }
                }
                else if (control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }

                // Si el control tiene hijos, aplicar la función recursivamente
                if (control.HasChildren)
                {
                    Limpiar(control);
                }
            }
        }
    }
}
