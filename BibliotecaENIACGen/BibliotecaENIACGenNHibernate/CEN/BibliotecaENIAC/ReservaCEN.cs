

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
public partial class ReservaCEN
{
private IReservaCAD _IReservaCAD;

public ReservaCEN()
{
        this._IReservaCAD = new ReservaCAD ();
}

public ReservaCEN(IReservaCAD _IReservaCAD)
{
        this._IReservaCAD = _IReservaCAD;
}

public IReservaCAD get_IReservaCAD ()
{
        return this._IReservaCAD;
}

public string New_ (string p_idReserva, Nullable<DateTime> p_fechaVencimiento, Nullable<DateTime> p_fechaInicio, string p_usuario)
{
        ReservaEN reservaEN = null;
        string oid;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.IdReserva = p_idReserva;

        reservaEN.FechaVencimiento = p_fechaVencimiento;

        reservaEN.FechaInicio = p_fechaInicio;


        if (p_usuario != null) {
                reservaEN.Usuario = new BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN ();
                reservaEN.Usuario.DNI = p_usuario;
        }

        //Call to ReservaCAD

        oid = _IReservaCAD.New_ (reservaEN);
        return oid;
}

public void Modify (string p_Reserva_OID, Nullable<DateTime> p_fechaVencimiento, Nullable<DateTime> p_fechaInicio)
{
        ReservaEN reservaEN = null;

        //Initialized ReservaEN
        reservaEN = new ReservaEN ();
        reservaEN.IdReserva = p_Reserva_OID;
        reservaEN.FechaVencimiento = p_fechaVencimiento;
        reservaEN.FechaInicio = p_fechaInicio;
        //Call to ReservaCAD

        _IReservaCAD.Modify (reservaEN);
}

public void Destroy (string idReserva)
{
        _IReservaCAD.Destroy (idReserva);
}

public System.Collections.Generic.IList<ReservaEN> ListaReservas (int first, int size)
{
        System.Collections.Generic.IList<ReservaEN> list = null;

        list = _IReservaCAD.ListaReservas (first, size);
        return list;
}
}
}
