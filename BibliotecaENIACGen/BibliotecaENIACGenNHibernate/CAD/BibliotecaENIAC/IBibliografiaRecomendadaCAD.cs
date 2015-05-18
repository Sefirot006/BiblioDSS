
using System;
using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC
{
public partial interface IBibliografiaRecomendadaCAD
{
BibliografiaRecomendadaEN ReadOIDDefault (int idSocioObras);

int New_ (BibliografiaRecomendadaEN bibliografiaRecomendada);

void Modify (BibliografiaRecomendadaEN bibliografiaRecomendada);


void Destroy (int idSocioObras);
}
}
