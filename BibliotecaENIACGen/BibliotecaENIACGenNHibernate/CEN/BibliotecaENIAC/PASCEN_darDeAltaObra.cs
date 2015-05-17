
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
public BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ObraEN DarDeAltaObra (string id, string p_nombre, short p_paginas, short p_anyo, string imagen, string pAS)
{
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.ReservaEN> reserva = null;
    System.Collections.Generic.IList<String> escrita = null;
    System.Collections.Generic.IList<String> tematica = null;
    System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.EjemplarEN> ejemplar = null;
    ObraCEN obra = new ObraCEN();
    ObraEN o = new ObraEN();
    obra.New_(id, p_nombre, p_paginas,  escrita, tematica, p_anyo, imagen);
   
    return o;


}
}
}
