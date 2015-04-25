
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
public partial class PrestamoCAD : BasicCAD, IPrestamoCAD
{
public PrestamoCAD() : base ()
{
}

public PrestamoCAD(ISession sessionAux) : base (sessionAux)
{
}



public PrestamoEN ReadOIDDefault (string idPrestamo)
{
        PrestamoEN prestamoEN = null;

        try
        {
                SessionInitializeTransaction ();
                prestamoEN = (PrestamoEN)session.Get (typeof(PrestamoEN), idPrestamo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PrestamoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return prestamoEN;
}


public string New_ (PrestamoEN prestamo)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (prestamo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PrestamoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return prestamo.IdPrestamo;
}

public void Modify (PrestamoEN prestamo)
{
        try
        {
                SessionInitializeTransaction ();
                PrestamoEN prestamoEN = (PrestamoEN)session.Load (typeof(PrestamoEN), prestamo.IdPrestamo);

                prestamoEN.FechaVencimiento = prestamo.FechaVencimiento;


                prestamoEN.FechaInicio = prestamo.FechaInicio;

                session.Update (prestamoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PrestamoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string idPrestamo)
{
        try
        {
                SessionInitializeTransaction ();
                PrestamoEN prestamoEN = (PrestamoEN)session.Load (typeof(PrestamoEN), idPrestamo);
                session.Delete (prestamoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PrestamoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<PrestamoEN> VisualizarPrestamo (int first, int size)
{
        System.Collections.Generic.IList<PrestamoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PrestamoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PrestamoEN>();
                else
                        result = session.CreateCriteria (typeof(PrestamoEN)).List<PrestamoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PrestamoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public PrestamoEN BuscarPrestamo (string idPrestamo)
{
        PrestamoEN prestamoEN = null;

        try
        {
                SessionInitializeTransaction ();
                prestamoEN = (PrestamoEN)session.Get (typeof(PrestamoEN), idPrestamo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PrestamoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return prestamoEN;
}
}
}
