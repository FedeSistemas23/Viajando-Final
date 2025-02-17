using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaSesion;
using CapaDatos;
using System.Deployment.Internal;

namespace Loggin
{
    public partial class FrmBuscarReserva : Form
    {
        CS_Reserva reservaCS = new CS_Reserva();
        CN_MostrarReserva mostrar = new CN_MostrarReserva();

        public FrmBuscarReserva()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CrearReserva reserva = new CrearReserva();
            reserva.ShowDialog();
        }

        bool ParametroBusqueda;


        public void buscquedaPor(bool parametro)
        {

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CN_Busqueda buscarPaqueteCN = new CN_Busqueda();
            DataTable mostrar = buscarPaqueteCN.BuscarReservaPorFechaRegreso_CD();
            dgvBuscarReserva.DataSource = null;
            dgvBuscarReserva.DataSource = mostrar;


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtNumReserva_TextChanged(object sender, EventArgs e)
        {
            if (txtNumReserva.Text == "")
                dgvBuscarReserva.DataSource = null;
            else
            {
                int nroReserva = Convert.ToInt32(txtNumReserva.Text);

                dgvBuscarReserva.Visible = true;
                CN_Busqueda mostrar = new CN_Busqueda();
                DataTable dt = mostrar.ObtenerCoincidenciasCN(nroReserva); // Busca con el texto del TextBox
                dgvBuscarReserva.DataSource = dt;
            }
        }

        private void txtDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtDestino.Text == "")
                dgvBuscarReserva.DataSource = null;
            else
            {
                dgvBuscarReserva.Visible = true;
                CN_Busqueda buscarPaqueteCN = new CN_Busqueda();
                DataTable dt = buscarPaqueteCN.ObtenerCoincidencias(txtDestino.Text); // Busca con el texto del TextBox
                dgvBuscarReserva.DataSource = dt;
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CN_Busqueda buscarPaqueteCN = new CN_Busqueda();
            DataTable mostrar = buscarPaqueteCN.MostrarReservasPorNombreCN();
            dgvBuscarReserva.DataSource = null;
            dgvBuscarReserva.DataSource = mostrar;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            CN_Busqueda buscarPaqueteCN = new CN_Busqueda();
            DataTable mostrar = buscarPaqueteCN.MostrarReservasPorApellidoCN();
            dgvBuscarReserva.DataSource = null;
            dgvBuscarReserva.DataSource = mostrar;

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CN_Busqueda buscarPaqueteCN = new CN_Busqueda();
            DataTable mostrar = buscarPaqueteCN.MostrarReservasPorFechaReservaCN();
            dgvBuscarReserva.DataSource = null;
            dgvBuscarReserva.DataSource = mostrar;

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CN_Busqueda buscarPaqueteCN = new CN_Busqueda();
            DataTable mostrar = buscarPaqueteCN.MostrarReservasPorDestinoCN();
            dgvBuscarReserva.DataSource = null;
            dgvBuscarReserva.DataSource = mostrar;

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CN_Busqueda buscarPaqueteCN = new CN_Busqueda();
            DataTable mostrar = buscarPaqueteCN.MostrarReservasPorFechaSalidaCN();
            dgvBuscarReserva.DataSource = null;
            dgvBuscarReserva.DataSource = mostrar;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void ckbNumRerva_CheckedChanged(object sender, EventArgs e)
        {

            CN_Busqueda buscarPaqueteCN = new CN_Busqueda();
            DataTable mostrar = buscarPaqueteCN.MostrarReservasPorNumReservaCN();
            dgvBuscarReserva.DataSource = null;
            dgvBuscarReserva.DataSource = mostrar;

        }
    }
}
    

