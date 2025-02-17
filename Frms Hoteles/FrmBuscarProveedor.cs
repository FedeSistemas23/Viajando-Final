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

namespace interfazPpal
{
    public partial class FrmBuscarProveedor : Form
    {
        CN_MostrarProveedor Proveedor;
        public FrmBuscarProveedor()
        {
            InitializeComponent();
            Proveedor=new CN_MostrarProveedor();
        }

        private void FrmBuscarProveedor_Load(object sender, EventArgs e)
        {
            MostrarProveedor();
        }
        private void MostrarProveedor()
        {
            dgvProveedorHotel.DataSource = Proveedor.MostrarProveedor();
        }

    }
}
