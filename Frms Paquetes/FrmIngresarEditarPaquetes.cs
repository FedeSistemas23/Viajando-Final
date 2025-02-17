using CapaNegocio;
using CapaServicios;
using CapaSesion;
using Loggin;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmIngresarEditarPaquetes : Form
    {
        CS_ValidarFormulario Validar;
        CS_LimpiarFormularios Limpiador;
        CN_Bitacora bitacora;

        string NombreHotel;
        int Id_Destino;
        string destino;
        bool editar = false;
        int Id_Paquete;

        public FrmIngresarEditarPaquetes()
        {
            InitializeComponent();
            Validar = new CS_ValidarFormulario();
            Limpiador = new CS_LimpiarFormularios();
            bitacora = new CN_Bitacora();
        }
        private void FrmIngresarEditarPaquetes_Load(object sender, EventArgs e)
        {
            MostrarPaquetes();
            CargarComboDestino();
            cmbBus.Items.Clear();
            cmbBus.Items.Insert(0, "Seleccione el Bus");
            cmbTipoBus.Items.Clear();
            cmbTipoBus.Items.Insert(0, "Tipo de Bus");
            cmbHotel.Items.Clear();
            cmbHotel.Items.Insert(0, "Selecione el hotel");
            cmbRegimen.Items.Clear();
            cmbRegimen.Items.Insert(0, "Selecione el regimen");
            cmbDestino.SelectedIndex = 0;
            cmbRegimen.SelectedIndex = 0;
            cmbBus.SelectedIndex = 0;
            cmbTipoBus.SelectedIndex = 0;
            cmbHotel.SelectedIndex = 0;

            //txtDestino.Enabled = false;
            //a partir de aca hago algunas configuraciones del dgvPaquetes.

            dgvPaquetes.RowHeadersVisible = false;
            dgvPaquetes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaquetes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in dgvPaquetes.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //dgvPaquetes.Columns["FechaSalida"].DisplayIndex = 4; // Primera posición
            //dgvPaquetes.Columns["FechaRegreso"].DisplayIndex = 5; // Segunda posición
            int[] columnasParaOcultar = { 3, 4, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            foreach (int indice in columnasParaOcultar)
            {
                if (indice < dgvPaquetes.Columns.Count)
                {
                    dgvPaquetes.Columns[indice].Visible = false;
                }
            }
        }
        private void MostrarPaquetes()
        {
            CN_MostrarPaquetes CargadorDgv = new CN_MostrarPaquetes();
            List<CS_AtributosPaquete> Paquetes = new List<CS_AtributosPaquete>();
            Paquetes = CargadorDgv.MostrarPaquetes();
            dgvPaquetes.DataSource = Paquetes;
        }


        public void btnAgregarDestino_Click(object sender, EventArgs e)
        {
            FrmAgregarDestino NuevoDestino = new FrmAgregarDestino(this);
            NuevoDestino.ShowDialog();
        }

        public void AgregarDestinoAlTextBox(int id_destino, string destino)
        {
            Id_Destino = id_destino;
            //txtDestino.Text = destino;
        }
        public void AgregarHotelAlCombo(string nombreHotel)
        {
            NombreHotel = nombreHotel;
        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaActual = DateTime.Now.Date;
            CN_GuardarPaquete NuevoPaquete = new CN_GuardarPaquete();
            if (editar == false)
            {
                try
                {
                    CS_AtributosPaquete Paquete = new CS_AtributosPaquete()
                    {
                        FechaSalida = Convert.ToDateTime(dtpFechaSalida.Value),
                        FechaRegreso = Convert.ToDateTime(dtpFechaRegreso.Value),
                        Destino = Convert.ToString(cmbDestino.ValueMember),
                        CantidadDias = Convert.ToInt32(npdCantidasDias.Value),
                        CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                        Regimen = Convert.ToString(cmbRegimen.Text),
                        ProveedorHotel = Convert.ToString(cmbHotel.Text),
                        ProveedorBus = Convert.ToString(cmbBus.Text),
                        GastosAdministrativos = Convert.ToDecimal(txtGastosAdministrativos.Text),
                        PrecioLista = Convert.ToDecimal(txtPrecioLista.Text),
                        PrecioEfectivo = Convert.ToDecimal(txtPrecioEfectivo.Text),
                        Coste = Convert.ToDecimal(txtCoste.Text),
                        Disponibilidad = Convert.ToInt32(npdDisponibilidad.Value),
                        CantidadDeHab = Convert.ToInt32(lblHabitaciones.Text),
                        Single = Convert.ToInt32(lblCantidadSingle.Text),
                        Doble = Convert.ToInt32(lblCantidadDobles.Text),
                        Triple = Convert.ToInt32(lblCantidadTriples.Text),
                        Cuadruple = Convert.ToInt32(lblCantidadCuadruples.Text),
                        TipoBus = Convert.ToString(cmbTipoBus.Text),
                        CantidadAsientos = Convert.ToInt32(npdCantidadAsientos.Value),
                        AsientosCama = Convert.ToInt32(npdAsientosSemicama.Value),
                        AsientosSemicama = Convert.ToInt32(npdAsientosCama.Value),
                        Estado= Convert.ToString("Pendiente"),
                    };
                    NuevoPaquete.GuardarPaqueteL(Paquete);
                    MostrarPaquetes();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                }
                finally
                {
                    Limpiador.Limpiar(this);
                }
            }

            if (editar == true)
            {
                CN_EditarPaquetes EditarPaquete = new CN_EditarPaquetes();
                try
                {
                    CS_AtributosPaquete Paquete = new CS_AtributosPaquete()
                    {
                        Id_Paquete = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value.ToString()),
                        FechaSalida = Convert.ToDateTime(dtpFechaSalida.Value),
                        FechaRegreso = Convert.ToDateTime(dtpFechaRegreso.Value),
                        Destino = Convert.ToString(cmbDestino.Text),
                        CantidadDias = Convert.ToInt32(npdCantidasDias.Value),
                        CantidadNoches = Convert.ToInt32(npdCantidadNoches.Value),
                        Regimen = Convert.ToString(cmbRegimen.Text),
                        ProveedorHotel = Convert.ToString(cmbHotel.Text),
                        ProveedorBus = Convert.ToString(cmbBus.Text),
                        GastosAdministrativos = Convert.ToDecimal(txtGastosAdministrativos.Text),
                        PrecioLista = Convert.ToDecimal(txtPrecioLista.Text),
                        PrecioEfectivo = Convert.ToDecimal(txtPrecioEfectivo.Text),
                        Coste = Convert.ToDecimal(txtCoste.Text),
                        Disponibilidad = Convert.ToInt32(npdDisponibilidad.Value),
                        CantidadDeHab = Convert.ToInt32(lblHabitaciones.Text),
                        Single = Convert.ToInt32(lblCantidadSingle.Text),
                        Doble = Convert.ToInt32(lblCantidadDobles.Text),
                        Triple = Convert.ToInt32(lblCantidadTriples.Text),
                        Cuadruple = Convert.ToInt32(lblCantidadCuadruples.Text),
                        TipoBus = Convert.ToString(cmbTipoBus.Text),
                        CantidadAsientos = Convert.ToInt32(npdCantidadAsientos.Value),
                        AsientosCama = Convert.ToInt32(npdAsientosSemicama.Value),
                        AsientosSemicama = Convert.ToInt32(npdAsientosCama.Value),
                    };
                    EditarPaquete.EditarPaqueteL(Paquete);
                    MessageBox.Show("Los campos se han modificado con exito");
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
                }
                finally
                {
                    Limpiador.Limpiar(this);
                    editar = false;
                    MostrarPaquetes();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CN_EliminarPaquete EliminarPaquete = new CN_EliminarPaquete();
            if (dgvPaquetes.SelectedRows.Count > 0)
            {
                if (dgvPaquetes.CurrentRow != null && dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value != null)
                {
                    Id_Paquete = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value.ToString());
                    EliminarPaquete.EliminarPaqueteL(Id_Paquete);
                    MessageBox.Show("Eliminado correctamente");
                    MostrarPaquetes();
                }
                else
                {
                    MessageBox.Show("No existen paquetes para eliminar");
                    cmbDestino.Focus();
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiador.Limpiar(this);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count == 1)
            {
                DataGridViewRow DestinoParaVer = dgvPaquetes.SelectedRows[0];
                if (DestinoParaVer != null)
                {
                    FrmFolletoPaquete Folleto = new FrmFolletoPaquete(DestinoParaVer);
                    Folleto.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No hay paquetes para ver");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar solo un destino");
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            try
            {
                editar = true;
                if (dgvPaquetes.SelectedRows.Count > 0)
                {
                    if (dgvPaquetes.CurrentRow != null && dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value != null)
                    {
                        int Id_Paquete = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value);
                        cmbDestino.Text = dgvPaquetes.CurrentRow.Cells["Destino"].Value.ToString();
                        npdDisponibilidad.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Disponibilidad"].Value);
                        
                        cmbRegimen.Text = dgvPaquetes.CurrentRow.Cells["Regimen"].Value.ToString();
                        dtpFechaRegreso.Value = Convert.ToDateTime(dgvPaquetes.CurrentRow.Cells["FechaRegreso"].Value);
                        npdCantidasDias.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadDias"].Value);
                        npdCantidadNoches.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadNoches"].Value);
                        cmbHotel.Text = dgvPaquetes.CurrentRow.Cells["ProveedorHotel"].Value.ToString();
                        cmbBus.Text = dgvPaquetes.CurrentRow.Cells["ProveedorBus"].Value.ToString();
                        npdCantidadAsientos.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadAsientos"].Value);
                        npdAsientosSemicama.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["AsientosCama"].Value);
                        npdAsientosCama.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["AsientosSemicama"].Value);
                        txtGastosAdministrativos.Text = dgvPaquetes.CurrentRow.Cells["GastosAdministrativos"].Value.ToString();
                        txtPrecioEfectivo.Text = dgvPaquetes.CurrentRow.Cells["PrecioEfectivo"].Value.ToString();
                        txtPrecioLista.Text = dgvPaquetes.CurrentRow.Cells["PrecioLista"].Value.ToString();
                        
                        txtCoste.Text = dgvPaquetes.CurrentRow.Cells["Coste"].Value.ToString();
                        dtpFechaSalida.Value = Convert.ToDateTime(dgvPaquetes.CurrentRow.Cells["FechaSalida"].Value);
                        cmbTipoBus.Text = dgvPaquetes.CurrentRow.Cells["TipoBus"].Value.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No hay paquetes para editar.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
        }
        private void btnBuscarHotel_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedorHotel NuevoHotel = new FrmIngresarEditarProveedorHotel(this);
            NuevoHotel.ShowDialog();
        }
        public void CargarComboDestino()
        {
            CN_CargarComboDestino comboDestino = new CN_CargarComboDestino();
            List<string> Destino = new List<string>();
            Destino = comboDestino.CargarComboDestinosL();
            cmbDestino.Items.Clear();

            // Limpia el ComboBox
            // Agrega la frase en la primera posición
            cmbDestino.Items.Add("Seleccione el Destino");

            // Luego, agrega los elementos de la lista
            foreach (string item in Destino)
            {
                cmbDestino.Items.Add(item);
            }

            // Opcional: Establece "Seleccione el Destino" como el elemento seleccionado predeterminado
            cmbDestino.SelectedIndex = 0;
        }

        private void cmbHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CN_CargarHabitacionesHotel CargadorHabitacionesyRegimen = new CN_CargarHabitacionesHotel();

            if (cmbHotel.SelectedIndex > 0)
            {
                string nombreHotel = cmbHotel.SelectedItem.ToString();
                if (nombreHotel != null)
                {
                    CS_HabitacionesYRegimen habitacionesYRegimen = new CS_HabitacionesYRegimen();
                    habitacionesYRegimen = CargadorHabitacionesyRegimen.CargarHabitacionesL(nombreHotel);
                    if (habitacionesYRegimen != null)
                    {
                        cmbRegimen.Items.Add("Desayuno");
                        cmbRegimen.Items.Add("Media Pension");
                        cmbRegimen.Items.Add("Pension Completa");
                        lblHabitaciones.Text= habitacionesYRegimen.CantidadHabitaciones.ToString();
                        lblCantidadSingle.Text = habitacionesYRegimen.Single.ToString();
                        lblCantidadDobles.Text = habitacionesYRegimen.Doble.ToString();
                        lblCantidadTriples.Text = habitacionesYRegimen.Triple.ToString();
                        lblCantidadCuadruples.Text = habitacionesYRegimen.Cuadruple.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Este hotel no tiene las habitaciones cargadas");
                }
            }
            else
            {
                cmbRegimen.Items.Clear();
                cmbRegimen.Items.Insert(0, "Selecione el regimen");
                cmbRegimen.SelectedIndex = 0;
                lblHabitaciones.Text = 0.ToString();
                lblCantidadSingle.Text = 0.ToString();
                lblCantidadDobles.Text = 0.ToString();
                lblCantidadTriples.Text = 0.ToString();
                lblCantidadCuadruples.Text = 0.ToString();
            }
        }

        private void cmbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<int> asientos = new List<int>();
            CN_CargaAsientosBuses CargadorDeAsientos = new CN_CargaAsientosBuses();
            if (cmbBus.SelectedIndex > 0)
            {
                string nombreBus = cmbBus.SelectedItem.ToString();
                asientos = CargadorDeAsientos.CargaAsientosBusL(nombreBus);
                if (asientos != null)
                {
                    cmbTipoBus.Items.Add("Suite");
                    cmbTipoBus.Items.Add("Cama");
                    cmbTipoBus.Items.Add("SemiCama");
                    npdCantidadAsientos.Value = asientos[0];
                    npdAsientosCama.Value = asientos[1];
                    npdAsientosSemicama.Value = asientos[2];
                }
                else
                {
                    MessageBox.Show("Este bus no tiene la cantidad de asientos cargadas");
                }
            }
            else
            {
                cmbTipoBus.Items.Clear();
                cmbTipoBus.Items.Insert(0, "Tipo de Bus");
                cmbTipoBus.SelectedIndex = 0;
                npdCantidadAsientos.Value = 0;
                npdAsientosCama.Value = 0;
                npdAsientosSemicama.Value = 0;
            }
        }

        private void btnBuscarBus_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedorBus bus = new FrmIngresarEditarProveedorBus();
            bus.ShowDialog();
        }

        private void dgvPaquetes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPaquetes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvPaquetes.SelectedRows[0].Cells["Id_Paquete"].Value);
                string destino = dgvPaquetes.SelectedRows[0].Cells["Destino"].Value.ToString();
                DateTime fechaSalida = Convert.ToDateTime(dgvPaquetes.SelectedRows[0].Cells["FechaSalida"].Value);
                DateTime Regreso = Convert.ToDateTime(dgvPaquetes.SelectedRows[0].Cells["FechaRegreso"].Value);
                int Disponibilidad = Convert.ToInt32(dgvPaquetes.SelectedRows[0].Cells["Disponibilidad"].Value);
                if (Disponibilidad > 0)
                {
                    CrearReserva frm = new CrearReserva(id, destino, fechaSalida, Regreso, Disponibilidad);
                    frm.ShowDialog();
                }
            }
        }

        private void cmbDestino_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<string> Buses = new List<string>();
            List<string> Hoteles = new List<string>();
            CN_CargaComboBus CargadorBus = new CN_CargaComboBus();
            CN_CargaComboHotel CargadorComboHotel = new CN_CargaComboHotel();
            try
            {
                if (cmbDestino.SelectedIndex > 0)
                {
                    string Destino = cmbDestino.SelectedItem.ToString();
                    Hoteles = null;
                    Hoteles = CargadorComboHotel.CargaComboHotelL(Destino);
                    Buses = null;
                    Buses = CargadorBus.CargadorComboBusL(Destino);
                    if (Hoteles.Count > 0)
                    {
                        cmbHotel.Items.AddRange(Hoteles.ToArray());
                        if (Buses.Count > 0)
                        {
                            cmbBus.Items.AddRange(Buses.ToArray());
                        }
                        else
                        {
                            MessageBox.Show("Ese destino no tiene buses, debe cargarlos.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ese destino no tiene hoteles, debe cargarlos.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
            }
        }

        private void txtCoste_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(((TextBox)sender).Text, out _))
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
                ((TextBox)sender).Focus();
            }
        }
    }
}
