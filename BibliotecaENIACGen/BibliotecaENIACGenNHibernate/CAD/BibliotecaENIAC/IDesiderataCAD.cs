
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IDesiderataCAD
{
DesiderataEN ReadOIDDefault (int id);

int New_ (DesiderataEN desiderata);

// New_(string p_autor, string p_titulo, string p_editorial, short p_año, string p_usuario, bool p_aceptada);

void Modify (DesiderataEN desiderata);


void Destroy (int id);


System.Collections.Generic.IList<DesiderataEN> ListaDesideratas (int first, int size);

System.Collections.Generic.IList<DesiderataEN> listarDesideratas();

System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.DesiderataEN> ListaDesideratasPendientes (bool aceptada);
}
}
