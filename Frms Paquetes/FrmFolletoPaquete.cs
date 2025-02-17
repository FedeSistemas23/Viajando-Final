using CapaNegocio;
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
    public partial class FrmFolletoPaquete : Form
    {
        DataGridViewRow DestinoElegido;
        public FrmFolletoPaquete(DataGridViewRow destinoparaver)
        {
            InitializeComponent();
            DestinoElegido = destinoparaver;
            CargarLabels();           
        }
        public void CargarLabels()
        {
            lblDestino.Text = DestinoElegido.Cells["Destino"].Value.ToString();
            lblSalidaEnNumeros.Text = DestinoElegido.Cells["FechaSalida"].Value.ToString();
            lblRegresoEnNumero.Text = DestinoElegido.Cells["FechaRegreso"].Value.ToString();
            lblTipoBus.Text = DestinoElegido.Cells["TipoBus"].Value.ToString();
            lblNombreHotel.Text = DestinoElegido.Cells["ProveedorHotel"].Value.ToString();
            lblTipoRegimen.Text = DestinoElegido.Cells["Regimen"].Value.ToString(); ;
            lblPrecLista.Text = DestinoElegido.Cells["PrecioLista"].Value.ToString();
            lblPrecEfectivo.Text = DestinoElegido.Cells["PrecioEfectivo"].Value.ToString();
            lblGastos.Text = DestinoElegido.Cells["GastosAdministrativos"].Value.ToString();
        }
    }
}
