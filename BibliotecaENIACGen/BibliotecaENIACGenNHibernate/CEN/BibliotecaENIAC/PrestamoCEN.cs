

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
public partial class PrestamoCEN
{
private IPrestamoCAD _IPrestamoCAD;

public PrestamoCEN()
{
        this._IPrestamoCAD = new PrestamoCAD ();
}

public PrestamoCEN(IPrestamoCAD _IPrestamoCAD)
{
        this._IPrestamoCAD = _IPrestamoCAD;
}

public IPrestamoCAD get_IPrestamoCAD ()
{
        return this._IPrestamoCAD;
}

public string New_ (string p_idPrestamo, Nullable<DateTime> p_fechaVencimiento, Nullable<DateTime> p_fechaInicio, int p_ejemplar)
{
        PrestamoEN prestamoEN = null;
        string oid;

        //Initialized PrestamoEN
        prestamoEN = new PrestamoEN ();
        prestamoEN.IdPrestamo = p_idPrestamo;

        prestamoEN.FechaVencimiento = p_fechaVencimiento;

        prestamoEN.FechaInicio = p_fechaInicio;


        if (p_ejemplar != -1) {
                prestamoEN.Ejemplar = new BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN ();
                prestamoEN.Ejemplar.Id = p_ejemplar;
        }

        //Call to PrestamoCAD

        oid = _IPrestamoCAD.New_ (prestamoEN);
        return oid;
}

public void Modify (string p_Prestamo_OID, Nullable<DateTime> p_fechaVencimiento, Nullable<DateTime> p_fechaInicio)
{
        PrestamoEN prestamoEN = null;

        //Initialized PrestamoEN
        prestamoEN = new PrestamoEN ();
        prestamoEN.IdPrestamo = p_Prestamo_OID;
        prestamoEN.FechaVencimiento = p_fechaVencimiento;
        prestamoEN.FechaInicio = p_fechaInicio;
        //Call to PrestamoCAD

        _IPrestamoCAD.Modify (prestamoEN);
}

public void Destroy (string idPrestamo)
{
        _IPrestamoCAD.Destroy (idPrestamo);
}

public System.Collections.Generic.IList<PrestamoEN> ListarPrestamos (int first, int size)
{
        System.Collections.Generic.IList<PrestamoEN> list = null;

        list = _IPrestamoCAD.ListarPrestamos (first, size);
        return list;
}
public PrestamoEN BuscarPrestamo (string idPrestamo)
{
        PrestamoEN prestamoEN = null;

        prestamoEN = _IPrestamoCAD.BuscarPrestamo (idPrestamo);
        return prestamoEN;
}
}
}
