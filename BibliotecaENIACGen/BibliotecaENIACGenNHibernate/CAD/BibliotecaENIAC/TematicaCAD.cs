
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
                tematicaEN.Obra = tematica.Obra;
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
    int i = 0;
    try
    {
        SessionInitializeTransaction();

        String sql = @"FROM TematicaEN ";
        for (i = 0; i < tematica.Count; i++)
        {
            if (i == 0)
            {
                sql += "where nombre ='" + tematica[i] + "'";
            }
            else
            {
                sql += "or nombre ='" + tematica[i] + "'";
            }
        }
        //String sql = @"SELECT * FROM ObraEN";// p WHERE p.autor = autor";
        IQuery query = session.CreateQuery(sql);
        //IQuery oquery = (IQuery)session.GetNamedQuery("ObraENbuscaPorAutorHQL");
        //query.SetParameter("autor", autor);

        result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();
        SessionCommit();
        Console.WriteLine(result);
        for (i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i].Obra.Count);

        }


    }

    catch (Exception ex)
    {
        SessionRollBack();
        if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
            throw ex;
        throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException("Error in ObraCAD.", ex);
    }


    finally
    {
        SessionClose();
    }

    return result;
}
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> BuscarTemas()
{
    int i = 0;
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN> salida = null;
    try
    {
        SessionInitializeTransaction();
        String sql = @"FROM TematicaEN";
        //String sql = @"SELECT * FROM ObraEN";// p WHERE p.autor = autor";
        IQuery query = session.CreateQuery(sql);
        //IQuery oquery = (IQuery)session.GetNamedQuery("ObraENbuscaPorAutorHQL");
        //query.SetParameter("autor", autor);

        salida = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN>();
        for (i = 0; i < salida.Count; i++)
        {
            Console.WriteLine(salida[i]);
        }
        SessionCommit();

    }

    catch (Exception ex)
    {
        SessionRollBack();
        if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
            throw ex;
        throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException("Error in AutorCAD.", ex);
    }


    finally
    {
        SessionClose();
    }

    return salida;
}
}
}
