
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
public partial class DesiderataCAD : BasicCAD, IDesiderataCAD
{
public DesiderataCAD() : base ()
{
}

public DesiderataCAD(ISession sessionAux) : base (sessionAux)
{
}



public DesiderataEN ReadOIDDefault (int id)
{
        DesiderataEN desiderataEN = null;

        try
        {
                SessionInitializeTransaction ();
                desiderataEN = (DesiderataEN)session.Get (typeof(DesiderataEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in DesiderataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return desiderataEN;
}


public int New_ (DesiderataEN desiderata)
{
        try
        {
                SessionInitializeTransaction ();
                if (desiderata.Usuario != null) {
                        desiderata.Usuario = (BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN)session.Load (typeof(BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN), desiderata.Usuario.DNI);

                        desiderata.Usuario.Desiderata.Add (desiderata);
                }

                session.Save (desiderata);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in DesiderataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return desiderata.Id;
}

public void Modify (DesiderataEN desiderata)
{
        try
        {
                SessionInitializeTransaction ();
                DesiderataEN desiderataEN = (DesiderataEN)session.Load (typeof(DesiderataEN), desiderata.Id);

                desiderataEN.Autor = desiderata.Autor;


                desiderataEN.Titulo = desiderata.Titulo;


                desiderataEN.Editorial = desiderata.Editorial;


                desiderataEN.Año = desiderata.Año;


                desiderataEN.Aceptada = desiderata.Aceptada;

                session.Update (desiderataEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in DesiderataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id)
{
        try
        {
                SessionInitializeTransaction ();
                DesiderataEN desiderataEN = (DesiderataEN)session.Load (typeof(DesiderataEN), id);
                session.Delete (desiderataEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in DesiderataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<DesiderataEN> ListaDesideratas (int first, int size)
{
        System.Collections.Generic.IList<DesiderataEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DesiderataEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DesiderataEN>();
                else
                        result = session.CreateCriteria (typeof(DesiderataEN)).List<DesiderataEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in DesiderataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<DesiderataEN> listarDesideratas()
{
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> result;
    int i = 0;
    try
    {
        SessionInitializeTransaction();
        String sql = @"FROM DesiderataEN";
        IQuery query = session.CreateQuery(sql);
        result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN>();
        SessionCommit();
    }

    catch (Exception ex)
    {
        SessionRollBack();
        if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
            throw ex;
        throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException("Error en DesiderataCAD.", ex);
    }
    finally
    {
        SessionClose();
    }
    return result;
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> ListaDesideratasPendientes(bool aceptada)
{
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> result;
    int i = 0;
    try
    {
        SessionInitializeTransaction();
        String sql = @"FROM DesiderataEN where aceptada =" + aceptada + "";
        //String sql = @"SELECT * FROM ObraEN";// p WHERE p.autor = autor";
        IQuery query = session.CreateQuery(sql);
        //IQuery oquery = (IQuery)session.GetNamedQuery("ObraENbuscaPorAutorHQL");
        //query.SetParameter("autor", autor);

        result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN>();
        SessionCommit();
        Console.WriteLine(result);
        for (i = 0; i < result.Count; i++)
        {
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
}
}