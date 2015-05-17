
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
public partial class SocioCAD : BasicCAD, ISocioCAD
{
public SocioCAD() : base ()
{
}

public SocioCAD(ISession sessionAux) : base (sessionAux)
{
}



public SocioEN ReadOIDDefault (string DNI)
{
        SocioEN socioEN = null;

        try
        {
                SessionInitializeTransaction ();
                socioEN = (SocioEN)session.Get (typeof(SocioEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in SocioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return socioEN;
}


public System.Collections.Generic.IList<SocioEN> Listasocios (int first, int size)
{
        System.Collections.Generic.IList<SocioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SocioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SocioEN>();
                else
                        result = session.CreateCriteria (typeof(SocioEN)).List<SocioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in SocioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public string New_ (SocioEN socio)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (socio);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in SocioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return socio.DNI;
}
}
}
