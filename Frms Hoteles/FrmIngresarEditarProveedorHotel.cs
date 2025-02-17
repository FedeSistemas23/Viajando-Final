using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarProveedorHotel : Form
    {
        CS_ValidarFormulario Validar = new CS_ValidarFormulario();
        CS_LimpiarFormularios Limpiar = new CS_LimpiarFormularios();
        FrmIngresarEditarPaquetes frmPaquetes;

        int Id_Destino;
        string NombreHotel;
        bool editar = false;
        public FrmIngresarEditarProveedorHotel()
        {
            InitializeComponent();
        }
        public FrmIngresarEditarProveedorHotel(FrmIngresarEditarPaquetes frmpaquetes)
        {
            InitializeComponent();
            frmPaquetes = frmpaquetes;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CS_AtributosHotel Hotel;
            CN_GuardarHotel NuevoHotel = new CN_GuardarHotel();
            try
            {
                if (!Validar.Validar(this))
                {
                    MessageBox.Show("Debe completar todos los campos.");
                }
                else
                {
                    if (editar == false)
                    {
                        Hotel = new CS_AtributosHotel()
                        {
                            NombreDelHotel = txtNombreProveedor.Text,
                            Destino = txtDestino.Text,
                            NombreTitularHotel = txtNombre.Text,
                            ApellidoTitularHotel = txtApellido.Text,
                            Cuit = Convert.ToString(txtCuit.Text),
                            Calle = txtCalle.Text,
                            Numero = Convert.ToInt32(txtNumero.Text),
                            Localidad = txtLocalidad.Text,
                            Partido = txtPartido.Text,
                            Provincia = txtProvincia.Text,
                            Email = txtEmail.Text,
                            Telefono = Convert.ToString(txtTelefono.Text),
                            Celular = Convert.ToString(txtCelular.Text),
                            CantidadDeHabitaciones = Convert.ToInt32(npdCantidadHabitaciones.Value),
                            Single = Convert.ToInt32(npdSingle.Value),
                            Doble = Convert.ToInt32(npdDoble.Value),
                            Triple = Convert.ToInt32(npdTriple.Value),
                            Cuadruple = Convert.ToInt32(npdCuadruple.Value),
                            Desayuno = Convert.ToBoolean(chbDesayuno.Checked),
                            MediaPension = Convert.ToBoolean(chbMediaPension.Checked),
                            PensionCompleta = Convert.ToBoolean(chbPensionCompleta.Checked),
                        };
                        NuevoHotel.GuardarHotelL(Hotel);
                        MessageBox.Show("El producto se ha creado con exito");
                        Limpiar.Limpiar(this);
                        MostrarHoteles();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }

            if (editar == true)
            {
                CN_EditarHotel HotelEditado = new CN_EditarHotel();
                Hotel = new CS_AtributosHotel()
                {
                    Id_ProvedorHotel = Convert.ToInt32(dgvHotel.CurrentRow.Cells["Id_ProvedorHotel"].Value.ToString()),
                    NombreDelHotel = txtNombreProveedor.Text,
                    Destino = txtDestino.Text,
                    NombreTitularHotel = txtNombre.Text,
                    ApellidoTitularHotel = txtApellido.Text,
                    Cuit = Convert.ToString(txtCuit.Text),
                    Calle = txtCalle.Text,
                    Numero = Convert.ToInt32(txtNumero.Text),
                    Localidad = txtLocalidad.Text,
                    Partido = txtPartido.Text,
                    Provincia = txtProvincia.Text,
                    Email = txtEmail.Text,
                    Telefono = Convert.ToString(txtTelefono.Text),
                    Celular = Convert.ToString(txtCelular.Text),
                    CantidadDeHabitaciones = Convert.ToInt32(npdCantidadHabitaciones.Value),
                    Single = Convert.ToInt32(npdSingle.Value),
                    Doble = Convert.ToInt32(npdDoble.Value),
                    Triple = Convert.ToInt32(npdTriple.Value),
                    Cuadruple = Convert.ToInt32(npdCuadruple.Value),
                    Desayuno = Convert.ToBoolean(chbDesayuno.Checked),
                    MediaPension = Convert.ToBoolean(chbMediaPension.Checked),
                    PensionCompleta = Convert.ToBoolean(chbPensionCompleta.Checked),
                };
                HotelEditado.EditarHotelL(Hotel);
                MessageBox.Show("Los datos se han modificado con exito");
                Limpiar.Limpiar(this);
                MostrarHoteles();
            }
        }

        private void FrmIngresarEditarProveedorHotel_Load(object sender, EventArgs e)
        {
            MostrarHoteles();
        }
        public void MostrarHoteles()
        {
            CN_MostrarProveedor Hoteles = new CN_MostrarProveedor();
            dgvHotel.DataSource = Hoteles.MostrarProveedor();
        }

        private void cmbProveedores_TextChanged(object sender, EventArgs e)
        {
            string filterText = cmbProveedores.Text.ToLower(); // Convertir a minúsculas para una comparación insensible a mayúsculas
            // Iteramos sobre cada fila del DataGridView
            foreach (DataGridViewRow row in dgvHotel.Rows)
            {
                // Verificamos si el valor de la columna que contiene el nombre contiene el texto del filtro
                if (row.Cells["Nombre_Hotel"].Value != null &&
                    row.Cells["Nombre_Hotel"].Value.ToString().ToLower().Contains(filterText))
                {
                    row.Visible = true;  // Mostrar fila si coincide
                }
            }
        }

        private void btnDarDeBaja_Click(object sender, EventArgs e)
        {
            CN_EliminarProveedorHotel ProveedorHotel = new CN_EliminarProveedorHotel();
            if (dgvHotel.SelectedRows.Count > 0)
            {
                int Id_Provedor = Convert.ToInt32(dgvHotel.CurrentRow.Cells["Id_ProvedorHotel"].Value.ToString());
                ProveedorHotel.ELiminarProveedorHotelL(Id_Provedor);
                MessageBox.Show("Eliminado correctamente");
                MostrarHoteles();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvHotel.SelectedRows.Count > 0)
            {
                editar = true;
                int Id_Provedor = Convert.ToInt32(dgvHotel.CurrentRow.Cells["Id_ProvedorHotel"].Value.ToString());
                txtNombreProveedor.Text = dgvHotel.CurrentRow.Cells["Nombre_Hotel"].Value.ToString();
                txtDestino.Text = dgvHotel.CurrentRow.Cells["Destino"].Value.ToString();
                txtNombre.Text = dgvHotel.CurrentRow.Cells["NombreTitularHotel"].Value.ToString();
                txtApellido.Text = dgvHotel.CurrentRow.Cells["ApellidoTitularHotel"].Value.ToString();
                txtCuit.Text = dgvHotel.CurrentRow.Cells["Cuit"].Value.ToString();
                txtCalle.Text = dgvHotel.CurrentRow.Cells["Calle"].Value.ToString();
                txtNumero.Text = dgvHotel.CurrentRow.Cells["Numero"].Value.ToString();
                txtLocalidad.Text = dgvHotel.CurrentRow.Cells["Localidad"].Value.ToString();
                txtPartido.Text = dgvHotel.CurrentRow.Cells["Partido"].Value.ToString();
                txtProvincia.Text = dgvHotel.CurrentRow.Cells["Provincia"].Value.ToString();
                txtEmail.Text = dgvHotel.CurrentRow.Cells["Email"].Value.ToString();
                txtTelefono.Text = dgvHotel.CurrentRow.Cells["Telefono"].Value.ToString();
                txtCelular.Text = dgvHotel.CurrentRow.Cells["Celular"].Value.ToString();
                npdSingle.Value = Convert.ToInt32(dgvHotel.CurrentRow.Cells["Single"].Value.ToString());
                npdDoble.Value = Convert.ToInt32(dgvHotel.CurrentRow.Cells["Doble"].Value.ToString());
                npdTriple.Value = Convert.ToInt32(dgvHotel.CurrentRow.Cells["Triple"].Value.ToString());
                npdCuadruple.Value = Convert.ToInt32(dgvHotel.CurrentRow.Cells["Cuadruple"].Value.ToString());
                npdCantidadHabitaciones.Value = Convert.ToInt32(dgvHotel.CurrentRow.Cells["Cantidad_Habitaciones"].Value.ToString());
                chbDesayuno.Checked = Convert.ToBoolean(dgvHotel.CurrentRow.Cells["Desayuno"].Value.ToString());
                chbMediaPension.Checked = Convert.ToBoolean(dgvHotel.CurrentRow.Cells["MediaPension"].Value.ToString());
                chbPensionCompleta.Checked = Convert.ToBoolean(dgvHotel.CurrentRow.Cells["PensionCompleta"].Value.ToString());

            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar.Limpiar(this);
        }

        private void dgvHotel_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            NombreHotel= dgvHotel.CurrentRow.Cells["Nombre_Hotel"].Value.ToString();
            frmPaquetes.AgregarHotelAlCombo(NombreHotel);
        }
    }
}
