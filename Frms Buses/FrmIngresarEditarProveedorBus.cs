using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarProveedorBus : Form
    {
        CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
        CS_ValidarFormulario Validar = new CS_ValidarFormulario();
        List<CS_AtributosBus> listaBuses;


        bool editar = false;
        public FrmIngresarEditarProveedorBus()
        {
            InitializeComponent();
        }         
        public void MostrarBuses()
        {
            CN_MostrarBuses buses = new CN_MostrarBuses();
            List<CS_AtributosBus> listaBuses = buses.MostrarBusesL();
            dgvBus.DataSource = listaBuses;
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            CN_ELiminarBus eliminarBus = new CN_ELiminarBus();
            if (dgvBus.SelectedRows.Count > 0)
            {
                int Id_ProvedorBus = Convert.ToInt32(dgvBus.CurrentRow.Cells["Id_ProvedorBus"].Value.ToString());
                eliminarBus.ELiminarBusL(Id_ProvedorBus);
                MessageBox.Show("Eliminado correctamente");
                MostrarBuses();

            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvBus.SelectedRows.Count > 0)
            {
                editar = true;
                int Id_Provedor = Convert.ToInt32(dgvBus.CurrentRow.Cells["Id_ProvedorBus"].Value);
                npdCantidadAsientos.Value = Convert.ToInt32(dgvBus.CurrentRow.Cells["CantidadDeAsientos"].Value);
                npdAsientosCama.Value = Convert.ToInt32(dgvBus.CurrentRow.Cells["Cama"].Value);
                npdAsientosSemicama.Value = Convert.ToInt32(dgvBus.CurrentRow.Cells["Semicama"].Value);
                txtCalle.Text = dgvBus.CurrentRow.Cells["Calle"].Value.ToString();
                txtNumero.Text = dgvBus.CurrentRow.Cells["Numero"].Value.ToString();
                txtLocalidad.Text = dgvBus.CurrentRow.Cells["Localidad"].Value.ToString();
                txtPartido.Text = dgvBus.CurrentRow.Cells["Partido"].Value.ToString();
                txtProvincia.Text = dgvBus.CurrentRow.Cells["Provincia"].Value.ToString();
                txtTelefono.Text = dgvBus.CurrentRow.Cells["Telefono"].Value.ToString();
                txtEmail.Text = dgvBus.CurrentRow.Cells["Email"].Value.ToString();
                txtDestino.Text = dgvBus.CurrentRow.Cells["Destino"].Value.ToString();
                txtNombre.Text = dgvBus.CurrentRow.Cells["NombreTitularBus"].Value.ToString();
                txtApellido.Text = dgvBus.CurrentRow.Cells["ApellidoTitularBus"].Value.ToString();
                txtCuit.Text = dgvBus.CurrentRow.Cells["Cuit"].Value.ToString();
                txtCelular.Text = dgvBus.CurrentRow.Cells["Celular"].Value.ToString();
                txtNombreProveedor.Text = dgvBus.CurrentRow.Cells["NombreBus"].Value.ToString();
            }
        }

        private void FrmIngresarEditarProveedorBus_Load(object sender, EventArgs e)
        {
            MostrarBuses();
            dgvBus.RowHeadersVisible = false;
            dgvBus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBus.Columns[1].Visible = false;
            dgvBus.Columns[2].Visible = false;
            dgvBus.Columns[3].Visible = false;
            dgvBus.Columns[4].Visible = false;
            dgvBus.Columns[5].Visible = false;
            dgvBus.Columns[6].Visible = false;
            dgvBus.Columns[7].Visible = false;
            dgvBus.Columns[8].Visible = false;
            dgvBus.Columns[9].Visible = false;
            dgvBus.Columns[10].Visible = false;
            dgvBus.Columns[12].Visible = false;
            dgvBus.Columns[13].Visible = false;
            dgvBus.Columns[14].Visible = false;
            dgvBus.Columns[15].Visible = false;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
                CS_AtributosBus Bus;
                CN_GuardarBus NuevoBus = new CN_GuardarBus();
                try
                {
                    if (string.IsNullOrEmpty(txtNombreProveedor.Text) || string.IsNullOrEmpty(txtDestino.Text) || string.IsNullOrEmpty(txtNombre.Text)
                        || string.IsNullOrEmpty(txtApellido.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCelular.Text))
                    {
                        MessageBox.Show("Debe con asterisco son obligattorios.");
                    }
                    else
                    {
                        if (editar == false)
                        {
                            Bus = new CS_AtributosBus()
                            {
                                CantidadDeAsientos = Convert.ToInt32(npdCantidadAsientos.Value),
                                Cama = Convert.ToInt32(npdAsientosCama.Value),
                                Semicama = Convert.ToInt32(npdAsientosSemicama.Value),
                                Calle = txtCalle.Text,
                                Numero = Convert.ToInt32(txtNumero.Text),
                                Localidad = txtLocalidad.Text,
                                Provincia = txtProvincia.Text,
                                Telefono = Convert.ToString(txtTelefono.Text),
                                Email = txtEmail.Text,
                                Destino = txtDestino.Text,
                                NombreTitularBus = txtNombre.Text,
                                ApellidoTitularBus = txtApellido.Text,
                                Cuit = Convert.ToString(txtCuit.Text),
                                Celular = Convert.ToString(txtCelular.Text),
                                NombreBus = txtNombreProveedor.Text,
                            };
                            NuevoBus.GuardarBusL(Bus);
                            MessageBox.Show("El producto se ha creado con exito");
                            MostrarBuses();
                            limpiar.Limpiar(this);
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                }

                if (editar == true)
                {
                    CN_EditarBus editarBus = new CN_EditarBus();
                    Bus = new CS_AtributosBus()
                    {
                        Id_ProvedorBus = Convert.ToInt32(dgvBus.CurrentRow.Cells["Id_ProvedorBus"].Value),
                        CantidadDeAsientos = Convert.ToInt32(npdCantidadAsientos.Value),
                        Cama = Convert.ToInt32(npdAsientosCama.Value),
                        Semicama = Convert.ToInt32(npdAsientosSemicama.Value),
                        Calle = txtCalle.Text,
                        Numero = Convert.ToInt32(txtNumero.Text),
                        Localidad = txtLocalidad.Text,
                        Provincia = txtProvincia.Text,
                        Telefono = Convert.ToString(txtTelefono.Text),
                        Email = txtEmail.Text,
                        Destino = txtDestino.Text,
                        NombreTitularBus = txtNombre.Text,
                        ApellidoTitularBus = txtApellido.Text,
                        Cuit = Convert.ToString(txtCuit.Text),
                        Celular = Convert.ToString(txtCelular.Text),
                        NombreBus = txtNombreProveedor.Text,

                    };
                    editarBus.EditarBusL(Bus);
                    MessageBox.Show("Los datos se han modificado con exito");
                    MostrarBuses();
                    limpiar.Limpiar(this);
                }
            }
        }

        /*private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            limpiar.Limpiar(this);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.ToLower();

            // Filtra la lista de objetos
            var listaFiltrada = listaBuses
                .Where(bus =>
                              bus.Destino.ToLower().Contains(filtro)
                             )
                .ToList();
            if (listaFiltrada.Count > 0)
            {
                // Actualiza el DataGridView con los resultados filtrados
                dgvBus =null;
                dgvBus.DataSource = new BindingList<CS_AtributosBus>(listaFiltrada);
            }
            else
            {
                MessageBox.Show("No hay provedores ingresesado. Debe ingresar provedores");
            }
        }*/

    }

    

