

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC
{
public partial class UsuarioCEN
{
private IUsuarioCAD _IUsuarioCAD;

public UsuarioCEN()
{
        this._IUsuarioCAD = new UsuarioCAD ();
}

public UsuarioCEN(IUsuarioCAD _IUsuarioCAD)
{
        this._IUsuarioCAD = _IUsuarioCAD;
}

public IUsuarioCAD get_IUsuarioCAD ()
{
        return this._IUsuarioCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, int p_telefono, string p_correo, int p_penalizacion, string p_contrasenya, bool p_logeado, int p_tipousuario)
{
        UsuarioEN usuarioEN = null;
        string oid;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.DNI = p_DNI;

        usuarioEN.Nombre = p_nombre;

        usuarioEN.Apellidos = p_apellidos;

        usuarioEN.Telefono = p_telefono;

        usuarioEN.Correo = p_correo;

        usuarioEN.Penalizacion = p_penalizacion;

        usuarioEN.Contrasenya = p_contrasenya;

        usuarioEN.Logeado = p_logeado;

        usuarioEN.Tipousuario = p_tipousuario;

        //Call to UsuarioCAD

        oid = _IUsuarioCAD.New_ (usuarioEN);
        return oid;
}

public void Modify (string p_Usuario_OID, string p_nombre, string p_apellidos, int p_telefono, string p_correo, int p_penalizacion, string p_contrasenya, bool p_logeado, int p_tipousuario)
{
        UsuarioEN usuarioEN = null;

        //Initialized UsuarioEN
        usuarioEN = new UsuarioEN ();
        usuarioEN.DNI = p_Usuario_OID;
        usuarioEN.Nombre = p_nombre;
        usuarioEN.Apellidos = p_apellidos;
        usuarioEN.Telefono = p_telefono;
        usuarioEN.Correo = p_correo;
        usuarioEN.Penalizacion = p_penalizacion;
        usuarioEN.Contrasenya = p_contrasenya;
        usuarioEN.Logeado = p_logeado;
        usuarioEN.Tipousuario = p_tipousuario;
        //Call to UsuarioCAD

        _IUsuarioCAD.Modify (usuarioEN);
}

public void Destroy (string DNI)
{
        _IUsuarioCAD.Destroy (DNI);
}

public UsuarioEN DameporOID (string DNI)
{
        UsuarioEN usuarioEN = null;

        usuarioEN = _IUsuarioCAD.DameporOID (DNI);
        return usuarioEN;
}

public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> DamePorNombre(string nombre)
{
    return _IUsuarioCAD.DamePorNombre(nombre);
}

public System.Collections.Generic.IList<UsuarioEN> ListaUsuarios (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> list = null;

        list = _IUsuarioCAD.ListaUsuarios (first, size);
        return list;
}
}
}
