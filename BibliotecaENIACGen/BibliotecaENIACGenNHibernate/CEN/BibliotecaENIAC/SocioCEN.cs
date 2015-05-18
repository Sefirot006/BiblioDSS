

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
public partial class SocioCEN
{
private ISocioCAD _ISocioCAD;

public SocioCEN()
{
        this._ISocioCAD = new SocioCAD ();
}

public SocioCEN(ISocioCAD _ISocioCAD)
{
        this._ISocioCAD = _ISocioCAD;
}

public ISocioCAD get_ISocioCAD ()
{
        return this._ISocioCAD;
}

public System.Collections.Generic.IList<SocioEN> Listasocios (int first, int size)
{
        System.Collections.Generic.IList<SocioEN> list = null;

        list = _ISocioCAD.Listasocios (first, size);
        return list;
}
public string New_ (string p_DNI, string p_nombre, string p_apellidos, long p_telefono, string p_correo, int p_penalizacion, string p_contrasenya, bool p_logeado)
{
        SocioEN socioEN = null;
        string oid;

        //Initialized SocioEN
        socioEN = new SocioEN ();
        socioEN.DNI = p_DNI;

        socioEN.Nombre = p_nombre;

        socioEN.Apellidos = p_apellidos;

        socioEN.Telefono = p_telefono;

        socioEN.Correo = p_correo;

        socioEN.Penalizacion = p_penalizacion;

        socioEN.Contrasenya = p_contrasenya;

        socioEN.Logeado = p_logeado;

        //Call to SocioCAD

        oid = _ISocioCAD.New_ (socioEN);
        return oid;
}
}
}
