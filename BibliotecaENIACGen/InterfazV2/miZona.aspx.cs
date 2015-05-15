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
            string usuario = Convert.ToString(Session["idUser"]);
            string pass = Convert.ToString(Session["pass"]);

            //Vamos averiguar de que tipo es el usuario loggueado

            /*DirectorCEN directorCEN = new DirectorCEN();
            DirectorEN directorEN = new DirectorEN();
            DirectorCAD directorCAD = new DirectorCAD();

             directorEN = directorCAD.ReadOIDDefault(usuario);*/

            UsuarioCEN userCEN = new UsuarioCEN();
            UsuarioEN userEN = new UsuarioEN();

            userEN = userCEN.DameporOID(usuario);
            if (userEN != null)//Como minimo es usuario normal
            {
                //diferentes vistas según el tipo de usuario
                if (userEN.Tipousuario == 1)//usuario normal
                {
                    Response.Redirect("About.aspx");

                }
                else if (userEN.Tipousuario == 2)//usuario PAS
                {
                    Response.Redirect("zonaPAS.aspx");
                }
                else if (userEN.Tipousuario == 3)//usuario Director
                {

                }
                

                

            }
        }
        protected void Reservas(object sender, EventArgs e, UsuarioEN user)
        {
            Console.WriteLine("Entro");
        }


    }
}