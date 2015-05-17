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
    public partial class misDatos : System.Web.UI.Page
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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioEN usuario = (UsuarioEN)Session["usuario"];
            txtNombre.Text = usuario.Nombre;
            txtApellidos.Text = usuario.Apellidos;
            txtTelefono.Text = Convert.ToString(usuario.Telefono);
            txtEmail.Text = usuario.Correo;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            labelConfirmar.Visible = true;
            txtPass.Visible = true;
            btnConfirmar.Visible = true;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            UsuarioEN usuario = (UsuarioEN)Session["usuario"];
            if (usuario.Contrasenya == txtPass.Text)
            {
                UsuarioCEN aux = new UsuarioCEN();
                String nombre = txtNombre.Text;
                String apellidos = txtApellidos.Text;
                int tel = Convert.ToInt32(txtTelefono.Text);
                String email = txtEmail.Text;
                aux.Modify(usuario.DNI, nombre, apellidos, tel, email, usuario.Penalizacion, usuario.Contrasenya, usuario.Logeado, usuario.Tipousuario);
                Session.Remove("usuario");
                Session["usuario"] = new UsuarioCEN().dameUsuario(nombre,txtPass.Text);
                Response.Redirect("zonaUsuario.aspx");
            }
            else
            {
                labelConfirmar.Text = "El password es incorrecto";
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

        protected void hacerDesideratas(object sender, EventArgs e)
        {
            Response.Redirect("Desiderata.aspx");
        }

        protected void misdatos_Click(object sender, EventArgs e)
        {
            Response.Redirect("misDatos.aspx");
        }

        protected void misprestamos_Click(object sender, EventArgs e)
        {
            
        }

        protected void misreservas_Click(object sender, EventArgs e)
        {

        }

        protected void hacerreserva_Click(object sender, EventArgs e)
        {
            Response.Redirect("misReservas.aspx");
        }
    }
}