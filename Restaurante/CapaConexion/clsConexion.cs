using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace Restaurante.CapaConexion{

    public class clsConexion{

        SqlConnection oCN = new SqlConnection("Server = tcp:clases.database.windows.net,1433; Initial Catalog = Ejemplo; Persist Security Info = False; User ID = estudiante; Password =progra3.; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30");

        public bool abrirConexion() {
            try {
                oCN.Open();
                return true;
            } catch(Exception) {
                return false;
            }
        }//fin abrirConexion

        public bool cerrarConexion() {
            try {
                if(oCN.State == ConnectionState.Open) {
                    oCN.Close();
                }
                return true;
            } catch(Exception) {
                oCN.Close();
                return true;
            }
        }//Fin cerrarConexion

        public bool ejecCMD(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = oCN;
                if(abrirConexion()) {
                    oSQLC.ExecuteNonQuery();
                }
                cerrarConexion();
                return true;
            } catch(Exception) {
                return false;
            }
        }//FIN EJEcmd

        public DataTable ejecCMDSelect(SqlCommand oSQLC) {
            try {
                oSQLC.Connection = oCN;
                DataTable oDT = new DataTable();
                SqlDataAdapter oSLDA = new SqlDataAdapter(oSQLC);
                if(abrirConexion()) {
                    oSLDA.Fill(oDT);
                }
                cerrarConexion();
                return oDT;
            } catch(Exception) {
                throw;
            }
        }//fin ejecCMDSelect

    }//fin clsConexion
}//fin Restaurante.CapaConexion