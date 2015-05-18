
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IPASCAD
{
PASEN ReadOIDDefault (string DNI);

System.Collections.Generic.IList<PASEN> ListarPAS (int first, int size);


string New_ (PASEN pAS);
}
}
