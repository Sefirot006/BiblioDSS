

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
public partial class EjemplarCEN
{
private IEjemplarCAD _IEjemplarCAD;

public EjemplarCEN()
{
        this._IEjemplarCAD = new EjemplarCAD ();
}

public EjemplarCEN(IEjemplarCAD _IEjemplarCAD)
{
        this._IEjemplarCAD = _IEjemplarCAD;
}

public IEjemplarCAD get_IEjemplarCAD ()
{
        return this._IEjemplarCAD;
}

public int New_ (bool p_prestado, bool p_reservado, string p_obra)
{
        EjemplarEN ejemplarEN = null;
        int oid;

        //Initialized EjemplarEN
        ejemplarEN = new EjemplarEN ();
        ejemplarEN.Prestado = p_prestado;

        ejemplarEN.Reservado = p_reservado;


        if (p_obra != null) {
                ejemplarEN.Obra = new BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN ();
                ejemplarEN.Obra.Isbn = p_obra;
        }

        //Call to EjemplarCAD

        oid = _IEjemplarCAD.New_ (ejemplarEN);
        return oid;
}

public void Modify (int p_Ejemplar_OID, bool p_prestado, bool p_reservado)
{
        EjemplarEN ejemplarEN = null;

        //Initialized EjemplarEN
        ejemplarEN = new EjemplarEN ();
        ejemplarEN.Id = p_Ejemplar_OID;
        ejemplarEN.Prestado = p_prestado;
        ejemplarEN.Reservado = p_reservado;
        //Call to EjemplarCAD

        _IEjemplarCAD.Modify (ejemplarEN);
}

public void Destroy (int id)
{
        _IEjemplarCAD.Destroy (id);
}
}
}
