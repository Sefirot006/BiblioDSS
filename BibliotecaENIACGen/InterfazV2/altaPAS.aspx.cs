﻿using System;
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
    public partial class altaPAS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
        public void contratar_click(object sender, EventArgs e)
        {
            UsuarioCEN usu = new UsuarioCEN();
            UsuarioEN seleccionado = new UsuarioEN();
            string identext = usuPASInput.Text;

            seleccionado = usu.DameporOID(identext);
            if (seleccionado != null)
            {
                seleccionado.Tipousuario = 2;

                usu.Modify(seleccionado.DNI, seleccionado.Nombre, seleccionado.Apellidos, seleccionado.Telefono, seleccionado.Correo, seleccionado.Penalizacion, seleccionado.Contrasenya, seleccionado.Logeado, seleccionado.Tipousuario);

                Label lmsg = new Label();

                lmsg.Text = "Dar de alta como PAS ha sido un exito";
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
    }
}