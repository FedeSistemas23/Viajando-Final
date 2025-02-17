﻿using CapaSesion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_EditarReserva : Conexion
    {
        SqlCommand cmd = new SqlCommand();
        Conexion conexion = new Conexion();
        public bool EditarReserva_CD(CS_Reserva reserva)
        {
            cmd.Connection = AbrirConexion();
            cmd.CommandText = "EditarReserva";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NroReserva", reserva.NroReserva);
            cmd.Parameters.AddWithValue("@Id_pasajero", reserva.Id_pasajero) ;
            cmd.Parameters.AddWithValue("@Id_Paquete", reserva.Id_Paquete);
            cmd.Parameters.AddWithValue("@CantidadPasajeros", reserva.CantidadPasajeros);
            cmd.Parameters.AddWithValue("@Id_Vendedor", reserva.Id_Vendedor);
            cmd.Parameters.AddWithValue("@NombreVendedor", reserva.NombreVendedor);
            cmd.Parameters.AddWithValue("@Destino", reserva.Destino);
            cmd.Parameters.AddWithValue("@FechaSalida", reserva.FechaSalida);
            cmd.Parameters.AddWithValue("@fecha", reserva.FechaReserva);
            cmd.Parameters.AddWithValue("@fechaRegreso", reserva.FechaRegreso);
            
            if (reserva.NroPago.HasValue)
                cmd.Parameters.AddWithValue("@NroPago", reserva.NroPago);
            else
                cmd.Parameters.AddWithValue("@NroPago", DBNull.Value);

                                           
            if (!string.IsNullOrEmpty(reserva.AscensoMicro))
                cmd.Parameters.AddWithValue("@Ascenso", reserva.AscensoMicro);
            else
                cmd.Parameters.AddWithValue("@Ascenso", DBNull.Value);

            if (reserva.CantMenorTres.HasValue)
                cmd.Parameters.AddWithValue("@PasajerosMenores", reserva.CantMenorTres);
            else
                cmd.Parameters.AddWithValue("@PasajerosMenores", DBNull.Value);

            if (reserva.AsientosCama.HasValue)
                cmd.Parameters.AddWithValue("@AsientosCama", reserva.AsientosCama);
            else
                cmd.Parameters.AddWithValue("@AsientosCama", DBNull.Value);


            if (reserva.AsientosSemiCama.HasValue)
                cmd.Parameters.AddWithValue("@AsientosSemicama", reserva.AsientosSemiCama);
            else
                cmd.Parameters.AddWithValue("@AsientosSemicama", DBNull.Value);

            if (reserva.Single.HasValue)
                cmd.Parameters.AddWithValue("@Single", reserva.Single);
            else
                cmd.Parameters.AddWithValue("@Single", DBNull.Value);

            if (reserva.Doble.HasValue)
                cmd.Parameters.AddWithValue("@Doble", reserva.Doble);
            else
                cmd.Parameters.AddWithValue("@Doble", DBNull.Value);

            if (reserva.Triple.HasValue)
                cmd.Parameters.AddWithValue("@Triple", reserva.Triple);
            else
                cmd.Parameters.AddWithValue("@Triple", DBNull.Value);

            if (reserva.Cuadruple.HasValue)
                cmd.Parameters.AddWithValue("@Cuadruple", reserva.Cuadruple);
            else
                cmd.Parameters.AddWithValue("@Cuadruple", DBNull.Value);

            if (reserva.CamaSimple.HasValue)
                cmd.Parameters.AddWithValue("@CamaSimple", reserva.CamaSimple);
            else
                cmd.Parameters.AddWithValue("@CamaSimple", DBNull.Value);

            if (reserva.CamaMatrimonial.HasValue)
                cmd.Parameters.AddWithValue("@CamaMatrimonial", reserva.CamaMatrimonial);
            else
                cmd.Parameters.AddWithValue("@CamaMatrimonial", DBNull.Value);

            if (reserva.AdicionalCama)
                cmd.Parameters.AddWithValue("@AdicionalCama", reserva.AdicionalCama);
            else
                cmd.Parameters.AddWithValue("@AdicionalCama", DBNull.Value);


            if (reserva.Cotizar)
                cmd.Parameters.AddWithValue("@Cotizar", reserva.Cotizar);
            else
                cmd.Parameters.AddWithValue("@Cotizar", DBNull.Value);


           
                cmd.Parameters.AddWithValue("@Seña", reserva.Senia);
           

            if (!string.IsNullOrEmpty(reserva.Observacion))
                cmd.Parameters.AddWithValue("@Observacion", reserva.Observacion);
            else
                cmd.Parameters.AddWithValue("@Observacion", DBNull.Value);

            if (reserva.Habitaciones.HasValue)
                cmd.Parameters.AddWithValue("@Habitaciones", reserva.Habitaciones);
            else
                cmd.Parameters.AddWithValue("@Habitaciones", DBNull.Value);

            if (!String.IsNullOrEmpty(reserva.NombreTitular))
                cmd.Parameters.AddWithValue("@NombreTitular", reserva.NombreTitular);
            else
                cmd.Parameters.AddWithValue("@NombreTitular", DBNull.Value);

            if (!String.IsNullOrEmpty(reserva.ApellidoTitular))
                cmd.Parameters.AddWithValue("@ApellidoTitular", reserva.ApellidoTitular);
            else
                cmd.Parameters.AddWithValue("@ApellidoTitular", DBNull.Value);



            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conexion.CerrarConexion();

            return true;
        }
    }
}
