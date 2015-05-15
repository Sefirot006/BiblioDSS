
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC;
using BibliotecaENIACGenNHibernate.CAD.BibliotecaENIAC;

namespace BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC
{
    public partial class UsuarioCEN
    {
        public bool Logearse(string p_oid, string contrasenya)
        {
            bool result = false;
            UsuarioEN usuario = _IUsuarioCAD.DameporOID(p_oid);
            if (usuario != null)
            {
                if (usuario.Contrasenya.Equals(contrasenya))
                {
                    result = true;
                    usuario.Logeado = true;
                } 
                else
                    usuario.Logeado = false;
            }
            return result;
        }
    }
}
