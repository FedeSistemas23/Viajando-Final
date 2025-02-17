using CapaNegocio;
using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmConfiguracionDelSistema : Form
    {
        CN_BackUp backup = new CN_BackUp();
        public FrmConfiguracionDelSistema()
        {
            InitializeComponent();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de Backup (*.bak)|*.bak";
            saveFileDialog.Title = "Guardar Backup de la Base de Datos";
            saveFileDialog.FileName = "Backup.bak";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaDestino = saveFileDialog.FileName;

                try
                {
                    backup.RealizarBackup(rutaDestino);

                    MessageBox.Show("Backup realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar el backup: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
