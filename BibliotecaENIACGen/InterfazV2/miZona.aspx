
<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="miZona.aspx.cs" Inherits="InterfazV2.miZona" %>

  
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent" >


    
  
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
    <asp:Panel ID="Panel3"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click">Iniciar sesión</asp:LinkButton> 
        </div>
        <div id="formularioBusqueda">
          
        </div>
    </asp:Panel>
    <asp:Panel ID="PanelmiZona"  runat="server" style="top:300px;">
        
        <div id="Div1">
            
        </div>
    </asp:Panel>
</asp:Content>


