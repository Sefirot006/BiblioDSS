

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC
{
public partial class ObraCEN
{
private IObraCAD _IObraCAD;

public ObraCEN()
{
        this._IObraCAD = new ObraCAD ();
}

public ObraCEN(IObraCAD _IObraCAD)
{
        this._IObraCAD = _IObraCAD;
}

public IObraCAD get_IObraCAD ()
{
        return this._IObraCAD;
}

public string New_ (string p_Isbn, string p_nombre, short p_paginas, System.Collections.Generic.IList<string> p_escrita, System.Collections.Generic.IList<string> p_tematica, short p_anyo, string p_imagen)
{
        ObraEN obraEN = null;
        string oid;

        //Initialized ObraEN
        obraEN = new ObraEN ();
        obraEN.Isbn = p_Isbn;

        obraEN.Nombre = p_nombre;

        obraEN.Paginas = p_paginas;


        obraEN.Escrita = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();
        if (p_escrita != null) {
                foreach (string item in p_escrita) {
                        BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN en = new BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN ();
                        en.Nombre = item;
                        obraEN.Escrita.Add (en);
                }
        }

        else{
                obraEN.Escrita = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();
        }


        obraEN.Tematica = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();
        if (p_tematica != null) {
                foreach (string item in p_tematica) {
                        BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN en = new BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN ();
                        en.Nombre = item;
                        obraEN.Tematica.Add (en);
                }
        }

        else{
                obraEN.Tematica = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();
        }

        obraEN.Anyo = p_anyo;

        obraEN.Imagen = p_imagen;

        //Call to ObraCAD

        oid = _IObraCAD.New_ (obraEN);
        return oid;
}

public void Modify(string p_Isbn, string p_nombre, short p_paginas, short p_anyo, string p_imagen)
{
    ObraEN obraEN = null;
    int i = 0;
    //Initialized ObraEN
    obraEN = new ObraEN();
    obraEN.Isbn = p_Isbn;
    obraEN.Nombre = p_nombre;
    obraEN.Paginas = p_paginas;
    obraEN.Anyo = p_anyo;
    obraEN.Imagen = p_imagen;


    //Call to ObraCAD

    _IObraCAD.Modify(obraEN);
}

public void Destroy (string Isbn)
{
        _IObraCAD.Destroy (Isbn);
}

public System.Collections.Generic.IList<ObraEN> ListarObras(int first, int size)
{
    System.Collections.Generic.IList<ObraEN> list = null;

    list = _IObraCAD.ListarObras(first, size);
    return list;
}
public ObraEN BuscaPorId(string Isbn)
{
    ObraEN obraEN = null;

    obraEN = _IObraCAD.BuscaPorId(Isbn);

    return obraEN;
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorNombre(string nombre)
{
    return _IObraCAD.BuscaPorNombre(nombre);
}
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorAutor(string autor)
{
    return _IObraCAD.BuscaPorAutor(autor);
}
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorTematica(string tema)
{
    return _IObraCAD.BuscaPorTematica(tema);
}
}
}
