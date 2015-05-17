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
            <a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" 
                OnClick="mostrarObrasA_click" Text="Buscar Por Autor" Width="130px" />
            &nbsp;<asp:Button ID="Button2" runat="server" OnClick="mostrarObrasN_click" 
                Text="Buscar Por Título" Width="130px" />
            &nbsp;<asp:Button ID="Button3" runat="server" OnClick="mostrarObrasT_click" 
                Text="Buscar Por Temática" Width="134px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</a>
            </asp:Button>
            </asp:Button>
            </asp:Button>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel2"  runat="server" style="top:300px;">
        <div id="Div1">
            
        </div>
    </asp:Panel>
</asp:Content>
