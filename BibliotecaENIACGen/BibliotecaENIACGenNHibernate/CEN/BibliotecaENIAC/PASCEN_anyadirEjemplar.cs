
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC
{
public partial class PASCEN
{
public void AnyadirEjemplar (BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN ejemplar, string pAS)
{
    EjemplarCEN ejem = new EjemplarCEN();

    ejem.New_(false, false, ejemplar.Obra.Isbn);
    
}
}
}
