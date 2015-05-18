using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace InterfazV2
{
    public partial class misPrestamos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioEN aux = (UsuarioEN)Session["usuario"];
            if (aux != null)
            {
                if (aux.Tipousuario == 1)
                {
                    labelUsuario.Text = "Bienvenido:  " + aux.Nombre;
                    linkSalir.Text = "Salir";
                    labelUsuario.Visible = true;
                    linkSalir.Visible = true;
                }
                else if (aux.Tipousuario == 2)
                    Response.Redirect("zonaPAS.aspx");
                else
                    Response.Redirect("zonaDirector.aspx");
            }
            else
            {
                linkSalir.Text = "Iniciar sesión";
            }
        }

        protected void hacerReservas(object sender, EventArgs e)
        {
            Response.Redirect("misReservas.aspx");
        }

        protected void mostrarReservas(object sender, EventArgs e)
        {
            Response.Redirect("misReservas.aspx");
        }

        protected void mostrarPrestecs(object sender, EventArgs e)
        {
            Response.Redirect("misPrestamos.aspx");
        }

        protected void misDatos(object sender, EventArgs e)
        {
            Response.Redirect("misDatos.aspx");
        }

        protected void hacerDesideratas(object sender, EventArgs e)
        {
            Response.Redirect("Desiderata.aspx");
        }

        protected void linkSalir_Click(object sender, EventArgs e)
        {
            if (linkSalir.Text == "Salir")
            {
                Session.Remove("usuario");
                labelUsuario.Visible = false;
                Response.Redirect("Default.aspx");
            }
            else
            {
                UsuarioEN aux = (UsuarioEN)Session["usuario"];
                if (aux != null)
                {
                    labelUsuario.Text = "Bienvenido:  " + aux.Nombre;
                    linkSalir.Text = "Salir";
                    labelUsuario.Visible = true;
                    linkSalir.Visible = true;
                }
                else
                {
                    Response.Redirect("formLogin.aspx");
                }
            }
        }
    }
}