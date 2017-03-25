using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Restaurante.CadaNegocios {
    public class clsReservaNegocios {

        public bool insertReserva(String nombre, String idced, String fecha, String tipo) {
            return new CapaConexion.clsReserva().insertarReserva(new CapaEntidad.clsReserva(nombre, idced, fecha, tipo));
        }//fin de insertReserva

        public DataTable returnSelectUnico() {
            return new CapaConexion.clsReserva().selectReservaUnica();
        }//fin de returnSelectUnico

        public DataTable returnSelectGlobal() {
            return new CapaConexion.clsReserva().selectReserva();
        }//fin retunsSelectGlobal

    }//clsReservaNegocios
}//fin Restaurante.CadaNegocios