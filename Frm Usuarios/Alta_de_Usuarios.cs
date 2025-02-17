using CapaNegocio;
using CapaServicios;
using CapaSesion;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Loggin
{
    public partial class Alta_de_Usuarios : Form
    {

        public Alta_de_Usuarios()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CN_Alta_Usuario AltaUsuario = new CN_Alta_Usuario();
            string pass = Aleatorios.Armar();          
            string concatenados = pass+txtUsuario.Text;
            

            ArmarMail.Preparar(txtUsuario.Text, txtEmail.Text, pass);
            string hasheo = Seguridad.SHA256(concatenados);


            CS_AtributosUsuario NuevoUsuario = new CS_AtributosUsuario()

            {
                Username = txtUsuario.Text,
                password = hasheo,
                Digito = CreaDigitoVerificador.Calcular(hasheo),
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Apellidos = txtApellido.Text,
                TipoDocumento = txtTipoDoc.Text,
                NumDocumento = txtNumDoc.Text,
                Telefono = txtTelefono.Text,
                Celular = txtCelular.Text,
                Calle = txtCalle.Text,
                NumCalle = Convert.ToInt32(txtNumCalle.Text),
                Localidad = txtLocalidad.Text,
                Partido = txtProvincia.Text,
                Provincia = txtProvincia.Text,
                pais = txtPais.Text,
                Familia = cmbFamilias.Text,
                intentos = Convert.ToInt32(npdIntentos.Value), // Usar Value para obtener el valor numérico de NumericUpDown.
                VencePass = Convert.ToInt32(npdVenceCada.Value),
                AvisarVencimientoPassword = Convert.ToBoolean(ckbAvisarVencimiento.Checked),
                ContraseñasAnteriores = Convert.ToBoolean(chbContraseñasAnteriores.Checked),
                Minuscula = Convert.ToBoolean(ckbMinuscula.Checked),
                Mayuscula = Convert.ToBoolean(ckbMayuscula.Checked),
                Numeros = Convert.ToBoolean(ckbNumero.Checked),
                CaracterEspecial = Convert.ToBoolean(ckbEspecial.Checked),
                Minimo8Caracteres = Convert.ToBoolean(ckbMinimo.Checked),
                RealizarPreguntasSeguridad = Convert.ToBoolean(ckbRealizarPreguntasSeguridad.Checked),
                Autenticacion2pasos = Convert.ToBoolean(ckbAutenticacion2FA.Checked),
                Bloqueado = Convert.ToBoolean(chbBloqueado.Checked),
                BloqueadoHasta = Convert.ToInt32(npdBloqueadoPorDias.Value),
                UsuarioTemporal = Convert.ToBoolean(ckbUsuarioTemporal.Checked),
                VenceUsuario = Convert.ToInt32(npdVenceUsuario.Value),
                VencenPermisos = Convert.ToInt32(npdVencePermisos.Value),
            };
            foreach (string permisos in clbPermisos.CheckedItems)
            {
                NuevoUsuario.Permisos.Add(permisos);
            }
            AltaUsuario.AñadirAtributos(NuevoUsuario);
          
            MessageBox.Show("Se ha enviado la 1° contraseña al E-mail.");
            txtUsuario.Focus();
        }
    }
}

