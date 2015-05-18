
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IDirectorCAD
{
DirectorEN ReadOIDDefault (string DNI);

string New_ (DirectorEN director);
}
}
