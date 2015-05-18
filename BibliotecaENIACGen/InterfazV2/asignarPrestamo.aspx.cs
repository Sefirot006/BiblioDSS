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
    public partial class asignarPrestamo : System.Web.UI.Page
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
                if (usuario.Tipousuario == 2)
                {
                    labelUsuario.Text = "Bienvenido:  " + usuario.Nombre;
                    linkSalir.Text = "Salir";
                    labelUsuario.Visible = true;
                    linkSalir.Visible = true;
                }
                else if (usuario.Tipousuario == 1)
                    Response.Redirect("zonaUsuario.aspx");
                else
                    Response.Redirect("zonaDirector.aspx");
            }
            else
            {
                linkSalir.Text = "Iniciar sesión";
            }
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
        protected void eliminarPrestamo(object sender, EventArgs e)
        {
            PrestamoCEN prestamoCEN = new PrestamoCEN();
            PrestamoEN prestamoEN = new PrestamoEN();
            UsuarioEN usuEN = new UsuarioEN();
            UsuarioCEN usuCEN = new UsuarioCEN();
            ReservaEN resEN = new ReservaEN();
            ReservaCAD resCEN = new ReservaCAD();

            usuEN = usuCEN.DameporOID(DNIInput.Text);

            EjemplarEN ejemplarEN = new EjemplarEN();
            EjemplarCAD ejemplarCAD = new EjemplarCAD();
            EjemplarCEN ejemplarCEN = new EjemplarCEN();

            DateTime hoy = new DateTime();
            hoy = DateTime.Now;
            DateTime devolucion = new DateTime();
            devolucion = DateTime.Now;
            devolucion = devolucion.AddDays(7);

            if (EjamplarInput.Text != "" && DNIInput.Text != "" && IsbnInput.Text != "")
            {

                ejemplarEN = ejemplarCAD.ReadOIDDefault(Convert.ToInt32(EjamplarInput.Text));
                Console.WriteLine(ejemplarEN);
                // antes de borrar saber si existe
                prestamoEN = prestamoCEN.BuscarPrestamo(ejemplarEN.Id.ToString() + ejemplarEN.Obra.Isbn);
                if (prestamoEN != null)
                {
                    prestamoCEN.Destroy(ejemplarEN.Id.ToString() + ejemplarEN.Obra.Isbn);
                    ejemplarCEN.Modify(Convert.ToInt32(EjamplarInput.Text), false, ejemplarEN.Reservado);
                    Label lexito = new Label();
                    lexito.Text = "Préstamo eliminado";
                    PanelPASModDown.Controls.Add(lexito);
                }
                else
                {
                    Label lerror4 = new Label();
                    lerror4.Text = "Este préstamo no existe";
                    PanelPASModDown.Controls.Add(lerror4);
                }
                
            }
            else
            {
                Label lerror = new Label();
                lerror.Text = "Rellene todos los campos por favor";
                PanelPASModDown.Controls.Add(lerror);
            }
        }
        protected void confirmarPrestamo(object sender, EventArgs e)
        {
            PrestamoCEN prestamoCEN = new PrestamoCEN();
            PrestamoEN prestamoEN = new PrestamoEN();
            UsuarioEN usuEN = new UsuarioEN();
            UsuarioCEN usuCEN = new UsuarioCEN();
            ReservaEN resEN = new ReservaEN();
            ReservaCAD resCEN = new ReservaCAD();

            usuEN = usuCEN.DameporOID(DNIInput.Text);
            
            EjemplarEN ejemplarEN = new EjemplarEN();
            EjemplarCAD ejemplarCAD = new EjemplarCAD();
            EjemplarCEN ejemplarCEN = new EjemplarCEN();

            DateTime hoy = new DateTime();
            hoy = DateTime.Now;
            DateTime devolucion = new DateTime();
            devolucion = DateTime.Now;
            devolucion = devolucion.AddDays(7);
            String salida;


                if (EjamplarInput.Text != "" && DNIInput.Text !="" && IsbnInput.Text != "")
                {
                    ejemplarEN = ejemplarCAD.ReadOIDDefault(Convert.ToInt32(EjamplarInput.Text));

                    //no esta reservado
                    if (ejemplarEN.Reservado == false)
                    {
                        if (ejemplarEN.Obra.Isbn == IsbnInput.Text)
                        {
                            if (usuEN != null)
                            {
                                prestamoEN = prestamoCEN.BuscarPrestamo(ejemplarEN.Id.ToString() + ejemplarEN.Obra.Isbn);
                                if (prestamoEN == null)
                                {
                                    salida = prestamoCEN.New_(ejemplarEN.Id.ToString() + ejemplarEN.Obra.Isbn, devolucion, hoy, ejemplarEN.Id,usuEN);
                                    ejemplarCEN.Modify(Convert.ToInt32(EjamplarInput.Text), true, ejemplarEN.Reservado);
                                    
                                    Label lexitoPrestamos = new Label();
                                    lexitoPrestamos.Text = "La operación ha sido un exito";
                                    PanelPASModDown.Controls.Add(lexitoPrestamos);
                                }
                                else
                                {
                                    Label lerrorPrestamos = new Label();
                                    lerrorPrestamos.Text = "Ha ocurrido un error: Este ejemplar ya esta prestado, revise sus datos de entrada";
                                    PanelPASModDown.Controls.Add(lerrorPrestamos);
                                }
                            }
                            else
                            {
                                Label lerrorUsuario = new Label();
                                lerrorUsuario.Text = "El usuario no existe";
                                PanelPASModDown.Controls.Add(lerrorUsuario);
                            }
                        }
                        else
                        {
                            Label lerrorIsbn = new Label();
                            lerrorIsbn.Text = "El isbn del ejemplar y el isbn de la obra deben de coincidir";
                            PanelPASModDown.Controls.Add(lerrorIsbn);
                        }
                    }
                    else
                    {
                        //Esta reservado Pero por quien?
                        
                        bool reservaObra = false;

                        // Esta hecha por el usuario que quiere retirar el ejemplar?
                        for (int i = 0; i < usuEN.Reserva.Count; i++)
                        {
                            Console.WriteLine(usuEN.Reserva[i].Obra);
                            Console.WriteLine(ejemplarEN.Obra);
                            if (usuEN.Reserva[i].Obra[0].Isbn== ejemplarEN.Obra.Isbn)
                            {
                                // si has hecho una reserva a esa obra
                                // esa reserva esta activa al dia de hoy


                                int result = DateTime.Compare(usuEN.Reserva[i].FechaVencimiento.Value, hoy);
                                if (result >= 0)
                                {
                                    reservaObra = true;
                                    salida = prestamoCEN.New_(ejemplarEN.Id.ToString() + ejemplarEN.Obra.Isbn, devolucion, hoy, ejemplarEN.Id, usuEN);
                                    ejemplarCEN.Modify(Convert.ToInt32(EjamplarInput.Text), true, ejemplarEN.Reservado);

                                    Label lexitoPrestamos = new Label();
                                    lexitoPrestamos.Text = "La operación ha sido un exito";
                                    PanelPASModDown.Controls.Add(lexitoPrestamos);
                                }
                            }
                        }
                        //Resulta que no has hecho reserva y ademas esta reservada por otro
                        if (reservaObra == false)
                        {
                            Label lNom = new Label();
                            lNom.Text = "Lo sentimo no puede realizar el prestamo sobre este ejemplar al usuario elegido";
                            PanelPASModDown.Controls.Add(lNom);
                        }
                    }
                }
                else
                {
                    Label lerror = new Label();
                    lerror.Text = "Rellene todos los campos por favor";
                    PanelPASModDown.Controls.Add(lerror);
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

        protected void linkSalir_Click1(object sender, EventArgs e)
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