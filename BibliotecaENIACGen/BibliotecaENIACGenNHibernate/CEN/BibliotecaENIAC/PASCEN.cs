

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
public partial class PASCEN
{
private IPASCAD _IPASCAD;

public PASCEN()
{
        this._IPASCAD = new PASCAD ();
}

public PASCEN(IPASCAD _IPASCAD)
{
        this._IPASCAD = _IPASCAD;
}

public IPASCAD get_IPASCAD ()
{
        return this._IPASCAD;
}

public System.Collections.Generic.IList<PASEN> ListarPAS (int first, int size)
{
        System.Collections.Generic.IList<PASEN> list = null;

        list = _IPASCAD.ListarPAS (first, size);
        return list;
}
public string New_ (string p_DNI, string p_nombre, string p_apellidos, int p_telefono, string p_correo, int p_penalizacion, string p_contrasenya, bool p_logeado)
{
        PASEN pASEN = null;
        string oid;

        //Initialized PASEN
        pASEN = new PASEN ();
        pASEN.DNI = p_DNI;

        pASEN.Nombre = p_nombre;

        pASEN.Apellidos = p_apellidos;

        pASEN.Telefono = p_telefono;

        pASEN.Correo = p_correo;

        pASEN.Penalizacion = p_penalizacion;

        pASEN.Contrasenya = p_contrasenya;

        pASEN.Logeado = p_logeado;

        //Call to PASCAD

        oid = _IPASCAD.New_ (pASEN);
        return oid;
}
}
}
