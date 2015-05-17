
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IAutorCAD
{
AutorEN ReadOIDDefault (string nombre);

string New_ (AutorEN autor);

void Modify (AutorEN autor);


void Destroy (string nombre);


System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> BuscarAutor (System.Collections.Generic.IList<string> autor);
System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN> BuscarAutor();

}
}
