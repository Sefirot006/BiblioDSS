using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;
using System.Net;
using System.Net.Mail;

namespace InterfazV2
{
    public partial class prestamosChequear : System.Web.UI.Page
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
            
        }

        protected void enviarEmail(object sender, EventArgs e, string correoPas, string correoUsu, string passPas, string titulo)
        {
            MailMessage correo = new MailMessage();

            correo.From = new MailAddress(correoPas);

            correo.To.Add(correoUsu);
            correo.Subject = "Aceptación de desiderata";
            correo.Body = "Le informamos que su petición sobre la obra: " + titulo + " ha sido aceptado";
            correo.IsBodyHtml = false;
            correo.Priority = MailPriority.Normal;

            SmtpClient smpt = new SmtpClient();
            smpt.Credentials = new NetworkCredential(correoPas, passPas);

            smpt.Host = "smtp.gmail.com";
            smpt.Port = 587;
            smpt.EnableSsl = true;

            try
            {
                smpt.Send(correo);
                Label lmsg = new Label();

                lmsg.Text = "Correo enviado a "+correoUsu +" correctamente";
                Panel3.Controls.Add(lmsg);
                Panel3.Controls.Add(new LiteralControl("&nbsp"));
            }
            catch
            {
                Console.WriteLine("Fail");
            }
            correo.Dispose();

        }
        public void enviar_notificacion_click(object sender, EventArgs e)
        {
            UsuarioCEN usu = new UsuarioCEN();
            PrestamoCEN prest = new PrestamoCEN();

            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> lprestamos = null;
            lprestamos = prest.ListarPrestamos(0, 100);


            foreach (PrestamoEN presta in lprestamos)
            {

                DateTime today = DateTime.Now;
                DateTime vencimiento = presta.FechaVencimiento.Value;

                today.AddDays(3);


                if (today.Equals(vencimiento))
                {
                    //mandar el codigo de notificacion a

                    //presta.Usuario.Correo

                    enviarEmail(sender, e, emailInput.Text, presta.Usuario.Correo, passInput.Text, presta.Ejemplar.Obra.Nombre);
                }
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