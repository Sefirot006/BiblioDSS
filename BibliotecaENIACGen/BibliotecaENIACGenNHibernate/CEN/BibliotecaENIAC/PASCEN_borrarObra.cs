
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC
{
public partial class PASCEN
{
public void BorrarObra (string p_oid)
{
        ObraCEN obra = new ObraCEN();
            ObraEN obraEN = obra.BuscaPorId(p_oid);
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
                obra.Destroy(p_oid);
            }
}
}
}
