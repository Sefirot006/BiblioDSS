
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
public partial class ObraCAD : BasicCAD, IObraCAD
{
public ObraCAD() : base ()
{
}

public ObraCAD(ISession sessionAux) : base (sessionAux)
{
}



public ObraEN ReadOIDDefault (string Isbn)
{
        ObraEN obraEN = null;

        try
        {
                SessionInitializeTransaction ();
                obraEN = (ObraEN)session.Get (typeof(ObraEN), Isbn);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return obraEN;
}


public string New_ (ObraEN obra)
{
        try
        {
                SessionInitializeTransaction ();
                if (obra.Escrita != null) {
                        for (int i = 0; i < obra.Escrita.Count; i++) {
                                obra.Escrita [i] = (BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN)session.Load (typeof(BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN), obra.Escrita [i].Nombre);
                                obra.Escrita [i].Escribe.Add (obra);
                        }
                }
                if (obra.Tematica != null) {
                        for (int i = 0; i < obra.Tematica.Count; i++) {
                                obra.Tematica [i] = (BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN)session.Load (typeof(BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN), obra.Tematica [i].Nombre);
                                obra.Tematica [i].Obra.Add (obra);
                        }
                }

                session.Save (obra);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return obra.Isbn;
}

public void Modify (ObraEN obra)
{
        try
        {
                SessionInitializeTransaction ();
                ObraEN obraEN = (ObraEN)session.Load (typeof(ObraEN), obra.Isbn);

                obraEN.Nombre = obra.Nombre;


                obraEN.Paginas = obra.Paginas;


                obraEN.Anyo = obra.Anyo;


                obraEN.Imagen = obra.Imagen;

                session.Update (obraEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string Isbn)
{
        try
        {
                SessionInitializeTransaction ();
                ObraEN obraEN = (ObraEN)session.Load (typeof(ObraEN), Isbn);
                session.Delete (obraEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ObraEN> ListarObras (int first, int size)
{
        System.Collections.Generic.IList<ObraEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ObraEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ObraEN>();
                else
                        result = session.CreateCriteria (typeof(ObraEN)).List<ObraEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public ObraEN BuscaPorId (string Isbn)
{
        ObraEN obraEN = null;

        try
        {
                SessionInitializeTransaction ();
                obraEN = (ObraEN)session.Get (typeof(ObraEN), Isbn);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return obraEN;
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorNombre (string nombre)
{
        System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObraEN self where FROM ObraEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObraENbuscaPorNombreHQL");
                query.SetParameter ("nombre", nombre);

                result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorAutor (string autor)
{
        System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObraEN self where FROM ObraEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObraENbuscaPorAutorHQL");
                query.SetParameter ("autor", autor);

                result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> BuscaPorTematica (string tema)
{
        System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM ObraEN self where FROM ObraEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("ObraENbuscaPorTematicaHQL");
                query.SetParameter ("tema", tema);

                result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in ObraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
