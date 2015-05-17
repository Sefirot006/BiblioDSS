
using System;
using System.Text;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.Exceptions;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial class BibliografiaRecomendadaCAD : BasicCAD, IBibliografiaRecomendadaCAD
{
public BibliografiaRecomendadaCAD() : base ()
{
}

public BibliografiaRecomendadaCAD(ISession sessionAux) : base (sessionAux)
{
}



public BibliografiaRecomendadaEN ReadOIDDefault (int idSocioObras)
{
        BibliografiaRecomendadaEN bibliografiaRecomendadaEN = null;

        try
        {
                SessionInitializeTransaction ();
                bibliografiaRecomendadaEN = (BibliografiaRecomendadaEN)session.Get (typeof(BibliografiaRecomendadaEN), idSocioObras);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in BibliografiaRecomendadaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return bibliografiaRecomendadaEN;
}


public int New_ (BibliografiaRecomendadaEN bibliografiaRecomendada)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (bibliografiaRecomendada);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in BibliografiaRecomendadaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return bibliografiaRecomendada.IdSocioObras;
}

public void Modify (BibliografiaRecomendadaEN bibliografiaRecomendada)
{
        try
        {
                SessionInitializeTransaction ();
                BibliografiaRecomendadaEN bibliografiaRecomendadaEN = (BibliografiaRecomendadaEN)session.Load (typeof(BibliografiaRecomendadaEN), bibliografiaRecomendada.IdSocioObras);
                session.Update (bibliografiaRecomendadaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in BibliografiaRecomendadaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int idSocioObras)
{
        try
        {
                SessionInitializeTransaction ();
                BibliografiaRecomendadaEN bibliografiaRecomendadaEN = (BibliografiaRecomendadaEN)session.Load (typeof(BibliografiaRecomendadaEN), idSocioObras);
                session.Delete (bibliografiaRecomendadaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in BibliografiaRecomendadaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
