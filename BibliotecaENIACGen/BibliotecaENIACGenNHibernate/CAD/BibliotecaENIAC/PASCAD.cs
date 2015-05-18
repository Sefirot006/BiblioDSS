
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
public partial class PASCAD : BasicCAD, IPASCAD
{
public PASCAD() : base ()
{
}

public PASCAD(ISession sessionAux) : base (sessionAux)
{
}



public PASEN ReadOIDDefault (string DNI)
{
        PASEN pASEN = null;

        try
        {
                SessionInitializeTransaction ();
                pASEN = (PASEN)session.Get (typeof(PASEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PASCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pASEN;
}


public System.Collections.Generic.IList<PASEN> ListarPAS (int first, int size)
{
        System.Collections.Generic.IList<PASEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PASEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PASEN>();
                else
                        result = session.CreateCriteria (typeof(PASEN)).List<PASEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PASCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public string New_ (PASEN pAS)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (pAS);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in PASCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pAS.DNI;
}
}
}
