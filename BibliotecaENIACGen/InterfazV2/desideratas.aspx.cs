using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Security.Permissions; 

using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;

namespace InterfazV2
{
    public partial class desideratas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void asignarPrestamo1(object sender, EventArgs e)
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
        protected void modificaObra(object sender, EventArgs e)
        {
            Response.Redirect("modificarObra.aspx");
        }
        protected void borrarObra(object sender, EventArgs e)
        {
            Response.Redirect("borrarObra.aspx");
        }
        protected void aceptarDesiderata(object sender, EventArgs e)
        {
            PASCEN pasCEN = new PASCEN();
            
            UsuarioCEN usuCEN = new UsuarioCEN();
            UsuarioEN usuEN = new UsuarioEN();
            
            if (desiInput.Text != "")
            {
                DesiderataCEN desiCEN = new DesiderataCEN();
                DesiderataEN desiEN = new DesiderataEN();
                DesiderataCAD desiCAD = new DesiderataCAD();

                desiEN = desiCAD.ReadOIDDefault(Convert.ToInt32(desiInput.Text));

                usuEN = usuCEN.DameporOID(desiEN.Usuario.DNI);


                pasCEN.AceptarDesiderata(desiInput.Text);
                if (emailInput.Text != "" && passInput.Text != "")
                {
                    enviarEmail(sender, e, emailInput.Text, usuEN.Correo, passInput.Text,desiEN.Titulo);
                }
                else
                {
                    Label lmsg = new Label();

                    lmsg.Text = "Aceptada con exito pero no se ha enviado un email de notificación";
                    PanelDesi.Controls.Add(lmsg);
                    PanelDesi.Controls.Add(new LiteralControl("&nbsp"));
                }
                
            }
            

        }
        protected void enviarEmail(object sender, EventArgs e,string correoPas, string correoUsu, string passPas, string titulo)
        {
            MailMessage correo = new MailMessage();
            
            correo.From = new MailAddress(correoPas);
            
            correo.To.Add(correoUsu);
            correo.Subject = "Aceptación de desiderata";
            correo.Body = "Le informamos que su petición sobre la obra: "+titulo+" ha sido aceptado";
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

                lmsg.Text = "Correo enviado y desiderata ha sido aceptada";
                PanelDesi.Controls.Add(lmsg);
                PanelDesi.Controls.Add(new LiteralControl("&nbsp"));
            }
            catch
            {
                Console.WriteLine("Fail");
            }
            correo.Dispose();



            /*var fromAddress = new MailAddress("danielperezsansano@gmail.com", "Daniel");
            var toAddress = new MailAddress("danpesan@hotmail.com", "Daniel");
            const string fromPassword = "superdanielito1988";
            const string subject = "Subject";
            const string body = "Body";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 465,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);         
            }*/

            



        }
        protected void listarDesideratasFalse(object sender, EventArgs e)
        {
            DesiderataCEN desiCEN = new DesiderataCEN();
           

            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> lista;

            lista = new List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN>();

            lista = desiCEN.ListaDesideratasPendientes(false);

            if (lista != null)
            {
                foreach (DesiderataEN desiEN in lista)
                {
                    //ID
                    Label lNum = new Label();
                    lNum.Text = "Número:";
                    PanelDesi.Controls.Add(lNum);
                    PanelDesi.Controls.Add(new LiteralControl("&nbsp"));
                    Label lNumero = new Label();
                    lNumero.Text = desiEN.Id.ToString();
                    PanelDesi.Controls.Add(lNumero);

                    PanelDesi.Controls.Add(new LiteralControl("<br>"));
                    //TITULO
                    Label lNom = new Label();
                    lNom.Text = "Título:";
                    PanelDesi.Controls.Add(lNom);
                    PanelDesi.Controls.Add(new LiteralControl("&nbsp"));
                    Label lNombre = new Label();
                    lNombre.Text = desiEN.Titulo;
                    PanelDesi.Controls.Add(lNombre);

                    PanelDesi.Controls.Add(new LiteralControl("<br>"));

                    //Autor
                    Label lAut = new Label();
                    lAut.Text = "Autor:";
                    PanelDesi.Controls.Add(lAut);
                    PanelDesi.Controls.Add(new LiteralControl("&nbsp"));
                    Label lAutor = new Label();
                    lAutor.Text = desiEN.Autor;
                    PanelDesi.Controls.Add(lAutor);

                    PanelDesi.Controls.Add(new LiteralControl("<br>"));

                    //Usuario
                    Label lUsu = new Label();
                    lUsu.Text = "DNI:";
                    PanelDesi.Controls.Add(lUsu);
                    PanelDesi.Controls.Add(new LiteralControl("&nbsp"));
                    Label lUsuario = new Label();
                    lUsuario.Text = desiEN.Usuario.DNI;
                    PanelDesi.Controls.Add(lUsuario);

                    PanelDesi.Controls.Add(new LiteralControl("<br>"));
                    PanelDesi.Controls.Add(new LiteralControl("<br>"));
                }
            }
        }
    }
}
