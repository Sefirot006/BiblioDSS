
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
            /*PROTECTED REGION ID(BibliotecaENIACGenNHibernate.CEN.BibliotecaENIAC_Usuario_logearse) ENABLED START*/

            // Write here your custom code...

            System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> result = null;
            result = _IUsuarioCAD.DamePorNombre(p_oid);
            if (result != null && result.Count != 0)
            {
                foreach (UsuarioEN usuario in result)
                    if (usuario.Nombre == p_oid && usuario.Contrasenya == contrasenya)
                        return true;
            }
            return false;

            /*PROTECTED REGION END*/
        }
    }
}
