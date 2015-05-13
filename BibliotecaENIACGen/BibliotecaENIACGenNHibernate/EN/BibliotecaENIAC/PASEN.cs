
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class PASEN              :                           BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN


{
/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DirectorEN director;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> acepta;





public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DirectorEN Director {
        get { return director; } set { director = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> Acepta {
        get { return acepta; } set { acepta = value;  }
}





public PASEN() : base ()
{
        acepta = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN>();
}



public PASEN(string dNI, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DirectorEN director, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> acepta, string nombre, string apellidos, int telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> desiderata)
{
        this.init (dNI, director, acepta, nombre, apellidos, telefono, correo, penalizacion, recomienda, reserva, prestamo, contrasenya, logeado, desiderata);
}


public PASEN(PASEN pAS)
{
        this.init (pAS.DNI, pAS.Director, pAS.Acepta, pAS.Nombre, pAS.Apellidos, pAS.Telefono, pAS.Correo, pAS.Penalizacion, pAS.Recomienda, pAS.Reserva, pAS.Prestamo, pAS.Contrasenya, pAS.Logeado, pAS.Desiderata);
}

private void init (string dNI, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DirectorEN director, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> acepta, string nombre, string apellidos, int telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> desiderata)
{
        this.DNI = DNI;


        this.Director = director;

        this.Acepta = acepta;

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
        PASEN t = obj as PASEN;
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
