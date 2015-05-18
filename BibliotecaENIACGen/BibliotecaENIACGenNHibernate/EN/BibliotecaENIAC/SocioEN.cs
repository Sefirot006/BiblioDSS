
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class SocioEN                    :                           BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN


{
public SocioEN() : base ()
{
}



public SocioEN(string dNI, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado)
{
        this.init (dNI, nombre, apellidos, telefono, correo, penalizacion, recomienda, reservar, prestamo, contrasenya, logeado);
}


public SocioEN(SocioEN socio)
{
        this.init (socio.DNI, socio.Nombre, socio.Apellidos, socio.Telefono, socio.Correo, socio.Penalizacion, socio.Recomienda, socio.Reservar, socio.Prestamo, socio.Contrasenya, socio.Logeado);
}

private void init (string dNI, string nombre, string apellidos, long telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reservar, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado)
{
        this.DNI = DNI;


        this.Nombre = nombre;

        this.Apellidos = apellidos;

        this.Telefono = telefono;

        this.Correo = correo;

        this.Penalizacion = penalizacion;

        this.Recomienda = recomienda;

        this.Reservar = reservar;

        this.Prestamo = prestamo;

        this.Contrasenya = contrasenya;

        this.Logeado = logeado;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SocioEN t = obj as SocioEN;
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
