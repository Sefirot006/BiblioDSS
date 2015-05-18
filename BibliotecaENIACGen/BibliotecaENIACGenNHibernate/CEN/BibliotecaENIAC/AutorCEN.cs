

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
public partial class AutorCEN
{
private IAutorCAD _IAutorCAD;

public AutorCEN()
{
        this._IAutorCAD = new AutorCAD ();
}

public AutorCEN(IAutorCAD _IAutorCAD)
{
        this._IAutorCAD = _IAutorCAD;
}

public IAutorCAD get_IAutorCAD ()
{
        return this._IAutorCAD;
}

public string New_ (string p_nombre)
{
        AutorEN autorEN = null;
        string oid;

        //Initialized AutorEN
        autorEN = new AutorEN ();
        autorEN.Nombre = p_nombre;

        //Call to AutorCAD

        oid = _IAutorCAD.New_ (autorEN);
        return oid;
}

public void Modify (string p_Autor_OID)
{
        AutorEN autorEN = null;

        //Initialized AutorEN
        autorEN = new AutorEN ();
        autorEN.Nombre = p_Autor_OID;
        //Call to AutorCAD

        _IAutorCAD.Modify (autorEN);
}

public void Destroy (string nombre)
{
        _IAutorCAD.Destroy (nombre);
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> BuscarAutor (System.Collections.Generic.IList<string> autor)
{
        return _IAutorCAD.BuscarAutor (autor);
}
}
}
