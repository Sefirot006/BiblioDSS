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
                DesiderataCEN desiderata = new DesiderataCEN();
                
            }
            else
            {
                labelError.Text = "Introducir al menos Título y Autor";
                labelError.Visible = true;
            }
        }
    }
}