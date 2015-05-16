
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
public partial class TematicaCAD : BasicCAD, ITematicaCAD
{
public TematicaCAD() : base ()
{
}

public TematicaCAD(ISession sessionAux) : base (sessionAux)
{
}



public TematicaEN ReadOIDDefault (string nombre)
{
        TematicaEN tematicaEN = null;

        try
        {
                SessionInitializeTransaction ();
                tematicaEN = (TematicaEN)session.Get (typeof(TematicaEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in TematicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tematicaEN;
}


public string New_ (TematicaEN tematica)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (tematica);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in TematicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return tematica.Nombre;
}

public void Modify (TematicaEN tematica)
{
        try
        {
                SessionInitializeTransaction ();
                TematicaEN tematicaEN = (TematicaEN)session.Load (typeof(TematicaEN), tematica.Nombre);
                session.Update (tematicaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in TematicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string nombre)
{
        try
        {
                SessionInitializeTransaction ();
                TematicaEN tematicaEN = (TematicaEN)session.Load (typeof(TematicaEN), nombre);
                session.Delete (tematicaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in TematicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> BuscarTematica (System.Collections.Generic.IList<string> tematica)
{
        System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM TematicaEN self where FROM TematicaEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("TematicaENbuscarTematicaHQL");
                query.SetParameter ("tematica", tematica);

                result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in TematicaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
