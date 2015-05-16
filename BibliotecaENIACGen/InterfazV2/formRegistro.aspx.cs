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
                int tipo = 0;
                if (pass1 == pass2)
                {
                    UsuarioCEN usuario = new UsuarioCEN();
                    if (!usuario.Logearse(nombre,pass1))
                    {
                        usuario.New_(id, nombre, apellido, telefono, email, penal, pass1, true, tipo);
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        labelError.Text = "El usuario que intenta crear ya existe";
                        labelError.Visible = true;
                        //Response.Redirect("formRegistro.aspx");
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
            
            

           /* string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (String.IsNullOrEmpty(continueUrl))
            {
                continueUrl = "~/";
            }
            Response.Redirect(continueUrl);*/
        }
    }
}