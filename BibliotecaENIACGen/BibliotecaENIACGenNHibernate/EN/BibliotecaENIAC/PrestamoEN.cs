
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class PrestamoEN
{
/**
 *
 */

private string idPrestamo;

/**
 *
 */

private Nullable<DateTime> fechaVencimiento;

/**
 *
 */

private Nullable<DateTime> fechaInicio;

/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario;

/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN ejemplar;





public virtual string IdPrestamo {
        get { return idPrestamo; } set { idPrestamo = value;  }
}


public virtual Nullable<DateTime> FechaVencimiento {
        get { return fechaVencimiento; } set { fechaVencimiento = value;  }
}


public virtual Nullable<DateTime> FechaInicio {
        get { return fechaInicio; } set { fechaInicio = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN Ejemplar {
        get { return ejemplar; } set { ejemplar = value;  }
}





public PrestamoEN()
{
}



public PrestamoEN(string idPrestamo, Nullable<DateTime> fechaVencimiento, Nullable<DateTime> fechaInicio, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN ejemplar)
{
        this.init (idPrestamo, fechaVencimiento, fechaInicio, usuario, ejemplar);
}


public PrestamoEN(PrestamoEN prestamo)
{
        this.init (prestamo.IdPrestamo, prestamo.FechaVencimiento, prestamo.FechaInicio, prestamo.Usuario, prestamo.Ejemplar);
}

private void init (string idPrestamo, Nullable<DateTime> fechaVencimiento, Nullable<DateTime> fechaInicio, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN usuario, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN ejemplar)
{
        this.IdPrestamo = idPrestamo;


        this.FechaVencimiento = fechaVencimiento;

        this.FechaInicio = fechaInicio;

        this.Usuario = usuario;

        this.Ejemplar = ejemplar;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PrestamoEN t = obj as PrestamoEN;
        if (t == null)
                return false;
        if (IdPrestamo.Equals (t.IdPrestamo))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdPrestamo.GetHashCode ();
        return hash;
}
}
}
