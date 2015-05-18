
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class AutorEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> escribe;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> rec;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> Escribe {
        get { return escribe; } set { escribe = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> Rec {
        get { return rec; } set { rec = value;  }
}





public AutorEN()
{
        escribe = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
        rec = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN>();
}



public AutorEN(string nombre, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> escribe, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> rec)
{
        this.init (nombre, escribe, rec);
}


public AutorEN(AutorEN autor)
{
        this.init (autor.Nombre, autor.Escribe, autor.Rec);
}

private void init (string nombre, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> escribe, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> rec)
{
        this.Nombre = nombre;


        this.Escribe = escribe;

        this.Rec = rec;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AutorEN t = obj as AutorEN;
        if (t == null)
                return false;
        if (Nombre.Equals (t.Nombre))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Nombre.GetHashCode ();
        return hash;
}
}
}
