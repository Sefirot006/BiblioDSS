
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IEjemplarCAD
{
EjemplarEN ReadOIDDefault (int id);

int New_ (EjemplarEN ejemplar);

void Modify (EjemplarEN ejemplar);


void Destroy (int id);
}
}
