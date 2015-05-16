
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IDesiderataCAD
{
DesiderataEN ReadOIDDefault (int id);

int New_ (DesiderataEN desiderata);

void Modify (DesiderataEN desiderata);


void Destroy (int id);


System.Collections.Generic.IList<DesiderataEN> ListaDesideratas (int first, int size);


System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> ListaDesideratasPendientes (bool aceptada);
}
}
