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
    public partial class zonaPAS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void asignarPrestamo(object sender, EventArgs e)
        {
            Response.Redirect("asignarPrestamo.aspx");
        }
        protected void verDesideratas(object sender, EventArgs e)
        {
            Response.Redirect("desideratas.aspx");
        }
        protected void nuevaObra(object sender, EventArgs e)
        {
            Response.Redirect("nuevaObra.aspx");
        }
        protected void modificarObra(object sender, EventArgs e)
        {
            Response.Redirect("modificarObra.aspx");
        }
        protected void borrarObra(object sender, EventArgs e)
        {
            Response.Redirect("borrarObra.aspx");
        }
    }
}