using CapaSesion;
using interfazPpal;
using System;
using System.Windows.Forms;


namespace Loggin
{
    public partial class MenuPpal : Form
    {
        
        FrmIngresarEditarPaquetes NuevoPaquete = new FrmIngresarEditarPaquetes();
        // frmlogin = new FrmLogin1();
        public MenuPpal()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Name = "Sistema de reservas Viajando";
        }

        private void AbrirFormuEnPanelMenu(object formHijo)
        {
            if (this.menuContenedor.Controls.Count > 0)
                this.menuContenedor.Controls.RemoveAt(0);
            Form form = formHijo as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.menuContenedor.Controls.Add(form);
            this.menuContenedor.Tag = form;
            form.Show();
        }
        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_de_Usuarios form = new Alta_de_Usuarios();
            // form.Show();
            AbrirFormuEnPanelMenu(form);
            //Alta_de_Usuarios frm = new Alta_de_Usuarios();
            //nuContenedor.Show();
        }

        private void editarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           CrearReserva frm = new CrearReserva();
            frm.ShowDialog();
        }

        private void crearNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarPaquetes frm = new FrmIngresarEditarPaquetes();
            AbrirFormuEnPanelMenu(frm);
        }

        private void pagoAVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagoVendedor pagoVendedor = new FrmPagoVendedor();
            pagoVendedor.Show();
        }

        private void ingresarEditarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagoRecibidos pagoRecibidos = new FrmPagoRecibidos(1, 1);
            pagoRecibidos.Show();
        }

        private void eliminarPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPagoRecibidos pagoRecibidos = new FrmPagoRecibidos(1, 1);
            pagoRecibidos.Show();
        }

        private void ingresarEditarPagoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPagoProveedores pagoProveedores = new FrmPagoProveedores(0);
            pagoProveedores.Show();
        }

        private void eliminarPagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPagoProveedores pagoProveedores = new FrmPagoProveedores(0, 1);
            pagoProveedores.Show();
        }

        private void pagosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmPagoRecibidos pagoRecibidos = new FrmPagoRecibidos(1, 1);
            pagoRecibidos.Show();
        }    

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedorHotel proveedor = new FrmIngresarEditarProveedorHotel();
            proveedor.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CS_UsuarioEnSesion.LimpiarUsuario();         //var login = new FrmLogin1();
            Application.Exit();            
        }

       
        private void ingresarPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargaPasajeros CargaPax = new FrmCargaPasajeros();
            CargaPax.ShowDialog();
        }

        private void buscarPaqueteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarPaquete buscarPaquete = new FrmBuscarPaquete();
            buscarPaquete.ShowDialog();
        }

        private void cancelarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarReserva buscarReserva = new FrmBuscarReserva();
            buscarReserva.ShowDialog();
        }

        private void buscarPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarPasajero buscarPasajero = new FrmBuscarPasajero();
            buscarPasajero.ShowDialog();
        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedorHotel proveedorHotel = new FrmIngresarEditarProveedorHotel();
            proveedorHotel.ShowDialog();
        }

        private void busesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresarEditarProveedorBus buses = new FrmIngresarEditarProveedorBus();
            buses.ShowDialog();  
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Alta_de_Usuarios NuevoUsuario = new Alta_de_Usuarios();
            NuevoUsuario.ShowDialog();
        }

        private void eliminarPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*int tipoDeFormulario = ;
            FrmCargaPasajeros eliminarPasajero = new FrmCargaPasajeros(tipoDeFormulario.ToString());
            eliminarPasajero.ShowDialog();*/
        }

        private void buscarReservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarReserva buscarReserva = new FrmBuscarReserva();
            buscarReserva.ShowDialog(); 
        }

        private void paquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuscarPaquete buscarPaquete = new FrmBuscarPaquete();
            buscarPaquete.ShowDialog();
        }
    }
}
