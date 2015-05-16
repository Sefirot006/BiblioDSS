<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="InterfazV2._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent"> 
</asp:Content>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Panel ID="Panel1"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click">Iniciar sesión</asp:LinkButton> 
        </div>
        <div id="formularioBusqueda">
            <asp:Label ID="Label1"  runat="server" Text="Buscar: "></asp:Label>
            <asp:TextBox ID="textBox"  runat="server" MaxLength="100"  style="width:400px" ></asp:TextBox>
            <br />
            <a>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</a>
            <asp:Button ID="Button1"  Width=130px runat="server" Text="Buscar Por Autor" OnClick="mostrarObrasA_click"/></asp:Button>
            <asp:Button ID="Button2"  Width=130px runat="server" Text="Buscar Por Título" OnClick="mostrarObrasN_click"/></asp:Button>
            <asp:Button ID="Button3"  Width=134px runat="server" Text="Buscar Por Temática" OnClick="mostrarObrasT_click"/></asp:Button>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2"  runat="server" style="top:300px;">
        <div id="Div1">
            
        </div>
    </asp:Panel>
</asp:Content>
