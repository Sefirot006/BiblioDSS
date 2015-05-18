
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IReservaCAD
{
ReservaEN ReadOIDDefault (string idReserva);

string New_ (ReservaEN reserva);

void Modify (ReservaEN reserva);


void Destroy (string idReserva);


System.Collections.Generic.IList<ReservaEN> ListaReservas (int first, int size);
}
}
