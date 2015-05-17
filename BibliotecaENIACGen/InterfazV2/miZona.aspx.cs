using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;

namespace InterfazV2
{
    public partial class miZona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioEN usuario = (UsuarioEN)Session["usuario"];
            if (usuario.Tipousuario == 1)
                Response.Redirect("zonaUsuario.aspx");
            else if (usuario.Tipousuario == 2)
                Response.Redirect("zonaPAS.aspx");
            else if (usuario.Tipousuario == 3)
                Response.Redirect("zonaDirector.aspx");
         }

        protected void Reservas(object sender, EventArgs e, UsuarioEN user)
        {
            Console.WriteLine("Entro");
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