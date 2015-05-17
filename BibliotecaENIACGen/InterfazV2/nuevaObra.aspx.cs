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
    public partial class nuevaObra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = 0;
           
            
            /*bloque para añadir al desplegable de autores todos los autores*/

            if (ListBox1.Items.Count == 0)
            {
                System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> autores;
                AutorCAD aut = new AutorCAD();
                autores = aut.BuscarAutor();
                for (i = 0; i < autores.Count; i++)
                {
                    ListItem l = new ListItem(autores[i].Nombre);

                    ListBox1.Items.Add(l);

                }
            }

            /*bloque para añadir al desplegable de autores todos las tematica*/

            if (tematica.Items.Count == 0)
            {
                System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> temas;
                TematicaCAD theme = new TematicaCAD();
                temas = theme.BuscarTemas();
                for (i = 0; i < temas.Count; i++)
                {
                    ListItem l = new ListItem(temas[i].Nombre);

                    tematica.Items.Add(l);

                }
            }
            
        }
        protected void asignarPrestamo(object sender, EventArgs e)
        {
            Response.Redirect("asignarPrestamo.aspx");
        }
        protected void verDesideratas(object sender, EventArgs e)
        {

        }
        protected void newObra(object sender, EventArgs e)
        {
            Response.Redirect("nuevaObra.aspx");


        }
        protected void modificarObra(object sender, EventArgs e)
        {
            Response.Redirect("modificarObra.aspx");
        }
        protected void borrarObra(object sender, EventArgs e)
        {
            Response.Redirect("borrarObra.aspx");
        }
      

        protected void confirmarObra(object sender, EventArgs e)
        {
            string id = isbnInput.Text;
            string titulo = titolInput.Text;
            short pag = Convert.ToInt16(paginasInput.Text);
            short year = Convert.ToInt16(anyoInput.Text);
            string urlImg = imgInput.Text;
            ObraCEN obra = new ObraCEN();
            EjemplarCEN ejemplar = new EjemplarCEN();
            PASCEN pas = new PASCEN();
            System.Collections.Generic.IList<String> autores = null;
            autores = new List<String>();
            ObraEN obraEn = new ObraEN();

           obraEn = obra.BuscaPorId(id);
           

            foreach (ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    //AutorEN autor = new AutorEN();
                    //autor.Nombre = li.Text;
                    autores.Add(li.Text);
                }
            }

            System.Collections.Generic.IList<String> temas = null;
            temas = new List<String>();
            foreach (ListItem li in tematica.Items)
            {
                if (li.Selected)
                {
                    //TematicaEN theme = new TematicaEN();
                    
                    temas.Add(li.Text);
                }
            }

            if (obraEn == null)
            {
                obra.New_(id, titulo, pag, autores, temas, year, urlImg);
                ejemplar.New_(false, false, id);
            }
            else
            {
                ejemplar.New_(false, false, id);
            }
            //obra.DarDeAltaObra(id,titulo,pag,year,urlImg,"");

            

        }
    }
}