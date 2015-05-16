using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterfazV2
{
    public partial class zonaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                labelUsuario.Text = "Bienvenido:  " + Session["usuario"].ToString();
                linkSalir.Text = "Salir";
                labelUsuario.Visible = true;
                linkSalir.Visible = true;
            }
            else
            {
                linkSalir.Text = "Iniciar sesión";
                //Response.Redirect("formLogin.aspx");
            }
        }
        protected void mostrarReservas(object sender, EventArgs e)
        {
        }

        protected void hacerReservas(object sender, EventArgs e)
        {

        }

        protected void misPrestamos(object sender, EventArgs e)
        {

        }

        protected void misDatos(object sender, EventArgs e)
        {

        }

        protected void hacerDesideratas(object sender, EventArgs e)
        {
            Response.Redirect("Desiderata.aspx");
        }

        protected void linkSalir_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            labelUsuario.Visible = false;
            Response.Redirect("Default.aspx");
        }
    }
}