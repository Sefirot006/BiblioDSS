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
    public partial class borrarObra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

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
        protected void borrarObra1(object sender, EventArgs e)
        {
            Response.Redirect("borrarObra.aspx");
        }
        protected void BorrarObraPorIsbn(object sender, EventArgs e)
        {
            ObraCEN obra = new ObraCEN();
            ObraEN obraEN = obra.BuscaPorId(busquedaInput.Text);
            if (obraEN != null)
            {
                /*
                 * Borrar en cascada bloque autores
                 */
                AutorEN autorEn = new AutorEN();
                AutorCEN autorCEn = new AutorCEN();
                System.Collections.Generic.IList<String> autores = null;
                System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> autoresDefinitivos;
                
                autores = new List<String>();

                autoresDefinitivos = new List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();

                for (int i = 0; i < obraEN.Escrita.Count; i++)
                {
                    autores.Add(obraEN.Escrita[i].Nombre);
                }
                    
                autoresDefinitivos = autorCEn.BuscarAutor(autores);
                for (int i = 0; i < obraEN.Escrita.Count; i++)
                {
                    for (int j = 0; j < autoresDefinitivos[i].Escribe.Count; j++)
                    {
                        if (autoresDefinitivos[i].Escribe[j].Nombre == obraEN.Nombre)
                        {
                            autoresDefinitivos[i].Escribe.RemoveAt(j);
                            j--;
                        }
                    }
                    AutorCAD autorCad = new AutorCAD();
                    autorCad.Modify(autoresDefinitivos[i]);
                    
                }

                /*
                 * Borrar en cascada bloque Tematica
                 */
                TematicaEN tematicaEn = new TematicaEN();
                TematicaCEN tematicaCEn = new TematicaCEN();
                System.Collections.Generic.IList<String> tematica = null;
                System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> tematicaDefinitivos;

                tematica = new List<String>();

                tematicaDefinitivos = new List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();

                for (int i = 0; i < obraEN.Tematica.Count; i++)
                {
                    tematica.Add(obraEN.Tematica[i].Nombre);
                }

                tematicaDefinitivos = tematicaCEn.BuscarTematica(tematica);
                for (int i = 0; i < obraEN.Tematica.Count; i++)
                {
                    for (int j = 0; j < tematicaDefinitivos[i].Obra.Count; j++)
                    {
                        
                        if (tematicaDefinitivos[i].Obra[j].Nombre == obraEN.Nombre)
                        {
                            tematicaDefinitivos[i].Obra.RemoveAt(j);
                            j--;
                            
                        }
                    }
                    TematicaCAD tematicaCad = new TematicaCAD();
                    tematicaCad.Modify(tematicaDefinitivos[i]);

                }

                //borrar definitivo
                obra.Destroy(busquedaInput.Text);
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
                        
                    }

                    //TITULO
                    Label lNom = new Label();
                    lNom.Text = "Título:";
                    PanelPASModDown.Controls.Add(lNom);
                    PanelPASModDown.Controls.Add(new LiteralControl("&nbsp"));
                    Label lNombre = new Label();
                    lNombre.Text = obraEn.Nombre;
                    PanelPASModDown.Controls.Add(lNombre);
                    
                    PanelPASModDown.Controls.Add(new LiteralControl("<br>"));


                    //PAGINAS
                    Label lPag = new Label();
                    lPag.Text = "Nº Páginas:";
                    PanelPASModDown.Controls.Add(lPag);
                    PanelPASModDown.Controls.Add(new LiteralControl("&nbsp"));
                    Label lPaginas = new Label();
                    lPaginas.Text = obraEn.Paginas.ToString();
                    PanelPASModDown.Controls.Add(lPaginas);
                    
                    PanelPASModDown.Controls.Add(new LiteralControl("<br>"));


                    //ANYO
                    Label lany = new Label();
                    lany.Text = "Año:";
                    PanelPASModDown.Controls.Add(lany);
                    PanelPASModDown.Controls.Add(new LiteralControl("&nbsp"));
                    Label lAnyo = new Label();
                    lAnyo.Text = obraEn.Anyo.ToString();
                    PanelPASModDown.Controls.Add(lAnyo);
                   
                    PanelPASModDown.Controls.Add(new LiteralControl("<br>"));




                    //AUTOR
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
    }
}