
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
public partial class PASCEN
{
public void AceptarDesiderata (string p_oid)
{
        /*PROTECTED REGION ID(BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC_PAS_aceptarDesiderata) ENABLED START*/

        // Write here your custom code...

    DesiderataCEN desiCEN = new DesiderataCEN();
    DesiderataEN desiEN = new DesiderataEN();
    DesiderataCAD desiCAD = new DesiderataCAD();


    desiEN = desiCAD.ReadOIDDefault(Convert.ToInt32(p_oid));
    desiCEN.Modify(desiEN.Id, desiEN.Autor, desiEN.Titulo, desiEN.Editorial, desiEN.Año, true);

        /*PROTECTED REGION END*/
}
}
}
