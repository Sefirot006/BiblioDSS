
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
public partial class BibliografiaRecomendadaCEN
{
public void Listaobras (int p_oid)
{
        /*PROTECTED REGION ID(BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC_BibliografiaRecomendada_listaobras) ENABLED START*/

        // Write here your custom code...
        // Hay que a asegurarnos de que devuelve una lista y no lanza una excepci�n en el acceso al CAD.
        //return (_IBibliografiaRecomendadaCAD.Listaobras());

        throw new NotImplementedException ("Method Listaobras() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
