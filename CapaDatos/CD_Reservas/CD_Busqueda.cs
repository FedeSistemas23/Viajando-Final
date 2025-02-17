using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Busqueda
    {
      
            Conexion conn = new Conexion(); 
            SqlCommand cmd = new SqlCommand();

            public DataTable BuscarPorCoincidencia(string filtro)
            {
                DataTable tabla = new DataTable();
                try
                {
                    cmd.Connection = conn.AbrirConexion();
                    cmd.CommandText = "SP_BuscarCoincidencias"; 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Filtro", filtro); 

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(tabla); 

                    cmd.Parameters.Clear();
                    conn.CerrarConexion();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al buscar coincidencias: " + ex.Message);
                }

                return tabla;
            }
        }
    }

/*private void btnEditar_Click_1(object sender, EventArgs e)
{
    try
    {
        editar = true;
        if (dgvPaquetes.SelectedRows.Count > 0)
        {
            if (dgvPaquetes.CurrentRow != null && dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value != null)
            {
                int Id_Paquete = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Id_Paquete"].Value.ToString());
                txtDestino.Text = dgvPaquetes.CurrentRow.Cells["Destino"].Value.ToString();
                npdDisponibilidad.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Disponibilidad"].Value);
                npdSIngle.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Single"].Value);
                npdDobles.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Doble"].Value);
                npdTriple.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Triple"].Value);
                npdCuadruple.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["Cuadruple"].Value);
                cmbRegimen.Text = dgvPaquetes.CurrentRow.Cells["Regimen"].Value.ToString();
                dtpFechaRegreso.Value = Convert.ToDateTime(dgvPaquetes.CurrentRow.Cells["FechaRegreso"].Value);
                npdCantidasDias.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadDias"].Value);
                npdCantidadNoches.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadNoches"].Value);
                cmbHotel.Text = dgvPaquetes.CurrentRow.Cells["ProveedorHotel"].Value.ToString();
                cmbBus.Text = dgvPaquetes.CurrentRow.Cells["ProveedorBus"].Value.ToString();
                npdCantidadAsientos.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadAsientos"].Value);
                npdAsientosSemicama.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadCamas"].Value);
                npdAsientosCama.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadSemicamas"].Value);
                txtGastosAdministrativos.Text = dgvPaquetes.CurrentRow.Cells["TipoBus"].Value.ToString();
                txtPrecioEfectivo.Text = dgvPaquetes.CurrentRow.Cells["PrecioEfectivo"].Value.ToString();
                txtPrecioLista.Text = dgvPaquetes.CurrentRow.Cells["PrecioLista"].Value.ToString();
                npdCantidadHabitaciones.Value = Convert.ToInt32(dgvPaquetes.CurrentRow.Cells["CantidadDeHab"].Value);
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
            MessageBox.Show("seleccione una fila por favor");
        }
    }
    catch (Exception ex)
    {
        throw new Exception("Error al ejecutar SP o Conexion a la BD. \n \n" + ex.Message);
    }
}*/

