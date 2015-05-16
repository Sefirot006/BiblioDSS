<%@ Page Title="Página principal" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="InterfazV2._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Panel ID="Panel1"  runat="server">
        <div id="formularioBusqueda">
            <asp:Label ID="Label1"  runat="server" Text="Buscar: "></asp:Label>
            <asp:TextBox ID="textBox"  runat="server" MaxLength="100"  style="width:400px" ></asp:TextBox>
            <asp:Button ID="Button1"  runat="server" Text="Buscar"/></asp:Button>
        </div>
    </asp:Panel>
</asp:Content>
