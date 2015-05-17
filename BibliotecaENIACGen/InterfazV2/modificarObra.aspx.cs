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
    public partial class modificarObra : System.Web.UI.Page
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

        protected void asignarPrestamo(object sender, EventArgs e)
        {
            Response.Redirect("asignarPrestamo.aspx");
        }
        protected void verDesideratas(object sender, EventArgs e)
        {

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
        protected void confirmarModificacionObra(object sender, EventArgs e)
        {
            string id = isbnInput.Text;
            string titulo = titolInput.Text;
            short pag = Convert.ToInt16(paginasInput.Text);
            short year = Convert.ToInt16(anyoInput.Text);
            string urlImg = imgInput.Text;
            ObraCEN obra = new ObraCEN();
            
            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> autores = null;
            autores = new List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();
            System.Collections.Generic.IList<String> autoresString = null;
            autoresString = new List<String>();
            ObraEN obraEn = new ObraEN();
            obraEn = obra.BuscaPorId(busquedaInput.Text);

            if (obraEn != null)
            {
                
                obra.Modify(id,titulo,pag,year,urlImg);    
            }
            
        }
        protected void buscarObraIsbn(object sender, EventArgs e)
        {
            ObraEN obraEn = new ObraEN();
            ObraCEN obra = new ObraCEN();
            string id = "";
            int i = 0;
            if (busquedaInput.Text.Count() > 0)
            {
                id = busquedaInput.Text;
                obraEn = obra.BuscaPorId(id);
                if (obraEn != null)
                {
                    isbnInput.Text = obraEn.Isbn;

                    //IMAGEN

                    Label img = new Label();
                    if (obraEn.Imagen.ToString() == "0")
                    {
                        img.Text = "Imagen No Disponible";
                    }
                    else
                    {

                        img.Text = "<img src ='" + obraEn.Imagen + "' width='100' height='100'>";
                        PanelPASModDown.Controls.Add(img);
                        PanelPASModDown.Controls.Add(new LiteralControl("<br>"));
                        imgInput.Text = obraEn.Imagen.ToString();
                    }

                    //TITULO
                    Label lNom = new Label();
                    lNom.Text = "Título:";
                    PanelPASModDown.Controls.Add(lNom);
                    PanelPASModDown.Controls.Add(new LiteralControl("&nbsp"));
                    Label lNombre = new Label();
                    lNombre.Text = obraEn.Nombre;
                    PanelPASModDown.Controls.Add(lNombre);
                    titolInput.Text = obraEn.Nombre;
                    PanelPASModDown.Controls.Add(new LiteralControl("<br>"));


                    //PAGINAS
                    Label lPag = new Label();
                    lPag.Text = "Nº Páginas:";
                    PanelPASModDown.Controls.Add(lPag);
                    PanelPASModDown.Controls.Add(new LiteralControl("&nbsp"));
                    Label lPaginas = new Label();
                    lPaginas.Text = obraEn.Paginas.ToString();
                    PanelPASModDown.Controls.Add(lPaginas);
                    paginasInput.Text = obraEn.Paginas.ToString();
                    PanelPASModDown.Controls.Add(new LiteralControl("<br>"));


                    //ANYO
                    Label lany = new Label();
                    lany.Text = "Año:";
                    PanelPASModDown.Controls.Add(lany);
                    PanelPASModDown.Controls.Add(new LiteralControl("&nbsp"));
                    Label lAnyo = new Label();
                    lAnyo.Text = obraEn.Anyo.ToString();
                    PanelPASModDown.Controls.Add(lAnyo);
                    anyoInput.Text = obraEn.Anyo.ToString();
                    PanelPASModDown.Controls.Add(new LiteralControl("<br>"));

                }
                else
                {
                    Label error = new Label();
                    error.Text = "ISBN incorrecto";
                    PanelPASModDown.Controls.Add(error);
                }
            }
            else
            {
                Label error = new Label();
                error.Text = "Introduzca algún dato";
                PanelPASModDown.Controls.Add(error);          
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