
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
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (string DNI)
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}


public string New_ (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.Nombre;
}

public void Modify (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.DNI);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Apellidos = usuario.Apellidos;


                usuarioEN.Telefono = usuario.Telefono;


                usuarioEN.Correo = usuario.Correo;


                usuarioEN.Penalizacion = usuario.Penalizacion;

                usuarioEN.Contrasenya = usuario.Contrasenya;

                usuarioEN.Logeado = usuario.Logeado;

                usuarioEN.Tipousuario = usuario.Tipousuario;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (string DNI)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), DNI);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public UsuarioEN DameporOID (string DNI)
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), DNI);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> DamePorNombre(string nombre)
{
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> result;
    try
    {
        SessionInitializeTransaction();
        String sql = @"FROM UsuarioEN where nombre like'%" + nombre + "%'";
        IQuery query = session.CreateQuery(sql);
        result = query.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN>();
        SessionCommit();
    }
    catch (Exception ex)
    {
        SessionRollBack();
        if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
            throw ex;
        throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException("Error in UsuarioCAD.", ex);
    }
    finally
    {
        SessionClose();
    }
    return result;
}

public UsuarioEN dameUsuario(string nombre, string contrasenya)
{
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> result = null;
    result = DamePorNombre(nombre);
    if (result != null && result.Count != 0)
    {
        foreach (UsuarioEN usuario in result)
            if (usuario.Nombre == nombre && usuario.Contrasenya == contrasenya)
                return usuario;
    }
    return null;
}

public System.Collections.Generic.IList<UsuarioEN> ListaUsuarios (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is BibliotecaENIACGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new BibliotecaENIACGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
