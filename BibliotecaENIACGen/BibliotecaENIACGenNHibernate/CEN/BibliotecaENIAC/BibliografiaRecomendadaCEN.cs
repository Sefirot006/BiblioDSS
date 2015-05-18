

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
public partial class BibliografiaRecomendadaCEN
{
private IBibliografiaRecomendadaCAD _IBibliografiaRecomendadaCAD;

public BibliografiaRecomendadaCEN()
{
        this._IBibliografiaRecomendadaCAD = new BibliografiaRecomendadaCAD ();
}

public BibliografiaRecomendadaCEN(IBibliografiaRecomendadaCAD _IBibliografiaRecomendadaCAD)
{
        this._IBibliografiaRecomendadaCAD = _IBibliografiaRecomendadaCAD;
}

public IBibliografiaRecomendadaCAD get_IBibliografiaRecomendadaCAD ()
{
        return this._IBibliografiaRecomendadaCAD;
}

public int New_ ()
{
        BibliografiaRecomendadaEN bibliografiaRecomendadaEN = null;
        int oid;

        //Initialized BibliografiaRecomendadaEN
        bibliografiaRecomendadaEN = new BibliografiaRecomendadaEN ();
        //Call to BibliografiaRecomendadaCAD

        oid = _IBibliografiaRecomendadaCAD.New_ (bibliografiaRecomendadaEN);
        return oid;
}

public void Modify (int p_BibliografiaRecomendada_OID)
{
        BibliografiaRecomendadaEN bibliografiaRecomendadaEN = null;

        //Initialized BibliografiaRecomendadaEN
        bibliografiaRecomendadaEN = new BibliografiaRecomendadaEN ();
        bibliografiaRecomendadaEN.IdSocioObras = p_BibliografiaRecomendada_OID;
        //Call to BibliografiaRecomendadaCAD

        _IBibliografiaRecomendadaCAD.Modify (bibliografiaRecomendadaEN);
}

public void Destroy (int idSocioObras)
{
        _IBibliografiaRecomendadaCAD.Destroy (idSocioObras);
}
}
}
