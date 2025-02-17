using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmAgregarDestino : Form
    {


        FrmIngresarEditarPaquetes nuevoDestino;
        CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
        CS_ValidarFormulario Validar = new CS_ValidarFormulario();
        int Id_Destino;
        string Nombre;

        CN_Destino destino;
        bool editar = false;
        public FrmAgregarDestino(FrmIngresarEditarPaquetes nuevoDestino)
        {
            InitializeComponent();
            this.nuevoDestino = nuevoDestino;
            destino = new CN_Destino();
        }
        private void FrmAgregarDestino_Load(object sender, EventArgs e)
        {
            CargarDgvDestinos();
            dgvDestinos.RowHeadersVisible = false;
            dgvDestinos.Columns[0].Visible = false;
            dgvDestinos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void CargarDgvDestinos()
        {
            List<CS_Destino> Destinos = new List<CS_Destino>();
            Destinos = destino.MostrarD();
            dgvDestinos.DataSource = Destinos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtDestino.Text;
            string localidad = txtLocalidad.Text;
            string partido = txtPartido.Text;
            string provincia = txtProvincia.Text;
            if (editar == false)
            {
                try
                {
                    if (!Validar.Validar(this))
                    {
                        MessageBox.Show("Debe completar todos los campos.");
                    }
                    else
                    {
                        destino.AgregarDestinoL(nombre, localidad, partido, provincia);
                        CargarDgvDestinos();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                }
                finally
                {
                    limpiar.Limpiar(this);
                }
            }
            if (editar == true)
            {
                Id_Destino = Convert.ToInt32(dgvDestinos.CurrentRow.Cells["Id_Destino"].Value);
                destino.EditarDestinoL(Id_Destino, nombre, localidad, partido, provincia);
                editar = false;
                CargarDgvDestinos();
                limpiar.Limpiar(this);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDestinos.SelectedRows.Count > 0)
                {
                    editar = true;
                    txtDestino.Text = dgvDestinos.CurrentRow.Cells["Nombre"].Value.ToString();
                    txtLocalidad.Text = dgvDestinos.CurrentRow.Cells["Localidad"].Value.ToString();
                    txtPartido.Text = dgvDestinos.CurrentRow.Cells["Partido"].Value.ToString();
                    txtProvincia.Text = dgvDestinos.CurrentRow.Cells["Provincia"].Value.ToString();
                }
                else
                {
                    MessageBox.Show("seleccione una fila por favor");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar.Limpiar(this);
        }

        private void dgvDestinos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Id_Destino= Convert.ToInt32(dgvDestinos.CurrentRow.Cells["Id_Destino"].Value.ToString());
            Nombre = dgvDestinos.CurrentRow.Cells["Nombre"].Value.ToString();
            nuevoDestino.AgregarDestinoAlTextBox(Id_Destino, Nombre);
            this.Close();   
        }
    }
}
