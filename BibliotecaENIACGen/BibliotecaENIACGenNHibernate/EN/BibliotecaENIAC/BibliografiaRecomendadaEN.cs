
using System;

namespace BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC
{
public partial class BibliografiaRecomendadaEN
{
/**
 *
 */

private int idSocioObras;

/**
 *
 */

private System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> usuario;

/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN tem;

/**
 *
 */

private BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN autor;





public virtual int IdSocioObras {
        get { return idSocioObras; } set { idSocioObras = value;  }
}


public virtual System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> Usuario {
        get { return usuario; } set { usuario = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN Tem {
        get { return tem; } set { tem = value;  }
}


public virtual BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN Autor {
        get { return autor; } set { autor = value;  }
}





public BibliografiaRecomendadaEN()
{
        usuario = new System.Collections.Generic.List<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN>();
}



public BibliografiaRecomendadaEN(int idSocioObras, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> usuario, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN tem, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN autor)
{
        this.init (idSocioObras, usuario, tem, autor);
}


public BibliografiaRecomendadaEN(BibliografiaRecomendadaEN bibliografiaRecomendada)
{
        this.init (bibliografiaRecomendada.IdSocioObras, bibliografiaRecomendada.Usuario, bibliografiaRecomendada.Tem, bibliografiaRecomendada.Autor);
}

private void init (int idSocioObras, System.Collections.Generic.IList<BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.UsuarioEN> usuario, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.TematicaEN tem, BibliotecaENIACGenNHibernate.EN.BibliotecaENIAC.AutorEN autor)
{
        this.IdSocioObras = idSocioObras;


        this.Usuario = usuario;

        this.Tem = tem;

        this.Autor = autor;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        BibliografiaRecomendadaEN t = obj as BibliografiaRecomendadaEN;
        if (t == null)
                return false;
        if (IdSocioObras.Equals (t.IdSocioObras))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.IdSocioObras.GetHashCode ();
        return hash;
}
}
}
