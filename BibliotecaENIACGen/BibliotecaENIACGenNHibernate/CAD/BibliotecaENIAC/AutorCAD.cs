
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
public partial class AutorCAD : BasicCAD, IAutorCAD
{
public AutorCAD() : base ()
{
}

public AutorCAD(ISession sessionAux) : base (sessionAux)
{
}



public AutorEN ReadOIDDefault (string nombre)
{
        AutorEN autorEN = null;

        try
        {
                SessionInitializeTransaction ();
                autorEN = (AutorEN)session.Get (typeof(AutorEN), nombre);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return autorEN;
}


public string New_ (AutorEN autor)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (autor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return autor.Nombre;
}

public void Modify (AutorEN autor)
{
        try
        {
                SessionInitializeTransaction ();
                AutorEN autorEN = (AutorEN)session.Load (typeof(AutorEN), autor.Nombre);
                autorEN.Escribe = autor.Escribe;
                session.Update (autorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
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
                AutorEN autorEN = (AutorEN)session.Load (typeof(AutorEN), nombre);
                session.Delete (autorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> BuscarAutor (System.Collections.Generic.IList<string> autor)
{
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> result;
    int i = 0;
    try
    {
        SessionInitializeTransaction();

        String sql = @"FROM AutorEN ";
        for (i = 0; i < autor.Count; i++)
        {
            if (i == 0)
            {
                sql += "where nombre ='" + autor[i] + "'";
            }
            else
            {
                sql += "or nombre ='" + autor[i] + "'";
            }
        }
        //String sql = @"SELECT * FROM ObraEN";// p WHERE p.autor = autor";
        IQuery query = session.CreateQuery(sql);
        //IQuery oquery = (IQuery)session.GetNamedQuery("ObraENbuscaPorAutorHQL");
        //query.SetParameter("autor", autor);

        result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();
        SessionCommit();
        Console.WriteLine(result);
        for (i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i].Escribe.Count);
            
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
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> BuscarAutor()
{
    int i= 0;
    System.Collections.Generic.IList < BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN > salida =  null;
    try
    {
        SessionInitializeTransaction();
        String sql = @"FROM AutorEN";
        //String sql = @"SELECT * FROM ObraEN";// p WHERE p.autor = autor";
        IQuery query = session.CreateQuery(sql);
        //IQuery oquery = (IQuery)session.GetNamedQuery("ObraENbuscaPorAutorHQL");
        //query.SetParameter("autor", autor);
        
        salida = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();
        for (i = 0; i < salida.Count;i++ )
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
