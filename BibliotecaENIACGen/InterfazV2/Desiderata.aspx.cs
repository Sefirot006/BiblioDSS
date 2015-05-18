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
    public partial class Desiderata : System.Web.UI.Page
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
                if (usuario.Tipousuario == 1)
                {
                    labelUsuario.Text = "Bienvenido:  " + usuario.Nombre;
                    linkSalir.Text = "Salir";
                    labelUsuario.Visible = true;
                    linkSalir.Visible = true;
                }
                else if (usuario.Tipousuario == 2)
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
            if (txtAutor.Text != "" && txtTitulo.Text != "")
            {
                
                DesiderataCEN desiderata = new DesiderataCEN();
                string editorial = txtEditorial.Text;
                string anyo = txtAno.Text;
                if (editorial == "")
                    editorial = "Sin especificar";
                if (anyo == "")
                    anyo = "1900";
                if (usuario.Tipousuario == 1)
                    desiderata.New_(txtAutor.Text, txtTitulo.Text, editorial, Convert.ToInt16(anyo), usuario.DNI, false);
                else if (usuario.Tipousuario == 2)
                    desiderata.New_(txtAutor.Text, txtTitulo.Text, editorial, Convert.ToInt16(anyo), usuario.DNI, false);
                Response.Redirect("zonaUsuario.aspx");
            }
            else
            {
                labelError.Text = "Introducir al menos Título y Autor";
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

        protected void hacerDesideratas(object sender, EventArgs e)
        {
            Response.Redirect("Desiderata.aspx");
        }

        protected void misDatos(object sender, EventArgs e)
        {
            Response.Redirect("misDatos.aspx");
        }

        protected void misPrestamos(object sender, EventArgs e)
        {
            Response.Redirect("prestamosChequear.aspx");
        }

        protected void mostrarReservas(object sender, EventArgs e)
        {

        }

        protected void hacerReservas(object sender, EventArgs e)
        {
            Response.Redirect("misReservas.aspx");
        }
    }
}