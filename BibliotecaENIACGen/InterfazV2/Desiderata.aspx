<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Desiderata.aspx.cs" Inherits="InterfazV2.Desiderata" %>

<asp:Content ID="HeaderContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1"  runat="server">
        <div align="right"> 
            <asp:Label ID="labelUsuario" runat="server" Text=""></asp:Label> 
            <asp:LinkButton ID="linkSalir" runat="server" onclick="linkSalir_Click">Iniciar sesión</asp:LinkButton> 
        </div>
        <div id = "general" align="center">

        <div id = "contenido_login">
            <table>
                <tr>
                    <td align="center" rowspan="1" style="font-size: 20px"> FORMULARIO DESIDERATA </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> Autor: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtAutor" runat="server" Width="250px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Título: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtTitulo" runat="server" Width="250px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Editorial: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtEditorial" runat="server" Width="250px"></asp:TextBox> </td>
                </tr>

                <tr>
                    <td colspan="2" align="left"> Año: </td>
                </tr>
                <tr>
                    <td colspan="2" align="left"> <asp:TextBox ID="txtAno" runat="server" Width="250px"></asp:TextBox> </td>
                </tr>
                
                <tr>
                    <td colspan="2" align="center"> 
                        <asp:Label ID="labelError" runat="server" Text="" ForeColor="Red" Visible="false"> </asp:Label> </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnAceptar" runat="server" 
                            Text="Enviar Solicitud" Width="150px" onclick="btnAceptar_Click"/>
                    </td>
                </tr>
            </table>
        
        </div>
    
    </div>    
    </asp:Panel>

</asp:Content>
