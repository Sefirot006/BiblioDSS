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
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ObraCEN obra = new ObraCEN();
            
            /*obra.New_("UML Distilled: A Brief Guide to the Standard Object Modeling Language", 2, "Martin Fowler", "Software", 345, false, false);
            obra.New_("Refactoring: Improving the Design of Existing Code", 3, "Martin Fowler", "Software", 297, true, false);
            obra.New_("Planning Extreme Programming", 4, "Martin Fowler", "Software", 365, false, false);
            obra.New_("Domain-Specific Languages", 1, "Martin Fowler", "Software", 286, true, false);
            obra.New_("NoSQL Distilled", 1, "Martin Fowler", "Software", 381, false, false);
            obra.New_("Agile and iterative development: a manager`s guide", 1, "Craig Larman", "Software", 369, true, false);
            obra.New_("Applying UML and patterns: an introduction to object-oriented analysis and design and iterative development", 4, "Craig Larman", "Software", 279, false, false);
            */
        }
        public void mostrarObrasA_click(object sender, EventArgs e)
        {
           
            ObraCEN obra =  new ObraCEN();
            
            int i = 0;
            int ejemplaresDisp = 0;
            string busqueda = textBox.Text;
            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> listFiltradaPorAutor = null;
            listFiltradaPorAutor = obra.BuscaPorAutor(busqueda);

            if (busqueda.Length < 3)
            {
                Panel2.Controls.Add(new LiteralControl("<br><center><b> Por favor, introduzca algún dato significativo para poder realizar la búsqueda. </center><br><br>"));
                return;
            }


            if (listFiltradaPorAutor != null)
            {
                if (listFiltradaPorAutor.Count == 0)
                {
                    Panel2.Controls.Add(new LiteralControl("<br><center><b> Lo sentimos, no se ha encontrado ningún resultado. </center><br><br>"));
                    return;
                }

                //Panel2.Controls.Add(new LiteralControl("<br><br><br><br><br><br><br><br><br><br>"));
                Panel2.Controls.Add(new LiteralControl("<br><center><b><u> Resultado de la búsqueda: </u></center><br><br>"));

               
                
                foreach (ObraEN obras in listFiltradaPorAutor)
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
                        Panel2.Controls.Add(img);
                        Panel2.Controls.Add(new LiteralControl("<br>"));
                    }

                    //TITULO
                    Label lNom = new Label();
                    lNom.Text = "Título:";
                    Panel2.Controls.Add(lNom);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lNombre = new Label();
                    lNombre.Text = obras.Nombre;
                    Panel2.Controls.Add(lNombre);

                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //AUTOR
                    Label lAut = new Label();
                    lAut.Text = "Autor:";
                    Panel2.Controls.Add(lAut);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lAutor = new Label();
                    if (obras.Escrita != null)
                    {
                        for (i = 0; i < obras.Escrita.Count; i++)
                        {
                            if (i != obras.Escrita.Count -1)
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
                  
                    Panel2.Controls.Add(lAutor);

                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //TEMATICA
                    i = 0;
                    Label lTem = new Label();
                    lTem.Text = "Temática:";
                    Panel2.Controls.Add(lTem);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lTematica = new Label();
                    if (obras.Tematica != null)
                    {

                        for (i = 0; i < obras.Tematica.Count; i++)
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
                        lTematica.Text ="Sin tematica" ;
                    }
                   
                    Panel2.Controls.Add(lTematica);
                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //DISPONIBILIDAD
                    Label lDis = new Label();
                    lDis.Text = "Disposición:";
                    Panel2.Controls.Add(lDis);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lDisponibilidad = new Label();
                    for (i = 0; i < obras.Ejemplar.Count; i++)
                    {
                        if (obras.Ejemplar[i].Prestado != true)
                        {
                            ejemplaresDisp++;
                        }
                    }
                    if (ejemplaresDisp == 0)
                    {
                        lDisponibilidad.Text = "No disponible";
                        Panel2.Controls.Add(lDisponibilidad);
                    }
                    else
                    {
                        lDisponibilidad.Text = "Disponibles " + ejemplaresDisp + "/" + obras.Ejemplar.Count;
                        Panel2.Controls.Add(lDisponibilidad);
                    }
                    Panel2.Controls.Add(new LiteralControl("<br>"));
                    Panel2.Controls.Add(new LiteralControl("<br>"));
                    ejemplaresDisp = 0;
                }
                
            }
        }

        public void mostrarObrasN_click(object sender, EventArgs e)
        {

            ObraCEN obra = new ObraCEN();

            int i = 0;
            int ejemplaresDisp = 0;
            string busqueda = textBox.Text;
            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> listFiltradaPorAutor = null;
            listFiltradaPorAutor = obra.BuscaPorNombre(busqueda);

            if (busqueda.Length < 3)
            {
                Panel2.Controls.Add(new LiteralControl("<br><center><b> Por favor, introduzca algún dato significativo para poder realizar la búsqueda. </center><br><br>"));
                return;
            }


            if (listFiltradaPorAutor != null)
            {
                if (listFiltradaPorAutor.Count == 0)
                {
                    Panel2.Controls.Add(new LiteralControl("<br><center><b> Lo sentimos, no se ha encontrado ningún resultado. </center><br><br>"));
                    return;
                }

                //Panel2.Controls.Add(new LiteralControl("<br><br><br><br><br><br><br><br><br><br>"));
                Panel2.Controls.Add(new LiteralControl("<br><center><b><u> Resultado de la búsqueda: </u></center><br><br>"));



                foreach (ObraEN obras in listFiltradaPorAutor)
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
                        Panel2.Controls.Add(img);
                        Panel2.Controls.Add(new LiteralControl("<br>"));
                    }

                    //TITULO
                    Label lNom = new Label();
                    lNom.Text = "Título:";
                    Panel2.Controls.Add(lNom);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lNombre = new Label();
                    lNombre.Text = obras.Nombre;
                    Panel2.Controls.Add(lNombre);

                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //AUTOR
                    Label lAut = new Label();
                    lAut.Text = "Autor:";
                    Panel2.Controls.Add(lAut);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lAutor = new Label();
                    if (obras.Escrita != null)
                    {
                        for (i = 0; i < obras.Escrita.Count; i++)
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

                    Panel2.Controls.Add(lAutor);

                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //TEMATICA
                    i = 0;
                    Label lTem = new Label();
                    lTem.Text = "Temática:";
                    Panel2.Controls.Add(lTem);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lTematica = new Label();
                    if (obras.Tematica != null)
                    {

                        for (i = 0; i < obras.Tematica.Count; i++)
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

                    Panel2.Controls.Add(lTematica);
                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //DISPONIBILIDAD
                    Label lDis = new Label();
                    lDis.Text = "Disposición:";
                    Panel2.Controls.Add(lDis);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lDisponibilidad = new Label();
                    for (i = 0; i < obras.Ejemplar.Count; i++)
                    {
                        if (obras.Ejemplar[i].Prestado != true)
                        {
                            ejemplaresDisp++;
                        }
                    }
                    if (ejemplaresDisp == 0)
                    {
                        lDisponibilidad.Text = "No disponible";
                        Panel2.Controls.Add(lDisponibilidad);
                    }
                    else
                    {
                        lDisponibilidad.Text = "Disponibles " + ejemplaresDisp + "/" + obras.Ejemplar.Count;
                        Panel2.Controls.Add(lDisponibilidad);
                    }
                    Panel2.Controls.Add(new LiteralControl("<br>"));
                    Panel2.Controls.Add(new LiteralControl("<br>"));
                    ejemplaresDisp = 0;
                }

            } 
                
            
        }

        public void mostrarObrasT_click(object sender, EventArgs e)
        {
             ObraCEN obra =  new ObraCEN();
            
            int i = 0;
            int ejemplaresDisp = 0;
            string busqueda = textBox.Text;
            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> listFiltradaPorAutor = null;
            listFiltradaPorAutor = obra.BuscaPorTematica(busqueda);

            if (busqueda.Length < 3)
            {
                Panel2.Controls.Add(new LiteralControl("<br><center><b> Por favor, introduzca algún dato significativo para poder realizar la búsqueda. </center><br><br>"));
                return;
            }


            if (listFiltradaPorAutor != null)
            {
                if (listFiltradaPorAutor.Count == 0)
                {
                    Panel2.Controls.Add(new LiteralControl("<br><center><b> Lo sentimos, no se ha encontrado ningún resultado. </center><br><br>"));
                    return;
                }

                //Panel2.Controls.Add(new LiteralControl("<br><br><br><br><br><br><br><br><br><br>"));
                Panel2.Controls.Add(new LiteralControl("<br><center><b><u> Resultado de la búsqueda: </u></center><br><br>"));

               
                
                foreach (ObraEN obras in listFiltradaPorAutor)
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
                        Panel2.Controls.Add(img);
                        Panel2.Controls.Add(new LiteralControl("<br>"));
                    }

                    //TITULO
                    Label lNom = new Label();
                    lNom.Text = "Título:";
                    Panel2.Controls.Add(lNom);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lNombre = new Label();
                    lNombre.Text = obras.Nombre;
                    Panel2.Controls.Add(lNombre);

                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //AUTOR
                    Label lAut = new Label();
                    lAut.Text = "Autor:";
                    Panel2.Controls.Add(lAut);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lAutor = new Label();
                    if (obras.Escrita != null)
                    {
                        for (i = 0; i < obras.Escrita.Count; i++)
                        {
                            if (i != obras.Escrita.Count -1)
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
                  
                    Panel2.Controls.Add(lAutor);

                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //TEMATICA
                    i = 0;
                    Label lTem = new Label();
                    lTem.Text = "Temática:";
                    Panel2.Controls.Add(lTem);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lTematica = new Label();
                    if (obras.Tematica != null)
                    {

                        for (i = 0; i < obras.Tematica.Count; i++)
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
                        lTematica.Text ="Sin tematica" ;
                    }
                   
                    Panel2.Controls.Add(lTematica);
                    Panel2.Controls.Add(new LiteralControl("<br>"));

                    //DISPONIBILIDAD
                    Label lDis = new Label();
                    lDis.Text = "Disposición:";
                    Panel2.Controls.Add(lDis);
                    Panel2.Controls.Add(new LiteralControl("&nbsp"));
                    Label lDisponibilidad = new Label();
                    for (i = 0; i < obras.Ejemplar.Count; i++)
                    {
                        if (obras.Ejemplar[i].Prestado != true)
                        {
                            ejemplaresDisp++;
                        }
                    }
                    if (ejemplaresDisp == 0)
                    {
                        lDisponibilidad.Text = "No disponible";
                        Panel2.Controls.Add(lDisponibilidad);
                    }
                    else
                    {
                        lDisponibilidad.Text = "Disponibles " + ejemplaresDisp + "/" + obras.Ejemplar.Count;
                        Panel2.Controls.Add(lDisponibilidad);
                    }
                    Panel2.Controls.Add(new LiteralControl("<br>"));
                    Panel2.Controls.Add(new LiteralControl("<br>"));
                    ejemplaresDisp = 0;
                }
                
            }

            
                
            
        }
    }
}
