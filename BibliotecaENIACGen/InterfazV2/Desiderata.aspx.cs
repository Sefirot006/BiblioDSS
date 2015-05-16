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
            //UsuarioEN usuario
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtAutor.Text != "" && txtTitulo.Text != "")
            {
                UsuarioEN usuario = (UsuarioEN)Session["usuario"];
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
            }
            else
            {
                labelError.Text = "Introducir al menos Título y Autor";
                labelError.Visible = true;
            }
        }
    }
}