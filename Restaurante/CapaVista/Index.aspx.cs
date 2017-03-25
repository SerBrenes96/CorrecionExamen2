using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace Restaurante.CapaVista
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){
            if(!IsPostBack) {
                GridView1.DataSource = new CadaNegocios.clsReservaNegocios().returnSelectGlobal();
                GridView1.DataBind();
                GridView2.DataSource = new CadaNegocios.clsReservaNegocios().returnSelectUnico();
                GridView2.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e) {
            new CadaNegocios.clsReservaNegocios().insertReserva(txtNombre.Text, txtCedula.Text, txtReserva.SelectedItem.Text, dtpDate.Value);
            GridView1.DataSource = new CadaNegocios.clsReservaNegocios().returnSelectGlobal();
            GridView1.DataBind();
        }

    }
}