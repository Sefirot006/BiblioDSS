
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IUsuarioCAD
{
UsuarioEN ReadOIDDefault (string DNI);

string New_ (UsuarioEN usuario);

void Modify (UsuarioEN usuario);

void Destroy (string DNI);

UsuarioEN DameporOID (string DNI);

System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> DamePorNombre(string nombre);

System.Collections.Generic.IList<UsuarioEN> ListaUsuarios (int first, int size);
}
}
