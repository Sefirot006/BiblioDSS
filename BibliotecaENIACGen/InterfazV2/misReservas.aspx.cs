﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;

namespace InterfazV2
{
    public partial class misReservas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioEN aux = (UsuarioEN)Session["usuario"];
            if (aux != null)
            {
                if (aux.Tipousuario == 1)
                {
                    labelUsuario.Text = "Bienvenido:  " + aux.Nombre;
                    linkSalir.Text = "Salir";
                    labelUsuario.Visible = true;
                    linkSalir.Visible = true;
                }
                else if (aux.Tipousuario == 2)
                    Response.Redirect("zonaPAS.aspx");
                else
                    Response.Redirect("zonaDirector.aspx");
            }
            else
            {
                linkSalir.Text = "Iniciar sesión";
            }
        }

        protected void hacerReservas(object sender, EventArgs e)
        {
            Response.Redirect("misReservas.aspx");
        }

        protected void mostrarReservas(object sender, EventArgs e)
        {
            Response.Redirect("misReservas.aspx");
        }

        protected void mostrarPrestecs(object sender, EventArgs e)
        {
            Response.Redirect("misPrestamos.aspx");
        }

        protected void misDatos(object sender, EventArgs e)
        {
            Response.Redirect("misDatos.aspx");
        }

        protected void hacerDesideratas(object sender, EventArgs e)
        {
            Response.Redirect("Desiderata.aspx");
        }
        public void verreservas_click(object sender, EventArgs e)
        {
            UsuarioEN aux = (UsuarioEN)Session["usuario"];
            ObraCEN obra = new ObraCEN();
            ReservaCEN reserva = new ReservaCEN();

            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> lreservas = null;
            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> mios = null;
            lreservas = reserva.ListaReservas(0, 20);
            mios = new List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN>();
            foreach (ReservaEN reser in lreservas) // guardamos todas mis reservas
            {
                if (reser.Usuario.DNI == aux.DNI )
                {
                    mios.Add(reser);
                }
            }

            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> misobras = null;
            misobras = new List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
            foreach (ReservaEN reser in mios) // guardamos todas las obras de los prestamos
            {
                foreach (ObraEN obras in reser.Obra)
                {
                    misobras.Add(obras);
                }
            }


            foreach (ObraEN obras in misobras) // mostramos las obras prestadas
            {
                //IMAGEN

                Label img = new Label();
                if (obras.Imagen.ToString().Equals("0"))
                {
                    img.Text = "Imagen No Disponible";
                }
                else
                {

                    img.Text = "<img src ='" + obras.Imagen + "' width='100' height='100'>";
                    PanelmiZona.Controls.Add(img);
                    PanelmiZona.Controls.Add(new LiteralControl("<br>"));
                }

                //ISBN
                Label lisbn = new Label();
                lisbn.Text = "ISBN:";
                PanelmiZona.Controls.Add(lisbn);
                PanelmiZona.Controls.Add(new LiteralControl("&nbsp"));
                Label liisbn = new Label();
                liisbn.Text = obras.Isbn;
                PanelmiZona.Controls.Add(liisbn);

                PanelmiZona.Controls.Add(new LiteralControl("<br>"));

                //TITULO
                Label lNom = new Label();
                lNom.Text = "Título:";
                PanelmiZona.Controls.Add(lNom);
                PanelmiZona.Controls.Add(new LiteralControl("&nbsp"));
                Label lNombre = new Label();
                lNombre.Text = obras.Nombre;
                PanelmiZona.Controls.Add(lNombre);

                PanelmiZona.Controls.Add(new LiteralControl("<br>"));

                //AUTOR
                Label lAut = new Label();
                lAut.Text = "Autor:";
                PanelmiZona.Controls.Add(lAut);
                PanelmiZona.Controls.Add(new LiteralControl("&nbsp"));
                Label lAutor = new Label();
                if (obras.Escrita != null)
                {
                    for (int i = 0; i < obras.Escrita.Count; i++)
                    {
                        if (i != obras.Escrita.Count - 1)
                        {
                            lAutor.Text += obras.Escrita[i].Nombre + ",";

                        }
                        else
                        {
                            lAutor.Text += obras.Escrita[i].Nombre;

                        }
                    }
                }
                else
                {
                    lAutor.Text = "Desconocido";
                }

                PanelmiZona.Controls.Add(lAutor);

                PanelmiZona.Controls.Add(new LiteralControl("<br>"));

                //TEMATICA
                Label lTem = new Label();
                lTem.Text = "Temática:";
                PanelmiZona.Controls.Add(lTem);
                PanelmiZona.Controls.Add(new LiteralControl("&nbsp"));
                Label lTematica = new Label();
                if (obras.Tematica != null)
                {

                    for (int i = 0; i < obras.Tematica.Count; i++)
                    {
                        if (i != obras.Tematica.Count - 1)
                        {
                            lTematica.Text += obras.Tematica[i].Nombre + ",";

                        }
                        else
                        {
                            lTematica.Text += obras.Tematica[i].Nombre;

                        }
                    }
                }
                else
                {
                    lTematica.Text = "Sin tematica";
                }

                PanelmiZona.Controls.Add(lTematica);
                PanelmiZona.Controls.Add(new LiteralControl("<br>"));
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