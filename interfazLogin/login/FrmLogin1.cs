using CapaNegocio;
using CapaServicios;
using CapaSesion;
using interfazLogin.Presentacion;
using interfazPpal;
using Loggin;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace interfazLogin
{
    public partial class FrmLogin1 : Form
    {
        MenuPpal menu1 = new MenuPpal();
        CN_GuardaRespuestas guardaRespuestas = new CN_GuardaRespuestas();
        CN_ValidarUsuario validarusuario = new CN_ValidarUsuario();
        CN_UsuarioEnSesion usuario = new CN_UsuarioEnSesion();

        string Aleatorio;
        public FrmLogin1()
        {
            InitializeComponent();
        }
        public FrmLogin1(string aleatorio)
        {
            InitializeComponent();
            Aleatorio = aleatorio;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ej.: ejemplo@gmail.com")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Ej.: ejemplo@gmail.com";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CN_BloquearUsuario BloqueadorUsuario = new CN_BloquearUsuario();
            FrmPreguntasSeguridad FrmPreguntasSeguridad = new FrmPreguntasSeguridad();
            FrmPrimerIngreso frmPrimerIngreso = new FrmPrimerIngreso();
            CN_registrarIntentosFallidos intentosFallidos = new CN_registrarIntentosFallidos();

            string pass = txtPass.Text;
            string Usuario = txtUsuario.Text;

            if (Aleatorio != txtPass.Text)
            {
                string concatenados = pass+Usuario;
                string hasheo = Seguridad.SHA256(concatenados);
                int digito = CreaDigitoVerificador.Calcular(hasheo);
                btnIngresar.Enabled = true; ;

                if (txtUsuario.Text != "Ej.: ejemplo@gmail.com")
                {
                    if (txtPass.Text != "Contraseña")
                    {
                        bool userexist = validarusuario.ValidarUsuarioL(txtUsuario.Text);
                        if (userexist)
                        {
                            bool bloqueado = CS_UsuarioEnSesion.Bloqueado;
                            int dias = CS_VencimientoPassword.CalcularDiasRestantes((DateTime)CS_UsuarioEnSesion.fechaPrimerIngreso, CS_UsuarioEnSesion.venceCada);
                            int intentos = CS_UsuarioEnSesion.intentos;
                            if (bloqueado == false)
                            {
                                if (intentos < 3)
                                {
                                    if (hasheo == CS_UsuarioEnSesion.password && digito == CS_UsuarioEnSesion.digito)
                                    {
                                        if (CS_UsuarioEnSesion.fechaPrimerIngreso == null)
                                        {
                                            frmPrimerIngreso.ShowDialog();
                                            this.Close();
                                        }
                                        else
                                        {
                                            DialogResult resultado = MessageBox.Show("Su contraseña esta por " +
                                            "vencer en " + " " + dias + " " + "dias. " + " " + "Desea cambiarla ahora?",
                                            "Contraseña por Vencer", MessageBoxButtons.OKCancel);

                                            if (resultado == DialogResult.OK)
                                            {
                                                FrmPreguntasSeguridad frm = new FrmPreguntasSeguridad();
                                                frm.ShowDialog();
                                                this.Close();
                                            }
                                            else
                                            {
                                                this.Hide();
                                                bienvenida saludo = new bienvenida();
                                                saludo.ShowDialog();
                                                menu1.Show();
                                                CN_ResetearIntentosFallidos reseteador = new CN_ResetearIntentosFallidos();
                                                reseteador.ReseteaIntentosFallidosL(Usuario);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("La contraseña es incorrecta. Intente de nuevo:");
                                        int nuevointento = intentos - 1;
                                        //intentosFallidos.registraIntentofallidoL(txtUsuario.Text, nuevointento);
                                        txtPass.Focus();
                                    }
                                }
                                else
                                {
                                    //BloqueadorUsuario.BloquearUsuarioL(txtUsuario.Text);
                                    MessageBox.Show("El Usuario ha sido Bloqueado \n Comuniquese con el administrador");
                                    btnIngresar.Enabled = false;
                                    txtPass.Clear();
                                    txtUsuario.Clear();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Usuario Bloqueado \n Comuniquese con el administrador");
                                btnIngresar.Enabled = false;
                                txtPass.Clear();
                                txtUsuario.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("EL usuario no existe");
                            txtUsuario.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresae una contraseña");
                        txtPass.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("debe ingresar un Usuario");
                    txtUsuario.Focus();
                }
            }
            else
            {
                FrmEditarPassword editar = new FrmEditarPassword(Aleatorio, Usuario);
                this.Close();
                editar.ShowDialog();
            }
        }

        private void lnkOlvidar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPreguntasSeguridad preguntas = new FrmPreguntasSeguridad();
            this.Hide();
            preguntas.Show();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            btnIngresar.Enabled = true;
        }
    }
}

