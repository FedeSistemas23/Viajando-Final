using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmCargaPasajeros : Form

    {
        CS_AtributosPasajeros CV_Pasajero = new CS_AtributosPasajeros();
        CN_CargarPasajero CV_CargarPasajero = new CN_CargarPasajero();
        CN_MostrarPasajero MostrarPasajero = new CN_MostrarPasajero();
        CS_ValidarFormulario frm = new CS_ValidarFormulario();
        CS_LimpiarFormularios FrmLimpiar = new CS_LimpiarFormularios();
        CN_EditarPasajero EditarPax = new CN_EditarPasajero();
        CN_EliminarPasajero EliminarPasajero = new CN_EliminarPasajero();

        string NumerodeReserva;
        bool editar = false;

        public FrmCargaPasajeros()
        {
            InitializeComponent();
            
        }

        public FrmCargaPasajeros(string tipoDeFormulario)
        {
            InitializeComponent();

        }
        /*public FrmCargaPasajeros(string numerodereserva)
        {
            InitializeComponent();
            NumerodeReserva = numerodereserva;

        }*/
        private void FrmCargaPasajeros_Load(object sender, EventArgs e)
        {
            MostrarPasajeros();

        }
        private void MostrarPasajeros()
        {
            dgvPasajeros.DataSource = MostrarPasajero.MostrarPasajeros();
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)

        {
            //bool validado = frm.Validar(this);
            if (editar == false)
            {
                try
                {
                    /*if (validado) // el validado no esta devolviendo true cuando se completan todos los controles.
                    {
                        MessageBox.Show("Debe completar todos los campos.");
                    }
                    else*/
                    CV_Pasajero = new CS_AtributosPasajeros()
                    {
                        NroReserva = Convert.ToInt32(txtNroReserva.Text),
                        nombre = txtNombrePax.Text,
                        apellido = txtApellidos.Text,
                        TipoDocumento = Convert.ToString(cmbTipoDoc.SelectedItem),
                        NroDocumento = txtNumDoc.Text,
                        FechaNacimiento = FechaNacimiento.Value,
                        telefono = txtTelefono.Text,
                        nacionalidad = txtNacionalidad.Text,
                        email = txtEmail.Text,
                        Calle = txtCalle.Text,
                        Numero = Convert.ToInt32(txtNumero.Text),
                        Localidad = txtLocalidad.Text,
                        Partido = txtPartido.Text,
                        Provincia = txtProvincia.Text,
                        Ascenso = Convert.ToString(cmbAscenso.SelectedItem),
                        menor_de_3 = Convert.ToBoolean(ckbEsMenor.Checked),
                        TieneObraSocial = Convert.ToBoolean(ckbTieneObraSocial.Checked),
                        ObraSocial = Convert.ToString(cmbObraSocial.SelectedItem),              
                    }; 
                    CV_CargarPasajero.CargarPax(CV_Pasajero);
                    MessageBox.Show("El pasajero se asignado con exito a la reserva");
                    FrmLimpiar.Limpiar(this);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                }
                finally
                {
                    if (CV_Pasajero.Id_Pasajero != null) { MostrarPasajero.MostrarPasajeros(); }

                }
            }
            if (editar == true)
            {
                try
                {
                    CV_Pasajero.Id_Pasajero = Convert.ToInt32(dgvPasajeros.CurrentRow.Cells["Id_Pasajero"].Value.ToString());
                    CV_Pasajero.NroReserva = Convert.ToInt32(txtNroReserva.Text);
                    CV_Pasajero.nombre = txtNombrePax.Text;
                    CV_Pasajero.apellido = txtApellidos.Text;
                    CV_Pasajero.TipoDocumento = cmbTipoDoc.SelectedItem.ToString();
                    CV_Pasajero.NroDocumento = txtNumDoc.Text;
                    CV_Pasajero.FechaNacimiento = FechaNacimiento.Value;
                    CV_Pasajero.telefono = txtTelefono.Text;
                    CV_Pasajero.nacionalidad = txtNacionalidad.Text;
                    CV_Pasajero.email = txtEmail.Text;
                    CV_Pasajero.Calle = txtCalle.Text;
                    CV_Pasajero.Numero = Convert.ToInt32(txtNumero.Text);
                    CV_Pasajero.Localidad = txtLocalidad.Text;
                    CV_Pasajero.Partido = txtPartido.Text;
                    CV_Pasajero.Provincia = txtProvincia.Text;
                    CV_Pasajero.Ascenso = cmbAscenso.SelectedItem.ToString();
                    CV_Pasajero.menor_de_3 = Convert.ToBoolean(ckbEsMenor.Checked);
                    CV_Pasajero.TieneObraSocial = Convert.ToBoolean(ckbTieneObraSocial.Checked);
                    CV_Pasajero.ObraSocial = cmbObraSocial.SelectedItem.ToString();
                    EditarPax.EditarPasajeroL(CV_Pasajero);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Los campos se han modificado con exito");
                    editar = false;
                    FrmLimpiar.Limpiar(this);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //
            /*try
            {
                if (dgvPasajeros.SelectedRows.Count > 0)
                {
                    editar = true;
                    int Id_Pasajero = Convert.ToInt32(dgvPasajeros.CurrentRow.Cells["Id_Pasajero"].Value.ToString());
                    DataTable pasajero = MostrarPasajero.MostrarPasajeros(Id_Pasajero);
                    if (pasajero != null)
                    {
                        DataRow row = pasajero.Rows[0];
                        txtNroReserva.Text = row["NroReserva"].ToString();
                        txtNombrePax.Text = row["Nombre"].ToString();
                        txtApellidos.Text = row["Apellido"].ToString();
                        cmbTipoDoc.SelectedValue = row["TipoDoc"].ToString();
                        txtNumDoc.Text = row["NroDoc"].ToString();
                        FechaNacimiento.Text = row["FecNac"].ToString();
                        txtTelefono.Text = row["Telefono"].ToString();
                        txtNacionalidad.Text = row["Nacionalidad"].ToString();
                        txtEmail.Text = row["Email"].ToString();
                        txtCalle.Text = row["Calle"].ToString();
                        txtNumero.Text = row["Nro"].ToString();
                        txtLocalidad.Text = row["Localidad"].ToString();
                        txtPartido.Text = row["Partido"].ToString();
                        txtProvincia.Text = row["Provincia"].ToString();
                        cmbAscenso.SelectedValue = row["Ascenso"].ToString() ;
                        ckbEsMenor.Checked = Convert.ToBoolean(row["EsMenor"]);
                        cmbObraSocial.SelectedItem = row["ObraSocial"].ToString();
                        ckbTieneObraSocial.Checked = Convert.ToBoolean(row["TieneObraSocial"]);
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("seleccione una fila por favor");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }*/

            try
            {

                if (dgvPasajeros.SelectedRows.Count == 1)
                {
                    editar = true;
                    NroPasajero.Text = dgvPasajeros.CurrentRow.Cells["Id_Pasajero"].Value.ToString();
                    txtNroReserva.Text = dgvPasajeros.CurrentRow.Cells["NroReserva"].ToString();
                    txtNombrePax.Text = dgvPasajeros.CurrentRow.Cells["Nombre"].ToString();
                    txtApellidos.Text = dgvPasajeros.CurrentRow.Cells["Apellido"].ToString();
                    cmbTipoDoc.SelectedValue = dgvPasajeros.CurrentRow.Cells["TipoDoc"].ToString();
                    txtNumDoc.Text = dgvPasajeros.CurrentRow.Cells["NroDoc"].ToString();
                    FechaNacimiento.Text = dgvPasajeros.CurrentRow.Cells["FecNac"].ToString();
                    txtTelefono.Text = dgvPasajeros.CurrentRow.Cells["Telefono"].ToString();
                    txtNacionalidad.Text = dgvPasajeros.CurrentRow.Cells["Nacionalidad"].ToString();
                    txtEmail.Text = dgvPasajeros.CurrentRow.Cells["Email"].ToString();
                    txtCalle.Text = dgvPasajeros.CurrentRow.Cells["Calle"].ToString();
                    txtNumero.Text = dgvPasajeros.CurrentRow.Cells["Nro"].ToString();
                    txtLocalidad.Text = dgvPasajeros.CurrentRow.Cells["Localidad"].ToString();
                    txtPartido.Text = dgvPasajeros.CurrentRow.Cells["Partido"].ToString();
                    txtProvincia.Text = dgvPasajeros.CurrentRow.Cells["Provincia"].ToString();
                    cmbAscenso.SelectedValue = dgvPasajeros.CurrentRow.Cells["Ascenso"].ToString();
                    ckbEsMenor.Checked = Convert.ToBoolean(dgvPasajeros.CurrentRow.Cells["EsMenor"]);
                    cmbObraSocial.SelectedItem = dgvPasajeros.CurrentRow.Cells["ObraSocial"].ToString();
                    ckbTieneObraSocial.Checked = Convert.ToBoolean(dgvPasajeros.CurrentRow.Cells["TieneObraSocial"]);

                }
                else
                {
                    MessageBox.Show("Debe seleccionar una fila");
                }
            }
            catch (Exception ex) { throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPasajeros.SelectedRows.Count > 0)
            {
                int Id_Pasajero = Convert.ToInt32(dgvPasajeros.CurrentRow.Cells["Id_Pasajero"].Value.ToString());
                EliminarPasajero.EliminarPasajeroL(Id_Pasajero);
                MessageBox.Show("Eliminado correctamente");
                MostrarPasajeros();
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }        
    }
}
