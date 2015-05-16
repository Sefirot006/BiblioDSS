
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
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AutorEN self where FROM AutorEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AutorENbuscarAutorHQL");
                query.SetParameter ("autor", autor);

                result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN>();
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

        return result;
}
}
}
