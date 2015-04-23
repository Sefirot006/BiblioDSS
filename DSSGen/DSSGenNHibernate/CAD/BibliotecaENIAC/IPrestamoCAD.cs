
using System;
using DSSGenNHibernate.EN.BibliotecaENIAC;

namespace DSSGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IPrestamoCAD
{
PrestamoEN ReadOIDDefault (string idPrestamo);

string New_ (PrestamoEN prestamo);

void Modify (PrestamoEN prestamo);


void Destroy (string idPrestamo);


System.Collections.Generic.IList<PrestamoEN> VisualizarPrestamo (int first, int size);



PrestamoEN BuscarPrestamo (string idPrestamo);
}
}