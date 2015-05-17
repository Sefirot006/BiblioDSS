
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
public partial class EjemplarCAD : BasicCAD, IEjemplarCAD
{
public EjemplarCAD() : base ()
{
}

public EjemplarCAD(ISession sessionAux) : base (sessionAux)
{
}



public EjemplarEN ReadOIDDefault (int id)
{
        EjemplarEN ejemplarEN = null;

        try
        {
                SessionInitializeTransaction ();
                ejemplarEN = (EjemplarEN)session.Get (typeof(EjemplarEN), id);

                
                    Console.WriteLine(ejemplarEN.Obra);
              
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in EjemplarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ejemplarEN;
}


public int New_ (EjemplarEN ejemplar)
{
        try
        {
                SessionInitializeTransaction ();
                if (ejemplar.Obra != null) {
                        ejemplar.Obra = (BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN)session.Load (typeof(BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN), ejemplar.Obra.Isbn);

                        ejemplar.Obra.Ejemplar.Add (ejemplar);
                }

                session.Save (ejemplar);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in EjemplarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ejemplar.Id;
}

public void Modify (EjemplarEN ejemplar)
{
        try
        {
                SessionInitializeTransaction ();
                EjemplarEN ejemplarEN = (EjemplarEN)session.Load (typeof(EjemplarEN), ejemplar.Id);

                ejemplarEN.Prestado = ejemplar.Prestado;
                

                ejemplarEN.Reservado = ejemplar.Reservado;

                session.Update (ejemplarEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in EjemplarCAD.", ex);
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
                EjemplarEN ejemplarEN = (EjemplarEN)session.Load (typeof(EjemplarEN), id);
                session.Delete (ejemplarEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in EjemplarCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
