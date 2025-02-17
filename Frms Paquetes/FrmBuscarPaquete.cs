using CapaNegocio;
using CapaSesion;
using Loggin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfazPpal
{
    public partial class FrmBuscarPaquete : Form
    {
        CN_Busqueda objNegocio = new CN_Busqueda();
        List<CS_AtributosPaquete> Paquetes = new List<CS_AtributosPaquete>();


        public FrmBuscarPaquete()
        {
            InitializeComponent();
        }
        private void FrmBuscarPaquete_Load(object sender, EventArgs e)
        {
            MostrarPaquetes();
            CargarFiltros();
        }
        
        private void MostrarPaquetes()
        {
            CN_MostrarPaquetes paquetes = new CN_MostrarPaquetes();
            
            try
            {
                CN_MostrarPaquetes CargadorDgv = new CN_MostrarPaquetes();
                Paquetes = CargadorDgv.MostrarPaquetes();
                dgvMostrarPaquetes.DataSource = Paquetes;
                //FormatearGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los paquetes: " + ex.Message);
            }
        }
        private void CargarFiltros()
        {
            
            cmbEstado.Items.Clear();
            cmbEstado.Items.Add("Todos");
            cmbEstado.Items.Add("Pendiente");
            cmbEstado.Items.Add("Realizado");
            cmbEstado.Items.Add("Cancelado");
            cmbEstado.SelectedIndex = 0; // "Todos" seleccionado por defecto

            /*ComboBox Destinos
            var destinosUnicos = listaPaquetes.Select(p => p.Destino).Distinct().ToList();
            destinosUnicos.Insert(0, "Todos");
            comboBoxDestinos.DataSource = destinosUnicos;
            comboBoxDestinos.SelectedIndex = 0;*/

            // DateTimePicker (Fechas por defecto)
            dtpFechaSalida.Value = DateTime.Today;
            dtpFechaRegreso.Value = DateTime.Today.AddMonths(5);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarPaquetes();

        }
        private void FiltrarPaquetes()
        {
            string estadoSeleccionado = cmbEstado.SelectedItem?.ToString() ?? "Todos";
            DateTime fechaDesde = dtpFechaSalida.Value;
            DateTime fechaHasta = dtpFechaRegreso.Value;
            string destinoBuscado = txtDestino.Text.Trim().ToLower();

            var paquetesFiltrados = Paquetes
                .Where(p => (estadoSeleccionado == "Todos" || p.Estado == estadoSeleccionado))
                .Where(p => (p.FechaSalida >= fechaDesde && p.FechaSalida <= fechaHasta))
                .Where(p => string.IsNullOrEmpty(destinoBuscado) || p.Destino.ToLower().Contains(destinoBuscado))
                .ToList();

            dgvMostrarPaquetes.DataSource = paquetesFiltrados;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //int id = ObtenerIdPaquete(dgvMostrarPaquetes);

            if (dgvMostrarPaquetes.SelectedRows.Count > 0)
            {

                int id = Convert.ToInt32(dgvMostrarPaquetes.SelectedRows[0].Cells["Id_Paquete"].Value);
                string destino = dgvMostrarPaquetes.SelectedRows[0].Cells["Destino"].Value.ToString();
                DateTime fechaSalida = Convert.ToDateTime(dgvMostrarPaquetes.SelectedRows[0].Cells["FechaSalida"].Value);
                DateTime Regreso = Convert.ToDateTime(dgvMostrarPaquetes.SelectedRows[0].Cells["FechaRegreso"].Value);
                int Disponibilidad = Convert.ToInt32(dgvMostrarPaquetes.SelectedRows[0].Cells["Disponibilidad"].Value);
                if (Disponibilidad > 0)
                {
                    this.Dispose();
                    CrearReserva frm = new CrearReserva(id, destino, fechaSalida, Regreso, Disponibilidad);                   
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No hay lugares disponibles para este paquete","lugares agotados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun paquete", "Seleccione una fila", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
    }
}
