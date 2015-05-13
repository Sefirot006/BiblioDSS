
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class UsuarioEN
{
/**
 *
 */

private string dNI;

/**
 *
 */

private string nombre;

/**
 *
 */

private string apellidos;

/**
 *
 */

private int telefono;

/**
 *
 */

private string correo;

/**
 *
 */

private int penalizacion;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo;

/**
 *
 */

private string contrasenya;

/**
 *
 */

private bool logeado;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> desiderata;





public virtual string DNI {
        get { return dNI; } set { dNI = value;  }
}


public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}


public virtual string Apellidos {
        get { return apellidos; } set { apellidos = value;  }
}


public virtual int Telefono {
        get { return telefono; } set { telefono = value;  }
}


public virtual string Correo {
        get { return correo; } set { correo = value;  }
}


public virtual int Penalizacion {
        get { return penalizacion; } set { penalizacion = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> Recomienda {
        get { return recomienda; } set { recomienda = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> Reserva {
        get { return reserva; } set { reserva = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> Prestamo {
        get { return prestamo; } set { prestamo = value;  }
}


public virtual string Contrasenya {
        get { return contrasenya; } set { contrasenya = value;  }
}


public virtual bool Logeado {
        get { return logeado; } set { logeado = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> Desiderata {
        get { return desiderata; } set { desiderata = value;  }
}





public UsuarioEN()
{
        recomienda = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN>();
        reserva = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN>();
        prestamo = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN>();
        desiderata = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN>();
}



public UsuarioEN(string dNI, string nombre, string apellidos, int telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> desiderata)
{
        this.init (dNI, nombre, apellidos, telefono, correo, penalizacion, recomienda, reserva, prestamo, contrasenya, logeado, desiderata);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (usuario.DNI, usuario.Nombre, usuario.Apellidos, usuario.Telefono, usuario.Correo, usuario.Penalizacion, usuario.Recomienda, usuario.Reserva, usuario.Prestamo, usuario.Contrasenya, usuario.Logeado, usuario.Desiderata);
}

private void init (string dNI, string nombre, string apellidos, int telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> desiderata)
{
        this.DNI = DNI;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Telefono = telefono;

        this.Correo = correo;

        this.Penalizacion = penalizacion;

        this.Recomienda = recomienda;

        this.Reserva = reserva;

        this.Prestamo = prestamo;

        this.Contrasenya = contrasenya;

        this.Logeado = logeado;

        this.Desiderata = desiderata;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (DNI.Equals (t.DNI))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.DNI.GetHashCode ();
        return hash;
}
}
}
