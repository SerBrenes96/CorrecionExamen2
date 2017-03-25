using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurante.CapaEntidad {
    public class clsReserva {
        private String strNombre;
        private String strCed;
        private String strnTipoReserva;
        private String dtFecha;

        //constructor
        public clsReserva() {
        }
        public clsReserva(String strNombre, String strCed, String strnTipoReserva, String dtFecha) {
            this.strNombre = strNombre;
            this.strCed = strCed;
            this.strnTipoReserva = strnTipoReserva;
            this.dtFecha = dtFecha;
        }

        //PROPERTIES
        public string propNombre { get { return this.strNombre; } set { this.strNombre = value; } }
        public string propCedula { get { return this.strCed; } set { this.strCed = value; } }
        public string propTipoReserva { get { return this.strnTipoReserva; } set { this.strnTipoReserva = value; } }
        public string propFecha { get { return this.dtFecha; } set { this.dtFecha = value; } }


    }//fin clsReserva
}//fin Restaurante.CapaEntidad