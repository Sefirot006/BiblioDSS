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
            int i = 0;


            /*bloque para añadir al desplegable de autores todos los autores*/

           /* if (ListBox1.Items.Count == 0)
            {
                System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> autores;
                AutorCAD aut = new AutorCAD();
                autores = aut.BuscarAutor();
                for (i = 0; i < autores.Count; i++)
                {
                    ListItem l = new ListItem(autores[i].Nombre);

                    ListBox1.Items.Add(l);

                }
            }*/

            /*bloque para añadir al desplegable de autores todos las tematica*/

           /* if (tematica.Items.Count == 0)
            {
                System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> temas;
                TematicaCAD theme = new TematicaCAD();
                temas = theme.BuscarTemas();
                for (i = 0; i < temas.Count; i++)
                {
                    ListItem l = new ListItem(temas[i].Nombre);

                    tematica.Items.Add(l);

                }
            }*/

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

            /*foreach (ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    AutorEN autor = new AutorEN();
                    autor.Nombre = li.Text;
                    autores.Add(autor);
                    autoresString.Add(li.Text);

                }
            }

            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> temas = null;
            temas = new List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();
            foreach (ListItem li in tematica.Items)
            {
                if (li.Selected)
                {
                    TematicaEN theme = new TematicaEN();
                    theme.Nombre = li.Text;
                    temas.Add(theme);
                    //temas.Add(li.Text);
                }
            }
            */
            if (obraEn != null)
            {
                
                obra.Modify(id,titulo,pag,year,urlImg);

                /*AutorCEN a = new AutorCEN();
                System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> aEn = a.BuscarAutor(autoresString);
                bool loEscribe = false;

                // Autor que no escribe la obra
                for (int i = 0; i < aEn.Count; i++)
                {
                    for(int j = 0; j < aEn[i].Escribe.Count; j++ )
                    {
                        if (aEn[i].Escribe[j].Nombre == titolInput.Text)
                        {
                            loEscribe = true;
                        }
                    }

                    if (loEscribe == false)
                    {
                        obraEn.Escrita = autores;
                        aEn[i].Escribe.Add(obraEn);
                        a.Modify(aEn[i].Nombre,aEn[i]);
                    }
                    loEscribe = false;
                }*/
                    
               
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




                   /* //AUTOR
                    Label lAut = new Label();
                    lAut.Text = "Autor:";
                    PanelPASModDown.Controls.Add(lAut);
                    PanelPASModDown.Controls.Add(new LiteralControl("&nbsp"));
                    Label lAutor = new Label();
                    if (obraEn.Escrita != null)
                    {
                        for (i = 0; i < obraEn.Escrita.Count; i++)
                        {
                            if (i != obraEn.Escrita.Count - 1)
                            {
                                lAutor.Text += obraEn.Escrita[i].Nombre + ",";

                            }
                            else
                            {
                                lAutor.Text += obraEn.Escrita[i].Nombre;

                            }
                        }
                    }
                    else
                    {
                        lAutor.Text = "Desconocido";
                    }

                    PanelPASModDown.Controls.Add(lAutor);

                    PanelPASModDown.Controls.Add(new LiteralControl("<br>"));

                    //TEMATICA

                    Label lTem = new Label();
                    lTem.Text = "Temática:";
                    PanelPASModDown.Controls.Add(lTem);
                    PanelPASModDown.Controls.Add(new LiteralControl("&nbsp"));
                    Label lTematica = new Label();
                    if (obraEn.Tematica != null)
                    {

                        for (i = 0; i < obraEn.Tematica.Count; i++)
                        {
                            if (i != obraEn.Tematica.Count - 1)
                            {
                                lTematica.Text += obraEn.Tematica[i].Nombre + ",";

                            }
                            else
                            {
                                lTematica.Text += obraEn.Tematica[i].Nombre;

                            }
                        }
                    }
                    else
                    {
                        lTematica.Text = "Sin tematica";
                    }

                    PanelPASModDown.Controls.Add(lTematica);
                    PanelPASModDown.Controls.Add(new LiteralControl("<br>"));*/



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
    }
}