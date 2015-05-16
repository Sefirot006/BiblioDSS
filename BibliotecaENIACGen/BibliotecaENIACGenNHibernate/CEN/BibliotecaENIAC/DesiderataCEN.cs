

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
public partial class DesiderataCEN
{
private IDesiderataCAD _IDesiderataCAD;

public DesiderataCEN()
{
        this._IDesiderataCAD = new DesiderataCAD ();
}

public DesiderataCEN(IDesiderataCAD _IDesiderataCAD)
{
        this._IDesiderataCAD = _IDesiderataCAD;
}

public IDesiderataCAD get_IDesiderataCAD ()
{
        return this._IDesiderataCAD;
}

public int New_ (string p_autor, string p_titulo, string p_editorial, short p_año, string p_usuario, bool p_aceptada)
{
        DesiderataEN desiderataEN = null;
        int oid;

        //Initialized DesiderataEN
        desiderataEN = new DesiderataEN ();
        desiderataEN.Autor = p_autor;

        desiderataEN.Titulo = p_titulo;

        desiderataEN.Editorial = p_editorial;

        desiderataEN.Año = p_año;


        if (p_usuario != null) {
                desiderataEN.Usuario = new BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN ();
                desiderataEN.Usuario.DNI = p_usuario;
        }

        desiderataEN.Aceptada = p_aceptada;

        //Call to DesiderataCAD

        oid = _IDesiderataCAD.New_ (desiderataEN);
        return oid;
}

public void Modify (int p_Desiderata_OID, string p_autor, string p_titulo, string p_editorial, short p_año, bool p_aceptada)
{
        DesiderataEN desiderataEN = null;

        //Initialized DesiderataEN
        desiderataEN = new DesiderataEN ();
        desiderataEN.Id = p_Desiderata_OID;
        desiderataEN.Autor = p_autor;
        desiderataEN.Titulo = p_titulo;
        desiderataEN.Editorial = p_editorial;
        desiderataEN.Año = p_año;
        desiderataEN.Aceptada = p_aceptada;
        //Call to DesiderataCAD

        _IDesiderataCAD.Modify (desiderataEN);
}

public void Destroy (int id)
{
        _IDesiderataCAD.Destroy (id);
}

public System.Collections.Generic.IList<DesiderataEN> ListaDesideratas (int first, int size)
{
        System.Collections.Generic.IList<DesiderataEN> list = null;

        list = _IDesiderataCAD.ListaDesideratas (first, size);
        return list;
}
public System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> ListaDesideratasPendientes (bool aceptada)
{
        return _IDesiderataCAD.ListaDesideratasPendientes (aceptada);
}
}
}
