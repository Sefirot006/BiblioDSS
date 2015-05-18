
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class ObraEN
{
/**
 *
 */

private string isbn;

/**
 *
 */

private string nombre;

/**
 *
 */

private short paginas;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> escrita;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> tematica;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN> ejemplar;

/**
 *
 */

private short anyo;

/**
 *
 */

private string imagen;





public virtual string Isbn {
        get { return isbn; } set { isbn = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual short Paginas {
        get { return paginas; } set { paginas = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> Escrita {
        get { return escrita; } set { escrita = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> Tematica {
        get { return tematica; } set { tematica = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN> Ejemplar {
        get { return ejemplar; } set { ejemplar = value;  }
}


public virtual short Anyo {
        get { return anyo; } set { anyo = value;  }
}


public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}





public ObraEN()
{
        reserva = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN>();
        escrita = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();
        tematica = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();
        ejemplar = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN>();
}



public ObraEN(string isbn, string nombre, short paginas, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> escrita, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> tematica, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN> ejemplar, short anyo, string imagen)
{
        this.init (isbn, nombre, paginas, reserva, escrita, tematica, ejemplar, anyo, imagen);
}


public ObraEN(ObraEN obra)
{
        this.init (obra.Isbn, obra.Nombre, obra.Paginas, obra.Reserva, obra.Escrita, obra.Tematica, obra.Ejemplar, obra.Anyo, obra.Imagen);
}

private void init (string isbn, string nombre, short paginas, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> escrita, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> tematica, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN> ejemplar, short anyo, string imagen)
{
        this.Isbn = Isbn;


        this.Nombre = nombre;

        this.Paginas = paginas;

        this.Reserva = reserva;

        this.Escrita = escrita;

        this.Tematica = tematica;

        this.Ejemplar = ejemplar;

        this.Anyo = anyo;

        this.Imagen = imagen;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ObraEN t = obj as ObraEN;
        if (t == null)
                return false;
        if (Isbn.Equals (t.Isbn))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Isbn.GetHashCode ();
        return hash;
}
}
}
