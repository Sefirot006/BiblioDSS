

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
public partial class DirectorCEN
{
private IDirectorCAD _IDirectorCAD;

public DirectorCEN()
{
        this._IDirectorCAD = new DirectorCAD ();
}

public DirectorCEN(IDirectorCAD _IDirectorCAD)
{
        this._IDirectorCAD = _IDirectorCAD;
}

public IDirectorCAD get_IDirectorCAD ()
{
        return this._IDirectorCAD;
}

public string New_ (string p_DNI, string p_nombre, string p_apellidos, int p_telefono, string p_correo, int p_penalizacion, string p_contrasenya, bool p_logeado, int p_tipousuario)
{
        DirectorEN directorEN = null;
        string oid;

        //Initialized DirectorEN
        directorEN = new DirectorEN ();
        directorEN.DNI = p_DNI;

        directorEN.Nombre = p_nombre;

        directorEN.Apellidos = p_apellidos;

        directorEN.Telefono = p_telefono;

        directorEN.Correo = p_correo;

        directorEN.Penalizacion = p_penalizacion;

        directorEN.Contrasenya = p_contrasenya;

        directorEN.Logeado = p_logeado;

        directorEN.Tipousuario = p_tipousuario;

        //Call to DirectorCAD

        oid = _IDirectorCAD.New_ (directorEN);
        return oid;
}
}
}
