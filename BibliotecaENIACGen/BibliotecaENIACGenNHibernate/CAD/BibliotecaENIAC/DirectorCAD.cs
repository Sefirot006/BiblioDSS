
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
public partial class DirectorCAD : BasicCAD, IDirectorCAD
{
public DirectorCAD() : base ()
{
}

public DirectorCAD(ISession sessionAux) : base (sessionAux)
{
}



public DirectorEN ReadOIDDefault (string DNI)
{
        DirectorEN directorEN = null;

        try
        {
                SessionInitializeTransaction ();
                directorEN = (DirectorEN)session.Get (typeof(DirectorEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in DirectorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return directorEN;
}


public string New_ (DirectorEN director)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (director);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in DirectorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return director.DNI;
}
}
}
