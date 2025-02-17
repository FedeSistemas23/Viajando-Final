using CapaNegocio;
using CapaServicios;
using CapaSesion;
using interfazPpal;
using System;
using System.Windows.Forms;

namespace Loggin
{
    public partial class CrearReserva : Form
    {
        ConversionesDeTipo convertir = new ConversionesDeTipo();
        CN_MostrarReserva mostrar = new CN_MostrarReserva();
        bool editar = false;

        public CrearReserva()
        {
            InitializeComponent();
        }
        public CrearReserva(int id , string nombre , DateTime FechaSalida , DateTime fechaRegreso, int Disponibilidad )
        {
            InitializeComponent();
            txtDestino.Text = nombre;
            lbl_IdDestino.Text = Convert.ToString(id);
            dtpFechaSalida.Value = FechaSalida ;
            dtpFechaRegreso.Value = fechaRegreso;
        }

        private bool ValidarControles()
        {
            // Verificar si los TextBox están vacíos
            if (string.IsNullOrWhiteSpace(txtDestino.Text))
            {
                MessageBox.Show("El campo 'Destino' no puede estar vacío.");
                txtDestino.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNumeroReserva.Text))
            {
                MessageBox.Show("El campo 'Número de Reserva' no puede estar vacío.");
                txtNumeroReserva.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtVendedor.Text))
            {
                MessageBox.Show("El campo 'Vendedor' no puede estar vacío.");
                txtVendedor.Focus();
                return false;
            }

            // Verificar si el valor de NumericUpDown es mayor que 0
            if (npdCantidadPax.Value <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida de pasajeros.");
                npdCantidadPax.Focus();
                return false;
            }

