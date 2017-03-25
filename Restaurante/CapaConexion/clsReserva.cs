using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.CapaConexion {
    public class clsReserva {

        public bool insertarReserva(CapaEntidad.clsReserva oReserva) {
            SqlCommand oSQLC = new SqlCommand("INSERT INTO Reserva(tipo_reserva, fecha_reserva, nombre_cliente, cedula_cliente) VALUES (@Tipo_Reserva, @Fecha, @Cliente, @Cedula);");
            oSQLC.Parameters.Add("@Tipo_Reserva", SqlDbType.VarChar, 10).Value = oReserva.propTipoReserva;
            oSQLC.Parameters.Add("@Fecha", SqlDbType.VarChar, 10).Value = oReserva.propFecha;
            oSQLC.Parameters.Add("@Cliente", SqlDbType.VarChar, 30).Value = oReserva.propNombre;
            oSQLC.Parameters.Add("@Cedula", SqlDbType.VarChar, 30).Value = oReserva.propCedula;
            return new clsConexion().ejecCMD(oSQLC);
        }//FIN INSERTAR RESERVA

        public DataTable selectReservaUnica() {
            SqlCommand oSQLC = new SqlCommand("SELECT tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula FROM reserva WHERE num_reserva=1");
            return new clsConexion().ejecCMDSelect(oSQLC);
        }//FIN SELECT RESERVA UNICA

        public DataTable selectReserva() {
            SqlCommand oSQLC = new SqlCommand("SELECT tipo_reserva as [Tipo de reserva], fecha_reserva as Fecha, nombre_cliente as Cliente, cedula_cliente as Cedula FROM reserva");
            return new clsConexion().ejecCMDSelect(oSQLC);
        }


    }//FIN CLSRESERVA
}//FIN Restaurante.CapaConexion