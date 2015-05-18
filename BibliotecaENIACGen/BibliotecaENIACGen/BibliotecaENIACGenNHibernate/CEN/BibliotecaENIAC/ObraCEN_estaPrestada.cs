
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
public partial class ObraCEN
{
public bool EstaPrestada (string p_oid)
{
        /*PROTECTED REGION ID(BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC_Obra_estaPrestada) ENABLED START*/
        throw new Exception("No implementado todavía...");
        //return (_IObraCAD.BuscaPorId (p_oid)).Prestado;
        // Write here your custom code...
        /*
         * bool result = false;
         * ObraEN obra = _IObraCAD.BuscaPorId (p_oid);
         * if (obra.Prestado.Equals (true)) {
         *      result = true;
         * }
         * return result;
         */
        /*PROTECTED REGION END*/
}
}
}