            // Si todos los controles están correctos, se retorna true
            return true;
        }
        private void CrearReserva_Load(object sender, EventArgs e)
        {
            MuestraNumReserva Nreserva = new MuestraNumReserva();
            CN_MostrarReserva mostrar = new CN_MostrarReserva();

            txtNumeroReserva.Text = Convert.ToString(Nreserva.MostrarNumReservaCN());
            mostrar.MostrarReservaCN();

            dgvReservas.DataSource = mostrar.MostrarReservaCN();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCargaPasajeros frm = new FrmCargaPasajeros();
            frm.ShowDialog();

        }
        public void muestraDatosEnTextbox(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvReservas.Rows[e.RowIndex];
                txtNumeroReserva.Text = filaSeleccionada.Cells["NroReserva"].Value.ToString();
                txtDestino.Text = filaSeleccionada.Cells["Destino"].Value.ToString();
                dtpFechaSalida.Text = filaSeleccionada.Cells["FechaSalida"].Value.ToString();
                dtpFechaRegreso.Text = filaSeleccionada.Cells["FechaRegreso"].Value.ToString();
                npdCantidadPax.Text = filaSeleccionada.Cells["CantidadPax"].Value.ToString();
                npdCamaMatrimonial.Text = filaSeleccionada.Cells["CamaMatrimonialx"].Value.ToString();
                npdDoble.Text = filaSeleccionada.Cells["CAntMenores"].Value.ToString();
                npdAsientosSemiCama.Text = filaSeleccionada.Cells["SemiCama"].Value.ToString();
                npdAsientosCama.Text = filaSeleccionada.Cells["AsientosCama"].Value.ToString();
                npdCantHabitaciones.Text = filaSeleccionada.Cells["CantidadHabitaciones"].Value.ToString();
                npdSingle.Text = filaSeleccionada.Cells["Single"].Value.ToString();
                npdDoble.Text = filaSeleccionada.Cells["Doble"].Value.ToString(); txtDestino.Text = filaSeleccionada.Cells["Destino"].Value.ToString();
                npdTriple.Text = filaSeleccionada.Cells["Triple"].Value.ToString();
                npdCuadruple.Text = filaSeleccionada.Cells["Cuadruple"].Value.ToString();
                txtAscenso.Text = filaSeleccionada.Cells["AscensoMicro"].Value.ToString();
                npdCamaSimple.Text = filaSeleccionada.Cells["CamaSimple"].Value.ToString();
                npdCamaMatrimonial.Text = filaSeleccionada.Cells["CamaMatrimonial"].Value.ToString();
                ckbCotizar.Text = filaSeleccionada.Cells["Cotizar"].Value.ToString();
                txtSeña.Text = filaSeleccionada.Cells["Senia"].Value.ToString();
                txtObservaciones.Text = filaSeleccionada.Cells["Observacion"].Value.ToString();
                txtNombre.Text = filaSeleccionada.Cells["Nombre"].Value.ToString();
                txtApellido.Text = filaSeleccionada.Cells["Apellido"].Value.ToString();
                ckbAdicionalCama.Text = filaSeleccionada.Cells["AdicionalCama"].Value.ToString();
                txtVendedor.Text = filaSeleccionada.Cells["Vendedor"].Value.ToString();
                txtAscenso.Text = filaSeleccionada.Cells["AscensMicro"].Value.ToString();
            }
        }

        

        private void btnVer_Click(object sender, EventArgs e)
        {
            frm_MostrarReserva frm = new frm_MostrarReserva();
            frm.ShowDialog();
        }

        private void btnBuscarDestino_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FrmBuscarPaquete frm = new FrmBuscarPaquete();
            frm.ShowDialog();

        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            CN_MostrarReserva mostrar = new CN_MostrarReserva();
            CN_GuardarReserva reservaNueva = new CN_GuardarReserva();
            if (editar == false)
            {
                if (this.ValidarControles())
                {
                    try
                    {
                        CS_Reserva reserva = new CS_Reserva()

                        {
                            NroReserva = Convert.ToInt32(txtNumeroReserva.Text),
                            Id_Paquete = Convert.ToInt32(lbl_IdDestino.Text),
                            CantidadPasajeros = Convert.ToInt32(npdCantidadPax.Value),
                            CantMenorTres = Convert.ToInt32(npdDoble.Value),
                            AsientosCama = Convert.ToInt32(npdAsientosCama.Value),
                            AsientosSemiCama = Convert.ToInt32(npdAsientosSemiCama.Value),
                            Single = Convert.ToInt32(npdSingle.Value),
                            Doble = Convert.ToInt32(npdDoble.Value),
                            Triple = Convert.ToInt32(npdTriple.Value),
                            Cuadruple = Convert.ToInt32(npdCuadruple.Value),
                            AscensoMicro = txtAscenso.Text,
                            CamaSimple = Convert.ToInt32(npdCamaSimple.Value),
                            CamaMatrimonial = Convert.ToInt32(npdCamaMatrimonial.Value),
                            Cotizar = Convert.ToBoolean(ckbCotizar.Checked),
                            Senia = convertir.ConvertirTextoADouble(txtSeña.Text),
                            Observacion = txtObservaciones.Text,
                            FechaSalida = dtpFechaSalida.Value,
                            FechaRegreso = dtpFechaRegreso.Value,
                            FechaReserva = DateTime.Now,
                            NombreTitular = txtNombre.Text,
                            ApellidoTitular = txtApellido.Text,
                            AdicionalCama = Convert.ToBoolean(ckbAdicionalCama.Checked),
                            Habitaciones = Convert.ToInt32(npdCantHabitaciones.Value),
                            NombreVendedor = txtVendedor.Text,
                            Destino = txtDestino.Text,
                        };

                        bool guardada = reservaNueva.GuardarReservaCN(reserva);
                        reserva.AgregarLista(reserva);
                        if (guardada == true)
                        {
                            reserva.AgregarLista(reserva);

                            panelMsg.Visible = true;
                            lblMsgOk.Visible = true;
                            lblMsgOk.Text = "Reserva guardada con exito";
                            CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
                            dgvReservas.DataSource = null;
                            lbl_IdDestino.Text = "";
                            dgvReservas.DataSource = null;
                            dgvReservas.DataSource = mostrar.MostrarReservaCN();
                            limpiar.Limpiar(this);
                            int reservacionN = reserva.NroReserva;
                        }
                        else
                        {
                            panelMsg.Visible = true;
                            lblMsgOk.Visible = true;
                            lblMsgOk.Text = "Ha ocurrido un error al cargar la reserva";
                        }
                        dgvReservas.DataSource = mostrar.MostrarReservaCN();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la reserva, intente de nuevo: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar los campos obligatorios ");
                }
            }
            if (editar == true)
            {
                CN_EditarReserva reservaEditar = new CN_EditarReserva();
                CS_Reserva reserva = new CS_Reserva()

                {
                    NroReserva = Convert.ToInt32(txtNumeroReserva.Text),
                    Id_Paquete = Convert.ToInt32(lbl_IdDestino.Text),
                    CantidadPasajeros = Convert.ToInt32(npdCantidadPax.Value),
                    CantMenorTres = Convert.ToInt32(npdDoble.Value),
                    AsientosCama = Convert.ToInt32(npdAsientosCama.Value),
                    AsientosSemiCama = Convert.ToInt32(npdAsientosSemiCama.Value),
                    Single = Convert.ToInt32(npdSingle.Value),
                    Doble = Convert.ToInt32(npdDoble.Value),
                    Triple = Convert.ToInt32(npdTriple.Value),
                    Cuadruple = Convert.ToInt32(npdCuadruple.Value),
                    AscensoMicro = txtAscenso.Text,
                    CamaSimple = Convert.ToInt32(npdCamaSimple.Value),
                    CamaMatrimonial = Convert.ToInt32(npdCamaMatrimonial.Value),
                    Cotizar = Convert.ToBoolean(ckbCotizar.Checked),
                    Senia = convertir.ConvertirTextoADouble(txtSeña.Text),
                    Observacion = txtObservaciones.Text,
                    FechaSalida = dtpFechaSalida.Value,
                    FechaRegreso = dtpFechaRegreso.Value,
                    FechaReserva = DateTime.Now,
                    NombreTitular = txtNombre.Text,
                    ApellidoTitular = txtApellido.Text,
                    AdicionalCama = Convert.ToBoolean(ckbAdicionalCama.Checked),
                    Habitaciones = Convert.ToInt32(npdCantHabitaciones.Value),
                    NombreVendedor = txtVendedor.Text,
                    Destino = txtDestino.Text,
                };

                if (reservaEditar.EditarReservaCN(reserva))
                {
                    panelMsg.Visible = true;
                    lblMsgOk.Visible = true;
                    lblMsgOk.Text = "Reserva editada con exito";
                    CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
                    dgvReservas.DataSource = null;
                    lbl_IdDestino.Text = "";
                    dgvReservas.DataSource = null;
                    dgvReservas.DataSource = mostrar.MostrarReservaCN();
                    limpiar.Limpiar(this);
                }
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            FrmCargaPasajeros frm = new FrmCargaPasajeros();
            frm.ShowDialog();

            //   int NumeroReserva = Convert.ToInt32(lblNroReserva.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            editar = true;

            if (dgvReservas.SelectedRows.Count > 0)
            {

                // DataGridViewRow filaSeleccionada = dgvReservas.Rows[e.RowIndex];
                lbl_IdDestino.Text = dgvReservas.CurrentRow.Cells["Id_Paquete"].Value.ToString();
                txtNumeroReserva.Text = dgvReservas.CurrentRow.Cells["NroReserva"].Value.ToString();
                txtDestino.Text = dgvReservas.CurrentRow.Cells["Destino"].Value.ToString();
                dtpFechaSalida.Text = dgvReservas.CurrentRow.Cells["FechaSalida"].Value.ToString();
                dtpFechaRegreso.Text = dgvReservas.CurrentRow.Cells["FechaRegreso"].Value.ToString();
                npdCantidadPax.Text = dgvReservas.CurrentRow.Cells["CantidadPasajeros"].Value.ToString();
                npdCamaMatrimonial.Text = dgvReservas.CurrentRow.Cells["CamaMatrimonial"].Value.ToString();
                npdCantMenores.Text = dgvReservas.CurrentRow.Cells["PasajerosMenores"].Value.ToString();
                npdAsientosSemiCama.Text = dgvReservas.CurrentRow.Cells["AsientosSemiCama"].Value.ToString();
                var valorAsientosCama = dgvReservas.CurrentRow.Cells["AsientosCama"].Value;
                if (valorAsientosCama != DBNull.Value)
                {
                    npdAsientosCama.Value = Convert.ToInt32(valorAsientosCama);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdAsientosCama.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                var CantHabitaciones = dgvReservas.CurrentRow.Cells["Habitaciones"].Value;

                if (CantHabitaciones != DBNull.Value)
                {
                    npdCantHabitaciones.Value = Convert.ToInt32(CantHabitaciones);
                }
                else
                {

                    npdCantHabitaciones.Value = 0;
                }
                var Single = dgvReservas.CurrentRow.Cells["Single"].Value;

                if (Single != DBNull.Value)
                {
                    npdSingle.Value = Convert.ToInt32(Single);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdSingle.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }


                var Doble = dgvReservas.CurrentRow.Cells["Doble"].Value;
                if (Doble != DBNull.Value)
                {
                    npdDoble.Value = Convert.ToInt32(Doble);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdDoble.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }

                var Triple = dgvReservas.CurrentRow.Cells["Triple"].Value;
                if (Triple != DBNull.Value)
                {
                    npdTriple.Value = Convert.ToInt32(Triple);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdTriple.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                var Cuadruple = dgvReservas.CurrentRow.Cells["Cuadruple"].Value;

                if (Cuadruple != DBNull.Value)
                {
                    npdCuadruple.Value = Convert.ToInt32(Cuadruple);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdCuadruple.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                txtAscenso.Text = dgvReservas.CurrentRow.Cells["Ascenso"].Value.ToString();
                var CamaSimple = dgvReservas.CurrentRow.Cells["CamaSimple"].Value;

                if (CamaSimple != DBNull.Value)
                {
                    npdCamaSimple.Value = Convert.ToInt32(CamaSimple);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdCamaSimple.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                var CamaMatrimonial = dgvReservas.CurrentRow.Cells["CamaMatrimonial"].Value;
                if (CamaMatrimonial != DBNull.Value)
                {
                    npdCamaMatrimonial.Value = Convert.ToInt32(CamaMatrimonial);
                }
                else
                {
                    // Establece un valor por defecto o maneja el caso en que el valor es nulo
                    npdCamaMatrimonial.Value = 0; // O cualquier valor que tenga sentido en tu contexto
                }
                ckbCotizar.Text = dgvReservas.CurrentRow.Cells["Cotizar"].Value.ToString();
                txtSeña.Text = dgvReservas.CurrentRow.Cells["Seña"].Value.ToString();
                txtObservaciones.Text = dgvReservas.CurrentRow.Cells["Observacion"].Value.ToString();
                txtNombre.Text = dgvReservas.CurrentRow.Cells["NombreTitular"].Value.ToString();
                txtApellido.Text = dgvReservas.CurrentRow.Cells["ApellidoTitular"].Value.ToString();
                ckbAdicionalCama.Text = dgvReservas.CurrentRow.Cells["AdicionalCama"].Value.ToString();
                txtVendedor.Text = dgvReservas.CurrentRow.Cells["NombreVendedor"].Value.ToString();
                //txtAscenso.Text = dgvReservas.CurrentRow.Cells["AscensoM"].Value.ToString();
                dtpFechaReserva.Text = dgvReservas.CurrentRow.Cells["fecha"].Value.ToString();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CN_MostrarReserva mostrar = new CN_MostrarReserva();
            CS_LimpiarFormularios limpiar = new CS_LimpiarFormularios();
            dgvReservas.DataSource = null;
            dgvReservas.DataSource = mostrar.MostrarReservaCN();
            lbl_IdDestino.Text = "";
            limpiar.Limpiar(this);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CN_ElimnarReserva eliminar = new CN_ElimnarReserva();
            CS_Reserva reserva = new CS_Reserva();
            CN_MostrarReserva mostrar = new CN_MostrarReserva();
            if (dgvReservas.SelectedRows.Count > 0)
            {
                reserva.NroReserva = Convert.ToInt32(dgvReservas.CurrentRow.Cells["NroReserva"].Value.ToString());
                if (eliminar.EliminarReservaCN(reserva.NroReserva))
                {
                    panelMsg.Visible = true;
                    lblMsgOk.Visible = true;
                    lblMsgOk.Text = "Reserva Eliminada con exito";
                    dgvReservas.DataSource = null;
                    dgvReservas.DataSource = mostrar.MostrarReservaCN();
                }
                else
                {
                    lblMsgOk.Text = "No se pudo editar la reserva";
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FrmBuscarReserva frm = new FrmBuscarReserva();
            frm.Show();
        }
    }
}



























