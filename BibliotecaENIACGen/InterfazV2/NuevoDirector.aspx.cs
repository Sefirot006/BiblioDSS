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
    public partial class NuevoDirector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioEN usuario = (UsuarioEN)Session["usuario"];
            if (usuario == null)
            {
                Response.Redirect("formLogin.aspx");
            }
            else if (usuario != null)
            {
                if (usuario.Tipousuario == 3)
                {
                    labelUsuario.Text = "Bienvenido:  " + usuario.Nombre;
                    linkSalir.Text = "Salir";
                    labelUsuario.Visible = true;
                    linkSalir.Visible = true;
                }
                else if (usuario.Tipousuario == 2)
                    Response.Redirect("zonaPAS.aspx");
                else
                    Response.Redirect("zonaUsuario.aspx");
            }
            else
            {
                linkSalir.Text = "Iniciar sesión";
            }
        }
        protected void altaPas(object sender, EventArgs e)
        {
            Response.Redirect("altaPAS.aspx");
        }
        protected void bajaPas(object sender, EventArgs e)
        {
            Response.Redirect("bajaPAS.aspx");
        }
        protected void nuevoDirector(object sender, EventArgs e)
        {
            Response.Redirect("NuevoDirector.aspx");
        }
        protected void checkPrestamos(object sender, EventArgs e)
        {
            Response.Redirect("prestamosChequear.aspx");
        }
        public void cambiarDir_click(object sender, EventArgs e)
        {
            UsuarioCEN usu = new UsuarioCEN();
            UsuarioEN seleccionado = new UsuarioEN();
            string identext = usuDirInput.Text;

            seleccionado = usu.DameporOID(identext);
            if (seleccionado != null)
            {
                seleccionado.Tipousuario = 3;

                usu.Modify(seleccionado.DNI, seleccionado.Nombre, seleccionado.Apellidos, seleccionado.Telefono, seleccionado.Correo, seleccionado.Penalizacion, seleccionado.Contrasenya, seleccionado.Logeado, seleccionado.Tipousuario);
                Label lmsg = new Label();

                lmsg.Text = "Dar de alta como Director ha sido un exito";
                Panel3.Controls.Add(lmsg);
                Panel3.Controls.Add(new LiteralControl("&nbsp"));
            }
            else
            {
                Label lmsg = new Label();

                lmsg.Text = "No existe un usuario con ese ID";
                Panel3.Controls.Add(lmsg);
                Panel3.Controls.Add(new LiteralControl("&nbsp"));
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