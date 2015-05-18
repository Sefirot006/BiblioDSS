using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;

namespace InterfazV2.Account
{

    public partial class Register : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            RegisterUser.ContinueDestinationPageUrl = Request.QueryString["ReturnUrl"];
        }

        protected void RegisterUser_CreatedUser(object sender, EventArgs e)
        {
            //Obtenemos la informacion de los textBox
            TextBox surname = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Surname");
            TextBox DNI = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("UserName");
            TextBox telefono = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Telefono");
            TextBox name = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Nombre");
            TextBox correo = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Email");
            TextBox contrasenya = (TextBox)RegisterUserWizardStep.ContentTemplateContainer.FindControl("Password");
            
            //inicializamos las variables
            string nombre = null;
            string email = null;
            string password = null;
            string apellidos = null;
            int tlf = 0;
            string idDNI = null;
            

            //Default para coockeis
            FormsAuthentication.SetAuthCookie(RegisterUser.UserName, false /* createPersistentCookie */);
            //FormsAuthentication.SetAuthCookie(RegisterUser.Email, false /* createPersistentCookie */);
            //FormsAuthentication.SetAuthCookie(RegisterUser.Password, false /* createPersistentCookie */);
            
            //insertamos en la variables los datos de los text box
            nombre = name.Text;
            apellidos = surname.Text;
            tlf = Convert.ToInt32(telefono.Text);
            idDNI = DNI.Text;
            email = correo.Text;
            password = contrasenya.Text;
           
            //Creamos e insertamos un usuario nuevo registrado
            UsuarioCEN usuCen = new UsuarioCEN();
            usuCen.New_(idDNI, nombre, apellidos, tlf, email, 0, password, true, 1);

            string continueUrl = RegisterUser.ContinueDestinationPageUrl;
            if (String.IsNullOrEmpty(continueUrl))
            {
                continueUrl = "~/";
            }
            Response.Redirect(continueUrl);
        }

    }
}
