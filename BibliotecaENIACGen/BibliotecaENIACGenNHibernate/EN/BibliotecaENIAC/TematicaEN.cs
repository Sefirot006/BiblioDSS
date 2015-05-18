
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class TematicaEN
{
/**
 *
 */

private string nombre;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> rec;





public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> Obra {
        get { return obra; } set { obra = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> Rec {
        get { return rec; } set { rec = value;  }
}





public TematicaEN()
{
        obra = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
        rec = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN>();
}



public TematicaEN(string nombre, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> rec)
{
        this.init (nombre, obra, rec);
}


public TematicaEN(TematicaEN tematica)
{
        this.init (tematica.Nombre, tematica.Obra, tematica.Rec);
}

private void init (string nombre, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> obra, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> rec)
{
        this.Nombre = nombre;


        this.Obra = obra;

        this.Rec = rec;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TematicaEN t = obj as TematicaEN;
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
