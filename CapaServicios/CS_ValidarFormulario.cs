using System.Windows.Forms;

namespace CapaServicios
{
    public class CS_ValidarFormulario
    {

        public bool Validar(Control form)
        {
            foreach (Control control in form.Controls)
            {
                // Validar TextBox no esté vacío
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
                // Validar NumericUpDown no sea 0
                else if (control is NumericUpDown numericUpDown)
                {
                    if (numericUpDown.Value == 0)
                    {
                        return false;
                    }
                }
                // Validar ComboBox tenga un ítem seleccionado
                else if (control is ComboBox comboBox)
                {
                    if (comboBox.SelectedIndex == -1 || comboBox.SelectedIndex == 0)
                    {

                    }
                }
            }
            return true;
        }
    }
}
