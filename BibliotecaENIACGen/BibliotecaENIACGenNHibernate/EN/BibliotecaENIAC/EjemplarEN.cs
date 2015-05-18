
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class EjemplarEN
{
/**
 *
 */

private int id;

/**
 *
 */

private bool prestado;

/**
 *
 */

private bool reservado;

/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN obra;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo;





public virtual int Id {
        get { return id; } set { id = value;  }
}


public virtual bool Prestado {
        get { return prestado; } set { prestado = value;  }
}


public virtual bool Reservado {
        get { return reservado; } set { reservado = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN Obra {
        get { return obra; } set { obra = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> Prestamo {
        get { return prestamo; } set { prestamo = value;  }
}





public EjemplarEN()
{
        prestamo = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN>();
}



public EjemplarEN(int id, bool prestado, bool reservado, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN obra, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.init (id, prestado, reservado, obra, prestamo);
}


public EjemplarEN(EjemplarEN ejemplar)
{
        this.init (ejemplar.Id, ejemplar.Prestado, ejemplar.Reservado, ejemplar.Obra, ejemplar.Prestamo);
}

private void init (int id, bool prestado, bool reservado, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN obra, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo)
{
        this.Id = id;


        this.Prestado = prestado;

        this.Reservado = reservado;

        this.Obra = obra;

        this.Prestamo = prestamo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EjemplarEN t = obj as EjemplarEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
