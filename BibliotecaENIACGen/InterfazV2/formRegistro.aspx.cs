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
    public partial class formRegistro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
                linkSalir.Text = "Iniciar sesión";
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtNombre.Text != "" && txtApellidos.Text != "" && txtTelefono.Text != "" && txtEmail.Text != "" && txtPass.Text != "" && txtPass1.Text != "")
            {
                String id = txtId.Text;
                String nombre = txtNombre.Text;
                String apellido = txtApellidos.Text;
                int telefono = Convert.ToInt32(txtTelefono.Text);
                string email = txtEmail.Text;
                int penal = 0;
                string pass1 = txtPass.Text;
                string pass2 = txtPass1.Text;
                int tipo = 1;
                if (pass1 == pass2)
                {
                    UsuarioCEN usuario = new UsuarioCEN();
                    if (!usuario.Logearse(nombre,pass1))
                    {
                        usuario.New_(id, nombre, apellido, telefono, email, penal, pass1, true, tipo);
                        UsuarioEN aux = usuario.dameUsuario(nombre,pass1);
                        Session["usuario"] = aux;
                        Response.Redirect("zonaUsuario.aspx");
                    }
                    else
                    {
                        labelError.Text = "El usuario que intenta crear ya existe";
                        labelError.Visible = true;
                    }
                }
                else
                {
                    labelError.Text = "El password no coincide";
                    labelError.Visible = true;
                }
            }
            else
            {
                labelError.Text = "Introducir todos los campos";
                labelError.Visible = true;
            }
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