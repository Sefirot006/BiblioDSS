

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
public partial class TematicaCEN
{
private ITematicaCAD _ITematicaCAD;

public TematicaCEN()
{
        this._ITematicaCAD = new TematicaCAD ();
}

public TematicaCEN(ITematicaCAD _ITematicaCAD)
{
        this._ITematicaCAD = _ITematicaCAD;
}

public ITematicaCAD get_ITematicaCAD ()
{
        return this._ITematicaCAD;
}

public string New_ (string p_nombre)
{
        TematicaEN tematicaEN = null;
        string oid;

        //Initialized TematicaEN
        tematicaEN = new TematicaEN ();
        tematicaEN.Nombre = p_nombre;

        //Call to TematicaCAD

        oid = _ITematicaCAD.New_ (tematicaEN);
        return oid;
}

public void Modify (string p_Tematica_OID)
{
        TematicaEN tematicaEN = null;

        //Initialized TematicaEN
        tematicaEN = new TematicaEN ();
        tematicaEN.Nombre = p_Tematica_OID;
        //Call to TematicaCAD

        _ITematicaCAD.Modify (tematicaEN);
}

public void Destroy (string nombre)
{
        _ITematicaCAD.Destroy (nombre);
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> BuscarTematica (System.Collections.Generic.IList<string> tematica)
{
        return _ITematicaCAD.BuscarTematica (tematica);
}
}
}
