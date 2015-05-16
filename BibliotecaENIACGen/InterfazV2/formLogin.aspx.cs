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
    public partial class formLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
                Response.Redirect("Default.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtPass.Text != "")
            {
                UsuarioCEN usuario = new UsuarioCEN();
                if (usuario.Logearse(txtUsuario.Text, txtPass.Text))
                {
                    UsuarioEN aux = new UsuarioCEN().dameUsuario(txtUsuario.Text,txtPass.Text);

                    Session["usuario"] = aux;
                    Response.Redirect("zonaUsuario.aspx");
                }
                else
                {
                    labelError.Text = "Usuario o Password inválido";
                    labelError.Visible = true;
                }
            }
            else
            {
                labelError.Text = "Ingresar usuario y contraseña";
                labelError.Visible = true;
            }
        }

        protected void linkOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("formRegistro.aspx");
        }

        
    }
}