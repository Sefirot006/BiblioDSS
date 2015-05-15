
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class DirectorEN                 :                           BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN


{
/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN> pAS;





public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN> PAS {
        get { return pAS; } set { pAS = value;  }
}





public DirectorEN() : base ()
{
        pAS = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN>();
}



public DirectorEN(string dNI, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN> pAS, string nombre, string apellidos, int telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> desiderata, int tipousuario)
{
        this.init (dNI, pAS, nombre, apellidos, telefono, correo, penalizacion, recomienda, reserva, prestamo, contrasenya, logeado, desiderata, tipousuario);
}


public DirectorEN(DirectorEN director)
{
        this.init (director.DNI, director.PAS, director.Nombre, director.Apellidos, director.Telefono, director.Correo, director.Penalizacion, director.Recomienda, director.Reserva, director.Prestamo, director.Contrasenya, director.Logeado, director.Desiderata, director.Tipousuario);
}

private void init (string dNI, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PASEN> pAS, string nombre, string apellidos, int telefono, string correo, int penalizacion, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.BibliografiaRecomendadaEN> recomienda, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.PrestamoEN> prestamo, string contrasenya, bool logeado, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> desiderata, int tipousuario)
{
        this.DNI = DNI;


        this.PAS = pAS;

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

        this.Tipousuario = tipousuario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DirectorEN t = obj as DirectorEN;
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
